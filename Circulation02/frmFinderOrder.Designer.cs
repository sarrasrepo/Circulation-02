﻿namespace Circulation02
{
    partial class frmFinderOrder
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.cmbFindBy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.dTPOrdDate = new System.Windows.Forms.DateTimePicker();
            this.lblPDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPOrdDate);
            this.groupBox1.Controls.Add(this.lblPDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.cmbCriteria);
            this.groupBox1.Controls.Add(this.cmbFindBy);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criteria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find By";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(89, 65);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(149, 23);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.DropDownWidth = 117;
            this.cmbCriteria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Location = new System.Drawing.Point(89, 39);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(149, 24);
            this.cmbCriteria.TabIndex = 1;
            // 
            // cmbFindBy
            // 
            this.cmbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFindBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFindBy.FormattingEnabled = true;
            this.cmbFindBy.Location = new System.Drawing.Point(89, 13);
            this.cmbFindBy.Name = "cmbFindBy";
            this.cmbFindBy.Size = new System.Drawing.Size(149, 24);
            this.cmbFindBy.TabIndex = 0;
            this.cmbFindBy.SelectedIndexChanged += new System.EventHandler(this.cmbFindBy_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvOrder);
            this.groupBox2.Location = new System.Drawing.Point(7, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 361);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lvOrder
            // 
            this.lvOrder.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrder.GridLines = true;
            this.lvOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOrder.HotTracking = true;
            this.lvOrder.HoverSelection = true;
            this.lvOrder.Location = new System.Drawing.Point(7, 14);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(657, 340);
            this.lvOrder.TabIndex = 5;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvOrder_DrawItem);
            this.lvOrder.DoubleClick += new System.EventHandler(this.lvOrder_DoubleClick);
            // 
            // dTPOrdDate
            // 
            this.dTPOrdDate.CustomFormat = "dd-MMM-yyyy";
            this.dTPOrdDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPOrdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPOrdDate.Location = new System.Drawing.Point(387, 13);
            this.dTPOrdDate.Name = "dTPOrdDate";
            this.dTPOrdDate.Size = new System.Drawing.Size(163, 23);
            this.dTPOrdDate.TabIndex = 131;
            this.dTPOrdDate.Visible = false;
            this.dTPOrdDate.ValueChanged += new System.EventHandler(this.dTPOrdDate_ValueChanged);
            // 
            // lblPDate
            // 
            this.lblPDate.AutoSize = true;
            this.lblPDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDate.Location = new System.Drawing.Point(310, 16);
            this.lblPDate.Name = "lblPDate";
            this.lblPDate.Size = new System.Drawing.Size(68, 16);
            this.lblPDate.TabIndex = 130;
            this.lblPDate.Text = "Pick Date";
            this.lblPDate.Visible = false;
            // 
            // frmFinderOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFinderOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Order";
            this.Load += new System.EventHandler(this.frmFinderOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.ComboBox cmbFindBy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.DateTimePicker dTPOrdDate;
        private System.Windows.Forms.Label lblPDate;
    }
}