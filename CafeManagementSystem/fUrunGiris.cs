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
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }

        BarkodDbEntities db = new BarkodDbEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (db.Urun.Any(a => a.Barkod == barkod))
                {
                    var urun = db.Urun.Where(a => a.Barkod == barkod).SingleOrDefault();
                    tUrunAdi.Text = urun.UrunAd;
                    tAciklama.Text = urun.Aciklama;
                    cmbUrunGrup.Text = urun.UrunGrup;
                    tAlis.Text = urun.AlisFiyat.ToString();
                    tSatis.Text = urun.SatisFiyat.ToString();
                    tMiktar.Text = urun.Miktar.ToString();
                    tKdvOran.Text = urun.KdvOrani.ToString();
                    if (urun.Birim=="Kg")
                    {
                        chUrunTipi.Checked = true;
                    }
                    else
                    {
                        chUrunTipi.Checked=false;
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Kayıtlı Değil Kaydediniz");
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {

            if (!db.Urun.Any(a => a.UrunAd.Trim().ToLower() == tUrunAdi.Text.Trim().ToLower()))
            {
                bBarkodOlustur_Click_1(sender, e);
            }

            if (tBarkod.Text!="" && tUrunAdi.Text!="" && cmbUrunGrup.Text != "" && tAlis.Text !="" && tSatis.Text!="" && tKdvOran.Text!=""  && tMiktar.Text!="")
            {   if ( db.Urun.Any(a => a.Barkod==tBarkod.Text))
                {   
                    var guncelle = db.Urun.Where(a => a.Barkod == tBarkod.Text).SingleOrDefault();
                    guncelle.Barkod = tBarkod.Text;
                    guncelle.UrunAd = tUrunAdi.Text;
                    guncelle.Aciklama = tAciklama.Text;
                    guncelle.UrunGrup = cmbUrunGrup.Text;
                    guncelle.AlisFiyat = Convert.ToDouble(tAlis.Text);
                    guncelle.SatisFiyat = Convert.ToDouble(tSatis.Text);
                    guncelle.KdvOrani = Convert.ToInt32(tKdvOran.Text);
                    guncelle.KdvTutari = Math.Round(Islemler.DoubleYap(tSatis.Text) * Convert.ToInt32(tKdvOran.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(tMiktar.Text); // var olan miktarın üstüne girilen miktar + değer olarak eklenir toplanır
                    guncelle.Onay = true;
                    if ( chUrunTipi.Checked )
                    {
                        guncelle.Birim = "Kg";

                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = lKullanici.Text;
                    db.SaveChanges();
                    tGridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                }
                else 
                {
                    bBarkodOlustur_Click_1(sender, e);

                    Urun urun = new Urun();
                    urun.Barkod = tBarkod.Text;
                    urun.UrunAd = tUrunAdi.Text;
                    urun.Aciklama = tAciklama.Text;
                    urun.UrunGrup = cmbUrunGrup.Text;
                    urun.AlisFiyat = Convert.ToDouble(tAlis.Text);
                    urun.SatisFiyat = Convert.ToDouble(tSatis.Text);
                    urun.KdvOrani = Convert.ToInt32(tKdvOran.Text);
                    urun.KdvTutari = Math.Round(Islemler.DoubleYap(tSatis.Text) * Convert.ToInt32(tKdvOran.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(tMiktar.Text);
                    urun.Onay=true;
                    if (chUrunTipi.Checked)
                    {
                        urun.Birim = "Kg";

                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();

                    if (tBarkod.Text.Length == 8 )
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges() ;
                    }

                    try
                    {
                        Islemler.StokGiris(tBarkod.Text, tUrunAdi.Text, "ADET", Convert.ToDouble(tMiktar.Text), cmbUrunGrup.Text, lKullanici.Text);
                        temizle();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ürün Eklenmiştir"); // 93.satır ve ıslemler.stokgiris güncellenmeli
                    }

                    tGridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    Islemler.GridDuzenle(tGridUrunler);
                }     // girilen barkod mevcut değil ise          
            }                
            else
            {
                MessageBox.Show("Bilgi girişlerini kontrol ediniz");
                tBarkod.Focus();
            }
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(tUrunAra.Text.Length >= 2)
            {
                string urunad = tUrunAra.Text;
                tGridUrunler.DataSource = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                // Equals ürün adının tamamını yazarsak ürünü listeler ama contains içeriyorsa listelemeye başlar
                Islemler.GridDuzenle(tGridUrunler);
            }
        }

        private void bİptal_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            tBarkod.Clear();
            tUrunAdi.Clear();
            tAciklama.Clear();
            tAlis.Text = "0";
            tSatis.Text = "0";
            tMiktar.Text = "0";
            tKdvOran.Text = "8";
            tBarkod.Focus();
            chUrunTipi.Checked = false;
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            tUrunSayisi.Text = db.Urun.Count().ToString();
            tGridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
            Islemler.GridDuzenle(tGridUrunler);
            grupDl();

            tGridUrunler.Columns["Barkod"].Visible = false;
            tGridUrunler.Columns["Aciklama"].Visible = false;
            tGridUrunler.Columns["AlisFiyat"].Visible = false;
            tGridUrunler.Columns["KdvOrani"].Visible = false;
            tGridUrunler.Columns["KdvTutari"].Visible = false;
            tGridUrunler.Columns["Birim"].Visible = false;
            tGridUrunler.Columns["Onay"].Visible = false;



        }
        public void grupDl()
        {
            cmbUrunGrup.DisplayMember = "UrunGrupAd";
            cmbUrunGrup.ValueMember = "Id";
            cmbUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }
        private void bUrunGrupEkle_Click(object sender, EventArgs e)
        {
            fUrunGrup f = new fUrunGrup();
            f.ShowDialog();
        }            
        private void bBarkodOlustur_Click_1(object sender, EventArgs e )
        {
            
            var barkodno = db.Barkod.First(); // varsayılan olarak verdiğimiz 1 değerini arar tabloda bulamaz ise program hata verir
            int karakter = barkodno.BarkodNo.ToString().Length;
            string sifirlar = string.Empty;

            for (int i = 0; i < 8 - karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
            tBarkod.Text = olusanbarkod;
            tUrunAdi.Focus();
            
        }

        private void tGridUrunler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false &&  e.KeyChar!=(char)08 && e.KeyChar!=(char)44 && e.KeyChar!=(char)45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tGridUrunler.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(tGridUrunler.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunad = tGridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = tGridUrunler.CurrentRow.Cells["barkod"].Value.ToString();

                DialogResult onay = MessageBox.Show(urunad + " ürününü silmek istiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);

                if (onay == DialogResult.Yes)
                {
                    // Ürünü silme işlemi
                    var urun = db.Urun.Find(urunid);
                    if (urun != null)
                    {
                        db.Urun.Remove(urun);
                        db.SaveChanges();

                        // Hızlı ürün kaydını güncelleme
                        var hizliurun = db.HizliUrun.Where(x => x.Barkod == barkod).SingleOrDefault();
                        if (hizliurun != null)
                        {
                            hizliurun.Barkod = "-";
                            hizliurun.UrunAd = "-";
                            hizliurun.Fiyat = 0;
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Ürün hızlı ürünlere eklenmeden siliniyor.");
                        }

                        MessageBox.Show("Ürün silinmiştir");
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı.");
                    }

                    // Grid'i güncelleme
                    tGridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    Islemler.GridDuzenle(tGridUrunler);

                    tBarkod.Focus();
                    tUrunSayisi.Text = db.Urun.Count().ToString();


                    // Silinen ürünü fSatis'dan da silmek için
                    /*var satisKaydi = db.fSatis.Where(x => x.Barkod == barkod).ToList();
                    if (satisKaydi.Any())
                    {
                        db.fSatis.RemoveRange(satisKaydi);
                        db.SaveChanges();
                    }*/
                }
            }
        }

        private void chUrunTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (chUrunTipi.Checked)
            {
                chUrunTipi.Text = "Gramajlı Ürün"; 
                bBarkodOlustur.Enabled = false;   
            }
            else
            {
                chUrunTipi.Text = "Barkodlu Ürün";
                bBarkodOlustur.Enabled = true;
            }
            /*
             gramajlı ürün ch kullanımı : 
             gramajlı ürün barkod 00001 bu şekilde oluşturulmalı
             ön ek 27'yi başına almalı
             27-00001-01500-9 
             01500 kısmı gramaj bilgisi
             9 sabit sayımız
             gramajlı ürün oluştururken
             barkod oluşturucumuzu kapatıyoruz
             */
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tGridUrunler.Rows.Count > 0)
            {
                tBarkod.Text = tGridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                tUrunAdi.Text = tGridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                tAciklama.Text = tGridUrunler.CurrentRow.Cells["Aciklama"].Value.ToString();
                cmbUrunGrup.Text = tGridUrunler.CurrentRow.Cells["UrunGrup"].Value.ToString();
                tAlis.Text = tGridUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
                tSatis.Text = tGridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                tKdvOran.Text = tGridUrunler.CurrentRow.Cells["Kdvorani"].Value.ToString();
                tMiktar.Text = tGridUrunler.CurrentRow.Cells["Miktar"].Value.ToString();
                string birim = tGridUrunler.CurrentRow.Cells["Birim"].Value.ToString();

                if (birim == "Kg")
                {
                    chUrunTipi.Checked = true;
                }
                else
                {
                    chUrunTipi.Checked = false;
                }
            }

        }

        private void bKullanilmayanUrunSilme_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("!! Dikkat: \n Ürün fiyat miktar gibi güncellemelerin TAMAMINI yaptıktan sonra bu işlemi gerçekleştirin.\n\n Onaylıyor musunuz ? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        db.Urun.RemoveRange(db.Urun.Where(x => x.Onay == false));
                        db.SaveChanges();
                        tGridUrunler.DataSource =db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                        MessageBox.Show("Kullanılmayan ürünler silindi");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
        }
    }
}
