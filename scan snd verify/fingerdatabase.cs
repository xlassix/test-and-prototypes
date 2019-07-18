using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace UI_Support
{
    class fingerdatabase
    {
        private static MySqlConnection databaseconnection;// init database connection 
        public string username { get; private set; }
        public string userid { get; private set; }
        public string scanid { get; private set; }
        private fingerdatabase(string u, string us, string scan) {
            username = u;
            userid = us;
            scanid = scan;
        }
        public static void initdb()
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.Server = "127.0.0.1";
            build.Database = "finger";
            build.UserID = "me";
            build.Password = "";
            string view = build.ToString();
            Console.WriteLine(view);
            build = null;
            databaseconnection = new MySqlConnection(view);
        }
        public static List<fingerdatabase> GetFingerdatabases()
        {
            List<fingerdatabase> user = new List<fingerdatabase>();
            string query = "SELECT * FROM fingerdb";
            MySqlCommand cmd = new MySqlCommand(query, databaseconnection);
            databaseconnection.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string username = read["username"].ToString();
                string userid = read["userid"].ToString();
                string scanid = read["scanid"].ToString();
                fingerdatabase u = new fingerdatabase(username, userid, scanid);
                user.Add(u);
            }
            databaseconnection.Close();
            return user;
        }
        public static fingerdatabase insert (string  user, string u){
            List<fingerdatabase> me = new List<fingerdatabase>();
            string y = string.Format("INSERT INTO fingerdb(username,userid,scanid) VALUES('{0}','{1}','{2}')", user, u,"scan registered yet");
            MySqlCommand cmd = new MySqlCommand(y, databaseconnection);
            databaseconnection.Open();
            cmd.ExecuteNonQuery();
            fingerdatabase open = new fingerdatabase(user, u, "scan registered yet");
            databaseconnection.Close();
            return open;
        }
        public void  update(string id , string scan)
        {
            string y = string.Format("UPDATE fingerdb SET scanid='{0}' WHERE (username='{1}')", scan, id);
            MySqlCommand cmd = new MySqlCommand(y, databaseconnection);
            databaseconnection.Open();
            cmd.ExecuteNonQuery();
            databaseconnection.Close();
        }
        public void delete()
        {
            string y = string.Format("DELETE from fingerdb WHERE  (username='{0}')", username);
            MySqlCommand cmd = new MySqlCommand(y, databaseconnection);
            databaseconnection.Open();
            cmd.ExecuteNonQuery();
            databaseconnection.Close();
        }
        public void deleteuser(string user)
        {
            string y = string.Format("DELETE from fingerdb WHERE  (username='{0}')", user);
            MySqlCommand cmd = new MySqlCommand(y, databaseconnection);
            databaseconnection.Open();
            cmd.ExecuteNonQuery();
            databaseconnection.Close();
        }
    }
}
