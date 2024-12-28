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
    public partial class AddProducts : UserControl
    {
        public AddProducts()
        {
            InitializeComponent();
        }
        private void AddProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT CategoryName FROM Category";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        categoryCombo.Items.Clear();

                        categoryCombo.Items.Add("-- Select a Category --");

                        while (reader.Read())
                        {
                            categoryCombo.Items.Add(reader["CategoryName"].ToString());
                        }

                        reader.Close();

                        categoryCombo.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameTxt.Text))
            {
                MessageBox.Show("Please enter the product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(unitPriceTxt.Text) || !decimal.TryParse(unitPriceTxt.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Please enter a valid unit price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(stockQuantityTxt.Text) || !decimal.TryParse(stockQuantityTxt.Text, out decimal stockQuantity) || stockQuantity < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoryCombo.SelectedItem == null || categoryCombo.SelectedItem.ToString() == "-- Select a Category --")
            {
                MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string selectedCategory = categoryCombo.SelectedItem.ToString();

            // Insert data into the database
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    // Start a transaction
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    // Insert product into the Products table
                    string insertProductQuery = @"INSERT INTO Products (ProductName, UnitPrice, StockQuantity) 
                                          VALUES (@ProductName, @UnitPrice, @StockQuantity);
                                          SELECT SCOPE_IDENTITY();";

                    int productId;
                    using (SqlCommand cmd = new SqlCommand(insertProductQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productNameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);

                        productId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Map product to the selected category in ProductCategory table
                    string mapProductCategoryQuery = @"INSERT INTO ProductCategory (ProductID, CategoryID) 
                                               VALUES (@ProductID, 
                                                       (SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName));";

                    using (SqlCommand cmd = new SqlCommand(mapProductCategoryQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@CategoryName", selectedCategory);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    productNameTxt.Clear();
                    unitPriceTxt.Clear();
                    stockQuantityTxt.Clear();
                    categoryCombo.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
