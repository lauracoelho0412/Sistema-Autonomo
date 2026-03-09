namespace Sistema_Autonomo_Predadores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPartidas = new System.Windows.Forms.Button();
            this.txtPartidas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.mtbSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPartidas
            // 
            this.btnPartidas.Location = new System.Drawing.Point(342, 328);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(75, 23);
            this.btnPartidas.TabIndex = 0;
            this.btnPartidas.Text = "Clique Aqui!";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtPartidas
            // 
            this.txtPartidas.Location = new System.Drawing.Point(293, 84);
            this.txtPartidas.Multiline = true;
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(165, 238);
            this.txtPartidas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Partidas do Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Criar nova partida!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Senha:";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(93, 211);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 11;
            this.btnCriarPartida.Text = "Criar Partida!";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(483, 361);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(43, 13);
            this.lblVersao.TabIndex = 12;
            this.lblVersao.Text = "Versão:";
            // 
            // mtbNome
            // 
            this.mtbNome.Location = new System.Drawing.Point(69, 84);
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(158, 20);
            this.mtbNome.TabIndex = 13;
            // 
            // mtbSenha
            // 
            this.mtbSenha.Location = new System.Drawing.Point(69, 118);
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.Size = new System.Drawing.Size(158, 20);
            this.mtbSenha.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(218, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 13);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Grupo Predadores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grupo:";
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(69, 160);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(158, 21);
            this.cboGrupo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 383);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mtbSenha);
            this.Controls.Add(this.mtbNome);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPartidas);
            this.Controls.Add(this.btnPartidas);
            this.MinimumSize = new System.Drawing.Size(566, 422);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.TextBox txtPartidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.MaskedTextBox mtbNome;
        private System.Windows.Forms.MaskedTextBox mtbSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGrupo;
    }
}

