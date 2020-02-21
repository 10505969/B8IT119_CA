using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using BusinessLayer;

namespace B8IT119_CA
{
    public partial class FormLogin : Form
    {

        LoginHandler lh = new LoginHandler();

        public FormLogin()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                control.Hide();
            }
            mainMenu.Show();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lh.Login(txtUser.Text, txtPassword.Text) == true)
            {
                {
                    this.Hide();
                    Homepage h = new Homepage();
                    h.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Login Failure");
            }           
        }

        private void loginMainMenu_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Show();
            }
        }

        private void exitMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
