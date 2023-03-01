using Microsoft.Win32;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Steam_Account_Switch
{
    public partial class JanelaPrincipal : Form
    {

        public string username;
        private Point mouseDownLocation;
        private readonly string caminhoArquivoContas = "Resources\\accounts.txt";

        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        // Armazena a localização do mouse quando o botão esquerdo do mouse é pressionado.
        private void ArrastarJanela_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        // Move a janela pela tela com base no movimento do mouse quando o botão esquerdo do mouse é pressionado.
        private void ArrastarJanela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(
                    Location.X + e.X - mouseDownLocation.X,
                    Location.Y + e.Y - mouseDownLocation.Y);

                Location = newLocation;
            }
        }

        // Executa a função de editar o registro, reiniciar e logar na Steam
        private void BotaoLogar_Click(object sender, EventArgs e)
        {
            string autoLoginUser = "AutoLoginUser";
            string rememberPassword = "RememberPassword";
            string accountSelected = listaDeContas.SelectedItem.ToString();
            EditSteamRegistry(autoLoginUser, accountSelected);
            EditSteamRegistry(rememberPassword, 1);
            RestartSteam();
            Close();
        }

        // Fecha a janela da aplicação
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Minimiza a janela da aplicação
        private void BotaoMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Realiza funções na janela principal quando a mesma é carregada
        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            LerArquivoDeContas();
            listaDeContas.SelectedIndex = 0;
        }

        // Abre uma janela que permite ao usuário inserir o nome de usuario.
        private void BotaoAdicionarConta_Click(object sender, EventArgs e)
        {
            JanelaPrincipalHelpers.AbrirFormCentralizado(this, new JanelaAdicionarConta());
        }

        // Remove a conta selecionada da lista de contas e atualiza o arquivo de contas.
        private void BotaoRemoverConta_Click(object sender, EventArgs e)
        {
            string accountSelected = listaDeContas.SelectedItem.ToString();
            RemoverConta(accountSelected);
        }

        // Atualiza a lista de contas.
        private void BotaoAtualizarLista_Click(object sender, EventArgs e)
        {
            listaDeContas.Items.Clear();
            LerArquivoDeContas();
            listaDeContas.SelectedIndex = 0;
        }

        // Abre o arquivo de texto que contém a lista de contas.
        private void BotaoAbrirArquivo_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", caminhoArquivoContas);
        }

        // Exibe uma mensagem de ajuda ao usuário quando o botão "Como Usar" é clicado
        private void BotaoComoUsar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void BotaoVersao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://github.com/needkg/Steam-Account-Switch";
            myProcess.Start();
        }

        // Remove um nome de usuário específico da lista de contas.
        public void RemoverConta(string accountSelected)
        {
            if (listaDeContas.Items.Count > 1)
            {
                listaDeContas.Items.Remove(accountSelected);
                listaDeContas.SelectedIndex = 0;
                AtualizarArquivoDeContas();
            }
            else
            {
                MessageBox.Show("You need to have at least 1 account on the list", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Atualiza o arquivo de contas com os usuários adicionados/removidos recentemente na lista.
        public void AtualizarArquivoDeContas()
        {
            using (StreamWriter arquivo = new StreamWriter(caminhoArquivoContas, false))
            {
                foreach (var linha in listaDeContas.Items)
                {
                    arquivo.WriteLine(linha);
                }

                arquivo.Close();
            }
        }

        // Lê o arquivo de texto contendo nomes de usuários e adiciona esses nomes a uma lista na interface do programa.
        public void LerArquivoDeContas()
        {
            Boolean found = false;
            string caminhoArquivo = caminhoArquivoContas;
            var linhas = new List<string>();
            using (var arquivo = new StreamReader(caminhoArquivo))
            {
                while (!arquivo.EndOfStream)
                {
                    var linha = arquivo.ReadLine();

                    if (linha.Length >= 3 && Regex.IsMatch(linha, "^[a-zA-Z0-9_]+$"))
                    {
                        if (!linhas.Contains(linha))
                        {   
                            found = true;
                            linhas.Add(linha);
                        }
                    }
                }
                arquivo.Close();
            }

            if (linhas.Count == 0)
            {
                linhas.Add("username1");
                linhas.Add("username2");
                linhas.Add("username3");
            }

            File.WriteAllLines(caminhoArquivo, linhas);

            listaDeContas.Items.AddRange(linhas.ToArray());
        }

        // Adiciona um nome de usuário selecionado a uma lista de contas.
        public void AdicionarConta()
        {
            if (username.Length >= 3 && Regex.IsMatch(username, "^[a-zA-Z0-9_]+$"))
            {
                if (!listaDeContas.Items.Contains(username))
                {
                    listaDeContas.Items.Add(username);
                    listaDeContas.SelectedItem = username;
                }
                else
                {
                    MessageBox.Show("The account has already been added.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    JanelaPrincipalHelpers.AbrirFormCentralizado(this, new JanelaAdicionarConta());
                }
            }
            else
            {
                MessageBox.Show("Please enter an account name that is at least 3 characters long and uses only a-z, A-Z, 0-9 or _ characters.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JanelaPrincipalHelpers.AbrirFormCentralizado(this, new JanelaAdicionarConta());
            }
        }

        // Edita uma chave do registro do Windows relacionada à Steam.
        public static void EditSteamRegistry(String valor, object dado)
        {
            string caminhoRegistroSteam = @"Software\Valve\Steam";
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(caminhoRegistroSteam))
            {
                key.SetValue(valor, dado);

                key.Close();
            }
        }

        // Esse método reinicia o processo da Steam e Explorer para que as alterações possam ser aplicadas.
        public static void RestartSteam()
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