using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryManagement.Admin;
using SalaryManagement.Common;
using SalaryManagement.User;
using Sunny.UI;

namespace SalaryManagement
{
    public partial class Login : UIForm
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBu_Click(object sender, EventArgs e)
        {
            Data.IsSuper = "";
            Data.AdID = "";
            if (!CheckInput()) return;
            loginit();
        }
        /// <summary>
        /// 登录方法
        /// </summary>
        private void loginit()
        {
            Dao dao = new Dao();
            string sql;
            if (LoginIsUser.Checked == true)
            {
                sql = String.Format("SELECT * FROM Employee WHERE LoginID='{0}' AND LoginPW='{1}'", LoginID.Text, CommonDefine.GetMD5Hash(LoginPW.Text));
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["LoginID"].ToString();
                    Data.UName = dc["LoginName"].ToString();
                    MessageBox.Show("登录成功");
                    UserMain usermain = new UserMain();
                    this.Hide();
                    usermain.ShowDialog();
                    this.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            if (LoginIsAdmin.Checked == true)
            {
                sql = String.Format("SELECT * FROM Administrator WHERE LoginID='{0}' AND LoginPW='{1}'", LoginID.Text, CommonDefine.GetMD5Hash(LoginPW.Text));
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["LoginID"].ToString();
                    Data.UName = dc["LoginName"].ToString();
                    Data.AdID = dc["Id"].ToString();
                    Data.IsSuper = dc["IsSupper"].ToString();
                    MessageBox.Show("登录成功");
                    AdminMain adminmain = new AdminMain();
                    this.Hide();
                    adminmain.ShowDialog();
                    this.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
        }

        #region 输入验证
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if ((LoginID.Text.Trim().Length == 0) | (LoginPW.Text.Trim().Length == 0))
            {
                MessageBox.Show("账号和密码不能为空");
                return false;
            }
            return true;
        }
        #endregion

        private void LoginExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢您的使用");
            Application.Exit();
        }
    }
}
