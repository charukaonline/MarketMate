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
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open(); // Open the connection
                    MessageBox.Show("Connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Show error message if connection fails
                    MessageBox.Show($"Connection failed: {ex.Message}", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // Close the connection
                }
            }
        }
    }
}
