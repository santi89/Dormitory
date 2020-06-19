using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace C_Sharp_2_Project
{
    class Connect
    {
        static SqlConnection con = new SqlConnection ();
        public static SqlConnection getconnect()
        {
            try
            {
                string strcon = string.Format("Data Source=MSI;Initial Catalog=dbDormitory;Integrated Security=True");
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.ConnectionString = strcon;
                con.Open();
                return con;
            }
            catch (Exception ex)
            {

               return null;
            }
        }

    }
}
