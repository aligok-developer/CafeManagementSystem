using System;
using System.Linq;
using System.Windows.Forms;
namespace BarkodluSatis
{
    public partial class fGiris : Form
    {
        public fGiris()
        {
            InitializeComponent();
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            girisYap();
        }

        private void girisYap ()
        {
            if (!string.IsNullOrEmpty(tKullanici.Text) && !string.IsNullOrEmpty(tSifre.Text))
            {
                try
                {
                    using (var db = new BarkodDbEntities())
                    {
                        var bak = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAd == tKullanici.Text && x.Sifre == tSifre.Text);
                        if (bak != null)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            fBaslangic f = new fBaslangic();
                            f.bSatisİslemi.Enabled = (bool)bak.Satis;
                            f.bRaporİslemi.Enabled = (bool)bak.Rapor;
                            f.bUrunİslemi.Enabled = (bool)bak.UrunGiris;
                            f.bStokİslemi.Enabled = (bool)bak.Stok;
                            f.bAyarİslemi.Enabled = (bool)bak.Ayarlar;
                            f.bFiyatİslemi.Enabled = (bool)bak.FiyatGuncelle;
                            f.bYedeklemeIslemi.Enabled = (bool)bak.Yedekleme;
                            f.lKullanici.Text = bak.AdSoyad;
                            var isyeri = db.KartKomisyonSabit.FirstOrDefault();
                            f.lIsyeriUnvan.Text = isyeri.Unvan;
                            f.Show();
                            this.Hide();
                            Cursor.Current = Cursors.Default;
                        }
                        else{MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı Tekrar Deneyiniz");
                        }
                    }
                }
                catch (Exception ex){ MessageBox.Show("Bir hata oluştu: " + ex.Message);}
            }
        }
        private void bGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                girisYap();
            }
        }
    }
}
