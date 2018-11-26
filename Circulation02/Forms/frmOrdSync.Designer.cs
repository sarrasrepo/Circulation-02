namespace Circulation02.Forms
{
    partial class frmOrdSync
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gVOrdSync = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPrvw = new System.Windows.Forms.Button();
            this.cmbSalesType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPOrdDateTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dTpOrdDateFrm = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotOrd = new System.Windows.Forms.Label();
            this.lblOrdCopy = new System.Windows.Forms.Label();
            this.lblTotOrdVal = new System.Windows.Forms.Label();
            this.lblOrdCopyVal = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVOrdSync)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOrdCopyVal);
            this.groupBox2.Controls.Add(this.lblTotOrdVal);
            this.groupBox2.Controls.Add(this.lblOrdCopy);
            this.groupBox2.Controls.Add(this.lblTotOrd);
            this.groupBox2.Controls.Add(this.gVOrdSync);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnReverse);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.btnPrvw);
            this.groupBox2.Controls.Add(this.cmbSalesType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbCat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dTPOrdDateTo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dTpOrdDateFrm);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 504);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gVOrdSync
            // 
            this.gVOrdSync.AllowUserToAddRows = false;
            this.gVOrdSync.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gVOrdSync.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gVOrdSync.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVOrdSync.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gVOrdSync.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gVOrdSync.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVOrdSync.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gVOrdSync.DefaultCellStyle = dataGridViewCellStyle3;
            this.gVOrdSync.Location = new System.Drawing.Point(5, 130);
            this.gVOrdSync.Name = "gVOrdSync";
            this.gVOrdSync.ReadOnly = true;
            this.gVOrdSync.Size = new System.Drawing.Size(762, 341);
            this.gVOrdSync.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 2);
            this.label1.TabIndex = 160;
            this.label1.Text = "label1";
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(659, 83);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(105, 30);
            this.btnReverse.TabIndex = 159;
            this.btnReverse.TabStop = false;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(537, 83);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(105, 30);
            this.btnPost.TabIndex = 158;
            this.btnPost.TabStop = false;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPrvw
            // 
            this.btnPrvw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrvw.Location = new System.Drawing.Point(415, 83);
            this.btnPrvw.Name = "btnPrvw";
            this.btnPrvw.Size = new System.Drawing.Size(105, 30);
            this.btnPrvw.TabIndex = 157;
            this.btnPrvw.TabStop = false;
            this.btnPrvw.Text = "Preview";
            this.btnPrvw.UseVisualStyleBackColor = true;
            this.btnPrvw.Click += new System.EventHandler(this.btnPrvw_Click);
            // 
            // cmbSalesType
            // 
            this.cmbSalesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalesType.FormattingEnabled = true;
            this.cmbSalesType.Location = new System.Drawing.Point(115, 57);
            this.cmbSalesType.Name = "cmbSalesType";
            this.cmbSalesType.Size = new System.Drawing.Size(154, 24);
            this.cmbSalesType.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 145;
            this.label4.Text = "Sales Type";
            // 
            // cmbCat
            // 
            this.cmbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(613, 18);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(149, 24);
            this.cmbCat.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 143;
            this.label6.Text = "Category";
            // 
            // dTPOrdDateTo
            // 
            this.dTPOrdDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPOrdDateTo.Location = new System.Drawing.Point(378, 16);
            this.dTPOrdDateTo.Name = "dTPOrdDateTo";
            this.dTPOrdDateTo.Size = new System.Drawing.Size(162, 23);
            this.dTPOrdDateTo.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 141;
            this.label7.Text = "Order Date To";
            // 
            // dTpOrdDateFrm
            // 
            this.dTpOrdDateFrm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTpOrdDateFrm.Location = new System.Drawing.Point(115, 16);
            this.dTpOrdDateFrm.Name = "dTpOrdDateFrm";
            this.dTpOrdDateFrm.Size = new System.Drawing.Size(154, 23);
            this.dTpOrdDateFrm.TabIndex = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 139;
            this.label8.Text = "Order Date From";
            // 
            // lblTotOrd
            // 
            this.lblTotOrd.AutoSize = true;
            this.lblTotOrd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotOrd.Location = new System.Drawing.Point(5, 478);
            this.lblTotOrd.Name = "lblTotOrd";
            this.lblTotOrd.Size = new System.Drawing.Size(83, 16);
            this.lblTotOrd.TabIndex = 162;
            this.lblTotOrd.Text = "Total Order :";
            // 
            // lblOrdCopy
            // 
            this.lblOrdCopy.AutoSize = true;
            this.lblOrdCopy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdCopy.Location = new System.Drawing.Point(567, 478);
            this.lblOrdCopy.Name = "lblOrdCopy";
            this.lblOrdCopy.Size = new System.Drawing.Size(115, 16);
            this.lblOrdCopy.TabIndex = 163;
            this.lblOrdCopy.Text = "Total Order Copy :";
            // 
            // lblTotOrdVal
            // 
            this.lblTotOrdVal.AutoSize = true;
            this.lblTotOrdVal.BackColor = System.Drawing.Color.Green;
            this.lblTotOrdVal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotOrdVal.ForeColor = System.Drawing.Color.White;
            this.lblTotOrdVal.Location = new System.Drawing.Point(87, 478);
            this.lblTotOrdVal.Name = "lblTotOrdVal";
            this.lblTotOrdVal.Size = new System.Drawing.Size(0, 16);
            this.lblTotOrdVal.TabIndex = 164;
            // 
            // lblOrdCopyVal
            // 
            this.lblOrdCopyVal.AutoSize = true;
            this.lblOrdCopyVal.BackColor = System.Drawing.Color.Green;
            this.lblOrdCopyVal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdCopyVal.ForeColor = System.Drawing.Color.White;
            this.lblOrdCopyVal.Location = new System.Drawing.Point(682, 479);
            this.lblOrdCopyVal.Name = "lblOrdCopyVal";
            this.lblOrdCopyVal.Size = new System.Drawing.Size(0, 16);
            this.lblOrdCopyVal.TabIndex = 165;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stationName";
            this.Column1.HeaderText = "Station Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "quantity";
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "complementaryCopy";
            this.Column3.HeaderText = "Complementary";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "bonusCopy";
            this.Column4.HeaderText = "Bonus Copy";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "daywiseChngQuantity";
            this.Column5.HeaderText = "Daily Change Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "daywiseDefQuanttity";
            this.Column6.HeaderText = "Default Change Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frmOrdSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmOrdSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Synchronization";
            this.Load += new System.EventHandler(this.frmOrdSync_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVOrdSync)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPrvw;
        private System.Windows.Forms.ComboBox cmbSalesType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPOrdDateTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTpOrdDateFrm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gVOrdSync;
        private System.Windows.Forms.Label lblOrdCopyVal;
        private System.Windows.Forms.Label lblTotOrdVal;
        private System.Windows.Forms.Label lblOrdCopy;
        private System.Windows.Forms.Label lblTotOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}