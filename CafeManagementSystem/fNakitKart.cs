using System;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fNakitKart : Form
    {
        public fNakitKart()
        {
            InitializeComponent();
        }
        private void tNakit_KeyDown(object sender, KeyEventArgs e)
        { 
            if (tNakit.Text != "")
            {
                if(e.KeyCode == Keys.Enter)
                {
                    Hesapla();
                }
            }
        }
        private void Hesapla()
        {
            fSatis f = (fSatis)Application.OpenForms["fSatis"];
            double nakit = Islemler.DoubleYap(tNakit.Text);
            double geneltoplam = Islemler.DoubleYap(f.tGenelToplam.Text);
            double kart = geneltoplam - nakit;
            f.lNakit.Text = nakit.ToString("C2");
            f.lKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }
        private void bEnter_Click(object sender, EventArgs e)
        {
            if (tNakit.Text != "")
            {
              Hesapla();
            }
        }

        private void tBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char .IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Name == "bNV") // Virgül kontrolü için buton adını kullan
            {
                // Virgül kontrolü: Mevcut metinde virgül var mı?
                if (!tNakit.Text.Contains(","))
                {
                    tNakit.Text += ",";
                }
            }
            else if (b.Name == "bNB") // Backspace kontrolü için buton adını kullan
            {
                if (tNakit.Text.Length > 0)
                {
                    tNakit.Text = tNakit.Text.Substring(0, tNakit.Text.Length - 1);
                }
            }
            else
            {
                tNakit.Text += b.Text;
            }
        }
    }
}
