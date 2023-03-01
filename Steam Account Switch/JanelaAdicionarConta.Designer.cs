using Steam_Account_Switch.Properties;
using System.Windows.Forms;

namespace Steam_Account_Switch
{
    partial class JanelaAdicionarConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            caixaDeTexto = new TextBox();
            botaoAdicionar = new Button();
            botaoCancelar = new Button();
            bordaInferior = new Panel();
            bordaDireita = new Panel();
            bordaEsquerda = new Panel();
            bordaSuperior = new Panel();
            SuspendLayout();
            // 
            // caixaDeTexto
            // 
            caixaDeTexto.BackColor = Color.FromArgb(24, 30, 54);
            caixaDeTexto.BorderStyle = BorderStyle.FixedSingle;
            caixaDeTexto.ForeColor = Color.FromArgb(158, 161, 178);
            caixaDeTexto.Location = new Point(16, 12);
            caixaDeTexto.Name = "caixaDeTexto";
            caixaDeTexto.Size = new Size(104, 23);
            caixaDeTexto.TabIndex = 7;
            caixaDeTexto.TextAlign = HorizontalAlignment.Center;
            caixaDeTexto.KeyDown += new KeyEventHandler(CaixaDeTexto_KeyDown);
            // 
            // botaoAdicionar
            // 
            botaoAdicionar.FlatAppearance.BorderSize = 0;
            botaoAdicionar.FlatStyle = FlatStyle.Flat;
            botaoAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botaoAdicionar.ForeColor = Color.White;
            botaoAdicionar.Location = new Point(27, 39);
            botaoAdicionar.Margin = new Padding(1);
            botaoAdicionar.Name = "botaoAdicionar";
            botaoAdicionar.Size = new Size(76, 25);
            botaoAdicionar.TabIndex = 18;
            botaoAdicionar.Text = "Add";
            botaoAdicionar.UseVisualStyleBackColor = true;
            botaoAdicionar.Click += BotaoAdicionar_Click;
            // 
            // botaoCancelar
            // 
            botaoCancelar.FlatAppearance.BorderSize = 0;
            botaoCancelar.FlatStyle = FlatStyle.Flat;
            botaoCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botaoCancelar.ForeColor = Color.White;
            botaoCancelar.Location = new Point(27, 66);
            botaoCancelar.Margin = new Padding(1);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(76, 25);
            botaoCancelar.TabIndex = 20;
            botaoCancelar.Text = "Cancel";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += BotaoFechar;
            // 
            // bordaInferior
            // 
            bordaInferior.BackColor = Color.FromArgb(24, 30, 54);
            bordaInferior.Location = new Point(-11, 96);
            bordaInferior.Name = "bordaInferior";
            bordaInferior.Size = new Size(144, 10);
            bordaInferior.TabIndex = 21;
            // 
            // bordaDireita
            // 
            bordaDireita.BackColor = Color.FromArgb(24, 30, 54);
            bordaDireita.Location = new Point(133, -3);
            bordaDireita.Name = "bordaDireita";
            bordaDireita.Size = new Size(12, 103);
            bordaDireita.TabIndex = 22;
            // 
            // bordaEsquerda
            // 
            bordaEsquerda.BackColor = Color.FromArgb(24, 30, 54);
            bordaEsquerda.Location = new Point(-9, -2);
            bordaEsquerda.Name = "bordaEsquerda";
            bordaEsquerda.Size = new Size(12, 103);
            bordaEsquerda.TabIndex = 23;
            // 
            // bordaSuperior
            // 
            bordaSuperior.BackColor = Color.FromArgb(24, 30, 54);
            bordaSuperior.Location = new Point(-9, -7);
            bordaSuperior.Name = "bordaSuperior";
            bordaSuperior.Size = new Size(144, 10);
            bordaSuperior.TabIndex = 22;
            // 
            // JanelaAdicionarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(128, 99);
            Controls.Add(bordaSuperior);
            Controls.Add(bordaEsquerda);
            Controls.Add(bordaDireita);
            Controls.Add(bordaInferior);
            Controls.Add(botaoCancelar);
            Controls.Add(botaoAdicionar);
            Controls.Add(caixaDeTexto);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "JanelaAdicionarConta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Steam Account Switcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox caixaDeTexto;
        private Button botaoAdicionar;
        private Button botaoCancelar;
        private Panel bordaInferior;
        private Panel bordaDireita;
        private Panel bordaEsquerda;
        private Panel bordaSuperior;
    }
}