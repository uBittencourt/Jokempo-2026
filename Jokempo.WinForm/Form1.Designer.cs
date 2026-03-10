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
            SuspendLayout();
            // 
            // txtNomeJogador
            // 
            txtNomeJogador.Location = new Point(331, 82);
            txtNomeJogador.Name = "txtNomeJogador";
            txtNomeJogador.Size = new Size(100, 23);
            txtNomeJogador.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(455, 83);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // listJogadores
            // 
            listJogadores.Location = new Point(375, 141);
            listJogadores.Name = "listJogadores";
            listJogadores.Size = new Size(121, 97);
            listJogadores.TabIndex = 2;
            listJogadores.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
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
    }
}
