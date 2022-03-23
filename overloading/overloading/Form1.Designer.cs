namespace overloading
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
            this.txbClear = new System.Windows.Forms.TextBox();
            this.btnNameAge = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbClear
            // 
            this.txbClear.Enabled = false;
            this.txbClear.Location = new System.Drawing.Point(128, 27);
            this.txbClear.Multiline = true;
            this.txbClear.Name = "txbClear";
            this.txbClear.Size = new System.Drawing.Size(327, 240);
            this.txbClear.TabIndex = 0;
            // 
            // btnNameAge
            // 
            this.btnNameAge.Location = new System.Drawing.Point(128, 290);
            this.btnNameAge.Name = "btnNameAge";
            this.btnNameAge.Size = new System.Drawing.Size(92, 23);
            this.btnNameAge.TabIndex = 1;
            this.btnNameAge.Text = "name + age";
            this.btnNameAge.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(243, 290);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "name";
            this.btnName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 455);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnNameAge);
            this.Controls.Add(this.txbClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbClear;
        private System.Windows.Forms.Button btnNameAge;
        private System.Windows.Forms.Button btnName;
    }
}

