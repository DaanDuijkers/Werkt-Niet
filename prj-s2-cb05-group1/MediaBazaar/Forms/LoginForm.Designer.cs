namespace MediaBazaar
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.userLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.fireDuckLogoPictureBox = new System.Windows.Forms.PictureBox();
			this.btnManagerForm = new System.Windows.Forms.Button();
			this.btnHrForm = new System.Windows.Forms.Button();
			this.btnPersonalDetailsForm = new System.Windows.Forms.Button();
			this.btnShopFloorForm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fireDuckLogoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logoPictureBox.Image = global::MediaBazaar.Properties.Resources.logo;
			this.logoPictureBox.Location = new System.Drawing.Point(265, 69);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(264, 191);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point(265, 288);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(33, 15);
			this.userLabel.TabIndex = 1;
			this.userLabel.Text = "User:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(265, 332);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(60, 15);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(265, 306);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(264, 23);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTextBox_KeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(265, 350);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(264, 23);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(265, 379);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(264, 24);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// fireDuckLogoPictureBox
			// 
			this.fireDuckLogoPictureBox.Image = global::MediaBazaar.Properties.Resources.fire_duck_logo;
			this.fireDuckLogoPictureBox.Location = new System.Drawing.Point(700, 392);
			this.fireDuckLogoPictureBox.Name = "fireDuckLogoPictureBox";
			this.fireDuckLogoPictureBox.Size = new System.Drawing.Size(88, 114);
			this.fireDuckLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.fireDuckLogoPictureBox.TabIndex = 6;
			this.fireDuckLogoPictureBox.TabStop = false;
			// 
			// btnManagerForm
			// 
			this.btnManagerForm.Location = new System.Drawing.Point(604, 204);
			this.btnManagerForm.Name = "btnManagerForm";
			this.btnManagerForm.Size = new System.Drawing.Size(150, 23);
			this.btnManagerForm.TabIndex = 7;
			this.btnManagerForm.Text = "ManagerForm";
			this.btnManagerForm.UseVisualStyleBackColor = true;
			this.btnManagerForm.Click += new System.EventHandler(this.btnManagerForm_Click);
			// 
			// btnHrForm
			// 
			this.btnHrForm.Location = new System.Drawing.Point(604, 237);
			this.btnHrForm.Name = "btnHrForm";
			this.btnHrForm.Size = new System.Drawing.Size(150, 23);
			this.btnHrForm.TabIndex = 8;
			this.btnHrForm.Text = "HrForm";
			this.btnHrForm.UseVisualStyleBackColor = true;
			this.btnHrForm.Click += new System.EventHandler(this.btnHrForm_Click);
			// 
			// btnPersonalDetailsForm
			// 
			this.btnPersonalDetailsForm.Location = new System.Drawing.Point(604, 266);
			this.btnPersonalDetailsForm.Name = "btnPersonalDetailsForm";
			this.btnPersonalDetailsForm.Size = new System.Drawing.Size(150, 23);
			this.btnPersonalDetailsForm.TabIndex = 9;
			this.btnPersonalDetailsForm.Text = "PersonalDetailsForm";
			this.btnPersonalDetailsForm.UseVisualStyleBackColor = true;
			this.btnPersonalDetailsForm.Click += new System.EventHandler(this.btnPersonalDetailsForm_Click);
			// 
			// btnShopFloorForm
			// 
			this.btnShopFloorForm.Location = new System.Drawing.Point(604, 295);
			this.btnShopFloorForm.Name = "btnShopFloorForm";
			this.btnShopFloorForm.Size = new System.Drawing.Size(150, 23);
			this.btnShopFloorForm.TabIndex = 10;
			this.btnShopFloorForm.Text = "ShopFloorForm";
			this.btnShopFloorForm.UseVisualStyleBackColor = true;
			this.btnShopFloorForm.Click += new System.EventHandler(this.btnShopFloorForm_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 518);
			this.Controls.Add(this.btnShopFloorForm);
			this.Controls.Add(this.btnPersonalDetailsForm);
			this.Controls.Add(this.btnHrForm);
			this.Controls.Add(this.btnManagerForm);
			this.Controls.Add(this.fireDuckLogoPictureBox);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.logoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MediaBazaar Login";
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fireDuckLogoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.PictureBox fireDuckLogoPictureBox;
		private System.Windows.Forms.Button btnManagerForm;
		private System.Windows.Forms.Button btnHrForm;
		private System.Windows.Forms.Button btnPersonalDetailsForm;
		private System.Windows.Forms.Button btnShopFloorForm;
	}
}

