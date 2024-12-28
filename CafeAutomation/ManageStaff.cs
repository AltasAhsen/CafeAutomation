using System.Data;
using System.Text;
using Npgsql;

namespace CafeAutomation
{
    public partial class ManageStaff : Form
    {

        public ManageStaff()
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
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void hire_btn_Click(object sender, EventArgs e)
        {
            string id = id_txtbox.Text;
            string name = name_txtbox.Text;
            string surname = surname_txtbox.Text;
            string position = position_txtbox.Text;
            string gender = gen_m_r_btn.Checked ? "m" :
                                gen_f_r_btn.Checked ? "f" : "u";

            if (EmployeeExists(id))
            {
                MessageBox.Show("There is already a staff with this ID!");
            }
            else
            {
                HireEmployee(id, name, surname, position, gender);
            }
        }

        private void fire_btn_Click(object sender, EventArgs e)
        {
            string id = id_txtbox.Text;

            if (EmployeeExists(id))
            {
                FireEmployee(id);
                LoadData();
            }
            else
            {
                MessageBox.Show("No Staff with this ID!");
            }
        }

        private bool EmployeeExists(string id)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Staff WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void HireEmployee(string id, string name, string surname, string position, string gender)
        {
            try
            {
                string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Staff (id, name, surname, position, password, gender) VALUES (@id, @name, @surname, @position, @password, @gender)";

                    string password = GenerateRandomPassword();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("surname", surname);
                        cmd.Parameters.AddWithValue("position", position);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("gender", gender);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Added Staff Successfully! Password: {password}");
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("Wrong or Missing Input");
            }
        }

        private void FireEmployee(string id)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Staff WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string GenerateRandomPassword(int length = 8)
        {
            const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                result.Append(validChars[random.Next(validChars.Length)]);
            }
            return result.ToString();
        }

        private void ManageStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ownerpage ownerForm = new Ownerpage();
            ownerForm.Show();
        }
    }
}
