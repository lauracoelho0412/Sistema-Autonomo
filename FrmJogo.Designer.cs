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
            ((System.ComponentModel.ISupportInitialize)(this.pbTabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTabuleiro
            // 
            this.pbTabuleiro.Image = global::Sistema_Autonomo_Predadores.Properties.Resources.tabuleiro1;
            this.pbTabuleiro.Location = new System.Drawing.Point(-4, 12);
            this.pbTabuleiro.Name = "pbTabuleiro";
            this.pbTabuleiro.Size = new System.Drawing.Size(750, 610);
            this.pbTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTabuleiro.TabIndex = 0;
            this.pbTabuleiro.TabStop = false;
            this.pbTabuleiro.Click += new System.EventHandler(this.pbTabuleiro_Click);
            // 
            // panelCD
            // 
            this.panelCD.BackColor = System.Drawing.Color.Transparent;
            this.panelCD.Location = new System.Drawing.Point(53, 424);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(251, 141);
            this.panelCD.TabIndex = 1;
            // 
            // panelRS
            // 
            this.panelRS.BackColor = System.Drawing.Color.Transparent;
            this.panelRS.Location = new System.Drawing.Point(529, 415);
            this.panelRS.Name = "panelRS";
            this.panelRS.Size = new System.Drawing.Size(185, 100);
            this.panelRS.TabIndex = 2;
            // 
            // panelMT
            // 
            this.panelMT.BackColor = System.Drawing.Color.Transparent;
            this.panelMT.Location = new System.Drawing.Point(53, 246);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(188, 113);
            this.panelMT.TabIndex = 3;
            // 
            // panelIS
            // 
            this.panelIS.BackColor = System.Drawing.Color.Transparent;
            this.panelIS.Location = new System.Drawing.Point(303, 180);
            this.panelIS.Name = "panelIS";
            this.panelIS.Size = new System.Drawing.Size(150, 84);
            this.panelIS.TabIndex = 4;
            this.panelIS.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIS_Paint);
            // 
            // panelPA
            // 
            this.panelPA.BackColor = System.Drawing.Color.Transparent;
            this.panelPA.Location = new System.Drawing.Point(446, 270);
            this.panelPA.Name = "panelPA";
            this.panelPA.Size = new System.Drawing.Size(246, 107);
            this.panelPA.TabIndex = 5;
            // 
            // panelFI
            // 
            this.panelFI.BackColor = System.Drawing.Color.Transparent;
            this.panelFI.Location = new System.Drawing.Point(68, 46);
            this.panelFI.Name = "panelFI";
            this.panelFI.Size = new System.Drawing.Size(218, 143);
            this.panelFI.TabIndex = 6;
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 614);
            this.Controls.Add(this.panelFI);
            this.Controls.Add(this.panelPA);
            this.Controls.Add(this.panelIS);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelRS);
            this.Controls.Add(this.panelCD);
            this.Controls.Add(this.pbTabuleiro);
            this.Name = "FrmJogo";
            this.Text = "FrmJogo";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabuleiro)).EndInit();
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
    }
}