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

namespace Circulation02.Forms
{
    public partial class frmOrdEntry : Form
    {
        public string UserName { get; set; }
        private DataProvider dp = new DataProvider();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        private string connStr ="Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";

        public frmOrdEntry()
        {
            InitializeComponent();
        }
        private void frmOrdEntry_Load(object sender, EventArgs e)
        {
            BindcmbCategory();
            BindVehicle();
            BindsubRoute();
            cmbEdition.SelectedIndex = 0;

        }

        #region All region
        private void BindData()
        {
            bool flaghasDta = true;
            string stationName = "";

            string sel = "select * from orderEntry where orderNo = '" + txtOdrId.Text + "'";
            SqlDataReader sdr = dp.getDataReader(sel);
            while (sdr.Read())
            {
                txtOdrId.Text = sdr["orderNo"].ToString();
                dTPOrdDate.Text = sdr["orderDate"].ToString();
                cmbVehicle.Text = sdr["vehicle"].ToString();
                cmbSubRoute.Text = sdr["subRoute"].ToString();
                txtAgntId.Text = sdr["customerId"].ToString();
                cmbCategory.Text = sdr["catagory"].ToString();
                txtRate.Text = sdr["rate"].ToString();
                cmbSalesType.Text = sdr["salesType"].ToString();
                stationName = sdr["stationName"].ToString();
                cmbEdition.Text = sdr["edition"].ToString();

                flaghasDta = false;
                break;
            }

            if (flaghasDta == false)
            {
                DataTable dt=new DataTable();
                //gvOrder.ResetBindings();
                //dtg.Rows.Clear();

                SqlConnection con = new SqlConnection(connStr);
               SqlDataAdapter sda =
                    new SqlDataAdapter("select stationName,quantity,bonusCopy,complementaryCopy,packetType from ShowOrder where orderNo = '" +
                        txtOdrId.Text + "' ", con);
                sda.Fill(dt);
                gvOrder.DataSource = dt;
                con.Close();

            }

            if (flaghasDta == true)
            {
                txtOdrId.Text = "";
                dTPOrdDate.Text = "";
                txtAgntId.Text = "";

            }

            int postStatus = 0;

            string selpostStatus = "SELECT postStatus from orderEntry where orderNo = '" + txtOdrId.Text + "' ";
            SqlDataReader sdrpost = dp.getDataReader(selpostStatus);

            while (sdrpost.Read())
            {
                postStatus = sdrpost["postStatus"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(sdrpost["postStatus"]);
            }

            sdrpost.Close();

            if (postStatus == 0)
            {
                btnPost.Enabled = true;
            }
            else
            {
                btnPost.Enabled = false;
                btnSave.Enabled = false;
                MessageBox.Show("Posted Data...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BindcmbCategory()
        {
            string sqlQry = "SELECT  CatName from CATEGORY where delStatus<>1 Order By CatName ASC ";
            ds = dp.getDataSet(sqlQry, "CatName");
            cmbCategory.DataSource = ds.Tables[0];
            cmbCategory.DisplayMember = "CatName";
            cmbCategory.Text= "---- Select ----";
        }

        private void BindVehicle()
        {
            string query = "SELECT  vehicleName from vehicle where delStatus<>1 Order By vehicleName ASC ";
            ds = dp.getDataSet(query, "vehicleName");
            cmbVehicle.DataSource = ds.Tables[0];
            cmbVehicle.DisplayMember = "vehicleName";
            cmbVehicle.Text= "---- Select ----";
        }

        

        private void BindsubRoute()
        {
            string query = "SELECT  subRouteName from subRoute where delStatus<>1 Order By subRouteName ASC ";
            ds = dp.getDataSet(query, "subRouteName");
            cmbSubRoute.DataSource = ds.Tables[0];
            cmbSubRoute.DisplayMember = "subRouteName";
            cmbSubRoute.Text = "---- Select ----";
            
        }

        private void Update()
        {
            foreach (DataGridViewRow gridRow in gvOrder.Rows)
            {

                var station = gridRow.Cells[0].Value.ToString();
                var qty = gridRow.Cells[1].Value.ToString();
                var bCopy = gridRow.Cells[2].Value.ToString();
                var cCopy = Convert.ToInt32(gridRow.Cells[3].Value.ToString());
                //ComboBox ddlPacket = gR.Cells[5].FindControl("ddlPacket") as DropDownList;
                var pType = gridRow.Cells[4].Value.ToString();
                
                string type = "";
                string corporate = "";

                if (cmbSalesType.Text == "Cash")
                {
                    var checkedButton = panelSalesTyp.Controls.OfType<RadioButton>()
                            .FirstOrDefault(r => r.Checked).Text;

                    string cmd = "update orderEntry set orderDate='" + dTPOrdDate.Text + "', vehicle='" + cmbVehicle.Text.Replace("'", "''") + "', subRoute='" + cmbSubRoute.Text.Replace("'", "''") + "', customerId='" + txtAgntId.Text + "', catagory='" + cmbCategory.Text + "', rate='" + txtRate.Text + "', salesType='" + cmbSalesType.Text + "', type='" + checkedButton + "',  quantity='" + qty+ "', bonusCopy='" + bCopy + "', complementaryCopy='" + cCopy + "', packetType='" + pType+ "', auditUser='" + UserName + "', createDate='" + DateTime.Now + "',edition='" + cmbEdition.Text + "'  where orderNo = '" + txtOdrId.Text + "' AND stationName='" + station.Trim().Replace("'", "''") + "' ";
                    dp.ExecuteCommand(cmd);
                    
                }

                if (cmbSalesType.Text == "Credit")
                {
                    if (cBLW.Checked)
                    {
                        type = cBLW.Text.Trim();
                    }

                    if (cBCorp.Checked)
                    {
                        type = cBCorp.Text.Trim();
                        if (rBPre.Checked)
                        {
                            corporate = rBPre.Text.Trim();
                        }

                        else if (rBPost.Checked)
                        {
                            corporate = rBPost.Text.Trim();
                        }

                    }

                    string cmd = "update orderEntry set orderDate='" + dTPOrdDate.Text + "', vehicle='" + cmbVehicle.Text.Replace("'","''") + "', subRoute='" + cmbSubRoute.Text.Replace("'","''") + "', customerId='" + txtAgntId.Text + "', catagory='" + cmbCategory.Text + "', rate='" + txtRate.Text + "', salesType='" + cmbSalesType.Text + "', type='" + type + "', corporate='" + corporate + "', stationName='" + station.Replace("'", "''") + "', quantity='" + qty + "', bonusCopy='" + bCopy+ "', complementaryCopy='" + cCopy + "', packetType='" + pType + "', auditUser='" + UserName + "', createDate='" + DateTime.Now + "',edition='" + cmbEdition.Text + "'  where orderNo = '" + txtOdrId.Text + "' AND stationName='" + station.Replace("'", "''") + "' ";
                    dp.ExecuteCommand(cmd);
                    
                }
                
            }
            MessageBox.Show("Order Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        #endregion

        #region All Button
        private void btnLast_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Update";

            string maxId = "SELECT  max(orderNo) from orderEntry";
            int intMaxId = Convert.ToInt32(dp.getResultString(maxId));

            txtOdrId.Text = intMaxId.ToString();

            BindData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Update";

            string minId = "SELECT  min(orderNo) from orderEntry";
            int intMinId = Convert.ToInt32(dp.getResultString(minId));

            txtOdrId.Text = intMinId.ToString();

            BindData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Update";

            if (txtOdrId.Text == "***** New *****")
            {
                string maxId = "Select max(orderNo) from orderEntry";
                int intMaxId = Convert.ToInt32(dp.getResultString(maxId));
                //int Id = 1;
                txtOdrId.Text = intMaxId.ToString();

                BindData();
            }

            else
            {
                string sqlOrdId = "SELECT  (orderNo+1) from orderEntry where orderNo='" + txtOdrId.Text + "'";
                int ordId = Convert.ToInt32(dp.getResultString(sqlOrdId));

                txtOdrId.Text = ordId.ToString();
                BindData();

            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Update";

            if (txtOdrId.Text == "***** New *****")
            {
                string minId = "Select min(orderNo) from orderEntry";
                int intMinId = Convert.ToInt32(dp.getResultString(minId));
                //int Id = 1;
                txtOdrId.Text = intMinId.ToString();

                BindData();
            }

            else
            {
                string sqlOrdId = "SELECT  (orderNo-1) from orderEntry where orderNo='" + txtOdrId.Text + "'";
                int ordId = Convert.ToInt32(dp.getResultString(sqlOrdId));

                txtOdrId.Text = ordId.ToString();
                BindData();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gbhdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            gbhdr.Controls.OfType<ComboBox>().ToList().ForEach(ComboBox => ComboBox.SelectedIndex=-0);
            gvOrder.DataSource = null;
            btnSave.Text = "Save";
        }
        private void btnFindOrd_Click(object sender, EventArgs e)
        {
            frmFinderOrder finderOrder=new frmFinderOrder(this);
            finderOrder.Owner = this;
            finderOrder.Show();
        }
        private void brnFindAgnt_Click(object sender, EventArgs e)
        {
            frmFinderAgnt2 agnt2= new frmFinderAgnt2(this);
            agnt2.Owner=this;
            agnt2.Show();
        }

        private void cmbSalesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalesType.SelectedIndex==0)
            {
                cBLW.Visible = false;
                cBCorp.Visible = false;
                panel.Visible = false;

                panelCorp.Visible = false;
                //cBPre.Visible = false;
                //cBPost.Visible = false;
              
                panelSalesTyp.Visible = true;
                rBFloatStrt.Visible = true;
                rBFloatOut.Visible = true;
            }

            if (cmbSalesType.SelectedIndex == 1)
            {
                panelSalesTyp.Visible = false;
                rBFloatStrt.Visible = false;
                rBFloatOut.Visible = false;
                
                cBLW.Visible = true;
                cBCorp.Visible = true;
                panel.Visible = true;
            }
        }

        private void cBCorp_CheckedChanged(object sender, EventArgs e)
       
         {
            if (cBCorp.Checked==true)
            {
                panelCorp.Visible = true;
                rBPre.Visible = true;
                rBPost.Visible = true;
               
            }

            else
            {
                panelCorp.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int orderNo = 0;
            bool flashOrdId = false;

            if (btnSave.Text == "Save")
            {
                foreach (DataGridViewRow gR in gvOrder.Rows)
                {
                    var station = gR.Cells[0].Value.ToString();
                    var qty = gR.Cells[1].Value.ToString();
                    var bCopy = gR.Cells[2].Value.ToString();
                    var cCopy = Convert.ToInt32(gR.Cells[3].Value.ToString());
                    var pType = gR.Cells[4].Value.ToString();

                    string sqlmaxNo = "select max(orderNo)from orderEntry";
                    int maxNo = Convert.ToInt32(dp.getResultString(sqlmaxNo));

                    if (flashOrdId == false)
                    {
                        orderNo = maxNo + 1;
                        flashOrdId = true;
                    }


                    string type = "";
                    string corporate = "";

                    if (cmbSalesType.SelectedIndex == 0)
                    {
                        var checkedButton = panelSalesTyp.Controls.OfType<RadioButton>()
                            .FirstOrDefault(r => r.Checked).Text;


                        string insertQuery =
                            "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,auditUser,createDate,edition,postStatus,syncFlag) values('" +
                            orderNo + "','" + dTPOrdDate.Text + "','" + cmbVehicle.Text.Trim().Replace("'", "''") +
                            "','" + cmbSubRoute.Text.Trim().Replace("'", "''") + "','" + txtAgntId.Text + "', '" +
                            cmbCategory.Text + "','" + txtRate.Text + "','" + cmbSalesType.Text + "','" + checkedButton +
                            "','" + corporate + "','" + station.Replace("'", "''") + "','" + qty + "','" + bCopy + "','" +
                            cCopy + "','" + pType + "', '" + UserName + "', '" + DateTime.Now + "','" + cmbEdition.Text +
                            "',0,0)";

                        dp.ExecuteCommand(insertQuery);
                        
                    }

                    if (cmbSalesType.SelectedIndex == 1)
                    {
                        if (cBLW.Checked)
                        {
                            type = cBLW.Text.Trim();
                        }

                        if (cBCorp.Checked)
                        {
                            type = cBCorp.Text.Trim();
                            if (rBPre.Checked)
                            {
                                corporate = rBPre.Text.Trim();
                            }

                            else if (rBPost.Checked)
                            {
                                corporate = rBPost.Text.Trim();
                            }

                        }

                        string insertQuery ="INSERT INTO orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,auditUser,createDate,edition,postStatus,syncFlag) values('" +
                            orderNo + "','" + dTPOrdDate.Text + "','" + cmbVehicle.Text.Replace("'", "''") + "','" +
                            cmbSubRoute.Text.Replace("'", "''") + "','" + txtAgntId.Text + "', '" + cmbCategory.Text +
                            "','" + txtRate.Text + "','" + cmbSalesType.Text + "','" + type + "','" + corporate + "','" +
                            station + "','" + qty + "','" + bCopy + "','" + cCopy + "','" + pType + "', '" + UserName +
                            "', '" + DateTime.Now + "','" + cmbEdition.Text + "',0,0)";
                        dp.ExecuteCommand(insertQuery);
                        
                   }
                   
                }
                MessageBox.Show("Order Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                Update();
                btnSave.Text = "Update";
            }

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE orderEntry set postStatus=1 where orderNo = '" + txtOdrId.Text + "'";
            dp.ExecuteCommand(cmd);

            btnSave.Enabled = false;
            btnPost.Enabled = false;
            MessageBox.Show("Order Posted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        #region ControlEvents
        private void txtAgntId_TextChanged(object sender, EventArgs e)
        {
            if (txtAgntId.Focused)
            {
                dt.Rows.Clear();
                SqlConnection con = new SqlConnection(connStr);
                SqlDataAdapter sda =
                    new SqlDataAdapter(
                        "Select stationName,quantity,bonusCopy,complementaryCopy,packetType from OrederCapture where hkrID='" +
                        txtAgntId.Text + "'", con);
                sda.Fill(dt);
                gvOrder.DataSource = dt;
                con.Close();
            }

        }

        #endregion

       
       


    }

}
