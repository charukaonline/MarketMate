using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MarketMate.adminUserControls
{
    public partial class ManageCashiers : UserControl
    {
        public ManageCashiers()
        {
            InitializeComponent();
            this.Load += ManageCashiers_Load;
            showUsers.CellContentClick += showUsers_CellDoubleClick;

        }

        private void ManageCashiers_Load(object sender, EventArgs e)
        {
            InitializeDBConnection();
        }

        private void InitializeDBConnection()
        {
            try
            {
                if (dbConn.GetConnection().State == ConnectionState.Closed)
                {
                    dbConn.GetConnection().Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshData()
        {
            FetchCashierRecords();
        }

        private void FetchCashierRecords()
        {
            SqlConnection conn = dbConn.GetConnection();

            string query = "SELECT CashierID AS [User ID], CashierName AS [Name], Username AS [Username], CashierPass AS [Password], UserRole AS [Role] FROM Cashier";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);

                    // Explicitly set DataGridView DataSource
                    showUsers.AutoGenerateColumns = true; // Ensure columns are auto-generated
                    showUsers.DataSource = dt;

                    // Optional: Adjust column headers or formatting here if needed
                    showUsers.Columns[0].HeaderText = "User ID";
                    showUsers.Columns[1].HeaderText = "Name";
                    showUsers.Columns[2].HeaderText = "Username";
                    showUsers.Columns[3].HeaderText = "Password";
                    showUsers.Columns[4].HeaderText = "Role";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error fetching cashier records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void showUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected row
                DataGridViewRow selectedRow = showUsers.Rows[e.RowIndex];

                // Map the cell values to the text boxes
                cashierIDTxt.Text = selectedRow.Cells["User ID"].Value.ToString();
                NameTxt.Text = selectedRow.Cells["Name"].Value.ToString();
                usernameTxt.Text = selectedRow.Cells["Username"].Value.ToString();
                passwordTxt.Text = selectedRow.Cells["Password"].Value.ToString();
                userRoleCombo.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Ensure the user has selected a row to update
            if (string.IsNullOrEmpty(cashierIDTxt.Text))
            {
                MessageBox.Show("Please select a cashier record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Retrieve the updated values from the text boxes
            string cashierID = cashierIDTxt.Text;
            string name = NameTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string role = userRoleCombo.SelectedItem.ToString();
            // Update the record in the database
            SqlConnection conn = dbConn.GetConnection();
            string query = "UPDATE Cashier SET CashierName = @Name, Username = @Username, CashierPass = @Password, UserRole = @Role WHERE CashierID = @CashierID";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@CashierID", cashierID);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cashier record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error updating cashier record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error updating cashier record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierIDTxt.Text))
            {
                MessageBox.Show("Please select a cashier record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Retrieve the CashierID of the record to delete
            string cashierID = cashierIDTxt.Text;
            // Delete the record from the database
            SqlConnection conn = dbConn.GetConnection();
            string query = "DELETE FROM Cashier WHERE CashierID = @CashierID";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CashierID", cashierID);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cashier record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting cashier record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting cashier record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
