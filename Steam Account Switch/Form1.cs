using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        // Executa a função do botão Connect
        private void botaoLogar_Click(object sender, EventArgs e)
        {
            string account = listaDeContas.SelectedItem.ToString();
            editSteamRegistry(nomeValor1, account);
            editSteamRegistry(nomeValor2, 1);
            restartSteam();
            this.Close();
        }

        // Executa a função do botão fechar
        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Executa a função do botão minimizar
        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Realiza funções na janela principal quando a mesma é carregada
        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            readAccountsFile();
            listaDeContas.SelectedIndex = 0;
        }

        // Executa a função do botão adicionar conta
        private void botaoAdicionarConta_Click(object sender, EventArgs e)
        {
            JanelaAdicionarConta form2 = new JanelaAdicionarConta();
            form2.ShowDialog(this);
        }

        // Executa a função do botão remover conta
        private void botaoRemoverConta_Click(object sender, EventArgs e)
        {
            string accountSelected = listaDeContas.SelectedItem.ToString();
            removerConta(accountSelected);
        }

        // Executa a função do botão atualizar lista
        private void botaoAtualizarLista_Click(object sender, EventArgs e)
        {
            listaDeContas.Items.Clear();
            readAccountsFile();
            listaDeContas.SelectedIndex = 0;
        }

        // Executa a função do botão abrir arquivo
        private void botaoAbrirArquivo_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", accountsFile);
        }

        // Executa a função do botão Como usar
        private void botaoComoUsar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String linha1 = "1. Click on the \"+\" button to add a new account.";
            String linha2 = "2. Enter your username and click on the \"Add\" button.";
            String linha3 = "3. Now select your account and click on the \"Connect\" button.";
            String linha4 = "";
            String linha5 = "Note: If this is the first time you're connecting this account, you will be prompted for the Steam Guard code for authentication. You will not need to provide the Steam Guard code in future logins with this account.";


            string mensagem = linha1 + "\n" + linha2 + "\n" + linha3 + "\n" + linha4 + "\n" + linha5;
            MessageBox.Show(mensagem, "How to use",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Executa a função do botão Versão
        private void botaoVersao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://github.com/nk260203/Steam-Account-Switch";
            myProcess.Start();
        }

        // Método que remove a conta da lista
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

        // Método que atualiza o arquvio accounts.txt
        public void writeAccountsFile()
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(accountsFile);
            foreach (var item in listaDeContas.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
        }

        // Método que lê o arquivo accounts.txt
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

        // Método que adiciona uma conta na lista de conta
        public void adicionarConta()
        {
            if (username.Length >= 3 && System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                listaDeContas.Items.Add(username);
                listaDeContas.SelectedItem = username;
            }
            else
            {
                MessageBox.Show("Please enter an account name that is at least 3 characters long and uses only a-z, A-Z, 0-9 or _ characters.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JanelaAdicionarConta form2 = new JanelaAdicionarConta();
                form2.ShowDialog(this);
            }
        }

        // Método que modifica o registro da Steam no registro do Windows
        public void editSteamRegistry(String valor, object dado)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(chave))
            {
                key.SetValue(valor, dado);

                key.Close();
            }
        }

        // Método que reinicia o processo da Steam e Explorer.
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