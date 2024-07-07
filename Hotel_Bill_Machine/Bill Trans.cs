using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Bill_Machine
{
    public partial class Bill_Trans : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlDataAdapter da; DataSet ds;
        SqlCommand cmd; SqlDataReader dr;
        DataRow row;
        DataGridViewRow gvrow;
        public static DataGridView billitems;

        Bill_Master billmaster = new Bill_Master();
        BillNumber newbill = new BillNumber();
        getbill bill= new getbill();

        string query; int price, qty;
        public string username;
        bool filled= true;
        int totalbill;
        int noitems;

        public Bill_Trans()
        {
            InitializeComponent();
        }

        private void Bill_Trans_Load(object sender, EventArgs e)
        {
            query = "select * from billtrans";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source);
            dataGridView1.DataSource = ds.Tables[0];

            query = "select items from items";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbitems.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void cmbitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price from items where items=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", cmbitems.Text);
            con.Open();
            int price =Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            txtprice.Text = price.ToString();
            txtqty.Text = "1";

            if (txtqty.Text.Length > 0 && txtprice.Text.Length > 0)
            {
                price = Convert.ToInt32(txtprice.Text);
                qty = Convert.ToInt32(txtqty.Text);
                txttprice.Text = (price * qty).ToString();
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            noitems = dataGridView1.RowCount;
            for(int i = 1; i <= noitems; i++)
            {
                gvrow= dataGridView1.Rows[i-1];
                totalbill += Convert.ToInt32(gvrow.Cells[4].Value);
            }
            //bill.totalbill = this.totalbill;
            Bill_Master.billmaster.txtbillamount.Text = totalbill.ToString();
            Bill_Master.billmaster.txtdate.Text=DateTime.Now.Date.ToString();
            Bill_Master.billmaster.txtstax.Text =Convert.ToInt32 (Convert.ToDouble(totalbill) * 0.05).ToString();
            Bill_Master.billmaster.txtvat.Text = Convert.ToInt32(Convert.ToDouble(totalbill) * 0.05).ToString();

            billitems = this.dataGridView1;
            billmaster.Visible = true;
            billmaster.username = username;
            billmaster.billitems = dataGridView1;

            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length == 0)
                    {
                        filled = false;
                    }
                }
            }

            if (filled && qty!=0)
            {
                row = ds.Tables[0].NewRow();
                row[0] = newbill.GetBillNum();
                row[1] = cmbitems.Text;
                row[2] = txtprice.Text;
                row[3] = txtqty.Text;
                row[4] = txttprice.Text;
                ds.Tables[0].Rows.Add(row);
            }
            else
            {
                if (qty == 0)
                    MessageBox.Show("Quantity Should not be Zero");
                else
                MessageBox.Show("Please fill all TextBoxes");
                filled = true;
            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if(txtqty.Text.Length > 0 && txtprice.Text.Length > 0)
            {
                price = Convert.ToInt32(txtprice.Text);
                qty = Convert.ToInt32(txtqty.Text);
                txttprice.Text = (price * qty).ToString();
            }
        }
    }
}
