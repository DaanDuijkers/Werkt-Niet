namespace Priemgetalen
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
            this.lbPrimeNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPrimeNumbers
            // 
            this.lbPrimeNumbers.FormattingEnabled = true;
            this.lbPrimeNumbers.ItemHeight = 16;
            this.lbPrimeNumbers.Location = new System.Drawing.Point(12, 9);
            this.lbPrimeNumbers.Name = "lbPrimeNumbers";
            this.lbPrimeNumbers.Size = new System.Drawing.Size(124, 500);
            this.lbPrimeNumbers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 516);
            this.Controls.Add(this.lbPrimeNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPrimeNumbers;
    }
}

