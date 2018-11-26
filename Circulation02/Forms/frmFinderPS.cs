using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Circulation02.Forms
{
    public partial class frmFinderPS : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        frmRegion Region=new frmRegion();
        public int psId { get; set; }
       
       
        public frmFinderPS()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void frmFinderPS_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("Police Station");
            cmbFindBy.SelectedIndex = 0;
            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");
            cmbCriteria.SelectedIndex = 1;

            string sqlQry = "select top(100) psName,distName,divName,createDate from policeStation where delStatus<>1";
            LoadList(sqlQry, "policeStation");
        }

        private void InitializeListView()
        {

            lvPS.FullRowSelect = true;
            lvPS.GridLines = true;
            lvPS.View = View.Details;


            lvPS.OwnerDraw = true;
            //lvPS.DrawColumnHeader += lvPS_DrawColumnHeader;


            lvPS.Columns.Add("Police Station", 150, HorizontalAlignment.Center);
            lvPS.Columns.Add("District", 150, HorizontalAlignment.Left);
            lvPS.Columns.Add("Division", 150, HorizontalAlignment.Left);
            lvPS.Columns.Add("Created Date", 150, HorizontalAlignment.Center);

        }

        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvPS.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["psName"].ToString().Trim());
                    lvi.SubItems.Add(drow["distName"].ToString().Trim());
                    lvi.SubItems.Add(drow["divName"].ToString().Trim());
                    lvi.SubItems.Add(drow["createDate"].ToString().Trim());

                    lvPS.Items.Add(lvi);

                }
            }

        }

        private void lvPS_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void lvPS_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string strSQL;
            if (cmbFindBy.Text == "Police Station")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(20) psName,distName,divName,createDate from policeStation where delStatus<>1 and psName like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "policeStation");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(20) psName,distName,divName,createDate from policeStation where delStatus<>1 and psName like '%" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "policeStation");
                }
            }


        }

        private void lvPS_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        }
        private void SetValue()
        {
            string selCountrow = "SELECT psId from policeStation where delStatus<>1 AND psName='" + lvPS.SelectedItems[0].SubItems[0].Text + "' AND divName='" + lvPS.SelectedItems[0].SubItems[2].Text +"' AND distName='" + lvPS.SelectedItems[0].SubItems[1].Text + "'";
            psId = Convert.ToInt32(dp.getResultString(selCountrow));
           
            this.Owner.Controls.Find("txtPS", true).First().Text = lvPS.SelectedItems[0].SubItems[0].Text;
            this.Owner.Controls.Find("cmbDivPS", true).First().Text = lvPS.SelectedItems[0].SubItems[2].Text;
            this.Owner.Controls.Find("cmbDistPS", true).First().Text = lvPS.SelectedItems[0].SubItems[1].Text;
            this.Owner.Controls.Find("txtHdnPsId", true).First().Text = psId.ToString();

            this.Owner.Controls.Find("btnSavePS", true).First().Text = "Update";
        }
    }
}
