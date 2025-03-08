using System;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BarkodluSatis
{
    static class Islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return Math.Round(sonuc,2);
        }
        public static void StokAzalt(string barkod, double miktar)
        {
            using (var db = new BarkodDbEntities())
            {
                if ( barkod != "1111111111116")     // diğer ürün olarak satış gerçekleştiğinde stok
                                                    // azaltma/arttırma işleminin gerekleşmemesi için != 
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar -= miktar;
                    db.SaveChanges();
                }
            }
        }
        public static void StokArttir(string barkod, double miktar)
        {
            using (var db = new BarkodDbEntities())
            {
                if ( barkod != "1111111111116")
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar += miktar;
                    db.SaveChanges();
                }
            }
        }
        public static void GridDuzenle(DataGridView dgv)
            {
                if (dgv.Columns.Count > 0)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        switch (dgv.Columns[i].HeaderText)
                        {
                            case "Id":
                                dgv.Columns[i].HeaderText = "Numara";
                                break;

                            case "IslemNo":
                                dgv.Columns[i].HeaderText = "İşlem No";
                                break;

                            case "UrunId":
                                dgv.Columns[i].HeaderText = "Urun Numarası";
                                break;

                            case "UrunAd":
                                dgv.Columns[i].HeaderText = "Ürün Adı";
                                break;

                            case "Aciklama":
                                dgv.Columns[i].HeaderText = "Açıklama";
                                break;

                            case "UrunGrup":
                                dgv.Columns[i].HeaderText = "Ürün Grubu";
                                break;

                            case "AlisFiyat":
                                dgv.Columns[i].HeaderText = "Alış Fiyatı";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;
                        case "AlisFiyatToplam":
                            dgv.Columns[i].HeaderText = "Alış Fiyat Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "SatisFiyat":
                                dgv.Columns[i].HeaderText = "Satış Fiyatı";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;
                            case "Kdvorani":
                                dgv.Columns[i].HeaderText = "Kdv Oranı";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            case "Birim":
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            case "OdemeSekli":
                                dgv.Columns[i].HeaderText = "Ödeme Şekli";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            case "Kart":
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;

                            case "Nakit":
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;

                            case "Gelir":
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;

                            case "Gider":
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;
                            case "Kullanici":
                                dgv.Columns[i].HeaderText = "Kullanıcı";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;

                            case "KdvTutari":
                                dgv.Columns[i].HeaderText = "Kdv Tutarı";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;
                            case "Toplam":
                                dgv.Columns[i].HeaderText = "Toplam";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                dgv.Columns[i].DefaultCellStyle.Format = "C2";
                                break;
                            /*case "Onay":
                                dgv.Columns[i].HeaderText = "Onay";
                                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                break;*/
                        }
                    }
                }
            }
        public static void StokGiris(string barkod, string urunad, string birim, double miktar, string urungrup, string kullanici)
        {
            if (string.IsNullOrWhiteSpace(barkod) || string.IsNullOrWhiteSpace(urunad) ||
                string.IsNullOrWhiteSpace(birim) || string.IsNullOrWhiteSpace(urungrup) ||
                string.IsNullOrWhiteSpace(kullanici))
            {
                throw new ArgumentException("Geçersiz parametreler. Boş veya null değer gönderilemez.");
            }

            using (var db = new BarkodDbEntities())
            {
                try
                {
                    StokHaraket sh = new StokHaraket
                    {
                        Barkod = barkod,
                        UrunAd = urunad,
                        Birim = birim,
                        Miktar = miktar,
                        UrunGrup = urungrup,
                        Kullanici = kullanici,
                        Tarih = DateTime.Now
                    };
                    db.StokHaraket.Add(sh);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Hata mesajını loglama veya başka bir işlem yapma
                    throw new Exception("Veritabanına kaydedilirken bir hata oluştu: " + ex.Message);
                }
            }
        }
        public static int kartKomisyon() 
        {
            int sonuc = 0;
            using (var db = new BarkodDbEntities())
            {
                if(db.KartKomisyonSabit.Any())
                {
                    sonuc = Convert.ToInt16(db.KartKomisyonSabit.First().kartkomisyon);
                }
                else
                {
                    sonuc = 0;
                }
            }
            return sonuc; //değer döndürmek için returnsonuc için metodun void türünde değil int türünde olması gerekli
        }
        public static void Sabit()
        {
            using (var db = new BarkodDbEntities())
            {
                if (!db.KartKomisyonSabit.Any())
                {
                    KartKomisyonSabit s = new KartKomisyonSabit();
                    s.kartkomisyon = 0;
                    s.AdSoyad = "admin";
                    s.Yazici = false;
                    s.Adres = "admin";
                    s.Unvan = "admin";
                    s.Adres = "admin"; // Duplicate assignment, likely an error
                    s.Telefon = "admin";
                    s.Eposta = "admin";
                    db.KartKomisyonSabit.Add(s);
                    db.SaveChanges();
                }
            }
        }
        public static void Yedekleme()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri yedek dosyası |0.bak";
            save.FileName = DateTime.Now.ToShortDateString() + "market_x_satis";
            if( save.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    var dbHedef = save.FileName;
                    string dbKaynak = Application.StartupPath + @"\BarkodDb.mdf";
                    using (var db = new BarkodDbEntities())
                    {
                        var cmd = @"BACKUP DATABASE [" + dbKaynak + "] TO DISK = '" + dbHedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Veri Yedekleme Yapılmıştır");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }
    }
}
