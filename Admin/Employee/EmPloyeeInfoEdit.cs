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
    public partial class EmInfoEdit : UIForm
    {
        string ID = "";
        public EmInfoEdit()
        {
            InitializeComponent();
        }
        #region 参数传递
        /// <summary>
        /// 参数传递
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="birthday"></param>
        /// <param name="telephone"></param>
        public EmInfoEdit(string id, string name, string sex, string birthday, string telephone,string dpname,string jbname)
        {
            InitializeComponent();
            ID = EmEdID.Text = id;
            EmEdName.Text = name;
            EmEdSexMale.Checked = true;
            if (sex == "女")
            {
                EmEdSexFamale.Checked = true;
            }
            EmEdBirthDay.Text = birthday;
            EmEdTelephone.Text = telephone;
            itemset(dpname,jbname);
        }

        private void itemset(string dpname,string jbname)
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
            EmAddDp.SelectedIndex = EmAddDp.Items.IndexOf(dpname);
            EmAddJob.Items.Clear();
            string jbsql = String.Format("SELECT Job.JobName FROM Job INNER JOIN Department ON Department.DpID = Job.DpID AND Department.DpName='{0}'", dpname);
            IDataReader jbdc = dao.read(jbsql);
            while (jbdc.Read())
            {
                EmAddJob.Items.Add(jbdc["JobName"].ToString());
            }
            EmAddJob.SelectedIndex = EmAddJob.Items.IndexOf(jbname);
            jbdc.Close();
            dc.Close();
            dao.DaoClose();
        }

        #endregion
        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeEdit_Load(object sender, EventArgs e)
        {

        } 
        #endregion
        #region 编辑事件
        /// <summary>
        /// 编辑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmEdBu_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            employeeedit();
        }
        #endregion
        #region 输入验证控件
        /// <summary>
        /// 输入验证控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (EmEdName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return false;
            }
            if (EmEdBirthDay.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择正确的出生日期");
                return false;
            }
            if (EmEdTelephone.Text.Trim().Length != 11)
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
        #region 编辑方法
        /// <summary>
        /// 编辑方法
        /// </summary>
        private void employeeedit()
        {
            Dao dao = new Dao();
            string updatesex = "男";
            if (EmEdSexFamale.Checked == true)
            {
                updatesex = "女";
            }
            if (EmAddDp.Text.Trim().Length == 0)
            {
                string emedsql = String.Format("UPDATE Employee SET LoginName='{0}',Sex='{1}',BirthDate='{2}',TelePhone = '{3}' WHERE LoginID = {4}", EmEdName.Text, updatesex, EmEdBirthDay.Text, EmEdTelephone.Text, ID);
                int n = dao.Execute(emedsql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                string jbidsql = String.Format("SELECT Job.JobID FROM Job INNER JOIN Department ON JOb.DpID = Department.DpID WHERE Department.DpName = '{0}' AND Job.JobName='{1}'", EmAddDp.SelectedItem.ToString(), EmAddJob.SelectedItem.ToString());
                IDataReader dc = dao.read(jbidsql);
                if (dc.Read())
                {
                    string emedsql = String.Format("UPDATE Employee SET LoginName='{0}',Sex='{1}',BirthDate='{2}',TelePhone = '{3}',JobID='{4}' WHERE LoginID = '{5}'", EmEdName.Text, updatesex, EmEdBirthDay.Text, EmEdTelephone.Text,dc["JobID"].ToString(), ID);
                    int n = dao.Execute(emedsql);
                    if (n > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
                dc.Close();
            }
            dao.DaoClose();
        }
        #endregion

        private void EmAddJob_ButtonClick(object sender, EventArgs e)
        {
            if (EmAddDp.Text.Trim().Length == 0)
            {
                MessageBox.Show("请先选择部门");
            }
        }

        private void EmAddDp_SelectedValueChanged(object sender, EventArgs e)
        {
            EmAddJob.Text = "";
            EmAddJob.Items.Clear();
            Dao dao = new Dao();
            string sql = String.Format("SELECT Job.JobName FROM Job INNER JOIN Department ON Department.DpID = Job.DpID AND Department.DpName='{0}'", EmAddDp.SelectedItem.ToString());
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                EmAddJob.Items.Add(dc["JobName"].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
