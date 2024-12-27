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

namespace MarketMate
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            UserSelectionForm UserSelectionForm = new UserSelectionForm();
            UserSelectionForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            String username = userNameTxt.Text.Trim();
            String password = passwordTxtBox.Text.Trim();

            if (String.IsNullOrEmpty(username))
            {
                usernameValidationLbl.Visible = true;
                return;
            } else
            {
               usernameValidationLbl.Visible = false;
            }

            if (String.IsNullOrEmpty(password))
            {

               pinValidationLbl.Visible = true;
                return;
            } else
            {
                pinValidationLbl.Visible = false;
            }

            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM AdminUser WHERE Username = @Username AND AdminPass = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Admin dashboard redirect
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or PIN. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            usernameValidationLbl.Visible = false;
            pinValidationLbl.Visible = false;
        }
    }
}
