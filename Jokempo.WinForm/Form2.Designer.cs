namespace Jokempo.WinForm
{
    partial class Form2
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
            btnJogarNovamente = new Button();
            btnJogar = new Button();
            btnTesoura = new Button();
            btnPapel = new Button();
            btnPedra = new Button();
            label1 = new Label();
            label2 = new Label();
            lblJogada = new Label();
            btnTrocarJogador = new Button();
            btnEstatisticas = new Button();
            SuspendLayout();
            // 
            // btnJogarNovamente
            // 
            btnJogarNovamente.Enabled = false;
            btnJogarNovamente.Location = new Point(65, 263);
            btnJogarNovamente.Name = "btnJogarNovamente";
            btnJogarNovamente.Size = new Size(122, 25);
            btnJogarNovamente.TabIndex = 17;
            btnJogarNovamente.Text = "Jogar Novamente";
            btnJogarNovamente.UseVisualStyleBackColor = true;
            btnJogarNovamente.Click += btnJogarNovamente_Click;
            // 
            // btnJogar
            // 
            btnJogar.Enabled = false;
            btnJogar.Location = new Point(49, 220);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(429, 37);
            btnJogar.TabIndex = 14;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.Location = new Point(356, 160);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(122, 34);
            btnTesoura.TabIndex = 13;
            btnTesoura.Text = "Tesoura";
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(200, 160);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(122, 34);
            btnPapel.TabIndex = 12;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnPedra
            // 
            btnPedra.Location = new Point(49, 160);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(122, 34);
            btnPedra.TabIndex = 11;
            btnPedra.Text = "Pedra";
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(165, 59);
            label1.Name = "label1";
            label1.Size = new Size(201, 51);
            label1.TabIndex = 18;
            label1.Text = "JOKEMPO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(146, 129);
            label2.Name = "label2";
            label2.Size = new Size(235, 17);
            label2.TabIndex = 19;
            label2.Text = "Clique em um botão e faça sua jogada";
            // 
            // lblJogada
            // 
            lblJogada.ForeColor = Color.Black;
            lblJogada.Location = new Point(49, 302);
            lblJogada.Name = "lblJogada";
            lblJogada.Size = new Size(429, 21);
            lblJogada.TabIndex = 20;
            lblJogada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTrocarJogador
            // 
            btnTrocarJogador.Enabled = false;
            btnTrocarJogador.Location = new Point(202, 263);
            btnTrocarJogador.Name = "btnTrocarJogador";
            btnTrocarJogador.Size = new Size(122, 25);
            btnTrocarJogador.TabIndex = 21;
            btnTrocarJogador.Text = "Trocar Jogador";
            btnTrocarJogador.UseVisualStyleBackColor = true;
            btnTrocarJogador.Click += btnTrocarJogador_Click;
            // 
            // btnEstatisticas
            // 
            btnEstatisticas.Enabled = false;
            btnEstatisticas.Location = new Point(339, 263);
            btnEstatisticas.Name = "btnEstatisticas";
            btnEstatisticas.Size = new Size(122, 25);
            btnEstatisticas.TabIndex = 22;
            btnEstatisticas.Text = "Ver Estatísticas";
            btnEstatisticas.UseVisualStyleBackColor = true;
            btnEstatisticas.Click += btnEstatisticas_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 408);
            Controls.Add(btnEstatisticas);
            Controls.Add(btnTrocarJogador);
            Controls.Add(lblJogada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnJogarNovamente);
            Controls.Add(btnJogar);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJogarNovamente;
        private Button btnJogar;
        private Button btnTesoura;
        private Button btnPapel;
        private Button btnPedra;
        private Label label1;
        private Label label2;
        private Label lblJogada;
        private Button btnTrocarJogador;
        private Button btnEstatisticas;
    }
}