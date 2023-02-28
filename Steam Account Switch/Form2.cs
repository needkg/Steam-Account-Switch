using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Account_Switch
{
    public partial class JanelaAdicionarConta : Form
    {

        public JanelaAdicionarConta()
        {
            InitializeComponent();
        }

        // Executa a função do botão adicionar
        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            JanelaPrincipal form1 = ((JanelaPrincipal)Owner);
            form1.username = caixaDeTexto.Text.ToString();
            form1.adicionarConta();
            form1.writeAccountsFile();
            this.Close();
        }

        // Executa a função do botão fechar
        private void botaoFechar(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
