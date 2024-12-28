using System.Data;
using System.Text.RegularExpressions;
using Npgsql;

namespace CafeAutomation
{
    public partial class customerAdding : Form
    {
        public customerAdding()
        {
            InitializeComponent();
        }

        private void customerAdding_Load_1(object sender, EventArgs e)
        {
            LoadCustomersIntoDataGridView();
        }
        private void LoadCustomersIntoDataGridView()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, surname, email, phone FROM Customers";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable customersTable = new DataTable();
                            adapter.Fill(customersTable);
                            dataGridView1.DataSource = customersTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string customerName = name_txtbox.Text.Trim();
            string customerSurname = surname_txtbox.Text.Trim();
            string customerEmail = email_txtbox.Text.Trim();
            string customerPhone = phone_txtbox.Text.Trim();

            if (string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(customerSurname) || 
                string.IsNullOrEmpty(customerEmail) ||
                string.IsNullOrEmpty(customerPhone))
            {
                MessageBox.Show("Please fill all the textboxes.");
                return;
            }

            if (!Regex.IsMatch(customerEmail, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                MessageBox.Show("Invalid mail format.");
                return;
            }

            if (!Regex.IsMatch(customerPhone, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Invalid phone format. Format: 5xxxxxxxxx");
                return;
            }

            var connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Customers (name, surname, email, phone) VALUES (@name, @surname, @email, @phone)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {                        cmd.Parameters.AddWithValue("name", customerName);
                        cmd.Parameters.AddWithValue("surname", customerSurname);
                        cmd.Parameters.AddWithValue("email", customerEmail);
                        cmd.Parameters.AddWithValue("phone", customerPhone);

                        cmd.ExecuteNonQuery();
                        LoadCustomersIntoDataGridView();
                        MessageBox.Show("Added customer successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }

        private void customerAdding_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaffPage staffPage = new StaffPage();
            staffPage.Show();
            this.Hide();
        }
    }
}
