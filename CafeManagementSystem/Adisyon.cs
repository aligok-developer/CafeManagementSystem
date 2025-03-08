using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class Adisyon : Form
    {
        // Her masa butonu için bir sipariş listesi
        private Dictionary<Button, List<OrderItem>> tableOrders = new Dictionary<Button, List<OrderItem>>();

        // Diziyle butonları kontrol edelim
        private Button[] butonlar;
        public List<OrderItem> GetOrderListForTable(Button tableButton)
        {
            return tableOrders.ContainsKey(tableButton) ? tableOrders[tableButton] : new List<OrderItem>();
        }

        public Adisyon()
        {
            InitializeComponent();
            InitializeTables();

            // Butonları diziye ekliyoruz
            butonlar = new Button[]
            {
                bStandart1, bStandart2, bStandart3, bStandart4, bStandart5,
                bStandart6, bStandart7, bStandart8, bStandart9, bStandart10,
                bStandart11, bStandart12, bStandart13, bStandart14, bStandart15,
                bStandart16, bStandart17, bStandart18, bStandart19, bStandart20,
                bStandart21, bStandart22, bStandart23, bStandart24, bStandart25,
                bStandart26, bStandart27, bStandart28, bStandart29, bStandart30,
                bStandart31, bStandart32, bStandart33, bStandart34, bStandart35,
                bStandart36, bStandart37, bStandart38, bStandart39, bStandart40,
                bStandart41, bStandart42, bStandart43, bStandart44, bStandart45,
                bStandart46, bStandart47, bStandart48, bStandart49
            };

            // İlk buton zaten görünür, diğerlerine müdahale etmiyoruz
        }

        private void InitializeTables()
        {
            // Form yüklendiğinde her buton için boş bir liste oluşturup dictionary'e ekliyoruz
            foreach (Button tableButton in this.Controls.OfType<Button>())
            {
                tableOrders[tableButton] = new List<OrderItem>();
                tableButton.Click += TableButton_Click; // Butona tıklandığında işlem yapacağız
            }
        }
        public void KaydirVeGuncelle(int tamamlananButonIndex)
        {
            int visibleButtonCount = butonlar.Count(b => b.Visible); // Görünür buton sayısını al

            for (int i = tamamlananButonIndex; i < visibleButtonCount - 1; i++)
            {
                // Geçici değişkenler kullanarak verileri kaydırma
                string nextButtonText = butonlar[i + 1].Text;
                System.Drawing.Color nextButtonColor = butonlar[i + 1].BackColor;
                bool nextButtonVisible = butonlar[i + 1].Visible;
                List<OrderItem> nextButtonOrderList = new List<OrderItem>();
                string nextGenelToplam = string.Empty;


                // Dizideki verileri deep copy ile kopyalama
                if (tableOrders.ContainsKey(butonlar[i + 1]))
                {
                    foreach (var item in tableOrders[butonlar[i + 1]])
                    {
                        nextButtonOrderList.Add(new OrderItem
                        {
                            ItemName = item.ItemName,
                            Price = item.Price,
                            Quantity = item.Quantity,
                            BarkodDeneme = item.BarkodDeneme,
                            UrunGrup = item.UrunGrup,
                            AlisFiyat = item.AlisFiyat,
                            SatisFiyat = item.SatisFiyat,
                            KdvTutari = item.KdvTutari,
                            Birim = item.Birim,
                            GenelToplam = item.GenelToplam

                        });
                        
                    }
                }

                // Mevcut butona bir sonraki butonun bilgilerini aktar
                butonlar[i].Text = nextButtonText;
                butonlar[i].BackColor = nextButtonColor;
                butonlar[i].Visible = nextButtonVisible;

                // Dizideki verileri de aktarma
                if (tableOrders.ContainsKey(butonlar[i]))
                {
                    tableOrders[butonlar[i]] = nextButtonOrderList;
                }
                else
                {
                    tableOrders.Add(butonlar[i], nextButtonOrderList);
                }
            }

            // Son görünür butonu sıfırla (tüm bilgileri temizle)
            if (visibleButtonCount > 0)
            {
                Button lastButton = butonlar[visibleButtonCount - 1];
                lastButton.Visible = false;
                lastButton.Text = "+";
                lastButton.BackColor = System.Drawing.Color.Tomato;

                // Dizideki bilgiyi sil
                if (tableOrders.ContainsKey(lastButton))
                {
                    tableOrders.Remove(lastButton);
                }
            }
        }


       

        public int GetButtonIndex(Button button)
        {
            return Array.IndexOf(butonlar, button);
        }

        public Button GetButton(int buttonIndex)
        {
            return butonlar[buttonIndex];
        }
        public List<OrderItem> GetOrdersForButton(Button tableButton)
        {
            if (tableOrders.ContainsKey(tableButton))
            {
                return tableOrders[tableButton];
            }
            return new List<OrderItem>();
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // fSatis formunu açıp sipariş ekleme işlemi yapacağız
                OpenSalesForm(clickedButton);
            }
        }

        private void OpenSalesForm(Button tableButton)
        {
            if (tableOrders.ContainsKey(tableButton))
            {
                fSatis satisForm = new fSatis(tableButton, tableOrders[tableButton], this);
                satisForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu masaya ait bir sipariş bulunamadı.");
            }
        }
        // Tıklanan butonun text'ini güncelleyen ve bir sonraki butonu görünür yapan fonksiyon
        public void UpdateBtnText(int buttonIndex, string text)
        {
            if (buttonIndex < butonlar.Length)
            {
                // Tıklanan butonun text'ini güncelle
                butonlar[buttonIndex].Text = text;
                butonlar[buttonIndex].BackColor = System.Drawing.Color.Green;

                // Bir sonraki buton varsa, görünür yap
                if (buttonIndex + 1 < butonlar.Length)
                {
                    butonlar[buttonIndex + 1].Visible = true;
                }
            }
        }



        // Ortak Click event handler'ı
        private void bStandart_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Eğer butonun rengi Tomato ise Veresiye2 formu açılır
                if (clickedButton.BackColor == System.Drawing.Color.Tomato)
                {
                    adisyonEkle veresiye2Form = new adisyonEkle(this, Array.IndexOf(butonlar, clickedButton));
                    veresiye2Form.ShowDialog();
                }
                // Eğer butonun rengi Green ise fSatis formu açılır
                else if (clickedButton.BackColor == System.Drawing.Color.Green)
                {
                    if (tableOrders.ContainsKey(clickedButton))
                    {
                        fSatis satisForm = new fSatis(clickedButton, tableOrders[clickedButton], this);
                        satisForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bu masaya ait bir sipariş bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void UpdateOrderListForTable(Button tableButton, List<OrderItem> newOrders)
        {
            if (tableOrders.ContainsKey(tableButton))
            {
                tableOrders[tableButton] = newOrders; // Mevcut sipariş listesini güncelle
            }
            else
            {
                tableOrders.Add(tableButton, newOrders); // Yeni sipariş listesi ekle
            }
        }

        private void Adisyon_Load(object sender, EventArgs e)
        {

        }

        
    }
}
