using MarketMate.adminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketMate
{
    public partial class AdminDashboard : Form
    {
        private System.Windows.Forms.Timer refreshTimer;

        public AdminDashboard()
        {
            InitializeComponent();

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            addCashiers1.Show();
            manageCashiers1.Hide();
        }

        private void addCashiersBtn_Click(object sender, EventArgs e)
        {
            addCashiers1.Show();
            manageCashiers1.Hide();
        }

        private void mngCashiersBtn_Click(object sender, EventArgs e)
        {
            addCashiers1.Hide();
            manageCashiers1.Show();
            manageCashiers1.RefreshData();

        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void manageProductsBtn_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.Show();
        }

        private void manageStocksBtn_Click(object sender, EventArgs e)
        {
            ManageStock manageStock = new ManageStock();
            manageStock.Show();
        }
    }
}
