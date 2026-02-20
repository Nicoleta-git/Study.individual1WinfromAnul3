using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace indiv1
{
    public partial class DashboardAdmin : UserControl
    {
        private Random random = new Random();

        public DashboardAdmin()
        {
            InitializeComponent();
            LoadChart();
            LoadSalesChart();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
        }

        private void chart2_Click(object sender, EventArgs e)
        {
        }

        private void LoadChart()
        {
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Legends.Clear();

            chart2.BackColor = Color.Black;

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Black;
            chart2.ChartAreas.Add(area);

            Legend legend = new Legend("Default");
            legend.ForeColor = Color.Black;
            chart2.Legends.Add(legend);

            Series pieSeries = new Series("Devices")
            {
                ChartType = SeriesChartType.Pie,
                Legend = "Default",
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White
            };

            DataPoint p1 = new DataPoint(0, random.Next(10, 100));
            p1.LegendText = "Mac";
            pieSeries.Points.Add(p1);

            DataPoint p2 = new DataPoint(0, random.Next(10, 100));
            p2.LegendText = "Windows";
            pieSeries.Points.Add(p2);

            DataPoint p3 = new DataPoint(0, random.Next(10, 100));
            p3.LegendText = "Linux";
            pieSeries.Points.Add(p3);

            chart2.Series.Add(pieSeries);
        }

        private void LoadSalesChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            chart1.BackColor = Color.Black;

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Black;
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.MajorGrid.LineColor = Color.Gray; 
            area.AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas.Add(area);

            Legend legend = new Legend("Default");
            legend.ForeColor = Color.White;
            legend.BackColor = Color.Black;
            legend.Docking = Docking.Top;
            chart1.Legends.Add(legend);

            Series barSeries = new Series("Sales")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.CornflowerBlue,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Legend = "Default"
            };

            barSeries.Points.Add(new DataPoint(0, random.Next(50, 200)) { AxisLabel = "January", LegendText = "January" });
            barSeries.Points.Add(new DataPoint(0, random.Next(50, 200)) { AxisLabel = "February", LegendText = "February" });
            barSeries.Points.Add(new DataPoint(0, random.Next(50, 200)) { AxisLabel = "March", LegendText = "March" });
            barSeries.Points.Add(new DataPoint(0, random.Next(50, 200)) { AxisLabel = "April", LegendText = "April" });

            chart1.Series.Add(barSeries);
        }



    }
}