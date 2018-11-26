namespace Circulation02.Forms
{
    partial class frmCopyOrd
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
            this.gBCOrder = new System.Windows.Forms.GroupBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.dTPSpcDate = new System.Windows.Forms.DateTimePicker();
            this.rBSameDay = new System.Windows.Forms.RadioButton();
            this.rBPrevDate = new System.Windows.Forms.RadioButton();
            this.rBSpcDate = new System.Windows.Forms.RadioButton();
            this.dTPTransDate = new System.Windows.Forms.DateTimePicker();
            this.btnUDQ = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cmbToSRoute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbToRoute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFrmSRoute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFrmRoute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSLine = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gBCOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBCOrder
            // 
            this.gBCOrder.Controls.Add(this.lblConfirm);
            this.gBCOrder.Controls.Add(this.dTPSpcDate);
            this.gBCOrder.Controls.Add(this.rBSameDay);
            this.gBCOrder.Controls.Add(this.rBPrevDate);
            this.gBCOrder.Controls.Add(this.rBSpcDate);
            this.gBCOrder.Controls.Add(this.dTPTransDate);
            this.gBCOrder.Controls.Add(this.btnUDQ);
            this.gBCOrder.Controls.Add(this.btnProcess);
            this.gBCOrder.Controls.Add(this.cmbToSRoute);
            this.gBCOrder.Controls.Add(this.label5);
            this.gBCOrder.Controls.Add(this.cmbToRoute);
            this.gBCOrder.Controls.Add(this.label6);
            this.gBCOrder.Controls.Add(this.cmbFrmSRoute);
            this.gBCOrder.Controls.Add(this.label4);
            this.gBCOrder.Controls.Add(this.cmbFrmRoute);
            this.gBCOrder.Controls.Add(this.label2);
            this.gBCOrder.Controls.Add(this.lblSLine);
            this.gBCOrder.Controls.Add(this.cmbCat);
            this.gBCOrder.Controls.Add(this.label3);
            this.gBCOrder.Controls.Add(this.label13);
            this.gBCOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBCOrder.Location = new System.Drawing.Point(10, 5);
            this.gBCOrder.Name = "gBCOrder";
            this.gBCOrder.Size = new System.Drawing.Size(763, 305);
            this.gBCOrder.TabIndex = 0;
            this.gBCOrder.TabStop = false;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Chartreuse;
            this.lblConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConfirm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(142, 251);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(2, 18);
            this.lblConfirm.TabIndex = 137;
            // 
            // dTPSpcDate
            // 
            this.dTPSpcDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPSpcDate.Location = new System.Drawing.Point(561, 25);
            this.dTPSpcDate.Name = "dTPSpcDate";
            this.dTPSpcDate.Size = new System.Drawing.Size(162, 23);
            this.dTPSpcDate.TabIndex = 136;
            this.dTPSpcDate.Visible = false;
            // 
            // rBSameDay
            // 
            this.rBSameDay.AutoSize = true;
            this.rBSameDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBSameDay.Location = new System.Drawing.Point(411, 78);
            this.rBSameDay.Name = "rBSameDay";
            this.rBSameDay.Size = new System.Drawing.Size(182, 20);
            this.rBSameDay.TabIndex = 135;
            this.rBSameDay.Text = "Same Day (Previous Week)";
            this.rBSameDay.UseVisualStyleBackColor = true;
            this.rBSameDay.CheckedChanged += new System.EventHandler(this.rBSpcDate_CheckedChanged);
            // 
            // rBPrevDate
            // 
            this.rBPrevDate.AutoSize = true;
            this.rBPrevDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPrevDate.Location = new System.Drawing.Point(412, 52);
            this.rBPrevDate.Name = "rBPrevDate";
            this.rBPrevDate.Size = new System.Drawing.Size(104, 20);
            this.rBPrevDate.TabIndex = 134;
            this.rBPrevDate.Text = "Previous Date";
            this.rBPrevDate.UseVisualStyleBackColor = true;
            this.rBPrevDate.CheckedChanged += new System.EventHandler(this.rBSpcDate_CheckedChanged);
            // 
            // rBSpcDate
            // 
            this.rBSpcDate.AutoSize = true;
            this.rBSpcDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBSpcDate.Location = new System.Drawing.Point(412, 23);
            this.rBSpcDate.Name = "rBSpcDate";
            this.rBSpcDate.Size = new System.Drawing.Size(100, 20);
            this.rBSpcDate.TabIndex = 133;
            this.rBSpcDate.Text = "Specific Date";
            this.rBSpcDate.UseVisualStyleBackColor = true;
            this.rBSpcDate.CheckedChanged += new System.EventHandler(this.rBSpcDate_CheckedChanged);
            // 
            // dTPTransDate
            // 
            this.dTPTransDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPTransDate.Location = new System.Drawing.Point(145, 22);
            this.dTPTransDate.Name = "dTPTransDate";
            this.dTPTransDate.Size = new System.Drawing.Size(162, 23);
            this.dTPTransDate.TabIndex = 127;
            // 
            // btnUDQ
            // 
            this.btnUDQ.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDQ.Location = new System.Drawing.Point(574, 244);
            this.btnUDQ.Name = "btnUDQ";
            this.btnUDQ.Size = new System.Drawing.Size(151, 30);
            this.btnUDQ.TabIndex = 126;
            this.btnUDQ.Text = "Update Daily Quantity";
            this.btnUDQ.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(462, 244);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(90, 30);
            this.btnProcess.TabIndex = 125;
            this.btnProcess.TabStop = false;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cmbToSRoute
            // 
            this.cmbToSRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToSRoute.FormattingEnabled = true;
            this.cmbToSRoute.Location = new System.Drawing.Point(562, 184);
            this.cmbToSRoute.Name = "cmbToSRoute";
            this.cmbToSRoute.Size = new System.Drawing.Size(162, 24);
            this.cmbToSRoute.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "To Sub-Route";
            // 
            // cmbToRoute
            // 
            this.cmbToRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToRoute.FormattingEnabled = true;
            this.cmbToRoute.Location = new System.Drawing.Point(562, 143);
            this.cmbToRoute.Name = "cmbToRoute";
            this.cmbToRoute.Size = new System.Drawing.Size(162, 24);
            this.cmbToRoute.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 121;
            this.label6.Text = "To Route";
            // 
            // cmbFrmSRoute
            // 
            this.cmbFrmSRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrmSRoute.FormattingEnabled = true;
            this.cmbFrmSRoute.Location = new System.Drawing.Point(145, 184);
            this.cmbFrmSRoute.Name = "cmbFrmSRoute";
            this.cmbFrmSRoute.Size = new System.Drawing.Size(162, 24);
            this.cmbFrmSRoute.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 119;
            this.label4.Text = "From Sub-Route";
            // 
            // cmbFrmRoute
            // 
            this.cmbFrmRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrmRoute.FormattingEnabled = true;
            this.cmbFrmRoute.Location = new System.Drawing.Point(144, 143);
            this.cmbFrmRoute.Name = "cmbFrmRoute";
            this.cmbFrmRoute.Size = new System.Drawing.Size(162, 24);
            this.cmbFrmRoute.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "From Route";
            // 
            // lblSLine
            // 
            this.lblSLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSLine.Location = new System.Drawing.Point(2, 119);
            this.lblSLine.Name = "lblSLine";
            this.lblSLine.Size = new System.Drawing.Size(760, 2);
            this.lblSLine.TabIndex = 0;
            // 
            // cmbCat
            // 
            this.cmbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(144, 62);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(162, 24);
            this.cmbCat.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 106;
            this.label13.Text = "Transaction Date";
            // 
            // frmCopyOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.gBCOrder);
            this.Name = "frmCopyOrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Order";
            this.Load += new System.EventHandler(this.frmCopyOrd_Load);
            this.gBCOrder.ResumeLayout(false);
            this.gBCOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBCOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbToSRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbToRoute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFrmSRoute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFrmRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSLine;
        private System.Windows.Forms.Button btnUDQ;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DateTimePicker dTPTransDate;
        private System.Windows.Forms.DateTimePicker dTPSpcDate;
        private System.Windows.Forms.RadioButton rBSameDay;
        private System.Windows.Forms.RadioButton rBPrevDate;
        private System.Windows.Forms.RadioButton rBSpcDate;
        private System.Windows.Forms.Label lblConfirm;
    }
}