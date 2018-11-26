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
    public partial class frmFinderAgnt2 : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        frmOrdEntry OrdEntry;
        public frmFinderAgnt2(frmOrdEntry frmOrdEntry)
        {
            InitializeComponent();
            this.OrdEntry = frmOrdEntry;
            InitializeListView();
        }
        private void InitializeListView()
        {

            lvAgent.FullRowSelect = true;
            lvAgent.GridLines = true;
            lvAgent.View = View.Details;


            lvAgent.OwnerDraw = true;
            lvAgent.DrawColumnHeader += lvAgent_DrawColumnHeader;


            lvAgent.Columns.Add("Agent Id", 80, HorizontalAlignment.Center);
            lvAgent.Columns.Add("Business Type", 120, HorizontalAlignment.Center);
            lvAgent.Columns.Add("Agent Name", 120, HorizontalAlignment.Left);
            lvAgent.Columns.Add("Agent Name(Bangla)", 150, HorizontalAlignment.Center);
            lvAgent.Columns.Add("Sub-Route", 120, HorizontalAlignment.Left);
            lvAgent.Columns.Add("Mobile", 120, HorizontalAlignment.Left);
            lvAgent.Columns.Add("Floating Quantity", 130, HorizontalAlignment.Center);
            lvAgent.Columns.Add("Regular Quantity", 130, HorizontalAlignment.Center);
            lvAgent.Columns.Add("Corporate Quantity", 140, HorizontalAlignment.Left);
            lvAgent.Columns.Add("Billing Agent", 100, HorizontalAlignment.Left);
            lvAgent.Columns.Add("Station", 120, HorizontalAlignment.Left);

        }

        private void frmFinderAgnt2_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("Agent ID");
            cmbFindBy.Items.Add("Agent Name");


            cmbFindBy.SelectedIndex = 1;

            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");

            cmbCriteria.SelectedIndex = 1;



            string sqlQry = "select top(100) hkrid,hkrType,hkrNameEng,hkrNameBangla,agentArea,mobileNumber,floatingCopy,regularCopy,corporateCopy,billTo,salesArea from hawkerInformation order by hkrid asc";
            LoadList(sqlQry, "hawkerInformation");
        }

        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvAgent.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["hkrid"].ToString().Trim());
                    lvi.SubItems.Add(drow["hkrType"].ToString().Trim());
                    lvi.SubItems.Add(drow["hkrNameEng"].ToString().Trim());
                    lvi.SubItems.Add(drow["hkrNameBangla"].ToString().Trim());
                    lvi.SubItems.Add(drow["agentArea"].ToString().Trim());
                    lvi.SubItems.Add(drow["mobileNumber"].ToString().Trim());
                    lvi.SubItems.Add(drow["floatingCopy"].ToString().Trim());
                    lvi.SubItems.Add(drow["regularCopy"].ToString().Trim());
                    lvi.SubItems.Add(drow["corporateCopy"].ToString().Trim());
                    lvi.SubItems.Add(drow["billTo"].ToString().Trim());
                    lvi.SubItems.Add(drow["salesArea"].ToString().Trim());
                    lvAgent.Items.Add(lvi);

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
                    strSQL = "select top(20) hkrid,hkrType,hkrNameEng,hkrNameBangla,agentArea,mobileNumber,floatingCopy,regularCopy,corporateCopy,billTo,salesArea from hawkerInformation where hkrNameEng like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "hawkerInformation");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(20) hkrid,hkrType,hkrNameEng,hkrNameBangla,agentArea,mobileNumber,floatingCopy,regularCopy,corporateCopy,billTo,salesArea from hawkerInformation where hkrNameEng like '%" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "hawkerInformation");
                }

            }


            if (cmbFindBy.Text == "Agent ID")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(20) hkrid,hkrType,hkrNameEng,hkrNameBangla,agentArea,mobileNumber,floatingCopy,regularCopy,corporateCopy,billTo,salesArea from hawkerInformation where hkrid like '" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "hawkerInformation");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(20) hkrid,hkrType,hkrNameEng,hkrNameBangla,agentArea,mobileNumber,floatingCopy,regularCopy,corporateCopy,billTo,salesArea from hawkerInformation where hkrid like '%" + txtFilter.Text.Trim() + "%' ";
                    LoadList(strSQL, "hawkerInformation");
                }

            }
        }

        private void lvAgent_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        
        }

        private void SetValue()
        {
            OrdEntry.txtAgntId.Focus();
            OrdEntry.txtAgntId.Text = lvAgent.SelectedItems[0].SubItems[0].Text;
            
        }

        private void lvAgent_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void lvAgent_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
