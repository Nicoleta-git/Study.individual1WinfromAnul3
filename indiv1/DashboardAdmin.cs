using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace indiv1
{
    public partial class DashboardAdmin : UserControl
    {
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public DashboardAdmin()
        {
            InitializeComponent();
            IncarcaStatistici();
        }

        private void IncarcaStatistici()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmdUtilizatori = new SqlCommand("SELECT COUNT(*) FROM Utilizatori", con);
                nrUtilizatorLbl.Text = cmdUtilizatori.ExecuteScalar().ToString();

                SqlCommand cmdVenit = new SqlCommand("SELECT ISNULL(SUM(PretTotal), 0) FROM Comenzi", con);
                decimal venit = Convert.ToDecimal(cmdVenit.ExecuteScalar());
                venitTotalLbl.Text = (venit / 1000).ToString("0.#") + "k";

                SqlCommand cmdVizitatori = new SqlCommand("SELECT COUNT(*) FROM Clienti", con);
                TotVizitatoriLbl.Text = cmdVizitatori.ExecuteScalar().ToString();

                IncarcaGraficComenzi(con);
                IncarcaGraficCategorii(con);
            }
        }

        private void IncarcaGraficComenzi(SqlConnection con)
        {
            chart1bar.Series.Clear();
            chart1bar.ChartAreas[0].BackColor = Color.Transparent;
            chart1bar.BackColor = Color.Transparent;

            Series series = new Series("Comenzi")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.MediumPurple,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White
            };

            string query = @"SELECT FORMAT(DataComanda, 'MMM') as Luna, COUNT(*) as Total 
                             FROM Comenzi 
                             GROUP BY FORMAT(DataComanda, 'MMM'), MONTH(DataComanda)
                             ORDER BY MONTH(DataComanda)";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                series.Points.AddXY(dr["Luna"].ToString(), dr["Total"]);
            }
            dr.Close();

            chart1bar.Series.Add(series);
            chart1bar.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1bar.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private void IncarcaGraficCategorii(SqlConnection con)
        {
            chart2pie.Series.Clear();
            chart2pie.Legends.Clear();
            chart2pie.BackColor = Color.Transparent;

            Legend lgd = new Legend("CategoriiLegend");
            lgd.BackColor = Color.Transparent;
            lgd.ForeColor = Color.White; 
            chart2pie.Legends.Add(lgd);

            Series series = new Series("Categorii")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Legend = "CategoriiLegend"
            };

            string query = "SELECT Categorie, COUNT(*) as Cantitate FROM Produse GROUP BY Categorie";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int i = series.Points.AddY(Convert.ToDouble(dr["Cantitate"]));
                series.Points[i].LegendText = dr["Categorie"].ToString();
                series.Points[i].Label = "#PERCENT";
            }
            dr.Close();

            chart2pie.Series.Add(series);
        }


    }
}