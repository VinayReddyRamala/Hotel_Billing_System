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
    public partial class ChangePassword : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlDataReader dr; SqlCommand cmd;
        string query;
        public string username;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            query = "select hintquestion,firstname from users";
            cmd=new SqlCommand(query, con);
            cmd.CommandType= CommandType.Text;
            con.Open();
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbhques.Items.Add(dr[0]); cmbfname.Items.Add(dr[1]);
            }
            con.Close();
        }

        private void radiooldpass_CheckedChanged(object sender, EventArgs e)
        {
            if (radiooldpass.Checked)
            {
                txthques.Visible = false;
                cmbhques.Visible = false;
                //cmbfname.Visible = true;
                label3.Text = "Enter Old Password";
            }
        }

        private void radiohques_CheckedChanged(object sender, EventArgs e)
        {
            if (radiohques.Checked)
            {
                txthques.Visible = true;
                cmbhques.Visible = true;
                cmbfname.Visible = false;
                label3.Text = "Enter Hint Answrert";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Change_Password check = new Change_Password();
            if (radiooldpass.Checked)
            {
                if (check.CheckPassword(txthanswer.Text))
                {
                    query = "update users set password=@p1 where password=@p2";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", txtnewpass.Text);
                    cmd.Parameters.AddWithValue("@p2", txthanswer.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Updated Succesfully");
                }
                else
                    MessageBox.Show("Invalid Password");
            }
            if (radiohques.Checked)
            {
                if (check.CheckHint(cmbhques.Text, txthanswer.Text))
                {
                    query = "update users set password=@p1 where hintanswer=@p2";
                    cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", txtnewpass.Text);
                    cmd.Parameters.AddWithValue("@p2", txthanswer.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Updated Succesfully");
                }
                else
                    MessageBox.Show("Invalid Hint");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username = username;
            mdi.Show();
        }
    }
    internal class Change_Password
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
        SqlDataReader dr; SqlCommand cmd;
        string query;
        internal bool CheckPassword(string password)
        {
            query="select * from users where password=@p1";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", password);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr .Read())
                return true;
            else 
                return false; 
        }
        internal bool CheckHint(string hintquestion,string hintanswer)
        {
            query = "select * from users where hintquestion=@p1 and hintanswer=@p2";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", hintquestion);
            cmd.Parameters.AddWithValue("@p2", hintanswer);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }
    }
}
