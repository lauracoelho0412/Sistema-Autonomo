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
            this.panelTabu = new System.Windows.Forms.PictureBox();
            this.panelPA = new System.Windows.Forms.Panel();
            this.panelIS = new System.Windows.Forms.Panel();
            this.panelMT = new System.Windows.Forms.Panel();
            this.panelRI = new System.Windows.Forms.Panel();
            this.panelCD = new System.Windows.Forms.Panel();
            this.panelFI = new System.Windows.Forms.Panel();
            this.panel1HUD = new System.Windows.Forms.Panel();
            this.cmbDino = new System.Windows.Forms.ComboBox();
            this.cmbCercado = new System.Windows.Forms.ComboBox();
            this.lblMao = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDado = new System.Windows.Forms.Label();
            this.lblJogadorDado = new System.Windows.Forms.Label();
            this.btnJogarManual = new System.Windows.Forms.Button();
            this.panelRS = new System.Windows.Forms.Panel();
            this.lblJDado = new System.Windows.Forms.Label();
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
            this.panel1HUD.Controls.Add(this.lblJDado);
            this.panel1HUD.Controls.Add(this.cmbDino);
            this.panel1HUD.Controls.Add(this.cmbCercado);
            this.panel1HUD.Controls.Add(this.lblMao);
            this.panel1HUD.Controls.Add(this.lblTurno);
            this.panel1HUD.Controls.Add(this.lblDado);
            this.panel1HUD.Controls.Add(this.lblJogadorDado);
            this.panel1HUD.Location = new System.Drawing.Point(618, 28);
            this.panel1HUD.Margin = new System.Windows.Forms.Padding(2);
            this.panel1HUD.Name = "panel1HUD";
            this.panel1HUD.Size = new System.Drawing.Size(170, 464);
            this.panel1HUD.TabIndex = 7;
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
            this.cmbDino.Location = new System.Drawing.Point(20, 305);
            this.cmbDino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDino.Name = "cmbDino";
            this.cmbDino.Size = new System.Drawing.Size(120, 21);
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
            this.cmbCercado.Location = new System.Drawing.Point(20, 341);
            this.cmbCercado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCercado.Name = "cmbCercado";
            this.cmbCercado.Size = new System.Drawing.Size(120, 21);
            this.cmbCercado.TabIndex = 6;
            // 
            // lblMao
            // 
            this.lblMao.AutoSize = true;
            this.lblMao.Location = new System.Drawing.Point(18, 207);
            this.lblMao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMao.Name = "lblMao";
            this.lblMao.Size = new System.Drawing.Size(35, 13);
            this.lblMao.TabIndex = 4;
            this.lblMao.Text = "label4";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(18, 144);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "label2";
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Location = new System.Drawing.Point(18, 105);
            this.lblDado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(35, 13);
            this.lblDado.TabIndex = 1;
            this.lblDado.Text = "label1";
            // 
            // lblJogadorDado
            // 
            this.lblJogadorDado.AutoSize = true;
            this.lblJogadorDado.Location = new System.Drawing.Point(18, 35);
            this.lblJogadorDado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogadorDado.Name = "lblJogadorDado";
            this.lblJogadorDado.Size = new System.Drawing.Size(35, 13);
            this.lblJogadorDado.TabIndex = 0;
            this.lblJogadorDado.Text = "label1";
            // 
            // btnJogarManual
            // 
            this.btnJogarManual.Location = new System.Drawing.Point(651, 423);
            this.btnJogarManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogarManual.Name = "btnJogarManual";
            this.btnJogarManual.Size = new System.Drawing.Size(94, 41);
            this.btnJogarManual.TabIndex = 10;
            this.btnJogarManual.Text = "Jogar Manual";
            this.btnJogarManual.UseVisualStyleBackColor = true;
            this.btnJogarManual.Click += new System.EventHandler(this.btnJogarManual_Click);
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
            // lblJDado
            // 
            this.lblJDado.AutoSize = true;
            this.lblJDado.Location = new System.Drawing.Point(17, 70);
            this.lblJDado.Name = "lblJDado";
            this.lblJDado.Size = new System.Drawing.Size(35, 13);
            this.lblJDado.TabIndex = 7;
            this.lblJDado.Text = "label1";
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 534);
            this.Controls.Add(this.panelRS);
            this.Controls.Add(this.panelCD);
            this.Controls.Add(this.btnJogarManual);
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
        private System.Windows.Forms.Label lblJogadorDado;
        private System.Windows.Forms.Button btnJogarManual;
        private System.Windows.Forms.ComboBox cmbCercado;
        private System.Windows.Forms.ComboBox cmbDino;
        private System.Windows.Forms.Panel panelRS;
        private System.Windows.Forms.Label lblJDado;
    }
}