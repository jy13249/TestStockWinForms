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
            label2.Text = TestPythonWithIronPython();
            
        }

        public string TestPythonWithIronPython()
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            ScriptSource source = engine.CreateScriptSourceFromString("testscript");
            string result = source.Execute(scope);
            return result;
        }

        private void TestPythonWithProcess()
        {
            string filename = "testscript.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("python.exe", filename)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true
            };

            p.Start();
            label2.Text = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

    }
}
