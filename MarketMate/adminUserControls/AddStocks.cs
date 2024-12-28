using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MarketMate.adminUserControls
{
    public partial class AddStocks : UserControl
    {
        private int adminID;
        private string adminUsername;
        public AddStocks()
        {
            InitializeComponent();
        }

        private void AddStocks_Load(object sender, EventArgs e)
        {
            adminID = UserSession.CurrentAdminID;
            adminUsername = UserSession.CurrentAdminUsername;
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT SupplierName FROM Supplier"; // Adjust to match your table structure
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        // Clear existing items to avoid duplicates
                        supplierCombo.Items.Clear();
                        // Populate the ComboBox
                        while (reader.Read())
                        {
                            supplierCombo.Items.Add(reader["SupplierName"].ToString());
                        }
                        reader.Close();
                        // Set the first item as a default value (optional)
                        if (supplierCombo.Items.Count > 0)
                        {
                            supplierCombo.SelectedIndex = 0; // Select the first item by default
                        }
                        else
                        {
                            supplierCombo.Text = "-- No Suppliers Available --";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Validate the inputs before proceeding
            if (string.IsNullOrWhiteSpace(productIdTxt.Text) || !int.TryParse(productIdTxt.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(quantityTxt.Text) || !int.TryParse(quantityTxt.Text, out int quantityAdded) || quantityAdded <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (supplierCombo.SelectedItem == null || supplierCombo.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected supplier name
            string selectedSupplier = supplierCombo.SelectedItem.ToString();

            // Insert data into the Stock table
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    // SQL query to insert stock record
                    string query = @"INSERT INTO Stock (DateAdded, QuantityAdded, ProductID, SupplierID, AdminID) 
                             VALUES (GETDATE(), @QuantityAdded, @ProductID, 
                                    (SELECT SupplierID FROM Supplier WHERE SupplierName = @SupplierName), 
                                    @AdminID);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@QuantityAdded", quantityAdded);
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@SupplierName", selectedSupplier);
                        cmd.Parameters.AddWithValue("@AdminID", adminID);

                        conn.Open();

                        // Execute the query
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Stock record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the input fields
                            productIdTxt.Clear();
                            quantityTxt.Clear();
                            supplierCombo.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the stock record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the stock record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
