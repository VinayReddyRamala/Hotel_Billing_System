using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Bill_Machine
{
    internal class BillNumber
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlDataAdapter da; DataSet ds; SqlCommand cmd; SqlDataReader dr;
        string query;
        int lastrow, lastbillnum;
        public int GetBillNum()
        {
            query = "select BillNumber from billtrans";
            cmd=new SqlCommand(query, con);
            cmd.CommandType= CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lastbillnum =Convert.ToInt32( dr[0]);
            }
            con.Close();
            return lastbillnum+1;
        }
    }
    public class getbill
    {
        public int totalbill { set; get; }
    }
}
