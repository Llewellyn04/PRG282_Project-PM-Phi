using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace PRG282_Project
{
    public partial class Form1 : Form
    {
        private const string StudentFilePath = "students.txt";
        private const string SummaryFilePath = "summary.txt";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wait for the loading screen to finish
            while (Application.OpenForms.OfType<LoadingScreen>().Any())
            {
                Application.DoEvents();
            }

            PopulateFilterCourseComboBox();
            LoadStudents();
            UpdateSummary();
        }

        private void PopulateFilterCourseComboBox()
        {
            cmbFilterCourse.Items.Clear();
            cmbFilterCourse.Items.Add("All Courses");
            cmbFilterCourse.Items.AddRange(cmbCourse.Items.Cast<object>().ToArray());
            cmbFilterCourse.SelectedIndex = 0;
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string studentData = $"{txtStudentId.Text},{txtName.Text},{txtSurname.Text},{txtAge.Text},{cmbCourse.SelectedItem}";
                File.AppendAllText(StudentFilePath, studentData + Environment.NewLine);
                LoadStudents(txtSearch.Text.Trim(), cmbFilterCourse.SelectedItem?.ToString() ?? "All Courses");
                UpdateSummary();
                MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear input fields after successfully adding a student
                ClearInputFields();
            }
        }

        private bool ValidateInput()
        {
            //remove return true;
            return true;
        }

        private void ClearInputFields()
        {
            txtStudentId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            cmbCourse.SelectedIndex = -1;
        }

        private void LoadStudents(string searchTerm = "", string courseFilter = "All Courses")
        {
            if (File.Exists(StudentFilePath))
            {
                var lines = File.ReadAllLines(StudentFilePath);
                var validStudents = new List<string>();
                var invalidLines = new List<string>();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5 && int.TryParse(parts[3], out _))
                    {
                        validStudents.Add(line);
                    }
                    else
                    {
                        invalidLines.Add(line);
                    }
                }

                if (invalidLines.Any())
                {
                    File.WriteAllLines(StudentFilePath, validStudents);
                    MessageBox.Show($"Found and removed {invalidLines.Count} invalid entries from the file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                var filteredStudents = validStudents.Select(line =>
                {
                    var parts = line.Split(',');
                    return new
                    {
                        StudentId = parts[0],
                        Name = parts[1],
                        Surname = parts[2],
                        Age = parts[3],
                        Course = parts[4]
                    };
                })
                .Where(s => (s.StudentId + s.Name + s.Surname).ToLower().Contains(searchTerm.ToLower()))
                .Where(s => courseFilter == "All Courses" || s.Course == courseFilter)
                .ToList();

                dgvStudents.DataSource = filteredStudents;
            }
        }

        private void DgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dgvStudents.SelectedRows[0];
                txtStudentId.Text = selectedRow.Cells["StudentId"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtSurname.Text = selectedRow.Cells["Surname"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                cmbCourse.SelectedItem = selectedRow.Cells["Course"].Value.ToString();
            }
        }

        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateSummary()
        {
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void grpSummary_Enter(object sender, EventArgs e)
        {

        }

        private void grpActions_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string courseFilter = cmbFilterCourse.SelectedItem?.ToString() ?? "All Courses";
            LoadStudents(searchTerm, courseFilter);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // You can implement real-time search here if needed
        }

        private void grpStudentInfo_Enter(object sender, EventArgs e)
        {
            // This method can be removed if not needed
        }
    }
}
