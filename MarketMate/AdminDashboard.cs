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
        public AdminDashboard()
        {
            InitializeComponent();
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
        }
    }
}
