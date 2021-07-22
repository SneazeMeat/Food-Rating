using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPage frm = new CustomerPage();
            frm.ShowDialog();

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (!(txtUserName.Text == string.Empty)) 
            {
                if (!(txtPassword.Text == string.Empty)) 
                {
                    if (txtUserName.Text == "Admin" || txtUserName.Text == "admin")
                    {
                        if (txtPassword.Text == "Admin" || txtPassword.Text == "admin")
                        {
                            this.Hide();
                            AdminDashBoard frm1 = new AdminDashBoard();
                            frm1.ShowDialog();
                        }
                        else 
                        {
                            MessageBox.Show("Password incorrect");
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Username Incorrect");
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
        }
    }
}
