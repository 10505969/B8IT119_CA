﻿using System;
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

        SqlConnection con = new SqlConnection();
      
        public FormLogin()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
              
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            {
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
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
    }
}