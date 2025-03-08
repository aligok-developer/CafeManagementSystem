using System.Linq;
using System.Windows.Forms;
using System;

namespace BarkodluSatis
{
    public partial class frmVeresiyeTakip : Form
    {
        public frmVeresiyeTakip()
        {
            InitializeComponent();
        }

        private void frmVeresiyeTakip_Load(object sender, EventArgs e)
        {
            MusteriListesiniGuncelle();
        }

        private void MusteriListesiniGuncelle()
        {
            using (var db = new BarkodDbEntities())
            {
                // Sadece Borç işlemlerini al
                var toplamBorcListesi = from v in db.musteriVeresiye
                                        where v.IslemTuru == "ToplamBorc"
                                        group v by new { v.ID, v.Ad, v.Telefon, v.Adres } into g
                                        select new
                                        {
                                            MusteriID = g.Key.ID,
                                            MusteriAd = g.Key.Ad,
                                            Telefon = g.Key.Telefon,
                                            Adres = g.Key.Adres,
                                            ToplamBorc = g.Sum(x => (decimal?)x.BorcTutari) ?? 0 // Sadece borç toplamı
                                        };

                // ToplamBorc'a göre azalan sıralama (en büyük borç önce gelir)
                var sortedList = toplamBorcListesi.OrderByDescending(x => x.ToplamBorc).ToList();

                dataGridViewVeresiye.DataSource = sortedList;

                // Sütun başlıklarını ayarla
                dataGridViewVeresiye.Columns["MusteriAd"].HeaderText = "Müşteri Adı";
                dataGridViewVeresiye.Columns["Telefon"].HeaderText = "Telefon";
                dataGridViewVeresiye.Columns["Adres"].HeaderText = "Adres";
                dataGridViewVeresiye.Columns["ToplamBorc"].HeaderText = "Toplam Borç";

                // Gereksiz sütunları gizleme
                dataGridViewVeresiye.Columns["MusteriID"].Visible = false;
            }
        }


        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeresiye.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtOdemeAl.Text.Trim(), out decimal odemeTutari) || odemeTutari <= 0)
            {
                MessageBox.Show("Geçerli bir ödeme tutarı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int musteriId = Convert.ToInt32(dataGridViewVeresiye.SelectedRows[0].Cells["MusteriID"].Value);
            decimal borcTutari = Convert.ToDecimal(dataGridViewVeresiye.SelectedRows[0].Cells["ToplamBorc"].Value);

            if (odemeTutari > borcTutari)
            {
                MessageBox.Show("Ödeme tutarı mevcut borç tutarından fazla olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new BarkodDbEntities())
            {
                // Ödeme işlemini kaydediyoruz
                var yeniIslem = new musteriVeresiye
                {
                    ID = musteriId,
                    Ad = dataGridViewVeresiye.SelectedRows[0].Cells["MusteriAd"].Value.ToString(),
                    Telefon = dataGridViewVeresiye.SelectedRows[0].Cells["Telefon"].Value.ToString(),
                    Adres = dataGridViewVeresiye.SelectedRows[0].Cells["Adres"].Value.ToString(),
                    BorcTutari = -odemeTutari, // Ödemeyi negatif olarak kaydediyoruz
                    veresiyeYazdirmaTarihi = DateTime.Now,
                    veresiyeOdemeTarihi = DateTime.Now,
                    IslemTuru = "Odeme"
                };

                db.musteriVeresiye.Add(yeniIslem);

                // Mevcut borcu güncelliyoruz
                var musteri = db.musteriVeresiye.FirstOrDefault(v => v.ID == musteriId && v.IslemTuru == "ToplamBorc");
                if (musteri != null)
                {
                    musteri.BorcTutari -= odemeTutari;
                }

                db.SaveChanges();
            }

            MessageBox.Show("Ödeme başarıyla alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusteriListesiniGuncelle();
            txtOdemeAl.Clear();
        }

        private void btnVeresiyeRapor_Click(object sender, EventArgs e)
        {
            frmVeresiyeRapor f = new frmVeresiyeRapor();
            f.ShowDialog();
        }

        private void txtOdemeAl_Enter(object sender, EventArgs e)
        {
            txtOdemeAl.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = textBox1.Text.Trim(); // TextBox1'den alınan değeri al

            // Eğer textBox1 boş değilse, müşteri listesini arama kriteriyle güncelle
            if (!string.IsNullOrEmpty(aramaKelimesi))
            {
                using (var db = new BarkodDbEntities())
                {
                    // Arama kelimesine göre filtreleme yap
                    var toplamBorcListesi = from v in db.musteriVeresiye
                                            where v.IslemTuru == "ToplamBorc" && v.Ad.ToLower().Contains(aramaKelimesi.ToLower())
                                            group v by new { v.ID, v.Ad, v.Telefon, v.Adres } into g
                                            select new
                                            {
                                                MusteriID = g.Key.ID,
                                                MusteriAd = g.Key.Ad,
                                                Telefon = g.Key.Telefon,
                                                Adres = g.Key.Adres,
                                                ToplamBorc = g.Sum(x => (decimal?)x.BorcTutari) ?? 0 // Sadece borç toplamı
                                            };

                    // Arama sonuçlarını dataGridView'e aktar
                    dataGridViewVeresiye.DataSource = toplamBorcListesi.ToList();
                }
            }
            else
            {
                // Eğer textBox1 boşsa, tüm müşteri listesini göster
                MusteriListesiniGuncelle();
            }
        }
    }
}

