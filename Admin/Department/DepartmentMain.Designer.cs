
namespace SalaryManagement.Admin.Department
{
    partial class DepartmentMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DpMnCm = new Sunny.UI.UITabControlMenu();
            this.DpMnCmInfo = new System.Windows.Forms.TabPage();
            this.DpCmOfJobInfo = new Sunny.UI.UIDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightCleckofJob = new Sunny.UI.UIContextMenuStrip();
            this.RcOfJbRefurbish = new System.Windows.Forms.ToolStripMenuItem();
            this.RcOfJbAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.RcOfJbEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.RcOfJbAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.RcOfJbDelect = new System.Windows.Forms.ToolStripMenuItem();
            this.DpMnCm.SuspendLayout();
            this.DpMnCmInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DpCmOfJobInfo)).BeginInit();
            this.RightCleckofJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // DpMnCm
            // 
            this.DpMnCm.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.DpMnCm.Controls.Add(this.DpMnCmInfo);
            this.DpMnCm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DpMnCm.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.DpMnCm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DpMnCm.ItemSize = new System.Drawing.Size(40, 200);
            this.DpMnCm.Location = new System.Drawing.Point(0, 35);
            this.DpMnCm.Multiline = true;
            this.DpMnCm.Name = "DpMnCm";
            this.DpMnCm.SelectedIndex = 0;
            this.DpMnCm.Size = new System.Drawing.Size(1021, 618);
            this.DpMnCm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.DpMnCm.TabIndex = 0;
            // 
            // DpMnCmInfo
            // 
            this.DpMnCmInfo.Controls.Add(this.DpCmOfJobInfo);
            this.DpMnCmInfo.Location = new System.Drawing.Point(201, 0);
            this.DpMnCmInfo.Name = "DpMnCmInfo";
            this.DpMnCmInfo.Size = new System.Drawing.Size(820, 618);
            this.DpMnCmInfo.TabIndex = 1;
            this.DpMnCmInfo.Text = "信息";
            this.DpMnCmInfo.UseVisualStyleBackColor = true;
            // 
            // DpCmOfJobInfo
            // 
            this.DpCmOfJobInfo.AllowUserToAddRows = false;
            this.DpCmOfJobInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DpCmOfJobInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DpCmOfJobInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DpCmOfJobInfo.BackgroundColor = System.Drawing.Color.White;
            this.DpCmOfJobInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DpCmOfJobInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DpCmOfJobInfo.ColumnHeadersHeight = 32;
            this.DpCmOfJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DpCmOfJobInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.DpCmOfJobInfo.ContextMenuStrip = this.RightCleckofJob;
            this.DpCmOfJobInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DpCmOfJobInfo.EnableHeadersVisualStyles = false;
            this.DpCmOfJobInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DpCmOfJobInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DpCmOfJobInfo.Location = new System.Drawing.Point(0, 0);
            this.DpCmOfJobInfo.MultiSelect = false;
            this.DpCmOfJobInfo.Name = "DpCmOfJobInfo";
            this.DpCmOfJobInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DpCmOfJobInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DpCmOfJobInfo.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DpCmOfJobInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DpCmOfJobInfo.RowTemplate.Height = 29;
            this.DpCmOfJobInfo.SelectedIndex = -1;
            this.DpCmOfJobInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DpCmOfJobInfo.ShowGridLine = true;
            this.DpCmOfJobInfo.Size = new System.Drawing.Size(820, 618);
            this.DpCmOfJobInfo.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "职位";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "基础薪资";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "人数";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // RightCleckofJob
            // 
            this.RightCleckofJob.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RightCleckofJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RcOfJbRefurbish,
            this.RcOfJbAdd,
            this.RcOfJbEdit,
            this.RcOfJbAbout,
            this.RcOfJbDelect});
            this.RightCleckofJob.Name = "RightCleckofJob";
            this.RightCleckofJob.Size = new System.Drawing.Size(113, 134);
            // 
            // RcOfJbRefurbish
            // 
            this.RcOfJbRefurbish.Name = "RcOfJbRefurbish";
            this.RcOfJbRefurbish.Size = new System.Drawing.Size(112, 26);
            this.RcOfJbRefurbish.Text = "刷新";
            this.RcOfJbRefurbish.Click += new System.EventHandler(this.RcOfJbRefurbish_Click);
            // 
            // RcOfJbAdd
            // 
            this.RcOfJbAdd.Name = "RcOfJbAdd";
            this.RcOfJbAdd.Size = new System.Drawing.Size(112, 26);
            this.RcOfJbAdd.Text = "创建";
            this.RcOfJbAdd.Click += new System.EventHandler(this.RcOfJbAdd_Click);
            // 
            // RcOfJbEdit
            // 
            this.RcOfJbEdit.Name = "RcOfJbEdit";
            this.RcOfJbEdit.Size = new System.Drawing.Size(112, 26);
            this.RcOfJbEdit.Text = "编辑";
            this.RcOfJbEdit.Click += new System.EventHandler(this.RcOfJbEdit_Click);
            // 
            // RcOfJbAbout
            // 
            this.RcOfJbAbout.Name = "RcOfJbAbout";
            this.RcOfJbAbout.Size = new System.Drawing.Size(112, 26);
            this.RcOfJbAbout.Text = "详情";
            this.RcOfJbAbout.Click += new System.EventHandler(this.RcOfJbAbout_Click);
            // 
            // RcOfJbDelect
            // 
            this.RcOfJbDelect.Name = "RcOfJbDelect";
            this.RcOfJbDelect.Size = new System.Drawing.Size(112, 26);
            this.RcOfJbDelect.Text = "删除";
            this.RcOfJbDelect.Click += new System.EventHandler(this.RcOfJbDelect_Click);
            // 
            // DepartmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 653);
            this.Controls.Add(this.DpMnCm);
            this.Name = "DepartmentMain";
            this.Text = "部门详细信息";
            this.Load += new System.EventHandler(this.DepartmentMain_Load);
            this.DpMnCm.ResumeLayout(false);
            this.DpMnCmInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DpCmOfJobInfo)).EndInit();
            this.RightCleckofJob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu DpMnCm;
        private System.Windows.Forms.TabPage DpMnCmInfo;
        private Sunny.UI.UIDataGridView DpCmOfJobInfo;
        private Sunny.UI.UIContextMenuStrip RightCleckofJob;
        private System.Windows.Forms.ToolStripMenuItem RcOfJbAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem RcOfJbRefurbish;
        private System.Windows.Forms.ToolStripMenuItem RcOfJbEdit;
        private System.Windows.Forms.ToolStripMenuItem RcOfJbDelect;
        private System.Windows.Forms.ToolStripMenuItem RcOfJbAbout;
    }
}