using Npgsql;

namespace CafeAutomation
{
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string query = "SELECT id, position, name, surname, isLoggedIn FROM Staff";
            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            string surname = reader["surname"].ToString();

                            welcome_lbl.Text = $"Welcome {name} {surname}!";
                        }
                    }
                }
            }
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LogoutAllUsers()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Staff SET isLoggedIn = 'f' WHERE isLoggedIn = 't'";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }

        private void StaffPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogoutAllUsers();
            Application.Exit();
        }

        private void pass_chang_btn_Click(object sender, EventArgs e)
        {
            PassChange passChange = new PassChange();
            passChange.Show();
            this.Hide();
        }

        private void add_cust_btn_Click(object sender, EventArgs e)
        {
            customerAdding customerAdding = new customerAdding();
            customerAdding.Show();
            this.Hide();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            TakeOrderPage takeOrder = new TakeOrderPage();
            takeOrder.Show();
            this.Hide();
        }

        private void update_cust_Click(object sender, EventArgs e)
        {
            customerUpdate customerUpdate = new customerUpdate();
            customerUpdate.Show();
            this.Hide();
        }
    }
}
