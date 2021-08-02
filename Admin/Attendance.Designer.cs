
namespace SalaryManagement.Admin
{
    partial class Attendance
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
            this.AttdaceEm = new Sunny.UI.UIComboBox();
            this.AttdaceDate = new Sunny.UI.UIDatePicker();
            this.AttdaceAt = new Sunny.UI.UITextBox();
            this.AttdaceOver = new Sunny.UI.UITextBox();
            this.AttdaceButton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // AttdaceEm
            // 
            this.AttdaceEm.FillColor = System.Drawing.Color.White;
            this.AttdaceEm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AttdaceEm.Location = new System.Drawing.Point(260, 63);
            this.AttdaceEm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AttdaceEm.MinimumSize = new System.Drawing.Size(63, 0);
            this.AttdaceEm.Name = "AttdaceEm";
            this.AttdaceEm.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.AttdaceEm.Size = new System.Drawing.Size(150, 29);
            this.AttdaceEm.TabIndex = 0;
            this.AttdaceEm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttdaceDate
            // 
            this.AttdaceDate.DateFormat = "yyyy-MM";
            this.AttdaceDate.FillColor = System.Drawing.Color.White;
            this.AttdaceDate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AttdaceDate.Location = new System.Drawing.Point(260, 124);
            this.AttdaceDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AttdaceDate.MaxLength = 7;
            this.AttdaceDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.AttdaceDate.Name = "AttdaceDate";
            this.AttdaceDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.AttdaceDate.Size = new System.Drawing.Size(150, 29);
            this.AttdaceDate.SymbolDropDown = 61555;
            this.AttdaceDate.SymbolNormal = 61555;
            this.AttdaceDate.TabIndex = 1;
            this.AttdaceDate.TagString = "2021-06";
            this.AttdaceDate.Text = "2021-06";
            this.AttdaceDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttdaceDate.Value = new System.DateTime(2021, 6, 21, 23, 47, 21, 601);
            // 
            // AttdaceAt
            // 
            this.AttdaceAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AttdaceAt.FillColor = System.Drawing.Color.White;
            this.AttdaceAt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AttdaceAt.Location = new System.Drawing.Point(260, 203);
            this.AttdaceAt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AttdaceAt.Maximum = 2147483647D;
            this.AttdaceAt.Minimum = -2147483648D;
            this.AttdaceAt.MinimumSize = new System.Drawing.Size(1, 1);
            this.AttdaceAt.Name = "AttdaceAt";
            this.AttdaceAt.Padding = new System.Windows.Forms.Padding(5);
            this.AttdaceAt.Size = new System.Drawing.Size(150, 29);
            this.AttdaceAt.TabIndex = 2;
            this.AttdaceAt.Text = "0";
            this.AttdaceAt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttdaceAt.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // AttdaceOver
            // 
            this.AttdaceOver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AttdaceOver.FillColor = System.Drawing.Color.White;
            this.AttdaceOver.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AttdaceOver.Location = new System.Drawing.Point(260, 287);
            this.AttdaceOver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AttdaceOver.Maximum = 2147483647D;
            this.AttdaceOver.Minimum = -2147483648D;
            this.AttdaceOver.MinimumSize = new System.Drawing.Size(1, 1);
            this.AttdaceOver.Name = "AttdaceOver";
            this.AttdaceOver.Padding = new System.Windows.Forms.Padding(5);
            this.AttdaceOver.Size = new System.Drawing.Size(150, 29);
            this.AttdaceOver.TabIndex = 3;
            this.AttdaceOver.Text = "0";
            this.AttdaceOver.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttdaceOver.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // AttdaceButton
            // 
            this.AttdaceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttdaceButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AttdaceButton.Location = new System.Drawing.Point(543, 287);
            this.AttdaceButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.AttdaceButton.Name = "AttdaceButton";
            this.AttdaceButton.Size = new System.Drawing.Size(100, 35);
            this.AttdaceButton.TabIndex = 4;
            this.AttdaceButton.Text = "创建";
            this.AttdaceButton.Click += new System.EventHandler(this.AttdaceButton_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AttdaceButton);
            this.Controls.Add(this.AttdaceOver);
            this.Controls.Add(this.AttdaceAt);
            this.Controls.Add(this.AttdaceDate);
            this.Controls.Add(this.AttdaceEm);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox AttdaceEm;
        private Sunny.UI.UIDatePicker AttdaceDate;
        private Sunny.UI.UITextBox AttdaceAt;
        private Sunny.UI.UITextBox AttdaceOver;
        private Sunny.UI.UIButton AttdaceButton;
    }
}