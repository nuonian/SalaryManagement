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

namespace SalaryManagement.Admin
{
    public partial class AdminAdd : UIForm
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {

        }

        private void AdAdButton_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            string issupper = "0";
            if (AdAdLabelIsSupper.Checked == true)
            {
                if (Data.AdID != "1")
                {
                    MessageBox.Show("只有初始超级管理员才可以创建超级管理员");
                    return;
                }
                issupper = "1";
            }
            adminadd(issupper);
        }

        private void adminadd(string issupper)
        {
            Dao dao =new Dao();
            string sql = String.Format("INSERT INTO Administrator (LoginID,LoginPW,LoginName,Telephone,IsSupper) VALUES ('{0}','{1}','{2}','{3}','{4}')",AdAdID.Text.Trim().ToString(),CommonDefine.GetMD5Hash(Data.DafaultAdPw),AdAdName.Text.Trim().ToString(),AdAdTelephone.Text.Trim().ToString(),issupper);
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("创建成功:\n账号：" + AdAdID.Text.Trim().ToString() + "\n密码：" + Data.DafaultAdPw);
                dao.DaoClose();
                this.Close();
            }
            else
            {
                MessageBox.Show("创建失败");
            }
            dao.DaoClose();
        }
        #region 输入验证控件
        /// <summary>
        /// 输入验证控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (AdAdID.Text.Trim().Length == 0)
            {
                MessageBox.Show("账号不能为空");
                return false;
            }
            if (AdAdName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return false;
            }
            if (AdAdTelephone.Text.Trim().Length != 11)
            {
                MessageBox.Show("请输入正确格式的联系方式");
                return false;
            }
            Dao dao = new Dao();
            string sql = String.Format("SELECT * FROM Administrator WHERE LoginID='{0}'", AdAdID.Text.Trim().ToString());
            IDataReader dc = dao.read(sql);
            if (dc.Read())
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
