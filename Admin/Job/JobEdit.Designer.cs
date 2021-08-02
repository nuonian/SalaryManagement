
namespace SalaryManagement.Admin.Job
{
    partial class JobEdit
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
            this.JobAdNameTt = new Sunny.UI.UILabel();
            this.JobSalaryTt = new Sunny.UI.UILabel();
            this.JobAdName = new Sunny.UI.UITextBox();
            this.JobAdSalary = new Sunny.UI.UITextBox();
            this.JobAddBu = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // JobAdNameTt
            // 
            this.JobAdNameTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.JobAdNameTt.Location = new System.Drawing.Point(69, 93);
            this.JobAdNameTt.Name = "JobAdNameTt";
            this.JobAdNameTt.Size = new System.Drawing.Size(100, 23);
            this.JobAdNameTt.TabIndex = 0;
            this.JobAdNameTt.Text = "职位名称：";
            this.JobAdNameTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobSalaryTt
            // 
            this.JobSalaryTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.JobSalaryTt.Location = new System.Drawing.Point(69, 156);
            this.JobSalaryTt.Name = "JobSalaryTt";
            this.JobSalaryTt.Size = new System.Drawing.Size(100, 23);
            this.JobSalaryTt.TabIndex = 1;
            this.JobSalaryTt.Text = "基础薪资：";
            this.JobSalaryTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobAdName
            // 
            this.JobAdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JobAdName.FillColor = System.Drawing.Color.White;
            this.JobAdName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.JobAdName.Location = new System.Drawing.Point(176, 93);
            this.JobAdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobAdName.Maximum = 2147483647D;
            this.JobAdName.Minimum = -2147483648D;
            this.JobAdName.MinimumSize = new System.Drawing.Size(1, 1);
            this.JobAdName.Name = "JobAdName";
            this.JobAdName.Padding = new System.Windows.Forms.Padding(5);
            this.JobAdName.Size = new System.Drawing.Size(150, 29);
            this.JobAdName.TabIndex = 2;
            this.JobAdName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobAdSalary
            // 
            this.JobAdSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JobAdSalary.FillColor = System.Drawing.Color.White;
            this.JobAdSalary.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.JobAdSalary.Location = new System.Drawing.Point(176, 150);
            this.JobAdSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobAdSalary.Maximum = 2147483647D;
            this.JobAdSalary.Minimum = -2147483648D;
            this.JobAdSalary.MinimumSize = new System.Drawing.Size(1, 1);
            this.JobAdSalary.Name = "JobAdSalary";
            this.JobAdSalary.Padding = new System.Windows.Forms.Padding(5);
            this.JobAdSalary.Size = new System.Drawing.Size(150, 29);
            this.JobAdSalary.TabIndex = 3;
            this.JobAdSalary.Text = "0.00";
            this.JobAdSalary.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.JobAdSalary.Type = Sunny.UI.UITextBox.UIEditType.Double;
            // 
            // JobAddBu
            // 
            this.JobAddBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobAddBu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.JobAddBu.Location = new System.Drawing.Point(176, 214);
            this.JobAddBu.MinimumSize = new System.Drawing.Size(1, 1);
            this.JobAddBu.Name = "JobAddBu";
            this.JobAddBu.Size = new System.Drawing.Size(100, 35);
            this.JobAddBu.TabIndex = 4;
            this.JobAddBu.Text = "创建";
            this.JobAddBu.Click += new System.EventHandler(this.JobAddBu_Click);
            // 
            // JobEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 298);
            this.Controls.Add(this.JobAddBu);
            this.Controls.Add(this.JobAdSalary);
            this.Controls.Add(this.JobAdName);
            this.Controls.Add(this.JobSalaryTt);
            this.Controls.Add(this.JobAdNameTt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobEdit";
            this.Text = "职位修改";
            this.Load += new System.EventHandler(this.JobMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel JobAdNameTt;
        private Sunny.UI.UILabel JobSalaryTt;
        private Sunny.UI.UITextBox JobAdName;
        private Sunny.UI.UITextBox JobAdSalary;
        private Sunny.UI.UIButton JobAddBu;
    }
}