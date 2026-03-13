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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSalvarJogador = new Button();
            lblErroJogador = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 203);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 23);
            txtNome.TabIndex = 7;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(90, 94);
            label1.Name = "label1";
            label1.Size = new Size(201, 51);
            label1.TabIndex = 11;
            label1.Text = "JOKEMPO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 183);
            label2.Name = "label2";
            label2.Size = new Size(162, 17);
            label2.TabIndex = 12;
            label2.Text = "Digite o nome do jogador";
            // 
            // btnSalvarJogador
            // 
            btnSalvarJogador.Location = new Point(138, 241);
            btnSalvarJogador.Name = "btnSalvarJogador";
            btnSalvarJogador.Size = new Size(104, 28);
            btnSalvarJogador.TabIndex = 13;
            btnSalvarJogador.Text = "Salvar";
            btnSalvarJogador.UseVisualStyleBackColor = true;
            btnSalvarJogador.Click += btnSalvarJogador_Click;
            // 
            // lblErroJogador
            // 
            lblErroJogador.ForeColor = Color.Red;
            lblErroJogador.Location = new Point(90, 281);
            lblErroJogador.Name = "lblErroJogador";
            lblErroJogador.Size = new Size(200, 15);
            lblErroJogador.TabIndex = 14;
            lblErroJogador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(lblErroJogador);
            Controls.Add(btnSalvarJogador);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Button btnSalvarJogador;
        private Label lblErroJogador;
    }
}
