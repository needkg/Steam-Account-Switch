namespace Steam_Account_Switch
{
    public partial class JanelaAdicionarConta : Form
    {

        public JanelaAdicionarConta()
        {
            InitializeComponent();
        }

        // Executa a função do botão adicionar quando o usuário pressionar ENTER dentro da caixaDeTexto
        private void CaixaDeTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoAdicionar.PerformClick();
            }
        }

        // Executa a função do botão adicionar
        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            JanelaPrincipal janelaPrincipal = ((JanelaPrincipal)Owner);
            janelaPrincipal.username = caixaDeTexto.Text.ToString();
            janelaPrincipal.AdicionarConta();
            janelaPrincipal.AtualizarArquivoDeContas();
            Close();
        }

        // Executa a função do botão fechar
        private void BotaoFechar(object sender, EventArgs e)
        {
            Close();
        }
    }

}
