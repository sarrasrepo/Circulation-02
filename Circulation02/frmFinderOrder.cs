using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circulation02.Forms;

namespace Circulation02
{
    public partial class frmFinderOrder : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        frmOrdEntry OrdEntry;
        public frmFinderOrder(frmOrdEntry frmOrdEntry)
        {
            InitializeComponent();
            this.OrdEntry = frmOrdEntry;
            InitializeListView();
        }

        private void InitializeListView()
        {

            lvOrder.FullRowSelect = true;
            lvOrder.GridLines = true;
            lvOrder.View = View.Details;


            lvOrder.OwnerDraw = true;
            lvOrder.DrawColumnHeader += lvOrder_DrawColumnHeader;


            lvOrder.Columns.Add("Order No", 80, HorizontalAlignment.Center);
            lvOrder.Columns.Add("Order Date", 120, HorizontalAlignment.Center);
            lvOrder.Columns.Add("Agent Id", 80, HorizontalAlignment.Left);
            lvOrder.Columns.Add("Agent Name ", 200, HorizontalAlignment.Center);
            lvOrder.Columns.Add("Sub-Route", 200, HorizontalAlignment.Left);
        }

        private void frmFinderOrder_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("Order No");
            cmbFindBy.Items.Add("Agent Name");
            cmbFindBy.Items.Add("Order Date");


            cmbFindBy.SelectedIndex = 0;

            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");

            cmbCriteria.SelectedIndex = 1;



            string sqlQry = "SELECT DISTINCT TOP (100) orderNo,convert(varchar,orderDate,106)as orderDate,customerId,hkrNameEng,subRoute from orderFinder where delStatus<>1 order by orderNo DESC";
            LoadList(sqlQry, "orderFinder");
        }

        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvOrder.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["orderNo"].ToString().Trim());
                    lvi.SubItems.Add(drow["orderDate"].ToString().Trim());
                    lvi.SubItems.Add(drow["customerId"].ToString().Trim());
                    lvi.SubItems.Add(drow["hkrNameEng"].ToString().Trim());
                    lvi.SubItems.Add(drow["subRoute"].ToString().Trim());
                    lvOrder.Items.Add(lvi);

                }
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string strSQL;

            if (cmbFindBy.Text == "Agent Name")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "SELECT DISTINCT TOP (20) orderNo,convert(varchar,orderDate,106)as orderDate,customerId,hkrNameEng,subRoute from orderFinder where delStatus<>1 and hkrNameEng like '" + txtFilter.Text.Trim() + "%'";
                    LoadList(strSQL, "orderFinder");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "SELECT DISTINCT TOP (20) orderNo,convert(varchar,orderDate,106)as orderDate,customerId,hkrNameEng,subRoute from orderFinder where delStatus<>1 and hkrNameEng like '%" + txtFilter.Text.Trim() + "%'";
                    LoadList(strSQL, "orderFinder");
                }

            }


            if (cmbFindBy.Text == "Order No")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "SELECT DISTINCT TOP (20) orderNo,convert(varchar,orderDate,106)as orderDate,customerId,hkrNameEng,subRoute from orderFinder where delStatus<>1 and orderNo like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "orderFinder");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "SELECT DISTINCT TOP (20) orderNo,convert(varchar,orderDate,106)as orderDate,customerId,hkrNameEng,subRoute from orderFinder where delStatus<>1 and orderNo like '%" + txtFilter.Text.Trim() + "%'";
                    LoadList(strSQL, "orderFinder");
                }

            }
        }

        private void lvOrder_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font("Tahoma", 10, FontStyle.Bold))
                {

                    e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                    e.Graphics.DrawRectangle(Pens.Azure, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, sf);

                }
            }
        }

        private void lvOrder_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvOrder_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        }
        private void SetValue()
        {
            OrdEntry.txtAgntId.Focus();
            this.Owner.Controls.Find("txtOdrId", true).First().Text = lvOrder.SelectedItems[0].SubItems[0].Text;
            this.Owner.Controls.Find("dTPOrdDate", true).First().Text = lvOrder.SelectedItems[0].SubItems[1].Text;
            this.Owner.Controls.Find("txtAgntId", true).First().Text = lvOrder.SelectedItems[0].SubItems[2].Text;
            this.Owner.Controls.Find("cmbSubRoute", true).First().Text = lvOrder.SelectedItems[0].SubItems[4].Text;

            this.Owner.Controls.Find("btnSave", true).First().Text = "Update";

        }

        private void cmbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFindBy.Text == "Order Date")
            {
                lblPDate.Visible = true;
                dTPOrdDate.Visible = true;
            }
        }

        private void dTPOrdDate_ValueChanged(object sender, EventArgs e)
        {
            string strSQL = "SELECT DISTINCT TOP (200) orderNo,convert(varchar,orderDate,106)as orderDate,customerId,hkrNameEng,subRoute from orderFinder where delStatus<>1 and orderDate='"+dTPOrdDate.Text+"'";
            LoadList(strSQL, "orderFinder");

        }
    }
}
