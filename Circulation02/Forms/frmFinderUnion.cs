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
    public partial class frmFinderUnion : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        public frmFinderUnion()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void frmFinderUnion_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("Union");
            cmbFindBy.SelectedIndex = 0;
            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");
            cmbCriteria.SelectedIndex = 0;

            string sqlQry = "select top(100) UnionName,postOffice,policeStation,district,division,createDate from geoUnion where delStatus<>1";
            LoadList(sqlQry, "geoUnion");
        }

        private void InitializeListView()
        {

            lvUnion.FullRowSelect = true;
            lvUnion.GridLines = true;
            lvUnion.View = View.Details;

            lvUnion.OwnerDraw = true;

            lvUnion.Columns.Add("Union", 150, HorizontalAlignment.Left);
            lvUnion.Columns.Add("Post Office", 150, HorizontalAlignment.Left);
            lvUnion.Columns.Add("Police Station", 150, HorizontalAlignment.Left);
            lvUnion.Columns.Add("District", 150, HorizontalAlignment.Left);
            lvUnion.Columns.Add("Division", 150, HorizontalAlignment.Left);
            lvUnion.Columns.Add("Created Date", 150, HorizontalAlignment.Left);

        }

        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvUnion.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["UnionName"].ToString().Trim());
                    lvi.SubItems.Add(drow["postOffice"].ToString().Trim());
                    lvi.SubItems.Add(drow["policeStation"].ToString().Trim());
                    lvi.SubItems.Add(drow["district"].ToString().Trim());
                    lvi.SubItems.Add(drow["division"].ToString().Trim());
                    lvi.SubItems.Add(drow["createDate"].ToString().Trim());

                    lvUnion.Items.Add(lvi);

                }
            }

        }

        private void lvUnion_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void lvUnion_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string strSQL;
            if (cmbFindBy.Text == "Union")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(20) UnionName,postOffice,policeStation,district,division,createDate from geoUnion where delStatus<>1 and UnionName like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "geoUnion");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(20) UnionName,postOffice,policeStation,district,division,createDate from geoUnion where delStatus<>1 and UnionName like '%" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "geoUnion");
                }
            }
        }

        private void lvUnion_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        }

        private void SetValue()
        {
            string selCountrow = "SELECT UnionId from geoUnion  where delStatus<>1 AND UnionName='" + lvUnion.SelectedItems[0].SubItems[0].Text + "' AND postOffice='" + lvUnion.SelectedItems[0].SubItems[1].Text + "' AND policeStation='" + lvUnion.SelectedItems[0].SubItems[2].Text + "' AND district='" + lvUnion.SelectedItems[0].SubItems[3].Text + "' AND division='"+lvUnion.SelectedItems[0].SubItems[4].Text+"' ";
            int unionId = Convert.ToInt32(dp.getResultString(selCountrow));

            this.Owner.Controls.Find("txtUnion", true).First().Text = lvUnion.SelectedItems[0].SubItems[0].Text;
            this.Owner.Controls.Find("cmbPOU", true).First().Text = lvUnion.SelectedItems[0].SubItems[1].Text;
            this.Owner.Controls.Find("cmbPSU", true).First().Text = lvUnion.SelectedItems[0].SubItems[2].Text;
            this.Owner.Controls.Find("cmbDistU", true).First().Text = lvUnion.SelectedItems[0].SubItems[3].Text;
            this.Owner.Controls.Find("cmbDivU", true).First().Text = lvUnion.SelectedItems[0].SubItems[4].Text;

            this.Owner.Controls.Find("txtHdnUnionId", true).First().Text = unionId.ToString();

            this.Owner.Controls.Find("btnSaveU", true).First().Text = "Update";
        }

    }
}
