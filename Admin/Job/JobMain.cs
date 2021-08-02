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
    public partial class JobMain : UIForm
    {
        string DPID, DPNAME;
        public JobMain(string dpid,string dpname)
        {
            InitializeComponent();
            DPID = dpid;
            DPNAME = dpname;
        }

        private void JobMain_Load(object sender, EventArgs e)
        {
            CommonDefine.JobEmInfoShow(JbCmOfEmInfo,DPID,DPNAME);
        }
    }
}
