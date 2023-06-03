using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace hengiotatmay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e)
        {
            string time = textBox1.Text;
            
            if (time.Length == 0)
            {
                MessageBox.Show("Enter the number of seconds");
            } else
            {
                int timeNumber = int.Parse(time, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
                timeNumber *= 60;
                Process Pro = new Process();
                Pro.StartInfo.UseShellExecute = false;
                Pro.StartInfo.RedirectStandardInput = true;
                Pro.StartInfo.RedirectStandardOutput = true;
                Pro.StartInfo.FileName = @"cmd.exe";
                Pro.StartInfo.CreateNoWindow = true;
                Pro.Start();
                Pro.StandardInput.WriteLine("shutdown -s -t "+ timeNumber);
                Pro.StandardInput.WriteLine("exit");
                MessageBox.Show("DONE!\n" + " Your computer will shutdown in " + timeNumber/60+ " minute");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process Pro = new Process();
            Pro.StartInfo.UseShellExecute = false;
            Pro.StartInfo.RedirectStandardInput = true;
            Pro.StartInfo.RedirectStandardOutput = true;
            Pro.StartInfo.FileName = @"cmd.exe";
            Pro.StartInfo.CreateNoWindow = true;
            Pro.Start();
            Pro.StandardInput.WriteLine("shutdown -a");
            Pro.StandardInput.WriteLine("exit");
            MessageBox.Show("Đã huỷ");
        }
    }
}

