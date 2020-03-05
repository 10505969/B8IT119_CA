namespace B8IT119_CA
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.rbUndergrad = new System.Windows.Forms.RadioButton();
            this.rbPostgrad = new System.Windows.Forms.RadioButton();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchStudentNo = new System.Windows.Forms.TextBox();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStu = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnXmlOutput = new System.Windows.Forms.Button();
            this.txtXMLFolderPath = new System.Windows.Forms.TextBox();
            this.lblXmlOutput = new System.Windows.Forms.Label();
            this.lblStudentXML = new System.Windows.Forms.Label();
            this.txtXMLStudentPath = new System.Windows.Forms.TextBox();
            this.btnXMLStudent = new System.Windows.Forms.Button();
            this.dgChangeLog = new System.Windows.Forms.DataGridView();
            this.lblMan1 = new System.Windows.Forms.Label();
            this.lblMan2 = new System.Windows.Forms.Label();
            this.lblMan4 = new System.Windows.Forms.Label();
            this.lblMan3 = new System.Windows.Forms.Label();
            this.lblMan5 = new System.Windows.Forms.Label();
            this.lblMan6 = new System.Windows.Forms.Label();
            this.lblMan7 = new System.Windows.Forms.Label();
            this.lblMan8 = new System.Windows.Forms.Label();
            this.lblMan9 = new System.Windows.Forms.Label();
            this.lblMan10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChangeLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStudents
            // 
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Location = new System.Drawing.Point(12, 36);
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.Size = new System.Drawing.Size(620, 163);
            this.dgStudents.TabIndex = 9;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(692, 24);
            this.mainMenu.TabIndex = 10;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.editStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newStudentToolStripMenuItem.Text = "New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // viewDatabaseHistoryToolStripMenuItem
            // 
            this.viewDatabaseHistoryToolStripMenuItem.Name = "viewDatabaseHistoryToolStripMenuItem";
            this.viewDatabaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.viewDatabaseHistoryToolStripMenuItem.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(193, 311);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(57, 318);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(57, 344);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(193, 337);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 370);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 363);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(57, 396);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(193, 389);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 17;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(57, 424);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblAddress1.TabIndex = 20;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(193, 417);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(100, 20);
            this.txtAddress1.TabIndex = 19;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(57, 450);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblAddress2.TabIndex = 22;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(193, 443);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(100, 20);
            this.txtAddress2.TabIndex = 21;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(57, 502);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 26;
            this.lblCounty.Text = "County";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(57, 476);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(193, 469);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 23;
            // 
            // cmbCounty
            // 
            this.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(193, 499);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(121, 21);
            this.cmbCounty.TabIndex = 27;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(57, 539);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 28;
            this.lblLevel.Text = "Level";
            // 
            // rbUndergrad
            // 
            this.rbUndergrad.AutoSize = true;
            this.rbUndergrad.Location = new System.Drawing.Point(193, 539);
            this.rbUndergrad.Name = "rbUndergrad";
            this.rbUndergrad.Size = new System.Drawing.Size(75, 17);
            this.rbUndergrad.TabIndex = 29;
            this.rbUndergrad.TabStop = true;
            this.rbUndergrad.Text = "Undergrad";
            this.rbUndergrad.UseVisualStyleBackColor = true;
            // 
            // rbPostgrad
            // 
            this.rbPostgrad.AutoSize = true;
            this.rbPostgrad.Location = new System.Drawing.Point(274, 539);
            this.rbPostgrad.Name = "rbPostgrad";
            this.rbPostgrad.Size = new System.Drawing.Size(67, 17);
            this.rbPostgrad.TabIndex = 30;
            this.rbPostgrad.TabStop = true;
            this.rbPostgrad.Text = "Postgrad";
            this.rbPostgrad.UseVisualStyleBackColor = true;
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(193, 576);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 32;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(57, 579);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 31;
            this.lblCourse.Text = "Course";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(57, 610);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(64, 13);
            this.lblStudentNo.TabIndex = 33;
            this.lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(193, 603);
            this.txtStudentNo.MaxLength = 8;
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNo.TabIndex = 34;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(403, 308);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 35;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 363);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchStudentNo
            // 
            this.txtSearchStudentNo.Location = new System.Drawing.Point(403, 363);
            this.txtSearchStudentNo.MaxLength = 8;
            this.txtSearchStudentNo.Name = "txtSearchStudentNo";
            this.txtSearchStudentNo.Size = new System.Drawing.Size(100, 20);
            this.txtSearchStudentNo.TabIndex = 37;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(403, 308);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudent.TabIndex = 38;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStu
            // 
            this.btnDeleteStu.Location = new System.Drawing.Point(403, 308);
            this.btnDeleteStu.Name = "btnDeleteStu";
            this.btnDeleteStu.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteStu.TabIndex = 39;
            this.btnDeleteStu.Text = "Delete Student";
            this.btnDeleteStu.UseVisualStyleBackColor = true;
            this.btnDeleteStu.Click += new System.EventHandler(this.btnDeleteStu_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(400, 344);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(104, 13);
            this.lblSearch.TabIndex = 40;
            this.lblSearch.Text = "Search by StudentId";
            // 
            // btnXmlOutput
            // 
            this.btnXmlOutput.Location = new System.Drawing.Point(15, 280);
            this.btnXmlOutput.Name = "btnXmlOutput";
            this.btnXmlOutput.Size = new System.Drawing.Size(186, 23);
            this.btnXmlOutput.TabIndex = 41;
            this.btnXmlOutput.Text = "Output Student Database to XML";
            this.btnXmlOutput.UseVisualStyleBackColor = true;
            this.btnXmlOutput.Click += new System.EventHandler(this.btnXmlOutput_Click);
            // 
            // txtXMLFolderPath
            // 
            this.txtXMLFolderPath.Location = new System.Drawing.Point(15, 244);
            this.txtXMLFolderPath.Name = "txtXMLFolderPath";
            this.txtXMLFolderPath.Size = new System.Drawing.Size(236, 20);
            this.txtXMLFolderPath.TabIndex = 42;
            // 
            // lblXmlOutput
            // 
            this.lblXmlOutput.AutoSize = true;
            this.lblXmlOutput.Location = new System.Drawing.Point(12, 202);
            this.lblXmlOutput.Name = "lblXmlOutput";
            this.lblXmlOutput.Size = new System.Drawing.Size(222, 39);
            this.lblXmlOutput.TabIndex = 43;
            this.lblXmlOutput.Text = "To output the entire student database please \r\nenter the full path of the folder " +
    "you would like \r\nthe file to be written to.";
            // 
            // lblStudentXML
            // 
            this.lblStudentXML.AutoSize = true;
            this.lblStudentXML.Location = new System.Drawing.Point(385, 398);
            this.lblStudentXML.Name = "lblStudentXML";
            this.lblStudentXML.Size = new System.Drawing.Size(247, 39);
            this.lblStudentXML.TabIndex = 45;
            this.lblStudentXML.Text = "To output the student record to an XML file please \r\nenter the full path of the f" +
    "older you would like \r\nthe file to be written to.";
            // 
            // txtXMLStudentPath
            // 
            this.txtXMLStudentPath.Location = new System.Drawing.Point(388, 440);
            this.txtXMLStudentPath.Name = "txtXMLStudentPath";
            this.txtXMLStudentPath.Size = new System.Drawing.Size(236, 20);
            this.txtXMLStudentPath.TabIndex = 44;
            // 
            // btnXMLStudent
            // 
            this.btnXMLStudent.Location = new System.Drawing.Point(388, 476);
            this.btnXMLStudent.Name = "btnXMLStudent";
            this.btnXMLStudent.Size = new System.Drawing.Size(186, 23);
            this.btnXMLStudent.TabIndex = 46;
            this.btnXMLStudent.Text = "Output Student Record to XML";
            this.btnXMLStudent.UseVisualStyleBackColor = true;
            this.btnXMLStudent.Click += new System.EventHandler(this.btnXMLStudent_Click);
            // 
            // dgChangeLog
            // 
            this.dgChangeLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChangeLog.Location = new System.Drawing.Point(12, 36);
            this.dgChangeLog.Name = "dgChangeLog";
            this.dgChangeLog.Size = new System.Drawing.Size(620, 163);
            this.dgChangeLog.TabIndex = 47;
            // 
            // lblMan1
            // 
            this.lblMan1.AutoSize = true;
            this.lblMan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan1.Location = new System.Drawing.Point(296, 316);
            this.lblMan1.Name = "lblMan1";
            this.lblMan1.Size = new System.Drawing.Size(14, 17);
            this.lblMan1.TabIndex = 48;
            this.lblMan1.Text = "*";
            // 
            // lblMan2
            // 
            this.lblMan2.AutoSize = true;
            this.lblMan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan2.Location = new System.Drawing.Point(296, 342);
            this.lblMan2.Name = "lblMan2";
            this.lblMan2.Size = new System.Drawing.Size(14, 17);
            this.lblMan2.TabIndex = 50;
            this.lblMan2.Text = "*";
            // 
            // lblMan4
            // 
            this.lblMan4.AutoSize = true;
            this.lblMan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan4.Location = new System.Drawing.Point(296, 394);
            this.lblMan4.Name = "lblMan4";
            this.lblMan4.Size = new System.Drawing.Size(14, 17);
            this.lblMan4.TabIndex = 51;
            this.lblMan4.Text = "*";
            // 
            // lblMan3
            // 
            this.lblMan3.AutoSize = true;
            this.lblMan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan3.Location = new System.Drawing.Point(296, 368);
            this.lblMan3.Name = "lblMan3";
            this.lblMan3.Size = new System.Drawing.Size(14, 17);
            this.lblMan3.TabIndex = 52;
            this.lblMan3.Text = "*";
            // 
            // lblMan5
            // 
            this.lblMan5.AutoSize = true;
            this.lblMan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan5.Location = new System.Drawing.Point(296, 422);
            this.lblMan5.Name = "lblMan5";
            this.lblMan5.Size = new System.Drawing.Size(14, 17);
            this.lblMan5.TabIndex = 53;
            this.lblMan5.Text = "*";
            // 
            // lblMan6
            // 
            this.lblMan6.AutoSize = true;
            this.lblMan6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan6.Location = new System.Drawing.Point(320, 503);
            this.lblMan6.Name = "lblMan6";
            this.lblMan6.Size = new System.Drawing.Size(14, 17);
            this.lblMan6.TabIndex = 54;
            this.lblMan6.Text = "*";
            // 
            // lblMan7
            // 
            this.lblMan7.AutoSize = true;
            this.lblMan7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan7.Location = new System.Drawing.Point(347, 539);
            this.lblMan7.Name = "lblMan7";
            this.lblMan7.Size = new System.Drawing.Size(14, 17);
            this.lblMan7.TabIndex = 55;
            this.lblMan7.Text = "*";
            // 
            // lblMan8
            // 
            this.lblMan8.AutoSize = true;
            this.lblMan8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan8.Location = new System.Drawing.Point(327, 580);
            this.lblMan8.Name = "lblMan8";
            this.lblMan8.Size = new System.Drawing.Size(14, 17);
            this.lblMan8.TabIndex = 56;
            this.lblMan8.Text = "*";
            // 
            // lblMan9
            // 
            this.lblMan9.AutoSize = true;
            this.lblMan9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan9.Location = new System.Drawing.Point(320, 606);
            this.lblMan9.Name = "lblMan9";
            this.lblMan9.Size = new System.Drawing.Size(14, 17);
            this.lblMan9.TabIndex = 57;
            this.lblMan9.Text = "*";
            // 
            // lblMan10
            // 
            this.lblMan10.AutoSize = true;
            this.lblMan10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan10.Location = new System.Drawing.Point(57, 647);
            this.lblMan10.Name = "lblMan10";
            this.lblMan10.Size = new System.Drawing.Size(135, 17);
            this.lblMan10.TabIndex = 58;
            this.lblMan10.Text = "* Mandatory Field";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 715);
            this.Controls.Add(this.lblMan10);
            this.Controls.Add(this.lblMan9);
            this.Controls.Add(this.lblMan8);
            this.Controls.Add(this.lblMan7);
            this.Controls.Add(this.lblMan6);
            this.Controls.Add(this.lblMan5);
            this.Controls.Add(this.lblMan3);
            this.Controls.Add(this.lblMan4);
            this.Controls.Add(this.lblMan2);
            this.Controls.Add(this.lblMan1);
            this.Controls.Add(this.dgChangeLog);
            this.Controls.Add(this.btnXMLStudent);
            this.Controls.Add(this.lblStudentXML);
            this.Controls.Add(this.txtXMLStudentPath);
            this.Controls.Add(this.lblXmlOutput);
            this.Controls.Add(this.txtXMLFolderPath);
            this.Controls.Add(this.btnXmlOutput);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDeleteStu);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.txtSearchStudentNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.rbPostgrad);
            this.Controls.Add(this.rbUndergrad);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cmbCounty);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.dgStudents);
            this.Name = "Homepage";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChangeLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.RadioButton rbUndergrad;
        private System.Windows.Forms.RadioButton rbPostgrad;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchStudentNo;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStu;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnXmlOutput;
        private System.Windows.Forms.TextBox txtXMLFolderPath;
        private System.Windows.Forms.Label lblXmlOutput;
        private System.Windows.Forms.Label lblStudentXML;
        private System.Windows.Forms.TextBox txtXMLStudentPath;
        private System.Windows.Forms.Button btnXMLStudent;
        private System.Windows.Forms.DataGridView dgChangeLog;
        private System.Windows.Forms.Label lblMan1;
        private System.Windows.Forms.Label lblMan2;
        private System.Windows.Forms.Label lblMan4;
        private System.Windows.Forms.Label lblMan3;
        private System.Windows.Forms.Label lblMan5;
        private System.Windows.Forms.Label lblMan6;
        private System.Windows.Forms.Label lblMan7;
        private System.Windows.Forms.Label lblMan8;
        private System.Windows.Forms.Label lblMan9;
        private System.Windows.Forms.Label lblMan10;
    }
}