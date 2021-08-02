
namespace SalaryManagement.Admin
{
    partial class EmInfoEdit
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
            this.EmEdIDTt = new Sunny.UI.UILabel();
            this.EmEdID = new Sunny.UI.UILabel();
            this.EmEdNameTt = new Sunny.UI.UILabel();
            this.EmEdSexTt = new Sunny.UI.UILabel();
            this.EmEdBirthDayTt = new Sunny.UI.UILabel();
            this.EmEdTelephoneTt = new Sunny.UI.UILabel();
            this.EmEdBu = new Sunny.UI.UIButton();
            this.EmEdSexMale = new Sunny.UI.UIRadioButton();
            this.EmEdSexFamale = new Sunny.UI.UIRadioButton();
            this.EmEdName = new Sunny.UI.UITextBox();
            this.EmEdBirthDay = new Sunny.UI.UIDatePicker();
            this.EmEdTelephone = new Sunny.UI.UITextBox();
            this.EmAddJob = new Sunny.UI.UIComboBox();
            this.EmAddJobTt = new Sunny.UI.UILabel();
            this.EmAddDpTt = new Sunny.UI.UILabel();
            this.EmAddDp = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // EmEdIDTt
            // 
            this.EmEdIDTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdIDTt.Location = new System.Drawing.Point(84, 82);
            this.EmEdIDTt.Name = "EmEdIDTt";
            this.EmEdIDTt.Size = new System.Drawing.Size(55, 23);
            this.EmEdIDTt.TabIndex = 0;
            this.EmEdIDTt.Text = "工号:";
            this.EmEdIDTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdID
            // 
            this.EmEdID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdID.Location = new System.Drawing.Point(174, 82);
            this.EmEdID.Name = "EmEdID";
            this.EmEdID.Size = new System.Drawing.Size(141, 23);
            this.EmEdID.TabIndex = 1;
            this.EmEdID.Text = "工号";
            this.EmEdID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdNameTt
            // 
            this.EmEdNameTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdNameTt.Location = new System.Drawing.Point(84, 116);
            this.EmEdNameTt.Name = "EmEdNameTt";
            this.EmEdNameTt.Size = new System.Drawing.Size(100, 23);
            this.EmEdNameTt.TabIndex = 2;
            this.EmEdNameTt.Text = "姓名：";
            this.EmEdNameTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdSexTt
            // 
            this.EmEdSexTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdSexTt.Location = new System.Drawing.Point(84, 152);
            this.EmEdSexTt.Name = "EmEdSexTt";
            this.EmEdSexTt.Size = new System.Drawing.Size(100, 23);
            this.EmEdSexTt.TabIndex = 3;
            this.EmEdSexTt.Text = "性别：";
            this.EmEdSexTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdBirthDayTt
            // 
            this.EmEdBirthDayTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdBirthDayTt.Location = new System.Drawing.Point(84, 195);
            this.EmEdBirthDayTt.Name = "EmEdBirthDayTt";
            this.EmEdBirthDayTt.Size = new System.Drawing.Size(100, 23);
            this.EmEdBirthDayTt.TabIndex = 4;
            this.EmEdBirthDayTt.Text = "出生日期：";
            this.EmEdBirthDayTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdTelephoneTt
            // 
            this.EmEdTelephoneTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdTelephoneTt.Location = new System.Drawing.Point(84, 233);
            this.EmEdTelephoneTt.Name = "EmEdTelephoneTt";
            this.EmEdTelephoneTt.Size = new System.Drawing.Size(100, 23);
            this.EmEdTelephoneTt.TabIndex = 5;
            this.EmEdTelephoneTt.Text = "联系方式：";
            this.EmEdTelephoneTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdBu
            // 
            this.EmEdBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmEdBu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdBu.Location = new System.Drawing.Point(158, 412);
            this.EmEdBu.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmEdBu.Name = "EmEdBu";
            this.EmEdBu.Size = new System.Drawing.Size(100, 35);
            this.EmEdBu.TabIndex = 6;
            this.EmEdBu.Text = "修改";
            this.EmEdBu.Click += new System.EventHandler(this.EmEdBu_Click);
            // 
            // EmEdSexMale
            // 
            this.EmEdSexMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmEdSexMale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdSexMale.Location = new System.Drawing.Point(178, 146);
            this.EmEdSexMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmEdSexMale.Name = "EmEdSexMale";
            this.EmEdSexMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.EmEdSexMale.Size = new System.Drawing.Size(58, 29);
            this.EmEdSexMale.TabIndex = 7;
            this.EmEdSexMale.Text = "男";
            // 
            // EmEdSexFamale
            // 
            this.EmEdSexFamale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmEdSexFamale.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdSexFamale.Location = new System.Drawing.Point(270, 146);
            this.EmEdSexFamale.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmEdSexFamale.Name = "EmEdSexFamale";
            this.EmEdSexFamale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.EmEdSexFamale.Size = new System.Drawing.Size(58, 29);
            this.EmEdSexFamale.TabIndex = 8;
            this.EmEdSexFamale.Text = "女";
            // 
            // EmEdName
            // 
            this.EmEdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmEdName.FillColor = System.Drawing.Color.White;
            this.EmEdName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdName.Location = new System.Drawing.Point(178, 116);
            this.EmEdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmEdName.Maximum = 2147483647D;
            this.EmEdName.Minimum = -2147483648D;
            this.EmEdName.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmEdName.Name = "EmEdName";
            this.EmEdName.Padding = new System.Windows.Forms.Padding(5);
            this.EmEdName.Size = new System.Drawing.Size(150, 29);
            this.EmEdName.TabIndex = 9;
            this.EmEdName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmEdBirthDay
            // 
            this.EmEdBirthDay.FillColor = System.Drawing.Color.White;
            this.EmEdBirthDay.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdBirthDay.Location = new System.Drawing.Point(178, 189);
            this.EmEdBirthDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmEdBirthDay.MaxLength = 10;
            this.EmEdBirthDay.MinimumSize = new System.Drawing.Size(63, 0);
            this.EmEdBirthDay.Name = "EmEdBirthDay";
            this.EmEdBirthDay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EmEdBirthDay.Size = new System.Drawing.Size(150, 29);
            this.EmEdBirthDay.SymbolDropDown = 61555;
            this.EmEdBirthDay.SymbolNormal = 61555;
            this.EmEdBirthDay.TabIndex = 10;
            this.EmEdBirthDay.Text = "2021-06-17";
            this.EmEdBirthDay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmEdBirthDay.Value = new System.DateTime(2021, 6, 17, 19, 43, 23, 500);
            // 
            // EmEdTelephone
            // 
            this.EmEdTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmEdTelephone.FillColor = System.Drawing.Color.White;
            this.EmEdTelephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmEdTelephone.Location = new System.Drawing.Point(178, 233);
            this.EmEdTelephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmEdTelephone.Maximum = 2147483647D;
            this.EmEdTelephone.Minimum = -2147483648D;
            this.EmEdTelephone.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmEdTelephone.Name = "EmEdTelephone";
            this.EmEdTelephone.Padding = new System.Windows.Forms.Padding(5);
            this.EmEdTelephone.Size = new System.Drawing.Size(150, 29);
            this.EmEdTelephone.TabIndex = 11;
            this.EmEdTelephone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmAddJob
            // 
            this.EmAddJob.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.EmAddJob.FillColor = System.Drawing.Color.White;
            this.EmAddJob.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmAddJob.Location = new System.Drawing.Point(178, 339);
            this.EmAddJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmAddJob.MinimumSize = new System.Drawing.Size(63, 0);
            this.EmAddJob.Name = "EmAddJob";
            this.EmAddJob.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EmAddJob.Size = new System.Drawing.Size(150, 29);
            this.EmAddJob.TabIndex = 18;
            this.EmAddJob.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmAddJob.ButtonClick += new System.EventHandler(this.EmAddJob_ButtonClick);
            // 
            // EmAddJobTt
            // 
            this.EmAddJobTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmAddJobTt.Location = new System.Drawing.Point(84, 339);
            this.EmAddJobTt.Name = "EmAddJobTt";
            this.EmAddJobTt.Size = new System.Drawing.Size(100, 23);
            this.EmAddJobTt.TabIndex = 17;
            this.EmAddJobTt.Text = "职位：";
            this.EmAddJobTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmAddDpTt
            // 
            this.EmAddDpTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmAddDpTt.Location = new System.Drawing.Point(84, 284);
            this.EmAddDpTt.Name = "EmAddDpTt";
            this.EmAddDpTt.Size = new System.Drawing.Size(65, 23);
            this.EmAddDpTt.TabIndex = 16;
            this.EmAddDpTt.Text = "部门：";
            this.EmAddDpTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmAddDp
            // 
            this.EmAddDp.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.EmAddDp.FillColor = System.Drawing.Color.White;
            this.EmAddDp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmAddDp.Location = new System.Drawing.Point(178, 278);
            this.EmAddDp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmAddDp.MinimumSize = new System.Drawing.Size(63, 0);
            this.EmAddDp.Name = "EmAddDp";
            this.EmAddDp.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EmAddDp.Size = new System.Drawing.Size(150, 29);
            this.EmAddDp.TabIndex = 15;
            this.EmAddDp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmAddDp.SelectedValueChanged += new System.EventHandler(this.EmAddDp_SelectedValueChanged);
            // 
            // EmInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 493);
            this.Controls.Add(this.EmAddJob);
            this.Controls.Add(this.EmAddJobTt);
            this.Controls.Add(this.EmAddDpTt);
            this.Controls.Add(this.EmAddDp);
            this.Controls.Add(this.EmEdTelephone);
            this.Controls.Add(this.EmEdBirthDay);
            this.Controls.Add(this.EmEdName);
            this.Controls.Add(this.EmEdSexFamale);
            this.Controls.Add(this.EmEdSexMale);
            this.Controls.Add(this.EmEdBu);
            this.Controls.Add(this.EmEdTelephoneTt);
            this.Controls.Add(this.EmEdBirthDayTt);
            this.Controls.Add(this.EmEdSexTt);
            this.Controls.Add(this.EmEdNameTt);
            this.Controls.Add(this.EmEdID);
            this.Controls.Add(this.EmEdIDTt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmInfoEdit";
            this.Text = "员工信息编辑";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel EmEdIDTt;
        private Sunny.UI.UILabel EmEdID;
        private Sunny.UI.UILabel EmEdNameTt;
        private Sunny.UI.UILabel EmEdSexTt;
        private Sunny.UI.UILabel EmEdBirthDayTt;
        private Sunny.UI.UILabel EmEdTelephoneTt;
        private Sunny.UI.UIButton EmEdBu;
        private Sunny.UI.UIRadioButton EmEdSexMale;
        private Sunny.UI.UIRadioButton EmEdSexFamale;
        private Sunny.UI.UITextBox EmEdName;
        private Sunny.UI.UIDatePicker EmEdBirthDay;
        private Sunny.UI.UITextBox EmEdTelephone;
        private Sunny.UI.UIComboBox EmAddJob;
        private Sunny.UI.UILabel EmAddJobTt;
        private Sunny.UI.UILabel EmAddDpTt;
        private Sunny.UI.UIComboBox EmAddDp;
    }
}