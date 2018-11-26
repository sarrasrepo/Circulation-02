namespace Circulation02.Forms
{
    partial class frmOrdEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDtl = new System.Windows.Forms.GroupBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.txtOdrId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgntId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSubRoute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEdition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSalesType = new System.Windows.Forms.ComboBox();
            this.panelSalesTyp = new System.Windows.Forms.Panel();
            this.rBFloatStrt = new System.Windows.Forms.RadioButton();
            this.rBFloatOut = new System.Windows.Forms.RadioButton();
            this.panelCorp = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.gbhdr = new System.Windows.Forms.GroupBox();
            this.cBCorp = new System.Windows.Forms.CheckBox();
            this.cBLW = new System.Windows.Forms.CheckBox();
            this.rBPre = new System.Windows.Forms.RadioButton();
            this.rBPost = new System.Windows.Forms.RadioButton();
            this.dTPOrdDate = new System.Windows.Forms.DateTimePicker();
            this.brnFindAgnt = new System.Windows.Forms.Button();
            this.btnFindOrd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.panelSalesTyp.SuspendLayout();
            this.panelCorp.SuspendLayout();
            this.gbhdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDtl
            // 
            this.gbDtl.Controls.Add(this.btnPost);
            this.gbDtl.Controls.Add(this.btnSave);
            this.gbDtl.Controls.Add(this.groupBox3);
            this.gbDtl.Controls.Add(this.gvOrder);
            this.gbDtl.Location = new System.Drawing.Point(7, 242);
            this.gbDtl.Name = "gbDtl";
            this.gbDtl.Size = new System.Drawing.Size(774, 264);
            this.gbDtl.TabIndex = 1;
            this.gbDtl.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(400, 221);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(90, 30);
            this.btnPost.TabIndex = 142;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(283, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 141;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(7, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // gvOrder
            // 
            this.gvOrder.AllowUserToAddRows = false;
            this.gvOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Empty;
            this.gvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvOrder.DefaultCellStyle = dataGridViewCellStyle12;
            this.gvOrder.Location = new System.Drawing.Point(6, 11);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.Size = new System.Drawing.Size(762, 200);
            this.gvOrder.TabIndex = 0;
            // 
            // txtOdrId
            // 
            this.txtOdrId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdrId.Location = new System.Drawing.Point(284, 18);
            this.txtOdrId.Multiline = true;
            this.txtOdrId.Name = "txtOdrId";
            this.txtOdrId.Size = new System.Drawing.Size(199, 23);
            this.txtOdrId.TabIndex = 24;
            this.txtOdrId.Text = "***** New *****";
            this.txtOdrId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Order Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 104;
            this.label13.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Agent ID";
            // 
            // txtAgntId
            // 
            this.txtAgntId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgntId.HideSelection = false;
            this.txtAgntId.Location = new System.Drawing.Point(135, 93);
            this.txtAgntId.Multiline = true;
            this.txtAgntId.Name = "txtAgntId";
            this.txtAgntId.Size = new System.Drawing.Size(163, 23);
            this.txtAgntId.TabIndex = 107;
            this.txtAgntId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgntId.TextChanged += new System.EventHandler(this.txtAgntId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Sub-Route";
            // 
            // cmbSubRoute
            // 
            this.cmbSubRoute.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSubRoute.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubRoute.FormattingEnabled = true;
            this.cmbSubRoute.Location = new System.Drawing.Point(136, 130);
            this.cmbSubRoute.Name = "cmbSubRoute";
            this.cmbSubRoute.Size = new System.Drawing.Size(162, 24);
            this.cmbSubRoute.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "Vehicle";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.BackColor = System.Drawing.SystemColors.Control;
            this.cmbVehicle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(136, 169);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(162, 24);
            this.cmbVehicle.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Edition";
            // 
            // cmbEdition
            // 
            this.cmbEdition.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEdition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdition.FormattingEnabled = true;
            this.cmbEdition.Items.AddRange(new object[] {
            "---- Select ----",
            "City Edition",
            "North Edition",
            "South Edition"});
            this.cmbEdition.Location = new System.Drawing.Point(136, 210);
            this.cmbEdition.Name = "cmbEdition";
            this.cmbEdition.Size = new System.Drawing.Size(162, 24);
            this.cmbEdition.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 117;
            this.label6.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(560, 55);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(162, 24);
            this.cmbCategory.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 106;
            this.label7.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(561, 93);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(163, 23);
            this.txtRate.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 119;
            this.label8.Text = "Sales Type";
            // 
            // cmbSalesType
            // 
            this.cmbSalesType.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSalesType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalesType.FormattingEnabled = true;
            this.cmbSalesType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbSalesType.Location = new System.Drawing.Point(561, 131);
            this.cmbSalesType.Name = "cmbSalesType";
            this.cmbSalesType.Size = new System.Drawing.Size(162, 24);
            this.cmbSalesType.TabIndex = 120;
            this.cmbSalesType.Text = "    ---- Select ----";
            this.cmbSalesType.SelectedIndexChanged += new System.EventHandler(this.cmbSalesType_SelectedIndexChanged);
            // 
            // panelSalesTyp
            // 
            this.panelSalesTyp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSalesTyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSalesTyp.Controls.Add(this.rBFloatOut);
            this.panelSalesTyp.Controls.Add(this.rBFloatStrt);
            this.panelSalesTyp.Location = new System.Drawing.Point(468, 172);
            this.panelSalesTyp.Name = "panelSalesTyp";
            this.panelSalesTyp.Size = new System.Drawing.Size(255, 33);
            this.panelSalesTyp.TabIndex = 121;
            this.panelSalesTyp.Visible = false;
            // 
            // rBFloatStrt
            // 
            this.rBFloatStrt.AutoSize = true;
            this.rBFloatStrt.Location = new System.Drawing.Point(12, 5);
            this.rBFloatStrt.Name = "rBFloatStrt";
            this.rBFloatStrt.Size = new System.Drawing.Size(110, 20);
            this.rBFloatStrt.TabIndex = 0;
            this.rBFloatStrt.TabStop = true;
            this.rBFloatStrt.Text = "Floating Street";
            this.rBFloatStrt.UseVisualStyleBackColor = true;
            this.rBFloatStrt.Visible = false;
            // 
            // rBFloatOut
            // 
            this.rBFloatOut.AutoSize = true;
            this.rBFloatOut.Location = new System.Drawing.Point(134, 5);
            this.rBFloatOut.Name = "rBFloatOut";
            this.rBFloatOut.Size = new System.Drawing.Size(109, 20);
            this.rBFloatOut.TabIndex = 1;
            this.rBFloatOut.TabStop = true;
            this.rBFloatOut.Text = "Floating Outlet";
            this.rBFloatOut.UseVisualStyleBackColor = true;
            this.rBFloatOut.Visible = false;
            // 
            // panelCorp
            // 
            this.panelCorp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCorp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCorp.Controls.Add(this.rBPost);
            this.panelCorp.Controls.Add(this.rBPre);
            this.panelCorp.Location = new System.Drawing.Point(469, 205);
            this.panelCorp.Name = "panelCorp";
            this.panelCorp.Size = new System.Drawing.Size(254, 31);
            this.panelCorp.TabIndex = 122;
            this.panelCorp.Visible = false;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(469, 171);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(254, 32);
            this.panel.TabIndex = 125;
            this.panel.Visible = false;
            // 
            // gbhdr
            // 
            this.gbhdr.Controls.Add(this.dTPOrdDate);
            this.gbhdr.Controls.Add(this.cBCorp);
            this.gbhdr.Controls.Add(this.cBLW);
            this.gbhdr.Controls.Add(this.panel);
            this.gbhdr.Controls.Add(this.panelCorp);
            this.gbhdr.Controls.Add(this.panelSalesTyp);
            this.gbhdr.Controls.Add(this.cmbSalesType);
            this.gbhdr.Controls.Add(this.label8);
            this.gbhdr.Controls.Add(this.txtRate);
            this.gbhdr.Controls.Add(this.label7);
            this.gbhdr.Controls.Add(this.cmbCategory);
            this.gbhdr.Controls.Add(this.label6);
            this.gbhdr.Controls.Add(this.brnFindAgnt);
            this.gbhdr.Controls.Add(this.cmbEdition);
            this.gbhdr.Controls.Add(this.label5);
            this.gbhdr.Controls.Add(this.cmbVehicle);
            this.gbhdr.Controls.Add(this.label4);
            this.gbhdr.Controls.Add(this.cmbSubRoute);
            this.gbhdr.Controls.Add(this.label3);
            this.gbhdr.Controls.Add(this.txtAgntId);
            this.gbhdr.Controls.Add(this.label2);
            this.gbhdr.Controls.Add(this.label13);
            this.gbhdr.Controls.Add(this.btnFindOrd);
            this.gbhdr.Controls.Add(this.btnNew);
            this.gbhdr.Controls.Add(this.label1);
            this.gbhdr.Controls.Add(this.txtOdrId);
            this.gbhdr.Controls.Add(this.btnLast);
            this.gbhdr.Controls.Add(this.btnNext);
            this.gbhdr.Controls.Add(this.btnPrev);
            this.gbhdr.Controls.Add(this.btnFirst);
            this.gbhdr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbhdr.Location = new System.Drawing.Point(8, -1);
            this.gbhdr.Name = "gbhdr";
            this.gbhdr.Size = new System.Drawing.Size(774, 243);
            this.gbhdr.TabIndex = 0;
            this.gbhdr.TabStop = false;
            // 
            // cBCorp
            // 
            this.cBCorp.AutoSize = true;
            this.cBCorp.Location = new System.Drawing.Point(604, 179);
            this.cBCorp.Name = "cBCorp";
            this.cBCorp.Size = new System.Drawing.Size(84, 20);
            this.cBCorp.TabIndex = 128;
            this.cBCorp.Text = "Corporate";
            this.cBCorp.UseVisualStyleBackColor = true;
            this.cBCorp.Visible = false;
            this.cBCorp.CheckedChanged += new System.EventHandler(this.cBCorp_CheckedChanged);
            // 
            // cBLW
            // 
            this.cBLW.AutoSize = true;
            this.cBLW.Location = new System.Drawing.Point(481, 180);
            this.cBLW.Name = "cBLW";
            this.cBLW.Size = new System.Drawing.Size(82, 20);
            this.cBLW.TabIndex = 127;
            this.cBLW.Text = "Line Wise";
            this.cBLW.UseVisualStyleBackColor = true;
            this.cBLW.Visible = false;
            // 
            // rBPre
            // 
            this.rBPre.AutoSize = true;
            this.rBPre.Location = new System.Drawing.Point(11, 4);
            this.rBPre.Name = "rBPre";
            this.rBPre.Size = new System.Drawing.Size(74, 20);
            this.rBPre.TabIndex = 0;
            this.rBPre.TabStop = true;
            this.rBPre.Text = "Pre-Paid";
            this.rBPre.UseVisualStyleBackColor = true;
            // 
            // rBPost
            // 
            this.rBPost.AutoSize = true;
            this.rBPost.Location = new System.Drawing.Point(135, 4);
            this.rBPost.Name = "rBPost";
            this.rBPost.Size = new System.Drawing.Size(79, 20);
            this.rBPost.TabIndex = 1;
            this.rBPost.TabStop = true;
            this.rBPost.Text = "Post-Paid";
            this.rBPost.UseVisualStyleBackColor = true;
            // 
            // dTPOrdDate
            // 
            this.dTPOrdDate.CustomFormat = "dd-MMM-yyyy";
            this.dTPOrdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPOrdDate.Location = new System.Drawing.Point(135, 56);
            this.dTPOrdDate.Name = "dTPOrdDate";
            this.dTPOrdDate.Size = new System.Drawing.Size(163, 23);
            this.dTPOrdDate.TabIndex = 129;
            // 
            // brnFindAgnt
            // 
            this.brnFindAgnt.Image = ((System.Drawing.Image)(resources.GetObject("brnFindAgnt.Image")));
            this.brnFindAgnt.Location = new System.Drawing.Point(304, 93);
            this.brnFindAgnt.Name = "brnFindAgnt";
            this.brnFindAgnt.Size = new System.Drawing.Size(31, 23);
            this.brnFindAgnt.TabIndex = 116;
            this.brnFindAgnt.UseVisualStyleBackColor = true;
            this.brnFindAgnt.Click += new System.EventHandler(this.brnFindAgnt_Click);
            // 
            // btnFindOrd
            // 
            this.btnFindOrd.Image = ((System.Drawing.Image)(resources.GetObject("btnFindOrd.Image")));
            this.btnFindOrd.Location = new System.Drawing.Point(582, 18);
            this.btnFindOrd.Name = "btnFindOrd";
            this.btnFindOrd.Size = new System.Drawing.Size(31, 23);
            this.btnFindOrd.TabIndex = 27;
            this.btnFindOrd.UseVisualStyleBackColor = true;
            this.btnFindOrd.Click += new System.EventHandler(this.btnFindOrd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(550, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(31, 23);
            this.btnNew.TabIndex = 26;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(519, 18);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(31, 23);
            this.btnLast.TabIndex = 23;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(488, 18);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 22;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(248, 18);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(31, 23);
            this.btnPrev.TabIndex = 20;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(217, 18);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(31, 23);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stationName";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column1.HeaderText = "Station";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "quantity";
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bonusCopy";
            this.Column3.HeaderText = "Bonus Copy";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "complementaryCopy";
            this.Column4.HeaderText = "Complementary Copy";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "packetType";
            this.Column5.HeaderText = "Packet Type";
            this.Column5.Name = "Column5";
            // 
            // frmOrdEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 512);
            this.Controls.Add(this.gbhdr);
            this.Controls.Add(this.gbDtl);
            this.Name = "frmOrdEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Entry";
            this.Load += new System.EventHandler(this.frmOrdEntry_Load);
            this.gbDtl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.panelSalesTyp.ResumeLayout(false);
            this.panelSalesTyp.PerformLayout();
            this.panelCorp.ResumeLayout(false);
            this.panelCorp.PerformLayout();
            this.gbhdr.ResumeLayout(false);
            this.gbhdr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDtl;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtOdrId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnFindOrd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSubRoute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEdition;
        private System.Windows.Forms.Button brnFindAgnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSalesType;
        private System.Windows.Forms.Panel panelSalesTyp;
        private System.Windows.Forms.RadioButton rBFloatOut;
        private System.Windows.Forms.RadioButton rBFloatStrt;
        private System.Windows.Forms.Panel panelCorp;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox gbhdr;
        private System.Windows.Forms.CheckBox cBCorp;
        private System.Windows.Forms.CheckBox cBLW;
        private System.Windows.Forms.RadioButton rBPost;
        private System.Windows.Forms.RadioButton rBPre;
        private System.Windows.Forms.DateTimePicker dTPOrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.TextBox txtAgntId;
        public System.Windows.Forms.TextBox txtRate;
    }
}