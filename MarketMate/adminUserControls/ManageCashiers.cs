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
    public partial class ManageCashiers : UserControl
    {
        public ManageCashiers()
        {
            InitializeComponent();
        }

        private void ManageCashiers_Load(object sender, EventArgs e)
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
            // call the fetch cashier records method
        }
    }
}
