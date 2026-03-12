namespace Jokempo.WinForm
{
    partial class Form1
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
            txtNomeJogador = new TextBox();
            btnSalvar = new Button();
            listJogadores = new ListView();
            btnPedra = new Button();
            btnPapel = new Button();
            btnTesoura = new Button();
            btnJogar = new Button();
            txtJogada = new TextBox();
            SuspendLayout();
            // 
            // txtNomeJogador
            // 
            txtNomeJogador.Location = new Point(12, 21);
            txtNomeJogador.Name = "txtNomeJogador";
            txtNomeJogador.Size = new Size(100, 23);
            txtNomeJogador.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(136, 22);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // listJogadores
            // 
            listJogadores.Location = new Point(56, 80);
            listJogadores.Name = "listJogadores";
            listJogadores.Size = new Size(121, 97);
            listJogadores.TabIndex = 2;
            listJogadores.UseCompatibleStateImageBehavior = false;
            // 
            // btnPedra
            // 
            btnPedra.Location = new Point(320, 80);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(122, 34);
            btnPedra.TabIndex = 3;
            btnPedra.Text = "Pedra";
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += button1_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(471, 80);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(122, 34);
            btnPapel.TabIndex = 4;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.Location = new Point(627, 80);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(122, 34);
            btnTesoura.TabIndex = 5;
            btnTesoura.Text = "Tesoura";
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // btnJogar
            // 
            btnJogar.Location = new Point(320, 140);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(429, 37);
            btnJogar.TabIndex = 6;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // txtJogada
            // 
            txtJogada.Location = new Point(408, 205);
            txtJogada.Name = "txtJogada";
            txtJogada.Size = new Size(245, 23);
            txtJogada.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
            Controls.Add(txtJogada);
            Controls.Add(btnJogar);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Controls.Add(listJogadores);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeJogador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeJogador;
        private Button btnSalvar;
        private ListView listJogadores;
        private Button btnPedra;
        private Button btnPapel;
        private Button btnTesoura;
        private Button btnJogar;
        private TextBox txtJogada;
    }
}
