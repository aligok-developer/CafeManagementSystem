using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Gerekli alanların kontrolü
                if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                    string.IsNullOrWhiteSpace(txtAdres.Text))
                {
                    MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni müşteri oluştur
                using (var db = new BarkodDbEntities())
                {
                    var musteri = new musteriVeresiye
                    {
                        Ad = txtAd.Text.Trim(),
                        Telefon = txtTelefon.Text.Trim(),
                        Adres = txtAdres.Text.Trim(),
                        Eposta = string.IsNullOrWhiteSpace(txtEposta.Text) ? null : txtEposta.Text.Trim(),
                        BorcTutari = 0,
                        veresiyeYazdirmaTarihi = DateTime.Now,
                        veresiyeOdemeTarihi = null,
                        IslemTuru = "ToplamBorc" // Varsayılan işlem türü
                    };

                    db.musteriVeresiye.Add(musteri);
                    db.SaveChanges();
                }

                MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (DbEntityValidationException ex)
            {
                // Hata detaylarını konsola yazdır
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                    }
                }

                MessageBox.Show("Doğrulama hatası meydana geldi. Lütfen gerekli alanları kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            txtAd.Focus();
        }
    }
}

