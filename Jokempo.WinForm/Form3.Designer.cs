namespace Jokempo.WinForm
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            listEstatisticas = new ListView();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(131, 64);
            label1.Name = "label1";
            label1.Size = new Size(201, 51);
            label1.TabIndex = 19;
            label1.Text = "JOKEMPO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 146);
            label2.Name = "label2";
            label2.Size = new Size(189, 21);
            label2.TabIndex = 20;
            label2.Text = "Estatísticas dos Jogadores";
            // 
            // listEstatisticas
            // 
            listEstatisticas.Location = new Point(51, 174);
            listEstatisticas.Name = "listEstatisticas";
            listEstatisticas.Size = new Size(355, 187);
            listEstatisticas.TabIndex = 21;
            listEstatisticas.UseCompatibleStateImageBehavior = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(167, 367);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(122, 25);
            btnVoltar.TabIndex = 22;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 450);
            Controls.Add(btnVoltar);
            Controls.Add(listEstatisticas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listEstatisticas;
        private Button btnVoltar;
    }
}