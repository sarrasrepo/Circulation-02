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
    public partial class frmFinderStation : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        public frmFinderStation()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void frmFinderStation_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("Station");
            cmbFindBy.SelectedIndex = 0;
            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");
            cmbCriteria.SelectedIndex = 0;

            string sqlQry = "select top(100) stationNameBan, stationName,UnionName,poName,psName,distName,divName,defaultCopy,packType,subRouteName from station where delStatus<>1";
            LoadList(sqlQry, "station");
        }

        private void InitializeListView()
        {

            lvStation.FullRowSelect = true;
            lvStation.GridLines = true;
            lvStation.View = View.Details;

            lvStation.OwnerDraw = true;

            lvStation.Columns.Add("Station (Bangla)", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Station (English)", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Union Name", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Post Office", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Police Station", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("District", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Division", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Default Copy", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Packet Type", 150, HorizontalAlignment.Left);
            lvStation.Columns.Add("Sub-Route Name", 150, HorizontalAlignment.Left);
            
            

        }

        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvStation.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["stationNameBan"].ToString().Trim());
                    lvi.SubItems.Add(drow["stationName"].ToString().Trim());
                    lvi.SubItems.Add(drow["UnionName"].ToString().Trim());
                    lvi.SubItems.Add(drow["poName"].ToString().Trim());
                    lvi.SubItems.Add(drow["psName"].ToString().Trim());
                    lvi.SubItems.Add(drow["distName"].ToString().Trim());
                    lvi.SubItems.Add(drow["divName"].ToString().Trim());
                    lvi.SubItems.Add(drow["defaultCopy"].ToString().Trim());
                    lvi.SubItems.Add(drow["packType"].ToString().Trim());
                    lvi.SubItems.Add(drow["subRouteName"].ToString().Trim());
                    lvStation.Items.Add(lvi);

                }
            }

        }

        private void lvStation_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void lvStation_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvStation_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string strSQL;
            if (cmbFindBy.Text == "Station")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(20) stationNameBan, stationName,UnionName,poName,psName,distName,divName,defaultCopy,packType,subRouteName from station where delStatus<>1 and stationName like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "station");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(20) stationNameBan,stationName,UnionName,poName,psName,distName,divName,defaultCopy,packType,subRouteName from station where delStatus<>1 and stationName like '%" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "station");
                }
            }
        }

        private void SetValue()
        {
            string selCountrow = "SELECT stationId from station  where delStatus<>1 AND stationName ='" + lvStation.SelectedItems[0].SubItems[1].Text + "'AND UnionName='" + lvStation.SelectedItems[0].SubItems[2].Text + "' AND poName='" + lvStation.SelectedItems[0].SubItems[3].Text + "' AND psName='" + lvStation.SelectedItems[0].SubItems[4].Text + "' AND distName='" + lvStation.SelectedItems[0].SubItems[5].Text + "' AND divName='" + lvStation.SelectedItems[0].SubItems[6].Text + "' ";
            int stationId = Convert.ToInt32(dp.getResultString(selCountrow));

            this.Owner.Controls.Find("txtStaBang", true).First().Text = lvStation.SelectedItems[0].SubItems[0].Text;
            this.Owner.Controls.Find("txtStaEng", true).First().Text = lvStation.SelectedItems[0].SubItems[1].Text;
            this.Owner.Controls.Find("cmbUnionSta", true).First().Text = lvStation.SelectedItems[0].SubItems[2].Text;
            this.Owner.Controls.Find("cmbPOSta", true).First().Text = lvStation.SelectedItems[0].SubItems[3].Text;
            this.Owner.Controls.Find("cmbPSSta", true).First().Text = lvStation.SelectedItems[0].SubItems[4].Text;
            this.Owner.Controls.Find("cmbDistSta", true).First().Text = lvStation.SelectedItems[0].SubItems[5].Text;
            this.Owner.Controls.Find("cmbDivSta", true).First().Text = lvStation.SelectedItems[0].SubItems[6].Text;
            this.Owner.Controls.Find("txtDfltCopy", true).First().Text = lvStation.SelectedItems[0].SubItems[7].Text;
            this.Owner.Controls.Find("cmbPktType", true).First().Text = lvStation.SelectedItems[0].SubItems[8].Text;
            this.Owner.Controls.Find("cmbSubRoute", true).First().Text = lvStation.SelectedItems[0].SubItems[9].Text;

            this.Owner.Controls.Find("txtHdnStationId", true).First().Text = stationId.ToString();

            this.Owner.Controls.Find("btnSaveSta", true).First().Text = "Update";
        }
    }
}
