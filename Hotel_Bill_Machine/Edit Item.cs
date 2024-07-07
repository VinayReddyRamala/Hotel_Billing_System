using System;
using System.Collections;
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
    public partial class Edit_Item : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd; 
        SqlDataAdapter da; 
        DataSet ds; 
        SqlCommandBuilder cb;
        DataGridViewRow selectedrow;


        int rowindex,i,j;
        string oldi,query, oldp;
        public string username;
        bool edited = false;

        public Edit_Item()
        {
            InitializeComponent();
        }

        private void Edit_Item_Load(object sender, EventArgs e)
        {
            string query = "select * from items";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "items");
            cb = new SqlCommandBuilder(da);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            selectedrow = dataGridView1.Rows[rowindex];
            txtitem.Text = selectedrow.Cells[0].Value.ToString();
            txtprice.Text = selectedrow.Cells[1].Value.ToString();
            oldi = txtitem.Text;
            oldp = txtprice.Text;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtitem.Text.Length != 0)
            {

                if (oldp != txtprice.Text)
                {
                    DataGridViewRow editrow = dataGridView1.Rows[rowindex];
                    editrow.Cells[0].Value = txtitem.Text;
                    editrow.Cells[1].Value = txtprice.Text;
                    MessageBox.Show("Item Edited");
                    edited = true;
                }
                else
                    MessageBox.Show("Please give different price");
            }
            else
                MessageBox.Show("Please select an item to Edit");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (edited)
            {

                int rowcount = dataGridView1.RowCount - 1;
                for (i = 0; i < rowcount; i++)
                {
                    query = "update items set price=@p2 where items=@p1";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Items Updated to DataBase");
            }
            else
                MessageBox.Show("There is No data to Edit","Information");
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
