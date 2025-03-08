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
    public partial class fUrunGrup : Form
    {
        public fUrunGrup()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void fUrunGrup_Load(object sender, EventArgs e)
        {
            grupDl();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text != "")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                grupDl();
                tUrunGrupAd.Clear();

                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];

                if (f != null)
                {
                    f.grupDl();
                }
                
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyiniz");
            }
        }
        private void grupDl()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + "  Ürün grubunu silmek istiyor musunuz ?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault( x => x.Id == grupid );
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                grupDl();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupad + " Ürün grubu silindi");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.grupDl();
            }
        }
    }
}
