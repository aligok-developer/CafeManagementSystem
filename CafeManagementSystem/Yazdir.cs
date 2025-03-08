using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace BarkodluSatis
{
    class Yazdir
    {   
        public int? IslemNo { get; set; }

        public Yazdir( int? islemno)
        {
            IslemNo = islemno;   
        }

        PrintDocument pd = new PrintDocument();

        public void YazdirmayaBasla()
        {
            try
            {
                pd.PrintPage += Pd_PrintPage1;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void Pd_PrintPage1(object sender, PrintPageEventArgs e)
        {
            BarkodDbEntities db = new BarkodDbEntities();

            var isyeri = db.KartKomisyonSabit.FirstOrDefault();
            var liste = db.Satis.Where(x => x.IslemNo == IslemNo).ToList();

            if (isyeri != null && liste != null)
            {
                int kagityükseklik = 120;
                for (int i = 0; i < liste.Count; i++) 
                {
                    kagityükseklik += 15; 
                }
                PaperSize ps58 = new PaperSize("58mm Termal", 220, kagityükseklik + 120);
                pd.DefaultPageSettings.PaperSize = ps58;

                Font fontBaslik = new Font("Calibri", 10, FontStyle.Bold);
                Font fontIcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);
                Font fontstandart = new Font("Calibri", 8, FontStyle.Bold);
                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);
                ortala.Alignment = StringAlignment.Center;
                RectangleF rcUnvanKonum = new RectangleF(0, 20, 220, 20);
                e.Graphics.DrawString(isyeri.Unvan, fontBaslik, Brushes.Black, rcUnvanKonum, ortala);

                e.Graphics.DrawString("Telefon: " + isyeri.Telefon, fontstandart, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("İşlem No: " + IslemNo.ToString(), fontstandart, Brushes.Black, new Point(5, 60));
                e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString("dd/MM/yyyy"), fontstandart, Brushes.Black, new Point(5, 75));
                e.Graphics.DrawString("-----------------------------------------------------------", fontstandart, Brushes.Black, new Point(5, 90));
                e.Graphics.DrawString("Ürün Adı: ", fontIcerikBaslik, Brushes.Black, new Point(5, 105));
                e.Graphics.DrawString("Miktar: ", fontIcerikBaslik, Brushes.Black, new Point(100, 105));
                e.Graphics.DrawString("Fiyat: ", fontIcerikBaslik, Brushes.Black, new Point(140, 105));
                e.Graphics.DrawString("Tutar: ", fontIcerikBaslik, Brushes.Black, new Point(180, 105));

                int yukseklik = 125;
                double geneltoplam = 0;
                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.UrunAd, fontstandart, Brushes.Black, new Point(5, yukseklik));
                    e.Graphics.DrawString(item.Miktar.ToString(), fontstandart, Brushes.Black, new Point(120, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.SatisFiyat).ToString("C2"), fontstandart, Brushes.Black, new Point(140, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.Toplam).ToString("C2"), fontstandart, Brushes.Black, new Point(180, yukseklik));
                    yukseklik += 15;
                    geneltoplam += Convert.ToDouble(item.Toplam);
                }
                e.Graphics.DrawString("-----------------------------------------------------------", fontstandart, Brushes.Black, new Point(5, yukseklik));
                e.Graphics.DrawString("Toplam : " + geneltoplam.ToString("C2"), fontBaslik, Brushes.Black, new Point(5, yukseklik + 20));
                e.Graphics.DrawString("-----------------------------------------------------------", fontstandart, Brushes.Black, new Point(5, yukseklik + 40));
            }
        }     
    }
}
