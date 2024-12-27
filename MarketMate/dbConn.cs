using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketMate
{
    public static class dbConn
    {
        private static readonly string connectionString = @"Data Source=localhost,1433;Initial Catalog=MarketmatePOS;Persist Security Info=True;User ID=sa;Password=<pass123>;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}