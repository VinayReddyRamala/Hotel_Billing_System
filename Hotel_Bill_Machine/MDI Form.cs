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
    public partial class MDI_Form : Form
    {
        public string username;
        public MDI_Form()
        {
            
            InitializeComponent();
        }


        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Item add_Item = new Add_Item();
            add_Item.username = username;
            add_Item.Show();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Item edit_Item = new Edit_Item();
            edit_Item.username = username;
            edit_Item.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Item delete_Item = new Delete_Item();
            delete_Item.username = username;
            delete_Item.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_User add_New_User = new Add_New_User();
            add_New_User.username = username;
            add_New_User.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.username = username;
            deleteUser.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.username = username;
            changePassword.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_User viewUser = new View_User();
            viewUser.username = username;
            viewUser.Show();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill_Master bill_Master = new Bill_Master();
            bill_Master.username = username;
            bill_Master.Show();
        }

        private void MDI_Form_Load(object sender, EventArgs e)
        {
            lbluser.Text = "Hi," + username;
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Bill view_Bill = new View_Bill();
            view_Bill.username = username;
            view_Bill.Show();
        }
    }
}
