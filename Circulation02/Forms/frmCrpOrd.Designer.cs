namespace Circulation02.Forms
{
    partial class frmCrpOrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrpOrd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRgn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgntId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFinder = new System.Windows.Forms.Button();
            this.cmbStat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCrpCust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPOrdDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgntFinder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgntFinder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbRgn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAgntId);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnFinder);
            this.groupBox1.Controls.Add(this.cmbStat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCrpCust);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dTPOrdDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(767, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(746, 2);
            this.label6.TabIndex = 153;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(609, 250);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 152;
            this.btnSave.Text = "Save Order";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(531, 167);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(189, 27);
            this.txtQty.TabIndex = 151;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 150;
            this.label4.Text = "Quantity";
            // 
            // cmbRgn
            // 
            this.cmbRgn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRgn.FormattingEnabled = true;
            this.cmbRgn.Location = new System.Drawing.Point(531, 116);
            this.cmbRgn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRgn.Name = "cmbRgn";
            this.cmbRgn.Size = new System.Drawing.Size(188, 24);
            this.cmbRgn.TabIndex = 149;
            this.cmbRgn.SelectedIndexChanged += new System.EventHandler(this.cmbRgn_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 148;
            this.label3.Text = "Region";
            // 
            // txtAgntId
            // 
            this.txtAgntId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgntId.Location = new System.Drawing.Point(530, 59);
            this.txtAgntId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAgntId.Multiline = true;
            this.txtAgntId.Name = "txtAgntId";
            this.txtAgntId.Size = new System.Drawing.Size(189, 26);
            this.txtAgntId.TabIndex = 147;
            this.txtAgntId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(431, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "Agent ID";
            // 
            // btnFinder
            // 
            this.btnFinder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnFinder.Image")));
            this.btnFinder.Location = new System.Drawing.Point(845, 58);
            this.btnFinder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(31, 27);
            this.btnFinder.TabIndex = 145;
            this.btnFinder.UseVisualStyleBackColor = true;
            // 
            // cmbStat
            // 
            this.cmbStat.Enabled = false;
            this.cmbStat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Location = new System.Drawing.Point(162, 170);
            this.cmbStat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(188, 24);
            this.cmbStat.TabIndex = 144;
            this.cmbStat.SelectedIndexChanged += new System.EventHandler(this.cmbStat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 143;
            this.label1.Text = "Station";
            // 
            // cmbCrpCust
            // 
            this.cmbCrpCust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrpCust.FormattingEnabled = true;
            this.cmbCrpCust.Location = new System.Drawing.Point(162, 116);
            this.cmbCrpCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCrpCust.Name = "cmbCrpCust";
            this.cmbCrpCust.Size = new System.Drawing.Size(188, 24);
            this.cmbCrpCust.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 141;
            this.label2.Text = "Crp. Customer";
            // 
            // dTPOrdDate
            // 
            this.dTPOrdDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPOrdDate.Location = new System.Drawing.Point(162, 62);
            this.dTPOrdDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTPOrdDate.Name = "dTPOrdDate";
            this.dTPOrdDate.Size = new System.Drawing.Size(188, 23);
            this.dTPOrdDate.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 139;
            this.label5.Text = "Order Date";
            // 
            // btnAgntFinder
            // 
            this.btnAgntFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnAgntFinder.Image")));
            this.btnAgntFinder.Location = new System.Drawing.Point(725, 58);
            this.btnAgntFinder.Name = "btnAgntFinder";
            this.btnAgntFinder.Size = new System.Drawing.Size(31, 27);
            this.btnAgntFinder.TabIndex = 154;
            this.btnAgntFinder.UseVisualStyleBackColor = true;
            this.btnAgntFinder.Click += new System.EventHandler(this.btnAgntFinder_Click);
            // 
            // frmCrpOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCrpOrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corporate Order";
            this.Load += new System.EventHandler(this.frmCrpOrd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTPOrdDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCrpCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinder;
        private System.Windows.Forms.TextBox txtAgntId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRgn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgntFinder;
    }
}