using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
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

        public string username = "null";
        static string chave = @"Software\Valve\Steam";
        static string nomeValor1 = "AutoLoginUser";
        static string nomeValor2 = "RememberPassword";
        static string accountsFile = "accounts.txt";

        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void botaoLogar_Click(object sender, EventArgs e)
        {
            string account = listaDeContas.SelectedItem.ToString();
            editSteamRegistry(nomeValor1, account);
            editSteamRegistry(nomeValor2, 1);
            restartSteam();
            this.Close();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            readAccountsFile();
            listaDeContas.SelectedIndex = 0;
        }

        private void botaoAdicionarConta_Click(object sender, EventArgs e)
        {
            JanelaAdicionarConta form2 = new JanelaAdicionarConta();
            form2.ShowDialog(this);
        }

        private void botaoRemoverConta_Click(object sender, EventArgs e)
        {
            string accountSelected = listaDeContas.SelectedItem.ToString();
            removerConta(accountSelected);
        }

        private void botaoAtualizarLista_Click(object sender, EventArgs e)
        {
            listaDeContas.Items.Clear();
            readAccountsFile();
            listaDeContas.SelectedIndex = 0;
        }

        private void botaoAbrirArquivo_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", accountsFile);
        }

        public void removerConta(string accountSelected)
        {
            if (listaDeContas.Items.Count > 1)
            {
                listaDeContas.Items.Remove(accountSelected);
                listaDeContas.SelectedIndex = 0;
                writeAccountsFile();
            }
            else
            {
                MessageBox.Show("You need to have at least 1 account on the list", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void writeAccountsFile()
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(accountsFile);
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
            System.IO.StreamReader readFile = new System.IO.StreamReader(accountsFile);
            while ((line = readFile.ReadLine()) != null)
            {
                listaDeContas.Items.Add(line); counter++;
            }
            readFile.Close();
        }

        public void updateList()
        {
            if (Regex.IsMatch(username, "^[a-zA-Z0-9_]*$"))
            {
                listaDeContas.Items.Add(username);
            }
            else
            {
                MessageBox.Show("Please enter an account name that is at least 3 characters long and uses only a-z, A-Z, 0-9 or _ characters.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JanelaAdicionarConta form2 = new JanelaAdicionarConta();
                form2.ShowDialog(this);
            }
        }

        public void editSteamRegistry(String valor, object dado)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(chave))
            {
                key.SetValue(valor, dado);

                key.Close();
            }
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
    }

}