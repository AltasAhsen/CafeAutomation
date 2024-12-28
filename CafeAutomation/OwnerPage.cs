using Npgsql;

namespace CafeAutomation
{
    public partial class Ownerpage : Form
    {
        public Ownerpage()
        {
            InitializeComponent();
        }

        private void manage_btn_Click(object sender, EventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.Show();
            this.Hide();
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

        private void Ownerpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogoutAllUsers();
            Application.Exit();
        }

        private void Ownerpage_Load(object sender, EventArgs e)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, surname, gender FROM staff WHERE isLoggedIn = 't'";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                string surname = reader["surname"].ToString();
                                string gender = reader["gender"].ToString();

                                if (gender == "m")
                                {
                                    welcome_lbl.Text = $"Nice to see you Mr. {name} {surname}!\nWhat would you like to do today?";
                                }
                                else if (gender == "f")
                                {
                                    welcome_lbl.Text = $"Nice to see you Ms. {name} {surname}!\nWhat would you like to do today?";
                                }
                                else
                                {
                                    welcome_lbl.Text = $"Nice to see you {name} {surname}!\nWhat would you like to do today";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            OrderProductPage orderPage = new OrderProductPage();
            orderPage.Show();
            this.Hide();
        }

        private void in_ex_btn_Click(object sender, EventArgs e)
        {
            TransactionPage transactionPage = new TransactionPage();
            transactionPage.Show();
            this.Hide();
        }
    }
}
