using Npgsql;

namespace CafeAutomation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string enteredId = id_txtbox.Text.Trim();
            string enteredPassword = pass_txtbox.Text;

            var connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT position, name, surname FROM Staff WHERE id = @id AND password = @password";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", enteredId);
                        cmd.Parameters.AddWithValue("password", enteredPassword);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string position = reader.GetString(0);
                                string name = reader.GetString(1);
                                string surname = reader.GetString(2);

                                MessageBox.Show($"Welcome {name} {surname}!");

                                reader.Close();
                                string updateQuery = "UPDATE Staff SET isLoggedIn = 't' WHERE id = @id";
                                using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("id", enteredId);
                                    updateCmd.ExecuteNonQuery();
                                }

                                if (position == "Owner")
                                {
                                    Ownerpage ownerForm = new Ownerpage();
                                    ownerForm.Show();
                                }
                                else if (position == "Cashier" || position == "Barista" || position == "Cleaner")
                                {
                                    StaffPage staffForm = new StaffPage();
                                    staffForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong Id or password. Please try again.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured: {ex.Message}");
                }
            }
        }
    }
}
