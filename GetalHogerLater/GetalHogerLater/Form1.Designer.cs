namespace GetalHogerLater
{
    partial class Form1
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
            this.txbUitkomst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblKeer = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbUitkomst
            // 
            this.txbUitkomst.Location = new System.Drawing.Point(187, 102);
            this.txbUitkomst.Name = "txbUitkomst";
            this.txbUitkomst.Size = new System.Drawing.Size(100, 22);
            this.txbUitkomst.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(66, 109);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(0, 17);
            this.lblGetal1.TabIndex = 5;
            // 
            // lblKeer
            // 
            this.lblKeer.AutoSize = true;
            this.lblKeer.Location = new System.Drawing.Point(88, 107);
            this.lblKeer.Name = "lblKeer";
            this.lblKeer.Size = new System.Drawing.Size(14, 17);
            this.lblKeer.TabIndex = 6;
            this.lblKeer.Text = "x";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(120, 109);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(0, 17);
            this.lblGetal2.TabIndex = 7;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(187, 131);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 17);
            this.lblCorrect.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 424);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblKeer);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbUitkomst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUitkomst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblKeer;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblCorrect;
    }
}

