using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fDetayGöster : Form
    {
        public fDetayGöster()
        {
            InitializeComponent();
        }
        public int islemno {  get; set; }
        private void fDetayGöster_Load(object sender, EventArgs e)
        {
            lIslemNo.Text = "İşlem No :  " + islemno.ToString();

            using ( var db = new BarkodDbEntities())
            {
                tGridListe.DataSource = db.Satis.Select(s => new {s.IslemNo, s.UrunAd ,s.Miktar , s.Toplam}).Where( x => x.IslemNo == islemno).ToList();
            }
        }
    }
}
