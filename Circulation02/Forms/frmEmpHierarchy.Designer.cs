namespace Circulation02.Forms
{
    partial class frmEmpHierarchy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tCEmpHier = new System.Windows.Forms.TabControl();
            this.tabPageGM = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gVGM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveGM = new System.Windows.Forms.Button();
            this.txtGM = new System.Windows.Forms.TextBox();
            this.lblGM = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gVManager = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGM = new System.Windows.Forms.ComboBox();
            this.btnSaveManager = new System.Windows.Forms.Button();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGMRM = new System.Windows.Forms.ComboBox();
            this.btnSaveRM = new System.Windows.Forms.Button();
            this.txtRM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gVRM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCEmpHier.SuspendLayout();
            this.tabPageGM.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVGM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVManager)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVRM)).BeginInit();
            this.SuspendLayout();
            // 
            // tCEmpHier
            // 
            this.tCEmpHier.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tCEmpHier.Controls.Add(this.tabPageGM);
            this.tCEmpHier.Controls.Add(this.tabPage2);
            this.tCEmpHier.Controls.Add(this.tabPage1);
            this.tCEmpHier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCEmpHier.Location = new System.Drawing.Point(7, 12);
            this.tCEmpHier.Name = "tCEmpHier";
            this.tCEmpHier.SelectedIndex = 0;
            this.tCEmpHier.Size = new System.Drawing.Size(770, 487);
            this.tCEmpHier.TabIndex = 0;
            this.tCEmpHier.Click += new System.EventHandler(this.tCEmpHier_Click);
            // 
            // tabPageGM
            // 
            this.tabPageGM.Controls.Add(this.groupBox2);
            this.tabPageGM.Controls.Add(this.groupBox1);
            this.tabPageGM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGM.Location = new System.Drawing.Point(4, 28);
            this.tabPageGM.Name = "tabPageGM";
            this.tabPageGM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGM.Size = new System.Drawing.Size(762, 455);
            this.tabPageGM.TabIndex = 0;
            this.tabPageGM.Text = "General Manager";
            this.tabPageGM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVGM);
            this.groupBox2.Location = new System.Drawing.Point(6, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // gVGM
            // 
            this.gVGM.AllowUserToAddRows = false;
            this.gVGM.AllowUserToDeleteRows = false;
            this.gVGM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVGM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gVGM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gVGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVGM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gVGM.Location = new System.Drawing.Point(6, 15);
            this.gVGM.Name = "gVGM";
            this.gVGM.ReadOnly = true;
            this.gVGM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gVGM.Size = new System.Drawing.Size(737, 231);
            this.gVGM.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "gmName";
            this.Column1.HeaderText = "General Manager";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "auditUser";
            this.Column2.HeaderText = "Created By";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "createDate";
            this.Column3.HeaderText = "Created Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveGM);
            this.groupBox1.Controls.Add(this.txtGM);
            this.groupBox1.Controls.Add(this.lblGM);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveGM
            // 
            this.btnSaveGM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGM.Location = new System.Drawing.Point(419, 100);
            this.btnSaveGM.Name = "btnSaveGM";
            this.btnSaveGM.Size = new System.Drawing.Size(90, 30);
            this.btnSaveGM.TabIndex = 29;
            this.btnSaveGM.Text = "Save";
            this.btnSaveGM.UseVisualStyleBackColor = true;
            this.btnSaveGM.Click += new System.EventHandler(this.btnSaveGM_Click);
            // 
            // txtGM
            // 
            this.txtGM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGM.Location = new System.Drawing.Point(328, 50);
            this.txtGM.Multiline = true;
            this.txtGM.Name = "txtGM";
            this.txtGM.Size = new System.Drawing.Size(181, 26);
            this.txtGM.TabIndex = 28;
            // 
            // lblGM
            // 
            this.lblGM.AutoSize = true;
            this.lblGM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGM.Location = new System.Drawing.Point(198, 53);
            this.lblGM.Name = "lblGM";
            this.lblGM.Size = new System.Drawing.Size(106, 16);
            this.lblGM.TabIndex = 27;
            this.lblGM.Text = "General Manager";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gVManager);
            this.groupBox3.Location = new System.Drawing.Point(6, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 253);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // gVManager
            // 
            this.gVManager.AllowUserToAddRows = false;
            this.gVManager.AllowUserToDeleteRows = false;
            this.gVManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVManager.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gVManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gVManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column4,
            this.dataGridViewTextBoxColumn3});
            this.gVManager.Location = new System.Drawing.Point(6, 15);
            this.gVManager.Name = "gVManager";
            this.gVManager.ReadOnly = true;
            this.gVManager.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVManager.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gVManager.Size = new System.Drawing.Size(737, 231);
            this.gVManager.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gmName";
            this.dataGridViewTextBoxColumn1.HeaderText = "General Manager";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "managerName";
            this.Column4.HeaderText = "Manager";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Created Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbGM);
            this.groupBox4.Controls.Add(this.btnSaveManager);
            this.groupBox4.Controls.Add(this.txtManager);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 190);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "General Manager";
            // 
            // cmbGM
            // 
            this.cmbGM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGM.FormattingEnabled = true;
            this.cmbGM.Location = new System.Drawing.Point(328, 77);
            this.cmbGM.Name = "cmbGM";
            this.cmbGM.Size = new System.Drawing.Size(181, 24);
            this.cmbGM.TabIndex = 30;
            // 
            // btnSaveManager
            // 
            this.btnSaveManager.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveManager.Location = new System.Drawing.Point(419, 136);
            this.btnSaveManager.Name = "btnSaveManager";
            this.btnSaveManager.Size = new System.Drawing.Size(90, 30);
            this.btnSaveManager.TabIndex = 29;
            this.btnSaveManager.Text = "Save";
            this.btnSaveManager.UseVisualStyleBackColor = true;
            this.btnSaveManager.Click += new System.EventHandler(this.btnSaveManager_Click);
            // 
            // txtManager
            // 
            this.txtManager.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManager.Location = new System.Drawing.Point(328, 33);
            this.txtManager.Multiline = true;
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(181, 26);
            this.txtManager.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manager";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 455);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "RM/ZM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cmbManager);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cmbGMRM);
            this.groupBox5.Controls.Add(this.btnSaveRM);
            this.groupBox5.Controls.Add(this.txtRM);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 190);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Manager";
            // 
            // cmbManager
            // 
            this.cmbManager.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(329, 110);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(181, 24);
            this.cmbManager.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "General Manager";
            // 
            // cmbGMRM
            // 
            this.cmbGMRM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGMRM.FormattingEnabled = true;
            this.cmbGMRM.Location = new System.Drawing.Point(328, 67);
            this.cmbGMRM.Name = "cmbGMRM";
            this.cmbGMRM.Size = new System.Drawing.Size(181, 24);
            this.cmbGMRM.TabIndex = 32;
            // 
            // btnSaveRM
            // 
            this.btnSaveRM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRM.Location = new System.Drawing.Point(420, 154);
            this.btnSaveRM.Name = "btnSaveRM";
            this.btnSaveRM.Size = new System.Drawing.Size(90, 30);
            this.btnSaveRM.TabIndex = 29;
            this.btnSaveRM.Text = "Save";
            this.btnSaveRM.UseVisualStyleBackColor = true;
            this.btnSaveRM.Click += new System.EventHandler(this.btnRM_Click);
            // 
            // txtRM
            // 
            this.txtRM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRM.Location = new System.Drawing.Point(328, 25);
            this.txtRM.Multiline = true;
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(181, 26);
            this.txtRM.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "RM/ZM";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gVRM);
            this.groupBox6.Location = new System.Drawing.Point(6, 195);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(750, 253);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // gVRM
            // 
            this.gVRM.AllowUserToAddRows = false;
            this.gVRM.AllowUserToDeleteRows = false;
            this.gVRM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVRM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gVRM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gVRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column5,
            this.Column6,
            this.dataGridViewTextBoxColumn5});
            this.gVRM.Location = new System.Drawing.Point(6, 15);
            this.gVRM.Name = "gVRM";
            this.gVRM.ReadOnly = true;
            this.gVRM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVRM.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gVRM.Size = new System.Drawing.Size(737, 231);
            this.gVRM.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gmName";
            this.dataGridViewTextBoxColumn2.HeaderText = "General Manager";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "managerName";
            this.Column5.HeaderText = "Manager Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "rmName";
            this.Column6.HeaderText = "Regional Manager";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Created Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmEmpHierarchy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tCEmpHier);
            this.Name = "frmEmpHierarchy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Hierarchy";
            this.Load += new System.EventHandler(this.frmEmpHierarchy_Load);
            this.tCEmpHier.ResumeLayout(false);
            this.tabPageGM.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVGM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVManager)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVRM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCEmpHier;
        private System.Windows.Forms.TabPage tabPageGM;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtGM;
        private System.Windows.Forms.Label lblGM;
        private System.Windows.Forms.Button btnSaveGM;
        private System.Windows.Forms.DataGridView gVGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gVManager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGM;
        private System.Windows.Forms.Button btnSaveManager;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGMRM;
        private System.Windows.Forms.Button btnSaveRM;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView gVRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}