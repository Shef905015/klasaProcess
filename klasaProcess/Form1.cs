using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace klasaProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("msedge.exe");
            startInfo.Arguments = "web2.ss-zcrnje-rovinj.skole.hr";
            Process.Start(startInfo);
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            Process.Start("msedge.exe");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }
    }
}
