using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MarketMate.adminUserControls
{
    public partial class AddCashiers : UserControl
    {
        public AddCashiers()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string cName = cashierName.Text;
            string cUsername = cashierUName.Text.Trim();
            string cPassword = cashierPass.Text.Trim();
            string userRole = userRoleCombo.Text;

            if (string.IsNullOrEmpty(cName))
            {
                MessageBox.Show("Cashier name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cUsername))
            {
                MessageBox.Show("Cashier username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cPassword))
            {
                MessageBox.Show("Cashier password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show("User role is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection conn = dbConn.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Cashier (CashierName, Username, CashierPass, UserRole) VALUES (@CashierName, @Username, @Password, @UserRole)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CashierName", cName);
                            cmd.Parameters.AddWithValue("@Username", cUsername);
                            cmd.Parameters.AddWithValue("@Password", cPassword);
                            cmd.Parameters.AddWithValue("@UserRole", userRole);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Cashier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cashierName.Text = "";
                                cashierUName.Text = "";
                                cashierPass.Text = "";
                                userRoleCombo.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to add cashier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
