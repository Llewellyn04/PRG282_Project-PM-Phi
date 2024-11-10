using PRG281_Project.Business;
using PRG281_Project.Data;
using PRG281_Project.Models;

namespace PRG281_Project
{
    public partial class Form1 : Form
    {
        private readonly StudentManager _studentManager;

        public Form1()
        {
            InitializeComponent();
            _studentManager = new StudentManager(new FileDataAccess());
            LoadStudents();
            SetupComboBox();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Add hover effects for all buttons
            SetupButtonHoverEffects(btnAdd, Color.FromArgb(46, 204, 113), Color.FromArgb(39, 174, 96));
            SetupButtonHoverEffects(btnUpdate, Color.FromArgb(243, 156, 18), Color.FromArgb(211, 84, 0));
            SetupButtonHoverEffects(btnDelete, Color.FromArgb(231, 76, 60), Color.FromArgb(192, 57, 43));
            SetupButtonHoverEffects(btnApplyFilter, Color.FromArgb(52, 152, 219), Color.FromArgb(41, 128, 185));
        }

        private void SetupButtonHoverEffects(Button button, Color defaultColor, Color hoverColor)
        {
            button.MouseEnter += (s, e) =>
            {
                button.BackColor = hoverColor;
            };

            button.MouseLeave += (s, e) =>
            {
                button.BackColor = defaultColor;
            };
        }

        private void SetupComboBox()
        {
            cmbCourse.Items.AddRange(new string[] {
                "Bachelor of Computing",
                "Bachelor of Information Technology",
                "Part-Time Bachelor of Information Technology",
                "Diploma in Information Technology",
                "Diploma for Deaf Students",
                "National Certificate: IT (Systems Development)",
                "Certificate: IT (Database Development)"
            });

            // Add the same courses to the filter combo box
            cmbFilter.Items.Add("All Courses");
            cmbFilter.Items.AddRange(new string[] {
                "Bachelor of Computing",
                "Bachelor of Information Technology",
                "Part-Time Bachelor of Information Technology",
                "Diploma in Information Technology",
                "Diploma for Deaf Students",
                "National Certificate: IT (Systems Development)",
                "Certificate: IT (Database Development)"
            });
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadStudents()
        {
            try
            {
                dgvStudents.DataSource = _studentManager.GetAllStudents();
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummary()
        {
            var students = _studentManager.GetAllStudents();
            lblTotalStudents.Text = $"Total Students: {students.Count}";
            lblAverageAge.Text = $"Average Age: {(students.Any() ? students.Average(s => s.Age).ToString("F2") : "0")}";
            _studentManager.GenerateSummary();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student(
                    int.Parse(txtStudentId.Text),
                    txtName.Text,
                    txtSurname.Text,
                    int.Parse(txtAge.Text),
                    cmbCourse.Text
                );

                _studentManager.AddStudent(student);
                LoadStudents();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
            txtStudentId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            cmbCourse.SelectedIndex = -1;
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                var student = (Student)dgvStudents.CurrentRow.DataBoundItem;
                txtStudentId.Text = student.StudentId.ToString();
                txtName.Text = student.Name;
                txtSurname.Text = student.Surname;
                txtAge.Text = student.Age.ToString();
                cmbCourse.Text = student.Course;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var allStudents = _studentManager.GetAllStudents();
                var filteredStudents = allStudents;

            
                if (!string.IsNullOrWhiteSpace(txtFilter.Text))
                {
                    string searchTerm = txtFilter.Text.ToLower();
                    filteredStudents = filteredStudents.Where(s =>
                        s.Name.ToLower().Contains(searchTerm) ||
                        s.Surname.ToLower().Contains(searchTerm) ||
                        s.StudentId.ToString().Contains(searchTerm)

                    ).ToList();
                }

            
                if (cmbFilter.SelectedItem!.ToString() != "All Courses")
                {
                    string selectedCourse = cmbFilter.SelectedItem.ToString()!;
                    filteredStudents = filteredStudents.Where(s => s.Course == selectedCourse).ToList();
                }

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = filteredStudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}