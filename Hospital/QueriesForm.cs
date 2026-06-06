using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Hospital
{
    public partial class QueriesForm : Form
    {
        private string connString = Form1.ConnectionString;

        public QueriesForm()
        {
            InitializeComponent();
            this.Text = "Запити";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void QueriesForm_Load(object sender, EventArgs e)
        {
            lstQueries.Items.Clear();
            lstQueries.Items.Add("1.Пацієнти за відділенням");
            lstQueries.Items.Add("2.Пошук за телефоном");
            lstQueries.Items.Add("3.Лікарі вище вказаної ЗП");
            lstQueries.Items.Add("4.Пацієнти у палаті");
            lstQueries.Items.Add("5.Спеціальність лікаря");
            lstQueries.Items.Add("6.Порожні відділення");
            lstQueries.Items.Add("7.Спільні лікарі");

            lstQueries.SelectedIndex = 0; 
        }

        private void lstQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstQueries.SelectedIndex;

            txbParamText.Visible = false;
            txbParamNumber.Visible = false;

            switch (index)
            {
                case 0:
                    tabQueryPage.Text = "Пацієнти за відділенням";
                    lblDescription.Text = "Запит: Вивести список усіх пацієнтів, які проходять лікування у вказаному відділенні";
                    txbParamText.Visible = true;
                    txbParamText.Text = "Терапевтичне";
                    break;
                case 1:
                    tabQueryPage.Text = "Пошук за телефоном";
                    lblDescription.Text = "Запит: Пошук контактних даних пацієнта за введенням частини номера телефону";
                    txbParamText.Visible = true;
                    txbParamText.Text = "093";
                    break;
                case 2:
                    tabQueryPage.Text = "Зарплати лікарів";
                    lblDescription.Text = "Запит: Вивести ПІБ та спеціальність лікарів, чия заробітна плата перевищує вказаний ліміт";
                    txbParamNumber.Visible = true;
                    txbParamNumber.Text = "16000";
                    break;
                case 3:
                    tabQueryPage.Text = "Пацієнти в палатах";
                    lblDescription.Text = "Запит: Пошук пацієнтів, які наразі перебувають у конкретно заданому номері палати.";
                    txbParamNumber.Visible = true;
                    txbParamNumber.Text = "102";
                    break;
                case 4:
                    tabQueryPage.Text = "Лікарі за спеціальністю";
                    lblDescription.Text = "Запит: Вибірка  персоналу за їхнім професійним напрямком";
                    txbParamText.Visible = true;
                    txbParamText.Text = "Терапевт";
                    break;
                case 5:
                    tabQueryPage.Text = "Відділення без пацієнтів";
                    lblDescription.Text = "Запит: Знайти відділення, де немає жодного зареєстрованого пацієнта.";
                    break;
                case 6:
                    tabQueryPage.Text = "Порівняння множин";
                    lblDescription.Text = "Запит: Вивести пацієнтів, які проходять курс лікування у тих же лікарів, що й пацієнт із  ID=1.";
                    break;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int index = lstQueries.SelectedIndex;
            string sql = "";
            NpgsqlParameter param = null;

            switch (index)
            {
                case 0:
                    sql = "SELECT p.\"Pid\", p.\"PName\", d.\"DName\" FROM \"PATIENT\" p INNER JOIN \"DEPT\" d ON p.\"dept_id\" = d.\"Id\" WHERE d.\"DName\" ILIKE @P";
                    param = new NpgsqlParameter("@P", "%" + txbParamText.Text.Trim() + "%");
                    break;
                case 1:
                    sql = "SELECT \"Pid\", \"PName\", \"Phone\" FROM \"PATIENT\" WHERE \"Phone\" LIKE @P";
                    param = new NpgsqlParameter("@P", "%" + txbParamText.Text.Trim() + "%");
                    break;
                case 2:
                    decimal sal = decimal.TryParse(txbParamNumber.Text, out sal) ? sal : 16000;
                    sql = "SELECT \"DocId\", \"DocName\", \"Salary\" FROM \"DOCTOR\" WHERE \"Salary\" > @P ORDER BY \"Salary\" DESC";
                    param = new NpgsqlParameter("@P", sal);
                    break;
                case 3:
                    int room = int.TryParse(txbParamNumber.Text, out room) ? room : 102;
                    sql = "SELECT p.\"Pid\", p.\"PName\", s.\"RoomNum\" FROM \"PATIENT\" p INNER JOIN \"SEESION\" s ON p.\"Pid\" = s.\"Pid\" WHERE s.\"RoomNum\" = @P";
                    param = new NpgsqlParameter("@P", room);
                    break;
                case 4:
                    sql = "SELECT \"DocId\", \"DocName\", \"Specialty\" FROM \"DOCTOR\" WHERE \"Specialty\" ILIKE @P";
                    param = new NpgsqlParameter("@P", "%" + txbParamText.Text.Trim() + "%");
                    break;
                case 5:
                    sql = "SELECT \"Id\", \"DName\" FROM \"DEPT\" EXCEPT SELECT d.\"Id\", d.\"DName\" FROM \"DEPT\" d INNER JOIN \"PATIENT\" p ON d.\"Id\" = p.\"dept_id\"";
                    break;
                case 6:
                    sql = "SELECT DISTINCT p.\"Pid\", p.\"PName\" FROM \"PATIENT\" p INNER JOIN \"SEESION\" s ON p.\"Pid\" = s.\"Pid\" WHERE s.\"DocId\" IN (SELECT \"DocId\" FROM \"SEESION\" WHERE \"Pid\" = 1) AND p.\"Pid\" <> 1";
                    break;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        if (param != null) cmd.Parameters.Add(param);
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvResults.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
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