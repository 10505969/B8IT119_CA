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
            foreach (var c in Enum.GetValues(typeof(CountiesEnum)))
            {
                cmbCounty.Items.Add(c);
            }

            foreach (var c in Enum.GetValues(typeof(CourseEnum)))
            {
                cmbCourse.Items.Add(c);
            }

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
            Student s = new Student();
            s.FirstName = txtFirstName.Text;
            s.LastName = txtFirstName.Text;
            s.Email = txtEmail.Text;
            s.Phone = txtPhone.Text;
            s.Address1 = txtAddress1.Text;
            s.Address2 = txtAddress2.Text;
            s.City = txtCity.Text;
            Enum.TryParse(cmbCounty.SelectedText, out CountiesEnum county);
            s.County = county;
            if (rbUndergrad.Checked)
            {
                s.Level = LevelEnum.Undergrad;
            } 
            else if (rbPostgrad.Checked)
            {
                s.Level = LevelEnum.Postgrad;
            }
            Enum.TryParse(cmbCourse.SelectedText, out CourseEnum course);
            s.StudentNo = int.Parse(txtStudentNo.Text);

            Student.AddStudent(s);

            MessageBox.Show("Student Added");
            dgStudents.Refresh();
        }

        
    }
}
