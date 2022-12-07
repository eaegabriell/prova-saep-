using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace APPSaep
{
    public class ClassConnecta
    {
            private static string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Desktop\APPSaep\APPSaep\APPSaep\DbSaep.mdf;Integrated Security=True";
            private static SqlConnection con = null;

            public static SqlConnection ObterConexao()
            {
                con = new SqlConnection(str);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                try
                {
                    con.Open();
                }
                catch (SqlException sqle)
                {
                    con = null;
                }
                return con;
            }

            public static void FecharConexao()
            {
                if (con != null || con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    
}
