﻿namespace Forms_FingerPrint
{
    partial class Admin_Panel
    {
        private string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Forms_FingerPrint.Properties.Settings.FINGERPRINTDB_DB"].ToString();

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel2;
            this.tboCompanyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fINGERPRINTDBMDFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tboCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameComboBox1 = new System.Windows.Forms.ComboBox();
            this.tbo_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyIDLabel1 = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.tbo_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxShowOnlyCompany = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.NameCard = new System.Windows.Forms.Label();
            this.BirthDateCard = new System.Windows.Forms.Label();
            this.PatronymicCard = new System.Windows.Forms.Label();
            this.SurNameCard = new System.Windows.Forms.Label();
            this.DateCreationCard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbo_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_RoleTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_CompanyTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter();
            this.tbo_ProfileTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter();
            this.tbo_ProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_DepartmentTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter();
            this.tboCompanyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet1 = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NameLabelCard = new System.Windows.Forms.Label();
            this.SurnameLabelCard = new System.Windows.Forms.Label();
            this.PatronymicLabelCard = new System.Windows.Forms.Label();
            this.BirthDateLabelCard = new System.Windows.Forms.Label();
            this.DateCreationLabelCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountofEmployees = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTDBMDFDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(13, 198);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(65, 13);
            nameLabel1.TabIndex = 10;
            nameLabel1.Text = "Department:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(13, 163);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(68, 13);
            companyIDLabel.TabIndex = 11;
            companyIDLabel.Text = "Company ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(13, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(13, 107);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(51, 13);
            nameLabel2.TabIndex = 18;
            nameLabel2.Text = "Company";
            // 
            // tboCompanyBindingSource1
            // 
            this.tboCompanyBindingSource1.DataMember = "tbo_Company";
            this.tboCompanyBindingSource1.DataSource = this.fINGERPRINTDBMDFDataSetBindingSource;
            // 
            // fINGERPRINTDBMDFDataSetBindingSource
            // 
            this.fINGERPRINTDBMDFDataSetBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            this.fINGERPRINTDBMDFDataSetBindingSource.Position = 0;
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tboCompanyBindingSource
            // 
            this.tboCompanyBindingSource.DataMember = "tbo_Company";
            this.tboCompanyBindingSource.DataSource = this.fINGERPRINTDBMDFDataSetBindingSource;
            // 
            // nameComboBox1
            // 
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_DepartmentBindingSource, "Name", true));
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbo_DepartmentBindingSource, "CompanyID", true));
            this.nameComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox1.FormattingEnabled = true;
            this.nameComboBox1.Location = new System.Drawing.Point(81, 194);
            this.nameComboBox1.Name = "nameComboBox1";
            this.nameComboBox1.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox1.TabIndex = 11;
            this.nameComboBox1.SelectedValueChanged += new System.EventHandler(this.nameComboBox1_SelectedValueChanged);
            // 
            // tbo_DepartmentBindingSource
            // 
            this.tbo_DepartmentBindingSource.DataMember = "tbo_Department";
            this.tbo_DepartmentBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // companyIDLabel1
            // 
            this.companyIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_DepartmentBindingSource, "CompanyID", true));
            this.companyIDLabel1.Location = new System.Drawing.Point(87, 163);
            this.companyIDLabel1.Name = "companyIDLabel1";
            this.companyIDLabel1.Size = new System.Drawing.Size(36, 25);
            this.companyIDLabel1.TabIndex = 12;
            this.companyIDLabel1.Text = "ID";
            this.companyIDLabel1.Click += new System.EventHandler(this.companyIDLabel1_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "Name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbo_DepartmentBindingSource, "CompanyID", true));
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(81, 69);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox.TabIndex = 14;
            this.nameComboBox.SelectedValueChanged += new System.EventHandler(this.nameComboBox_SelectedValueChanged);
            // 
            // tbo_CompanyBindingSource
            // 
            this.tbo_CompanyBindingSource.DataMember = "tbo_Company";
            this.tbo_CompanyBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // checkBoxShowOnlyCompany
            // 
            this.checkBoxShowOnlyCompany.AutoSize = true;
            this.checkBoxShowOnlyCompany.Enabled = false;
            this.checkBoxShowOnlyCompany.Location = new System.Drawing.Point(16, 267);
            this.checkBoxShowOnlyCompany.Name = "checkBoxShowOnlyCompany";
            this.checkBoxShowOnlyCompany.Size = new System.Drawing.Size(346, 17);
            this.checkBoxShowOnlyCompany.TabIndex = 22;
            this.checkBoxShowOnlyCompany.Text = "Show all employees in current company (no division by departments)";
            this.checkBoxShowOnlyCompany.UseVisualStyleBackColor = true;
            this.checkBoxShowOnlyCompany.CheckedChanged += new System.EventHandler(this.checkBoxShowOnlyCompany_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NameCard
            // 
            this.NameCard.AutoSize = true;
            this.NameCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCard.Location = new System.Drawing.Point(261, 335);
            this.NameCard.Name = "NameCard";
            this.NameCard.Size = new System.Drawing.Size(101, 22);
            this.NameCard.TabIndex = 26;
            this.NameCard.Text = "NameCard";
            // 
            // BirthDateCard
            // 
            this.BirthDateCard.AutoSize = true;
            this.BirthDateCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateCard.Location = new System.Drawing.Point(261, 427);
            this.BirthDateCard.Name = "BirthDateCard";
            this.BirthDateCard.Size = new System.Drawing.Size(129, 22);
            this.BirthDateCard.TabIndex = 29;
            this.BirthDateCard.Text = "BirthDateCard";
            // 
            // PatronymicCard
            // 
            this.PatronymicCard.AutoSize = true;
            this.PatronymicCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicCard.Location = new System.Drawing.Point(261, 395);
            this.PatronymicCard.Name = "PatronymicCard";
            this.PatronymicCard.Size = new System.Drawing.Size(145, 22);
            this.PatronymicCard.TabIndex = 30;
            this.PatronymicCard.Text = "PatronymicCard";
            // 
            // SurNameCard
            // 
            this.SurNameCard.AutoSize = true;
            this.SurNameCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameCard.Location = new System.Drawing.Point(261, 361);
            this.SurNameCard.Name = "SurNameCard";
            this.SurNameCard.Size = new System.Drawing.Size(130, 22);
            this.SurNameCard.TabIndex = 31;
            this.SurNameCard.Text = "SurNameCard";
            // 
            // DateCreationCard
            // 
            this.DateCreationCard.AutoSize = true;
            this.DateCreationCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateCreationCard.Location = new System.Drawing.Point(261, 461);
            this.DateCreationCard.Name = "DateCreationCard";
            this.DateCreationCard.Size = new System.Drawing.Size(162, 22);
            this.DateCreationCard.TabIndex = 38;
            this.DateCreationCard.Text = "DateCreationCard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(603, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 718);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tbo_RoleBindingSource
            // 
            this.tbo_RoleBindingSource.DataMember = "tbo_Role";
            this.tbo_RoleBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_RoleTableAdapter
            // 
            this.tbo_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbo_CompanyTableAdapter = this.tbo_CompanyTableAdapter;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = null;
            this.tableAdapterManager.tbo_LinkDepartmentUserTableAdapter = null;
            this.tableAdapterManager.tbo_ProfileTableAdapter = this.tbo_ProfileTableAdapter;
            this.tableAdapterManager.tbo_RoleTableAdapter = this.tbo_RoleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_CompanyTableAdapter
            // 
            this.tbo_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_ProfileTableAdapter
            // 
            this.tbo_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_ProfileBindingSource
            // 
            this.tbo_ProfileBindingSource.DataMember = "tbo_Profile";
            this.tbo_ProfileBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_DepartmentTableAdapter
            // 
            this.tbo_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // tboCompanyBindingSource2
            // 
            this.tboCompanyBindingSource2.DataMember = "tbo_Company";
            this.tboCompanyBindingSource2.DataSource = this._FINGERPRINTDB_MDFDataSet1;
            // 
            // _FINGERPRINTDB_MDFDataSet1
            // 
            this._FINGERPRINTDB_MDFDataSet1.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 507);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(449, 200);
            this.dataGridView2.TabIndex = 40;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(481, 465);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 41;
            this.button6.Text = "Change Info";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1571, 720);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "label1";
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.Location = new System.Drawing.Point(16, 335);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(118, 144);
            this.pictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCard.TabIndex = 25;
            this.pictureBoxCard.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Forms_FingerPrint.Properties.Resources._179407;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(66, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 27);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.user_add_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(463, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 73);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.img_2494653;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(463, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 80);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.add1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(463, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 75);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // NameLabelCard
            // 
            this.NameLabelCard.AutoSize = true;
            this.NameLabelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabelCard.Location = new System.Drawing.Point(146, 335);
            this.NameLabelCard.Name = "NameLabelCard";
            this.NameLabelCard.Size = new System.Drawing.Size(55, 20);
            this.NameLabelCard.TabIndex = 44;
            this.NameLabelCard.Text = "Name:";
            this.NameLabelCard.Visible = false;
            // 
            // SurnameLabelCard
            // 
            this.SurnameLabelCard.AutoSize = true;
            this.SurnameLabelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabelCard.Location = new System.Drawing.Point(146, 366);
            this.SurnameLabelCard.Name = "SurnameLabelCard";
            this.SurnameLabelCard.Size = new System.Drawing.Size(78, 20);
            this.SurnameLabelCard.TabIndex = 45;
            this.SurnameLabelCard.Text = "Surname:";
            this.SurnameLabelCard.Visible = false;
            // 
            // PatronymicLabelCard
            // 
            this.PatronymicLabelCard.AutoSize = true;
            this.PatronymicLabelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabelCard.Location = new System.Drawing.Point(146, 400);
            this.PatronymicLabelCard.Name = "PatronymicLabelCard";
            this.PatronymicLabelCard.Size = new System.Drawing.Size(91, 20);
            this.PatronymicLabelCard.TabIndex = 46;
            this.PatronymicLabelCard.Text = "Patronymic:";
            this.PatronymicLabelCard.Visible = false;
            // 
            // BirthDateLabelCard
            // 
            this.BirthDateLabelCard.AutoSize = true;
            this.BirthDateLabelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateLabelCard.Location = new System.Drawing.Point(146, 432);
            this.BirthDateLabelCard.Name = "BirthDateLabelCard";
            this.BirthDateLabelCard.Size = new System.Drawing.Size(81, 20);
            this.BirthDateLabelCard.TabIndex = 47;
            this.BirthDateLabelCard.Text = "BitrhDate:";
            this.BirthDateLabelCard.Visible = false;
            // 
            // DateCreationLabelCard
            // 
            this.DateCreationLabelCard.AutoSize = true;
            this.DateCreationLabelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateCreationLabelCard.Location = new System.Drawing.Point(146, 461);
            this.DateCreationLabelCard.Name = "DateCreationLabelCard";
            this.DateCreationLabelCard.Size = new System.Drawing.Size(108, 20);
            this.DateCreationLabelCard.TabIndex = 48;
            this.DateCreationLabelCard.Text = "DateCreation:";
            this.DateCreationLabelCard.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Employees";
            // 
            // CountofEmployees
            // 
            this.CountofEmployees.AutoSize = true;
            this.CountofEmployees.Location = new System.Drawing.Point(81, 138);
            this.CountofEmployees.Name = "CountofEmployees";
            this.CountofEmployees.Size = new System.Drawing.Size(35, 13);
            this.CountofEmployees.TabIndex = 50;
            this.CountofEmployees.Text = "Count";
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 753);
            this.Controls.Add(this.CountofEmployees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateCreationLabelCard);
            this.Controls.Add(this.BirthDateLabelCard);
            this.Controls.Add(this.PatronymicLabelCard);
            this.Controls.Add(this.SurnameLabelCard);
            this.Controls.Add(this.NameLabelCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DateCreationCard);
            this.Controls.Add(this.SurNameCard);
            this.Controls.Add(this.PatronymicCard);
            this.Controls.Add(this.BirthDateCard);
            this.Controls.Add(this.NameCard);
            this.Controls.Add(this.pictureBoxCard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBoxShowOnlyCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(nameLabel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(companyIDLabel);
            this.Controls.Add(this.companyIDLabel1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameComboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Admin_Panel";
            this.Text = "FingerPrintSystem:: Administration Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTDBMDFDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_RoleBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter tbo_RoleTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter tbo_ProfileTableAdapter;
        private System.Windows.Forms.BindingSource tbo_ProfileBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter tbo_CompanyTableAdapter;
        private System.Windows.Forms.BindingSource fINGERPRINTDBMDFDataSetBindingSource;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource1;
        private System.Windows.Forms.BindingSource tbo_CompanyBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource tbo_DepartmentBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter tbo_DepartmentTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox1;
        private System.Windows.Forms.Label companyIDLabel1;
        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet1;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.CheckBox checkBoxShowOnlyCompany;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCard;
        private System.Windows.Forms.Label NameCard;
        private System.Windows.Forms.Label BirthDateCard;
        private System.Windows.Forms.Label PatronymicCard;
        private System.Windows.Forms.Label SurNameCard;
        private System.Windows.Forms.Label DateCreationCard;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabelCard;
        private System.Windows.Forms.Label SurnameLabelCard;
        private System.Windows.Forms.Label PatronymicLabelCard;
        private System.Windows.Forms.Label BirthDateLabelCard;
        private System.Windows.Forms.Label DateCreationLabelCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CountofEmployees;
    }
}