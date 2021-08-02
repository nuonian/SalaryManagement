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

namespace SalaryManagement.User
{
    public partial class UserPwChange : UIForm
    {
        public UserPwChange()
        {
            InitializeComponent();
        }

        private void UserPwChange_Load(object sender, EventArgs e)
        {

        }

        private void UserPwCgButton_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            userpdchange();
        }

        private void userpdchange()
        {
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Employee SET LoginPW='{0}' WHERE LoginID='{1}'",CommonDefine.GetMD5Hash(UserPwNew.Text.Trim()),Data.UID);
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("修改成功");
                dao.DaoClose();
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败请重试");
                dao.DaoClose();
            }
        }

        /// <summary>
        /// 输入检查控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (UserPwOld.Text.Trim().Length == 0)
            {
                MessageBox.Show("旧密码不能为空");
                return false;
            }
            if (UserPwNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("新密码不能为空");
                return false;
            }
            if (UserPwReNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("重复密码不能为空");
                return false;
            }
            if (UserPwReNew.Text != UserPwNew.Text)
            {
                MessageBox.Show("两次新密码不相同");
                return false;
            }
            if (UserPwNew.Text == UserPwOld.Text)
            {
                MessageBox.Show("新密码不能与旧密码相同");
                return false;
            }
            Dao dao = new Dao();
            string sql = String.Format("SELECT * FROM Employee WHERE LoginID='{0}' AND LoginPW='{1}'",Data.UID, CommonDefine.GetMD5Hash(UserPwOld.Text.Trim()));
            IDataReader dc = dao.read(sql);
            if (!dc.Read())
            {
                MessageBox.Show("旧密码错误");
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
