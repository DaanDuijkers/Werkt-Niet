namespace DierentuinAdmin
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
            this.cmbRead = new System.Windows.Forms.ComboBox();
            this.gvRead = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRead)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRead
            // 
            this.cmbRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRead.FormattingEnabled = true;
            this.cmbRead.Location = new System.Drawing.Point(12, 12);
            this.cmbRead.Name = "cmbRead";
            this.cmbRead.Size = new System.Drawing.Size(369, 30);
            this.cmbRead.TabIndex = 0;
            this.cmbRead.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // gvRead
            // 
            this.gvRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRead.Location = new System.Drawing.Point(12, 48);
            this.gvRead.Name = "gvRead";
            this.gvRead.RowTemplate.Height = 24;
            this.gvRead.Size = new System.Drawing.Size(369, 449);
            this.gvRead.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 509);
            this.Controls.Add(this.gvRead);
            this.Controls.Add(this.cmbRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRead;
        private System.Windows.Forms.DataGridView gvRead;
    }
}

