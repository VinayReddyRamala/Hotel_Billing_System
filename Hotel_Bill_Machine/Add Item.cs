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
    public partial class Add_Item : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd; SqlDataAdapter da; DataSet ds; DataRow row; SqlCommandBuilder cb;
        string query;
        public string username;
        public Add_Item()
        {
            InitializeComponent();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            string query = "select * from items";
            da=new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "items");
            cb = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtitem.Text.Length != 0 && txtprice.Text.Length != 0)
            {
                row = ds.Tables[0].NewRow();
                row[0] = txtitem.Text;
                row[1] = txtprice.Text;
                ds.Tables[0].Rows.Add(row);
                MessageBox.Show("New Item Added");
            }
            else
                MessageBox.Show("Please Enter Data to Add");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            da.Update(ds, "items");
            MessageBox.Show("Items Saved to DataBase");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username = username;
            mdi.Show();
        }
    }
}
