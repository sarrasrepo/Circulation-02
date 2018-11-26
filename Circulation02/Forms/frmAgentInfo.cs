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
using TextBox = System.Windows.Forms.TextBox;

namespace Circulation02.Forms
{
    public partial class frmAgentInfo : Form
    {
        DataProvider dp=new DataProvider();
        DataTable dt= new DataTable();
        DataSet ds = new DataSet();
        public string UserName { get; set; }
        public frmAgentInfo()
        {
            InitializeComponent();
        }

       
#region All Private Method
        private void BindStation_DailyOrderChange()
        {
            string query = "SELECT stationName from dayWisedefaultChange  where delStatus<>1 AND CustId='" + txtHkrId.Text + "' Order By stationName ASC";
            ds = dp.getDataSet(query, "stationName");
            cmbStationDOC.DataSource = ds.Tables[0];
            cmbStationDOC.DisplayMember = "stationName";
            

        }
        private void BindCategory_DailyOrderChange()
        {
            string query = "SELECT DISTINCT CATNAME FROM CATEGORY";
            ds = dp.getDataSet(query, "CATNAME");
            cmbCat.DataSource = ds.Tables[0];
            cmbCat.DisplayMember = "CATNAME";
           
        }

        private void BindSubRoute()
        {
            string query = "SELECT subRouteName from subRoute where delStatus<>1 Order By subRouteName ASC";
            DataSet ds = new DataSet();
            ds = dp.getDataSet(query, "subRouteName");
            cmbSubroute.DataSource = ds.Tables[0];
            cmbSubroute.DisplayMember = "subRouteName";
            cmbSubroute.Text="--- Select ---";

        }

        private void bindStation()
        {
            string query = "SELECT stationName from station where delStatus<>1 Order By stationName ASC";
            DataSet ds = new DataSet();
            ds = dp.getDataSet(query, "stationName");
            cmbStation.DataSource = ds.Tables[0];
            cmbStation.DisplayMember = "stationName";
            cmbStation.Text = "--- Select ---";

        }

        private void readData()
        {
            bool flaghasDta = true;

            string sel = "select * from hawkerInformation where hkrID = '" + txtHkrId.Text + "' ";
            SqlDataReader sdr = dp.getDataReader(sel);

            while (sdr.Read())
            {
                txtHkrId.Text = sdr["hkrID"].ToString();
              
                //bindGrid();
                //bindfrmDistribution();

                //txtAgntId.Text = txtHawkerId.Text;

                txtBnzType.Text = sdr["hkrType"].ToString();
                txtNameBangla.Text = sdr["hkrNameBangla"].ToString();
                txtAgntName.Text = sdr["hkrNameEng"].ToString();

                lblAgntName.Text = txtAgntName.Text;

                //txtHkrFatherName.Text = sdr["fatherName"].ToString();

                //if (ddlCusType.SelectedItem.Text == "Hawker" || ddlCusType.SelectedItem.Text == "Sub-Agent")
                //{
                //    ddlAgentName.Text = sdr["agentName"].ToString();
                //}
                //bindAgentArea();
               // ddlAgentArea.SelectedItem.Text = sdr["agentArea"].ToString();
                //ddlArrival.Text = sdr["salesDuration"].ToString();
                //txtSortingOrder.Text = sdr["sortingOrder"].ToString();
                //txtMarriageDay.Text = sdr["marigeDay"].ToString();
                txtFlotQty.Text = sdr["floatingCopy"].ToString();
                txtRegQty.Text = sdr["regularCopy"].ToString();
                txtCprQty.Text = sdr["corporateCopy"].ToString();
                txtBillTo.Text = sdr["billTo"].ToString();
                bindStation();
                BindSubRoute();
                cmbSubroute.Text = sdr["agentArea"].ToString();
                cmbStation.Text = sdr["salesArea"].ToString();
                //txtBirthDay.Text = sdr["birthDay"].ToString();
                txtMobNo.Text = sdr["mobileNumber"].ToString();

                //chkActive.Checked = false;
                //ChkInactive.Checked = false;
                //if (Convert.ToBoolean(sdr["delStatus"].ToString()) == false)
                //{
                //    chkActive.Checked = true;
                //}
                //else
                //{
                //    ChkInactive.Checked = true;
                //}

                //flaghasDta = false;
            }



        }

        private void FamilyInfo()
        {
            gbFamInfoTop.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            btnFamAdd.Text = "Add";
            txtAgntID.Text = txtHkrId.Text;
            string sqlQry = "select * from agntFamInfo where hkrid='"+txtHkrId.Text+"'";
            SqlDataReader sdr = dp.getDataReader(sqlQry);
            while (sdr.Read())
            {
                txtAgntID.Text = sdr["hkrId"].ToString();
                txtEdu.Text = sdr["education"].ToString();
                txtBloodGrp.Text = sdr["bloodGrp"].ToString();
                txtFatherName.Text = sdr["fatherName"].ToString();
                txtMotherName.Text = sdr["motherName"].ToString();
                txtPreAddr.Text = sdr["presentAdd"].ToString();
                txtPerAddr.Text = sdr["permanentAdd"].ToString();
                btnFamAdd.Text = "Update";
            }

            sdr.Close();

        }
        private void DropPoint()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT rmId,rmName,statId,stationName,defaultCopy from AgentDropPoint where custId = '" + txtHkrId.Text + "' ", con);
            sda.Fill(dt);
            gvDropPoint.DataSource = dt;
            con.Close();

        }
        private void ReadDailyOrderChange()
        {


            string strCountRow = "Select Count(*) from dayWisedefaultChange  where delStatus<>1 AND CustId='" + txtHkrId.Text + "' ";
            int intRow = Convert.ToInt32(dp.getResultString(strCountRow));

            if (intRow != 0 && intRow > 0)
            {

                bool flaghasDta = true;

                string strStationId = "Select stationId from station where stationName='" + cmbStation.Text + "' and delStatus<>1";
                int stationId = Convert.ToInt32(dp.getResultString(strStationId));


                string sel = "select day,quantityChange from AgentDailyOrderChange where hkrID='" + txtHkrId.Text + "' and StationId='" + stationId + "' AND category='" + cmbCat.Text + "' ";
                SqlDataReader sdr = dp.getDataReader(sel);

                while (sdr.Read())
                {
                    string strDay = sdr["day"].ToString();

                    if (strDay == "SAT")
                    {
                        txtSat.Text = sdr["quantityChange"].ToString();
                    }

                    if (strDay == "SUN")
                    {
                        txtSun.Text = sdr["quantityChange"].ToString();
                    }

                    if (strDay == "MON")
                    {
                        txtMon.Text = sdr["quantityChange"].ToString();
                    }

                    if (strDay == "TUE")
                    {
                        txtTue.Text = sdr["quantityChange"].ToString();
                    }

                    if (strDay == "WED")
                    {
                        txtWed.Text = sdr["quantityChange"].ToString();
                    }

                    if (strDay == "THU")
                    {
                        txtThu.Text = sdr["quantityChange"].ToString();
                    }

                    if (strDay == "FRI")
                    {
                        txtFri.Text = sdr["quantityChange"].ToString();
                    }

                    flaghasDta = false;

                }

                if (flaghasDta == true)
                {
                    txtSat.Text = "0";
                    txtSun.Text = "0";
                    txtMon.Text = "0";
                    txtTue.Text = "0";
                    txtWed.Text = "0";
                    txtThu.Text = "0";
                    txtFri.Text = "0";
                }
            }

        }
        private void bindAgentSalesData()
            {
            bool flag = false;
            DataTable dts= new DataTable();

            lblagntNameSI.Text = txtAgntName.Text;
            dts.Columns.Clear();
            dts.Rows.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;");
            SqlDataAdapter sda = new SqlDataAdapter("Select PaperName,PaperQuantity from AGENTSALESINFO where  hkrId='" + txtHkrId.Text + "'", con);
            sda.Fill(dts);
            gvSalesInfo.DataSource = dts;
            con.Close();
            
        }

        private void UpdateDailyOrderChange()
        {

            string quantityChange = "";
            string strDay = "";

            string strStationId = "Select stationId from station where stationName='" + cmbStation.Text +
                                  "' and delStatus<>1";
            int stationId = Convert.ToInt32(dp.getResultString(strStationId));

            string sel = "select day,quantityChange from AgentDailyOrderChange where hkrID='" + txtHkrId.Text +
                         "' and category='" + cmbCat.Text + "'  ";
            SqlDataReader sdr = dp.getDataReader(sel);

            while (sdr.Read())
            {
                strDay = sdr["day"].ToString();

                if (strDay == "SAT")
                {
                    quantityChange = txtSat.Text;
                }

                if (strDay == "SUN")
                {
                    quantityChange = txtSun.Text;
                }

                if (strDay == "MON")
                {
                    quantityChange = txtMon.Text;
                }

                if (strDay == "TUE")
                {
                    quantityChange = txtTue.Text;
                }

                if (strDay == "WED")
                {
                    quantityChange = txtWed.Text;
                }

                if (strDay == "THU")
                {
                    quantityChange = txtThu.Text;
                }

                if (strDay == "FRI")
                {
                    quantityChange = txtFri.Text;
                }

             
                string cmd = "update AgentDailyOrderChange set quantityChange = '" + quantityChange +
                             "', createDate = '" + DateTime.Now + "', audUser = '" + UserName + "', StationId='" +
                             stationId + "' where day = '" + strDay + "' and hkrID='" + txtHkrId.Text +
                             "' and StationId='" + stationId + "' and category='" + cmbCat.Text + "' ";
                dp.ExecuteCommand(cmd);

            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

            btnSave.Text = "Update";
            string maxId = "select max(hkrID)from hawkerInformation";
            int intMaxId = Convert.ToInt32(dp.getResultString(maxId));

            txtHkrId.Text = intMaxId.ToString();

            BindStation_DailyOrderChange();  
            readData();
            FamilyInfo();
            DropPoint();
            BindCategory_DailyOrderChange();
            bindAgentSalesData();
            //readDailyChange();
            //bindAgentSalesData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            btnSave.Text = "Update";
            string MinId = "select min(hkrID) from hawkerInformation";
            int intMinId = Convert.ToInt32(dp.getResultString(MinId));

            txtHkrId.Text = intMinId.ToString();

            BindStation_DailyOrderChange();
            readData();
            FamilyInfo();
            DropPoint();
            BindCategory_DailyOrderChange();
            bindAgentSalesData();
            //readDailyChange();
            //bindAgentSalesData();


        }
        private void btnNext_Click(object sender, EventArgs e)
        {
           

            if (txtHkrId.Text == "")
            {
                string maxId = "select max(hkrID)from hawkerInformation";
                int intMaxId = Convert.ToInt32(dp.getResultString(maxId));
                txtHkrId.Text = intMaxId.ToString();
                BindStation_DailyOrderChange();
                readData();
                FamilyInfo();
                DropPoint();
                BindCategory_DailyOrderChange();
                bindAgentSalesData();
                //readDailyChange();
                //bindAgentSalesData();
            }

            else
            {
                string sqlId = "select top 1 hkrID from hawkerInformation where hkrID>'" + txtHkrId.Text + "' order by hkrid ";
               
                int id = Convert.ToInt32(dp.getResultString(sqlId));

                txtHkrId.Text = id.ToString();

                    BindStation_DailyOrderChange();
                    readData();
                    FamilyInfo();
                    DropPoint();
                    BindCategory_DailyOrderChange();
                    bindAgentSalesData();
                //readDailyChange();
                //bindAgentSalesData();

            }
            btnSave.Text = "Update";
            
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (txtHkrId.Text == "")

            {
                string sqlminId = "select min(hkrID)from hawkerInformation";
                int minId = Convert.ToInt32(dp.getResultString(sqlminId));
                txtHkrId.Text = minId.ToString();
                BindStation_DailyOrderChange();
                readData();
                FamilyInfo();
                DropPoint();
                BindCategory_DailyOrderChange();
                bindAgentSalesData();
                //readDailyChange();
                //bindAgentSalesData();
            }


            if(txtHkrId.Text!="1")
            {
                string sqlId = "select top 1 hkrID from hawkerInformation where hkrID <'" + txtHkrId.Text + "' order by hkrid DESC";

                int id = Convert.ToInt32(dp.getResultString(sqlId));

                txtHkrId.Text = id.ToString();

                BindStation_DailyOrderChange();
                readData();
                FamilyInfo();
                DropPoint();
                BindCategory_DailyOrderChange();
                bindAgentSalesData();
                //readDailyChange();
                //bindAgentSalesData();
            }

               btnSave.Text = "Update";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        
            string maxId = "select max(hkrID)from hawkerInformation";
            int intmaxId = Convert.ToInt32(dp.getResultString(maxId));

             if (intmaxId != 0)
                {
                    int  agentId = (intmaxId + 1);
                    grpBoxHdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    txtHkrId.Text = agentId.ToString();
                    BindSubRoute();
                    bindStation();
                    btnSave.Text = "Save";
                }

        }

        #endregion
        private void frmAgentInfo_Load(object sender, EventArgs e)
        {
            BindSubRoute();
            bindStation();
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from hawkerInformation where hkrID = '" + txtHkrId.Text + "' ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (rowNumber == 0)
            {
                if (txtAgntName.Text!="")
                {
                    try
                    {
                        string selHkrId = "Select max(hkrID) from hawkerInformation";
                        int maxHkrID = Convert.ToInt32(dp.getResultString(selHkrId));
                        txtHkrId.Text = (maxHkrID + 1).ToString();

                        string cmd = "EXEC Insert_HawkerInfo '"
                                   + txtHkrId.Text + "','"
                                   + txtBnzType.Text + "','"
                                   + txtNameBangla.Text + "','"
                                   + txtAgntName.Text + "','','','"
                                   + cmbSubroute.Text + "','','' ,'','"
                                   + txtFlotQty.Text + "','"
                                   + txtRegQty.Text + "','"
                                   + txtCprQty.Text + "','"
                                   + txtBillTo.Text + "','','"
                                   + cmbStation.Text + "','','"
                                   + txtMobNo.Text + "','"
                                   + DateTime.Now + "','"
                                   + UserName + "','0'";

                        dp.ExecuteCommand(cmd);

                        MessageBox.Show("Agent Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
               
                }
                else
                {
                    MessageBox.Show("Please fill Agent Details !", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            if (btnSave.Text=="Update")
            {
                string sqlHkrId = "select * from hawkerInformation where hkrID='" + txtHkrId.Text + "' ";
                int hkrId = Convert.ToInt32(dp.getResultString(sqlHkrId));
                try
                {
                    string cmd = "update hawkerInformation set hkrType='" + txtBnzType.Text + "', hkrNameBangla='" + txtNameBangla.Text + "', hkrNameEng='" + txtAgntName.Text + "', agentArea='" +cmbSubroute.Text+"', floatingCopy='" + txtFlotQty.Text + "', regularCopy='" + txtRegQty.Text + "', corporateCopy='" + txtCprQty.Text + "', billTo='" + txtBillTo.Text + "', salesArea='" + cmbStation.Text + "',  mobileNumber='" + txtMobNo.Text + "', createDate ='" + DateTime.Now + "', audUser ='" + UserName + "' where hkrID='" + txtHkrId.Text + "' ";
                    dp.ExecuteCommand(cmd);

                    MessageBox.Show("Updated Successfully ", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
             
            }

        private void btnAgntFinder_Click(object sender, EventArgs e)
        {
            frmFinderAgnt finderAgnt=new frmFinderAgnt();
            finderAgnt.Owner = this;
            finderAgnt.Show();
        }

        private void btnFamAdd_Click(object sender, EventArgs e)
        {
            if (btnFamAdd.Text=="Add")
            {
                try
                {
                    string sqlCmd = "INSERT INTO agntFamInfo VALUES('"+txtAgntID.Text+"','"+txtEdu.Text+"', '"+txtBloodGrp.Text+"','"+txtFatherName.Text+"','"+txtMotherName.Text+"','"+txtPreAddr.Text+"','"+txtPerAddr.Text+"','"+UserName+"','"+DateTime.Now+"')";
                    dp.ExecuteCommand(sqlCmd);
                    MessageBox.Show("Information Added Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }

            if (btnFamAdd.Text == "Update")
            {
                try
                {
                    string sqlCmd = "UPDATE agntFamInfo SET education='" + txtEdu.Text + "', bloodGrp='" + txtBloodGrp.Text + "', fatherName='" + txtFatherName.Text + "', motherName='" + txtMotherName.Text + "',presentAdd='" + txtPreAddr.Text + "', permanentAdd='" + txtPerAddr.Text + "',createBy='" + UserName + "',createDate='" + DateTime.Now + "' WHERE hkrId='"+txtAgntID.Text+"'";
                    dp.ExecuteCommand(sqlCmd);
                    MessageBox.Show("Information Updated Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadDailyOrderChange();

        }

        private void btnSaveDOC_Click(object sender, EventArgs e)
        {
            string AgentId = txtHkrId.Text;
            //lblAgntName.Text = txtHkrName.Text;
            string AgentName = lblAgntName.Text;

            string SAT = lblSat.Text;
            string SATPAGE = txtSat.Text;

            string SUN = lblSun.Text;
            string SUNPAGE = txtSun.Text;

            string MON = lblMon.Text;
            string MONPAGE = txtMon.Text;

            string TUES = lblTue.Text;
            string TUESPAGE = txtTue.Text;

            string WED = lblWed.Text;
            string WEDPAGE = txtWed.Text;

            string THURS = lblThu.Text;
            string THURSPAGE = txtThu.Text;

            string FRI = lblFri.Text;
            string FRIPAGE = txtFri.Text;

           

            string strStationId = "Select stationId from station where stationName='" + cmbStationDOC.Text + "' and delStatus<>1";
            int stationId = Convert.ToInt32(dp.getResultString(strStationId));

            string strCountRow = "select count(*) from AgentDailyOrderChange where hkrID='" + txtHkrId.Text + "' AND StationId='" + stationId + "' AND category='" + cmbCat.Text + "' ";
            int rowNumber = Convert.ToInt32(dp.getResultString(strCountRow));

            if (rowNumber == 0)
            {
                string sqlCmd = "INSERT INTO AgentDailyOrderChange (hkrID,hkrNameEng,day,quantityChange,createDate,audUser,StationId,category) VALUES ('" + AgentId + "', '" + AgentName + "', '" + SAT + "','" + SATPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "','" + cmbCat.Text + "') , ('" + AgentId + "', '" + AgentName + "', '" + SUN + "','" + SUNPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "' ,'" + cmbCat.Text + "'), ('" + AgentId + "', '" + AgentName + "', '" + MON + "','" + MONPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "' ,'" + cmbCat.Text + "'), ('" + AgentId + "', '" + AgentName + "', '" + TUES + "','" + TUESPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "' ,'" + cmbCat.Text + "'), ('" + AgentId + "', '" + AgentName + "', '" + WED + "','" + WEDPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "','" + cmbCat.Text + "'), ('" + AgentId + "', '" + AgentName + "', '" + THURS + "','" + THURSPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "','" + cmbCat.Text + "'), ('" + AgentId + "', '" + AgentName + "', '" + FRI + "','" + FRIPAGE + "','" + DateTime.Now + "','" + UserName + "','" + stationId + "','" + cmbCat.Text + "')  ";
                dp.ExecuteCommand(sqlCmd);
                MessageBox.Show("Day Wise Quantity Added Sucessfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            else
            {
                UpdateDailyOrderChange();
                MessageBox.Show("Day Wise Quantity Updated Sucessfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            ReadDailyOrderChange();



            btnSaveDOC.Text = "Update";
           
        }

           
        }
    
    }
