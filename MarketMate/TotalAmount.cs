using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace MarketMate
{
    public partial class TotalAmount : Form
    {
        private readonly decimal totalPrice;
        private readonly decimal totalDiscount;
        private readonly int orderId;
        private readonly DataTable orderDetails;
        private int cashierId;

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

            cashierId = UserSession.CurrentCashierID;
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
                            dateTimelbl.Text = Convert.ToDateTime(reader["SaleDateTime"]).ToString("MM/dd/yyyy HH:mm:ss");
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

        private async void printBillBtn_Click(object sender, EventArgs e)
        {
            printBillBtn.Enabled = false;
            printBillBtn.Text = "Printing Bill...";

            try
            {
                //await GeneratePdfAsync();
                MessageBox.Show("Bill printed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing the bill: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            printBillBtn.Text = "Print Bill";
            printBillBtn.Enabled = true;
        }

        //private async Task GeneratePdfAsync()
        //{
        //    await Task.Run(() =>
        //    {
        //        try
        //        {
        //            // Get Downloads folder
        //            string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

        //            // Generate file path for the PDF
        //            string filePath = Path.Combine(downloadsFolder, $"Bill_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

        //            if (!Directory.Exists(downloadsFolder))
        //            {
        //                MessageBox.Show("Downloads folder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            // Generate the PDF using QuestPDF
        //            var document = new BillDocument(orderId, dateTimelbl.Text, cashier_id.Text, orderDetails, totalPrice, totalDiscount);
        //            document.GeneratePdf(filePath);

        //            MessageBox.Show($"Bill printed successfully. You can find the bill at: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"An unexpected error occurred during PDF generation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    });
        //}

        //private class BillDocument : IDocument
        //{
        //    private readonly int orderId;
        //    private readonly string saleDateTime;
        //    private readonly string cashierId;
        //    private readonly DataTable orderDetails;
        //    private readonly decimal totalPrice;
        //    private readonly decimal totalDiscount;

        //    public BillDocument(int orderId, string saleDateTime, string cashierId, DataTable orderDetails, decimal totalPrice, decimal totalDiscount)
        //    {
        //        this.orderId = orderId;
        //        this.saleDateTime = saleDateTime;
        //        this.cashierId = cashierId;
        //        this.orderDetails = orderDetails;
        //        this.totalPrice = totalPrice;
        //        this.totalDiscount = totalDiscount;
        //    }

        //    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        //    public void Compose(IDocumentContainer container)
        //    {
        //        container.Page(page =>
        //        {
        //            page.Margin(20);
        //            page.Header().Text("MarketMate - Bill").FontSize(18).Bold().AlignCenter();
        //            page.Content().Padding(10).Column(col =>
        //            {
        //                col.Item().Text($"Order ID: {orderId}");
        //                col.Item().Text($"Date: {saleDateTime}");
        //                col.Item().Text($"Cashier ID: {cashierId}");

        //                col.Item().Table(table =>
        //                {
        //                    table.ColumnsDefinition(columns =>
        //                    {
        //                        columns.RelativeColumn(2);
        //                        columns.RelativeColumn(1);
        //                        columns.RelativeColumn(1);
        //                    });

        //                    table.Header(header =>
        //                    {
        //                        header.Cell().Text("Item").Bold();
        //                        header.Cell().Text("Price").Bold();
        //                        header.Cell().Text("Quantity").Bold();
        //                    });

        //                    if (orderDetails != null && orderDetails.Rows.Count > 0)
        //                    {
        //                        foreach (DataRow row in orderDetails.Rows)
        //                        {
        //                            table.Cell().Text(row["ItemName"]?.ToString() ?? "N/A");
        //                            table.Cell().Text($"{row["Price"]:C}");
        //                            table.Cell().Text(row["Quantity"]?.ToString() ?? "0");
        //                        }
        //                    }
        //                });

        //                col.Item().Text($"Total Price: {totalPrice:C}").AlignRight();
        //                col.Item().Text($"Total Discount: {totalDiscount:C}").AlignRight();
        //            });
        //        });
        //    }

        //    public DocumentSettings GetSettings()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

    }
}

