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
    public partial class EmployeeSerch : UIForm
    {
        public AdminMain adminman;
        public EmployeeSerch(AdminMain value)
        {
            InitializeComponent();
            adminman = value;
        }
        public EmployeeSerch()
        {
            InitializeComponent();
        }

        private void EmployeeSerch_Load(object sender, EventArgs e)
        {
            EmShCmBx.SelectedIndex = 0;
        }

        private void EmSerchBu_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string shsql;
            if (EmSerchItem.Text.Trim().Length == 0)
            {
                MessageBox.Show("搜索框不能为空");
                return;
            }
            switch(EmShCmBx.SelectedIndex)
            {
                case 0:
                    if (EmSerchItem.Text.Trim().Length != 6)
                    {
                        MessageBox.Show("请输入正确格式的工号");
                        return;
                    }
                    else
                    {
                        shsql = String.Format("SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,Employee.BirthDate,Employee.TelePhone,Department.DpName,Job.JobName FROM Employee LEFT JOIN Job ON Job.JobID=Employee.JobID LEFT JOIN Department ON Department.DpID=Job.DpID WHERE Employee.LoginID = '{0}'", EmSerchItem.Text);
                    }
                    break;
                case 1:
                    shsql = String.Format("SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,Employee.BirthDate,Employee.TelePhone,Department.DpName,Job.JobName FROM Employee LEFT JOIN Job ON Job.JobID=Employee.JobID LEFT JOIN Department ON Department.DpID=Job.DpID WHERE Employee.LoginName LIKE '%{0}%'", EmSerchItem.Text);
                    break;
                case 2:
                    shsql = String.Format("SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,Employee.BirthDate,Employee.TelePhone,Department.DpName,Job.JobName FROM Employee LEFT JOIN Job ON Job.JobID=Employee.JobID LEFT JOIN Department ON Department.DpID=Job.DpID WHERE Department.DpName LIKE '%{0}%'", EmSerchItem.Text);
                    break;
                case 3:
                    shsql = String.Format("SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,Employee.BirthDate,Employee.TelePhone,Department.DpName,Job.JobName FROM Employee LEFT JOIN Job ON Job.JobID=Employee.JobID LEFT JOIN Department ON Department.DpID=Job.DpID WHERE Job.JobName LIKE '%{0}%'", EmSerchItem.Text);
                    break;
                default:
                    shsql = "";
                    MessageBox.Show("发生异常请重试");
                    this.Close();
                    break;
            }
            adminman.MyDataGridView.Rows.Clear();
            IDataReader dc = dao.read(shsql);
            DateTime dt;
            if (dc.Read())
            {
                do
                {
                    dt = Convert.ToDateTime(dc["BirthDate"]);
                    adminman.MyDataGridView.Rows.Add(dc["LoginID"].ToString(), dc["LoginName"].ToString(), dc["Sex"].ToString(), dt.ToString("yyyy-MM-dd"), dc["TelePhone"].ToString(), dc["DpName"].ToString(), dc["JobName"].ToString());
                } while (dc.Read());
            }
            dc.Close();
            dao.DaoClose();
            MessageBox.Show("搜索成功");
            this.Close();
        }
    }
}
