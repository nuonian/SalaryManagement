using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryManagement.Admin.Department;
using SalaryManagement.Common;
using SalaryManagement.User;
using Sunny.UI;

namespace SalaryManagement.Admin
{
    public partial class AdminMain : UIForm
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminMain_Load(object sender, EventArgs e)
        {
            this.Text = "欢迎管理员：" + Data.UName + "登录";
            CommonDefine.EmInfoShow(AdCmOfEmInfo);
            CommonDefine.AdInfoShow(AdCmOfAdInfo);
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        } 
        #endregion
        #region 员工右键菜单删除
        /// <summary>
        /// 员工右键菜单删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RCofEmDelect_Click(object sender, EventArgs e)
        {
            CommonDefine.EmInfoDelete(AdCmOfEmInfo);
            CommonDefine.EmInfoShow(AdCmOfEmInfo);
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        }
        #endregion
        #region 员工右键菜单添加
        /// <summary>
        /// 员工右键菜单添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RCofEmAdd_Click(object sender, EventArgs e)
        {
            EmployeeAdd employeeadd = new EmployeeAdd();
            employeeadd.ShowDialog();
            CommonDefine.EmInfoShow(AdCmOfEmInfo);
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        }
        #endregion
        #region 员工右键菜单编辑
        /// <summary>
        /// 员工右键菜单编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RCofEmEdit_Click(object sender, EventArgs e)
        {
            CommonDefine.EmInfoEdit(AdCmOfEmInfo);
            CommonDefine.EmInfoShow(MyDataGridView);
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        }
        #endregion
        #region 员工右键搜索菜单
        /// <summary>
        /// 员工右键搜索菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RCofEmSech_Click(object sender, EventArgs e)
        {
            EmployeeSerch employeeserch = new EmployeeSerch(this);
            employeeserch.ShowDialog();
        } 
        #endregion
        #region 跨窗口调用员工信息框
        /// <summary>
        /// 跨窗口调用员工信息框
        /// </summary>
        public UIDataGridView MyDataGridView
        {
            get
            {
                return AdCmOfEmInfo;
            }
            set
            {
                AdCmOfEmInfo = value;
            }
        }
        #endregion
        #region 右键菜单刷新功能
        /// <summary>
        /// 右键菜单刷新功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RCofEmRefurbish_Click(object sender, EventArgs e)
        {
            CommonDefine.EmInfoShow(AdCmOfEmInfo);
        }
        #endregion
        #region 员工右键菜单重置密码
        /// <summary>
        /// 员工右键菜单重置密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RCofEmPwReset_Click(object sender, EventArgs e)
        {
            CommonDefine.EmInfoPwReset(AdCmOfEmInfo);
        }
        #endregion
        #region 管理员创建
        /// <summary>
        /// 管理员创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdAdd_Click(object sender, EventArgs e)
        {
            if (Data.IsSuper == "0")
            {
                MessageBox.Show("只有超级管理员才可以增加管理员");
            }
            else
            {
                AdminAdd adminadd = new AdminAdd();
                adminadd.ShowDialog();
                CommonDefine.AdInfoShow(AdCmOfAdInfo);
            }
        }
        #endregion
        #region 管理员刷新
        /// <summary>
        /// 管理员刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdRefurbish_Click(object sender, EventArgs e)
        {
            CommonDefine.AdInfoShow(AdCmOfAdInfo);
        }
        #endregion
        #region 管理员编辑
        /// <summary>
        /// 管理员编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdEdit_Click(object sender, EventArgs e)
        {
            if (!CommonDefine.issuper(AdCmOfAdInfo, "编辑")) return;
            CommonDefine.AdInfoEdit(AdCmOfAdInfo);
            CommonDefine.AdInfoShow(AdCmOfAdInfo);
        }
        #endregion
        #region 管理员重置密码
        /// <summary>
        /// 管理员重置密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdReset_Click(object sender, EventArgs e)
        {
            if (!CommonDefine.issuper(AdCmOfAdInfo, "重置")) return;
            CommonDefine.AdInfoPwReset(AdCmOfAdInfo);
        }
        #endregion
        #region 删除管理员
        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdDelete_Click(object sender, EventArgs e)
        {
            if (!CommonDefine.issuper(AdCmOfAdInfo, "删除")) return;
            CommonDefine.AdInfoDelete(AdCmOfAdInfo);
        } 
        #endregion
        #region 提高管理员权限
        /// <summary>
        /// 提高管理员权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdLbup_Click(object sender, EventArgs e)
        {
            CommonDefine.AdInfoLabelUp(AdCmOfAdInfo);
        } 
        #endregion
        #region 降低管理员权限
        /// <summary>
        /// 降低管理员权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfAdlbdown_Click(object sender, EventArgs e)
        {
            CommonDefine.AdInfoLabelDown(AdCmOfAdInfo);
        }
        #endregion
        #region 部门右键刷新
        /// <summary>
        /// 部门右键刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfDpRefurbish_Click(object sender, EventArgs e)
        {
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        }
        #endregion
        #region 部门创建
        /// <summary>
        /// 部门创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfDpAdd_Click(object sender, EventArgs e)
        {
            if (Data.IsSuper == "0")
            {
                MessageBox.Show("只有超级管理员才能创建部门");
                return;
            }
            CommonDefine.DpInfoAdd();
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        }
        #endregion
        #region 删除部门
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfDpDelete_Click(object sender, EventArgs e)
        {
            if (Data.IsSuper == "0")
            {
                MessageBox.Show("只有超级管理员才能删除部门");
                return;
            }
            CommonDefine.DpInfoDelete(AdCmOfDpInfo);
            CommonDefine.DpInfoShow(AdCmOfDpInfo);
        }
        #endregion
        #region 部门详情
        /// <summary>
        /// 部门详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfDpMain_Click(object sender, EventArgs e)
        {
            CommonDefine.DpInfoMain(AdCmOfDpInfo);
        }
        #endregion
        #region 部门编辑
        /// <summary>
        /// 部门编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RcOfDpEdit_Click(object sender, EventArgs e)
        {
            CommonDefine.DpInfoEdit(AdCmOfDpInfo);
        }
        #endregion

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.ShowDialog();
        }
        private void RcofAdminPwChange_Click(object sender, EventArgs e)
        {
            AdminPwChange adminPwChange = new AdminPwChange();
            adminPwChange.ShowDialog();
        }

        private void RcofAdminTpChange_Click(object sender, EventArgs e)
        {
            AdminTpChange adminTpChange = new AdminTpChange();
            adminTpChange.ShowDialog();
        }
    }
}