namespace PRG282_Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvStudents = new DataGridView();
            lblSummary = new Label();
            cmbCourse = new ComboBox();
            lblCourse = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            grpStudentInfo = new GroupBox();
            txtSurname = new TextBox();
            label1 = new Label();
            btnAddStudent = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            grpSummary = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbFilterCourse = new ComboBox();
            lblFilterCourse = new Label();
            btnApplyFilter = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            HeaderName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            grpStudentInfo.SuspendLayout();
            grpSummary.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Location = new Point(6, 58);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(541, 296);
            dgvStudents.TabIndex = 2;
            dgvStudents.SelectionChanged += DgvStudents_SelectionChanged;
            // 
            // lblSummary
            // 
            lblSummary.BackColor = Color.Transparent;
            lblSummary.Location = new Point(6, 19);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(238, 198);
            lblSummary.TabIndex = 0;
            // 
            // cmbCourse
            // 
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Bachelor of Computing", "Bachelor of Information Technology", "Part-Time Bachelor of Information Technology", "Diploma in Information Technology", "Diploma for Deaf Students", "National Certificate: IT (Systems Development)", "Certificate: IT (Database Development)" });
            cmbCourse.Location = new Point(116, 143);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(164, 23);
            cmbCourse.TabIndex = 7;
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(10, 146);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(100, 23);
            lblCourse.TabIndex = 6;
            lblCourse.Text = "Course:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(116, 113);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(164, 23);
            txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(10, 116);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age:";
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.Location = new Point(10, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(116, 22);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(164, 23);
            txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.Location = new Point(10, 25);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(100, 23);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // grpStudentInfo
            // 
            grpStudentInfo.Controls.Add(txtSurname);
            grpStudentInfo.Controls.Add(label1);
            grpStudentInfo.Controls.Add(btnAddStudent);
            grpStudentInfo.Controls.Add(lblStudentId);
            grpStudentInfo.Controls.Add(btnUpdateStudent);
            grpStudentInfo.Controls.Add(txtStudentId);
            grpStudentInfo.Controls.Add(lblName);
            grpStudentInfo.Controls.Add(btnDeleteStudent);
            grpStudentInfo.Controls.Add(txtName);
            grpStudentInfo.Controls.Add(lblAge);
            grpStudentInfo.Controls.Add(txtAge);
            grpStudentInfo.Controls.Add(lblCourse);
            grpStudentInfo.Controls.Add(cmbCourse);
            grpStudentInfo.Location = new Point(40, 117);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Size = new Size(297, 232);
            grpStudentInfo.TabIndex = 0;
            grpStudentInfo.TabStop = false;
            grpStudentInfo.Text = "Student Information";
            grpStudentInfo.Enter += grpStudentInfo_Enter;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(116, 84);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(164, 23);
            txtSurname.TabIndex = 9;
            // 
            // label1
            // 
            label1.Location = new Point(10, 84);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            label1.Text = "Surname:";
            label1.Click += label1_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(0, 192, 0);
            btnAddStudent.Location = new Point(6, 187);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(90, 30);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += BtnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateStudent.Location = new Point(102, 187);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(90, 30);
            btnUpdateStudent.TabIndex = 1;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += BtnUpdateStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = Color.Red;
            btnDeleteStudent.Location = new Point(198, 187);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(90, 30);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            btnDeleteStudent.Click += BtnDeleteStudent_Click;
            // 
            // grpSummary
            // 
            grpSummary.BackColor = Color.Transparent;
            grpSummary.Controls.Add(lblSummary);
            grpSummary.Location = new Point(343, 117);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(250, 232);
            grpSummary.TabIndex = 3;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary";
            grpSummary.Enter += grpSummary_Enter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(40, 326);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // cmbFilterCourse
            // 
            cmbFilterCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterCourse.FormattingEnabled = true;
            cmbFilterCourse.Items.AddRange(new object[] { "Bachelor of Computing", "Bachelor of Information Technology", "Part-Time Bachelor of Information Technology", "Diploma in Information Technology", "Diploma for Deaf Students", "National Certificate: IT (Systems Development)", "Certificate: IT (Database Development)" });
            cmbFilterCourse.Location = new Point(212, 22);
            cmbFilterCourse.Name = "cmbFilterCourse";
            cmbFilterCourse.Size = new Size(200, 23);
            cmbFilterCourse.TabIndex = 6;
            // 
            // lblFilterCourse
            // 
            lblFilterCourse.AutoSize = true;
            lblFilterCourse.Location = new Point(246, 326);
            lblFilterCourse.Name = "lblFilterCourse";
            lblFilterCourse.Size = new Size(76, 15);
            lblFilterCourse.TabIndex = 7;
            lblFilterCourse.Text = "Filter Course:";
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(418, 22);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(75, 23);
            btnApplyFilter.TabIndex = 8;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += BtnApplyFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnApplyFilter);
            groupBox1.Controls.Add(dgvStudents);
            groupBox1.Controls.Add(cmbFilterCourse);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(40, 355);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 360);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Table";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // HeaderName
            // 
            HeaderName.AutoSize = true;
            HeaderName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderName.Location = new Point(252, 51);
            HeaderName.Name = "HeaderName";
            HeaderName.Size = new Size(301, 30);
            HeaderName.TabIndex = 11;
            HeaderName.Text = "Student Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(627, 752);
            Controls.Add(HeaderName);
            Controls.Add(pictureBox1);
            Controls.Add(grpStudentInfo);
            Controls.Add(grpSummary);
            Controls.Add(lblSearch);
            Controls.Add(lblFilterCourse);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Student Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            grpStudentInfo.ResumeLayout(false);
            grpStudentInfo.PerformLayout();
            grpSummary.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterCourse;
        private System.Windows.Forms.Label lblFilterCourse;
        private System.Windows.Forms.Button btnApplyFilter;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label HeaderName;
    }
}
