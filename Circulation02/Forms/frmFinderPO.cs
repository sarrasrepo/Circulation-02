using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulation02.Forms
{
    public partial class frmFinderPO : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        public frmFinderPO()
        {
            InitializeComponent();
            InitializeListView();
        }
        private void frmFinderPO_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("Post Office");
            cmbFindBy.SelectedIndex = 0;
            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");
            cmbCriteria.SelectedIndex = 0;

            string sqlQry = "select top(100) poName,poCode,psName,distName,divName,createDate from postOffice where delStatus<>1";
            LoadList(sqlQry, "postOffice");
        }
        private void InitializeListView()
        {

            lvPO.FullRowSelect = true;
            lvPO.GridLines = true;
            lvPO.View = View.Details;
            
            lvPO.OwnerDraw = true;

            lvPO.Columns.Add("Post Office", 150, HorizontalAlignment.Left);
            lvPO.Columns.Add("Post Code", 150, HorizontalAlignment.Left);
            lvPO.Columns.Add("Police Station", 150, HorizontalAlignment.Left);
            lvPO.Columns.Add("District", 150, HorizontalAlignment.Left);
            lvPO.Columns.Add("Division", 150, HorizontalAlignment.Left);
            lvPO.Columns.Add("Created Date", 150, HorizontalAlignment.Left);

        }
        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvPO.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["poName"].ToString().Trim());
                    lvi.SubItems.Add(drow["poCode"].ToString().Trim());
                    lvi.SubItems.Add(drow["psName"].ToString().Trim());
                    lvi.SubItems.Add(drow["distName"].ToString().Trim());
                    lvi.SubItems.Add(drow["divName"].ToString().Trim());
                    lvi.SubItems.Add(drow["createDate"].ToString().Trim());

                    lvPO.Items.Add(lvi);

                }
            }

        }

        private void lvPO_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void lvPO_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string strSQL;
            if (cmbFindBy.Text == "Post Office")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(20) poName,poCode,psName,distName,divName,createDate from postOffice where delStatus<>1 and poName like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "postOffice");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(20) poName,poCode,psName,distName,divName,createDate from postOffice where delStatus<>1 and poName like '%" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "postOffice");
                }
            }

        }

        private void lvPO_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        }

        private void SetValue()
        {
            string selCountrow = "SELECT poId from postOffice  where delStatus<>1 AND poName='" + lvPO.SelectedItems[0].SubItems[0].Text + "' AND psName='" + lvPO.SelectedItems[0].SubItems[2].Text + "' AND distName='" + lvPO.SelectedItems[0].SubItems[3].Text + "' AND divName='" + lvPO.SelectedItems[0].SubItems[4].Text + "'";
            int poId = Convert.ToInt32(dp.getResultString(selCountrow));

            this.Owner.Controls.Find("txtPO", true).First().Text = lvPO.SelectedItems[0].SubItems[0].Text;
            this.Owner.Controls.Find("txtPC", true).First().Text = lvPO.SelectedItems[0].SubItems[1].Text;
            this.Owner.Controls.Find("cmbPS", true).First().Text = lvPO.SelectedItems[0].SubItems[2].Text;
            this.Owner.Controls.Find("cmbDistPO", true).First().Text = lvPO.SelectedItems[0].SubItems[3].Text;
            this.Owner.Controls.Find("cmbDivPO", true).First().Text = lvPO.SelectedItems[0].SubItems[4].Text;

            this.Owner.Controls.Find("txtHdnPoId", true).First().Text = poId.ToString();

            this.Owner.Controls.Find("btnSavePO", true).First().Text = "Update";
        }
    }
}
