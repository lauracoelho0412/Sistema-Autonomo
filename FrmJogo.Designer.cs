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
            this.lblJogadorDado = new System.Windows.Forms.Label();
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
            this.panelTabu.Location = new System.Drawing.Point(18, 11);
            this.panelTabu.Margin = new System.Windows.Forms.Padding(2);
            this.panelTabu.Name = "panelTabu";
            this.panelTabu.Size = new System.Drawing.Size(596, 509);
            this.panelTabu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelTabu.TabIndex = 0;
            this.panelTabu.TabStop = false;
            // 
            // panelPA
            // 
            this.panelPA.BackColor = System.Drawing.Color.Transparent;
            this.panelPA.Location = new System.Drawing.Point(64, 358);
            this.panelPA.Margin = new System.Windows.Forms.Padding(2);
            this.panelPA.Name = "panelPA";
            this.panelPA.Size = new System.Drawing.Size(166, 116);
            this.panelPA.TabIndex = 1;
            // 
            // panelIS
            // 
            this.panelIS.BackColor = System.Drawing.Color.Transparent;
            this.panelIS.Location = new System.Drawing.Point(447, 340);
            this.panelIS.Margin = new System.Windows.Forms.Padding(2);
            this.panelIS.Name = "panelIS";
            this.panelIS.Size = new System.Drawing.Size(119, 89);
            this.panelIS.TabIndex = 2;
            // 
            // panelMT
            // 
            this.panelMT.BackColor = System.Drawing.Color.Transparent;
            this.panelMT.Location = new System.Drawing.Point(52, 209);
            this.panelMT.Margin = new System.Windows.Forms.Padding(2);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(159, 101);
            this.panelMT.TabIndex = 3;
            // 
            // panelRI
            // 
            this.panelRI.BackColor = System.Drawing.Color.Transparent;
            this.panelRI.Location = new System.Drawing.Point(261, 195);
            this.panelRI.Margin = new System.Windows.Forms.Padding(2);
            this.panelRI.Name = "panelRI";
            this.panelRI.Size = new System.Drawing.Size(78, 142);
            this.panelRI.TabIndex = 4;
            // 
            // panelCD
            // 
            this.panelCD.BackColor = System.Drawing.Color.Transparent;
            this.panelCD.Location = new System.Drawing.Point(374, 200);
            this.panelCD.Margin = new System.Windows.Forms.Padding(2);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(193, 123);
            this.panelCD.TabIndex = 5;
            // 
            // panelFI
            // 
            this.panelFI.BackColor = System.Drawing.Color.Transparent;
            this.panelFI.Location = new System.Drawing.Point(52, 49);
            this.panelFI.Margin = new System.Windows.Forms.Padding(2);
            this.panelFI.Name = "panelFI";
            this.panelFI.Size = new System.Drawing.Size(184, 115);
            this.panelFI.TabIndex = 6;
            // 
            // panel1HUD
            // 
            this.panel1HUD.Controls.Add(this.lblCercados);
            this.panel1HUD.Controls.Add(this.lblStatus);
            this.panel1HUD.Controls.Add(this.lblJogadorDado);
            this.panel1HUD.Controls.Add(this.lblMao);
            this.panel1HUD.Controls.Add(this.lblTurno);
            this.panel1HUD.Controls.Add(this.lblDado);
            this.panel1HUD.Controls.Add(this.lblJogador);
            this.panel1HUD.Location = new System.Drawing.Point(618, 28);
            this.panel1HUD.Margin = new System.Windows.Forms.Padding(2);
            this.panel1HUD.Name = "panel1HUD";
            this.panel1HUD.Size = new System.Drawing.Size(289, 446);
            this.panel1HUD.TabIndex = 7;
            // 
            // lblCercados
            // 
            this.lblCercados.AutoSize = true;
            this.lblCercados.Location = new System.Drawing.Point(164, 207);
            this.lblCercados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCercados.Name = "lblCercados";
            this.lblCercados.Size = new System.Drawing.Size(62, 13);
            this.lblCercados.TabIndex = 13;
            this.lblCercados.Text = "lblCercados";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 181);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "lblStatus";
            // 
            // lblJogadorDado
            // 
            this.lblJogadorDado.AutoSize = true;
            this.lblJogadorDado.Location = new System.Drawing.Point(17, 70);
            this.lblJogadorDado.Name = "lblJogadorDado";
            this.lblJogadorDado.Size = new System.Drawing.Size(81, 13);
            this.lblJogadorDado.TabIndex = 7;
            this.lblJogadorDado.Text = "lblJogadorDado";
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.Location = new System.Drawing.Point(18, 207);
            this.lblMao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(38, 13);
            this.lblMao.TabIndex = 4;
            this.lblMao.Text = "lblMao";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(18, 144);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(45, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "lblTurno";
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Location = new System.Drawing.Point(18, 105);
            this.lblDado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(43, 13);
            this.lblDado.TabIndex = 1;
            this.lblDado.Text = "lblDado";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(18, 35);
            this.lblJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(55, 13);
            this.lblJogador.TabIndex = 0;
            this.lblJogador.Text = "lblJogador";
            // 
            // panelRS
            // 
            this.panelRS.BackColor = System.Drawing.Color.Transparent;
            this.panelRS.Location = new System.Drawing.Point(387, 63);
            this.panelRS.Margin = new System.Windows.Forms.Padding(2);
            this.panelRS.Name = "panelRS";
            this.panelRS.Size = new System.Drawing.Size(115, 72);
            this.panelRS.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 534);
            this.Controls.Add(this.panelRS);
            this.Controls.Add(this.panelCD);
            this.Controls.Add(this.panel1HUD);
            this.Controls.Add(this.panelFI);
            this.Controls.Add(this.panelRI);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelIS);
            this.Controls.Add(this.panelPA);
            this.Controls.Add(this.panelTabu);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Panel panelRS;
        private System.Windows.Forms.Label lblJogadorDado;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCercados;
        private System.Windows.Forms.Timer timer1;
    }
}