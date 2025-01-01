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
    public partial class ManageSuppliers : UserControl
    {
        public ManageSuppliers()
        {
            InitializeComponent();
            this.Load += ManageSuppliers_Load;
            showSuppliers.CellClick += showSuppliers_CellClick;
        }

        private void ManageSuppliers_Load(object sender, EventArgs e)
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
            LoadSupplierRecords();
        }

        private void LoadSupplierRecords()
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    string query = @"SELECT 
                                SupplierID AS [Supplier ID], 
                                SupplierName AS [Name], 
                                ContactNumber AS [Contact Number], 
                                Email AS [Email]
                             FROM Supplier";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        showSuppliers.DataSource = dt;

                        // Optional: Adjust DataGridView properties
                        showSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        showSuppliers.AllowUserToAddRows = false; 
                        showSuppliers.ReadOnly = true; 
                        showSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading supplier records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a valid row and not the header or an empty area
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = showSuppliers.Rows[e.RowIndex];

                // Populate the text fields with data from the selected row
                supplierIDTxt.Text = selectedRow.Cells["Supplier ID"].Value.ToString();
                nameTxt.Text = selectedRow.Cells["Name"].Value.ToString();
                phoneTxt.Text = selectedRow.Cells["Contact Number"].Value.ToString();
                emailTxt.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Validate the inputs before proceeding
            if (string.IsNullOrWhiteSpace(supplierIDTxt.Text) || !int.TryParse(supplierIDTxt.Text, out int supplierId))
            {
                MessageBox.Show("Please enter a valid Supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Please enter the supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phoneTxt.Text) || !long.TryParse(phoneTxt.Text, out long contactNumber) || phoneTxt.Text.Length > 15)
            {
                MessageBox.Show("Please enter a valid contact number (up to 15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(emailTxt.Text) || !IsValidEmail(emailTxt.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update supplier details in the database
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    // SQL query to update supplier details
                    string updateQuery = @"UPDATE Supplier 
                                   SET SupplierName = @SupplierName, 
                                       ContactNumber = @ContactNumber, 
                                       Email = @Email 
                                   WHERE SupplierID = @SupplierID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@SupplierName", nameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", phoneTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", emailTxt.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Supplier details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshData();

                            supplierIDTxt.Clear();
                            nameTxt.Clear();
                            phoneTxt.Clear();
                            emailTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
