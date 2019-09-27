using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Chat_Application
{
    class admin
    {
        public string contr = "Data Source=FAWAD-PC;Initial Catalog=Chat_app;Integrated Security=True";

        public void insert(userinfo info)
        {
            SqlConnection con = new SqlConnection(contr);
            con.Open();
            SqlCommand command = new SqlCommand(string.Format("insert into userinfo values ('{0}','{1}','{2}','{3}')", info.fname, info.lname, info.email, info.password), con);
            command.ExecuteNonQuery();
        }
        public userinfo select(string email, string password)
        {
            userinfo info = new userinfo();
            SqlConnection sc = new SqlConnection(contr);
            sc.Open();
            SqlCommand command = new SqlCommand(string.Format("Select Firstname , Email , Password from userinfo where Email='{0}' AND Password='{1}'", email, password), sc);
            SqlDataReader sr = command.ExecuteReader();
            sr.Read();
            info.email = sr["Email"].ToString();
            info.password = sr["Password"].ToString();
            info.fname = sr["Firstname"].ToString();
            return info;
        }
    }
}
