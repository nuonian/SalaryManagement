using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryManagement.Common;
using Sunny.UI;

namespace SalaryManagement.Admin.Department
{
    public partial class DepartmentAdd : UIForm
    {
        string ID = "";
        string NaMe = "";
        int type = 0;
        public DepartmentAdd()
        {
            InitializeComponent();
            type = 1;
        }
        public DepartmentAdd(string id, string name, string allowance, string telephone)
        {
            InitializeComponent();
            ID = id;
            type = 2;
            this.Text = name;
            NaMe=DpAdName.Text = name;
            DpAdTelephone.Text = telephone;
            DpAdAllowance.Text = allowance;
            DpAdButton.Text = "修改";
        }
        private void DepartmentAdd_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 部门创建事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DpAdButton_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    if (!CheckInput()) return;
                    dpadd();
                    break;
                case 2:
                    if (!CheckInput()) return;
                    dpedit();
                    break;
                default:
                    MessageBox.Show("发生错误请重试");
                    break;
            }            
        }
        /// <summary>
        /// 部门修改方法
        /// </summary>
        /// <param name="id"></param>
        private void dpedit()
        {
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Department SET DpName='{0}',EpAllowance='{1}',TelePhone='{2}' WHERE DpID='{3}'", DpAdName.Text.Trim().ToString(), DpAdAllowance.Text.Trim().ToString(), DpAdTelephone.Text.Trim().ToString(), ID);
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        /// <summary>
        /// 部门创建方法
        /// </summary>
        private void dpadd()
        {
            Dao dao = new Dao();
            string sql = String.Format("INSERT INTO Department (DpName,EpAllowance,TelePhone) VALUES ('{0}','{1}','{2}')",DpAdName.Text.Trim().ToString(),DpAdAllowance.Text.Trim().ToString(),DpAdTelephone.Text.Trim().ToString());
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("成功创建：" + DpAdName.Text.Trim().ToString());
                dao.DaoClose();
                this.Close();
            }
            else
            {
                MessageBox.Show("创建失败");
            }
            dao.DaoClose();
        }

        /// <summary>
        /// 输入检查控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (DpAdNameTt.Text.Trim().Length == 0)
            {
                MessageBox.Show("部门名称不能为空");
                return false;
            }
            if (DpAdTelephone.Text.Trim().Length != 11)
            {
                MessageBox.Show("请输入正确格式的办公室电话");
                return false;
            }
            Dao dao = new Dao();
            string sql = String.Format("SELECT * FROM Department WHERE DpName='{0}'", DpAdName.Text.Trim().ToString());
            IDataReader dc = dao.read(sql);
            if (dc.Read()&& DpAdName.Text.Trim()!=NaMe)
            {
                MessageBox.Show("该部门已被创建");
                dc.Close();
                dao.DaoClose();
                return false;
            }
            dc.Close();
            dao.DaoClose();
            return true;
        }
    }
}
