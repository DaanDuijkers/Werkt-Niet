namespace carStore
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
            this.gbCreateCar = new System.Windows.Forms.GroupBox();
            this.btnMakeCar = new System.Windows.Forms.Button();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbMake = new System.Windows.Forms.TextBox();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.gbInventory = new System.Windows.Forms.GroupBox();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbCreateCar.SuspendLayout();
            this.gbInventory.SuspendLayout();
            this.grpCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreateCar
            // 
            this.gbCreateCar.BackColor = System.Drawing.SystemColors.Control;
            this.gbCreateCar.Controls.Add(this.btnMakeCar);
            this.gbCreateCar.Controls.Add(this.txbPrice);
            this.gbCreateCar.Controls.Add(this.txbMake);
            this.gbCreateCar.Controls.Add(this.txbModel);
            this.gbCreateCar.Controls.Add(this.lblPrice);
            this.gbCreateCar.Controls.Add(this.Model);
            this.gbCreateCar.Controls.Add(this.lblMake);
            this.gbCreateCar.Location = new System.Drawing.Point(12, 12);
            this.gbCreateCar.Name = "gbCreateCar";
            this.gbCreateCar.Size = new System.Drawing.Size(200, 171);
            this.gbCreateCar.TabIndex = 0;
            this.gbCreateCar.TabStop = false;
            this.gbCreateCar.Text = "Create a car";
            // 
            // btnMakeCar
            // 
            this.btnMakeCar.Location = new System.Drawing.Point(48, 120);
            this.btnMakeCar.Name = "btnMakeCar";
            this.btnMakeCar.Size = new System.Drawing.Size(96, 24);
            this.btnMakeCar.TabIndex = 1;
            this.btnMakeCar.Text = "Make a car";
            this.btnMakeCar.UseVisualStyleBackColor = true;
            this.btnMakeCar.Click += new System.EventHandler(this.btnMakeCar_Click);
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(62, 79);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(132, 22);
            this.txbPrice.TabIndex = 2;
            // 
            // txbMake
            // 
            this.txbMake.Location = new System.Drawing.Point(62, 23);
            this.txbMake.Name = "txbMake";
            this.txbMake.Size = new System.Drawing.Size(132, 22);
            this.txbMake.TabIndex = 2;
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(62, 51);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(132, 22);
            this.txbModel.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(6, 82);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.BackColor = System.Drawing.SystemColors.Control;
            this.Model.Location = new System.Drawing.Point(6, 54);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(50, 17);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.SystemColors.Control;
            this.lblMake.Location = new System.Drawing.Point(6, 26);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make:";
            // 
            // gbInventory
            // 
            this.gbInventory.BackColor = System.Drawing.SystemColors.Control;
            this.gbInventory.Controls.Add(this.lbInventory);
            this.gbInventory.Location = new System.Drawing.Point(235, 12);
            this.gbInventory.Name = "gbInventory";
            this.gbInventory.Size = new System.Drawing.Size(439, 492);
            this.gbInventory.TabIndex = 1;
            this.gbInventory.TabStop = false;
            this.gbInventory.Text = "Car inventory";
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.ItemHeight = 16;
            this.lbInventory.Location = new System.Drawing.Point(7, 26);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(426, 452);
            this.lbInventory.TabIndex = 0;
            // 
            // grpCart
            // 
            this.grpCart.BackColor = System.Drawing.SystemColors.Control;
            this.grpCart.Controls.Add(this.lbCart);
            this.grpCart.Location = new System.Drawing.Point(802, 12);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(427, 363);
            this.grpCart.TabIndex = 2;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Shopping cart";
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 16;
            this.lbCart.Location = new System.Drawing.Point(7, 26);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(414, 324);
            this.lbCart.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(680, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add to cart ->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(802, 381);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(76, 23);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(799, 418);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(74, 17);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(879, 418);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(48, 17);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "€ 0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 516);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.gbInventory);
            this.Controls.Add(this.gbCreateCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCreateCar.ResumeLayout(false);
            this.gbCreateCar.PerformLayout();
            this.gbInventory.ResumeLayout(false);
            this.grpCart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateCar;
        private System.Windows.Forms.Button btnMakeCar;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbMake;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.GroupBox gbInventory;
        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

