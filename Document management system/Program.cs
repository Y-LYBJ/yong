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
            Application.Run(new 教师主页面());
        }
    }

    public class ShowPage
    {
        public static string User = "用户";
        public static string Account = "账号";
        public static string Level = "级别";
        public static string Descreption = "(100字)";
        public static string Password = "Password";
    }
    public class PublicationSetting
    {
        public int Id { get; set; }
        public string Frequency { get; set; }
        public int PublishedIssuesCount { get; set; }
        public DateTime LastPublishedDate { get; set; }
    }

    public class ArtPage
    {
        public static string Article = "";
        public static string Advice = "";
        public static string Organize = "";
        public static string Type = "";
        public static string Path = "";
    }

    public class SQLpromgram
    {

        private SqlConnection conn = new();
        public bool SqlLoad(string My_user, string My_password, string My_id)      ///查询账户是否存在
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
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

        public void SqlAuthor()      ///引入作者信息
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql = "select * from Author where account= '" + ShowPage.Account + "'";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataReader mys = cmd.ExecuteReader();
            while (mys.Read())
            {
                ShowPage.User = mys.GetString(mys.GetOrdinal("organization"));
                ShowPage.Level = mys.GetString(mys.GetOrdinal("TheLevel"));
                ShowPage.Descreption = mys.GetString(mys.GetOrdinal("introduce"));
            }
        }

        public void SqlAudior()      ///引入编辑和主编信息
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql = "select * from Load where account= '" + ShowPage.Account + "'";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataReader mys = cmd.ExecuteReader();
            while (mys.Read())
            {
                ShowPage.User = mys.GetString(mys.GetOrdinal("organization"));
            }
        }
        public void SqlChangeDes(string Des)    ///修改简介
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "UPDATE Author SET introduce = '" + Des + "'where account= '" + ShowPage.Account + "'";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                ShowPage.Descreption = Des;
            }
            catch { MessageBox.Show("请输入正确的文字信息！"); }
        }

        public void SqlChangePassword(string My_user, string My_password)      ///修改密码
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "UPDATE Load SET password = '" + My_password + "'where account= '" + My_user + "'";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("密码修改成功！", "提示");
                    ShowPage.Password = My_password;
                }
                else
                {
                    MessageBox.Show("密码修改失败！", "提示");
                }
            }
            catch { MessageBox.Show("请输入正确的密码类型！"); }
        }

        public void SqlEnroll(string Acccount,string Name,string Identity)    ///注册
        {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql1 = "INSERT INTO Load (account,id,organization) VALUES ('";
                string sql2 = Acccount + "','" + Identity + "','" + Name + "')";
                string sql = sql1 + sql2;
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show("注册成功！", "提示");
                }
                else
                {
                    MessageBox.Show("注册失败！", "提示");
                }
        }


          public class PublicationDataAccess
        {
            private string connectionString;

            public PublicationDataAccess(string connString)
            {
            connectionString = connString;
            }

            public PublicationSetting GetPublicationSetting()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Frequency, PublishedIssuesCount, LastPublishedDate FROM PublicationSettings WHERE Id = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new PublicationSetting
                                {
                                    Frequency = reader["Frequency"].ToString(),
                                    PublishedIssuesCount = Convert.ToInt32(reader["PublishedIssuesCount"]),
                                    LastPublishedDate = Convert.ToDateTime(reader["LastPublishedDate"])
                                };
                            }
                        }
                    }
                }
                return null;
            }

            public void UpdatePublicationSetting(PublicationSetting setting)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PublicationSettings SET Frequency = @Frequency, PublishedIssuesCount = @PublishedIssuesCount, LastPublishedDate = @LastPublishedDate WHERE Id = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Frequency", setting.Frequency);
                        cmd.Parameters.AddWithValue("@PublishedIssuesCount", setting.PublishedIssuesCount);
                        cmd.Parameters.AddWithValue("@LastPublishedDate", setting.LastPublishedDate);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
         }
    }
}


}