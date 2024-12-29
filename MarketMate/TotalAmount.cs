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
    public partial class TotalAmount : Form
    {

        private decimal totalPrice;
        private decimal totalDiscount;
        private int orderId;
        private DataTable orderDetails;

        public TotalAmount(decimal totalPrice, decimal totalDiscount, int orderId, DataTable orderDetails)
        {
            InitializeComponent();
            this.totalPrice = totalPrice;
            this.totalDiscount = totalDiscount;
            this.orderId = orderId;
            this.orderDetails = orderDetails;

            orderDetailsGrid.DataSource = orderDetails;

            totAmountlbl.Text = $"{totalPrice:C}";
            discountlbl.Text = $"{totalDiscount:C}";

            LoadOrderDetails();

            receivedMoneyTxt.TextChanged += ReceivedMoneyTxt_TextChanged;
        }

        private void LoadOrderDetails()
        {
            string query = @"
                SELECT TOP 1 [OrderID], [SaleDateTime], [TotalPrice], [TotalDiscount], [CustomerID], [CashierID]
                FROM [Orders]
                ORDER BY [SaleDateTime] DESC";

            using (SqlConnection connection = dbConn.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            //orderIdLbl.Text = reader["OrderID"].ToString();
                            dateTimelbl.Text = Convert.ToDateTime(reader["SaleDateTime"]).ToString("MM/dd/yyyy HH:mm:ss");
                            cashier_id.Text = reader["CashierID"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No order records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReceivedMoneyTxt_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(receivedMoneyTxt.Text, out decimal receivedMoney) && receivedMoney >= totalPrice)
            {
                balancelbl.Text = $"{(receivedMoney - totalPrice):C}";
            }
            else
            {
                balancelbl.Text = "Balance: Invalid input";
            }
        }
    }
}
