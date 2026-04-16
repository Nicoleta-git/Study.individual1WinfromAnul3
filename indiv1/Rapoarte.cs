using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace indiv1
{
    public partial class Rapoarte : UserControl
    {
        public Rapoarte()
        {
            InitializeComponent();
            this.Load += Rapoarte_Load;
        }

        private void Rapoarte_Load(object sender, EventArgs e)
        {
            try
            {
                this.produseTableAdapter.Fill(this.darwinDBDataSet.Produse);
                this.reportViewer1.RefreshReport();

                this.sp_TopProduseVanduteTableAdapter.Fill(
                    this.darwinDBDataSet.sp_TopProduseVandute,
                    5
                );
                this.reportViewer2.RefreshReport();

                this.clientiTableAdapter1.Fill(this.darwinDBDataSet.Clienti);

                this.reportViewer3.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataSet1", this.darwinDBDataSet.Clienti.DefaultView);

                this.reportViewer3.LocalReport.DataSources.Add(rds);
                this.reportViewer3.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message,
                    "Report error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void darwinTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void darwinTabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
