using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Hotel_Bill_Machine
{
    public partial class Delete_Item : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewRow row;
        List<string> deleteditems = new List<string>();

        int Index,i,j;
        string Sqlcon, query;
        public string username;

        public Delete_Item()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtitem.Text.Length != 0)
            {
                deleteditems.Add(row.Cells[0].Value.ToString());
                DGVItems.Rows.Remove(row);
                MessageBox.Show("Item Removed from the List");
            }
            else
                MessageBox.Show("Please select an item from the List");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            MDI_Form mdi = new MDI_Form();
            mdi.username = username;
            this.Hide();
            mdi.Show();
        }

        private void DGVItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            row = DGVItems.Rows[Index];
            txtitem.Text = row.Cells[0].Value.ToString();
            txtprice.Text = row.Cells[1].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (deleteditems.Count != 0)
            {
                for (i = 0; i < deleteditems.Count; i++)
                {
                    query = "delete items where items=@p1";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", deleteditems[i]);
                    con.Open();
                    j = cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show(j + " Item(s) Deleted from the DataBase");
            }
            else
                MessageBox.Show("There is no Data to Save");
        }

        private void Delete_Item_Load(object sender, EventArgs e)
        {
            Sqlcon = "server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay";
            con = new SqlConnection(Sqlcon);
            query = "Select * from Items";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "HotelItems");
            DGVItems.DataSource = ds.Tables[0];
        }
    }
}
