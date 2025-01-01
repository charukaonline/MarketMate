using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketMate.adminForms
{
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void addStocksBtn_Click(object sender, EventArgs e)
        {
            addStocks1.Show();
            addSuppliers1.Hide();
        }

        private void ManageStock_Load(object sender, EventArgs e)
        {
            addStocks1.Show();
            addSuppliers1.Hide();
        }

        private void addSuppliersBtn_Click(object sender, EventArgs e)
        {
            addSuppliers1.Show();
            addStocks1.Hide();
        }
    }
}
