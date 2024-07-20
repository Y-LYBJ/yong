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

    public class ShowPage
    {
        public static string User = "�û�";
        public static string Account = "�˺�";
        public static string Level = "����";
        public static string Descreption = "(100��)";
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
        public bool SqlLoad(string My_user, string My_password, string My_id)      ///��ѯ�˻��Ƿ����
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

        public void SqlAuthor()      ///����������Ϣ
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

        public void SqlAudior()      ///����༭��������Ϣ
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
        public void SqlChangeDes(string Des)    ///�޸ļ��
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
            catch { MessageBox.Show("��������ȷ��������Ϣ��"); }
        }

        public void SqlChangePassword(string My_user, string My_password)      ///�޸�����
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
                    MessageBox.Show("�����޸ĳɹ���", "��ʾ");
                    ShowPage.Password = My_password;
                }
                else
                {
                    MessageBox.Show("�����޸�ʧ�ܣ�", "��ʾ");
                }
            }
            catch { MessageBox.Show("��������ȷ���������ͣ�"); }
        }

        public void SqlEnroll(string Acccount, string Name, string Identity)    ///ע��
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
                MessageBox.Show("ע��ɹ���", "��ʾ");
            }
            else
            {
                MessageBox.Show("ע��ʧ�ܣ�", "��ʾ");
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
                    string query = "SELECT Type, oid, Day FROM Teacher WHERE oid = (SELECT MAX(oid) FROM Teacher)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new PublicationSetting
                                {
                                    Frequency = reader["Type"].ToString(),
                                    PublishedIssuesCount = Convert.ToInt32(reader["oid"]),
                                    LastPublishedDate = Convert.ToDateTime(reader["Day"])
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
                    string str = "��" + Convert.ToString(setting.PublishedIssuesCount) + "��";
                    string query = "INSERT INTO Teacher (Type,AllCount,Day) VALUES (@Type,@AllCount,@Day)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", setting.Frequency);
                        cmd.Parameters.AddWithValue("@AllCount", str);
                        cmd.Parameters.AddWithValue("@Day", setting.LastPublishedDate);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}