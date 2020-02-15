using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace B8IT119_CA
{
    public partial class Homepage : Form
    {
        StudentTable st = new StudentTable();

        public Homepage()
        {
            InitializeComponent();
            dgStudents.DataSource = st.Stus();
            foreach (Control control in this.Controls)
            {
                control.Hide();
            }
            mainMenu.Show();
            dgStudents.Show();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin h = new FormLogin();
            h.ShowDialog();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Show();
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFirstName.ReadOnly = true;

            foreach (Control control in this.Controls)
            {
                control.Show();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
           
        }
    }
}
