namespace Sistema_Autonomo_Predadores
{
    partial class PgInicial
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
            this.btnLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLobby
            // 
            this.btnLobby.Location = new System.Drawing.Point(316, 90);
            this.btnLobby.Name = "btnLobby";
            this.btnLobby.Size = new System.Drawing.Size(157, 60);
            this.btnLobby.TabIndex = 0;
            this.btnLobby.Text = "Lobby";
            this.btnLobby.UseVisualStyleBackColor = true;
            this.btnLobby.Click += new System.EventHandler(this.btnLobby_Click);
            // 
            // PgInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLobby);
            this.Name = "PgInicial";
            this.Text = "Início";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLobby;
    }
}