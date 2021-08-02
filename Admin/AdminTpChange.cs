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
    public partial class AdminTpChange : UIForm
    {
        public AdminTpChange()
        {
            InitializeComponent();
        }

        private void AdminTpChange_Load(object sender, EventArgs e)
        {

        }

        private void AdminTpChangeBu_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            admintelephonechange();

        }

        private void admintelephonechange()
        {
            Dao dao = new Dao();
            string sql = String.Format("UPDATE Administrator SET Telephone='{0}' WHERE Id='{1}'", AdTpCgNewTp.Text.Trim(),Data.AdID);
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
            if(AdTpCgNewTp.Text.Trim().Length!=11)
            {
                MessageBox.Show("请输入正确格式的联系方式");
                return false;
            }
            return true;
        }
    }
}
