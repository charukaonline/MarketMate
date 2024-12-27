using spend_smart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketMate.adminUserControls
{
    public partial class AddStocks : UserControl
    {
        private int adminID;
        private string adminUsername;
        public AddStocks()
        {
            InitializeComponent();
        }

        private void AddStocks_Load(object sender, EventArgs e)
        {
            adminID = UserSession.CurrentAdminID;
            adminUsername = UserSession.CurrentAdminUsername;
        }
    }
}
