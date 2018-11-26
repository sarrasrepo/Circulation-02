using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View = System.Windows.Forms.View;

namespace Circulation02.Forms
{
    public partial class frmPopulation : Form
    {
        public string UserName { get; set; }
        private DataTable dt = new DataTable();
        private DataProvider dp = new DataProvider();
        private DataSet ds = new DataSet();
        private SqlConnection con = new SqlConnection();
        private SqlDataAdapter sda = new SqlDataAdapter();
        public frmPopulation()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void frmPopulation_Load(object sender, EventArgs e)
        {
            BindStation();
            string sqlQry = "select top(100) stationName,population,literate,takepalo,regularSubscriber,floatingSubscriber from PopulationInformation WHERE delStatus<>1";
            LoadList(sqlQry, "PopulationInformation");
        }
        private void InitializeListView()
        {

            lvPopulation.FullRowSelect = true;
            lvPopulation.GridLines = true;
            lvPopulation.View = View.Details;

            lvPopulation.OwnerDraw = true;

            lvPopulation.Columns.Add("Station Name", 150, HorizontalAlignment.Left);
            lvPopulation.Columns.Add("Population", 150, HorizontalAlignment.Left);
            lvPopulation.Columns.Add("Literacy", 150, HorizontalAlignment.Left);
            lvPopulation.Columns.Add("Subscriber of PALO", 150, HorizontalAlignment.Left);
            lvPopulation.Columns.Add("Regular Subscriber", 150, HorizontalAlignment.Left);
            lvPopulation.Columns.Add("Floating Subscriber", 150, HorizontalAlignment.Left);

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
                    e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.Left, e.Bounds.Right);
                    
                }
            }
        }

        private void lvUnion_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void BindStation()
        {
            string sqlQry = "SELECT  stationName from station where delStatus<>1  Order By stationName ASC ";
            ds = dp.getDataSet(sqlQry, "stationName");
            cmbStaName.DataSource = ds.Tables[0];
            cmbStaName.DisplayMember = "stationName";
            cmbStaName.Text = "---- Select ----";   
        }

        private void LoadList(string strSQL, string myString)
        {
            dt = dp.getDataTable(strSQL, myString);

            lvPopulation.Items.Clear();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["stationName"].ToString().Trim());
                    lvi.SubItems.Add(drow["population"].ToString().Trim());
                    lvi.SubItems.Add(drow["literate"].ToString().Trim());
                    lvi.SubItems.Add(drow["takepalo"].ToString().Trim());
                    lvi.SubItems.Add(drow["regularSubscriber"].ToString().Trim());
                    lvi.SubItems.Add(drow["floatingSubscriber"].ToString().Trim());

                    lvPopulation.Items.Add(lvi);

                }
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string strSQL;
            strSQL = "select top(20) stationName,population,literate,takepalo,regularSubscriber,floatingSubscriber from PopulationInformation WHERE delStatus<>1 and stationName like '%" + txtFilter.Text.Trim() + "%' ";
            LoadList(strSQL, "PopulationInformation");
        }

        private void lvPopulation_DoubleClick(object sender, EventArgs e)
        {
            //string selCountrow = "SELECT UnionId from geoUnion  where delStatus<>1 AND UnionName='" + lvUnion.SelectedItems[0].SubItems[0].Text + "' AND postOffice='" + lvUnion.SelectedItems[0].SubItems[1].Text + "' AND policeStation='" + lvUnion.SelectedItems[0].SubItems[2].Text + "' AND district='" + lvUnion.SelectedItems[0].SubItems[3].Text + "' AND division='" + lvUnion.SelectedItems[0].SubItems[4].Text + "' ";
            //int unionId = Convert.ToInt32(dp.getResultString(selCountrow));

            cmbStaName.Text = lvPopulation.SelectedItems[0].SubItems[0].Text;
            txtPop.Text = lvPopulation.SelectedItems[0].SubItems[1].Text;
            txtNOLiterate.Text = lvPopulation.SelectedItems[0].SubItems[2].Text;
            txtSOPalo.Text = lvPopulation.SelectedItems[0].SubItems[3].Text;
            txtRegSubs.Text = lvPopulation.SelectedItems[0].SubItems[4].Text;
            txtFlotSubs.Text = lvPopulation.SelectedItems[0].SubItems[5].Text;

            //this.Owner.Controls.Find("txtHdnUnionId", true).First().Text = unionId.ToString();

            btnSave.Text= "Update";
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text=="Save")
            {
                 string selCountrow = "SELECT COUNT(*) from PopulationInformation where delStatus<>1 AND stationName='" + lvPopulation.SelectedItems[0].SubItems[0].Text + "'  ";
                 int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

                if (rowNumber==0)
                {
                    string sqlInsert="EXEC Insert_populationInfo '" + cmbStaName.Text+ "' ,'"
                                                + txtPop.Text + "' ,'"
                                                + txtNOLiterate.Text + "' ,'"
                                                + txtSOPalo.Text + "' ,'"
                                                + txtRegSubs.Text + "','"
                                                + txtFlotSubs.Text + "','"
                                                + UserName + "' ,'"
                                                + DateTime.Now + "' ";
                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    gbHdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    gbHdr.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
    
                }

                else
                {
                    MessageBox.Show(" Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (btnSave.Text=="Update")
            {
                string sqlpId = "select piId from PopulationInformation where stationName='"+cmbStaName.Text+"'";
                int pId = Convert.ToInt32(dp.getResultString(sqlpId));
                string sqlUPdate= "EXEC Update_populationInfo '" + pId + "','"
                                                 + cmbStaName.Text + "' ,'"
                                                 + txtPop.Text + "' ,'"
                                                 + txtNOLiterate.Text + "' ,'"
                                                 + txtSOPalo.Text + "' ,'"
                                                 + txtRegSubs.Text+ "','"
                                                 + txtFlotSubs.Text + "','"
                                                 + UserName + "' ,'"
                                                 + DateTime.Now+ "' ";
                dp.ExecuteCommand(sqlUPdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbHdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                gbHdr.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                btnSave.Text = "Save";


            }
        }
    }
}
