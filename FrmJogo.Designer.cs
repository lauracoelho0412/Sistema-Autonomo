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
            this.components = new System.ComponentModel.Container();
            this.panelTabu = new System.Windows.Forms.PictureBox();
            this.panelPA = new System.Windows.Forms.Panel();
            this.panelIS = new System.Windows.Forms.Panel();
            this.panelMT = new System.Windows.Forms.Panel();
            this.panelRI = new System.Windows.Forms.Panel();
            this.panelCD = new System.Windows.Forms.Panel();
            this.panelFI = new System.Windows.Forms.Panel();
            this.panel1HUD = new System.Windows.Forms.Panel();
            this.lblCercados = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblJogadorDado = new System.Windows.Forms.Label();
            this.cmbDino = new System.Windows.Forms.ComboBox();
            this.cmbCercado = new System.Windows.Forms.ComboBox();
            this.btnJogarManual = new System.Windows.Forms.Button();
            this.lblMao = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDado = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.panelRS = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelTabu)).BeginInit();
            this.panel1HUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabu
            // 
            this.panelTabu.BackColor = System.Drawing.Color.Transparent;
            this.panelTabu.Image = global::Sistema_Autonomo_Predadores.Properties.Resources.tabuleiro1;
            this.panelTabu.Location = new System.Drawing.Point(24, 14);
            this.panelTabu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTabu.Name = "panelTabu";
            this.panelTabu.Size = new System.Drawing.Size(795, 626);
            this.panelTabu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelTabu.TabIndex = 0;
            this.panelTabu.TabStop = false;
            // 
            // panelPA
            // 
            this.panelPA.BackColor = System.Drawing.Color.Transparent;
            this.panelPA.Location = new System.Drawing.Point(85, 441);
            this.panelPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPA.Name = "panelPA";
            this.panelPA.Size = new System.Drawing.Size(221, 143);
            this.panelPA.TabIndex = 1;
            // 
            // panelIS
            // 
            this.panelIS.BackColor = System.Drawing.Color.Transparent;
            this.panelIS.Location = new System.Drawing.Point(596, 418);
            this.panelIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIS.Name = "panelIS";
            this.panelIS.Size = new System.Drawing.Size(159, 110);
            this.panelIS.TabIndex = 2;
            // 
            // panelMT
            // 
            this.panelMT.BackColor = System.Drawing.Color.Transparent;
            this.panelMT.Location = new System.Drawing.Point(69, 257);
            this.panelMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(212, 124);
            this.panelMT.TabIndex = 3;
            // 
            // panelRI
            // 
            this.panelRI.BackColor = System.Drawing.Color.Transparent;
            this.panelRI.Location = new System.Drawing.Point(348, 240);
            this.panelRI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRI.Name = "panelRI";
            this.panelRI.Size = new System.Drawing.Size(104, 175);
            this.panelRI.TabIndex = 4;
            // 
            // panelCD
            // 
            this.panelCD.BackColor = System.Drawing.Color.Transparent;
            this.panelCD.Location = new System.Drawing.Point(499, 246);
            this.panelCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(257, 151);
            this.panelCD.TabIndex = 5;
            // 
            // panelFI
            // 
            this.panelFI.BackColor = System.Drawing.Color.Transparent;
            this.panelFI.Location = new System.Drawing.Point(69, 60);
            this.panelFI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFI.Name = "panelFI";
            this.panelFI.Size = new System.Drawing.Size(245, 142);
            this.panelFI.TabIndex = 6;
            // 
            // panel1HUD
            // 
            this.panel1HUD.Controls.Add(this.lblCercados);
            this.panel1HUD.Controls.Add(this.lblStatus);
            this.panel1HUD.Controls.Add(this.btnAtualizar);
            this.panel1HUD.Controls.Add(this.lblJogadorDado);
            this.panel1HUD.Controls.Add(this.cmbDino);
            this.panel1HUD.Controls.Add(this.cmbCercado);
            this.panel1HUD.Controls.Add(this.btnJogarManual);
            this.panel1HUD.Controls.Add(this.lblMao);
            this.panel1HUD.Controls.Add(this.lblTurno);
            this.panel1HUD.Controls.Add(this.lblDado);
            this.panel1HUD.Controls.Add(this.lblJogador);
            this.panel1HUD.Location = new System.Drawing.Point(824, 34);
            this.panel1HUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1HUD.Name = "panel1HUD";
            this.panel1HUD.Size = new System.Drawing.Size(385, 549);
            this.panel1HUD.TabIndex = 7;
            // 
            // lblCercados
            // 
            this.lblCercados.AutoSize = true;
            this.lblCercados.Location = new System.Drawing.Point(219, 255);
            this.lblCercados.Name = "lblCercados";
            this.lblCercados.Size = new System.Drawing.Size(80, 16);
            this.lblCercados.TabIndex = 13;
            this.lblCercados.Text = "lblCercados";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 223);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "lblStatus";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(223, 464);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 50);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblJogadorDado
            // 
            this.lblJogadorDado.AutoSize = true;
            this.lblJogadorDado.Location = new System.Drawing.Point(23, 86);
            this.lblJogadorDado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJogadorDado.Name = "lblJogadorDado";
            this.lblJogadorDado.Size = new System.Drawing.Size(106, 16);
            this.lblJogadorDado.TabIndex = 7;
            this.lblJogadorDado.Text = "lblJogadorDado";
            // 
            // cmbDino
            // 
            this.cmbDino.BackColor = System.Drawing.Color.Red;
            this.cmbDino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDino.FormattingEnabled = true;
            this.cmbDino.Items.AddRange(new object[] {
            "Br",
            "Ep",
            "Et",
            "Pa",
            "Ti",
            "Tr"});
            this.cmbDino.Location = new System.Drawing.Point(28, 406);
            this.cmbDino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDino.Name = "cmbDino";
            this.cmbDino.Size = new System.Drawing.Size(159, 24);
            this.cmbDino.TabIndex = 5;
            // 
            // cmbCercado
            // 
            this.cmbCercado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCercado.FormattingEnabled = true;
            this.cmbCercado.Items.AddRange(new object[] {
            "CD",
            "FI",
            "IS",
            "MT",
            "PA",
            "RI",
            "RS"});
            this.cmbCercado.Location = new System.Drawing.Point(208, 406);
            this.cmbCercado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCercado.Name = "cmbCercado";
            this.cmbCercado.Size = new System.Drawing.Size(159, 24);
            this.cmbCercado.TabIndex = 6;
            // 
            // btnJogarManual
            // 
            this.btnJogarManual.Location = new System.Drawing.Point(43, 464);
            this.btnJogarManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogarManual.Name = "btnJogarManual";
            this.btnJogarManual.Size = new System.Drawing.Size(125, 50);
            this.btnJogarManual.TabIndex = 10;
            this.btnJogarManual.Text = "Jogar Manual";
            this.btnJogarManual.UseVisualStyleBackColor = true;
            this.btnJogarManual.Click += new System.EventHandler(this.btnJogarManual_Click);
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.Location = new System.Drawing.Point(24, 255);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(48, 16);
            this.lblMao.TabIndex = 4;
            this.lblMao.Text = "lblMao";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(24, 177);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(56, 16);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "lblTurno";
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Location = new System.Drawing.Point(24, 129);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(55, 16);
            this.lblDado.TabIndex = 1;
            this.lblDado.Text = "lblDado";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(24, 43);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(72, 16);
            this.lblJogador.TabIndex = 0;
            this.lblJogador.Text = "lblJogador";
            // 
            // panelRS
            // 
            this.panelRS.BackColor = System.Drawing.Color.Transparent;
            this.panelRS.Location = new System.Drawing.Point(516, 78);
            this.panelRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRS.Name = "panelRS";
            this.panelRS.Size = new System.Drawing.Size(153, 89);
            this.panelRS.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 657);
            this.Controls.Add(this.panelRS);
            this.Controls.Add(this.panelCD);
            this.Controls.Add(this.panel1HUD);
            this.Controls.Add(this.panelFI);
            this.Controls.Add(this.panelRI);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelIS);
            this.Controls.Add(this.panelPA);
            this.Controls.Add(this.panelTabu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmJogo";
            this.Text = "FrmJogo";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTabu)).EndInit();
            this.panel1HUD.ResumeLayout(false);
            this.panel1HUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox panelTabu;
        private System.Windows.Forms.Panel panelPA;
        private System.Windows.Forms.Panel panelIS;
        private System.Windows.Forms.Panel panelMT;
        private System.Windows.Forms.Panel panelRI;
        private System.Windows.Forms.Panel panelCD;
        private System.Windows.Forms.Panel panelFI;
        private System.Windows.Forms.Panel panel1HUD;
        private System.Windows.Forms.Label lblMao;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Button btnJogarManual;
        private System.Windows.Forms.ComboBox cmbCercado;
        private System.Windows.Forms.ComboBox cmbDino;
        private System.Windows.Forms.Panel panelRS;
        private System.Windows.Forms.Label lblJogadorDado;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCercados;
        private System.Windows.Forms.Timer timer1;
    }
}