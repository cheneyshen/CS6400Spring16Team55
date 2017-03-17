using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace P3
{
    internal class Utility
    {
        //Get the connection string from App config file.
        internal static string GetConnectionString()
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["P3.Properties.Settings.connString"];
            //If found, return the connection string.
            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }

        internal static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}