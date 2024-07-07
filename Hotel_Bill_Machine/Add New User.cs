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
    public partial class Add_New_User : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd; SqlDataReader dr;

        List<string> usernames = new List<string>();
        string query;
        public string username;
        bool filled = true, existed = true;
        public Add_New_User()
        {
            InitializeComponent();
        }

        private void Add_New_User_Load(object sender, EventArgs e)
        {
            query = "select hintquestion from users";
            cmd=new SqlCommand (query,con);
            cmd.CommandType=CommandType.Text;
            con.Open();
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbhque.Items.Add(dr[0]);
            }
            con.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    if (c.Text.Length == 0)
                        filled = false;
            }

            if (filled)
            {
                users u1 = new users();
                existed = u1.getusers(txtuname.Text);
                if (existed)
                    MessageBox.Show("Username already existed");
                else
                {
                    query = "insert into users values(@p1,@p2,@p3,@p4,@p5,@p6)";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", txtuname.Text);
                    cmd.Parameters.AddWithValue("@p2", txtpass.Text);
                    cmd.Parameters.AddWithValue("@p3", txtfname.Text);
                    cmd.Parameters.AddWithValue("@p4", txtsname.Text);
                    cmd.Parameters.AddWithValue("@p5", cmbhque.Text);
                    cmd.Parameters.AddWithValue("@p6", txthans.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(i + " Users Added to DataBase");
                }
            }
            else
                MessageBox.Show("Please fill all textboxes to Create User");
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            cmbhque.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username = username;
            mdi.Show();
        }
    }
    public class users
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlCommand cmd; SqlDataReader dr;
        List<string> usernames = new List<string>();
        bool existed = false;
        public bool getusers(string user)
        {
            cmd = new SqlCommand("select username from users", con) ;
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (user == dr[0].ToString())
                    existed = true;
            }
            con.Close();
            return existed ;
        }
    }
}
