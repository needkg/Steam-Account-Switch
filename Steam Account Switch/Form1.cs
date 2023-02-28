using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Steam_Account_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            if (!checkBox2.Checked && !checkBox3.Checked)
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            if (!checkBox1.Checked && !checkBox3.Checked)
            {
                checkBox2.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                checkBox3.Checked = true;
            }
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
                string account = checkBox1.Text;
                editRegistry(account);
                restartSteam();
                this.Close();
            }
            if (checkBox2.Checked)
            {
                string account = checkBox2.Text;
                editRegistry(account);
                restartSteam();
                exit();
            }
            if (checkBox3.Checked)
            {
                string account = checkBox3.Text;
                editRegistry(account);
                restartSteam();
                exit();
            }
        }

        public void editRegistry(String account)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Valve\Steam");
            key.SetValue("AutoLoginUser", account);
            key.SetValue("RememberPassword", 1);
            key.Close();
        }

        public void restartSteam()
        {
            foreach (var process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            p.StartInfo.Arguments = "/c start steam://open/main";
            p.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exit();
        }

        public void exit()
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}