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
    public partial class fUrunEkle : Form
    {
        public fUrunEkle()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text != "")
            {
                string urunad = tUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                gridUrunler.DataSource = urunler;
                Islemler.GridDuzenle(gridUrunler);
            }
        }

        /*private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                // ürünler tablomuzdan gerekli verileri alıyoruz 
                // bu tarz veri göndermelerde breakpoint kullanarak
                // db üstüne gelip sağ tık yapıp hataları kontrol edebiliriz.

                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());         
                int id = Convert.ToInt16(lButonId.Text);
                var guncellenecek = db.HizliUrun.Find(id);  // find fonk. ilgili tabloda arama yapmamızı sağlar
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunad;
                guncellenecek.Fiyat = fiyat;
                MessageBox.Show("Buton Tanımlandı");

                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                if (f != null)
                {
                    Button b = f.Controls.Find("bH" + id,true).FirstOrDefault() as Button;
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
                db.SaveChanges();
            }
        }*/
        
        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                gridUrunler.DataSource = db.Urun.ToList();
                gridUrunler.Columns["AlisFiyat"].Visible = false;
                gridUrunler.Columns["KdvOrani"].Visible = false;
                gridUrunler.Columns["KdvTutari"].Visible = false;
                gridUrunler.Columns["Miktar"].Visible = false;
                gridUrunler.Columns["Onay"].Visible = false;
                gridUrunler.Columns["UrunId"].Visible = false;
                gridUrunler.Columns["Barkod"].Visible = false;
                gridUrunler.Columns["Aciklama"].Visible = false;
                gridUrunler.Columns["Birim"].Visible = false;
                gridUrunler.Columns["Tarih"].Visible = false;
                gridUrunler.Columns["Kullanici"].Visible = false;
                Islemler.GridDuzenle(gridUrunler);
            }
            else
            {
                gridUrunler.DataSource = null;
            }
        }

        private void fUrunEkle_Load(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                chTumu_CheckedChanged(sender, e); //form load kısımına tüm ürünlerin form açıldığında listelenmesi için eklendi
            }
        }

        private void gridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                // ürünler tablomuzdan gerekli verileri alıyoruz 
                // bu tarz veri göndermelerde breakpoint kullanarak
                // db üstüne gelip sağ tık yapıp hataları kontrol edebiliriz.

                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lButonId.Text);
                var guncellenecek = db.HizliUrun.Find(id);  // find fonk. ilgili tabloda arama yapmamızı sağlar
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunad;
                guncellenecek.Fiyat = fiyat;

                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                if (f != null)
                {
                    Button b = f.Controls.Find("bH" + id, true).FirstOrDefault() as Button;
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
                db.SaveChanges();
                this.Close();
            }
        }
    }

}
