using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Bill_Machine
{
    public partial class Login_Form : Form
    {
        public string username;
        public static Login_Form login;
        public Login_Form()
        {
            InitializeComponent();
            login = this;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool allowed = false;

            
            login l1= new login();
            allowed = l1.CheckUser(txtuid.Text,txtpass.Text);
            if (allowed)
            {
                username= txtuid.Text;
                this.Hide();
                MDI_Form mdi = new MDI_Form();
                mdi.username = username;
                mdi.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserID / Password..");
            }
        }
    }
}
