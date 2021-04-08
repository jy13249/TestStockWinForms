using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

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
            //string stockList = TestPythonWithProcess();
            //label2.Text = TestPythonWithProcess();
            string[] newStockList = TestPythonWithProcess();

            
        }

        public string[] TestPythonWithProcess()
        {
            ProcessStartInfo start = new ProcessStartInfo();
            var pythonPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "python.exe");
            start.FileName = pythonPath;
            start.Arguments = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "testscript.py");
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            using(Process process = Process.Start(start))
            {
                using(StreamReader reader = process.StandardOutput)
                {
                    
                    string[] result = reader.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    return result;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
