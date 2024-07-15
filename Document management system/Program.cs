using System.Security.Principal;
using System.Data.SqlClient;
using System.Data;

namespace Document_management_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoadChoice());
        }
    }

    public class SQLpromgram
    {
    public
        bool SqlLoad(string My_user,string My_password,string My_id)      ///查询账户是否存在
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=(local);Initial Catalog=\"management system\";Integrated Security=True";
            conn.Open();
            string sql = "select * from Load where account= '" + My_user + "' and password= '" + My_password + "' and id= '" + My_id + "'";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataReader mys = cmd.ExecuteReader();
            if (mys.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }


    }



}