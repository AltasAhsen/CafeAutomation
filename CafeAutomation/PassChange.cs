using Npgsql;

namespace CafeAutomation
{
    public partial class PassChange : Form
    {
        public PassChange()
        {
            InitializeComponent();
        }

        private void chang_btn_Click(object sender, EventArgs e)
        {
            string currentPassword = curr_pass_txtbox.Text.Trim();
            string newPassword = new_pass_txtbox.Text.Trim();
            string confirmNewPassword = conf_pass_txtbox.Text.Trim();

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor!");
                return;
            }

            if (ValidateCurrentPassword(currentPassword))
            {
                UpdatePassword(newPassword);
                MessageBox.Show("Şifreniz başarıyla güncellendi!");
            }
            else
            {
                MessageBox.Show("Mevcut şifreniz yanlış!");
            }
        }

        private bool ValidateCurrentPassword(string currentPassword)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Staff WHERE isLoggedIn = 't' AND password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("password", currentPassword);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void UpdatePassword(string newPassword)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Staff SET password = @newPassword WHERE isLoggedIn = 't'";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("newPassword", newPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void PassChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaffPage staffPage = new StaffPage();
            staffPage.Show();
            this.Hide();
        }
    }
}
