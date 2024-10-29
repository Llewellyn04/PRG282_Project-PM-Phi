using System;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class LoadingScreen : Form
    {
        private ProgressBar progressBar1;
        private Label lblStatus;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 38);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Loading...";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void UpdateProgress(int value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateProgress(value)));
                return;
            }
            
            if (progressBar1.Value != value)
            {
                progressBar1.Value = value;
                lblStatus.Text = $"Loading... {value}%";
                Application.DoEvents();
            }
        }
    }
}
