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
            this.tboCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameComboBox1 = new System.Windows.Forms.ComboBox();
            this.companyIDLabel1 = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxShowOnlyCompany = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.NameCard = new System.Windows.Forms.Label();
            this.BirthDateCard = new System.Windows.Forms.Label();
            this.PatronymicCard = new System.Windows.Forms.Label();
            this.SurNameCard = new System.Windows.Forms.Label();
            this.DateCreationCard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbo_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tbo_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINGERPRINTDBMDFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            nameLabel1 = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTDBMDFDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(13, 168);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(65, 13);
            nameLabel1.TabIndex = 10;
            nameLabel1.Text = "Department:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(13, 141);
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
            nameLabel2.Location = new System.Drawing.Point(13, 121);
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
            // tboCompanyBindingSource
            // 
            this.tboCompanyBindingSource.DataMember = "tbo_Company";
            this.tboCompanyBindingSource.DataSource = this.fINGERPRINTDBMDFDataSetBindingSource;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create departments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.user_add_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(461, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 73);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // nameComboBox1
            // 
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_DepartmentBindingSource, "Name", true));
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbo_DepartmentBindingSource, "CompanyID", true));
            this.nameComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox1.FormattingEnabled = true;
            this.nameComboBox1.Location = new System.Drawing.Point(81, 164);
            this.nameComboBox1.Name = "nameComboBox1";
            this.nameComboBox1.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox1.TabIndex = 11;
            this.nameComboBox1.SelectedIndexChanged += new System.EventHandler(this.nameComboBox1_SelectedIndexChanged);
            // 
            // companyIDLabel1
            // 
            this.companyIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_DepartmentBindingSource, "CompanyID", true));
            this.companyIDLabel1.Location = new System.Drawing.Point(87, 141);
            this.companyIDLabel1.Name = "companyIDLabel1";
            this.companyIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.companyIDLabel1.TabIndex = 12;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 19;
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
            // checkBoxShowOnlyCompany
            // 
            this.checkBoxShowOnlyCompany.AutoSize = true;
            this.checkBoxShowOnlyCompany.Location = new System.Drawing.Point(16, 211);
            this.checkBoxShowOnlyCompany.Name = "checkBoxShowOnlyCompany";
            this.checkBoxShowOnlyCompany.Size = new System.Drawing.Size(346, 17);
            this.checkBoxShowOnlyCompany.TabIndex = 22;
            this.checkBoxShowOnlyCompany.Text = "Show all employees in current company (no division by departments)";
            this.checkBoxShowOnlyCompany.UseVisualStyleBackColor = true;
            this.checkBoxShowOnlyCompany.CheckedChanged += new System.EventHandler(this.checkBoxShowOnlyCompany_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(237, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            // NameCard
            // 
            this.NameCard.AutoSize = true;
            this.NameCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCard.Location = new System.Drawing.Point(166, 335);
            this.NameCard.Name = "NameCard";
            this.NameCard.Size = new System.Drawing.Size(0, 22);
            this.NameCard.TabIndex = 26;
            // 
            // BirthDateCard
            // 
            this.BirthDateCard.AutoSize = true;
            this.BirthDateCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateCard.Location = new System.Drawing.Point(167, 432);
            this.BirthDateCard.Name = "BirthDateCard";
            this.BirthDateCard.Size = new System.Drawing.Size(0, 22);
            this.BirthDateCard.TabIndex = 29;
            // 
            // PatronymicCard
            // 
            this.PatronymicCard.AutoSize = true;
            this.PatronymicCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicCard.Location = new System.Drawing.Point(167, 400);
            this.PatronymicCard.Name = "PatronymicCard";
            this.PatronymicCard.Size = new System.Drawing.Size(0, 22);
            this.PatronymicCard.TabIndex = 30;
            // 
            // SurNameCard
            // 
            this.SurNameCard.AutoSize = true;
            this.SurNameCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameCard.Location = new System.Drawing.Point(167, 366);
            this.SurNameCard.Name = "SurNameCard";
            this.SurNameCard.Size = new System.Drawing.Size(0, 22);
            this.SurNameCard.TabIndex = 31;
            // 
            // DateCreationCard
            // 
            this.DateCreationCard.AutoSize = true;
            this.DateCreationCard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateCreationCard.Location = new System.Drawing.Point(167, 466);
            this.DateCreationCard.Name = "DateCreationCard";
            this.DateCreationCard.Size = new System.Drawing.Size(0, 22);
            this.DateCreationCard.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(603, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 718);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tbo_CompanyBindingSource
            // 
            this.tbo_CompanyBindingSource.DataMember = "tbo_Company";
            this.tbo_CompanyBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbo_DepartmentBindingSource
            // 
            this.tbo_DepartmentBindingSource.DataMember = "tbo_Department";
            this.tbo_DepartmentBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // fINGERPRINTDBMDFDataSetBindingSource
            // 
            this.fINGERPRINTDBMDFDataSetBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            this.fINGERPRINTDBMDFDataSetBindingSource.Position = 0;
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
            this.dataGridView2.Location = new System.Drawing.Point(16, 533);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(367, 200);
            this.dataGridView2.TabIndex = 40;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 753);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Admin_Panel";
            this.Text = "FingerPrintSystem:: Administration Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTDBMDFDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}