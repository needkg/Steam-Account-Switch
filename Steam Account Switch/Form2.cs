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
        public string accountId2;
        public JanelaAdicionarConta()
        {
            InitializeComponent();
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            JanelaPrincipal form1 = ((JanelaPrincipal)Owner);
            form1.username = caixaDeTexto.Text.ToString();
            form1.updateList();
            form1.writeAccountsFile();
            this.Close();
        }

        private void botaoFechar(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
