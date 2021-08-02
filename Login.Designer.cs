
namespace SalaryManagement
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginID = new Sunny.UI.UITextBox();
            this.LoginPW = new Sunny.UI.UITextBox();
            this.LoginIsUser = new Sunny.UI.UIRadioButton();
            this.LoginIsAdmin = new Sunny.UI.UIRadioButton();
            this.LoginBu = new Sunny.UI.UIButton();
            this.LoginExit = new Sunny.UI.UIButton();
            this.LoginIDTt = new Sunny.UI.UILabel();
            this.LoginPWTt = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // LoginID
            // 
            this.LoginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginID.FillColor = System.Drawing.Color.White;
            this.LoginID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginID.Location = new System.Drawing.Point(228, 90);
            this.LoginID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginID.Maximum = 2147483647D;
            this.LoginID.Minimum = -2147483648D;
            this.LoginID.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginID.Name = "LoginID";
            this.LoginID.Padding = new System.Windows.Forms.Padding(5);
            this.LoginID.Size = new System.Drawing.Size(150, 29);
            this.LoginID.TabIndex = 0;
            this.LoginID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginPW
            // 
            this.LoginPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPW.FillColor = System.Drawing.Color.White;
            this.LoginPW.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginPW.Location = new System.Drawing.Point(228, 147);
            this.LoginPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginPW.Maximum = 2147483647D;
            this.LoginPW.Minimum = -2147483648D;
            this.LoginPW.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginPW.Name = "LoginPW";
            this.LoginPW.Padding = new System.Windows.Forms.Padding(5);
            this.LoginPW.PasswordChar = '*';
            this.LoginPW.Size = new System.Drawing.Size(150, 29);
            this.LoginPW.TabIndex = 1;
            this.LoginPW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginIsUser
            // 
            this.LoginIsUser.Checked = true;
            this.LoginIsUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginIsUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginIsUser.Location = new System.Drawing.Point(179, 203);
            this.LoginIsUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginIsUser.Name = "LoginIsUser";
            this.LoginIsUser.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.LoginIsUser.Size = new System.Drawing.Size(65, 29);
            this.LoginIsUser.TabIndex = 2;
            this.LoginIsUser.Text = "用户";
            // 
            // LoginIsAdmin
            // 
            this.LoginIsAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginIsAdmin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginIsAdmin.Location = new System.Drawing.Point(267, 203);
            this.LoginIsAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginIsAdmin.Name = "LoginIsAdmin";
            this.LoginIsAdmin.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.LoginIsAdmin.Size = new System.Drawing.Size(80, 29);
            this.LoginIsAdmin.TabIndex = 3;
            this.LoginIsAdmin.Text = "管理员";
            // 
            // LoginBu
            // 
            this.LoginBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginBu.Location = new System.Drawing.Point(163, 259);
            this.LoginBu.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginBu.Name = "LoginBu";
            this.LoginBu.Size = new System.Drawing.Size(100, 35);
            this.LoginBu.TabIndex = 4;
            this.LoginBu.Text = "登录";
            this.LoginBu.Click += new System.EventHandler(this.LoginBu_Click);
            // 
            // LoginExit
            // 
            this.LoginExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginExit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginExit.Location = new System.Drawing.Point(278, 259);
            this.LoginExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginExit.Name = "LoginExit";
            this.LoginExit.Size = new System.Drawing.Size(100, 35);
            this.LoginExit.TabIndex = 5;
            this.LoginExit.Text = "退出";
            this.LoginExit.Click += new System.EventHandler(this.LoginExit_Click);
            // 
            // LoginIDTt
            // 
            this.LoginIDTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginIDTt.Location = new System.Drawing.Point(159, 90);
            this.LoginIDTt.Name = "LoginIDTt";
            this.LoginIDTt.Size = new System.Drawing.Size(62, 23);
            this.LoginIDTt.TabIndex = 6;
            this.LoginIDTt.Text = "账号：";
            this.LoginIDTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginPWTt
            // 
            this.LoginPWTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginPWTt.Location = new System.Drawing.Point(159, 147);
            this.LoginPWTt.Name = "LoginPWTt";
            this.LoginPWTt.Size = new System.Drawing.Size(62, 23);
            this.LoginPWTt.TabIndex = 7;
            this.LoginPWTt.Text = "密码：";
            this.LoginPWTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 352);
            this.Controls.Add(this.LoginPWTt);
            this.Controls.Add(this.LoginIDTt);
            this.Controls.Add(this.LoginExit);
            this.Controls.Add(this.LoginBu);
            this.Controls.Add(this.LoginIsAdmin);
            this.Controls.Add(this.LoginIsUser);
            this.Controls.Add(this.LoginPW);
            this.Controls.Add(this.LoginID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowRadius = false;
            this.ShowRect = false;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox LoginID;
        private Sunny.UI.UITextBox LoginPW;
        private Sunny.UI.UIRadioButton LoginIsUser;
        private Sunny.UI.UIRadioButton LoginIsAdmin;
        private Sunny.UI.UIButton LoginBu;
        private Sunny.UI.UIButton LoginExit;
        private Sunny.UI.UILabel LoginIDTt;
        private Sunny.UI.UILabel LoginPWTt;
    }
}

