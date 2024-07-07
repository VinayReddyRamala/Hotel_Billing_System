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
    public partial class Bill_Master : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd;

        Login_Form login = new Login_Form();
        public static Bill_Master billmaster;
        getbill bill = new getbill();
        login l1= new login();
        public DataGridView billitems;

        int toltbill;
        string query;
        public string username;
        
        public Bill_Master()
        {
            InitializeComponent();
            billmaster = this;
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            bill.totalbill=Convert.ToInt32(txtbillnum.Text);
            this.Hide();
            Bill_Trans bt=new Bill_Trans();
            bt.username = username;
            bt.Show();
        }

        private void Bill_Master_Load(object sender, EventArgs e)
        {
            BillNumber newbill=new BillNumber();
            txtbillnum.Text = newbill.GetBillNum().ToString();
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtdiscount.Text.Length > 0)
            {
                int bill=Convert.ToInt32(txtbillamount.Text);
                int discount = Convert.ToInt32(txtdiscount.Text);
                int stax = Convert.ToInt32(txtstax.Text);
                int vat = Convert.ToInt32(txtvat.Text);
                txttbill.Text = ((bill+vat+stax) - discount).ToString();
            }
        }

        private void txtdate_VisibleChanged(object sender, EventArgs e)
        {
            int bill = Convert.ToInt32(txtbillamount.Text);
            int discount = Convert.ToInt32(txtdiscount.Text);
            int stax = Convert.ToInt32(txtstax.Text);
            int vat = Convert.ToInt32(txtvat.Text);
            txttbill.Text = ((bill + vat + stax) - discount).ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txttbill.Text == "0" || txttbill.Text.Length == 0)
                MessageBox.Show("Please add Bills to Save");
            else
            {
                query = "insert into billmaster values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", txtbillnum.Text);
                cmd.Parameters.AddWithValue("@p2", txtdate.Text);
                cmd.Parameters.AddWithValue("@p3", txtbillamount.Text);
                cmd.Parameters.AddWithValue("@p4", txtstax.Text);
                cmd.Parameters.AddWithValue("@p5", txtvat.Text);
                cmd.Parameters.AddWithValue("@p6", txtdiscount.Text);
                cmd.Parameters.AddWithValue("@p7", txttbill.Text);
                cmd.Parameters.AddWithValue("@p8", username);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                for (i = 0; i < billitems.RowCount - 1; i++)
                {
                    DataGridViewRow row = billitems.Rows[i];
                    query = "insert into billtrans values(@p1,@p2,@p3,@p4,@p5)";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", row.Cells[0].Value);
                    cmd.Parameters.AddWithValue("@p2", row.Cells[1].Value);
                    cmd.Parameters.AddWithValue("@p3", row.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@p4", row.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@p5", row.Cells[4].Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show(i + " Bill(s) Inserted to the database");
            }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username = username;
            mdi.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    if(c.Name!= "txtbillnum")
                        c.Text = "";
                }
            }
        }
    }
}
