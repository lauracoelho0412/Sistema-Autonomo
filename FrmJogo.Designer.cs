namespace Sistema_Autonomo_Predadores
{
    partial class FrmJogo
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
            this.pbTabuleiro = new System.Windows.Forms.PictureBox();
            this.panelCD = new System.Windows.Forms.Panel();
            this.panelRS = new System.Windows.Forms.Panel();
            this.panelMT = new System.Windows.Forms.Panel();
            this.panelIS = new System.Windows.Forms.Panel();
            this.panelPA = new System.Windows.Forms.Panel();
            this.panelFI = new System.Windows.Forms.Panel();
            this.panel1HUD = new System.Windows.Forms.Panel();
            this.lblJogadorDado = new System.Windows.Forms.Label();
            this.lblDado = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblMao = new System.Windows.Forms.Label();
            this.btnJogarManual = new System.Windows.Forms.Button();
            this.cmbDino = new System.Windows.Forms.ComboBox();
            this.cmbCercado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabuleiro)).BeginInit();
            this.panel1HUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTabuleiro
            // 
            this.pbTabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.pbTabuleiro.Image = global::Sistema_Autonomo_Predadores.Properties.Resources.tabuleiro1;
            this.pbTabuleiro.Location = new System.Drawing.Point(14, 18);
            this.pbTabuleiro.Name = "pbTabuleiro";
            this.pbTabuleiro.Size = new System.Drawing.Size(795, 627);
            this.pbTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTabuleiro.TabIndex = 0;
            this.pbTabuleiro.TabStop = false;
            this.pbTabuleiro.Click += new System.EventHandler(this.pbTabuleiro_Click);
            // 
            // panelCD
            // 
            this.panelCD.BackColor = System.Drawing.Color.Transparent;
            this.panelCD.Location = new System.Drawing.Point(85, 440);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(221, 143);
            this.panelCD.TabIndex = 1;
            // 
            // panelRS
            // 
            this.panelRS.BackColor = System.Drawing.Color.Transparent;
            this.panelRS.Location = new System.Drawing.Point(596, 419);
            this.panelRS.Name = "panelRS";
            this.panelRS.Size = new System.Drawing.Size(159, 109);
            this.panelRS.TabIndex = 2;
            // 
            // panelMT
            // 
            this.panelMT.BackColor = System.Drawing.Color.Transparent;
            this.panelMT.Location = new System.Drawing.Point(70, 257);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(212, 124);
            this.panelMT.TabIndex = 3;
            // 
            // panelIS
            // 
            this.panelIS.BackColor = System.Drawing.Color.Transparent;
            this.panelIS.Location = new System.Drawing.Point(302, 216);
            this.panelIS.Name = "panelIS";
            this.panelIS.Size = new System.Drawing.Size(190, 106);
            this.panelIS.TabIndex = 4;
            this.panelIS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIS_Paint);
            // 
            // panelPA
            // 
            this.panelPA.BackColor = System.Drawing.Color.Transparent;
            this.panelPA.Location = new System.Drawing.Point(498, 246);
            this.panelPA.Name = "panelPA";
            this.panelPA.Size = new System.Drawing.Size(257, 151);
            this.panelPA.TabIndex = 5;
            // 
            // panelFI
            // 
            this.panelFI.BackColor = System.Drawing.Color.Transparent;
            this.panelFI.Location = new System.Drawing.Point(70, 60);
            this.panelFI.Name = "panelFI";
            this.panelFI.Size = new System.Drawing.Size(245, 141);
            this.panelFI.TabIndex = 6;
            this.panelFI.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFI_Paint);
            // 
            // panel1HUD
            // 
            this.panel1HUD.Controls.Add(this.cmbDino);
            this.panel1HUD.Controls.Add(this.cmbCercado);
            this.panel1HUD.Controls.Add(this.lblMao);
            this.panel1HUD.Controls.Add(this.lblTurno);
            this.panel1HUD.Controls.Add(this.lblDado);
            this.panel1HUD.Controls.Add(this.lblJogadorDado);
            this.panel1HUD.Location = new System.Drawing.Point(824, 35);
            this.panel1HUD.Name = "panel1HUD";
            this.panel1HUD.Size = new System.Drawing.Size(227, 571);
            this.panel1HUD.TabIndex = 7;
            // 
            // lblJogadorDado
            // 
            this.lblJogadorDado.AutoSize = true;
            this.lblJogadorDado.Location = new System.Drawing.Point(24, 43);
            this.lblJogadorDado.Name = "lblJogadorDado";
            this.lblJogadorDado.Size = new System.Drawing.Size(44, 16);
            this.lblJogadorDado.TabIndex = 0;
            this.lblJogadorDado.Text = "label1";
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Location = new System.Drawing.Point(24, 97);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(44, 16);
            this.lblDado.TabIndex = 1;
            this.lblDado.Text = "label1";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(24, 150);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(44, 16);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "label2";
            this.lblTurno.Click += new System.EventHandler(this.lblTurno_Click);
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.Location = new System.Drawing.Point(24, 255);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(44, 16);
            this.lblMao.TabIndex = 4;
            this.lblMao.Text = "label4";
            // 
            // btnJogarManual
            // 
            this.btnJogarManual.Location = new System.Drawing.Point(868, 521);
            this.btnJogarManual.Name = "btnJogarManual";
            this.btnJogarManual.Size = new System.Drawing.Size(126, 51);
            this.btnJogarManual.TabIndex = 10;
            this.btnJogarManual.Text = "Jogar Manual";
            this.btnJogarManual.UseVisualStyleBackColor = true;
            this.btnJogarManual.Click += new System.EventHandler(this.btnJogarManual_Click);
            // 
            // cmbDino
            // 
            this.cmbDino.BackColor = System.Drawing.Color.Red;
            this.cmbDino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDino.FormattingEnabled = true;
            this.cmbDino.Items.AddRange(new object[] {
            "BR",
            "AZ",
            "AM",
            "EP"});
            this.cmbDino.Location = new System.Drawing.Point(27, 375);
            this.cmbDino.Name = "cmbDino";
            this.cmbDino.Size = new System.Drawing.Size(159, 24);
            this.cmbDino.TabIndex = 5;
            // 
            // cmbCercado
            // 
            this.cmbCercado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCercado.FormattingEnabled = true;
            this.cmbCercado.Items.AddRange(new object[] {
            "FI",
            "PA",
            "IS",
            "MT",
            "CD",
            "RS"});
            this.cmbCercado.Location = new System.Drawing.Point(27, 420);
            this.cmbCercado.Name = "cmbCercado";
            this.cmbCercado.Size = new System.Drawing.Size(159, 24);
            this.cmbCercado.TabIndex = 6;
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 657);
            this.Controls.Add(this.panelPA);
            this.Controls.Add(this.btnJogarManual);
            this.Controls.Add(this.panel1HUD);
            this.Controls.Add(this.panelFI);
            this.Controls.Add(this.panelIS);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelRS);
            this.Controls.Add(this.panelCD);
            this.Controls.Add(this.pbTabuleiro);
            this.Name = "FrmJogo";
            this.Text = "FrmJogo";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabuleiro)).EndInit();
            this.panel1HUD.ResumeLayout(false);
            this.panel1HUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTabuleiro;
        private System.Windows.Forms.Panel panelCD;
        private System.Windows.Forms.Panel panelRS;
        private System.Windows.Forms.Panel panelMT;
        private System.Windows.Forms.Panel panelIS;
        private System.Windows.Forms.Panel panelPA;
        private System.Windows.Forms.Panel panelFI;
        private System.Windows.Forms.Panel panel1HUD;
        private System.Windows.Forms.Label lblMao;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.Label lblJogadorDado;
        private System.Windows.Forms.Button btnJogarManual;
        private System.Windows.Forms.ComboBox cmbCercado;
        private System.Windows.Forms.ComboBox cmbDino;
    }
}