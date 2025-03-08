using System;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fRaporGöster : Form
    {
        public fRaporGöster()
        {
            InitializeComponent();
        }

        private void fRaporGöster_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
