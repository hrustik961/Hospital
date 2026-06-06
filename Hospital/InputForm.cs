using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    public partial class InputForm : Form
    {
        private string connString = Form1.ConnectionString;

        public InputForm()
        {
            InitializeComponent();
            this.Text = "Реєстрування пацієнта";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void InputForm_Load(object sender, EventArgs e)
        {
            ZavantazhytySpysokViddilen();
            OnovytyTablytsyuPacientiv();
        }

        private void ZavantazhytySpysokViddilen()
        {
            string query = "SELECT \"Id\", \"DName\" FROM \"DEPT\" ORDER BY \"DName\"";
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbDepts.DataSource = dt;
                        cmbDepts.DisplayMember = "DName"; 
                        cmbDepts.ValueMember = "Id";     
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження списку відділень: " + ex.Message);
            }
        }

        private void OnovytyTablytsyuPacientiv()
        {
            string query = "SELECT p.\"Pid\" AS \"ID\", p.\"PName\" AS \"ПІБ Пацієнта\", p.\"Phone\" AS \"Телефон\", d.\"DName\" AS \"Відділення\" " +
                           "FROM \"PATIENT\" p " +
                           "LEFT JOIN \"DEPT\" d ON p.\"dept_id\" = d.\"Id\" " +
                           "ORDER BY p.\"Pid\" DESC"; 
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPatients.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення таблиці: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbName.Text) || string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                MessageBox.Show("Будь ласка, заповніть ПІБ та Телефон пацієнта!");
                return;
            }

            string query = "INSERT INTO \"PATIENT\" (\"PName\", \"Phone\", \"dept_id\") VALUES (@PName, @Phone, @DeptId)";

            try
            {
                string name = txbName.Text.Trim();
                string phone = txbPhone.Text.Trim();

                int deptId = Convert.ToInt32(cmbDepts.SelectedValue);

                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PName", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@DeptId", deptId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Пацієнта додано у відділення: {cmbDepts.Text}");

                txbName.Clear();
                txbPhone.Clear();

                OnovytyTablytsyuPacientiv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні: " + ex.Message);
            }
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Form1"];
            if (main != null)
            {
                main.Show();
            }
            this.Close(); 
        }
    }
}