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
    public partial class AddSuppliers : UserControl
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            // Validate the inputs before proceeding
            if (string.IsNullOrWhiteSpace(supplierNameTxt.Text))
            {
                MessageBox.Show("Please enter the supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phoneTxt.Text) || !long.TryParse(phoneTxt.Text, out long phoneNumber) || phoneTxt.Text.Length > 15)
            {
                MessageBox.Show("Please enter a valid contact number (up to 15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(emailTxt.Text) || !IsValidEmail(emailTxt.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data into the Supplier table
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    string query = @"INSERT INTO Supplier (SupplierName, ContactNumber, Email) 
                             VALUES (@SupplierName, @ContactNumber, @Email);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@SupplierName", supplierNameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", phoneTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", emailTxt.Text.Trim());

                        conn.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the input fields
                            supplierNameTxt.Clear();
                            phoneTxt.Clear();
                            emailTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while adding the supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void addAddressBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplierIdTxt.Text) || !int.TryParse(supplierIdTxt.Text, out int supplierId))
            {
                MessageBox.Show("Please enter a valid Supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(addressTxt.Text))
            {
                MessageBox.Show("Please enter the address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Check if the Supplier ID exists
                    string checkSupplierQuery = "SELECT COUNT(*) FROM Supplier WHERE SupplierID = @SupplierID";
                    using (SqlCommand checkCmd = new SqlCommand(checkSupplierQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Supplier ID does not exist. Please enter a valid Supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert the address into the SupplierAddress table
                    string insertAddressQuery = @"INSERT INTO SupplierAddress (SupplierID, SAddress) 
                                          VALUES (@SupplierID, @Address)";

                    using (SqlCommand insertCmd = new SqlCommand(insertAddressQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        insertCmd.Parameters.AddWithValue("@Address", addressTxt.Text.Trim());

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Address added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            supplierIdTxt.Clear();
                            addressTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the address. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while adding the address: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
