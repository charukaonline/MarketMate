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
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addItemsBtn_Click(object sender, EventArgs e)
        {
            string productId = productIdTxt.Text;
            string quantityText = quantityTxt.Text;

            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(quantityText))
            {
                MessageBox.Show("Please enter a valid Product ID and Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantityText, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productQuery = "SELECT [ProductID], [ProductName], [UnitPrice] FROM [Products] WHERE [ProductID] = @ProductID";
            string discountQuery = @"
                SELECT d.DiscountType, d.DiscountValue 
                FROM ProductDiscount pd
                JOIN Discount d ON pd.DiscountID = d.DiscountID
                WHERE pd.ProductID = @ProductID 
                    AND d.StartDate <= GETDATE() 
                    AND d.EndDate >= GETDATE()";

            using (SqlConnection connection = dbConn.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Fetch Product Details
                    string productName = string.Empty;
                    decimal unitPrice = 0;

                    using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                    {
                        productCommand.Parameters.AddWithValue("@ProductID", productId);

                        using (SqlDataReader productReader = productCommand.ExecuteReader())
                        {
                            if (productReader.Read())
                            {
                                productName = productReader["ProductName"].ToString();
                                unitPrice = Convert.ToDecimal(productReader["UnitPrice"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        } // Automatically closes the productReader
                    }

                    // Fetch Discount Details
                    decimal discountValue = 0;
                    using (SqlCommand discountCommand = new SqlCommand(discountQuery, connection))
                    {
                        discountCommand.Parameters.AddWithValue("@ProductID", productId);

                        using (SqlDataReader discountReader = discountCommand.ExecuteReader())
                        {
                            if (discountReader.Read())
                            {
                                string discountType = discountReader["DiscountType"].ToString();
                                decimal discount = Convert.ToDecimal(discountReader["DiscountValue"]);

                                if (discountType.Equals("Fixed", StringComparison.OrdinalIgnoreCase))
                                {
                                    discountValue = discount;
                                }
                                else if (discountType.Equals("Percentage", StringComparison.OrdinalIgnoreCase))
                                {
                                    discountValue = (unitPrice * discount / 100) * quantity;
                                }
                            }
                        } // Automatically closes the discountReader
                    }

                    // Calculate Total Price and Add to Grid
                    decimal totalPrice = (unitPrice * quantity) - discountValue;
                    orderGrid.Rows.Add(productId, productName, quantity, discountValue, totalPrice);

                    MessageBox.Show(
                        $"Item added to the order. Discount applied: {discountValue:C}.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    productIdTxt.Text = "";
                    quantityTxt.Text = "";
                    productIdTxt.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
