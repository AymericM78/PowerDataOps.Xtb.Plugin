
namespace PowerDataOps.Xtb.Plugin
{
    partial class PowerDataOpsPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerDataOpsPluginControl));
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtScripting = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.Image = ((System.Drawing.Image)(resources.GetObject("btnInstall.Image")));
            this.btnInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstall.Location = new System.Drawing.Point(19, 11);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(307, 74);
            this.btnInstall.TabIndex = 5;
            this.btnInstall.Text = "Install / Upgrade Pshell Module";
            this.btnInstall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc.Image")));
            this.btnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.Location = new System.Drawing.Point(349, 11);
            this.btnDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(307, 74);
            this.btnDoc.TabIndex = 7;
            this.btnDoc.Text = "Check documentation";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(680, 11);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(307, 74);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New script";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtScripting
            // 
            this.txtScripting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.txtScripting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScripting.ForeColor = System.Drawing.SystemColors.Window;
            this.txtScripting.Location = new System.Drawing.Point(275, 90);
            this.txtScripting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScripting.Multiline = true;
            this.txtScripting.Name = "txtScripting";
            this.txtScripting.Size = new System.Drawing.Size(711, 304);
            this.txtScripting.TabIndex = 9;
            // 
            // btnExecute
            // 
            this.btnExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnExecute.Image")));
            this.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecute.Location = new System.Drawing.Point(680, 400);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(307, 74);
            this.btnExecute.TabIndex = 10;
            this.btnExecute.Text = "Run PowerShell";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 370);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PowerDataOpsPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtScripting);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnInstall);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PowerDataOpsPluginControl";
            this.Size = new System.Drawing.Size(1007, 482);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtScripting;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
