namespace Steam_Account_Switch
{
    partial class JanelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            botaoLogar = new Button();
            botaoFechar = new Button();
            botaoMinimizar = new Button();
            iconeSteam = new PictureBox();
            labelVersao = new Label();
            nomeDoPrograma = new Label();
            bordaSuperior = new Panel();
            listaDeContas = new ListBox();
            botaoRemoverConta = new Button();
            botaoAdicionarConta = new Button();
            bordaDireita = new Panel();
            bordaInferior = new Panel();
            bordaEsquerda = new Panel();
            botaoAtualizarLista = new Button();
            botaoAbrirArquivo = new Button();
            ((System.ComponentModel.ISupportInitialize)iconeSteam).BeginInit();
            bordaSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // botaoLogar
            // 
            botaoLogar.FlatAppearance.BorderSize = 0;
            botaoLogar.FlatStyle = FlatStyle.Flat;
            botaoLogar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            botaoLogar.ForeColor = Color.FromArgb(0, 126, 249);
            botaoLogar.ImageAlign = ContentAlignment.MiddleLeft;
            botaoLogar.Location = new Point(19, 159);
            botaoLogar.Margin = new Padding(10);
            botaoLogar.Name = "botaoLogar";
            botaoLogar.Size = new Size(127, 31);
            botaoLogar.TabIndex = 3;
            botaoLogar.Text = "Connect";
            botaoLogar.TextImageRelation = TextImageRelation.ImageBeforeText;
            botaoLogar.UseVisualStyleBackColor = true;
            botaoLogar.Click += botao_Click;
            // 
            // botaoFechar
            // 
            botaoFechar.FlatAppearance.BorderSize = 0;
            botaoFechar.FlatStyle = FlatStyle.Flat;
            botaoFechar.ForeColor = Color.White;
            botaoFechar.Location = new Point(252, 11);
            botaoFechar.Margin = new Padding(1);
            botaoFechar.Name = "botaoFechar";
            botaoFechar.Size = new Size(25, 25);
            botaoFechar.TabIndex = 5;
            botaoFechar.Text = "X";
            botaoFechar.UseVisualStyleBackColor = true;
            botaoFechar.Click += button2_Click;
            // 
            // botaoMinimizar
            // 
            botaoMinimizar.FlatAppearance.BorderSize = 0;
            botaoMinimizar.FlatStyle = FlatStyle.Flat;
            botaoMinimizar.ForeColor = Color.White;
            botaoMinimizar.Location = new Point(227, 11);
            botaoMinimizar.Margin = new Padding(1);
            botaoMinimizar.Name = "botaoMinimizar";
            botaoMinimizar.Size = new Size(25, 25);
            botaoMinimizar.TabIndex = 6;
            botaoMinimizar.Text = "-";
            botaoMinimizar.UseVisualStyleBackColor = true;
            botaoMinimizar.Click += button3_Click;
            // 
            // iconeSteam
            // 
            iconeSteam.Image = Properties.Resources.Steam_Switch_Account_Icon;
            iconeSteam.Location = new Point(190, 70);
            iconeSteam.Name = "iconeSteam";
            iconeSteam.Size = new Size(67, 65);
            iconeSteam.TabIndex = 7;
            iconeSteam.TabStop = false;
            // 
            // labelVersao
            // 
            labelVersao.AutoSize = true;
            labelVersao.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            labelVersao.ForeColor = Color.FromArgb(158, 161, 178);
            labelVersao.Location = new Point(196, 178);
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(72, 15);
            labelVersao.TabIndex = 12;
            labelVersao.Text = "Version: 1.2";
            // 
            // nomeDoPrograma
            // 
            nomeDoPrograma.AutoSize = true;
            nomeDoPrograma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nomeDoPrograma.ForeColor = Color.FromArgb(158, 161, 178);
            nomeDoPrograma.Location = new Point(13, 16);
            nomeDoPrograma.Name = "nomeDoPrograma";
            nomeDoPrograma.Size = new Size(145, 15);
            nomeDoPrograma.TabIndex = 13;
            nomeDoPrograma.Text = "Steam Account Switcher";
            // 
            // bordaSuperior
            // 
            bordaSuperior.BackColor = Color.FromArgb(24, 30, 54);
            bordaSuperior.BackgroundImageLayout = ImageLayout.None;
            bordaSuperior.Controls.Add(nomeDoPrograma);
            bordaSuperior.Controls.Add(botaoMinimizar);
            bordaSuperior.Controls.Add(botaoFechar);
            bordaSuperior.Location = new Point(-6, -9);
            bordaSuperior.Name = "bordaSuperior";
            bordaSuperior.Size = new Size(292, 38);
            bordaSuperior.TabIndex = 14;
            // 
            // listaDeContas
            // 
            listaDeContas.BackColor = Color.FromArgb(46, 51, 73);
            listaDeContas.BorderStyle = BorderStyle.FixedSingle;
            listaDeContas.ForeColor = Color.FromArgb(158, 161, 178);
            listaDeContas.FormattingEnabled = true;
            listaDeContas.ItemHeight = 15;
            listaDeContas.Location = new Point(18, 44);
            listaDeContas.Margin = new Padding(10);
            listaDeContas.Name = "listaDeContas";
            listaDeContas.Size = new Size(128, 107);
            listaDeContas.TabIndex = 16;
            // 
            // botaoRemoverConta
            // 
            botaoRemoverConta.FlatAppearance.BorderSize = 0;
            botaoRemoverConta.FlatStyle = FlatStyle.Flat;
            botaoRemoverConta.ForeColor = Color.White;
            botaoRemoverConta.Location = new Point(150, 71);
            botaoRemoverConta.Margin = new Padding(1);
            botaoRemoverConta.Name = "botaoRemoverConta";
            botaoRemoverConta.Size = new Size(25, 25);
            botaoRemoverConta.TabIndex = 17;
            botaoRemoverConta.Text = "-";
            botaoRemoverConta.UseVisualStyleBackColor = true;
            botaoRemoverConta.Click += button1_Click;
            // 
            // botaoAdicionarConta
            // 
            botaoAdicionarConta.FlatAppearance.BorderSize = 0;
            botaoAdicionarConta.FlatStyle = FlatStyle.Flat;
            botaoAdicionarConta.ForeColor = Color.White;
            botaoAdicionarConta.Location = new Point(150, 45);
            botaoAdicionarConta.Margin = new Padding(1);
            botaoAdicionarConta.Name = "botaoAdicionarConta";
            botaoAdicionarConta.Size = new Size(25, 25);
            botaoAdicionarConta.TabIndex = 18;
            botaoAdicionarConta.Text = "+";
            botaoAdicionarConta.UseVisualStyleBackColor = true;
            botaoAdicionarConta.Click += button4_Click;
            // 
            // bordaDireita
            // 
            bordaDireita.BackColor = Color.FromArgb(24, 30, 54);
            bordaDireita.BackgroundImageLayout = ImageLayout.None;
            bordaDireita.Location = new Point(269, 29);
            bordaDireita.Name = "bordaDireita";
            bordaDireita.Size = new Size(17, 182);
            bordaDireita.TabIndex = 15;
            // 
            // bordaInferior
            // 
            bordaInferior.BackColor = Color.FromArgb(24, 30, 54);
            bordaInferior.BackgroundImageLayout = ImageLayout.None;
            bordaInferior.Location = new Point(-7, 196);
            bordaInferior.Name = "bordaInferior";
            bordaInferior.Size = new Size(290, 15);
            bordaInferior.TabIndex = 16;
            // 
            // bordaEsquerda
            // 
            bordaEsquerda.BackColor = Color.FromArgb(24, 30, 54);
            bordaEsquerda.BackgroundImageLayout = ImageLayout.None;
            bordaEsquerda.Location = new Point(-7, 23);
            bordaEsquerda.Name = "bordaEsquerda";
            bordaEsquerda.Size = new Size(10, 188);
            bordaEsquerda.TabIndex = 17;
            // 
            // botaoAtualizarLista
            // 
            botaoAtualizarLista.FlatAppearance.BorderSize = 0;
            botaoAtualizarLista.FlatStyle = FlatStyle.Flat;
            botaoAtualizarLista.ForeColor = Color.White;
            botaoAtualizarLista.Location = new Point(150, 125);
            botaoAtualizarLista.Margin = new Padding(1);
            botaoAtualizarLista.Name = "botaoAtualizarLista";
            botaoAtualizarLista.Size = new Size(25, 25);
            botaoAtualizarLista.TabIndex = 19;
            botaoAtualizarLista.Text = "⟳";
            botaoAtualizarLista.UseVisualStyleBackColor = true;
            botaoAtualizarLista.Click += button5_Click;
            // 
            // botaoAbrirArquivo
            // 
            botaoAbrirArquivo.FlatAppearance.BorderSize = 0;
            botaoAbrirArquivo.FlatStyle = FlatStyle.Flat;
            botaoAbrirArquivo.ForeColor = Color.White;
            botaoAbrirArquivo.Location = new Point(150, 98);
            botaoAbrirArquivo.Margin = new Padding(1);
            botaoAbrirArquivo.Name = "botaoAbrirArquivo";
            botaoAbrirArquivo.Size = new Size(25, 25);
            botaoAbrirArquivo.TabIndex = 20;
            botaoAbrirArquivo.Text = "📂";
            botaoAbrirArquivo.UseVisualStyleBackColor = true;
            botaoAbrirArquivo.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(272, 199);
            Controls.Add(botaoAbrirArquivo);
            Controls.Add(botaoAtualizarLista);
            Controls.Add(bordaEsquerda);
            Controls.Add(bordaInferior);
            Controls.Add(bordaDireita);
            Controls.Add(botaoAdicionarConta);
            Controls.Add(botaoRemoverConta);
            Controls.Add(listaDeContas);
            Controls.Add(bordaSuperior);
            Controls.Add(labelVersao);
            Controls.Add(iconeSteam);
            Controls.Add(botaoLogar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Steam Account Switcher";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)iconeSteam).EndInit();
            bordaSuperior.ResumeLayout(false);
            bordaSuperior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botaoLogar;
        private Button botaoFechar;
        private Button botaoMinimizar;
        private PictureBox iconeSteam;
        private Label labelVersao;
        private Label nomeDoPrograma;
        private Panel bordaSuperior;
        private ListBox listaDeContas;
        private Button botaoRemoverConta;
        private Button botaoAdicionarConta;
        private Panel bordaDireita;
        private Panel bordaInferior;
        private Panel bordaEsquerda;
        private Button botaoAtualizarLista;
        private Button botaoAbrirArquivo;
    }
}