
namespace SalaryManagement.Admin
{
    partial class AdminTpChange
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
            this.AdTpCgNewTp = new Sunny.UI.UITextBox();
            this.AdminTpChangeBu = new Sunny.UI.UIButton();
            this.AdTpCgNewTpTt = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // AdTpCgNewTp
            // 
            this.AdTpCgNewTp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdTpCgNewTp.FillColor = System.Drawing.Color.White;
            this.AdTpCgNewTp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AdTpCgNewTp.Location = new System.Drawing.Point(148, 79);
            this.AdTpCgNewTp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdTpCgNewTp.Maximum = 2147483647D;
            this.AdTpCgNewTp.Minimum = -2147483648D;
            this.AdTpCgNewTp.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdTpCgNewTp.Name = "AdTpCgNewTp";
            this.AdTpCgNewTp.Padding = new System.Windows.Forms.Padding(5);
            this.AdTpCgNewTp.Size = new System.Drawing.Size(193, 29);
            this.AdTpCgNewTp.TabIndex = 0;
            this.AdTpCgNewTp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminTpChangeBu
            // 
            this.AdminTpChangeBu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminTpChangeBu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AdminTpChangeBu.Location = new System.Drawing.Point(148, 131);
            this.AdminTpChangeBu.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdminTpChangeBu.Name = "AdminTpChangeBu";
            this.AdminTpChangeBu.Size = new System.Drawing.Size(100, 35);
            this.AdminTpChangeBu.TabIndex = 1;
            this.AdminTpChangeBu.Text = "修改";
            this.AdminTpChangeBu.Click += new System.EventHandler(this.AdminTpChangeBu_Click);
            // 
            // AdTpCgNewTpTt
            // 
            this.AdTpCgNewTpTt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AdTpCgNewTpTt.Location = new System.Drawing.Point(49, 79);
            this.AdTpCgNewTpTt.Name = "AdTpCgNewTpTt";
            this.AdTpCgNewTpTt.Size = new System.Drawing.Size(108, 23);
            this.AdTpCgNewTpTt.TabIndex = 2;
            this.AdTpCgNewTpTt.Text = "新联系方式：";
            this.AdTpCgNewTpTt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminTpChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 219);
            this.Controls.Add(this.AdTpCgNewTp);
            this.Controls.Add(this.AdTpCgNewTpTt);
            this.Controls.Add(this.AdminTpChangeBu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminTpChange";
            this.Text = "联系方式修改";
            this.Load += new System.EventHandler(this.AdminTpChange_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox AdTpCgNewTp;
        private Sunny.UI.UIButton AdminTpChangeBu;
        private Sunny.UI.UILabel AdTpCgNewTpTt;
    }
}