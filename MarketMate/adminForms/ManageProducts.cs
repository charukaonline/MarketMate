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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            addProducts1.Show();
            viewProducts1.Hide();
            manageCategories1.Hide();

        }

        private void addProductsBtn_Click(object sender, EventArgs e)
        {
            addProducts1.Show();
            viewProducts1.Hide();
            manageCategories1.Hide();
        }

        private void viewProductsBtn_Click(object sender, EventArgs e)
        {
            addProducts1.Hide();
            viewProducts1.Show();
            manageCategories1.Hide();
            viewProducts1.RefreshData();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            addProducts1.Hide();
            viewProducts1.Hide();
            manageCategories1.Show();
            manageCategories1.RefreshData();
        }
    }
}
