namespace Festival
{
    partial class FrmConnexion
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(134, 204);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(124, 32);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pseudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(158, 135);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(175, 20);
            this.txtMdp.TabIndex = 4;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(158, 75);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(175, 20);
            this.txtPseudo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.Location = new System.Drawing.Point(94, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Connexion";
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnexion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label label4;
    }
}