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
    public partial class StockRecords : UserControl
    {
        public StockRecords()
        {
            InitializeComponent();
            this.Load += StockRecords_Load;
        }

        private void StockRecords_Load(object sender, EventArgs e)
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
            LoadStockRecords();
        }

        private void LoadStockRecords()
        {
            using (SqlConnection conn = dbConn.GetConnection())
            {
                try
                {
                    string query = @"SELECT 
                                s.StockID AS [Stock ID],
                                s.DateAdded AS [Date Added],
                                s.QuantityAdded AS [Quantity Added],
                                p.ProductName AS [Product Name],
                                sup.SupplierName AS [Supplier Name],
                                a.Username AS [Admin Added By]
                             FROM Stock s
                             INNER JOIN Products p ON s.ProductID = p.ProductID
                             INNER JOIN Supplier sup ON s.SupplierID = sup.SupplierID
                             INNER JOIN AdminUser a ON s.AdminID = a.AdminID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        showStocks.DataSource = dt;

                        // Optional: Adjust DataGridView properties
                        showStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        showStocks.AllowUserToAddRows = false; 
                        showStocks.ReadOnly = true; 
                        showStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading stock records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
