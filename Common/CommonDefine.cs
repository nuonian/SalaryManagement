using SalaryManagement.Admin;
using SalaryManagement.Admin.Administrator;
using SalaryManagement.Admin.Department;
using SalaryManagement.Admin.Job;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagement.Common
{
    class CommonDefine
    {
        #region 对字符串进行MD5加密
        /// <summary>
        /// 对字符串进行MD5加密
        /// </summary>
        /// <param name="sVal"></param>
        /// <returns></returns>
        public static string GetMD5Hash(string sVal)
        {
            MD5 mD5 = MD5.Create();
            byte[] bs = mD5.ComputeHash(Encoding.Default.GetBytes(sVal));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bs.Length; i++)
            {
                sb.Append(bs[i].ToString("x2"));
            }
            return sb.ToString();
        }
        #endregion
        #region 员工信息显示
        /// <summary>
        /// 员工信息显示
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void EmInfoShow(UIDataGridView MyDataGridView)
        {
            MyDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,Employee.BirthDate,Employee.TelePhone,Department.DpName,Job.JobName FROM Employee LEFT JOIN Job ON Job.JobID=Employee.JobID LEFT JOIN Department ON Department.DpID=Job.DpID";
            IDataReader dc = dao.read(sql);
            DateTime dt;
            while (dc.Read())
            {
                dt = Convert.ToDateTime(dc["BirthDate"]);
                MyDataGridView.Rows.Add(dc["LoginID"].ToString(), dc["LoginName"].ToString(), dc["Sex"].ToString(), dt.ToString("yyyy-MM-dd"), dc["TelePhone"].ToString(),dc["DpName"].ToString(),dc["JobName"].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        #endregion
        #region 员工信息删除
        /// <summary>
        /// 员工信息删除
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void EmInfoDelete(UIDataGridView MyDataGridView)
        {
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (id.Trim().Length == 0)
                {
                    MessageBox.Show("请先选择要删除的行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = MessageBox.Show("是否要删除：\n" + id + "\n" + name, "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    string sql = String.Format("DELETE FROM Employee WHERE LoginID = '{0}'", id);
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        EmInfoShow(MyDataGridView);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("发生故障", "故障", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 员工信息编辑
        /// <summary>
        /// 员工信息编辑
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void EmInfoEdit(UIDataGridView MyDataGridView)
        {
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string sex = MyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string birthday = MyDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string telephone = MyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string dpname = MyDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string jbname = MyDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                EmInfoEdit eminfoEdit = new EmInfoEdit(id, name, sex, birthday, telephone,dpname,jbname);
                eminfoEdit.ShowDialog();
            }
            catch
            {
                MessageBox.Show("出现异常请重试");
            }
        }
        #endregion
        #region 员工密码重置
        /// <summary>
        /// 员工密码重置
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void EmInfoPwReset(UIDataGridView MyDataGridView)
        {
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (id.Trim().Length == 0)
                {
                    MessageBox.Show("请先选择要重置的信息", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = MessageBox.Show("是否要重置：\n" + id + "\n" + name + "的密码", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    string sql = String.Format("UPDATE Employee SET LoginPW='{0}' WHERE LoginID='{1}'", GetMD5Hash(Data.DefaultPw), id);
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("重置成功,密码为初始密码" + Data.DefaultPw);
                        EmInfoShow(MyDataGridView);
                    }
                    else
                    {
                        MessageBox.Show("重置失败");
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("发生故障", "故障", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        } 
        #endregion
        #region 管理员信息显示
        /// <summary>
        /// 管理员信息显示
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void AdInfoShow(UIDataGridView MyDataGridView)
        {
            MyDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT * FROM Administrator";
            IDataReader dc = dao.read(sql);
            string issupper;
            while (dc.Read())
            {
                issupper = "普通管理员";
                if (dc["IsSupper"].ToString() != "0")
                {
                    issupper = "超级管理员";
                }
                MyDataGridView.Rows.Add(dc["Id"].ToString(),dc["LoginID"].ToString(), dc["LoginName"].ToString(),dc["Telephone"].ToString(),issupper);
            }
            dc.Close();
            dao.DaoClose();
        }
        #endregion
        #region 管理员信息编辑
        /// <summary>
        /// 管理员信息编辑
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void AdInfoEdit(UIDataGridView MyDataGridView)
        {
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string logid = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string telephone = MyDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string label = MyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                AdminInfoEdit admininfoedit = new AdminInfoEdit(id, logid, name, telephone, label);
                admininfoedit.ShowDialog();
            }
            catch
            {
                MessageBox.Show("出现异常请重试");
            }
        } 
        #endregion
        #region 管理员编辑权限判断
        /// <summary>
        /// 管理员编辑权限判断
        /// </summary>
        /// <param name="MyDataGridView"></param>
        /// <returns></returns>
        public static bool issuper(UIDataGridView MyDataGridView, string text)
        {
            string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string label = MyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (Data.IsSuper == "0")
            {
                MessageBox.Show("只有超级管理员可以" + text + "管理员");
                return false;
            }
            if (Data.AdID != "1" && label == "超级管理员")
            {
                MessageBox.Show("只有初始超管才能" + text + "超级管理员");
                return false;
            }
            return true;
        } 
        #endregion
        #region 管理员密码重置
        /// <summary>
        /// 管理员密码重置
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void AdInfoPwReset(UIDataGridView MyDataGridView)
        {
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string logid = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                if (id.Trim().Length == 0)
                {
                    MessageBox.Show("请先选择要重置的信息", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = MessageBox.Show("是否要重置：\n" + logid + "\n" + name + "的密码", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    string sql = String.Format("UPDATE Administrator SET LoginPW='{0}' WHERE Id='{1}'", GetMD5Hash(Data.DafaultAdPw), id);
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("重置成功,密码为初始密码" + Data.DafaultAdPw);
                        AdInfoShow(MyDataGridView);
                    }
                    else
                    {
                        MessageBox.Show("重置失败");
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("发生故障", "故障", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 管理员信息删除
        /// <summary>
        /// 管理员信息删除
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void AdInfoDelete(UIDataGridView MyDataGridView)
        {
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string logid = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                if (id.Trim().Length == 0)
                {
                    MessageBox.Show("请先选择要删除的行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (id.Trim() == "1")
                {
                    MessageBox.Show("无法删除初始超级管理员");
                    return;
                }
                DialogResult dr = MessageBox.Show("是否要删除：\n" + id + "\n" + name, "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    string sql = String.Format("DELETE FROM Administrator WHERE Id = '{0}'", id);
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        AdInfoShow(MyDataGridView);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("发生故障", "故障", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 提高管理员权限
        /// <summary>
        /// 提高管理员权限
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void AdInfoLabelUp(UIDataGridView MyDataGridView)
        {
            string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string label = MyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (id == "1")
            {
                MessageBox.Show("无法修改初始管理员权限");
                return;
            }
            if (Data.AdID != "1")
            {
                MessageBox.Show("只有初始超级管理员才能修改权限");
                return;
            }
            if (label == "超级管理员")
            {
                MessageBox.Show("该账号已为超级管理员无法提升权限");
                return;
            }
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Administrator SET IsSupper='1' WHERE Id = '{0}'", id);
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            AdInfoShow(MyDataGridView);
            dao.DaoClose();
        }
        #endregion
        #region 降低管理员权限
        /// <summary>
        /// 降低管理员权限
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void AdInfoLabelDown(UIDataGridView MyDataGridView)
        {
            string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string label = MyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            if (id == "1")
            {
                MessageBox.Show("无法修改初始管理员权限");
                return;
            }
            if (Data.AdID != "1")
            {
                MessageBox.Show("只有初始超级管理员才能修改权限");
                return;
            }
            if (label == "普通管理员")
            {
                MessageBox.Show("该账号已为普通管理员无法降低权限");
                return;
            }
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Administrator SET IsSupper='0' WHERE Id = '{0}'", id);
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            AdInfoShow(MyDataGridView);
            dao.DaoClose();
        }
        #endregion
        #region 部门信息显示
        /// <summary>
        /// 部门信息显示
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void DpInfoShow(UIDataGridView MyDataGridView)
        {
            MyDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = "SELECT Department.DpID,Department.DpName,Department.EpAllowance,Department.TelePhone,Employee.LoginName FROM Department LEFT JOIN Job ON Job.DpID = Department.DpID AND Job.JobName ='部门经理'LEFT JOIN Employee ON Employee.JobID = Job.JobID";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                string numbersql = String.Format("SELECT COUNT(Employee.JobID) number FROM Job LEFT JOIN Employee ON Job.JobID = Employee.JobID WHERE Job.DpID='{0}'", dc["DpID"].ToString());
                IDataReader numbdc = dao.read(numbersql);
                numbdc.Read();
                MyDataGridView.Rows.Add(dc["DpID"].ToString(), dc["DpName"].ToString(), dc["EpAllowance"].ToString(), dc["LoginName"].ToString(),dc["TelePhone"].ToString(), numbdc["number"].ToString());
                numbdc.Close();
            }
            dc.Close();
            dao.DaoClose();
        }
        #endregion
        #region 部门创建
        /// <summary>
        /// 部门创建
        /// </summary>
        public static void DpInfoAdd()
        {
            DepartmentAdd departmentadd = new DepartmentAdd();
            departmentadd.ShowDialog();
        }
        #endregion
        #region 删除部门
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void DpInfoDelete(UIDataGridView MyDataGridView)
        {
            if (Data.IsSuper == "0")
            {
                MessageBox.Show("只有超级管理员才能删除部门");
            }
            try
            {
                string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (id.Trim().Length == 0)
                {
                    MessageBox.Show("请先选择要删除的行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = MessageBox.Show("是否要删除:" + name, "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    string emsql = String.Format("UPDATE Employee SET JobID=NULL FROM Employee INNER JOIN Job ON Employee.JobID = Job.JobID INNER JOIN Department ON Job.DpID = Department.DpID WHERE Department.DpID='{0}'",id);
                    string jbsql = String.Format("DELETE FROM Job WHERE DpID = '{0}'",id);
                    string sql = String.Format("DELETE FROM Department WHERE DpID = '{0}'", id);
                    Dao dao = new Dao();
                    dao.Execute(emsql);
                    dao.Execute(jbsql);
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("发生故障", "故障", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 部门编辑
        /// <summary>
        /// 部门编辑
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void DpInfoEdit(UIDataGridView MyDataGridView)
        {
            if (Data.IsSuper == "0")
            {
                MessageBox.Show("只有超级管理员才能编辑部门");
                return;
            }
            string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string name = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string allowance = MyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string telephone = MyDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            DepartmentAdd departmentedit = new DepartmentAdd(id, name, allowance, telephone);
            departmentedit.ShowDialog();
            DpInfoShow(MyDataGridView);
        }
        #endregion
        #region 部门详情
        /// <summary>
        /// 部门详情
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void DpInfoMain(UIDataGridView MyDataGridView)
        {
            string id = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string name = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            DepartmentMain departmentmain = new DepartmentMain(id, name);
            departmentmain.ShowDialog();
            DpInfoShow(MyDataGridView);
        }
        #endregion
        #region 职位信息显示
        /// <summary>
        /// 职位信息显示
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void JobInfoShow(UIDataGridView MyDataGridView, string id)
        {
            MyDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = String.Format("SELECT JobID,JobName,Salary FROM Job WHERE DpID='{0}'", id);
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                Dao numbdao = new Dao();
                string numbsql = String.Format("SELECT COUNT(JobID) number FROM Employee WHERE JobID = '{0}'", dc["JobID"].ToString());
                IDataReader numbdc = numbdao.read(numbsql);
                numbdc.Read();
                MyDataGridView.Rows.Add(dc["JobName"].ToString(), dc["Salary"].ToString(), numbdc["number"].ToString());
                numbdc.Close();
                numbdao.DaoClose();
            }
            dc.Close();
            dao.DaoClose();
        }
        #endregion
        #region 职位创建
        /// <summary>
        /// 职位创建
        /// </summary>
        /// <param name="MyDataGridView"></param>
        public static void JbInfoAdd(string dpid)
        {
            JobEdit jobadd = new JobEdit(dpid);
            jobadd.ShowDialog();
        }
        #endregion
        #region 职位修改
        /// <summary>
        /// 职位修改
        /// </summary>
        /// <param name="MyDataGridView"></param>
        /// <param name="dpid"></param>
        public static void JbInfoEdit(UIDataGridView MyDataGridView, string dpid)
        {
            string name = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string salary = MyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            JobEdit jobedit = new JobEdit(dpid, name, salary);
            jobedit.ShowDialog();
        }
        public static void JbInfoDelect(UIDataGridView MyDataGridView, string dpid)
        {
            string name = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Dao dao = new Dao();
            string emsql = String.Format("UPDATE Employee SET JobID=NULL FROM Employee INNER JOIN Job ON Employee.JobID = Job.JobID INNER JOIN Department ON Job.DpID = Department.DpID WHERE Department.DpID='{0}' AND Job.JobName='{1}'", dpid, name);
            string sql = String.Format("DELETE FROM Job WHERE DpID='{0}' AND JobName='{1}'", dpid, name);
            dao.Execute(emsql);
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            dao.DaoClose();
        }
        #endregion
        public static void JobEmMain(UIDataGridView MyDataGridView,string dpid)
        {
            string name = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            JobMain jobmain = new JobMain(dpid,name);
            jobmain.ShowDialog();
            
        }
        public static void JobEmInfoShow(UIDataGridView MyDataGridView, string dpid, string dpname)
        {
            MyDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = String.Format("SELECT Employee.LoginID,Employee.LoginName,Employee.Sex,Employee.BirthDate,Employee.TelePhone FROM Employee INNER JOIN Job ON Employee.JobID = Job.JobID INNER JOIN Department ON Job.DpID = Department.DpID WHERE Department.DpID='{0}' AND Job.JobName='{1}'", dpid, dpname);
            IDataReader dc = dao.read(sql);
            DateTime dt;
            while (dc.Read())
            {
                dt = Convert.ToDateTime(dc["BirthDate"]);
                MyDataGridView.Rows.Add(dc["LoginID"].ToString(),dc["LoginName"].ToString(),dc["Sex"].ToString(),dt.ToString("yyyy-MM-dd"),dc["TelePhone"].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public static void Attendanceadd()
        {
            Attendance attendance = new Attendance();
            attendance.ShowDialog();
        }
        public static double TaxCount(double beforemoney)
        {
            double tax=0;
            if (beforemoney > 5000)
            {
                beforemoney -= 5000;
                if (beforemoney < 36000)
                {
                    tax = beforemoney * 0.03;
                }
                else
                {
                    tax += 1080;
                    if (beforemoney < 144000)
                    {
                        tax = (beforemoney - 36000) * 0.1;
                    }
                    else
                    {
                        tax += 10800;
                        if (beforemoney < 300000)
                        {
                            tax = (beforemoney - 144000) * 0.2;
                        }
                    }
                }
            } 
            return tax;
        }

        public static void PayrollShow(UIDataGridView MyDataGridView)
        {
            MyDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = String.Format("SELECT CONCAT(DATEPART(YEAR,Attendance.TimeOFAttendance),'-',DATENAME(mm,Attendance.TimeOFAttendance)) TimeOfAttendance,(Job.Salary/DATEDIFF(DD,TimeOFAttendance,DATEADD(Month,1,TimeOFAttendance))*Attendance.Attendanc)+60*Attendance.OverTime+Department.EpAllowance jbmoney,Department.EpAllowance DpSalary,Job.Salary JbSalary,Attendance.Attendanc,Attendance.OverTime FROM Attendance RIGHT JOIN Employee ON Employee.LoginID=Attendance.JobID LEFT JOIN Job ON Employee.JobID=Job.JobID LEFT JOIN Department ON Job.DpID=Department.DpID WHERE Employee.LoginID={0}",Data.UID);
            IDataReader dc = dao.read(sql);
            double fnmoney;
            double money;
            while (dc.Read())
            {
                money = dc["jbmoney"].ToString().ToDouble();
                fnmoney = money-TaxCount(money);
                MyDataGridView.Rows.Add(dc["TimeOfAttendance"].ToString(),fnmoney, money,TaxCount(money).ToString(), dc["JbSalary"].ToString(),dc["DpSalary"].ToString(),dc["Attendanc"].ToString(),dc["OverTime"].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
