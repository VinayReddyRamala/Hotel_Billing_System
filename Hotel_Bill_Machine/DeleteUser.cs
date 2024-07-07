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
    public partial class DeleteUser : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd; DataSet ds; SqlDataAdapter da;
        DataGridViewRow row;
        string query,uname;
        public string username;
        bool selected = false;
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = true;
            row = dataGridView1.Rows[e.RowIndex];
            uname = row.Cells[0].Value.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username= username;
            mdi.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                dataGridView1.Rows.Remove(row);
                query = "delete users where username=@p1";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", uname);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Deleted");
            }
            else
                MessageBox.Show("Please select a user to delete");
        }
    }
}
