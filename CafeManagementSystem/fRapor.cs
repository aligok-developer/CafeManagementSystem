using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BarkodluSatis
{
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        public void bGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);

            using (var db = new BarkodDbEntities()) 
            {
                if (listFiltrelemeTuru.SelectedIndex==0) //Tümünü listeleliyoruz
                {
                    db.IslemOzet.Where(x => x.Tarih>=baslangic && x.Tarih<=bitis).OrderByDescending(x => x.Tarih).Load();   
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    tGridListe.DataSource = islemozet;
                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(s => s.Kart)).ToString("C2");
                    tIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    tIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");
                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(s => s.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(s => s.Kart)).ToString("C2");
                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(s => s.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(s => s.Kart)).ToString("C2");

                    double toplamKart = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(s => s.Kart));
                    double toplamNakit = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(s => s.Nakit));

                    // İki değeri toplayın
                    double toplam = toplamKart + toplamNakit;

                    // Sonucu formatlayarak tNumeric1.Text'e yazın
                    tNumeric1.Text = toplam.ToString("C2");


                    var satistable = db.Satis.Local.ToBindingList();
                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    double kdvtutarisatistable = Islemler.DoubleYap(satistable.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvtutariiadetable = Islemler.DoubleYap(satistable.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    tKdvToplam.Text = (kdvtutarisatistable - kdvtutariiadetable).ToString("C2");

                    tGridListe.Columns["IslemNo"].Visible = false;
                    tGridListe.Columns["Iade"].Visible = false;
                    //tGridListe.Columns["Nakit"].Visible = false;
                    //tGridListe.Columns["Kart"].Visible = false;
                    tGridListe.Columns["Gelir"].Visible = false;
                    tGridListe.Columns["Gider"].Visible = false;
                    tGridListe.Columns["Aciklama"].Visible = false;
                    tGridListe.Columns["AlisFiyatToplam"].Visible = false;
                }   
                
                
                else if (listFiltrelemeTuru.SelectedIndex == 1) //ÜRÜNLER
                {
                    // Satis tablosundaki verileri sorgula
                    var satisVerileri = db.Satis
                        .Where(x => x.Tarih >= baslangic && x.Tarih <= bitis)
                        .GroupBy(x => new { x.Barkod, x.UrunAd }) // Barkod ve Ürün Adı ile gruplandır
                        .Select(g => new
                        {
                            Barkod = g.Key.Barkod,
                            UrunAd = g.Key.UrunAd,
                            ToplamMiktar = g.Sum(x => x.Miktar), // Toplam miktarı hesapla
                            ToplamTutar = g.Sum(x => x.Toplam)  // Toplam tutarı hesapla
                        })
                        .OrderBy(x => x.UrunAd) // A'dan Z'ye sıralama
                        .ToList();

                    // Verileri tGridListe'ye bağla
                    tGridListe.DataSource = satisVerileri;

                    // Grid başlıklarını ayarla
                    tGridListe.Columns["Barkod"].HeaderText = "Barkod";
                    tGridListe.Columns["UrunAd"].HeaderText = "Ürün Adı";
                    tGridListe.Columns["ToplamMiktar"].HeaderText = "Toplam Miktar";
                    tGridListe.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";

                    // Tablonun sütun genişliklerini otomatik ayarla
                    foreach (DataGridViewColumn column in tGridListe.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            Islemler.GridDuzenle(tGridListe);
            Cursor.Current = Cursors.Default; 



        }

        private void fRapor_Load(object sender, EventArgs e)
        {          
            listFiltrelemeTuru.SelectedIndex = 0;
            tKartKomisyon.Text = Islemler.kartKomisyon().ToString();
            bGoster_Click(null, null);

            tGridListe.Columns["IslemNo"].Visible = false;
            tGridListe.Columns["Iade"].Visible = false;
            //tGridListe.Columns["Nakit"].Visible = false;
            //tGridListe.Columns["Kart"].Visible = false;
            tGridListe.Columns["Gelir"].Visible = false;
            tGridListe.Columns["Gider"].Visible = false;
            tGridListe.Columns["Aciklama"].Visible = false;
            tGridListe.Columns["AlisFiyatToplam"].Visible = false;
            tGridListe.Columns["Kullanici"].Visible = false;







        }

        private void tGridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied= true;
                }
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GİDER";
            f.kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listFiltrelemeTuru.SelectedIndex == 1)
            {
                return;
            }

            int islemno = Convert.ToInt32(tGridListe.CurrentRow.Cells["IslemNo"].Value.ToString());

            if (islemno != 0)
            {
                fDetayGöster f = new fDetayGöster();
                f.islemno = islemno;
                f.ShowDialog();
            }
        }

        private void bRapor_Click(object sender, EventArgs e)
        {
            Raporlar.RaporSayfasiRaporu(tGridListe);
            Raporlar.Baslik = "Genel Rapor";
            Raporlar.SatisNakit = tSatisNakit.Text;
            Raporlar.SatisKart = tSatisKart.Text;   
            Raporlar.IadeNakit = tIadeNakit.Text;
            Raporlar.IadeKart = tIadeKart.Text;
            Raporlar.GelirKart = tGelirKart.Text;
            Raporlar.GelirNakit = tGelirNakit.Text;
            Raporlar.GiderNakit = tGiderNakit.Text;
            Raporlar.GiderKart = tGiderKart.Text;   
            Raporlar.dBaslangic = dBaslangic.Value.ToLongDateString();
            Raporlar.dBitis = dBitis.Value.ToLongDateString();
            Raporlar.KdvToplam = tKdvToplam.Text;
            Raporlar.KartKomisyon = tKartKomisyon.Text;        
        }
    }
}
