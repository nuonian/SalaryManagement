
namespace SalaryManagement.Admin
{
    partial class EmployeeSerch
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
            this.EmSerchItem = new Sunny.UI.UITextBox();
            this.EmSerchBu = new Sunny.UI.UIButton();
            this.EmShCmBx = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // EmSerchItem
            // 
            this.EmSerchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmSerchItem.FillColor = System.Drawing.Color.White;
            this.EmSerchItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmSerchItem.Location = new System.Drawing.Point(79, 58);
            this.EmSerchItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmSerchItem.Maximum = 2147483647D;
            this.EmSerchItem.Minimum = -2147483648D;
            this.EmSerchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmSerchItem.Name = "EmSerchItem";
            this.EmSerchItem.Padding = new System.Windows.Forms.Padding(5);
            this.EmSerchItem.Size = new System.Drawing.Size(268, 29);
            this.EmSerchItem.TabIndex = 1;
            this.EmSerchItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmSerchBu
            // 
            this.EmSerchBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmSerchBu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmSerchBu.Location = new System.Drawing.Point(161, 134);
            this.EmSerchBu.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmSerchBu.Name = "EmSerchBu";
            this.EmSerchBu.Size = new System.Drawing.Size(100, 35);
            this.EmSerchBu.TabIndex = 4;
            this.EmSerchBu.Text = "搜索";
            this.EmSerchBu.Click += new System.EventHandler(this.EmSerchBu_Click);
            // 
            // EmShCmBx
            // 
            this.EmShCmBx.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.EmShCmBx.FillColor = System.Drawing.Color.White;
            this.EmShCmBx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EmShCmBx.Items.AddRange(new object[] {
            "工号",
            "姓名",
            "部门",
            "职称"});
            this.EmShCmBx.Location = new System.Drawing.Point(79, 97);
            this.EmShCmBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmShCmBx.MinimumSize = new System.Drawing.Size(63, 0);
            this.EmShCmBx.Name = "EmShCmBx";
            this.EmShCmBx.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EmShCmBx.Size = new System.Drawing.Size(268, 29);
            this.EmShCmBx.TabIndex = 5;
            this.EmShCmBx.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeeSerch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 196);
            this.Controls.Add(this.EmShCmBx);
            this.Controls.Add(this.EmSerchBu);
            this.Controls.Add(this.EmSerchItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeSerch";
            this.Text = "员工搜索";
            this.Load += new System.EventHandler(this.EmployeeSerch_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox EmSerchItem;
        private Sunny.UI.UIButton EmSerchBu;
        private Sunny.UI.UIComboBox EmShCmBx;
    }
}