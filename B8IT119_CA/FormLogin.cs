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
            if (lh.login(txtUser.Text, txtPassword.Text) == true)
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

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //con.Open();
            //string UserName = txtUser.Text;
            //string pword = txtPassword.Text;
            //SqlCommand cmd = new SqlCommand("select UserName, pword from Users where UserName='" + txtUser.Text + "'and pword='" + txtPassword.Text + "'", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    this.Hide();
            //    Homepage h = new Homepage();
            //    h.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Login please check username and password");
            //}
            //con.Close();            
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
