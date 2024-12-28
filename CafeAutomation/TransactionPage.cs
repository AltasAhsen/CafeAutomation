using System.Data;
using Npgsql;

namespace CafeAutomation
{
    public partial class TransactionPage : Form
    {
        public TransactionPage()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string incQuery = "SELECT transaction_id,transaction_date,price, cust_id FROM Transactions WHERE transaction_type = 'i'";
            string expQuery = "SELECT transaction_id,transaction_date,price FROM Transactions WHERE transaction_type = 'e'";
            string totalIncomeQuery = "SELECT SUM(price) FROM Transactions WHERE transaction_type = 'i'";
            string totalExpenseQuery = "SELECT SUM(price) FROM Transactions WHERE transaction_type = 'e'";
            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(incQuery, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                using (var cmd = new NpgsqlCommand(totalIncomeQuery, conn))
                {
                    var totalIncome = cmd.ExecuteScalar();
                    label1.Text = $"Total Income: {totalIncome}";
                }

                using (var cmd = new NpgsqlCommand(expQuery, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
                using (var cmd = new NpgsqlCommand(totalExpenseQuery, conn))
                {
                    var totalExpense = cmd.ExecuteScalar();
                    label2.Text = $"Total Expense: {totalExpense}";
                }
            }
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TransactionPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ownerpage ownerPage = new Ownerpage();
            ownerPage.Show();
            this.Hide();
        }
    }
}
