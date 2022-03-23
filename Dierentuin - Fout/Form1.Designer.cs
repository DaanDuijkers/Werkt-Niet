namespace Dierentuin
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
            this.btnClick = new System.Windows.Forms.Button();
            this.tabDierentuin = new System.Windows.Forms.TabControl();
            this.tabDierentuinen = new System.Windows.Forms.TabPage();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txbDierentuinBudget = new System.Windows.Forms.TextBox();
            this.cmbFilterDierentuin = new System.Windows.Forms.ComboBox();
            this.btnFilterDierentuin = new System.Windows.Forms.Button();
            this.gvDierentuin = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDierentuinAdres = new System.Windows.Forms.Label();
            this.lblDierentuinNaam = new System.Windows.Forms.Label();
            this.txbDierentuinAdres = new System.Windows.Forms.TextBox();
            this.txbDierentuinNaam = new System.Windows.Forms.TextBox();
            this.tabDieren = new System.Windows.Forms.TabPage();
            this.gvDier = new System.Windows.Forms.DataGridView();
            this.cmbDierDierentuin = new System.Windows.Forms.ComboBox();
            this.lblDierEten = new System.Windows.Forms.Label();
            this.txbDierEten = new System.Windows.Forms.TextBox();
            this.lblDierentuinVanDier = new System.Windows.Forms.Label();
            this.lblGeslacht = new System.Windows.Forms.Label();
            this.cmbDierGeslacht = new System.Windows.Forms.ComboBox();
            this.lblDierLocatie = new System.Windows.Forms.Label();
            this.lblDierNaam = new System.Windows.Forms.Label();
            this.lblSoort = new System.Windows.Forms.Label();
            this.txbDierSoort = new System.Windows.Forms.TextBox();
            this.txbDierNaam = new System.Windows.Forms.TextBox();
            this.txbDierLocatie = new System.Windows.Forms.TextBox();
            this.tabWerkers = new System.Windows.Forms.TabPage();
            this.gvWerker = new System.Windows.Forms.DataGridView();
            this.dtpWerkerEindTijd = new System.Windows.Forms.DateTimePicker();
            this.dtpWerkerBeginTijd = new System.Windows.Forms.DateTimePicker();
            this.cmbWerkerDierentuin = new System.Windows.Forms.ComboBox();
            this.txbWerkerVoornaam = new System.Windows.Forms.TextBox();
            this.txbWerkerTussenvoegsel = new System.Windows.Forms.TextBox();
            this.txbWerkerAchternaam = new System.Windows.Forms.TextBox();
            this.txbWerkerWerkzaamheden = new System.Windows.Forms.TextBox();
            this.lblWerkerWerktBij = new System.Windows.Forms.Label();
            this.lblEindtijd = new System.Windows.Forms.Label();
            this.lblBegintijd = new System.Windows.Forms.Label();
            this.lblWerkzaamheden = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblTussenvoegsel = new System.Windows.Forms.Label();
            this.lblWerkerNaam = new System.Windows.Forms.Label();
            this.tabVerzorger = new System.Windows.Forms.TabPage();
            this.lblVerzorgerInvoer = new System.Windows.Forms.Label();
            this.lblVerzorgerID = new System.Windows.Forms.Label();
            this.lblZoekDierOp = new System.Windows.Forms.Label();
            this.btnVerzorgerSelectDier = new System.Windows.Forms.Button();
            this.txbVerzorgerID = new System.Windows.Forms.TextBox();
            this.gvVerzorger = new System.Windows.Forms.DataGridView();
            this.txbVerzorgerDier = new System.Windows.Forms.TextBox();
            this.lblDierVanVerzorger = new System.Windows.Forms.Label();
            this.dtpVerzorgerEindTijd = new System.Windows.Forms.DateTimePicker();
            this.dtpVerzorgerBeginTijd = new System.Windows.Forms.DateTimePicker();
            this.cmbVerzorgerDierentuin = new System.Windows.Forms.ComboBox();
            this.txbVerzorgerVoornaam = new System.Windows.Forms.TextBox();
            this.txbVerzorgerTussenvoegsel = new System.Windows.Forms.TextBox();
            this.txbVerzorgerAchternaam = new System.Windows.Forms.TextBox();
            this.txbVerzorgerWerkzaamheden = new System.Windows.Forms.TextBox();
            this.lblDierentuinVanVerzorger = new System.Windows.Forms.Label();
            this.lblVerzorgerEindTijd = new System.Windows.Forms.Label();
            this.lblVerzorgerBeginTijd = new System.Windows.Forms.Label();
            this.lblVerzorgerWerkzaamheden = new System.Windows.Forms.Label();
            this.lblVerzorgerAchternaam = new System.Windows.Forms.Label();
            this.lblVerzorgerTussenvoegsel = new System.Windows.Forms.Label();
            this.lblVerzorgerVoornaam = new System.Windows.Forms.Label();
            this.tabDierentuin.SuspendLayout();
            this.tabDierentuinen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDierentuin)).BeginInit();
            this.tabDieren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDier)).BeginInit();
            this.tabWerkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWerker)).BeginInit();
            this.tabVerzorger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVerzorger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(597, 531);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 31);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Click!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // tabDierentuin
            // 
            this.tabDierentuin.Controls.Add(this.tabDierentuinen);
            this.tabDierentuin.Controls.Add(this.tabDieren);
            this.tabDierentuin.Controls.Add(this.tabWerkers);
            this.tabDierentuin.Controls.Add(this.tabVerzorger);
            this.tabDierentuin.Location = new System.Drawing.Point(13, 12);
            this.tabDierentuin.Name = "tabDierentuin";
            this.tabDierentuin.SelectedIndex = 0;
            this.tabDierentuin.Size = new System.Drawing.Size(1242, 513);
            this.tabDierentuin.TabIndex = 6;
            this.tabDierentuin.SelectedIndexChanged += new System.EventHandler(this.tabDierentuin_SelectedIndexChanged);
            // 
            // tabDierentuinen
            // 
            this.tabDierentuinen.Controls.Add(this.lblBudget);
            this.tabDierentuinen.Controls.Add(this.txbDierentuinBudget);
            this.tabDierentuinen.Controls.Add(this.cmbFilterDierentuin);
            this.tabDierentuinen.Controls.Add(this.btnFilterDierentuin);
            this.tabDierentuinen.Controls.Add(this.gvDierentuin);
            this.tabDierentuinen.Controls.Add(this.lblDierentuinAdres);
            this.tabDierentuinen.Controls.Add(this.lblDierentuinNaam);
            this.tabDierentuinen.Controls.Add(this.txbDierentuinAdres);
            this.tabDierentuinen.Controls.Add(this.txbDierentuinNaam);
            this.tabDierentuinen.Location = new System.Drawing.Point(4, 25);
            this.tabDierentuinen.Name = "tabDierentuinen";
            this.tabDierentuinen.Padding = new System.Windows.Forms.Padding(3);
            this.tabDierentuinen.Size = new System.Drawing.Size(1234, 484);
            this.tabDierentuinen.TabIndex = 0;
            this.tabDierentuinen.Text = "Dierentuin";
            this.tabDierentuinen.UseVisualStyleBackColor = true;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(24, 306);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(122, 17);
            this.lblBudget.TabIndex = 55;
            this.lblBudget.Text = "DierentuinBudget:";
            // 
            // txbDierentuinBudget
            // 
            this.txbDierentuinBudget.Location = new System.Drawing.Point(23, 329);
            this.txbDierentuinBudget.Name = "txbDierentuinBudget";
            this.txbDierentuinBudget.Size = new System.Drawing.Size(273, 22);
            this.txbDierentuinBudget.TabIndex = 54;
            // 
            // cmbFilterDierentuin
            // 
            this.cmbFilterDierentuin.DisplayMember = "Id";
            this.cmbFilterDierentuin.FormattingEnabled = true;
            this.cmbFilterDierentuin.Location = new System.Drawing.Point(921, 187);
            this.cmbFilterDierentuin.Name = "cmbFilterDierentuin";
            this.cmbFilterDierentuin.Size = new System.Drawing.Size(190, 24);
            this.cmbFilterDierentuin.TabIndex = 53;
            this.cmbFilterDierentuin.ValueMember = "Id";
            // 
            // btnFilterDierentuin
            // 
            this.btnFilterDierentuin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDierentuin.Location = new System.Drawing.Point(1117, 181);
            this.btnFilterDierentuin.Name = "btnFilterDierentuin";
            this.btnFilterDierentuin.Size = new System.Drawing.Size(75, 30);
            this.btnFilterDierentuin.TabIndex = 52;
            this.btnFilterDierentuin.Text = "Filter";
            this.btnFilterDierentuin.UseVisualStyleBackColor = true;
            this.btnFilterDierentuin.Click += new System.EventHandler(this.btnFilterDierentuin_Click);
            // 
            // gvDierentuin
            // 
            this.gvDierentuin.AllowUserToAddRows = false;
            this.gvDierentuin.AllowUserToDeleteRows = false;
            this.gvDierentuin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDierentuin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naam,
            this.Adres});
            this.gvDierentuin.Location = new System.Drawing.Point(349, 59);
            this.gvDierentuin.Name = "gvDierentuin";
            this.gvDierentuin.ReadOnly = true;
            this.gvDierentuin.RowTemplate.Height = 24;
            this.gvDierentuin.Size = new System.Drawing.Size(532, 359);
            this.gvDierentuin.TabIndex = 48;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Naam
            // 
            this.Naam.DataPropertyName = "Naam";
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // lblDierentuinAdres
            // 
            this.lblDierentuinAdres.AutoSize = true;
            this.lblDierentuinAdres.Location = new System.Drawing.Point(20, 209);
            this.lblDierentuinAdres.Name = "lblDierentuinAdres";
            this.lblDierentuinAdres.Size = new System.Drawing.Size(117, 17);
            this.lblDierentuinAdres.TabIndex = 7;
            this.lblDierentuinAdres.Text = "Dierentuin adres:";
            // 
            // lblDierentuinNaam
            // 
            this.lblDierentuinNaam.AutoSize = true;
            this.lblDierentuinNaam.Location = new System.Drawing.Point(21, 114);
            this.lblDierentuinNaam.Name = "lblDierentuinNaam";
            this.lblDierentuinNaam.Size = new System.Drawing.Size(116, 17);
            this.lblDierentuinNaam.TabIndex = 6;
            this.lblDierentuinNaam.Text = "Dierentuin naam:";
            // 
            // txbDierentuinAdres
            // 
            this.txbDierentuinAdres.Location = new System.Drawing.Point(23, 229);
            this.txbDierentuinAdres.Name = "txbDierentuinAdres";
            this.txbDierentuinAdres.Size = new System.Drawing.Size(273, 22);
            this.txbDierentuinAdres.TabIndex = 5;
            // 
            // txbDierentuinNaam
            // 
            this.txbDierentuinNaam.Location = new System.Drawing.Point(23, 134);
            this.txbDierentuinNaam.Name = "txbDierentuinNaam";
            this.txbDierentuinNaam.Size = new System.Drawing.Size(273, 22);
            this.txbDierentuinNaam.TabIndex = 4;
            // 
            // tabDieren
            // 
            this.tabDieren.Controls.Add(this.gvDier);
            this.tabDieren.Controls.Add(this.cmbDierDierentuin);
            this.tabDieren.Controls.Add(this.lblDierEten);
            this.tabDieren.Controls.Add(this.txbDierEten);
            this.tabDieren.Controls.Add(this.lblDierentuinVanDier);
            this.tabDieren.Controls.Add(this.lblGeslacht);
            this.tabDieren.Controls.Add(this.cmbDierGeslacht);
            this.tabDieren.Controls.Add(this.lblDierLocatie);
            this.tabDieren.Controls.Add(this.lblDierNaam);
            this.tabDieren.Controls.Add(this.lblSoort);
            this.tabDieren.Controls.Add(this.txbDierSoort);
            this.tabDieren.Controls.Add(this.txbDierNaam);
            this.tabDieren.Controls.Add(this.txbDierLocatie);
            this.tabDieren.Location = new System.Drawing.Point(4, 25);
            this.tabDieren.Name = "tabDieren";
            this.tabDieren.Padding = new System.Windows.Forms.Padding(3);
            this.tabDieren.Size = new System.Drawing.Size(1234, 484);
            this.tabDieren.TabIndex = 1;
            this.tabDieren.Text = "Dier";
            this.tabDieren.UseVisualStyleBackColor = true;
            // 
            // gvDier
            // 
            this.gvDier.AllowUserToAddRows = false;
            this.gvDier.AllowUserToDeleteRows = false;
            this.gvDier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDier.Location = new System.Drawing.Point(351, 39);
            this.gvDier.Name = "gvDier";
            this.gvDier.ReadOnly = true;
            this.gvDier.RowTemplate.Height = 24;
            this.gvDier.Size = new System.Drawing.Size(785, 418);
            this.gvDier.TabIndex = 27;
            // 
            // cmbDierDierentuin
            // 
            this.cmbDierDierentuin.DisplayMember = "ID";
            this.cmbDierDierentuin.FormattingEnabled = true;
            this.cmbDierDierentuin.Location = new System.Drawing.Point(31, 356);
            this.cmbDierDierentuin.Name = "cmbDierDierentuin";
            this.cmbDierDierentuin.Size = new System.Drawing.Size(258, 24);
            this.cmbDierDierentuin.TabIndex = 26;
            this.cmbDierDierentuin.ValueMember = "ID";
            // 
            // lblDierEten
            // 
            this.lblDierEten.AutoSize = true;
            this.lblDierEten.Location = new System.Drawing.Point(28, 223);
            this.lblDierEten.Name = "lblDierEten";
            this.lblDierEten.Size = new System.Drawing.Size(71, 17);
            this.lblDierEten.TabIndex = 25;
            this.lblDierEten.Text = "Dier Eten:";
            // 
            // txbDierEten
            // 
            this.txbDierEten.Location = new System.Drawing.Point(31, 243);
            this.txbDierEten.Name = "txbDierEten";
            this.txbDierEten.Size = new System.Drawing.Size(258, 22);
            this.txbDierEten.TabIndex = 24;
            // 
            // lblDierentuinVanDier
            // 
            this.lblDierentuinVanDier.AutoSize = true;
            this.lblDierentuinVanDier.Location = new System.Drawing.Point(28, 336);
            this.lblDierentuinVanDier.Name = "lblDierentuinVanDier";
            this.lblDierentuinVanDier.Size = new System.Drawing.Size(128, 17);
            this.lblDierentuinVanDier.TabIndex = 23;
            this.lblDierentuinVanDier.Text = "Dierentuin van dier";
            // 
            // lblGeslacht
            // 
            this.lblGeslacht.AutoSize = true;
            this.lblGeslacht.Location = new System.Drawing.Point(28, 277);
            this.lblGeslacht.Name = "lblGeslacht";
            this.lblGeslacht.Size = new System.Drawing.Size(98, 17);
            this.lblGeslacht.TabIndex = 22;
            this.lblGeslacht.Text = "Dier Geslacht:";
            // 
            // cmbDierGeslacht
            // 
            this.cmbDierGeslacht.FormattingEnabled = true;
            this.cmbDierGeslacht.Items.AddRange(new object[] {
            "Man",
            "Vrouw"});
            this.cmbDierGeslacht.Location = new System.Drawing.Point(31, 297);
            this.cmbDierGeslacht.Name = "cmbDierGeslacht";
            this.cmbDierGeslacht.Size = new System.Drawing.Size(258, 24);
            this.cmbDierGeslacht.TabIndex = 21;
            // 
            // lblDierLocatie
            // 
            this.lblDierLocatie.AutoSize = true;
            this.lblDierLocatie.Location = new System.Drawing.Point(28, 167);
            this.lblDierLocatie.Name = "lblDierLocatie";
            this.lblDierLocatie.Size = new System.Drawing.Size(83, 17);
            this.lblDierLocatie.TabIndex = 20;
            this.lblDierLocatie.Text = "Dier locatie:";
            // 
            // lblDierNaam
            // 
            this.lblDierNaam.AutoSize = true;
            this.lblDierNaam.Location = new System.Drawing.Point(28, 112);
            this.lblDierNaam.Name = "lblDierNaam";
            this.lblDierNaam.Size = new System.Drawing.Size(77, 17);
            this.lblDierNaam.TabIndex = 19;
            this.lblDierNaam.Text = "Dier naam:";
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(28, 55);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(74, 17);
            this.lblSoort.TabIndex = 18;
            this.lblSoort.Text = "Dier soort:";
            // 
            // txbDierSoort
            // 
            this.txbDierSoort.Location = new System.Drawing.Point(31, 75);
            this.txbDierSoort.Name = "txbDierSoort";
            this.txbDierSoort.Size = new System.Drawing.Size(258, 22);
            this.txbDierSoort.TabIndex = 15;
            // 
            // txbDierNaam
            // 
            this.txbDierNaam.Location = new System.Drawing.Point(31, 132);
            this.txbDierNaam.Name = "txbDierNaam";
            this.txbDierNaam.Size = new System.Drawing.Size(258, 22);
            this.txbDierNaam.TabIndex = 16;
            // 
            // txbDierLocatie
            // 
            this.txbDierLocatie.Location = new System.Drawing.Point(31, 187);
            this.txbDierLocatie.Name = "txbDierLocatie";
            this.txbDierLocatie.Size = new System.Drawing.Size(258, 22);
            this.txbDierLocatie.TabIndex = 17;
            // 
            // tabWerkers
            // 
            this.tabWerkers.Controls.Add(this.gvWerker);
            this.tabWerkers.Controls.Add(this.dtpWerkerEindTijd);
            this.tabWerkers.Controls.Add(this.dtpWerkerBeginTijd);
            this.tabWerkers.Controls.Add(this.cmbWerkerDierentuin);
            this.tabWerkers.Controls.Add(this.txbWerkerVoornaam);
            this.tabWerkers.Controls.Add(this.txbWerkerTussenvoegsel);
            this.tabWerkers.Controls.Add(this.txbWerkerAchternaam);
            this.tabWerkers.Controls.Add(this.txbWerkerWerkzaamheden);
            this.tabWerkers.Controls.Add(this.lblWerkerWerktBij);
            this.tabWerkers.Controls.Add(this.lblEindtijd);
            this.tabWerkers.Controls.Add(this.lblBegintijd);
            this.tabWerkers.Controls.Add(this.lblWerkzaamheden);
            this.tabWerkers.Controls.Add(this.lblAchternaam);
            this.tabWerkers.Controls.Add(this.lblTussenvoegsel);
            this.tabWerkers.Controls.Add(this.lblWerkerNaam);
            this.tabWerkers.Location = new System.Drawing.Point(4, 25);
            this.tabWerkers.Name = "tabWerkers";
            this.tabWerkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabWerkers.Size = new System.Drawing.Size(1234, 484);
            this.tabWerkers.TabIndex = 2;
            this.tabWerkers.Text = "Werker";
            this.tabWerkers.UseVisualStyleBackColor = true;
            // 
            // gvWerker
            // 
            this.gvWerker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWerker.Location = new System.Drawing.Point(313, 34);
            this.gvWerker.Name = "gvWerker";
            this.gvWerker.RowTemplate.Height = 24;
            this.gvWerker.Size = new System.Drawing.Size(874, 387);
            this.gvWerker.TabIndex = 31;
            // 
            // dtpWerkerEindTijd
            // 
            this.dtpWerkerEindTijd.CustomFormat = "HH:mm";
            this.dtpWerkerEindTijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWerkerEindTijd.Location = new System.Drawing.Point(22, 335);
            this.dtpWerkerEindTijd.Name = "dtpWerkerEindTijd";
            this.dtpWerkerEindTijd.ShowUpDown = true;
            this.dtpWerkerEindTijd.Size = new System.Drawing.Size(258, 22);
            this.dtpWerkerEindTijd.TabIndex = 30;
            // 
            // dtpWerkerBeginTijd
            // 
            this.dtpWerkerBeginTijd.CustomFormat = "HH:mm";
            this.dtpWerkerBeginTijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWerkerBeginTijd.Location = new System.Drawing.Point(22, 277);
            this.dtpWerkerBeginTijd.Name = "dtpWerkerBeginTijd";
            this.dtpWerkerBeginTijd.ShowUpDown = true;
            this.dtpWerkerBeginTijd.Size = new System.Drawing.Size(258, 22);
            this.dtpWerkerBeginTijd.TabIndex = 29;
            // 
            // cmbWerkerDierentuin
            // 
            this.cmbWerkerDierentuin.DisplayMember = "ID";
            this.cmbWerkerDierentuin.FormattingEnabled = true;
            this.cmbWerkerDierentuin.Location = new System.Drawing.Point(22, 397);
            this.cmbWerkerDierentuin.Name = "cmbWerkerDierentuin";
            this.cmbWerkerDierentuin.Size = new System.Drawing.Size(258, 24);
            this.cmbWerkerDierentuin.TabIndex = 28;
            this.cmbWerkerDierentuin.ValueMember = "ID";
            // 
            // txbWerkerVoornaam
            // 
            this.txbWerkerVoornaam.Location = new System.Drawing.Point(22, 44);
            this.txbWerkerVoornaam.Name = "txbWerkerVoornaam";
            this.txbWerkerVoornaam.Size = new System.Drawing.Size(258, 22);
            this.txbWerkerVoornaam.TabIndex = 27;
            // 
            // txbWerkerTussenvoegsel
            // 
            this.txbWerkerTussenvoegsel.Location = new System.Drawing.Point(22, 102);
            this.txbWerkerTussenvoegsel.Name = "txbWerkerTussenvoegsel";
            this.txbWerkerTussenvoegsel.Size = new System.Drawing.Size(258, 22);
            this.txbWerkerTussenvoegsel.TabIndex = 26;
            // 
            // txbWerkerAchternaam
            // 
            this.txbWerkerAchternaam.Location = new System.Drawing.Point(22, 166);
            this.txbWerkerAchternaam.Name = "txbWerkerAchternaam";
            this.txbWerkerAchternaam.Size = new System.Drawing.Size(258, 22);
            this.txbWerkerAchternaam.TabIndex = 25;
            // 
            // txbWerkerWerkzaamheden
            // 
            this.txbWerkerWerkzaamheden.Location = new System.Drawing.Point(22, 220);
            this.txbWerkerWerkzaamheden.Name = "txbWerkerWerkzaamheden";
            this.txbWerkerWerkzaamheden.Size = new System.Drawing.Size(258, 22);
            this.txbWerkerWerkzaamheden.TabIndex = 24;
            // 
            // lblWerkerWerktBij
            // 
            this.lblWerkerWerktBij.AutoSize = true;
            this.lblWerkerWerktBij.Location = new System.Drawing.Point(19, 376);
            this.lblWerkerWerktBij.Name = "lblWerkerWerktBij";
            this.lblWerkerWerktBij.Size = new System.Drawing.Size(113, 17);
            this.lblWerkerWerktBij.TabIndex = 21;
            this.lblWerkerWerktBij.Text = "Werker werkt bij:";
            // 
            // lblEindtijd
            // 
            this.lblEindtijd.AutoSize = true;
            this.lblEindtijd.Location = new System.Drawing.Point(19, 315);
            this.lblEindtijd.Name = "lblEindtijd";
            this.lblEindtijd.Size = new System.Drawing.Size(165, 17);
            this.lblEindtijd.TabIndex = 20;
            this.lblEindtijd.Text = "Werker stopt werken om:";
            // 
            // lblBegintijd
            // 
            this.lblBegintijd.AutoSize = true;
            this.lblBegintijd.Location = new System.Drawing.Point(19, 257);
            this.lblBegintijd.Name = "lblBegintijd";
            this.lblBegintijd.Size = new System.Drawing.Size(173, 17);
            this.lblBegintijd.TabIndex = 19;
            this.lblBegintijd.Text = "Werker begint werken om:";
            // 
            // lblWerkzaamheden
            // 
            this.lblWerkzaamheden.AutoSize = true;
            this.lblWerkzaamheden.Location = new System.Drawing.Point(19, 200);
            this.lblWerkzaamheden.Name = "lblWerkzaamheden";
            this.lblWerkzaamheden.Size = new System.Drawing.Size(119, 17);
            this.lblWerkzaamheden.TabIndex = 18;
            this.lblWerkzaamheden.Text = "Werkzaamheden:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(19, 146);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(88, 17);
            this.lblAchternaam.TabIndex = 17;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblTussenvoegsel
            // 
            this.lblTussenvoegsel.AutoSize = true;
            this.lblTussenvoegsel.Location = new System.Drawing.Point(19, 82);
            this.lblTussenvoegsel.Name = "lblTussenvoegsel";
            this.lblTussenvoegsel.Size = new System.Drawing.Size(108, 17);
            this.lblTussenvoegsel.TabIndex = 16;
            this.lblTussenvoegsel.Text = "Tussenvoegsel:";
            // 
            // lblWerkerNaam
            // 
            this.lblWerkerNaam.AutoSize = true;
            this.lblWerkerNaam.Location = new System.Drawing.Point(19, 24);
            this.lblWerkerNaam.Name = "lblWerkerNaam";
            this.lblWerkerNaam.Size = new System.Drawing.Size(77, 17);
            this.lblWerkerNaam.TabIndex = 15;
            this.lblWerkerNaam.Text = "Voornaam:";
            // 
            // tabVerzorger
            // 
            this.tabVerzorger.Controls.Add(this.lblVerzorgerInvoer);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerID);
            this.tabVerzorger.Controls.Add(this.lblZoekDierOp);
            this.tabVerzorger.Controls.Add(this.btnVerzorgerSelectDier);
            this.tabVerzorger.Controls.Add(this.txbVerzorgerID);
            this.tabVerzorger.Controls.Add(this.gvVerzorger);
            this.tabVerzorger.Controls.Add(this.txbVerzorgerDier);
            this.tabVerzorger.Controls.Add(this.lblDierVanVerzorger);
            this.tabVerzorger.Controls.Add(this.dtpVerzorgerEindTijd);
            this.tabVerzorger.Controls.Add(this.dtpVerzorgerBeginTijd);
            this.tabVerzorger.Controls.Add(this.cmbVerzorgerDierentuin);
            this.tabVerzorger.Controls.Add(this.txbVerzorgerVoornaam);
            this.tabVerzorger.Controls.Add(this.txbVerzorgerTussenvoegsel);
            this.tabVerzorger.Controls.Add(this.txbVerzorgerAchternaam);
            this.tabVerzorger.Controls.Add(this.txbVerzorgerWerkzaamheden);
            this.tabVerzorger.Controls.Add(this.lblDierentuinVanVerzorger);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerEindTijd);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerBeginTijd);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerWerkzaamheden);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerAchternaam);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerTussenvoegsel);
            this.tabVerzorger.Controls.Add(this.lblVerzorgerVoornaam);
            this.tabVerzorger.Location = new System.Drawing.Point(4, 25);
            this.tabVerzorger.Name = "tabVerzorger";
            this.tabVerzorger.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerzorger.Size = new System.Drawing.Size(1234, 484);
            this.tabVerzorger.TabIndex = 3;
            this.tabVerzorger.Text = "Verzorger";
            this.tabVerzorger.UseVisualStyleBackColor = true;
            // 
            // lblVerzorgerInvoer
            // 
            this.lblVerzorgerInvoer.AutoSize = true;
            this.lblVerzorgerInvoer.Location = new System.Drawing.Point(824, 74);
            this.lblVerzorgerInvoer.Name = "lblVerzorgerInvoer";
            this.lblVerzorgerInvoer.Size = new System.Drawing.Size(385, 17);
            this.lblVerzorgerInvoer.TabIndex = 56;
            this.lblVerzorgerInvoer.Text = "Voer data in om te kijken welk dier er moet worden verzorgd";
            this.lblVerzorgerInvoer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVerzorgerID
            // 
            this.lblVerzorgerID.AutoSize = true;
            this.lblVerzorgerID.Location = new System.Drawing.Point(884, 138);
            this.lblVerzorgerID.Name = "lblVerzorgerID";
            this.lblVerzorgerID.Size = new System.Drawing.Size(95, 17);
            this.lblVerzorgerID.TabIndex = 55;
            this.lblVerzorgerID.Text = "Voer uw ID in:";
            // 
            // lblZoekDierOp
            // 
            this.lblZoekDierOp.AutoSize = true;
            this.lblZoekDierOp.Location = new System.Drawing.Point(866, 217);
            this.lblZoekDierOp.Name = "lblZoekDierOp";
            this.lblZoekDierOp.Size = new System.Drawing.Size(212, 17);
            this.lblZoekDierOp.TabIndex = 52;
            this.lblZoekDierOp.Text = "Welke dieren moet ik verzorgen:";
            // 
            // btnVerzorgerSelectDier
            // 
            this.btnVerzorgerSelectDier.Location = new System.Drawing.Point(1084, 207);
            this.btnVerzorgerSelectDier.Name = "btnVerzorgerSelectDier";
            this.btnVerzorgerSelectDier.Size = new System.Drawing.Size(75, 33);
            this.btnVerzorgerSelectDier.TabIndex = 51;
            this.btnVerzorgerSelectDier.Text = "Zoek op";
            this.btnVerzorgerSelectDier.UseVisualStyleBackColor = true;
            this.btnVerzorgerSelectDier.Click += new System.EventHandler(this.btnVerzorgerSelectDier_Click);
            // 
            // txbVerzorgerID
            // 
            this.txbVerzorgerID.Location = new System.Drawing.Point(887, 158);
            this.txbVerzorgerID.Multiline = true;
            this.txbVerzorgerID.Name = "txbVerzorgerID";
            this.txbVerzorgerID.Size = new System.Drawing.Size(255, 22);
            this.txbVerzorgerID.TabIndex = 50;
            // 
            // gvVerzorger
            // 
            this.gvVerzorger.AllowUserToAddRows = false;
            this.gvVerzorger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVerzorger.Location = new System.Drawing.Point(365, 36);
            this.gvVerzorger.Name = "gvVerzorger";
            this.gvVerzorger.RowTemplate.Height = 24;
            this.gvVerzorger.Size = new System.Drawing.Size(366, 433);
            this.gvVerzorger.TabIndex = 47;
            // 
            // txbVerzorgerDier
            // 
            this.txbVerzorgerDier.Location = new System.Drawing.Point(19, 447);
            this.txbVerzorgerDier.Name = "txbVerzorgerDier";
            this.txbVerzorgerDier.Size = new System.Drawing.Size(258, 22);
            this.txbVerzorgerDier.TabIndex = 46;
            // 
            // lblDierVanVerzorger
            // 
            this.lblDierVanVerzorger.AutoSize = true;
            this.lblDierVanVerzorger.Location = new System.Drawing.Point(16, 426);
            this.lblDierVanVerzorger.Name = "lblDierVanVerzorger";
            this.lblDierVanVerzorger.Size = new System.Drawing.Size(225, 17);
            this.lblDierVanVerzorger.TabIndex = 45;
            this.lblDierVanVerzorger.Text = "Dier waar de verzorger voor zorgt:";
            // 
            // dtpVerzorgerEindTijd
            // 
            this.dtpVerzorgerEindTijd.CustomFormat = "HH:mm";
            this.dtpVerzorgerEindTijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVerzorgerEindTijd.Location = new System.Drawing.Point(19, 327);
            this.dtpVerzorgerEindTijd.Name = "dtpVerzorgerEindTijd";
            this.dtpVerzorgerEindTijd.ShowUpDown = true;
            this.dtpVerzorgerEindTijd.Size = new System.Drawing.Size(258, 22);
            this.dtpVerzorgerEindTijd.TabIndex = 44;
            // 
            // dtpVerzorgerBeginTijd
            // 
            this.dtpVerzorgerBeginTijd.CustomFormat = "HH:mm";
            this.dtpVerzorgerBeginTijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVerzorgerBeginTijd.Location = new System.Drawing.Point(19, 269);
            this.dtpVerzorgerBeginTijd.Name = "dtpVerzorgerBeginTijd";
            this.dtpVerzorgerBeginTijd.ShowUpDown = true;
            this.dtpVerzorgerBeginTijd.Size = new System.Drawing.Size(258, 22);
            this.dtpVerzorgerBeginTijd.TabIndex = 43;
            // 
            // cmbVerzorgerDierentuin
            // 
            this.cmbVerzorgerDierentuin.DisplayMember = "ID";
            this.cmbVerzorgerDierentuin.FormattingEnabled = true;
            this.cmbVerzorgerDierentuin.Location = new System.Drawing.Point(19, 389);
            this.cmbVerzorgerDierentuin.Name = "cmbVerzorgerDierentuin";
            this.cmbVerzorgerDierentuin.Size = new System.Drawing.Size(258, 24);
            this.cmbVerzorgerDierentuin.TabIndex = 42;
            this.cmbVerzorgerDierentuin.ValueMember = "ID";
            // 
            // txbVerzorgerVoornaam
            // 
            this.txbVerzorgerVoornaam.Location = new System.Drawing.Point(19, 36);
            this.txbVerzorgerVoornaam.Name = "txbVerzorgerVoornaam";
            this.txbVerzorgerVoornaam.Size = new System.Drawing.Size(258, 22);
            this.txbVerzorgerVoornaam.TabIndex = 41;
            // 
            // txbVerzorgerTussenvoegsel
            // 
            this.txbVerzorgerTussenvoegsel.Location = new System.Drawing.Point(19, 94);
            this.txbVerzorgerTussenvoegsel.Name = "txbVerzorgerTussenvoegsel";
            this.txbVerzorgerTussenvoegsel.Size = new System.Drawing.Size(258, 22);
            this.txbVerzorgerTussenvoegsel.TabIndex = 40;
            // 
            // txbVerzorgerAchternaam
            // 
            this.txbVerzorgerAchternaam.Location = new System.Drawing.Point(19, 158);
            this.txbVerzorgerAchternaam.Name = "txbVerzorgerAchternaam";
            this.txbVerzorgerAchternaam.Size = new System.Drawing.Size(258, 22);
            this.txbVerzorgerAchternaam.TabIndex = 39;
            // 
            // txbVerzorgerWerkzaamheden
            // 
            this.txbVerzorgerWerkzaamheden.Location = new System.Drawing.Point(19, 212);
            this.txbVerzorgerWerkzaamheden.Name = "txbVerzorgerWerkzaamheden";
            this.txbVerzorgerWerkzaamheden.Size = new System.Drawing.Size(258, 22);
            this.txbVerzorgerWerkzaamheden.TabIndex = 38;
            // 
            // lblDierentuinVanVerzorger
            // 
            this.lblDierentuinVanVerzorger.AutoSize = true;
            this.lblDierentuinVanVerzorger.Location = new System.Drawing.Point(16, 368);
            this.lblDierentuinVanVerzorger.Name = "lblDierentuinVanVerzorger";
            this.lblDierentuinVanVerzorger.Size = new System.Drawing.Size(130, 17);
            this.lblDierentuinVanVerzorger.TabIndex = 37;
            this.lblDierentuinVanVerzorger.Text = "Verzorger werkt bij:";
            // 
            // lblVerzorgerEindTijd
            // 
            this.lblVerzorgerEindTijd.AutoSize = true;
            this.lblVerzorgerEindTijd.Location = new System.Drawing.Point(16, 307);
            this.lblVerzorgerEindTijd.Name = "lblVerzorgerEindTijd";
            this.lblVerzorgerEindTijd.Size = new System.Drawing.Size(182, 17);
            this.lblVerzorgerEindTijd.TabIndex = 36;
            this.lblVerzorgerEindTijd.Text = "Verzorger stopt werken om:";
            // 
            // lblVerzorgerBeginTijd
            // 
            this.lblVerzorgerBeginTijd.AutoSize = true;
            this.lblVerzorgerBeginTijd.Location = new System.Drawing.Point(16, 249);
            this.lblVerzorgerBeginTijd.Name = "lblVerzorgerBeginTijd";
            this.lblVerzorgerBeginTijd.Size = new System.Drawing.Size(190, 17);
            this.lblVerzorgerBeginTijd.TabIndex = 35;
            this.lblVerzorgerBeginTijd.Text = "Verzorger begint werken om:";
            // 
            // lblVerzorgerWerkzaamheden
            // 
            this.lblVerzorgerWerkzaamheden.AutoSize = true;
            this.lblVerzorgerWerkzaamheden.Location = new System.Drawing.Point(16, 192);
            this.lblVerzorgerWerkzaamheden.Name = "lblVerzorgerWerkzaamheden";
            this.lblVerzorgerWerkzaamheden.Size = new System.Drawing.Size(119, 17);
            this.lblVerzorgerWerkzaamheden.TabIndex = 34;
            this.lblVerzorgerWerkzaamheden.Text = "Werkzaamheden:";
            // 
            // lblVerzorgerAchternaam
            // 
            this.lblVerzorgerAchternaam.AutoSize = true;
            this.lblVerzorgerAchternaam.Location = new System.Drawing.Point(16, 138);
            this.lblVerzorgerAchternaam.Name = "lblVerzorgerAchternaam";
            this.lblVerzorgerAchternaam.Size = new System.Drawing.Size(88, 17);
            this.lblVerzorgerAchternaam.TabIndex = 33;
            this.lblVerzorgerAchternaam.Text = "Achternaam:";
            // 
            // lblVerzorgerTussenvoegsel
            // 
            this.lblVerzorgerTussenvoegsel.AutoSize = true;
            this.lblVerzorgerTussenvoegsel.Location = new System.Drawing.Point(16, 74);
            this.lblVerzorgerTussenvoegsel.Name = "lblVerzorgerTussenvoegsel";
            this.lblVerzorgerTussenvoegsel.Size = new System.Drawing.Size(108, 17);
            this.lblVerzorgerTussenvoegsel.TabIndex = 32;
            this.lblVerzorgerTussenvoegsel.Text = "Tussenvoegsel:";
            // 
            // lblVerzorgerVoornaam
            // 
            this.lblVerzorgerVoornaam.AutoSize = true;
            this.lblVerzorgerVoornaam.Location = new System.Drawing.Point(16, 16);
            this.lblVerzorgerVoornaam.Name = "lblVerzorgerVoornaam";
            this.lblVerzorgerVoornaam.Size = new System.Drawing.Size(77, 17);
            this.lblVerzorgerVoornaam.TabIndex = 31;
            this.lblVerzorgerVoornaam.Text = "Voornaam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 572);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.tabDierentuin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDierentuin.ResumeLayout(false);
            this.tabDierentuinen.ResumeLayout(false);
            this.tabDierentuinen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDierentuin)).EndInit();
            this.tabDieren.ResumeLayout(false);
            this.tabDieren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDier)).EndInit();
            this.tabWerkers.ResumeLayout(false);
            this.tabWerkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWerker)).EndInit();
            this.tabVerzorger.ResumeLayout(false);
            this.tabVerzorger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVerzorger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TabControl tabDierentuin;
        private System.Windows.Forms.TabPage tabWerkers;
        private System.Windows.Forms.DateTimePicker dtpWerkerEindTijd;
        private System.Windows.Forms.DateTimePicker dtpWerkerBeginTijd;
        private System.Windows.Forms.ComboBox cmbWerkerDierentuin;
        private System.Windows.Forms.TextBox txbWerkerVoornaam;
        private System.Windows.Forms.TextBox txbWerkerTussenvoegsel;
        private System.Windows.Forms.TextBox txbWerkerAchternaam;
        private System.Windows.Forms.TextBox txbWerkerWerkzaamheden;
        private System.Windows.Forms.Label lblWerkerWerktBij;
        private System.Windows.Forms.Label lblEindtijd;
        private System.Windows.Forms.Label lblBegintijd;
        private System.Windows.Forms.Label lblWerkzaamheden;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblTussenvoegsel;
        private System.Windows.Forms.Label lblWerkerNaam;
        private System.Windows.Forms.TabPage tabVerzorger;
        private System.Windows.Forms.Label lblDierVanVerzorger;
        private System.Windows.Forms.DateTimePicker dtpVerzorgerEindTijd;
        private System.Windows.Forms.DateTimePicker dtpVerzorgerBeginTijd;
        private System.Windows.Forms.ComboBox cmbVerzorgerDierentuin;
        private System.Windows.Forms.TextBox txbVerzorgerVoornaam;
        private System.Windows.Forms.TextBox txbVerzorgerTussenvoegsel;
        private System.Windows.Forms.TextBox txbVerzorgerAchternaam;
        private System.Windows.Forms.TextBox txbVerzorgerWerkzaamheden;
        private System.Windows.Forms.Label lblDierentuinVanVerzorger;
        private System.Windows.Forms.Label lblVerzorgerEindTijd;
        private System.Windows.Forms.Label lblVerzorgerBeginTijd;
        private System.Windows.Forms.Label lblVerzorgerWerkzaamheden;
        private System.Windows.Forms.Label lblVerzorgerAchternaam;
        private System.Windows.Forms.Label lblVerzorgerTussenvoegsel;
        private System.Windows.Forms.Label lblVerzorgerVoornaam;
        private System.Windows.Forms.TextBox txbVerzorgerDier;
        private System.Windows.Forms.DataGridView gvVerzorger;
        private System.Windows.Forms.DataGridView gvWerker;
        private System.Windows.Forms.TabPage tabDierentuinen;
        private System.Windows.Forms.DataGridView gvDierentuin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.Label lblDierentuinAdres;
        private System.Windows.Forms.Label lblDierentuinNaam;
        private System.Windows.Forms.TextBox txbDierentuinAdres;
        private System.Windows.Forms.TextBox txbDierentuinNaam;
        private System.Windows.Forms.TabPage tabDieren;
        private System.Windows.Forms.DataGridView gvDier;
        private System.Windows.Forms.ComboBox cmbDierDierentuin;
        private System.Windows.Forms.Label lblDierEten;
        private System.Windows.Forms.TextBox txbDierEten;
        private System.Windows.Forms.Label lblDierentuinVanDier;
        private System.Windows.Forms.Label lblGeslacht;
        private System.Windows.Forms.ComboBox cmbDierGeslacht;
        private System.Windows.Forms.Label lblDierLocatie;
        private System.Windows.Forms.Label lblDierNaam;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.TextBox txbDierSoort;
        private System.Windows.Forms.TextBox txbDierNaam;
        private System.Windows.Forms.TextBox txbDierLocatie;
        private System.Windows.Forms.Button btnFilterDierentuin;
        private System.Windows.Forms.ComboBox cmbFilterDierentuin;
        private System.Windows.Forms.Label lblVerzorgerInvoer;
        private System.Windows.Forms.Label lblVerzorgerID;
        private System.Windows.Forms.Label lblZoekDierOp;
        private System.Windows.Forms.Button btnVerzorgerSelectDier;
        private System.Windows.Forms.TextBox txbVerzorgerID;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txbDierentuinBudget;
    }
}

