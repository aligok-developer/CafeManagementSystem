using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class frmVeresiye : Form
    {
        private readonly fSatis satisForm;

        public frmVeresiye(fSatis satis)
        {
            InitializeComponent();
            satisForm = satis;
        }

        private void frmVeresiye_Load(object sender, EventArgs e)
        {
            MusteriListesiniGuncelle();
        }

        private void MusteriListesiniGuncelle()
        {
            using (var db = new BarkodDbEntities())
            {
                // Tüm müşterileri alıyoruz
                var musteriListesi = (from m in db.musteriVeresiye
                                      group m by new { m.ID, m.Ad, m.Telefon, m.Adres } into g
                                      select new
                                      {
                                          ID = g.Key.ID,
                                          Ad = g.Key.Ad,
                                          Telefon = g.Key.Telefon,
                                          Adres = g.Key.Adres,
                                          ToplamBorc = g.Where(x => x.IslemTuru == "ToplamBorc").Sum(x => (decimal?)x.BorcTutari) ?? 0 -
                                                       g.Where(x => x.IslemTuru == "Odeme").Sum(x => (decimal?)x.BorcTutari) ?? 0
                                      }).ToList();

                // Telefon ve Ad aynı olan kişileri filtrele
                var benzersizMusteriler = musteriListesi
                    .GroupBy(m => new { m.Ad, m.Telefon })
                    .Select(g => g.First()) // Sadece benzersiz kayıtları al
                    .ToList();

                // İlk 50 müşteriyi listele
                dataGridViewMusteri.DataSource = benzersizMusteriler.Take(50).ToList();

                // DataGridView sütun başlıkları
                dataGridViewMusteri.Columns["Ad"].HeaderText = "Müşteri Adı";
                dataGridViewMusteri.Columns["Telefon"].HeaderText = "Telefon";
                dataGridViewMusteri.Columns["Adres"].HeaderText = "Adres";

                // Gereksiz sütunları gizle
                dataGridViewMusteri.Columns["ID"].Visible = false;
                dataGridViewMusteri.Columns["ToplamBorc"].Visible = false;
            }
        }
        private void btnVeresiyeKaydet_Click(object sender, EventArgs e)
        {
            if (dataGridViewMusteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string genelToplamString = satisForm.GenelToplamText.Replace("₺", "").Trim();
            if (!decimal.TryParse(genelToplamString, out decimal tGenelToplam) || tGenelToplam <= 0)
            {
                MessageBox.Show("Geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int musteriId = Convert.ToInt32(dataGridViewMusteri.SelectedRows[0].Cells["ID"].Value);

            using (var db = new BarkodDbEntities())
            {
                // Mevcut müşteriyi kontrol et
                var mevcutMusteri = db.musteriVeresiye.FirstOrDefault(v => v.ID == musteriId);

                if (mevcutMusteri != null)
                {
                    // Eğer müşteri zaten kayıtlıysa borç tutarını güncelle
                    mevcutMusteri.BorcTutari += tGenelToplam;
                    mevcutMusteri.veresiyeYazdirmaTarihi = DateTime.Now; // Tarihi güncelle
                }
                else
                {
                    // Yeni bir müşteri kaydı oluştur (Bu durum normalde oluşmamalı!)
                    var yeniVeresiye = new musteriVeresiye
                    {
                        ID = musteriId,
                        Ad = dataGridViewMusteri.SelectedRows[0].Cells["Ad"].Value.ToString(),
                        Telefon = dataGridViewMusteri.SelectedRows[0].Cells["Telefon"].Value.ToString(),
                        Adres = dataGridViewMusteri.SelectedRows[0].Cells["Adres"].Value.ToString(),
                        BorcTutari = tGenelToplam,
                        veresiyeYazdirmaTarihi = DateTime.Now,
                        veresiyeOdemeTarihi = null,
                        IslemTuru = "ToplamBorc"
                    };

                    db.musteriVeresiye.Add(yeniVeresiye);
                }

                // Her veresiye işlemi için ayrı bir kayıt ekle
                var yeniBorc = new musteriVeresiye
                {
                    ID = musteriId,
                    Ad = dataGridViewMusteri.SelectedRows[0].Cells["Ad"].Value.ToString(),
                    Telefon = dataGridViewMusteri.SelectedRows[0].Cells["Telefon"].Value.ToString(),
                    Adres = dataGridViewMusteri.SelectedRows[0].Cells["Adres"].Value.ToString(),
                    BorcTutari = tGenelToplam,
                    veresiyeYazdirmaTarihi = DateTime.Now,
                    veresiyeOdemeTarihi = DateTime.Now,
                    IslemTuru = "Borc"
                };

                db.musteriVeresiye.Add(yeniBorc);
                db.SaveChanges();
            }

            MessageBox.Show("Veresiye başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusteriListesiniGuncelle();
            this.Close();
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle musteriEkleForm = new frmMusteriEkle();
            musteriEkleForm.ShowDialog(); // Yeni müşteri formunu aç
            MusteriListesiniGuncelle(); // Müşteri eklendikten sonra listeyi güncelle
        }


    }
}

