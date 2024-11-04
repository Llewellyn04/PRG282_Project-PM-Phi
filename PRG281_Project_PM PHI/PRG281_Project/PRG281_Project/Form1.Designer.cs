namespace PRG281_Project
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpStudentInfo = new GroupBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSurname = new Label();
            txtSurname = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblCourse = new Label();
            cmbCourse = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            grpSummary = new GroupBox();
            lblTotalStudents = new Label();
            lblAverageAge = new Label();
            grpTable = new GroupBox();
            txtFilter = new TextBox();
            cmbFilter = new ComboBox();
            btnApplyFilter = new Button();
            dgvStudents = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            grpStudentInfo.SuspendLayout();
            grpSummary.SuspendLayout();
            grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpStudentInfo
            // 
            grpStudentInfo.Controls.Add(lblStudentId);
            grpStudentInfo.Controls.Add(txtStudentId);
            grpStudentInfo.Controls.Add(lblName);
            grpStudentInfo.Controls.Add(txtName);
            grpStudentInfo.Controls.Add(lblSurname);
            grpStudentInfo.Controls.Add(txtSurname);
            grpStudentInfo.Controls.Add(lblAge);
            grpStudentInfo.Controls.Add(txtAge);
            grpStudentInfo.Controls.Add(lblCourse);
            grpStudentInfo.Controls.Add(cmbCourse);
            grpStudentInfo.Controls.Add(btnAdd);
            grpStudentInfo.Controls.Add(btnUpdate);
            grpStudentInfo.Controls.Add(btnDelete);
            grpStudentInfo.Location = new Point(12, 169);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Size = new Size(394, 251);
            grpStudentInfo.TabIndex = 0;
            grpStudentInfo.TabStop = false;
            grpStudentInfo.Text = "Student Information";
            // 
            // lblStudentId
            // 
            lblStudentId.Location = new Point(20, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(100, 23);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(126, 27);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(190, 23);
            txtStudentId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 3;
            // 
            // lblSurname
            // 
            lblSurname.Location = new Point(20, 90);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(100, 23);
            lblSurname.TabIndex = 4;
            lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(126, 87);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(190, 23);
            txtSurname.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 120);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 23);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(126, 117);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(190, 23);
            txtAge.TabIndex = 7;
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(20, 150);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(100, 23);
            lblCourse.TabIndex = 8;
            lblCourse.Text = "Course:";
            // 
            // cmbCourse
            // 
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.Location = new Point(126, 147);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(261, 23);
            cmbCourse.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(66, 194);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(243, 156, 18);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(156, 194);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(246, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblTotalStudents);
            grpSummary.Controls.Add(lblAverageAge);
            grpSummary.Location = new Point(12, 13);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(759, 67);
            grpSummary.TabIndex = 1;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Location = new Point(260, 29);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(112, 23);
            lblTotalStudents.TabIndex = 0;
            // 
            // lblAverageAge
            // 
            lblAverageAge.Location = new Point(378, 29);
            lblAverageAge.Name = "lblAverageAge";
            lblAverageAge.Size = new Size(112, 23);
            lblAverageAge.TabIndex = 1;
            // 
            // grpTable
            // 
            grpTable.Controls.Add(txtFilter);
            grpTable.Controls.Add(cmbFilter);
            grpTable.Controls.Add(btnApplyFilter);
            grpTable.Controls.Add(dgvStudents);
            grpTable.Location = new Point(12, 90);
            grpTable.Name = "grpTable";
            grpTable.Size = new Size(759, 267);
            grpTable.TabIndex = 2;
            grpTable.TabStop = false;
            grpTable.Text = "Table";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(20, 30);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Search Name and Surname";
            txtFilter.Size = new Size(180, 23);
            txtFilter.TabIndex = 0;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Location = new Point(206, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(261, 23);
            cmbFilter.TabIndex = 1;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.FromArgb(52, 152, 219);
            btnApplyFilter.Cursor = Cursors.Hand;
            btnApplyFilter.FlatAppearance.BorderSize = 0;
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApplyFilter.ForeColor = Color.White;
            btnApplyFilter.Location = new Point(473, 30);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(90, 23);
            btnApplyFilter.TabIndex = 2;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = false;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.LightGray;
            dgvStudents.GridColor = SystemColors.ActiveBorder;
            dgvStudents.Location = new Point(20, 61);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(720, 190);
            dgvStudents.TabIndex = 3;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(532, 44);
            label1.Name = "label1";
            label1.Size = new Size(274, 25);
            label1.TabIndex = 4;
            label1.Text = "Student Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpSummary);
            groupBox1.Controls.Add(grpTable);
            groupBox1.Location = new Point(422, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 367);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1215, 591);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(grpStudentInfo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management System";
            Load += Form1_Load;
            grpStudentInfo.ResumeLayout(false);
            grpStudentInfo.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpTable.ResumeLayout(false);
            grpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpStudentInfo;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblName;
        private TextBox txtName;
        private Label lblSurname;
        private TextBox txtSurname;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox grpSummary;
        private Label lblTotalStudents;
        private Label lblAverageAge;
        private GroupBox grpTable;
        private TextBox txtFilter;
        private ComboBox cmbFilter;
        private Button btnApplyFilter;
        private DataGridView dgvStudents;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
    }
}
