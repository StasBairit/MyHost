using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace MyHost.Utils
{
    class DBConnection
    {
        private static SqlConnection cn = null;

        private DBConnection() { }

        public static SqlConnection GetConnection()
        {
            try
            {
                if (cn == null)
                {
                    cn = new SqlConnection(Properties.Settings.Default.MyConnectionString);
                    cn.Open();
                }
                else //if( )
                {
                    cn.Open();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return cn;
        }

        public static void Close()
        {
            if (cn != null)
            {
                cn.Close();
                cn = null;
            }
        }

        public static int GetIdentity()
        {
            int Identity = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", GetConnection());
                Identity = Convert.ToInt32(cmd.ExecuteScalar());
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + "\n" + exc.StackTrace);
            }

            return Identity;
        }

    }
    class FileUtils
    {
        public static string filePathBase = Directory.GetCurrentDirectory();
    }
}
