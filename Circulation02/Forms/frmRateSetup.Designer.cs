namespace Circulation02.Forms
{
    partial class frmRateSetup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFriRate = new System.Windows.Forms.TextBox();
            this.txtThuRate = new System.Windows.Forms.TextBox();
            this.txtWedRate = new System.Windows.Forms.TextBox();
            this.txtTueRate = new System.Windows.Forms.TextBox();
            this.txtMonRate = new System.Windows.Forms.TextBox();
            this.txtSunRate = new System.Windows.Forms.TextBox();
            this.txtSatRate = new System.Windows.Forms.TextBox();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblSun = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblThu = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatPage = new System.Windows.Forms.TextBox();
            this.txtSunPage = new System.Windows.Forms.TextBox();
            this.txtMonPage = new System.Windows.Forms.TextBox();
            this.txtTuePage = new System.Windows.Forms.TextBox();
            this.txtWedPage = new System.Windows.Forms.TextBox();
            this.txtThuPage = new System.Windows.Forms.TextBox();
            this.txtFriPage = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(308, 39);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(191, 24);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(327, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txtFriRate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtThuRate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtWedRate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTueRate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMonRate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSunRate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSatRate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWed, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSun, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblThu, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFri, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblMon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSatPage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSunPage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMonPage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTuePage, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtWedPage, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtThuPage, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFriPage, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(169, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 337);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtFriRate
            // 
            this.txtFriRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriRate.Location = new System.Drawing.Point(275, 299);
            this.txtFriRate.Multiline = true;
            this.txtFriRate.Name = "txtFriRate";
            this.txtFriRate.Size = new System.Drawing.Size(129, 34);
            this.txtFriRate.TabIndex = 23;
            this.txtFriRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThuRate
            // 
            this.txtThuRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuRate.Location = new System.Drawing.Point(275, 257);
            this.txtThuRate.Multiline = true;
            this.txtThuRate.Name = "txtThuRate";
            this.txtThuRate.Size = new System.Drawing.Size(129, 34);
            this.txtThuRate.TabIndex = 22;
            this.txtThuRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWedRate
            // 
            this.txtWedRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWedRate.Location = new System.Drawing.Point(275, 215);
            this.txtWedRate.Multiline = true;
            this.txtWedRate.Name = "txtWedRate";
            this.txtWedRate.Size = new System.Drawing.Size(129, 34);
            this.txtWedRate.TabIndex = 21;
            this.txtWedRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTueRate
            // 
            this.txtTueRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTueRate.Location = new System.Drawing.Point(275, 173);
            this.txtTueRate.Multiline = true;
            this.txtTueRate.Name = "txtTueRate";
            this.txtTueRate.Size = new System.Drawing.Size(129, 34);
            this.txtTueRate.TabIndex = 20;
            this.txtTueRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonRate
            // 
            this.txtMonRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonRate.Location = new System.Drawing.Point(275, 131);
            this.txtMonRate.Multiline = true;
            this.txtMonRate.Name = "txtMonRate";
            this.txtMonRate.Size = new System.Drawing.Size(129, 34);
            this.txtMonRate.TabIndex = 19;
            this.txtMonRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSunRate
            // 
            this.txtSunRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSunRate.Location = new System.Drawing.Point(275, 89);
            this.txtSunRate.Multiline = true;
            this.txtSunRate.Name = "txtSunRate";
            this.txtSunRate.Size = new System.Drawing.Size(129, 34);
            this.txtSunRate.TabIndex = 18;
            this.txtSunRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSatRate
            // 
            this.txtSatRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatRate.Location = new System.Drawing.Point(275, 47);
            this.txtSatRate.Multiline = true;
            this.txtSatRate.Name = "txtSatRate";
            this.txtSatRate.Size = new System.Drawing.Size(129, 34);
            this.txtSatRate.TabIndex = 12;
            this.txtSatRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWed
            // 
            this.lblWed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWed.AutoSize = true;
            this.lblWed.BackColor = System.Drawing.Color.Transparent;
            this.lblWed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWed.Location = new System.Drawing.Point(51, 212);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(35, 16);
            this.lblWed.TabIndex = 9;
            this.lblWed.Text = "WED";
            this.lblWed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSat
            // 
            this.lblSat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSat.AutoSize = true;
            this.lblSat.BackColor = System.Drawing.Color.Transparent;
            this.lblSat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSat.Location = new System.Drawing.Point(52, 44);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(32, 16);
            this.lblSat.TabIndex = 3;
            this.lblSat.Text = "SAT";
            this.lblSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSun
            // 
            this.lblSun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSun.AutoSize = true;
            this.lblSun.BackColor = System.Drawing.Color.Transparent;
            this.lblSun.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSun.Location = new System.Drawing.Point(52, 86);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(32, 16);
            this.lblSun.TabIndex = 4;
            this.lblSun.Text = "SUN";
            this.lblSun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTue
            // 
            this.lblTue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTue.AutoSize = true;
            this.lblTue.BackColor = System.Drawing.Color.Transparent;
            this.lblTue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTue.Location = new System.Drawing.Point(53, 170);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(31, 16);
            this.lblTue.TabIndex = 6;
            this.lblTue.Text = "TUE";
            this.lblTue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThu
            // 
            this.lblThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThu.AutoSize = true;
            this.lblThu.BackColor = System.Drawing.Color.Transparent;
            this.lblThu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblThu.Location = new System.Drawing.Point(52, 254);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(32, 16);
            this.lblThu.TabIndex = 8;
            this.lblThu.Text = "THU";
            this.lblThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFri
            // 
            this.lblFri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFri.AutoSize = true;
            this.lblFri.BackColor = System.Drawing.Color.Transparent;
            this.lblFri.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFri.Location = new System.Drawing.Point(55, 296);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(27, 16);
            this.lblFri.TabIndex = 9;
            this.lblFri.Text = "FRI";
            this.lblFri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMon
            // 
            this.lblMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMon.AutoSize = true;
            this.lblMon.BackColor = System.Drawing.Color.Transparent;
            this.lblMon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMon.Location = new System.Drawing.Point(51, 128);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(35, 16);
            this.lblMon.TabIndex = 5;
            this.lblMon.Text = "MON";
            this.lblMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label22.Location = new System.Drawing.Point(159, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "No. Of Pages";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(320, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSatPage
            // 
            this.txtSatPage.BackColor = System.Drawing.SystemColors.Window;
            this.txtSatPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatPage.Location = new System.Drawing.Point(140, 47);
            this.txtSatPage.Multiline = true;
            this.txtSatPage.Name = "txtSatPage";
            this.txtSatPage.Size = new System.Drawing.Size(127, 34);
            this.txtSatPage.TabIndex = 11;
            this.txtSatPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSunPage
            // 
            this.txtSunPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSunPage.Location = new System.Drawing.Point(140, 89);
            this.txtSunPage.Multiline = true;
            this.txtSunPage.Name = "txtSunPage";
            this.txtSunPage.Size = new System.Drawing.Size(127, 34);
            this.txtSunPage.TabIndex = 12;
            this.txtSunPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonPage
            // 
            this.txtMonPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonPage.Location = new System.Drawing.Point(140, 131);
            this.txtMonPage.Multiline = true;
            this.txtMonPage.Name = "txtMonPage";
            this.txtMonPage.Size = new System.Drawing.Size(127, 34);
            this.txtMonPage.TabIndex = 13;
            this.txtMonPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTuePage
            // 
            this.txtTuePage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuePage.Location = new System.Drawing.Point(140, 173);
            this.txtTuePage.Multiline = true;
            this.txtTuePage.Name = "txtTuePage";
            this.txtTuePage.Size = new System.Drawing.Size(127, 34);
            this.txtTuePage.TabIndex = 14;
            this.txtTuePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWedPage
            // 
            this.txtWedPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWedPage.Location = new System.Drawing.Point(140, 215);
            this.txtWedPage.Multiline = true;
            this.txtWedPage.Name = "txtWedPage";
            this.txtWedPage.Size = new System.Drawing.Size(127, 34);
            this.txtWedPage.TabIndex = 15;
            this.txtWedPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThuPage
            // 
            this.txtThuPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuPage.Location = new System.Drawing.Point(140, 257);
            this.txtThuPage.Multiline = true;
            this.txtThuPage.Name = "txtThuPage";
            this.txtThuPage.Size = new System.Drawing.Size(127, 34);
            this.txtThuPage.TabIndex = 16;
            this.txtThuPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFriPage
            // 
            this.txtFriPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriPage.Location = new System.Drawing.Point(140, 299);
            this.txtFriPage.Multiline = true;
            this.txtFriPage.Name = "txtFriPage";
            this.txtFriPage.Size = new System.Drawing.Size(127, 34);
            this.txtFriPage.TabIndex = 17;
            this.txtFriPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label21.Location = new System.Drawing.Point(52, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Day";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRateSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRateSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Setup";
            this.Load += new System.EventHandler(this.frmRateSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSatPage;
        private System.Windows.Forms.TextBox txtFriRate;
        private System.Windows.Forms.TextBox txtThuRate;
        private System.Windows.Forms.TextBox txtWedRate;
        private System.Windows.Forms.TextBox txtTueRate;
        private System.Windows.Forms.TextBox txtMonRate;
        private System.Windows.Forms.TextBox txtSunRate;
        private System.Windows.Forms.TextBox txtSatRate;
        private System.Windows.Forms.TextBox txtSunPage;
        private System.Windows.Forms.TextBox txtMonPage;
        private System.Windows.Forms.TextBox txtTuePage;
        private System.Windows.Forms.TextBox txtWedPage;
        private System.Windows.Forms.TextBox txtThuPage;
        private System.Windows.Forms.TextBox txtFriPage;
    }
}