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

namespace SalaryManagement.Admin.Department
{
    public partial class DepartmentMain : UIForm
    {
        string ID;
        public DepartmentMain(string id,string name)
        {
            InitializeComponent();
            ID = id;
            this.Text = name;
        }
        /// <summary>
        /// 职位窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentMain_Load(object sender, EventArgs e)
        {
            CommonDefine.JobInfoShow(DpCmOfJobInfo,ID);
        }
        /// <summary>
        /// 职位右键菜单创建事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfJbAdd_Click(object sender, EventArgs e)
        {
            CommonDefine.JbInfoAdd(ID);
            CommonDefine.JobInfoShow(DpCmOfJobInfo,ID);
        }
        /// <summary>
        /// 职位右键菜单刷新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfJbRefurbish_Click(object sender, EventArgs e)
        {
            CommonDefine.JobInfoShow(DpCmOfJobInfo,ID);
        }
        /// <summary>
        /// 职位右键菜单修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfJbEdit_Click(object sender, EventArgs e)
        {
            CommonDefine.JbInfoEdit(DpCmOfJobInfo,ID);
            CommonDefine.JobInfoShow(DpCmOfJobInfo,ID);
        }
        /// <summary>
        /// 职位右键菜单删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfJbDelect_Click(object sender, EventArgs e)
        {
            CommonDefine.JbInfoDelect(DpCmOfJobInfo,ID);
            CommonDefine.JobInfoShow(DpCmOfJobInfo, ID);
        }

        private void RcOfJbAbout_Click(object sender, EventArgs e)
        {
            CommonDefine.JobEmMain(DpCmOfJobInfo,ID);
            CommonDefine.JobInfoShow(DpCmOfJobInfo,ID);
        }
    }
}
