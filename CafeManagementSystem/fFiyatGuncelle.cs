using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarkodDbEntities())
                {
                    if (db.Urun.Any(x => x.Barkod == tBarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAdi.Text = getir.UrunAd;
                        double mevcutfiyat = Convert.ToDouble(getir.SatisFiyat);
                        lMevcutFiyat.Text = mevcutfiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Giriş Formundan ürünü kaydediniz");
                    }    
                }
            }
        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tYeniFiyat.Text != "" && lBarkod.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    int tkdvorani = Convert.ToInt16( guncellenecek.KdvOrani );
                    Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * tkdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni fiyat kaydedilmiştir");
                    tBarkod.Clear();
                    tYeniFiyat.Clear();
                    lBarkod.Text = "";
                    lUrunAdi.Text = "";
                    lMevcutFiyat.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ürün okutunuz");
            }
        }
    }
}
