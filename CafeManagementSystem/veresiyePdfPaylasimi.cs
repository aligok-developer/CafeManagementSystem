using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class veresiyePdfPaylasimi : Form
    {
        private DateTime _startDate;
        private DateTime _endDate;

        public veresiyePdfPaylasimi(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            _startDate = startDate;
            _endDate = endDate;
        }

        private void veresiyePdfPaylasimi_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {
            try
            {
                // RDLC rapor dosyasını bağla
                reportViewer1.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "veresiyeRapor.rdlc");

                // Veriyi al ve rapora bağla
                DataTable veresiyeData = GetVeresiyeData();
                ReportDataSource dataSource = new ReportDataSource("veresiyeM", veresiyeData);  // 'veresiyeM' veri kaynağına bağla

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);

                // Raporu yenile
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rapor oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable GetVeresiyeData()
        {
            try
            {
                using (var db = new BarkodDbEntities())
                {
                    // Tarih aralığını saat kısmı dahil olmadan ayarla
                    DateTime startDate = _startDate.Date; // 00:00:00
                    DateTime endDate = _endDate.Date.AddDays(1).AddTicks(-1); // 23:59:59

                    var veresiyeData = (from v in db.musteriVeresiye
                                        where v.veresiyeYazdirmaTarihi >= startDate
                                              && v.veresiyeYazdirmaTarihi <= endDate
                                        select new
                                        {
                                            v.ID,
                                            v.MusteriID,
                                            v.Ad,
                                            v.Telefon,
                                            v.Adres,
                                            v.Eposta,
                                            v.BorcTutari,
                                            v.veresiyeYazdirmaTarihi,
                                            v.veresiyeOdemeTarihi,
                                            v.IslemTuru
                                        }).ToList();

                    // DataTable oluştur ve verileri ekle
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("MusteriID", typeof(int));
                    dt.Columns.Add("Ad", typeof(string));
                    dt.Columns.Add("Telefon", typeof(string));
                    dt.Columns.Add("Adres", typeof(string));
                    dt.Columns.Add("Eposta", typeof(string));
                    dt.Columns.Add("BorcTutari", typeof(decimal));
                    dt.Columns.Add("veresiyeYazdirmaTarihi", typeof(DateTime));
                    dt.Columns.Add("veresiyeOdemeTarihi", typeof(DateTime));
                    dt.Columns.Add("IslemTuru", typeof(string));

                    foreach (var item in veresiyeData)
                    {
                        dt.Rows.Add(item.ID, item.MusteriID, item.Ad, item.Telefon, item.Adres, item.Eposta, item.BorcTutari, item.veresiyeYazdirmaTarihi, item.veresiyeOdemeTarihi, item.IslemTuru);
                    }

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
