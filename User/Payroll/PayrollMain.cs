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

namespace SalaryManagement.User.Payroll
{
    public partial class PayrollMain : UIForm
    {
        public PayrollMain()
        {
            InitializeComponent();
        }

        private void PayrollMain_Load(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = String.Format("SELECT DATEDIFF(DD,TimeOFAttendance,DATEADD(Month,1,TimeOFAttendance))-Attendance.Attendanc daycount,ISNULL(Attendance.OverTime,0) OverTime,(ISNULL(Job.Salary,0)/DATEDIFF(DD,TimeOFAttendance,DATEADD(Month,1,TimeOFAttendance))*ISNULL(Attendance.Attendanc,0))+60*ISNULL(Attendance.OverTime,0)+Department.EpAllowance jbmoney FROM Attendance RIGHT JOIN Employee ON Employee.LoginID=Attendance.JobID LEFT JOIN Job ON Employee.JobID=Job.JobID LEFT JOIN Department ON Job.DpID=Department.DpID WHERE Employee.LoginID='{0}' AND Attendance.TimeOFAttendance='{1}'", Data.UID, System.DateTime.Now.ToString("yyyy-MM")+"-01");
            IDataReader dc = dao.read(sql);
            dc.Read();
            double jbmoney= dc["jbmoney"].ToString().ToDouble();
            PyMnMoney.Text = jbmoney.ToString();
            if (dc["daycount"].ToString() == "0")
            {
                Attendance.Text = "满勤";
            }
            else
            {
                Attendance.Text = "缺勤" + dc["daycount"].ToString() + "天";
            }
            OverTime.Text = dc["OverTime"].ToString() + "次";
            double tax;
            tax = dc["jbmoney"].ToString().ToDouble();
            Tax.Text = CommonDefine.TaxCount(tax).ToString();
            double fnmoney = jbmoney - CommonDefine.TaxCount(tax);
            FnMnMoney.Text = fnmoney.ToString();
        }
    }
}
