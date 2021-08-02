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
    public partial class Attendance : UIForm
    {
        public Attendance()
        {
            InitializeComponent();
            Dao dao = new Dao();
            string sql = "SELECT LoginID FROM Employee";
            IDataReader dc = dao.read(sql);
            AttdaceEm.Items.Clear();
            while (dc.Read())
            {
                AttdaceEm.Items.Add(dc["LoginID"].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void AttdaceButton_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = String.Format("INSERT INTO Attendance (TimeOFAttendance,JobID,Attendanc,OverTime) VALUES ('{0}',{1},{2},{3})", AttdaceDate.Text+"-01",AttdaceEm.SelectedItem.ToString(),AttdaceAt.Text,AttdaceOver.Text);
            dao.Execute(sql);
        }
    }
}
