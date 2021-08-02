
namespace SalaryManagement.User
{
    partial class UserMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserMnControlMenu = new Sunny.UI.UITabControlMenu();
            this.UserCmHome = new System.Windows.Forms.TabPage();
            this.CreatePayrollButton = new Sunny.UI.UIButton();
            this.UserHomeTelephone = new Sunny.UI.UITextBox();
            this.UserPasswordChange = new Sunny.UI.UIButton();
            this.UserTelephoneChange = new Sunny.UI.UIButton();
            this.UserHomeJob = new Sunny.UI.UILabel();
            this.UserHomeDp = new Sunny.UI.UILabel();
            this.UserHomeTelephoneTt = new Sunny.UI.UILabel();
            this.UserHomeAge = new Sunny.UI.UILabel();
            this.UserHomeSex = new Sunny.UI.UILabel();
            this.UserHomeName = new Sunny.UI.UILabel();
            this.UserHomeID = new Sunny.UI.UILabel();
            this.UserCmHistory = new System.Windows.Forms.TabPage();
            this.PayrollHistory = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMnControlMenu.SuspendLayout();
            this.UserCmHome.SuspendLayout();
            this.UserCmHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // UserMnControlMenu
            // 
            this.UserMnControlMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.UserMnControlMenu.Controls.Add(this.UserCmHome);
            this.UserMnControlMenu.Controls.Add(this.UserCmHistory);
            this.UserMnControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserMnControlMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.UserMnControlMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserMnControlMenu.ItemSize = new System.Drawing.Size(40, 200);
            this.UserMnControlMenu.Location = new System.Drawing.Point(0, 35);
            this.UserMnControlMenu.Multiline = true;
            this.UserMnControlMenu.Name = "UserMnControlMenu";
            this.UserMnControlMenu.SelectedIndex = 0;
            this.UserMnControlMenu.Size = new System.Drawing.Size(1230, 637);
            this.UserMnControlMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.UserMnControlMenu.TabIndex = 0;
            // 
            // UserCmHome
            // 
            this.UserCmHome.Controls.Add(this.CreatePayrollButton);
            this.UserCmHome.Controls.Add(this.UserHomeTelephone);
            this.UserCmHome.Controls.Add(this.UserPasswordChange);
            this.UserCmHome.Controls.Add(this.UserTelephoneChange);
            this.UserCmHome.Controls.Add(this.UserHomeJob);
            this.UserCmHome.Controls.Add(this.UserHomeDp);
            this.UserCmHome.Controls.Add(this.UserHomeTelephoneTt);
            this.UserCmHome.Controls.Add(this.UserHomeAge);
            this.UserCmHome.Controls.Add(this.UserHomeSex);
            this.UserCmHome.Controls.Add(this.UserHomeName);
            this.UserCmHome.Controls.Add(this.UserHomeID);
            this.UserCmHome.Location = new System.Drawing.Point(201, 0);
            this.UserCmHome.Name = "UserCmHome";
            this.UserCmHome.Size = new System.Drawing.Size(1029, 637);
            this.UserCmHome.TabIndex = 0;
            this.UserCmHome.Text = "主页";
            this.UserCmHome.UseVisualStyleBackColor = true;
            // 
            // CreatePayrollButton
            // 
            this.CreatePayrollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatePayrollButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CreatePayrollButton.Location = new System.Drawing.Point(548, 444);
            this.CreatePayrollButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.CreatePayrollButton.Name = "CreatePayrollButton";
            this.CreatePayrollButton.Size = new System.Drawing.Size(100, 35);
            this.CreatePayrollButton.TabIndex = 10;
            this.CreatePayrollButton.Text = "生成本月账单";
            this.CreatePayrollButton.Click += new System.EventHandler(this.CreatePayrollButton_Click);
            // 
            // UserHomeTelephone
            // 
            this.UserHomeTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserHomeTelephone.FillColor = System.Drawing.Color.White;
            this.UserHomeTelephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeTelephone.Location = new System.Drawing.Point(379, 284);
            this.UserHomeTelephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserHomeTelephone.Maximum = 2147483647D;
            this.UserHomeTelephone.Minimum = -2147483648D;
            this.UserHomeTelephone.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserHomeTelephone.Name = "UserHomeTelephone";
            this.UserHomeTelephone.Padding = new System.Windows.Forms.Padding(5);
            this.UserHomeTelephone.Size = new System.Drawing.Size(174, 29);
            this.UserHomeTelephone.TabIndex = 9;
            this.UserHomeTelephone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPasswordChange
            // 
            this.UserPasswordChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPasswordChange.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserPasswordChange.Location = new System.Drawing.Point(363, 444);
            this.UserPasswordChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserPasswordChange.Name = "UserPasswordChange";
            this.UserPasswordChange.Size = new System.Drawing.Size(100, 35);
            this.UserPasswordChange.TabIndex = 8;
            this.UserPasswordChange.Text = "修改密码";
            this.UserPasswordChange.Click += new System.EventHandler(this.UserPasswordChange_Click);
            // 
            // UserTelephoneChange
            // 
            this.UserTelephoneChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserTelephoneChange.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserTelephoneChange.Location = new System.Drawing.Point(560, 284);
            this.UserTelephoneChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserTelephoneChange.Name = "UserTelephoneChange";
            this.UserTelephoneChange.Size = new System.Drawing.Size(100, 35);
            this.UserTelephoneChange.TabIndex = 7;
            this.UserTelephoneChange.Text = "修改联系电话";
            this.UserTelephoneChange.Click += new System.EventHandler(this.UserTelephoneChange_Click);
            // 
            // UserHomeJob
            // 
            this.UserHomeJob.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeJob.Location = new System.Drawing.Point(298, 371);
            this.UserHomeJob.Name = "UserHomeJob";
            this.UserHomeJob.Size = new System.Drawing.Size(307, 23);
            this.UserHomeJob.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeJob.TabIndex = 6;
            this.UserHomeJob.Text = "职称：";
            this.UserHomeJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserHomeDp
            // 
            this.UserHomeDp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeDp.Location = new System.Drawing.Point(298, 330);
            this.UserHomeDp.Name = "UserHomeDp";
            this.UserHomeDp.Size = new System.Drawing.Size(307, 23);
            this.UserHomeDp.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeDp.TabIndex = 5;
            this.UserHomeDp.Text = "所属部门：";
            this.UserHomeDp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserHomeTelephoneTt
            // 
            this.UserHomeTelephoneTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeTelephoneTt.Location = new System.Drawing.Point(298, 290);
            this.UserHomeTelephoneTt.Name = "UserHomeTelephoneTt";
            this.UserHomeTelephoneTt.Size = new System.Drawing.Size(93, 23);
            this.UserHomeTelephoneTt.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeTelephoneTt.TabIndex = 4;
            this.UserHomeTelephoneTt.Text = "联系电话：";
            this.UserHomeTelephoneTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserHomeAge
            // 
            this.UserHomeAge.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeAge.Location = new System.Drawing.Point(298, 240);
            this.UserHomeAge.Name = "UserHomeAge";
            this.UserHomeAge.Size = new System.Drawing.Size(307, 23);
            this.UserHomeAge.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeAge.TabIndex = 3;
            this.UserHomeAge.Text = "年龄：";
            this.UserHomeAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserHomeSex
            // 
            this.UserHomeSex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeSex.Location = new System.Drawing.Point(298, 191);
            this.UserHomeSex.Name = "UserHomeSex";
            this.UserHomeSex.Size = new System.Drawing.Size(307, 23);
            this.UserHomeSex.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeSex.TabIndex = 2;
            this.UserHomeSex.Text = "性别：";
            this.UserHomeSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserHomeName
            // 
            this.UserHomeName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeName.Location = new System.Drawing.Point(298, 144);
            this.UserHomeName.Name = "UserHomeName";
            this.UserHomeName.Size = new System.Drawing.Size(307, 23);
            this.UserHomeName.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeName.TabIndex = 1;
            this.UserHomeName.Text = "姓名：";
            this.UserHomeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserHomeID
            // 
            this.UserHomeID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserHomeID.Location = new System.Drawing.Point(298, 96);
            this.UserHomeID.Name = "UserHomeID";
            this.UserHomeID.Size = new System.Drawing.Size(307, 23);
            this.UserHomeID.Style = Sunny.UI.UIStyle.Custom;
            this.UserHomeID.TabIndex = 0;
            this.UserHomeID.Text = "工号：";
            this.UserHomeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserCmHistory
            // 
            this.UserCmHistory.Controls.Add(this.PayrollHistory);
            this.UserCmHistory.Location = new System.Drawing.Point(201, 0);
            this.UserCmHistory.Name = "UserCmHistory";
            this.UserCmHistory.Size = new System.Drawing.Size(1029, 637);
            this.UserCmHistory.TabIndex = 1;
            this.UserCmHistory.Text = "历史账单";
            this.UserCmHistory.UseVisualStyleBackColor = true;
            // 
            // PayrollHistory
            // 
            this.PayrollHistory.AllowUserToAddRows = false;
            this.PayrollHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.PayrollHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PayrollHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PayrollHistory.BackgroundColor = System.Drawing.Color.White;
            this.PayrollHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PayrollHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PayrollHistory.ColumnHeadersHeight = 32;
            this.PayrollHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PayrollHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.PayrollHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollHistory.EnableHeadersVisualStyles = false;
            this.PayrollHistory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PayrollHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.PayrollHistory.Location = new System.Drawing.Point(0, 0);
            this.PayrollHistory.Name = "PayrollHistory";
            this.PayrollHistory.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PayrollHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.PayrollHistory.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.PayrollHistory.RowTemplate.Height = 29;
            this.PayrollHistory.SelectedIndex = -1;
            this.PayrollHistory.ShowGridLine = true;
            this.PayrollHistory.Size = new System.Drawing.Size(1029, 637);
            this.PayrollHistory.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "月份";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "最终工资";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "工资";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "个人所得税";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "职位基本工资";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "部门津贴";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "出勤情况";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "加班情况";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.UserMnControlMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.UserMnControlMenu.ResumeLayout(false);
            this.UserCmHome.ResumeLayout(false);
            this.UserCmHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PayrollHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu UserMnControlMenu;
        private System.Windows.Forms.TabPage UserCmHome;
        private System.Windows.Forms.TabPage UserCmHistory;
        private Sunny.UI.UILabel UserHomeID;
        private Sunny.UI.UILabel UserHomeJob;
        private Sunny.UI.UILabel UserHomeDp;
        private Sunny.UI.UILabel UserHomeTelephoneTt;
        private Sunny.UI.UILabel UserHomeAge;
        private Sunny.UI.UILabel UserHomeSex;
        private Sunny.UI.UILabel UserHomeName;
        private Sunny.UI.UIButton UserPasswordChange;
        private Sunny.UI.UIButton UserTelephoneChange;
        private Sunny.UI.UITextBox UserHomeTelephone;
        private Sunny.UI.UIButton CreatePayrollButton;
        private Sunny.UI.UIDataGridView PayrollHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}