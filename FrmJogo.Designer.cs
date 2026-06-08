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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogo));
            this.panelTabu = new System.Windows.Forms.PictureBox();
            this.panelPA = new System.Windows.Forms.Panel();
            this.panelIS = new System.Windows.Forms.Panel();
            this.panelMT = new System.Windows.Forms.Panel();
            this.panelRI = new System.Windows.Forms.Panel();
            this.panelCD = new System.Windows.Forms.Panel();
            this.panelFI = new System.Windows.Forms.Panel();
            this.panel1HUD = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCercados = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMao = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTurno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblJogadorDado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.panelRS = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelTabu)).BeginInit();
            this.panel1HUD.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelPA.BackColor = System.Drawing.Color.Black;
            this.panelPA.Location = new System.Drawing.Point(58, 432);
            this.panelPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPA.Name = "panelPA";
            this.panelPA.Size = new System.Drawing.Size(221, 143);
            this.panelPA.TabIndex = 1;
            // 
            // panelIS
            // 
            this.panelIS.BackColor = System.Drawing.Color.Black;
            this.panelIS.Location = new System.Drawing.Point(528, 418);
            this.panelIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIS.Name = "panelIS";
            this.panelIS.Size = new System.Drawing.Size(131, 110);
            this.panelIS.TabIndex = 2;
            // 
            // panelMT
            // 
            this.panelMT.BackColor = System.Drawing.Color.Black;
            this.panelMT.Location = new System.Drawing.Point(39, 247);
            this.panelMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(212, 124);
            this.panelMT.TabIndex = 3;
            // 
            // panelRI
            // 
            this.panelRI.BackColor = System.Drawing.Color.Black;
            this.panelRI.Location = new System.Drawing.Point(288, 239);
            this.panelRI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRI.Name = "panelRI";
            this.panelRI.Size = new System.Drawing.Size(104, 175);
            this.panelRI.TabIndex = 4;
            // 
            // panelCD
            // 
            this.panelCD.BackColor = System.Drawing.Color.Black;
            this.panelCD.Location = new System.Drawing.Point(413, 246);
            this.panelCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(253, 151);
            this.panelCD.TabIndex = 5;
            // 
            // panelFI
            // 
            this.panelFI.BackColor = System.Drawing.Color.Black;
            this.panelFI.Location = new System.Drawing.Point(47, 38);
            this.panelFI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFI.Name = "panelFI";
            this.panelFI.Size = new System.Drawing.Size(245, 142);
            this.panelFI.TabIndex = 6;
            // 
            // panel1HUD
            // 
            this.panel1HUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1HUD.BackgroundImage")));
            this.panel1HUD.Controls.Add(this.panel7);
            this.panel1HUD.Controls.Add(this.panel6);
            this.panel1HUD.Controls.Add(this.panel5);
            this.panel1HUD.Controls.Add(this.panel4);
            this.panel1HUD.Controls.Add(this.panel3);
            this.panel1HUD.Controls.Add(this.panel2);
            this.panel1HUD.Controls.Add(this.panel1);
            this.panel1HUD.Controls.Add(this.lblPartida);
            this.panel1HUD.Location = new System.Drawing.Point(824, 14);
            this.panel1HUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1HUD.Name = "panel1HUD";
            this.panel1HUD.Size = new System.Drawing.Size(609, 626);
            this.panel1HUD.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.lblCercados);
            this.panel7.Location = new System.Drawing.Point(313, 398);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 225);
            this.panel7.TabIndex = 15;
            // 
            // lblCercados
            // 
            this.lblCercados.AutoSize = true;
            this.lblCercados.BackColor = System.Drawing.Color.SandyBrown;
            this.lblCercados.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCercados.ForeColor = System.Drawing.Color.Purple;
            this.lblCercados.Location = new System.Drawing.Point(75, 14);
            this.lblCercados.Name = "lblCercados";
            this.lblCercados.Size = new System.Drawing.Size(110, 31);
            this.lblCercados.TabIndex = 1;
            this.lblCercados.Text = "Cercados";
            this.lblCercados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lblMao);
            this.panel6.Location = new System.Drawing.Point(12, 288);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 309);
            this.panel6.TabIndex = 14;
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.BackColor = System.Drawing.Color.SandyBrown;
            this.lblMao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMao.ForeColor = System.Drawing.Color.Purple;
            this.lblMao.Location = new System.Drawing.Point(97, 14);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(81, 41);
            this.lblMao.TabIndex = 2;
            this.lblMao.Text = "Mão";
            this.lblMao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lblStatus);
            this.panel5.Location = new System.Drawing.Point(312, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 99);
            this.panel5.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.SandyBrown;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Purple;
            this.lblStatus.Location = new System.Drawing.Point(100, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 41);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lblDado);
            this.panel4.Location = new System.Drawing.Point(312, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 99);
            this.panel4.TabIndex = 12;
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.BackColor = System.Drawing.Color.SandyBrown;
            this.lblDado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado.ForeColor = System.Drawing.Color.Purple;
            this.lblDado.Location = new System.Drawing.Point(95, 14);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(93, 41);
            this.lblDado.TabIndex = 1;
            this.lblDado.Text = "Dado";
            this.lblDado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblTurno);
            this.panel3.Location = new System.Drawing.Point(12, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 99);
            this.panel3.TabIndex = 9;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.Color.Purple;
            this.lblTurno.Location = new System.Drawing.Point(93, 14);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(100, 41);
            this.lblTurno.TabIndex = 1;
            this.lblTurno.Text = "Turno";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblJogadorDado);
            this.panel2.Location = new System.Drawing.Point(312, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 99);
            this.panel2.TabIndex = 11;
            // 
            // lblJogadorDado
            // 
            this.lblJogadorDado.AutoSize = true;
            this.lblJogadorDado.BackColor = System.Drawing.Color.SandyBrown;
            this.lblJogadorDado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorDado.ForeColor = System.Drawing.Color.Purple;
            this.lblJogadorDado.Location = new System.Drawing.Point(70, 14);
            this.lblJogadorDado.Name = "lblJogadorDado";
            this.lblJogadorDado.Size = new System.Drawing.Size(265, 38);
            this.lblJogadorDado.TabIndex = 1;
            this.lblJogadorDado.Text = "Jogador com Dado";
            this.lblJogadorDado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblJogador);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 99);
            this.panel1.TabIndex = 8;
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.SandyBrown;
            this.lblJogador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.ForeColor = System.Drawing.Color.Purple;
            this.lblJogador.Location = new System.Drawing.Point(88, 14);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(133, 41);
            this.lblJogador.TabIndex = 0;
            this.lblJogador.Text = "Jogador";
            this.lblJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPartida.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartida.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblPartida.Location = new System.Drawing.Point(18, 11);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(205, 59);
            this.lblPartida.TabIndex = 10;
            this.lblPartida.Text = "PARTIDA";
            this.lblPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPartida.Click += new System.EventHandler(this.lblPartida_Click);
            // 
            // panelRS
            // 
            this.panelRS.BackColor = System.Drawing.Color.Black;
            this.panelRS.Location = new System.Drawing.Point(459, 54);
            this.panelRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRS.Name = "panelRS";
            this.panelRS.Size = new System.Drawing.Size(111, 89);
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
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1445, 657);
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panelRS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblCercados;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMao;
        private System.Windows.Forms.Label lblJogadorDado;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}