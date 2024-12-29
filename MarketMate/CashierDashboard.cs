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
                        }
                    }

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
                        }
                    }

                    decimal totalPrice = (unitPrice * quantity) - discountValue;
                    orderGrid.Rows.Add(productId, productName, unitPrice, quantity, discountValue, totalPrice);

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

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            decimal totalDiscount = 0;

            DataTable orderDetails = new DataTable();
            orderDetails.Columns.Add("ProductID", typeof(string));
            orderDetails.Columns.Add("ProductName", typeof(string));
            orderDetails.Columns.Add("UnitPrice", typeof(decimal));
            orderDetails.Columns.Add("Quantity", typeof(int));
            orderDetails.Columns.Add("Discount", typeof(decimal));
            orderDetails.Columns.Add("TotalPrice", typeof(decimal));

            // Populate orderDetails with data from orderGrid
            foreach (DataGridViewRow row in orderGrid.Rows)
            {
                if (row.Cells["product_id"].Value != null)
                {
                    string productId = row.Cells["product_id"].Value.ToString();
                    string productName = row.Cells["product_name"].Value.ToString();
                    decimal unitPrice = Convert.ToDecimal(row.Cells["unit_price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    decimal discount = Convert.ToDecimal(row.Cells["discount"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["total_price"].Value);

                    totalPrice += total;
                    totalDiscount += discount;

                    orderDetails.Rows.Add(productId, productName, unitPrice, quantity, discount, total);
                }
            }

            using (SqlConnection connection = dbConn.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int orderId;

                    string orderInsertQuery = @"
                        DECLARE @InsertedOrders TABLE (OrderID INT);
                        INSERT INTO [Orders] ([SaleDateTime], [TotalPrice], [TotalDiscount], [CustomerID], [CashierID])
                        OUTPUT INSERTED.OrderID INTO @InsertedOrders
                        VALUES (GETDATE(), @TotalPrice, @TotalDiscount, @CustomerID, @CashierID);
                        SELECT OrderID FROM @InsertedOrders;";

                    using (SqlCommand orderCommand = new SqlCommand(orderInsertQuery, connection, transaction))
                    {
                        orderCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        orderCommand.Parameters.AddWithValue("@TotalDiscount", totalDiscount);
                        orderCommand.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                        orderCommand.Parameters.AddWithValue("@CashierID", 1);

                        orderId = Convert.ToInt32(orderCommand.ExecuteScalar());
                    }

                    string orderItemInsertQuery = @"
                        INSERT INTO [OrderItem] ([OrderID], [ProductID], [Quantity])
                        VALUES (@OrderID, @ProductID, @Quantity)";

                    foreach (DataRow detailRow in orderDetails.Rows)
                    {
                        using (SqlCommand orderItemCommand = new SqlCommand(orderItemInsertQuery, connection, transaction))
                        {
                            orderItemCommand.Parameters.AddWithValue("@OrderID", orderId);
                            orderItemCommand.Parameters.AddWithValue("@ProductID", detailRow["ProductID"]);
                            orderItemCommand.Parameters.AddWithValue("@Quantity", detailRow["Quantity"]);
                            orderItemCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TotalAmount totalAmountForm = new TotalAmount(totalPrice, totalDiscount, orderId, orderDetails);
                    totalAmountForm.Show();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
