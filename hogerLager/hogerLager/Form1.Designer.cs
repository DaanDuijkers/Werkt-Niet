namespace hogerLager
{
    partial class hogerLager
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
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.btnHoger = new System.Windows.Forms.Button();
            this.btnLager = new System.Windows.Forms.Button();
            this.btnGoed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUitkomst.Location = new System.Drawing.Point(348, 56);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(168, 109);
            this.lblUitkomst.TabIndex = 0;
            // 
            // btnHoger
            // 
            this.btnHoger.Location = new System.Drawing.Point(52, 56);
            this.btnHoger.Name = "btnHoger";
            this.btnHoger.Size = new System.Drawing.Size(75, 23);
            this.btnHoger.TabIndex = 1;
            this.btnHoger.Text = "Hoger!";
            this.btnHoger.UseVisualStyleBackColor = true;
            this.btnHoger.Click += new System.EventHandler(this.btnHoger_Click);
            // 
            // btnLager
            // 
            this.btnLager.Location = new System.Drawing.Point(52, 98);
            this.btnLager.Name = "btnLager";
            this.btnLager.Size = new System.Drawing.Size(75, 23);
            this.btnLager.TabIndex = 2;
            this.btnLager.Text = "Lager!";
            this.btnLager.UseVisualStyleBackColor = true;
            this.btnLager.Click += new System.EventHandler(this.btnLager_Click);
            // 
            // btnGoed
            // 
            this.btnGoed.Location = new System.Drawing.Point(52, 142);
            this.btnGoed.Name = "btnGoed";
            this.btnGoed.Size = new System.Drawing.Size(75, 23);
            this.btnGoed.TabIndex = 3;
            this.btnGoed.Text = "Goed!";
            this.btnGoed.UseVisualStyleBackColor = true;
            this.btnGoed.Click += new System.EventHandler(this.btnGoed_Click);
            // 
            // hogerLager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 485);
            this.Controls.Add(this.btnGoed);
            this.Controls.Add(this.btnLager);
            this.Controls.Add(this.btnHoger);
            this.Controls.Add(this.lblUitkomst);
            this.Name = "hogerLager";
            this.Text = "Hoger/Lager";
            this.Load += new System.EventHandler(this.hogerLager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUitkomst;
        private System.Windows.Forms.Button btnHoger;
        private System.Windows.Forms.Button btnLager;
        private System.Windows.Forms.Button btnGoed;
    }
}

