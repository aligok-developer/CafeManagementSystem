using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;



namespace BarkodluSatis
{
    public partial class fBaslangic : Form
    {
        internal fBaslangic()
        {
            InitializeComponent();
        }
        internal void bSatisİslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Adisyon f = new Adisyon();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        internal void bRaporİslemi_Click(object sender, EventArgs e)
        {   
            Cursor.Current = Cursors.WaitCursor;
            fRapor f = new fRapor();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();  
            Cursor.Current = Cursors.Default;
        }
        internal void bStokİslemi_Click(object sender, EventArgs e)
        {   
            Cursor.Current = Cursors.WaitCursor;
            fStok f = new fStok();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        internal void bUrunİslemi_Click(object sender, EventArgs e)
        {   
            Cursor.Current = Cursors.WaitCursor;
            fUrunGiris f = new fUrunGiris();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        internal void bFiyatİslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fFiyatGuncelle f = new fFiyatGuncelle();
            //f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        internal void bCikisİslemi_Click(object sender, EventArgs e)
        {
            frmVeresiyeTakip f = new frmVeresiyeTakip();
            f.ShowDialog();
        }
        internal void bAyarİslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fAyarlar f = new fAyarlar();
            //f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        internal void bYedeklemeİslemi_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 1) LocalDB instance’ını durdur
                // sqllocaldb stop komutu, ilgili LocalDB instance’ını durdurur.
                // Bu sayede MDF/ldf dosyaları kilitli olmaktan çıkar.
                var psi = new ProcessStartInfo("sqllocaldb", "stop " + "MSSQLLocalDB")
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                var p = Process.Start(psi);
                p.WaitForExit();
                // Varsayılan LocalDB instance adı "MSSQLLocalDB"dir
                // Farklı bir instance kullanıyorsanız burayı değiştirin.

                // 2) Dosyaları kopyala
                string appPath = Application.StartupPath;
                string[] dbFiles = { "BarkodDb.mdf", "BarkodDb_log.ldf" };

                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Yedek dosyaların kopyalanacağı klasörü seçin";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string backupFolder = fbd.SelectedPath;
                        foreach (string dbFile in dbFiles)
                        {
                            string sourceFile = Path.Combine(appPath, dbFile);
                            if (File.Exists(sourceFile))
                            {
                                string destFile = Path.Combine(backupFolder, dbFile);
                                File.Copy(sourceFile, destFile, true);
                            }
                        }

                        MessageBox.Show("Yedekleme işlemi başarıyla tamamlandı.",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // 3) (İsteğe Bağlı) Uygulamayı kapatmak veya LocalDB’yi tekrar başlatmak isteyebilirsiniz
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void bKullaiciİslemi_Click(object sender, EventArgs e)
        {
            fGiris login = new fGiris();
            login.Show();
            this.Hide();
        }

        private void fBaslangic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Tüm işlemleri ve formaları temizler
        }
    }
}
