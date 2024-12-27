using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace spend_smart
{
    public class UserSession
    {
        public static int CurrentAdminID { get; private set; }
        public static string CurrentAdminUsername { get; private set; }

        public static void AdminStartSession(int userID, string username)
        {
            CurrentAdminID = userID;
            CurrentAdminUsername = username;
        }

        public static void AdminEndSession()
        {
            CurrentAdminID = 0;
            CurrentAdminUsername = null;
        }
    }

}