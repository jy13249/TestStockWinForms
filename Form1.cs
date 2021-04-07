using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;

namespace TestStockWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            TestPython();
            
        }

        private void TestPython()
        {
            string filename = "testscript.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("python.exe", filename)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false
            };

            p.Start();
            label2.Text = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

    }
}
