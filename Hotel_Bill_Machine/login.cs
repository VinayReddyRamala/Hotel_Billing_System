using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Bill_Machine
{
    internal class login
    {
        public string username { get; set; }

        string query;
        
        SqlCommand cmd; SqlDataReader dr;
        public bool CheckUser(string username,string password)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
            query = "select * from users where username=@p1 and password=@p2";
            cmd=new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@p1", username);
            cmd.Parameters.AddWithValue("@p2", password);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
                con.Close();
            }
            else
            {
                return false;
                con.Close();
            }
        }
    }
}
