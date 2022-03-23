namespace MediaBazaar.Forms
{
    partial class HrForm
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
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Department = new System.Windows.Forms.ColumnHeader();
            this.Position = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxFilterDepartment = new System.Windows.Forms.ComboBox();
            this.lblFilterDepartment = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.cbxFilterPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAllEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Department,
            this.Position,
            this.columnHeader4});
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Location = new System.Drawing.Point(12, 47);
            this.lvEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(556, 502);
            this.lvEmployees.TabIndex = 0;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 25;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 25;
            // 
            // Department
            // 
            this.Department.Text = "Department";
            // 
            // Position
            // 
            this.Position.Text = "Position";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hours Worked";
            this.columnHeader4.Width = 90;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(574, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbxFilterDepartment
            // 
            this.cbxFilterDepartment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFilterDepartment.FormattingEnabled = true;
            this.cbxFilterDepartment.Location = new System.Drawing.Point(574, 123);
            this.cbxFilterDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFilterDepartment.Name = "cbxFilterDepartment";
            this.cbxFilterDepartment.Size = new System.Drawing.Size(211, 28);
            this.cbxFilterDepartment.TabIndex = 4;
            this.cbxFilterDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxFilterDepartment_SelectedIndexChanged);
            // 
            // lblFilterDepartment
            // 
            this.lblFilterDepartment.AutoSize = true;
            this.lblFilterDepartment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterDepartment.Location = new System.Drawing.Point(574, 101);
            this.lblFilterDepartment.Name = "lblFilterDepartment";
            this.lblFilterDepartment.Size = new System.Drawing.Size(214, 20);
            this.lblFilterDepartment.TabIndex = 5;
            this.lblFilterDepartment.Text = "Filter employee by department";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(632, 380);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add employee";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(632, 418);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete selected employee";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(592, 461);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(281, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "View or update the selected employee details ";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employees";
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchEmployee.Location = new System.Drawing.Point(574, 25);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(362, 20);
            this.lblSearchEmployee.TabIndex = 12;
            this.lblSearchEmployee.Text = "Search for an employee by id, first name or last name";
            // 
            // cbxFilterPosition
            // 
            this.cbxFilterPosition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxFilterPosition.FormattingEnabled = true;
            this.cbxFilterPosition.Location = new System.Drawing.Point(574, 200);
            this.cbxFilterPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFilterPosition.Name = "cbxFilterPosition";
            this.cbxFilterPosition.Size = new System.Drawing.Size(211, 28);
            this.cbxFilterPosition.TabIndex = 4;
            this.cbxFilterPosition.SelectedIndexChanged += new System.EventHandler(this.cbxFilterPosition_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(574, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter employee by position";
            // 
            // btnViewAllEmployees
            // 
            this.btnViewAllEmployees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllEmployees.Location = new System.Drawing.Point(574, 316);
            this.btnViewAllEmployees.Name = "btnViewAllEmployees";
            this.btnViewAllEmployees.Size = new System.Drawing.Size(184, 41);
            this.btnViewAllEmployees.TabIndex = 13;
            this.btnViewAllEmployees.Text = "View all employees";
            this.btnViewAllEmployees.UseVisualStyleBackColor = true;
            this.btnViewAllEmployees.Click += new System.EventHandler(this.btnViewAllEmployees_Click);
            // 
            // HrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 563);
            this.Controls.Add(this.btnViewAllEmployees);
            this.Controls.Add(this.lblSearchEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilterDepartment);
            this.Controls.Add(this.cbxFilterPosition);
            this.Controls.Add(this.cbxFilterDepartment);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HrForm";
            this.Text = "HrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxFilterDepartment;
        private System.Windows.Forms.Label lblFilterDepartment;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.ComboBox cbxFilterPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllEmployees;
    }
}
