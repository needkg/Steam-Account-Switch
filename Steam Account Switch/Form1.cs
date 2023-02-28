using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Steam_Account_Switch
{
    public partial class JanelaPrincipal : Form
    {
        public string username;
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string account = listaDeContas.SelectedItem.ToString();
            editRegistry(account);
            restartSteam();
            this.Close();
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
            foreach (Process process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }

            string steamProtocol = "steam://open/main";

            string cmdCommand = $"/C start {steamProtocol} & taskkill /f /im explorer.exe & start explorer.exe";

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo("cmd.exe", cmdCommand);
            cmdStartInfo.CreateNoWindow = true;
            cmdStartInfo.UseShellExecute = false;

            Process cmdProcess = new Process();
            cmdProcess.StartInfo = cmdStartInfo;
            cmdProcess.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readAccountsFile();
            listaDeContas.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JanelaAdicionarConta form2 = new JanelaAdicionarConta();
            form2.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string accountSelected = listaDeContas.SelectedItem.ToString();
                listaDeContas.Items.Remove(accountSelected);
                listaDeContas.SelectedIndex = 0;
            }
            catch
            {

            }
            writeAccountsFile();
        }

        public void updateList()
        {
            if (Regex.IsMatch(username, "^[a-zA-Z0-9_]*$"))
            {
                listaDeContas.Items.Add(username);
            }
        }

        public void writeAccountsFile()
        {
            const string sPath = "accounts.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listaDeContas.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
        }

        public void readAccountsFile()
        {
            int counter = 0;
            string line;
            const string sPath = "accounts.txt";
            System.IO.StreamReader readFile = new System.IO.StreamReader(sPath);
            while ((line = readFile.ReadLine()) != null)
            {
                listaDeContas.Items.Add(line); counter++;
            }
            readFile.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listaDeContas.Items.Clear();
            readAccountsFile();
            listaDeContas.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "accounts.txt";
            Process.Start("notepad.exe", path);
        }
    }

}