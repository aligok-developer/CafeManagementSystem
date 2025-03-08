using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BarkodluSatis
{
    public partial class frmVeresiyeRapor : Form
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public frmVeresiyeRapor()
        {
            InitializeComponent();
        }

        private void frmVeresiyeRapor_Load(object sender, EventArgs e)
        {
            // İlk açılışta tüm verileri listele
            LoadVeresiyeData(null, null);
        }

        private void btnTarihSecme_Click(object sender, EventArgs e)
        {
            // Tarih aralığı dBaslangic ve dBitis DateTimePicker'larındaki tarihlerle filtrelenerek verileri yükle
            DateTime baslangicTarihi = dBaslangic.Value.Date;  // Tarih kısmı alınır
            DateTime bitisTarihi = dBitis.Value.Date.AddDays(1).AddSeconds(-1); // Bitis tarihi bir gün eklenerek saat 23:59:59 olarak ayarlanır

            // LoadVeresiyeData fonksiyonunu tarih aralığı ile çağırıyoruz
            LoadVeresiyeData(baslangicTarihi, bitisTarihi);
        }

        private void LoadVeresiyeData(DateTime? baslangic, DateTime? bitis)
        {
            using (var db = new BarkodDbEntities())
            {
                var veresiyeRaporListesi = from v in db.musteriVeresiye
                                           where v.IslemTuru == "Borc" || v.IslemTuru == "Odeme"  // Burada filtreyi ekliyoruz
                                           select new
                                           {
                                               MusteriAd = v.Ad,
                                               Telefon = v.Telefon,
                                               Adres = v.Adres,
                                               IslemTuru = v.IslemTuru,
                                               Tutar = v.BorcTutari,
                                               Tarih = v.IslemTuru == "ToplamBorc" ? v.veresiyeYazdirmaTarihi : v.veresiyeOdemeTarihi
                                           };

                // Eğer tarih aralığı belirtilmişse filtre uygula
                if (baslangic.HasValue && bitis.HasValue)
                {
                    veresiyeRaporListesi = veresiyeRaporListesi
                        .Where(v => v.Tarih >= baslangic && v.Tarih <= bitis);
                }

                // Verileri tarih alanına göre büyükten küçüğe sıralıyoruz (en yeni tarihten en eskiye)
                veresiyeRaporListesi = veresiyeRaporListesi.OrderByDescending(v => v.Tarih);

                // Verileri DataGridView'e yükle
                tGridVeresiye.DataSource = veresiyeRaporListesi.ToList();

                // Sütun başlıklarını ayarla
                tGridVeresiye.Columns["MusteriAd"].HeaderText = "Müşteri Adı";
                tGridVeresiye.Columns["Telefon"].HeaderText = "Telefon";
                tGridVeresiye.Columns["Adres"].HeaderText = "Adres";
                tGridVeresiye.Columns["IslemTuru"].HeaderText = "İşlem Türü";
                tGridVeresiye.Columns["Tutar"].HeaderText = "Tutar";
                tGridVeresiye.Columns["Tarih"].HeaderText = "Tarih";

                // Tarih formatlama
                tGridVeresiye.Columns["Tarih"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void btnVeresiyeRaporla_Click(object sender, EventArgs e)
        {
            StartDate = dBaslangic.Value;
            EndDate = dBitis.Value;

            veresiyePdfPaylasimi f = new veresiyePdfPaylasimi(StartDate, EndDate);
            f.ShowDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            {
                string aramaKelimesi = textBox1.Text.ToLower(); // TextBox1'deki değeri alıp küçük harfe çeviriyoruz

                // Verileri tekrar yükle ve müşteri adına göre filtrele
                using (var db = new BarkodDbEntities())
                {
                    var veresiyeRaporListesi = from v in db.musteriVeresiye
                                               where (v.IslemTuru == "Borc" || v.IslemTuru == "Odeme") &&
                                                     v.Ad.ToLower().Contains(aramaKelimesi) // Müşteri adı arama kelimesini içeriyorsa
                                               select new
                                               {
                                                   MusteriAd = v.Ad,
                                                   Telefon = v.Telefon,
                                                   Adres = v.Adres,
                                                   IslemTuru = v.IslemTuru,
                                                   Tutar = v.BorcTutari,
                                                   Tarih = v.IslemTuru == "ToplamBorc" ? v.veresiyeYazdirmaTarihi : v.veresiyeOdemeTarihi
                                               };

                    // Verileri tarih alanına göre büyükten küçüğe sıralıyoruz (en yeni tarihten en eskiye)
                    veresiyeRaporListesi = veresiyeRaporListesi.OrderByDescending(v => v.Tarih);

                    // Verileri DataGridView'e yükle
                    tGridVeresiye.DataSource = veresiyeRaporListesi.ToList();

                    // Sütun başlıklarını ayarla
                    tGridVeresiye.Columns["MusteriAd"].HeaderText = "Müşteri Adı";
                    tGridVeresiye.Columns["Telefon"].HeaderText = "Telefon";
                    tGridVeresiye.Columns["Adres"].HeaderText = "Adres";
                    tGridVeresiye.Columns["IslemTuru"].HeaderText = "İşlem Türü";
                    tGridVeresiye.Columns["Tutar"].HeaderText = "Tutar";
                    tGridVeresiye.Columns["Tarih"].HeaderText = "Tarih";

                    // Tarih formatlama
                    tGridVeresiye.Columns["Tarih"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
            }
        }
    }
}
