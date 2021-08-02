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
using SalaryManagement.User.Payroll;
using Sunny.UI;

namespace SalaryManagement.User
{
    public partial class UserMain : UIForm
    {
        string ID;
        string TelePhone;
        public UserMain()
        {
            InitializeComponent();
            UserHomeID.Text = "工号：" + Data.UID;
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = String.Format("SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,DATEDIFF(YEAR,Employee.BirthDate,GETDATE()) age,Employee.TelePhone,Department.DpName,Job.JobName FROM Employee LEFT JOIN Job ON Job.JobID=Employee.JobID LEFT JOIN Department ON Department.DpID=Job.DpID WHERE Employee.LoginID='{0}'",Data.UID);
            IDataReader dc = dao.read(sql);
            dc.Read();
            this.Text = "欢迎员工："+Data.UID+"  "+Data.UName;
            ID = dc["LoginID"].ToString();
            TelePhone = dc["TelePhone"].ToString();
            UserHomeID.Text = "工号：    "+dc["LoginID"].ToString();
            UserHomeName.Text = "姓名：    " + dc["LoginName"].ToString();
            UserHomeSex.Text = "性别：    " + dc["Sex"].ToString();
            UserHomeAge.Text = "年龄：    " + dc["age"].ToString();
            UserHomeTelephone.Text = dc["TelePhone"].ToString();
            UserHomeDp.Text = "所属部门：" + dc["DpName"].ToString();
            UserHomeJob.Text = "职称：    " + dc["JobName"].ToString();
            CommonDefine.PayrollShow(PayrollHistory);
        }

        private void UserTelephoneChange_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            telephonechange();
        }

        private void telephonechange()
        {
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Employee SET TelePhone='{0}' WHERE LoginID='{1}'",UserHomeTelephone.Text.Trim(),ID);
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private bool CheckInput()
        {
            if (UserHomeTelephone.Text.Trim().Length != 11)
            {
                MessageBox.Show("请输入正确格式的电话号码");
                return false;
            }
            if (UserHomeTelephone.Text.Trim() == TelePhone)
            {
                MessageBox.Show("号码并未改变");
                return false;
            }
            return true;
        }

        private void UserPasswordChange_Click(object sender, EventArgs e)
        {
            UserPwChange userpwchange = new UserPwChange();
            userpwchange.ShowDialog();
        }

        private void CreatePayrollButton_Click(object sender, EventArgs e)
        {
            PayrollMain payrollMain = new PayrollMain();
            payrollMain.ShowDialog();
        }
    }
}
