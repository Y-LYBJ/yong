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
            Application.Run(new �༭��ҳ��());
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

    public class ArtPage
    {
        public static string Article = "";
        public static string Advice = "";
        public static string Organize = "";
        public static string Type = "";
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
                int i = cmd.ExecuteNonQuery();
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

        public void SqlEnroll(string Acccount,string Name,string Identity)    ///ע��
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


    }


}