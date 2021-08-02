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

namespace SalaryManagement.Admin.Job
{
    public partial class JobEdit : UIForm
    {
        string ID="";
        string NaMe = "";
        int type = 0;
        public JobEdit(string dpid)
        {
            InitializeComponent();
            ID = dpid;
            type = 1;
        }
        public JobEdit(string dpid, string dpname,string salary)
        {
            InitializeComponent();
            ID = dpid;
            NaMe = JobAdName.Text = dpname;
            JobAdSalary.Text = salary;
            this.Text = NaMe;
            JobAddBu.Text = "修改";
            type = 2;
        }


        private void JobMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 创建/修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JobAddBu_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    if (!CheckInput()) return;
                    jobadd();
                    break;
                case 2:
                    if (!CheckInput()) return;
                    jobedit();
                    break;
                default:
                    MessageBox.Show("数据异常请重试");
                    break;
            }
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        private void jobedit()
        {
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Job SET JobName='{0}',Salary='{1}' WHERE JobName='{2}' AND DpID='{3}'",JobAdName.Text.Trim().ToString(),JobAdSalary.Text.Trim().ToString(),NaMe,ID);
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
        /// 创建方法
        /// </summary>
        private void jobadd()
        {
            Dao dao = new Dao();
            string sql = String.Format("INSERT INTO Job (JobName,Salary,DpID) VALUES ('{0}','{1}','{2}') ",JobAdName.Text.Trim().ToString(),JobAdSalary.Text.Trim().ToString(),ID);
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("创建成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("创建失败");
            }
        }

        /// <summary>
        /// 输入检查控件
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (JobAdName.Text.Trim().Length == 0)
            {
                MessageBox.Show("职位名不能为空");
                return false;
            }
            Dao dao = new Dao();
            string sql = String.Format("SELECT JobID FROM Job WHERE DpID='{0}' AND JobName = '{1}'", ID,JobAdName.Text.Trim());
            IDataReader dc = dao.read(sql);
            if (dc.Read() && JobAdName.Text.Trim()!=NaMe)
            {
                MessageBox.Show("该职位已被创建");
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
