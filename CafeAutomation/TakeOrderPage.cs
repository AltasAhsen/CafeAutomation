using Npgsql;

namespace CafeAutomation
{
    public partial class TakeOrderPage : Form
    {
        public TakeOrderPage()
        {
            InitializeComponent();
        }

        private void TakeOrderPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaffPage staffPage = new StaffPage();
            staffPage.Show();
            this.Hide();
        }
        private void order_btn_Click(object sender, EventArgs e)
        {
            decimal price = 50 * regular_latte_num.Value + 55 * soy_latte_num.Value
                + 60 * almond_latte_num.Value + 45 * americano_num.Value + 40 * espresso_num.Value
                + 55 * flat_num.Value + 50 * capp_num.Value;

            string connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string getStaffIdQuery = "SELECT id FROM Staff WHERE isLoggedIn = 't'";
                string staffId = null;
                using (var cmd = new NpgsqlCommand(getStaffIdQuery, conn))
                {
                    staffId = (string)cmd.ExecuteScalar();
                }

                string getCustIdQuery = "SELECT id FROM Customers WHERE phone = @phone";
                int custId = 0;
                using (var cmd = new NpgsqlCommand(getCustIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("phone", phone_txtbox.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        custId = (int)result;
                }

                string transactionCountQuery = "SELECT COUNT(*) FROM Transactions WHERE cust_id = @cust_id";
                int transactionCount = 0;
                using (var cmd = new NpgsqlCommand(transactionCountQuery, conn))
                {
                    cmd.Parameters.AddWithValue("cust_id", custId);
                    transactionCount = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (transactionCount % 5 == 0 && transactionCount > 0)
                {
                    price *= 0.80M; 
                }


                if (!CheckStock(conn, "Coffee Bean", 10 * (regular_latte_num.Value + soy_latte_num.Value + almond_latte_num.Value + americano_num.Value + espresso_num.Value + flat_num.Value + capp_num.Value)) ||
                    !CheckStock(conn, "Regular Milk", 200 * regular_latte_num.Value + 100 * flat_num.Value + 50 * capp_num.Value) ||
                    !CheckStock(conn, "Soy Milk", 200 * soy_latte_num.Value) ||
                    !CheckStock(conn, "Almond Milk", 200 * almond_latte_num.Value))
                {
                    MessageBox.Show("Insufficient stock for one or more items.");
                    return;
                }

                string insertTransactionQuery = @"
            INSERT INTO Transactions (transaction_type, staff_id, cust_id, transaction_date, price)
            VALUES ('i', @staff_id, @cust_id, @transaction_date, @price)";
                using (var cmd = new NpgsqlCommand(insertTransactionQuery, conn))
                {
                    cmd.Parameters.AddWithValue("staff_id", staffId);
                    cmd.Parameters.AddWithValue("cust_id", custId);
                    cmd.Parameters.AddWithValue("transaction_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("price", price);
                    cmd.ExecuteNonQuery();
                }

                if (regular_latte_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -10 * regular_latte_num.Value);
                    UpdateProductAmount(conn, "Regular Milk", -200 * regular_latte_num.Value);
                }

                if (soy_latte_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -10 * soy_latte_num.Value);
                    UpdateProductAmount(conn, "Soy Milk", -200 * soy_latte_num.Value);
                }

                if (almond_latte_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -10 * almond_latte_num.Value);
                    UpdateProductAmount(conn, "Almond Milk", -200 * almond_latte_num.Value);
                }

                if (americano_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -10 * americano_num.Value);
                }

                if (espresso_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -10 * espresso_num.Value);
                }

                if (flat_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -20 * flat_num.Value);
                    UpdateProductAmount(conn, "Regular Milk", -100 * flat_num.Value);
                }

                if (capp_num.Value > 0)
                {
                    UpdateProductAmount(conn, "Coffee Bean", -10 * capp_num.Value);
                    UpdateProductAmount(conn, "Regular Milk", -50 * capp_num.Value);
                }
            }

            MessageBox.Show($"Order successfully placed! Total: {price}");
        }

        private bool CheckStock(NpgsqlConnection conn, string productName, decimal requiredAmount)
        {
            string checkStockQuery = "SELECT amount FROM Products WHERE name = @productName";
            using (var cmd = new NpgsqlCommand(checkStockQuery, conn))
            {
                cmd.Parameters.AddWithValue("productName", productName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal currentAmount = Convert.ToDecimal(result);
                    return currentAmount >= requiredAmount;
                }
                else
                {
                    return false;
                }
            }
        }

        private void UpdateProductAmount(NpgsqlConnection conn, string productName, decimal amountChange)
        {
            string updateQuery = @"UPDATE Products SET amount = amount + @amountChange WHERE name = @productName";
            using (var cmd = new NpgsqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("amountChange", amountChange);
                cmd.Parameters.AddWithValue("productName", productName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
