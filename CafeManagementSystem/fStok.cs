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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarkodluSatis
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        BarkodDbEntities dbx = new BarkodDbEntities();

        private void bAra_Click(object sender, EventArgs e)
        {
            tGridListe.DataSource = null;

            using (var db = new BarkodDbEntities())
            {
                if (cmbIslemTuru.Text != "")
                {
                    string urungrubu = cmbUrunGrubu.Text;

                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            tGridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rdUrunGrubu.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            tGridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Herhangi bir filtreleme yapmadınız");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.StokHaraket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            tGridListe.DataSource = db.StokHaraket.Local.ToBindingList();
                        }
                        else if (rdUrunGrubu.Checked)
                        {
                            db.StokHaraket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            tGridListe.DataSource = db.StokHaraket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Herhangi bir filtreleme yapmadınız");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İşlem türünü seçiniz");
                }
            }
            tGridListe.Columns["Barkod"].Visible = false;
            tGridListe.Columns["Birim"].Visible = false;
            tGridListe.Columns["KdvOrani"].Visible = false;
            tGridListe.Columns["KdvTutari"].Visible = false;
            tGridListe.Columns["AlisFiyat"].Visible = false;
            tGridListe.Columns["Aciklama"].Visible = false;
            tGridListe.Columns["Onay"].Visible = false;
            tGridListe.Columns["Tarih"].Visible = false;

            



            Islemler.GridDuzenle(tGridListe);
        }
        private void bRapor_Click(object sender, EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == 0)
            {
                Raporlar.Baslik = cmbIslemTuru.Text + "RAPORU";
                Raporlar.dBaslangic = dBaslangic.Value.ToShortDateString();
                Raporlar.dBitis = dBitis.Value.ToShortDateString();
                Raporlar.StokSayfasiRaporu(tGridListe);
            }
            else if (cmbIslemTuru.SelectedIndex == 1)
            {
                Raporlar.Baslik = cmbIslemTuru.Text + "RAPORU";
                Raporlar.dBaslangic = dBaslangic.Value.ToShortDateString();
                Raporlar.dBitis = dBitis.Value.ToShortDateString();
                Raporlar.StokİzlemeRaporu(tGridListe);
            }
        }
        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
            cmbIslemTuru.SelectedIndex = 0; // İlk öğeyi seçili yapar
        }
        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 1)
            {
                string urunad = tUrunAra.Text;

                using (var db = new BarkodDbEntities())
                {
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        tGridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHaraket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        tGridListe.DataSource = db.StokHaraket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(tGridListe);
            }
        }
    }
}

