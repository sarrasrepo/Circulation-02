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
using System.Windows.Forms.VisualStyles;
using ListBox = System.Windows.Forms.ListBox;

namespace Circulation02.Forms
{
    public partial class frmRegion : Form
    {
        public string UserName { get; set; }
        public int PSId {get; set; }

        private DataTable dt = new DataTable();
        private DataProvider dp = new DataProvider();
        private DataSet ds = new DataSet();
        private SqlConnection con = new SqlConnection();
        private SqlDataAdapter sda = new SqlDataAdapter();
        

        private string connStr ="Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";

        public frmRegion()
        {
            InitializeComponent();
            

        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            BindDivisionGrd();
            
        }

        //Tab Control
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControlRgn.SelectedIndex == 1)
            {
                BindCmbDivision();
            }

            if (tabControlRgn.SelectedIndex == 2)
            {
                BindCmbDivision();
            }

            if (tabControlRgn.SelectedIndex == 3)
            {
                BindCmbDivision();
            }

            if (tabControlRgn.SelectedIndex == 4)
            {
                BindCmbDivision();
            }
            if (tabControlRgn.SelectedIndex == 5)
            {
                cmbPktType.Items.Add("--- Select ---");
                cmbPktType.Items.Add("Individual");
                cmbPktType.Items.Add("Combined");
                cmbPktType.Items.Add("Overpacked");
                cmbPktType.Items.Add("Special");
                cmbPktType.SelectedIndex = 0;

                BindCmbDivision();
            }
        }

        #region Bind All Controls

        
        private void BindDivisionGrd()
        {
            dt.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("SELECT divName,createDate,auditUser from division where delStatus<>1 ORDER BY divName ASC", con);
            sda.Fill(dt);
            gvDivision.DataSource = dt;
            con.Close();
            gvDivision.CurrentCell.Selected = false;
        }

        private void BindCmbDivision()
        {
            if (tabControlRgn.SelectedIndex==1)
            {
                string sqlQry = "SELECT  divName from DIVISION where delStatus<>1 Order By divName ASC ";
                ds = dp.getDataSet(sqlQry, "divName");
                cmbDivision.DataSource = ds.Tables[0];
                cmbDivision.DisplayMember = "divName";
                cmbDivision.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 2)
            {
                string sqlQry = "SELECT  divName from DIVISION where delStatus<>1 Order By divName ASC ";
                ds = dp.getDataSet(sqlQry, "divName");
                cmbDivPS.DataSource = ds.Tables[0];
                cmbDivPS.DisplayMember = "divName";
                cmbDivPS.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 3)
            {
                string sqlQry = "SELECT  divName from DIVISION where delStatus<>1 Order By divName ASC ";
                ds = dp.getDataSet(sqlQry, "divName");
                cmbDivPO.DataSource = ds.Tables[0];
                cmbDivPO.DisplayMember = "divName";
                cmbDivPO.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 4)
            {
                string sqlQry = "SELECT  divName from DIVISION where delStatus<>1 Order By divName ASC ";
                ds = dp.getDataSet(sqlQry, "divName");
                cmbDivU.DataSource = ds.Tables[0];
                cmbDivU.DisplayMember = "divName";
                cmbDivU.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 5)
            {
                string sqlQry = "SELECT  divName from DIVISION where delStatus<>1 Order By divName ASC ";
                ds = dp.getDataSet(sqlQry, "divName");
                cmbDivSta.DataSource = ds.Tables[0];
                cmbDivSta.DisplayMember = "divName";
                cmbDivSta.Text = "---- Select ----";

                string sqlSubRoute = "select subRouteName from subRoute where delStatus<>1 Order By subRouteName ASC ";
                ds = dp.getDataSet(sqlSubRoute, "subRouteName");
                cmbSubRoute.DataSource = ds.Tables[0];
                cmbSubRoute.DisplayMember = "subRouteName";
                cmbSubRoute.Text = "---- Select ----";
                
            }
           
        }

        private void BindCmbDistrict()
        {
            if (tabControlRgn.SelectedIndex==2)
            {
                string sqlQry = "SELECT  distName from district where delStatus<>1 AND divName='"+cmbDivPS.Text+"' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "distName");
                cmbDistPS.DataSource = ds.Tables[0];
                cmbDistPS.DisplayMember = "distName";
                cmbDistPS.Text = "---- Select ----";   
            }

            if (tabControlRgn.SelectedIndex == 3)
            {
                string sqlQry = "SELECT  distName from district where delStatus<>1 AND divName='" + cmbDivPO.Text + "' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "distName");
                cmbDistPO.DataSource = ds.Tables[0];
                cmbDistPO.DisplayMember = "distName";
                cmbDistPO.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 4)
            {
                string sqlQry = "SELECT  distName from district where delStatus<>1 AND divName='" + cmbDivU.Text + "' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "distName");
                cmbDistU.DataSource = ds.Tables[0];
                cmbDistU.DisplayMember = "distName";
                cmbDistU.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 5)
            {
                string sqlQry = "SELECT  distName from district where delStatus<>1 AND divName='" + cmbDivSta.Text + "' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "distName");
                cmbDistSta.DataSource = ds.Tables[0];
                cmbDistSta.DisplayMember = "distName";
                cmbDistSta.Text = "---- Select ----";

            }

        }

        private void BindCmbPS()
        {
            if (tabControlRgn.SelectedIndex == 3)
            {
                string sqlQry = "SELECT  psName from policeStation where delStatus<>1 AND divName='" + cmbDivPO.Text + "' and distName='"+cmbDistPO.Text+"' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "psName");
                cmbPS.DataSource = ds.Tables[0];
                cmbPS.DisplayMember = "psName";
                cmbPS.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 4)
            {
                string sqlQry = "SELECT  psName from policeStation where delStatus<>1 AND divName='" + cmbDivU.Text + "' and distName='" + cmbDistU.Text + "' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "psName");
                cmbPSU.DataSource = ds.Tables[0];
                cmbPSU.DisplayMember = "psName";
                cmbPSU.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 5)
            {
                string sqlQry = "SELECT  psName from policeStation where delStatus<>1 AND divName='" + cmbDivSta.Text + "' and distName='" + cmbDistSta.Text + "' Order By distName ASC ";
                ds = dp.getDataSet(sqlQry, "psName");
                cmbPSSta.DataSource = ds.Tables[0];
                cmbPSSta.DisplayMember = "psName";
                cmbPSSta.Text = "---- Select ----";
            }
        }

        private void BindCmbPO()
        {
            if (tabControlRgn.SelectedIndex==4)
            {
                string sqlQry = "SELECT  poName from postOffice where delStatus<>1 AND divName='" + cmbDivU.Text + "' and distName='" + cmbDistU.Text + "' AND psName='" + cmbPSU.Text + "' Order By poName ASC ";
                ds = dp.getDataSet(sqlQry, "poName");
                cmbPOU.DataSource = ds.Tables[0];
                cmbPOU.DisplayMember = "poName";
                cmbPOU.Text = "---- Select ----";
            }

            if (tabControlRgn.SelectedIndex == 5)
            {
                string sqlQry = "SELECT  poName from postOffice where delStatus<>1 AND divName='" + cmbDivSta.Text + "' and distName='" + cmbDistSta.Text + "' AND psName='" + cmbPSSta.Text + "' Order By poName ASC ";
                ds = dp.getDataSet(sqlQry, "poName");
                cmbPOSta.DataSource = ds.Tables[0];
                cmbPOSta.DisplayMember = "poName";
                cmbPOSta.Text = "---- Select ----";
            }
        }

        private void BindCmbUnion()
        {

            if (tabControlRgn.SelectedIndex == 5)
            {
                string sqlQry = "SELECT  UnionName from geoUnion where delStatus<>1 AND division='" + cmbDivSta.Text + "' and district='" + cmbDistSta.Text + "' AND policeStation='" + cmbPSSta.Text + "' AND postOffice='" + cmbPOSta.Text + "'Order By UnionName ASC ";
                ds = dp.getDataSet(sqlQry, "UnionName");
                cmbUnionSta.DataSource = ds.Tables[0];
                cmbUnionSta.DisplayMember = "UnionName";
                cmbUnionSta.Text = "---- Select ----";
            }
        }

        private void BindDistrictGrd(string sItem)
        {
            DataTable dts= new DataTable();
            dts.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("SELECT divName,distName,createDate from district where delStatus<>1 and divName='" + sItem + "' ORDER BY distName  ASC", con);
            sda.Fill(dts);
            gvDistrict.DataSource = dts;
            con.Close();
            gvDistrict.ClearSelection();
        }

        #endregion

        #region Button Event
        private void btnSaveDiv_Click(object sender, EventArgs e)
        {
            
            string selCountrow = "SELECT COUNT(*) from division where delStatus<>1 AND divName='" + txtDivName.Text + "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));
            

          
            if (btnSaveDiv.Text=="Save")
            {
                if (rowNumber == 0)
                {
                    string sqlInsert = "EXEC Insert_division '" + txtDivName.Text + "' ,'"
                                           + UserName+ "' ,'"+ DateTime.Now+ "' ";
                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDivName.Clear();
                }
                else
                {
                    MessageBox.Show("Division Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }

            if (btnSaveDiv.Text=="Update")
            {
                DataGridViewRow gvRow = gvDivision.SelectedRows[0];
                string sqlDivId = "select divId from division where divName='"+gvRow.Cells[0].Value+"'";
                int divId = Convert.ToInt32(dp.getResultString(sqlDivId));
                
                string sqlUpdate = "EXEC Update_division '"+ divId + "','"+ txtDivName.Text + "' ,'"+ UserName + "' ,' "+ DateTime.Now + "' ";
                dp.ExecuteCommand(sqlUpdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDivName.Clear();
                btnSaveDiv.Text = "Save";

            }
           
            BindDivisionGrd();
           
        }

        private void btnSaveDis_Click(object sender, EventArgs e)
        {
            
            if (btnSaveDis.Text == "Save")
            {
                string selCountrow = "SELECT COUNT(*) from district where delStatus<>1 AND divName='" + cmbDivision.Text + "' AND distName='" + txtDistrict.Text + "'  ";
                int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

                if (rowNumber == 0)
                {
                    string sqlInsert = "EXEC Insert_district '" + cmbDivision.Text + "' ,'"
                                           + txtDistrict.Text+ "' ,'"
                                           + UserName + "' ,'"
                                           + DateTime.Now + "' ";

                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("District Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindCmbDivision();
                    txtDistrict.Clear();
                }
                else
                {
                    MessageBox.Show("District for the Division Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (btnSaveDis.Text == "Update")
            {
                DataGridViewRow gvRow = gvDistrict.SelectedRows[0];
                string sqlDistId = "select distId from District where divName='" + gvRow.Cells[0].Value + "' AND distName='"+gvRow.Cells[1].Value+"'";
                int distId = Convert.ToInt32(dp.getResultString(sqlDistId));

                string sqlUpdate = "EXEC Update_district '"
                            + distId + "','"
                            + cmbDivision.Text+ "' ,'"
                            + txtDistrict.Text + "' ,'"
                            + UserName + "' ,'"
                            + DateTime.Now + "' ";
                dp.ExecuteCommand(sqlUpdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDistrict.Clear();
                BindCmbDivision();
                btnSaveDis.Text = "Save";

            }
        }

        private void findrPS_Click(object sender, EventArgs e)
        {
            frmFinderPS finderPs = new frmFinderPS();
            finderPs.Owner = this;
            finderPs.Show();
        }

        private void btnSavePS_Click(object sender, EventArgs e)
        {
            if (btnSavePS.Text == "Save")
            {
                string selCountrow = "SELECT COUNT(*) from policeStation where delStatus<>1 AND psName='" + txtPS.Text + "' AND divName='" + cmbDivPS.Text + "' AND distName='" + cmbDistPS.Text + "'  ";
                int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

                if (rowNumber == 0)
                {
                    string sqlInsert = "EXEC Insert_policeStation '" + cmbDivPS.Text + "' ,'"
                                                + cmbDistPS.Text + "' ,'"
                                                + txtPS.Text + "' ,'"
                                                + UserName + "' ,'"
                                                + DateTime.Now + "' ";

                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("Police Station Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPS.Clear();
                }
                else
                {
                    MessageBox.Show("Police Station for the same District & Division Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (btnSavePS.Text == "Update")
            {
               
               
                //string sqlDistId = "select distId from District where divName='" + gvRow.Cells[0].Value + "' AND distName='" + gvRow.Cells[1].Value + "'";
                //int distId = Convert.ToInt32(dp.getResultString(sqlDistId));

                string sqlUpdate = "EXEC Update_policeStation '"
                            + txtHdnPsId.Text + "','"
                            + cmbDivPS.Text + "' ,'"
                            + cmbDistPS.Text + "' ,'"
                            + txtPS.Text + "' ,'"
                            + UserName+ "' ,'"
                            + DateTime.Now + "' ";;
                dp.ExecuteCommand(sqlUpdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPS.Clear();
                btnSavePS.Text = "Save";

            }
        }
        private void btnFinderPO_Click(object sender, EventArgs e)
        {
            frmFinderPO finderPo=new frmFinderPO();
            finderPo.Owner = this;
            finderPo.Show();
        }
        private void btnSavePO_Click(object sender, EventArgs e)
        {
            if (btnSavePO.Text == "Save")
            {
                string selCountrow = "SELECT COUNT(*) from postOffice where delStatus<>1 AND poName= '" + txtPO.Text + "'AND psName='" + cmbPS.Text + "' AND distName='" + cmbDistPO.Text + "'  AND divName='" + cmbDivPO.Text + "'   ";
                int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

                if (rowNumber == 0)
                {
                    string sqlInsert = "EXEC Insert_postOffice '" +cmbDivPO.Text + "' ,'"
                                             + cmbDistPO.Text + "' ,'"
                                             + cmbPS.Text+ "' ,'"
                                             + txtPO.Text + "' ,'"
                                             + txtPC.Text+ "' ,'"
                                             + UserName + "' ,'"
                                             + DateTime.Now+ "' ";

                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("Post Office Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbPO.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    gbPO.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                }
                else
                {
                    MessageBox.Show("Post Office for the same Police Station, District & Division Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (btnSavePO.Text == "Update")
            {
                string sqlUpdate = "EXEC Update_postOffice '"
                            + txtHdnPoId.Text + "','"
                            + cmbDivPO.Text + "' ,'"
                            + cmbDistPO.Text + "' ,'"
                            + cmbPS.Text + "' ,'"
                            + txtPO.Text + "' ,'"
                            + txtPC.Text + "' ,'"
                            + UserName + "' ,'"
                            + DateTime.Now+ "' ";
                dp.ExecuteCommand(sqlUpdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbPO.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                gbPO.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                btnSavePO.Text = "Save";

            }
        }

        private void btnFinderU_Click(object sender, EventArgs e)
        {
            frmFinderUnion finderUnion = new frmFinderUnion();
            finderUnion.Owner = this;
            finderUnion.Show();

        }

        private void btnSaveU_Click(object sender, EventArgs e)
        {
            if (btnSaveU.Text == "Save")
            {
                string selCountrow = "SELECT COUNT(*) from geoUnion where delStatus<>1 AND UnionName= '" + txtUnion.Text + "'AND postOffice='" + cmbPOU.Text + "' AND policeStation='" + cmbPSU.Text + "'  AND district='" + cmbDistU.Text + "' AND division='" + cmbDivU.Text + "'  ";
                int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

                if (rowNumber == 0)
                {
                    string sqlInsert = " insert into geoUnion(UnionName,postOffice,policestation,district,division,createUser,createDate,delStatus)VALUES('" + txtUnion.Text.Replace("'", "''") + "','" + cmbPOU.Text.Replace("'", "''") + "','" + cmbPSU.Text.Replace("'", "''") + "','" + cmbDistU.Text.Replace("'", "''") + "','" + cmbDivU.Text.Replace("'", "''") + "','" + UserName + "','" + DateTime.Now + "',0)";
                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("Union Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbUnion.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    gbUnion.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                }
                else
                {
                    MessageBox.Show("Union for the same Post Office, Police Station, District & Division Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (btnSaveU.Text == "Update")
            {
                string sqlUpdate = "update geoUnion set UnionName='" + txtUnion.Text.Replace("'", "''") + "',division= '" + cmbDivU.Text.Replace("'", "''") + "',district='" + cmbDistU.Text.Replace("'", "''") + "',policestation='" + cmbPSU.Text.Replace("'", "''") + "',postOffice='" + cmbPOU.Text.Replace("'", "''") + "',createUser='" + UserName + "',createDate='" + DateTime.Now + "' where UnionId='" + txtHdnUnionId.Text + "'";
                dp.ExecuteCommand(sqlUpdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbUnion.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                gbUnion.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                btnSaveU.Text = "Save";

            }
        }

        private void btnFinderSta_Click(object sender, EventArgs e)
        {
            frmFinderStation finderStation = new frmFinderStation();
            finderStation.Owner = this;
            finderStation.Show();
        }

        private void btnSaveSta_Click(object sender, EventArgs e)
        {
            if (btnSaveSta.Text == "Save")
            {
                string selCountrow = "SELECT COUNT(*) from station where delStatus<>1 AND stationName='" + txtStaEng.Text + "' AND UnionName= '" + cmbUnionSta.Text + "'AND poName='" + cmbPOSta.Text + "' AND psName='" + cmbPSSta.Text + "'  AND distName='" + cmbDistSta.Text + "' AND divName='" + cmbDivSta.Text + "'  ";
                int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

                if (rowNumber == 0)
                {
                    string sqlInsert = "EXEC Insert_station '" + cmbDivSta.Text + "' ,'"
                                          + cmbDistSta.Text + "' ,'"
                                          + cmbPSSta.Text+ "' ,'"
                                          + cmbPOSta.Text + "' ,'"
                                          + cmbUnionSta.Text+ "' ,'"
                                          + txtStaBang.Text + "' ,'"
                                          + txtStaEng.Text + "' ,'"
                                          + txtDfltCopy.Text + "' ,'"
                                          + cmbPktType.Text+ "' ,'"
                                          + cmbSubRoute.Text + "' ,'"
                                          + UserName + "' ,'"
                                          + DateTime.Now + "' ,'0' ";
                    dp.ExecuteCommand(sqlInsert);
                    MessageBox.Show("Station Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbStation.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    gbStation.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                }
                else
                {
                    MessageBox.Show("Station for the same Union, Post Office, Police Station, District & Division Already Exists! Please Try Another One ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (btnSaveSta.Text == "Update")
            {
                string sqlUpdate = "EXEC Update_station '"
                            + txtHdnStationId.Text + "','"
                            + cmbDivSta.Text + "' ,'"
                            + cmbDistSta.Text + "' ,'"
                            + cmbPSSta.Text + "' ,'"
                            + cmbPOSta.Text+ "' ,'"
                            + cmbUnionSta.Text + "' ,'"
                            + txtStaBang.Text + "' ,'"
                            + txtStaEng.Text + "' ,'"
                            + txtDfltCopy.Text + "' ,'"
                            + cmbPktType.Text + "' ,'"
                            + cmbSubRoute.Text + "' ,'"
                            + UserName + "' ,'"
                            + DateTime.Now + "' ,'0' ";
                dp.ExecuteCommand(sqlUpdate);
                MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbStation.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                gbStation.Controls.OfType<ComboBox>().ToList().ForEach(comboBox => comboBox.ResetText());
                btnSaveSta.Text = "Save";

            }
        }
        #endregion

        #region All controls change or selection event
        private void gvDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dgRow = gvDivision.Rows[indexRow];

            txtDivName.Text = dgRow.Cells[0].Value.ToString();
            btnSaveDiv.Text = "Update";

        }

        private void cmbDivision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = cmbDivision.SelectedIndex;
            string sItem = cmbDivision.GetItemText(cmbDivision.Items[index]);
            BindDistrictGrd(sItem);

        }

        private void gvDistrict_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dgRow = gvDistrict.Rows[indexRow];

            cmbDivision.Text = dgRow.Cells[0].Value.ToString();
            txtDistrict.Text = dgRow.Cells[1].Value.ToString();
            btnSaveDis.Text = "Update";

        }

        private void cmbDivPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCmbDistrict();
        }

        private void cmbDivPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Focused)
            {
                BindCmbDistrict();
            }
        }

       
        private void cmbDistPO_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = (ComboBox)sender;
            if (cb.Focused)
            {
                BindCmbPS();
            }
                
            
        }
        private void cmbDivU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb= (ComboBox) sender;

            if (cb.Focused)
            {
                BindCmbDistrict();
            }
            
        }

        private void cmbDistU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Focused)
            {
                BindCmbPS();
            }

        }
        private void cmbPSU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Focused)
            {
                BindCmbPO();
            }
        }

        private void cmbDivSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Focused)
            {
                BindCmbDistrict();
            }
        }
        private void cmbDistSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Focused)
            {
                BindCmbPS();
            }
        }
        private void cmbPSSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Focused)
            {
                BindCmbPO();
            }
        }

        private void cmbPOSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Focused)
            {
                BindCmbUnion();
            }
        }
        #endregion

       

       
        

       
        

        
    
        
       

        

        
       
       

       
       

        


        
       

        

        

        
        

        
       



    }
}
