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

                        // Use SqlDataAdapter to fill a DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        showSuppliers.DataSource = dt;

                        // Optional: Adjust DataGridView properties
                        showSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        showSuppliers.AllowUserToAddRows = false; // Disable adding new rows manually
                        showSuppliers.ReadOnly = true; // Set to read-only mode
                        showSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Enable full row selection
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading supplier records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
