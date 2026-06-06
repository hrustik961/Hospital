using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 
using Npgsql;

namespace Hospital
{
    public partial class ReportsForm : Form
    {
        private string connString = Form1.ConnectionString;

        private Chart chartReport;

        public ReportsForm()
        {
            InitializeComponent();
            this.Text = "Звіт";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            СтворитиГрафікВручну();

            ЗавантажитиАналітику();
        }

        private void СтворитиГрафікВручну()
        {
            chartReport = new Chart();
            chartReport.Size = new Size(420, 350); 
            chartReport.Location = new Point(350, 60);

            ChartArea chartArea = new ChartArea("MainArea");
            chartReport.ChartAreas.Add(chartArea);

            Legend legend = new Legend("MainLegend");
            chartReport.Legends.Add(legend);

            this.Controls.Add(chartReport);
        }

        private void ЗавантажитиАналітику()
        {
            string query = "SELECT s.\"RoomNum\" AS \"Палата\", " +
                           "COUNT(s.\"Pid\") AS \"Кількість пацієнтів\", " +
                           "ROUND(AVG(s.\"Price\"), 2) AS \"Середня вартість лікування\" " +
                           "FROM \"SEESION\" s " +
                           "GROUP BY s.\"RoomNum\" " +
                           "ORDER BY s.\"RoomNum\"";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvReport.DataSource = dt;

                        chartReport.Series.Clear();
                        chartReport.Titles.Clear();
                        chartReport.Titles.Add("Розподіл пацієнтів за палатами");

                        Series series = new Series("Пацієнти у палаті")
                        {
                            ChartType = SeriesChartType.Pie, 
                            XValueMember = "Палата",
                            YValueMembers = "Кількість пацієнтів"
                        };

                        series["PieLabelStyle"] = "Inside";
                        series.IsValueShownAsLabel = true;

                        chartReport.Series.Add(series);
                        chartReport.DataSource = dt;
                        chartReport.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка побудови" + ex.Message, "Помилка СУБД");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Form1"];
            if (main != null) main.Show();
            this.Close();
        }
    }
}