using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        // Наш єдиний рядок підключення для всієї програми
        public static string ConnectionString = "Host=localhost;Port=5432;Database=HospitalDB;Username=hrustunka;Password=postgres";

        public Form1()
        {
            InitializeComponent();
            this.Text = "Головне меню";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Відкриваємо форму введення даних
        private void btnOpenInput_Click(object sender, EventArgs e)
        {
            // ВИПРАВЛЕНО: Створюємо саме InputForm, а не dgvPatients!
            InputForm f = new InputForm();
            f.Show();
            this.Hide(); // Сховуємо меню
        }

        // Відкриваємо форму із запитами
        private void btnOpenQueries_Click(object sender, EventArgs e)
        {
            QueriesForm f = new QueriesForm();
            f.Show();
            this.Hide(); // Сховуємо меню
        }

        // Відкриваємо форму зі звітами та графіками
        private void btnOpenReports_Click(object sender, EventArgs e)
        {
            ReportsForm f = new ReportsForm();
            f.Show();
            this.Hide(); // Сховуємо меню
        }
    }
}