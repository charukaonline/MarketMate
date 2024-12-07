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
    public partial class CashierLogin : Form
    {
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameValidationLbl.Visible = false;
            pinValidationLbl.Visible = false;
        }

        private void goBackBtn_Click_1(object sender, EventArgs e)
        {
            UserSelectionForm userSelectionForm = new UserSelectionForm();
            userSelectionForm.Show();
            this.Hide();
        }
    }
}
