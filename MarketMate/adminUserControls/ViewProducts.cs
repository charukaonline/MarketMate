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
    public partial class ViewProducts : UserControl
    {
        public ViewProducts()
        {
            InitializeComponent();
            this.Load += ViewProducts_Load;
            showProducts.CellClick += showProducts_CellClick;
        }

        private void ViewProducts_Load(object sender, EventArgs e)
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
            LoadProductRecords();
        }

        private void LoadProductRecords()
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    string query = @"SELECT 
                                p.ProductID AS [Product ID],
                                p.ProductName AS [Product Name],
                                p.UnitPrice AS [Unit Price],
                                p.StockQuantity AS [Stock Quantity],
                                STRING_AGG(c.CategoryName, ', ') AS [Categories]
                             FROM Products p
                             LEFT JOIN ProductCategory pc ON p.ProductID = pc.ProductID
                             LEFT JOIN Category c ON pc.CategoryID = c.CategoryID
                             GROUP BY p.ProductID, p.ProductName, p.UnitPrice, p.StockQuantity";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        // Use SqlDataAdapter to fill a DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        showProducts.DataSource = dt;
                        showProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        showProducts.AllowUserToAddRows = false; 
                        showProducts.ReadOnly = true; 
                        showProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a valid row and not the header or an empty area
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = showProducts.Rows[e.RowIndex];

                // Populate the text fields with data from the selected row
                productIDTxt.Text = selectedRow.Cells["Product ID"].Value.ToString();
                nameTxt.Text = selectedRow.Cells["Product Name"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs before proceeding
            if (string.IsNullOrWhiteSpace(productIDTxt.Text) || !int.TryParse(productIDTxt.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Please enter a valid Product Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    conn.Open();

                    // SQL query to update the product name
                    string updateQuery = @"UPDATE Products 
                                   SET ProductName = @ProductName 
                                   WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@ProductName", nameTxt.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView to reflect the updated product name
                            RefreshData();

                            productIDTxt.Clear();
                            nameTxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
