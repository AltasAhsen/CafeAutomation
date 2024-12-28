using System;
using System.Collections.Generic;
using System.ComponentModel;
using Npgsql;

namespace CafeAutomation
{
    public partial class customerUpdate : Form
    {
        public customerUpdate()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "SELECT id, name, surname, email, phone FROM Customers";
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

        private void customerUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string selectedOption = email_r_btn.Checked ? "email" : "phone";
            string nonSelectedOption = email_r_btn.Checked ? "phone" : "email";
            string newValue = email_r_btn.Checked ? email_txtbox.Text : phone_txtbox.Text;
            string nonSelectedValue = email_r_btn.Checked ? phone_txtbox.Text : email_txtbox.Text;


            var connectionString = "Host=localhost;Username=postgres;Password=Gazi_Ankara_24;Database=postgres";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = $"UPDATE Customers SET {selectedOption} = @newValue WHERE {nonSelectedOption} = @nonSelectedValue";

                using (var cmd = new NpgsqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("newValue", newValue);
                    cmd.Parameters.AddWithValue("nonSelectedValue", nonSelectedValue);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"new Value: {newValue} ve nonSelectedValue: {nonSelectedValue}.An error occured: {ex.Message}");
                    }
                }
            }
        }

        private void customerUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaffPage staffPage = new StaffPage();
            staffPage.Show();
            this.Hide();
        }
    }
}
