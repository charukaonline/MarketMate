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
    public partial class UserSelectionForm : Form
    {
        public UserSelectionForm()
        {
            InitializeComponent();
        }

        private void CashierBtn_Click(object sender, EventArgs e)
        {
            CashierLogin cashierLogin = new CashierLogin();
            cashierLogin.Show();
            this.Hide();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
