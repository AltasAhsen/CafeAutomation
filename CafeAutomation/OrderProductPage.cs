using System.Data;
using Npgsql;

namespace CafeAutomation
{
    public partial class OrderProductPage : Form
    {
        public OrderProductPage()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string query = "SELECT code, name, price, amount FROM Products";
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
        private void OrderProductPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void OrderProductPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ownerpage owner = new Ownerpage();
            owner.Show();
            this.Hide();
        }

        private void ord_btn_Click(object sender, EventArgs e)
        {
            decimal price = 300 * bean_num.Value + 25 * milk_num.Value + 40 * soy_milk_num.Value + 50 * alm_milk_num.Value;

            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string insertTransactionQuery = @"INSERT INTO Transactions (transaction_type, transaction_date, price)
                                          VALUES ('e', @transaction_date, @price)";
                using (var cmd = new NpgsqlCommand(insertTransactionQuery, conn))
                {
                    cmd.Parameters.AddWithValue("transaction_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("price", price);
                    cmd.ExecuteNonQuery();
                }

                string updateCoffeeBeanQuery = @"UPDATE Products SET amount = amount + @increment WHERE name = 'Coffee Bean'";
                using (var cmd = new NpgsqlCommand(updateCoffeeBeanQuery, conn))
                {
                    cmd.Parameters.AddWithValue("increment", bean_num.Value * 500);
                    cmd.ExecuteNonQuery();
                }

                string updateMilkQuery = @"UPDATE Products SET amount = amount + @increment WHERE name = 'Regular Milk'";
                using (var cmd = new NpgsqlCommand(updateMilkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("increment", milk_num.Value * 1000);
                    cmd.ExecuteNonQuery();
                }

                string updateSoyMilkQuery = @"UPDATE Products SET amount = amount + @increment WHERE name = 'Soy Milk'";
                using (var cmd = new NpgsqlCommand(updateSoyMilkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("increment", soy_milk_num.Value * 1000);
                    cmd.ExecuteNonQuery();
                }

                string updateAlmondMilkQuery = @"UPDATE Products SET amount = amount + @increment WHERE name = 'Almond Milk'";
                using (var cmd = new NpgsqlCommand(updateAlmondMilkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("increment", alm_milk_num.Value * 1000);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Successfully ordered!");
            LoadData();
        }

    }
}
