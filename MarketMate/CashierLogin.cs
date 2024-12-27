﻿using System;
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
    public partial class CashierLogin : Form
    {
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameValidationLbl.Visible = false;
            pinValidationLbl.Visible = false;
        }

        private void goBackBtn_Click_1(object sender, EventArgs e)
        {
            UserSelectionForm userSelectionForm = new UserSelectionForm();
            userSelectionForm.Show();
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
            }
            else
            {
                usernameValidationLbl.Visible = false;
            }

            if (String.IsNullOrEmpty(password))
            {

                pinValidationLbl.Visible = true;
                return;
            }
            else
            {
                pinValidationLbl.Visible = false;
            }

            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Cashier WHERE Username = @Username AND CashierPass = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Cashier dashboard redirect
                            CashierDashboard cashierDashboard = new CashierDashboard();
                            cashierDashboard.Show();
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
    }
}
