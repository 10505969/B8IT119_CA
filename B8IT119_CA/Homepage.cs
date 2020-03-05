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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.IO;
using System.Configuration;


namespace B8IT119_CA
{
    public partial class Homepage : Form
    {
        StudentTable st = new StudentTable();
        StudentTable logs = new StudentTable();
        Students studentlist = new Students();
        int tab;

        private bool EmailChecker(string email) {
            try
            {
                MailAddress address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ButtonChecked()
        {
            if (rbUndergrad.Checked is true || rbPostgrad.Checked is true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateFields()
        {

            int studentNoLengthChecker;
            int studentId = 0;
           
            studentNoLengthChecker = txtStudentNo.Text.Length;

            var p = ConfigurationManager.AppSettings["phone"];
            var s = ConfigurationManager.AppSettings["stuNo"];


            Regex phone = new Regex(p);
            Regex studentNumber = new Regex(s);
                

            bool valid = txtFirstName.Text.Length > 0;
            valid &= txtSurname.Text.Length > 0;
            valid &= EmailChecker(txtEmail.Text);
            Match phoneMatch = phone.Match(txtPhone.Text);
            valid &= phoneMatch.Success;
            valid &= txtAddress1.Text.Length > 0;
            valid &= cmbCounty.SelectedIndex > -1;
            valid &= ButtonChecked();
            valid &= cmbCourse.SelectedIndex > -1;
            valid &= studentNoLengthChecker == 8;
            Match stunoMatch = studentNumber.Match(txtStudentNo.Text);
            valid &= stunoMatch.Success;
            valid &= int.TryParse(txtStudentNo.Text, out studentId);

            return valid;
        }

        public Homepage()
        {
            InitializeComponent();
            dgStudents.DataSource = st.Stus();
            dgChangeLog.DataSource = logs.History();

            foreach (Control control in this.Controls)
            {
                control.Hide();
            }
            mainMenu.Show();
            dgStudents.Show();
            btnXmlOutput.Show();
            txtXMLFolderPath.Show();
            lblXmlOutput.Show();

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
            tab = 1;
            
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
            txtEmail.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtAddress1.ReadOnly = false;
            txtAddress2.ReadOnly = false;
            txtCity.ReadOnly = false;
            cmbCounty.Enabled = true;
            rbPostgrad.Enabled = true;
            rbUndergrad.Enabled = true;
            txtStudentNo.ReadOnly = false;
            cmbCourse.Enabled = true;

            foreach (Control control in this.Controls)
                {             
                    control.Show();               
                }

            btnSearch.Hide();
            txtSearchStudentNo.Hide();
            lblSearch.Hide();
            btnEditStudent.Hide();
            btnDeleteStu.Hide();
            btnXMLStudent.Hide();
            lblStudentXML.Hide();
            txtXMLStudentPath.Hide();
            btnXMLStudent.Hide();
            dgChangeLog.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            Student s = new Student();
            if (ValidateFields())
            {
                if (s.StudentNoInUse(int.Parse(txtStudentNo.Text)))
                {
                    MessageBox.Show("Student number is already being used");
                }
                else
                {
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
                    dgChangeLog.DataSource = logs.History();

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
            }
            else
            {
                MessageBox.Show("One or more input fields is invalid");
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab = 2;
            
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
            txtEmail.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtAddress1.ReadOnly = false;
            txtAddress2.ReadOnly = false;
            txtCity.ReadOnly = false;
            cmbCounty.Enabled = true;
            rbPostgrad.Enabled = true;
            rbUndergrad.Enabled = true;
            cmbCourse.Enabled = false;


            foreach (Control control in this.Controls)
            {
                control.Hide();
            }

            mainMenu.Show();
            dgStudents.Show();
            txtSearchStudentNo.Show();
            btnSearch.Show();
            lblSearch.Show();
            btnXmlOutput.Show();
            txtXMLFolderPath.Show();
            lblXmlOutput.Show();
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Hide();
            }

            mainMenu.Show();
            dgStudents.Show();
            txtSearchStudentNo.Show();
            btnSearch.Show();
            lblSearch.Show();
            btnXmlOutput.Show();
            txtXMLFolderPath.Show();
            lblXmlOutput.Show();

            studentlist.Clear();
            Student s = new Student();

            bool valid = int.TryParse(txtSearchStudentNo.Text, out int studentId);

            if (valid)
            {
                if (s.IdVerifier(studentId) is false)
                {

                    MessageBox.Show("There is no student with that student number");
                }
                else
                {


                    s = s.GetStuById(studentId);

                    txtFirstName.Text = s.FirstName;
                    txtSurname.Text = s.LastName;
                    txtEmail.Text = s.Email;
                    txtPhone.Text = s.Phone;
                    txtAddress1.Text = s.Address1;
                    txtAddress2.Text = s.Address2;
                    txtCity.Text = s.City;
                    cmbCounty.SelectedItem = s.County;

                    if (s.Level == LevelEnum.Postgrad)
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

                    foreach (Control control in this.Controls)
                    {
                        control.Show();
                    }

                    txtSearchStudentNo.Clear();
                    btnAddStudent.Hide();
                    dgChangeLog.Hide();

                    if (tab == 2)
                    {
                        btnEditStudent.Show();
                        btnDeleteStu.Hide();
                    }
                    else if (tab == 3)
                    {
                        btnEditStudent.Hide();
                        btnDeleteStu.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid student number");
            }
          
           
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
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
                    MessageBox.Show("Record for student with Student Number " + s.StudentNo + " has been updated");
                }

                dgStudents.DataSource = st.Stus();
                dgChangeLog.DataSource = logs.History();
                studentlist.Clear();
                foreach (Control control in this.Controls)
                {
                    control.Hide();
                }

                mainMenu.Show();
                dgStudents.Show();
                txtSearchStudentNo.Show();
                txtSearchStudentNo.Clear();
                btnSearch.Show();
                lblSearch.Show();
                txtXMLFolderPath.Show();
                lblXmlOutput.Show();
                btnXmlOutput.Show();
            }
            else
            {
                MessageBox.Show("One or more input fields is invalid");
            }
        
    }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab = 3;
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
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress1.ReadOnly = true;
            txtAddress2.ReadOnly = true;
            txtCity.ReadOnly = true;
            cmbCounty.Enabled = false;
            rbPostgrad.Enabled = false;
            rbUndergrad.Enabled = false;

            foreach (Control control in this.Controls)
            {
                control.Hide();
            }

            mainMenu.Show();
            dgStudents.Show();
            txtSearchStudentNo.Show();
            btnSearch.Show();
            lblSearch.Show();
            btnXmlOutput.Show();
            txtXMLFolderPath.Show();
            lblXmlOutput.Show();
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            Student deletedStu = new Student();

            foreach (Student s in studentlist)
            {
                s.DeleteStudent();
                deletedStu = s;
            }

            MessageBox.Show("Record for student with Student Number " + deletedStu.StudentNo + " has been deleted");

            dgStudents.DataSource = st.Stus();
            dgChangeLog.DataSource = logs.History();
            studentlist.Clear();
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

            foreach (Control control in this.Controls)
            {
                control.Hide();
            }

            mainMenu.Show();
            dgStudents.Show();
            txtSearchStudentNo.Show();
            txtSearchStudentNo.Clear();
            btnSearch.Show();
            lblSearch.Show();
            txtXMLFolderPath.Show();
            lblXmlOutput.Show();
            btnXmlOutput.Show();

        }

        private void btnXmlOutput_Click(object sender, EventArgs e)
        {
            
            XMLOutput xml = new XMLOutput();
            string folderpath = txtXMLFolderPath.Text;

            bool valid = Directory.Exists(folderpath);

                if (valid)
            {
                xml.FullTabletoXml(folderpath);
                MessageBox.Show("The XML output is located here: \n" + folderpath + @"\Students.xml");
                txtXMLFolderPath.Clear();
            }
            else
            {
                MessageBox.Show("Please verify your folder path.");
            }           
        }

        private void btnXMLStudent_Click(object sender, EventArgs e)
        {
            XMLOutput xml = new XMLOutput();
            string folderpath = txtXMLStudentPath.Text;
            bool valid = Directory.Exists(folderpath);
           
            if (valid)
            {
                xml.StudentToXml(folderpath, txtStudentNo.Text);
                MessageBox.Show("The XML output is located here: \n" + folderpath + @"\" + txtStudentNo.Text + @".xml");
                txtXMLStudentPath.Clear();
            }
            else
            {
                MessageBox.Show("Please verify your folder path.");
            }
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab = 4;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            dgChangeLog.Show();
            mainMenu.Show();
        }

       
    }
}

