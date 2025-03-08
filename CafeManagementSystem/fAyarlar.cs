using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tEposta.Text != "" && tSifre.Text != "" && tKullaniciAdi.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        using (var db = new BarkodDbEntities())
                            try
                            {
                                if (!db.Kullanicilar.Any(x => x.KullaniciAd == tKullaniciAdi.Text))
                                {
                                    Kullanicilar k = new Kullanicilar();

                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.Eposta = tEposta.Text;
                                    k.KullaniciAd = tKullaniciAdi.Text.Trim();
                                    k.Sifre = tSifre.Text;
                                    k.Satis = chSatis.Checked;
                                    k.Rapor = chRapor.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = chUrunGiris.Checked;
                                    k.Ayarlar = chAyarlar.Checked;
                                    k.FiyatGuncelle = chFiyatGuncelleme.Checked;
                                    k.Yedekleme = chYedekleme.Checked;
                                    db.Kullanicilar.Add(k);
                                    db.SaveChanges();
                                    dbDoldur();
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Kullanıcı Kayıtlı");
                                }
                            }
                            catch (Exception)
                            {throw;}
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Zorunlu Alanları Doldurunuz");
                }
            }
            else if (bKaydet.Text == "Düzenle")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tEposta.Text != "" && tSifre.Text != "" && tKullaniciAdi.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lKullaniciId.Text);
                        using (var db = new BarkodDbEntities())
                        {
                            var guncelle = db.Kullanicilar.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = tTelefon.Text;
                            guncelle.Eposta = tEposta.Text;
                            guncelle.KullaniciAd = tKullaniciAdi.Text.Trim();
                            guncelle.Sifre = tSifre.Text;
                            guncelle.Satis = chSatis.Checked;
                            guncelle.Rapor = chRapor.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.FiyatGuncelle = chFiyatGuncelleme.Checked;
                            guncelle.Yedekleme = chYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapılmıştır");
                            bKaydet.Text = ("Kaydet");
                            Temizle();
                            dbDoldur();
                            //var kullanicilarListesi = db.Kullanicilar.ToList();
                            //tGridListeKullanici.DataSource = kullanicilarListesi;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Zorunlu Alanları Doldurunuz");
                }
            }
        }

        private void Temizle()
        {
            tSifre.Clear();
            tSifreTekrar.Clear();
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEposta.Clear();
            tKullaniciAdi.Clear();
            tSifre.Clear();
            chRapor.Checked = false;
            chSatis.Checked = false;
            chAyarlar.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelleme.Checked = false;
            chYedekleme.Checked = false;
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dbDoldur();
            Cursor.Current = Cursors.Default;
            // TabPage'i gizlemek
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);




        }
        private void dbDoldur()
        {
            using (var db = new BarkodDbEntities())
            {
                if (db.Kullanicilar.Any())
                {
                    tGridListeKullanici.DataSource = db.Kullanicilar.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon, x.Eposta }).ToList();
                }
                Islemler.Sabit();
                var yazici = db.KartKomisyonSabit.FirstOrDefault();
                chYazici.Checked = (bool)yazici.Yazici;
                var sabitler = db.KartKomisyonSabit.FirstOrDefault();
                tKartKomisyon.Text = sabitler.kartkomisyon.ToString();
                var terazionek = db.Terazi.ToList();
                cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                cmbTeraziOnEk.ValueMember = "Id";
                cmbTeraziOnEk.DataSource = terazionek;
                tIsYeriAdsoyad.Text = sabitler.AdSoyad;
                tUnvan.Text = sabitler.Unvan;
                tAdres.Text = sabitler.Adres;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        } // düzenle

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            if (tGridListeKullanici.Rows.Count > 0)
            {
                var id = Convert.ToInt32(tGridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullaniciId.Text = id.ToString();

                using (var db = new BarkodDbEntities())
                {
                    var getir = db.Kullanicilar.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEposta.Text = getir.Eposta;
                    tKullaniciAdi.Text = getir.KullaniciAd;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    chSatis.Checked = (bool)getir.Satis;
                    chRapor.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chFiyatGuncelleme.Checked = (bool)getir.FiyatGuncelle;
                    chYedekleme.Checked = (bool)getir.Yedekleme;
                    bKaydet.Text = "Düzenle";
                    dbDoldur();
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapınız");
            }
        }

        private void chYazici_CheckedChanged(object sender, EventArgs e)
        {
            if (chYazici.Checked)
            {
                using (var db = new BarkodDbEntities())
                {
                    Islemler.Sabit();
                    var ayarla = db.KartKomisyonSabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    chYazici.Text = " Yazıcı Pasif";
                }
            }
            else
            {
                using (var db = new BarkodDbEntities())
                {
                    Islemler.Sabit();
                    var ayarla = db.KartKomisyonSabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    db.SaveChanges();
                    chYazici.Text = " Yazıcı Aktif";
                }
            }
        }

        private void bKartKomisyon_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var sabit = db.KartKomisyonSabit.FirstOrDefault();
                    sabit.kartkomisyon = Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart komisyon ayarlandı");
                }
            }
            else
            {
                MessageBox.Show("Kart komisyon bilgisini giriniz");
            }
        }

        private void bTeraziOnEkKaydet_Click(object sender, EventArgs e)
        {
            if (tTeraziOnEk.Text != "")
            {
                int tonek = Convert.ToInt16(tTeraziOnEk.Text);
                using (var db = new BarkodDbEntities())
                {
                    if (db.Terazi.Any(x => x.TeraziOnEk == tonek))
                    {
                        MessageBox.Show(" Kayıtlı bir önek girdiniz!");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = tonek;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Onek bilgisi kayıt edilmiştir");
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        tTeraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi önek bilgisi giriniz! ");
            }
        }

        private void bTeraziOnekSil_Click(object sender, EventArgs e)
        {
            if (cmbTeraziOnEk.Text != "")
            {
                int onekid = Convert.ToInt16(cmbTeraziOnEk.SelectedValue);

                DialogResult onay = MessageBox.Show(cmbTeraziOnEk.Text + " öneki silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    using (var db = new BarkodDbEntities())
                    {
                        var onek = db.Terazi.Find(onekid);

                        if (onek != null)
                        {
                            db.Terazi.Remove(onek);
                            db.SaveChanges();

                            cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                            cmbTeraziOnEk.ValueMember = "Id";
                            cmbTeraziOnEk.DataSource = db.Terazi.ToList();

                            MessageBox.Show("Önek başarıyla silindi!"); 
                        }
                        else
                        {
                            MessageBox.Show("Silinecek önek bulunamadı!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir önek seçin!");
            }
        }

        private void bIsYeriKaydet_Click(object sender, EventArgs e)
        {
            if (tIsYeriAdsoyad.Text != "" && tUnvan.Text != "" && tAdres.Text != "" && tIsYeriTelefon.Text != "" && tIsYeriEposta.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var isyeri = db.KartKomisyonSabit.FirstOrDefault();
                    isyeri.AdSoyad = tIsYeriAdsoyad.Text;
                    isyeri.Unvan = tUnvan.Text;
                    isyeri.Adres = tAdres.Text;
                    isyeri.Telefon = tIsYeriTelefon.Text;
                    isyeri.Eposta = tIsYeriEposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("İşyeri bilgileri kaydedilmiştir");
                    var yeni = db.KartKomisyonSabit.FirstOrDefault();
                    tIsYeriAdsoyad.Text = yeni.AdSoyad;
                    tUnvan.Text = yeni.Unvan;
                    tAdres.Text = yeni.Adres;
                    tIsYeriTelefon.Text = yeni.Telefon;
                    tIsYeriEposta.Text = yeni.Eposta;
                }
            }
            else
            { 
                MessageBox.Show("Zorunlu alanları doldurunuz!"); 
            }
        }

        private void bİptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void tGridListeKullanici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bYedekYukleme_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // LocalDB instance’ını durdur
                var psi = new ProcessStartInfo("sqllocaldb", "stop " + "MSSQLLocalDB")
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                var p = Process.Start(psi);
                p.WaitForExit();

                string appPath = Application.StartupPath;
                string[] dbFiles = new string[] { "BarkodDb.mdf", "BarkodDb_log.ldf" };

                // Dosyaları silmeden önce kullanıcıdan yeni dosyaları seçmesini isteyin
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    Cursor.Current = Cursors.Default;
                    ofd.Title = "Yedek Veritabanı Dosyalarını Seçin";
                    ofd.Multiselect = true;
                    ofd.Filter = "Veritabanı Dosyaları|*.mdf;*.ldf";

                    if (ofd.ShowDialog() == DialogResult.OK && ofd.FileNames.Length == 2)
                    {
                        // Kullanıcı dosya seçtiyse, eski dosyaları sil
                        foreach (var dbFile in dbFiles)
                        {
                            string dbFullPath = Path.Combine(appPath, dbFile);
                            if (File.Exists(dbFullPath))
                            {
                                File.Delete(dbFullPath);
                            }
                        }

                        // Seçilen dosyaları kopyala
                        foreach (var selectedBackupPath in ofd.FileNames)
                        {
                            string destinationPath = Path.Combine(appPath, Path.GetFileName(selectedBackupPath));
                            File.Copy(selectedBackupPath, destinationPath, true);
                        }

                        MessageBox.Show("Yedekten geri yükleme işlemi başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Kullanıcı dosya seçmediyse uyarı ver
                        MessageBox.Show("Veritabanı dosyaları seçilmedi. İşlem iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // İşlemden çık
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
