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


namespace B8IT119_CA
{
    public partial class Homepage : Form
    {
        StudentTable st = new StudentTable();
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


        private bool Validate()
        {


            int studentNoLengthChecker;
            int studentId = 0;

           
            studentNoLengthChecker = txtStudentNo.Text.Length;

            //Regex phone = new Regex(@"\+?\d+-?\d+");

            bool valid = txtFirstName.Text.Length > 0;
            valid &= txtSurname.Text.Length > 0;
            valid &= EmailChecker(txtEmail.Text);
            //Match phoneMatch = phone.Match(txtEmail.Text);
            //valid &= phoneMatch.Success;
            valid &= txtAddress1.Text.Length > 0;
            valid &= cmbCounty.SelectedIndex > -1;
            valid &= ButtonChecked();
            valid &= cmbCourse.SelectedIndex > -1;
            valid &= studentNoLengthChecker == 8;
            valid &= int.TryParse(txtStudentNo.Text, out studentId);

            return valid;
        }


        public bool EmailCheck(string email)
        {
            string[] components;
            components = email.Split('@');

            if (components.Length > 1)
                {
                    if (email.EndsWith("@") is false)
                    {
                        if (email.Contains(" ") is false)
                        {
                            return true;
                        }
                        else
                        {
                        return false;
                        }
                    }
                    else
                    {
                    return false;
                    }
                }
                else
                {
                return false;
            }

        }

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
            tab = 1;
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
                else if (control == btnAddStudent)
                {
                    control.Show();
                }
                else
                {
                    control.Show();
                }
            }
       
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab = 2;
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
                else if (control == btnEditStudent)
                {
                    control.Show();
                    control.Enabled = false;
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
            if (Validate())
            {
                if (s.IdVerifier(int.Parse(txtStudentNo.Text))){

                    MessageBox.Show("StudentId Already Exitst");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            studentlist.Clear();

          Student s = new Student();
                s = s.GetStuById(int.Parse(txtSearchStudentNo.Text));

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

                if (tab == 2)
                {
                    btnEditStudent.Enabled = true;
                }
                else if (tab == 3)
                {
                    btnDeleteStu.Enabled = true;
                }
           
           
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
            studentlist.Clear();
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
                else if (control == btnDeleteStu)
                {
                    control.Enabled = false;
                }
                else
                {
                    control.Show();
                }
            }
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            foreach (Student s in studentlist)
            {
                s.DeleteStudent();
            }

            studentlist.Clear();
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            epValidate.SetError(txtFirstName, string.Empty);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            //Check to see if the textbox is empty
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                epValidate.SetError(txtFirstName, "Name must have a value");
                cancel = true;
            }
            e.Cancel = cancel;
        }
    }
}

