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
    public partial class EmployeeAdd : UIForm
    {
        #region 窗体构造
        /// <summary>
        /// 窗体构造
        /// </summary>
        public EmployeeAdd()
        {
            InitializeComponent();
        } 
        #endregion
        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
            EmAddDp.Items.Clear();
            EmAddDp.Items.Add("");
            Dao dao = new Dao();
            string sql = "SELECT DpName FROM Department";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                EmAddDp.Items.Add(dc["DpName"].ToString());
            }
            dc.Close();
            dao.DaoClose();
        } 
        #endregion
        #region 添加事件
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmAddBu_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            employeeadd();

        } 
        #endregion
        #region 输入验证控件
        /// <summary>
        /// 输入验证控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (EmAddName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return false;
            }
            if (EmAddBd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择正确的出生日期");
            }
            if (EmAddTelephone.Text.Trim().Length != 11)
            {
                MessageBox.Show("请输入正确格式的电话号码");
                return false;
            }
            if (EmAddDp.Text.Trim().Length != 0 && EmAddJob.Text.Trim().Length == 0)
            {
                MessageBox.Show("请先选择职位");
                return false;
            }
            return true;
        } 
        #endregion
        #region 添加方法
        /// <summary>
        /// 添加方法
        /// </summary>
        private void employeeadd()
        {
            Dao dao = new Dao();
            string sex = "男";
            if (EmAddIsFamale.Checked == true)
            {
                sex = "女";
            }
            if (EmAddDp.Text.Trim().Length == 0)
            {
                string emaddsql = String.Format("INSERT INTO Employee (LoginName,LoginPW,Sex,BirthDate,TelePhone) VALUES ('{0}','{1}','{2}','{3}','{4}')", EmAddName.Text, CommonDefine.GetMD5Hash(Data.DefaultPw), sex, EmAddBd.Text, EmAddTelephone.Text);
                int n = dao.Execute(emaddsql);
                if (n > 0)
                {
                    string getid = "SELECT TOP 1 LoginID FROM Employee ORDER BY LoginID DESC";
                    IDataReader dc = dao.read(getid);
                    dc.Read();
                    MessageBox.Show("账户：" + dc[0].ToString() + "\n密码：" + Data.DefaultPw, "添加成功");
                    dc.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                string jbidsql = String.Format("SELECT Job.JobID FROM Job INNER JOIN Department ON JOb.DpID = Department.DpID WHERE Department.DpName = '{0}' AND Job.JobName='{1}'", EmAddDp.SelectedItem.ToString(), EmAddJob.SelectedItem.ToString());
                IDataReader dc = dao.read(jbidsql);
                if (dc.Read())
                {
                    string emaddjbsql = String.Format("INSERT INTO Employee (LoginName,LoginPW,Sex,BirthDate,TelePhone,JobID) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", EmAddName.Text, CommonDefine.GetMD5Hash(Data.DefaultPw), sex, EmAddBd.Text, EmAddTelephone.Text, dc["JobID"].ToString());
                    int m = dao.Execute(emaddjbsql);
                    if (m > 0)
                    {
                        string getid = "SELECT TOP 1 LoginID FROM Employee ORDER BY LoginID DESC";
                        IDataReader dcm = dao.read(getid);
                        dcm.Read();
                        MessageBox.Show("账户：" + dcm[0].ToString() + "\n密码：" + Data.DefaultPw, "添加成功");
                        dcm.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            dao.DaoClose();
            this.Close();
        }
        #endregion
        private void EmAddDp_ButtonClick(object sender, EventArgs e)
        {
            EmAddJob.Text = "";
        }

        private void EmAddJob_ButtonClick(object sender, EventArgs e)
        {
            if (EmAddDp.Text.Trim().Length == 0)
            {
                MessageBox.Show("请先选择部门");
            }
        }

        private void EmAddDp_SelectedValueChanged(object sender, EventArgs e)
        {
            EmAddJob.Items.Clear();
            Dao dao = new Dao();
            string sql = String.Format("SELECT Job.JobName FROM Job INNER JOIN Department ON Department.DpID = Job.DpID AND Department.DpName='{0}'", EmAddDp.SelectedItem.ToString());
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                EmAddJob.Items.Add(dc["JobName"].ToString());
            }
        }
    }
}
