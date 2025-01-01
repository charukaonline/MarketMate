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
        private static readonly string connectionString = @"Data Source=cnk-nitro\sqlexpress;Initial Catalog=MarketmatePOS;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}