using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fSatis : Form
    {
        public List<OrderItem> Orders { get; private set; } = new List<OrderItem>();

        private Adisyon veresiyeForm;
        private Button _currentTableButton;
        private List<OrderItem> _currentOrders;

        private Button _tableButton;
        private List<OrderItem> _orderList;
        private Adisyon _parentForm; // Adisyon formuna referans

        private Button _currentButton;
        private List<OrderItem> _currentOrderList;


        public fSatis(Button tableButton, List<OrderItem> tableOrders, Adisyon parentForm)
        {
            InitializeComponent();

            _currentButton = tableButton;
            _currentOrderList = tableOrders;
            _parentForm = parentForm;

            LoadOrdersToGrid();
        }


        private void LoadOrdersToGrid()
        {
            gridSatisListesi.Rows.Clear();
            foreach (var order in _currentOrderList)
            {
                int rowIndex = gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[rowIndex].Cells["UrunAdi"].Value = order.ItemName;
                gridSatisListesi.Rows[rowIndex].Cells["Fiyat"].Value = order.Price;
                gridSatisListesi.Rows[rowIndex].Cells["miktari"].Value = order.Quantity;
                gridSatisListesi.Rows[rowIndex].Cells["Barkod"].Value = order.BarkodDeneme;
                
                gridSatisListesi.Rows[rowIndex].Cells["UrunGrup"].Value = order.UrunGrup;
                gridSatisListesi.Rows[rowIndex].Cells["Birim"].Value = order.Birim;
                gridSatisListesi.Rows[rowIndex].Cells["Toplam"].Value = Math.Round(order.Quantity * (double)order.SatisFiyat, 2);
                gridSatisListesi.Rows[rowIndex].Cells["AlisFiyat"].Value = order.AlisFiyat;
                gridSatisListesi.Rows[rowIndex].Cells["KdvTutari"].Value = order.KdvTutari;
                tGenelToplam.Text = order.GenelToplam;
                //devam
            }
        }

        BarkodDbEntities db = new BarkodDbEntities();

        private void fSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");

            using (var db = new BarkodDbEntities())
            {
                try
                {
                    KartKomisyonSabit sabit = db.KartKomisyonSabit.FirstOrDefault();
                    fSatischYazdirma.Checked = Convert.ToBoolean(sabit.Yazici);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                    throw;
                }
            }
        }

        private void LoadOrders(List<OrderItem> orders)
        {
            gridSatisListesi.Rows.Clear();

            foreach (var order in orders)
            {
                gridSatisListesi.Rows.Add(order.ItemName, order.Quantity, order.Price, order.BarkodDeneme, order.UrunGrup, order.AlisFiyat, order.SatisFiyat, order.KdvTutari, order.Birim); //devam
            }
        }

        

        private void HizliButonDoldur() // BURDA BİR HATA ALIYORUZ AMA ÇÖZEMEDİM
        {
            var hizliurun = db.HizliUrun.ToList();
            foreach (var item in hizliurun)
            {
                Button bH = this.Controls.Find("bH" + item.Id, true).FirstOrDefault() as Button;
                if (bH != null)
                {
                    double fiyat = Islemler.DoubleYap(item.Fiyat.ToString());
                    bH.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }
        private void HizliButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));

            if (b.Text.ToString().StartsWith("-"))
            {
                fUrunEkle f = new fUrunEkle();
                f.lButonId.Text = butonid.ToString();
                f.ShowDialog();
            }
            

            var urunbarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault();
            var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
            UrunGetirListeye(urun, urunbarkod, Convert.ToDouble(tMiktar.Text));
            GenelToplam();
        }
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();

                if (barkod.Length <= 2)
                {
                    tMiktar.Text = barkod;
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        UrunGetirListeye(urun, barkod, Convert.ToDouble(tMiktar.Text));
                    }
                    else
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onek))
                        {
                            string teraziurunno = barkod.Substring(2, 5); // barkod alanına 27 sonrası
                                                                          // tek bir rakam yazarsak hata alıyoruz  

                            if (db.Urun.Any(a => a.Barkod == teraziurunno))
                            {
                                var urunterazi = db.Urun.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListeye(urunterazi, teraziurunno, miktarkg);
                            }
                            else
                            {
                                Console.Beep(900, 500);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 500);
                            fUrunGiris f = new fUrunGiris();
                            f.tBarkod.Text = barkod;
                            f.ShowDialog();
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();
            }
        }
        private void UrunGetirListeye(Urun urun, string barkod, double miktar)
        {
            if (urun == null)
            {
                //MessageBox.Show("Ürün bulunamadı!");
                return;
            }

            int satirsayisi = gridSatisListesi.Rows.Count;
            double miktari = Convert.ToDouble(tMiktar.Text);
            bool eklenmismi = false;

            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        // Alışveriş sepetindeki miktarı güncelle
                        gridSatisListesi.Rows[i].Cells["miktari"].Value =
                            miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["miktari"].Value);

                        gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(
                            Convert.ToDouble(gridSatisListesi.Rows[i].Cells["miktari"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi)
            {
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["miktari"].Value = miktar;
                gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.KdvTutari;
            }
        }
        
        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow);
                gridSatisListesi.ClearSelection();
                GenelToplam();
                tBarkod.Focus();
            }
        }
        private void bn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;

                if (!b.Text.StartsWith("-"))
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt32(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();
            Button b = this.Controls.Find("bH" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + 0.ToString("C2"); ;

        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Name == "bNV") // Virgül kontrolü için buton adını kullan
            {
                // Virgül kontrolü: Mevcut metinde virgül var mı?
                if (!tNumarator.Text.Contains(","))
                {
                    tNumarator.Text += ",";
                }
            }
            else if (b.Name == "bNB") // Backspace kontrolü için buton adını kullan
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                }
            }
            else
            {
                tNumarator.Text += b.Text;
            }
        }
        private void bAdet_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                tMiktar.Text = tNumarator.Text;
                tNumarator.Clear();
                tBarkod.Clear();
                tBarkod.Focus();
            }
        }
        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                double sonuc = Islemler.DoubleYap(tNumarator.Text) - Islemler.DoubleYap(tGenelToplam.Text);
                tParaUstu.Text = sonuc.ToString("C2");
                tOdenen.Text = Islemler.DoubleYap(tNumarator.Text).ToString("C2");
                tNumarator.Clear();
                tBarkod.Focus();
            }
        }
        private void bBarkod_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                if (db.Urun.Any(a => a.Barkod == tNumarator.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == tNumarator.Text).FirstOrDefault();
                    UrunGetirListeye(urun, tNumarator.Text, Convert.ToDouble(tMiktar.Text));
                    tNumarator.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    MessageBox.Show("Ürün Ekleme Sayfasını Aç");
                }
            }
        }
        private void ParaUstuHesapla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = Islemler.DoubleYap(b.Text) - Islemler.DoubleYap(tGenelToplam.Text);
            tOdenen.Text = Islemler.DoubleYap(b.Text).ToString("C2");
            tParaUstu.Text = sonuc.ToString("C2");
        }
        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                int satirsayisi = gridSatisListesi.Rows.Count;
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                gridSatisListesi.Rows[satirsayisi].Cells["miktari"].Value = 1;
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(tNumarator.Text);
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(tNumarator.Text);
                tNumarator.Text = "";
                GenelToplam();
                tBarkod.Focus();
            }
        }
        private void bIade_Click(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                chSatisIadeIslemi.Checked = false;
                chSatisIadeIslemi.Text = " Satış Yapılıyor";
            }
            else
            {
                chSatisIadeIslemi.Checked = true;
                chSatisIadeIslemi.Text = " İade İşlemi";
            }
        }
        private void bTemizle_Click(object sender, EventArgs e) => Temizle();
        private void Temizle()
        {
            tMiktar.Text = "1";
            tBarkod.Clear();
            tOdenen.Clear();
            tParaUstu.Clear();
            tGenelToplam.Text = 0.ToString("C2");
            chSatisIadeIslemi.Checked = false;
            tNumarator.Clear();
            tNumarator.Text = "0";
            gridSatisListesi.Rows.Clear();
            tBarkod.Clear();
            tBarkod.Focus();
        }
        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }
        private void bKart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
        }
        public void SatisYap(string odemesekli)
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            bool satisiade = chSatisIadeIslemi.Checked;
            double alisfiyattoplam = 0;

            if (satirsayisi > 0)
            {
                int? islemno = db.Islem.First()?.IslemNo;
                Satis satis = new Satis();

                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.IslemNo = islemno;
                    satis.UrunAd = gridSatisListesi.Rows[i].Cells["UrunAdi"].Value.ToString();
                    satis.UrunGrup = gridSatisListesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = gridSatisListesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.SatisFiyat = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktari"].Value.ToString());
                    satis.Toplam = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KdvTutari = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["KdvTutari"].Value.ToString()) * Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktari"].Value.ToString());
                    satis.OdemeSekli = odemesekli;
                    satis.Iade = satisiade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lKullanici.Text;

                    db.Satis.Add(satis);
                    db.SaveChanges();
                    alisfiyattoplam += Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString());

                    try
                    {
                        if (!satisiade)
                        {
                            Islemler.StokAzalt(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktari"].Value.ToString()));
                        }
                        else
                        {
                            Islemler.StokArttir(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["miktari"].Value.ToString()));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata oluştu: " + ex.Message);
                    }
                }

                IslemOzet io = new IslemOzet();
                io.IslemNo = islemno;
                io.Iade = satisiade;
                io.AlisFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;

                if (satisiade)
                {
                    io.Aciklama = "İade işlemi (" + odemesekli + ")";
                }
                else
                {
                    io.Aciklama = odemesekli + "Satış";
                }

                io.OdemeSekli = odemesekli;
                io.Kullanici = lKullanici.Text;
                io.Tarih = DateTime.Now;

                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakit = Islemler.DoubleYap(tGenelToplam.Text);

                        io.Kart = 0;
                        break;

                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = Islemler.DoubleYap(tGenelToplam.Text);
                        break;

                    case "Kart-Nakit":
                        io.Nakit = Islemler.DoubleYap(lNakit.Text);
                        io.Kart = Islemler.DoubleYap(lKart.Text);
                        break;
                }
                db.IslemOzet.Add(io);
                db.SaveChanges();


                var islemnoartir = db.Islem.First();
                islemnoartir.IslemNo += 1;
                db.SaveChanges();


                

                this.Close();

                // Satış sonrası kaydırma işlemi yap
                int tamamlananButonIndex = _parentForm.GetButtonIndex(_currentButton);
                _parentForm.KaydirVeGuncelle(tamamlananButonIndex);

            }
        }




        private void bKartNakit_Click(object sender, EventArgs e)
        {
            fNakitKart f = new fNakitKart();
            f.ShowDialog();
        }
        private void fSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SatisYap("Nakit");
            }
            if (e.KeyCode == Keys.F2)
            {
                SatisYap("Kart");
            }
            if (e.KeyCode == Keys.F3)
            {
                fNakitKart f = new fNakitKart();
                f.ShowDialog();
            }
        }
        private void bIslemBeklet_Click(object sender, EventArgs e)
        {
            if (bIslemBeklet.Text == "Kasa-1")
            {
                Bekle();
                bIslemBeklet.BackColor = System.Drawing.Color.OrangeRed;
                bIslemBeklet.Text = "Kasa 1 bekliyor";
                gridSatisListesi.Rows.Clear();
            }
            else
            {
                beklemedencik();
                bIslemBeklet.BackColor = System.Drawing.Color.DimGray;
                bIslemBeklet.Text = "Kasa-1";
                gridBekle.Rows.Clear();
            }
        }

        private void Bekle()
        {
            int satir = gridSatisListesi.Rows.Count;
            int sutun = gridSatisListesi.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    gridBekle.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        gridBekle.Rows[i].Cells[j].Value = gridSatisListesi.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
        private void beklemedencik()
        {
            int satir = gridBekle.Rows.Count;
            int sutun = gridBekle.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    gridSatisListesi.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        gridSatisListesi.Rows[i].Cells[j].Value = gridBekle.Rows[i].Cells[j].Value;
                    }
                }
            }
        }

        private void chSatisIadeIslemi_CheckedChanged(object sender, EventArgs e)
        {
            if (chSatisIadeIslemi.Checked)
            {
                chSatisIadeIslemi.Text = "İade Yapılıyor";

            }
            else
            {
                chSatisIadeIslemi.Text = " Satış Yapılıyor";
            }
        }

        public string GenelToplamText
        {
            get { return tGenelToplam.Text; }
        }


        private void GenelToplam()
        {
            double toplam = 0;
            for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value);
            }
            tGenelToplam.Text = toplam.ToString("C2");
            tMiktar.Text = "1";
            tBarkod.Clear();
            tBarkod.Focus();
        }

        private void btnVeresiyeYazdir_Click(object sender, EventArgs e)
        {
            // 1. gridSatisListesi'ndeki ürünleri Satis tablosuna kaydet
            using (var db = new BarkodDbEntities())
            {
                foreach (DataGridViewRow row in gridSatisListesi.Rows)
                {
                    if (row.Cells["Barkod"].Value != null && row.Cells["UrunAdi"].Value != null)
                    {
                        var satis = new Satis
                        {
                            Barkod = row.Cells["Barkod"].Value.ToString(),
                            UrunAd = row.Cells["UrunAdi"].Value.ToString(),
                            Miktar = Convert.ToDouble(row.Cells["miktari"].Value),
                            Toplam = Convert.ToDouble(row.Cells["Toplam"].Value),
                            OdemeSekli = "Veresiye", // Sabit değer
                            Tarih = DateTime.Now, // İstersen null yap
                            Kullanici = null // Eğer kullanıcı kaydı yoksa null
                        };

                        db.Satis.Add(satis);
                    }
                }
                db.SaveChanges();
            }
            // 3. Veresiye formunu aç
            frmVeresiye veresiyeForm = new frmVeresiye(this);
            veresiyeForm.ShowDialog();

            this.Close();

            // Satış sonrası kaydırma işlemi yap
            int tamamlananButonIndex = _parentForm.GetButtonIndex(_currentButton);
            _parentForm.KaydirVeGuncelle(tamamlananButonIndex);
        }


        private void fSatis_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Önce mevcut sipariş listesini temizliyoruz
            _currentOrderList.Clear();

            // Grid'deki her satırı tek tek kontrol ediyoruz
            foreach (DataGridViewRow row in gridSatisListesi.Rows)
            {
                if (row.Cells["UrunAdi"].Value != null) // Satırda ürün adı var mı kontrol ediyoruz
                {
                    string itemName = row.Cells["UrunAdi"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["miktari"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Fiyat"].Value);
                    string barkodDeneme = row.Cells["Barkod"].Value.ToString();
                    string urunGrup = row.Cells["UrunGrup"].Value.ToString();
                    string birim = row.Cells["Birim"].Value.ToString();
                    double? alisFiyat = row.Cells["AlisFiyat"].Value != null ? Convert.ToDouble(row.Cells["AlisFiyat"].Value) : (double?)null;
                    double? satisFiyat = row.Cells["Fiyat"].Value != null ? Convert.ToDouble(row.Cells["Fiyat"].Value) : (double?)null;
                    double? kdvTutari = row.Cells["KdvTutari"].Value != null ? Convert.ToDouble(row.Cells["KdvTutari"].Value) : (double?)null;
                    string geneltoplam = tGenelToplam.Text;
                    // Yeni bir OrderItem nesnesi oluşturuyoruz
                    OrderItem order = new OrderItem
                    {
                        ItemName = itemName,
                        Quantity = quantity,
                        Price = price,
                        BarkodDeneme = barkodDeneme,
                        UrunGrup = urunGrup,
                        Birim = birim,
                        AlisFiyat = alisFiyat,
                        SatisFiyat = satisFiyat,
                        KdvTutari = kdvTutari,
                        GenelToplam = geneltoplam
                    };

                    // Siparişi mevcut listeye ekliyoruz
                    _currentOrderList.Add(order);
                }
            }

            // Güncellenen listeyi parent forma aktarıyoruz
            _parentForm.UpdateOrderListForTable(_currentButton, _currentOrderList);
        }
        


    }
}