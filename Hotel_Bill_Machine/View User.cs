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
    public partial class View_User : Form
    {
        public string username;
        public View_User()
        {
            InitializeComponent();
        }

        private void View_User_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-Q6ES58N;Integrated Security=SSPI;database=vinay");
            SqlDataAdapter da; DataSet ds;
            string query="select * from users";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables["users"];
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDI_Form mdi = new MDI_Form();
            mdi.username= username;
            mdi.Show();
        }
    }
}
