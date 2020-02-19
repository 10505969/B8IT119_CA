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
        Students studentlist = new Students();

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

            cmbCounty.DataSource = Enum.GetValues(typeof(CountiesEnum));
            cmbCounty.SelectedIndex = -1;

            cmbCourse.DataSource = Enum.GetValues(typeof(CourseEnum));
            cmbCourse.SelectedIndex = -1;            

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
            btnSearch.Hide();
            txtSearchStudentNo.Hide();
            btnEditStudent.Hide();

            txtFirstName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            cmbCounty.SelectedIndex = -1;
            rbUndergrad.Checked = false;
            rbPostgrad.Checked = false;
            cmbCourse.SelectedIndex = -1;
            txtStudentNo.Clear();
            txtFirstName.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtStudentNo.ReadOnly = false;
            cmbCourse.Enabled = true;

            foreach (Control control in this.Controls)
            {
                if (control == btnSearch )
                {
                    control.Hide();
                }
                else if ( control == txtSearchStudentNo)
                {
                    control.Hide();
                }
                else if (control == btnEditStudent)
                {
                    control.Hide();
                }
                else if (control == btnDeleteStu)
                {
                    control.Hide();
                }
                else
                {
                    control.Show();
                }
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddStudent.Hide();
            txtFirstName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            cmbCounty.SelectedIndex = -1;
            rbUndergrad.Checked = false;
            rbPostgrad.Checked = false;
            cmbCourse.SelectedIndex = -1;
            txtStudentNo.Clear();

            txtFirstName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            txtStudentNo.ReadOnly = true;
            cmbCourse.Enabled = false;
          
            foreach (Control control in this.Controls)
            {
                if (control == btnAddStudent)
                {
                    control.Hide();
                }
                else if (control == btnDeleteStu)
                {
                    control.Hide();
                }
                else
                {
                    control.Show();
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            Student s = new Student();
            s.FirstName = txtFirstName.Text;
            s.LastName = txtSurname.Text;
            s.Email = txtEmail.Text;
            s.Phone = txtPhone.Text;
            s.Address1 = txtAddress1.Text;
            s.Address2 = txtAddress2.Text;
            s.City = txtCity.Text;
            Enum.TryParse<CountiesEnum>(cmbCounty.SelectedValue.ToString(), out CountiesEnum county);
            s.County = county;
            if (rbUndergrad.Checked)
            {
                s.Level = LevelEnum.Undergrad;
            } 
            else if (rbPostgrad.Checked)
            {
                s.Level = LevelEnum.Postgrad;
            }
            Enum.TryParse<CourseEnum>(cmbCourse.SelectedValue.ToString(), out CourseEnum course);
            s.Course = course;
            s.StudentNo = int.Parse(txtStudentNo.Text);

            s.AddStudent();
            dgStudents.DataSource = st.Stus();

            MessageBox.Show("Student Added");
            txtFirstName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            cmbCounty.SelectedIndex = -1;
            rbUndergrad.Checked = false;
            rbPostgrad.Checked = false;
            cmbCourse.SelectedIndex = -1;
            txtStudentNo.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            studentlist.Clear();
            int studentnumber = int.Parse(txtSearchStudentNo.Text);
            Student s = new Student();
            s = s.GetStuById(studentnumber);

            txtFirstName.Text = s.FirstName;
            txtSurname.Text = s.LastName;
            txtEmail.Text = s.Email;
            txtPhone.Text = s.Phone;
            txtAddress1.Text = s.Address1;
            txtAddress2.Text = s.Address2;
            txtCity.Text = s.City;
            cmbCounty.SelectedItem = s.County;
         
            if(s.Level == LevelEnum.Postgrad)
            {
                rbPostgrad.Checked = true;
            }
            else if (s.Level == LevelEnum.Undergrad)
            {
                rbUndergrad.Checked = true;
            }

            cmbCourse.SelectedItem = s.Course;
            txtStudentNo.Text = s.StudentNo.ToString();
            studentlist.Add(s);
           
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            foreach (Student s in studentlist)
            {

                s.Email = txtEmail.Text;
                s.Phone = txtPhone.Text;
                s.Address1 = txtAddress1.Text;
                s.Address2 = txtAddress2.Text;
                s.City = txtCity.Text;
                Enum.TryParse<CountiesEnum>(cmbCounty.SelectedValue.ToString(), out CountiesEnum county); ;
                s.County = county;

                if (rbPostgrad.Checked == true)
                {
                    s.Level = LevelEnum.Postgrad;                   
                }
                else if (rbUndergrad.Checked == true)                   
                {
                    s.Level = LevelEnum.Undergrad;
                }

                Enum.TryParse<CourseEnum>(cmbCourse.SelectedValue.ToString(), out CourseEnum course);
                s.Course = course;
                s.StudentNo = int.Parse(txtStudentNo.Text);
                s.EditStudent();
            }

            dgStudents.DataSource = st.Stus();

        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control == btnAddStudent)
                {
                    control.Hide();
                }
                
                else if (control == btnEditStudent)
                {
                    control.Hide();
                }
                else
                {
                    control.Show();
                }
            }
        }
    }
}

