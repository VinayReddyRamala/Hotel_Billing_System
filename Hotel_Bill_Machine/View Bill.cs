using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Bill_Machine
{
    public partial class View_Bill : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd; SqlDataReader dr; SqlDataAdapter da; DataSet ds;

        string query;
        public string username;

        public View_Bill()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username= username;
            mdi.Show();
        }

        private void View_Bill_Load(object sender, EventArgs e)
        {
            query = "select billnumber from billmaster";
            cmd=new SqlCommand(query,con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbbillnum.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void cmbbillnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbillnum.Text.Length != 0)
            {
                query = "select * from billmaster where billnumber= " + cmbbillnum.Text;
                da = new SqlDataAdapter(query, con);
                ds = new DataSet();
                da.Fill(ds, "billmaster");
                dgvbillmaster.DataSource = ds.Tables["billmaster"];
            }
            else
                MessageBox.Show("Select a bill number from combobox");


            query = "select * from billtrans where billnumber = " + cmbbillnum.Text;
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "billtrans");
            dgvbilltrans.DataSource = ds.Tables["billtrans"];

        }
    }
}
