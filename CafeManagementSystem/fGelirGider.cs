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
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }

        public string gelirgider {  get; set; }
        public string kullanici { get; set; }

        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lGelirGider.Text = gelirgider;
        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.SelectedIndex == 0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }
            else if (cmbOdemeTuru.SelectedIndex == 1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }
            else if (cmbOdemeTuru.SelectedIndex == 2)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }

            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text != "")
            {
                if (tNakit.Text != "" && tKart.Text != "") //&& (tNakit.Text !="0" && tKart.Text!="0")
                {   using (var db = new BarkodDbEntities())
                    {
                        IslemOzet io = new IslemOzet();
                        io.IslemNo = 0;
                        io.Iade = false;
                        io.OdemeSekli = cmbOdemeTuru.Text;
                        io.Nakit = Islemler.DoubleYap(tNakit.Text);
                        io.Kart = Islemler.DoubleYap(tKart.Text);
                        if (gelirgider == "GELİR")
                        {
                            io.Gelir = true;
                            io.Gider = false;
                        }
                        else
                        {
                            io.Gelir = false;
                            io.Gider = true;
                        }
                        io.AlisFiyatToplam = 0;
                        io.Aciklama = gelirgider + " - İşlemi" + tAçiklama.Text;
                        io.Tarih = dTarih.Value;
                        io.Kullanici = kullanici;
                        db.IslemOzet.Add(io);
                        db.SaveChanges();
                        MessageBox.Show(gelirgider + " İşlem Onaylandı");
                        tNakit.Text = "0";
                        tKart.Text = "0";
                        tAçiklama.Clear();
                        cmbOdemeTuru.Text = "";
                        fRapor f = (fRapor)Application.OpenForms["fRapor"];
                        if (f != null)
                        {
                            f.bGoster_Click(null, null);
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seçim yapınız");
            }
        }
    }
}
