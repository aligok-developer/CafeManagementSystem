using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class adisyonEkle : Form
    {
        private Adisyon _veresiye;
        private int _buttonIndex;

        // Buton index'ini constructor ile alıyoruz
        public adisyonEkle(Adisyon veresiye, int buttonIndex)
        {
            InitializeComponent();
            _veresiye = veresiye;
            _buttonIndex = buttonIndex;
        }


        // Kaydet butonuna tıklanınca text'i Veresiye formuna gönderiyoruz
        private void bStandart1_Click(object sender, EventArgs e)
        {
            string textFromTextbox = textBox1.Text;
            _veresiye.UpdateBtnText(_buttonIndex, textFromTextbox);
            fSatis fSatisForm = new fSatis(_veresiye.GetButton(_buttonIndex), _veresiye.GetOrdersForButton(_veresiye.GetButton(_buttonIndex)), _veresiye);
            this.Hide();
            fSatisForm.ShowDialog();
            this.Close();
        }

        private void adisyonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
