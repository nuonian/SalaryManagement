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

namespace SalaryManagement.Admin.Administrator
{
    public partial class AdminInfoEdit : UIForm
    {
        string ID = "";
        string Label = "";
        string Id = "";
        public AdminInfoEdit()
        {
            InitializeComponent();
        }
        public AdminInfoEdit(string id, string logid, string name, string telephone, string label)
        {
            InitializeComponent();
            ID = id;
            Id=AdEdID.Text = logid;
            AdEdName.Text = name;
            AdEdTelephone.Text = telephone;
            Label = label;
            this.Text = "管理员编号" + ID+"  "+Label;
        }

        private void AdminInfoEdit_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 编辑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdEdButton_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            AdEditInfo();
        }
        /// <summary>
        /// 编辑方法
        /// </summary>
        private void AdEditInfo()
        {
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Administrator SET LoginID='{0}',LoginName='{1}',TelePhone = '{2}' WHERE Id = {3}", AdEdID.Text.Trim().ToString(), AdEdName.Text.Trim().ToString(), AdEdTelephone.Text.Trim().ToString(), ID);
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

        #region 输入验证控件
        /// <summary>
        /// 输入验证控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (AdEdID.Text.Trim().Length == 0)
            {
                MessageBox.Show("账号不能为空");
                return false;
            }
            if (AdEdName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return false;
            }
            if (AdEdTelephone.Text.Trim().Length != 11)
            {
                MessageBox.Show("请输入正确格式的电话号码");
                return false;
            }
            Dao dao = new Dao();
            string sql = String.Format("SELECT * FROM Administrator WHERE LoginID='{0}'", AdEdID.Text.Trim().ToString());
            IDataReader dc = dao.read(sql);
            if (dc.Read() && AdEdID.Text.Trim().ToString()!=Id)
            {
                MessageBox.Show("该账号已被使用");
                dc.Close();
                dao.DaoClose();
                return false;
            }
            dc.Close();
            dao.DaoClose();
            return true;
        }
        #endregion

    }
}
