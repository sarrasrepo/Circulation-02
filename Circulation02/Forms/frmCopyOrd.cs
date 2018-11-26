using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulation02.Forms
{
    public partial class frmCopyOrd : Form
    {
        public DateTime? yesterday1 { get; set; }
        public DateTime? sameday1 { get; set; }
        public DateTime? FrmDate { get; set; }

        DataProvider dp = new DataProvider();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public string UserName { get; set; }
        public frmCopyOrd()
        {
            InitializeComponent();
        }

      private void frmCopyOrd_Load(object sender, EventArgs e)
        {
          BindCategory();
          BindRoute();
          BindSubRoute();
        }

      private void BindCategory()
      {
          string sql = "SELECT  CatName from CATEGORY where delStatus<>1 Order By CatName ASC ";
          ds = dp.getDataSet(sql, "CatName");
          cmbCat.DisplayMember = "CatName";
          cmbCat.DataSource = ds.Tables[0];
          cmbCat.Text = "---- Select ----";
      }

      private void BindRoute()
      {
          string query = "SELECT  routeName from subRoute where delStatus<>1 and routeName<>'--Select--' Order By routeName ASC ";
          ds = dp.getDataSet(query, "routeName");

          cmbFrmRoute.DataSource = ds.Tables[0];
          cmbFrmRoute.DisplayMember = "routeName";
          cmbFrmRoute.Text = "---- Select ----";

          cmbToRoute.DataSource = ds.Tables[0];
          cmbToRoute.DisplayMember = "routeName";
          cmbToRoute.Text = "---- Select ----";
          
      }

      private void BindSubRoute()
      {
          string query = "SELECT  subRouteName from subRoute where delStatus<>1 Order By routeName ASC ";
          ds = dp.getDataSet(query, "subRouteName");

          cmbFrmSRoute.DataSource = ds.Tables[0];
          cmbFrmSRoute.DisplayMember = "subRouteName";
          cmbFrmSRoute.Text = "---- Select ----";

          cmbToSRoute.DataSource = ds.Tables[0];
          cmbToSRoute.DisplayMember = "subRouteName";
          cmbToSRoute.Text = "---- Select ----";

      }

      private void rBSpcDate_CheckedChanged(object sender, EventArgs e)
      {
          dTPSpcDate.Visible = rBSpcDate.Checked == true;
      }

      private void btnProcess_Click(object sender, EventArgs e)
      {
          string frmSubroute = "";
          string toSubroute = "";

          string strcountDate = "SELECT  count(*) from orderEntry where orderDate = '" + dTPTransDate.Text + "' AND catagory='" + cmbCat.Text + "' ";
          int countDate = Convert.ToInt32(dp.getResultString(strcountDate));

          if (countDate != 0)
          {
              MessageBox.Show("Data Already Exits for this Date !!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
          }

          else
          {
              if (cmbFrmRoute.Text != "---- Select ----" && cmbToRoute.Text != "---- Select ----")
              {
                  string strfrmSubroute = "select subRouteName from subRoute where delStatus <> 1 and routeName = '" + cmbFrmRoute.Text.Replace("'","''")+ "' ";
                  frmSubroute = dp.getResultString(strfrmSubroute);

                  string strtoSubroute = "select subRouteName from subRoute where delStatus <> 1 and routeName = '" +cmbToRoute.Text.Replace("'","''") + "' ";
                  toSubroute = dp.getResultString(strtoSubroute);
              }

              string strsubRoute = "select subRoute from orderEntry";
              string subRoute = dp.getResultString(strsubRoute);

              if (rBPrevDate.Checked)
              {
                  DateTime ss = Convert.ToDateTime(dTPTransDate.Text);
                  string strYesterday = ss.AddDays(-1).ToString("dd-MMM-yyyy");
                  yesterday1 = Convert.ToDateTime(strYesterday);
              }

              if (rBSameDay.Checked)
              {
                  DateTime ss = Convert.ToDateTime(dTPTransDate.Text);
                  string strSameday = ss.AddDays(-7).ToString("dd/MM/yyyy");
                  sameday1 = Convert.ToDateTime(strSameday);
              }

              string sel = "select orderNo from CopyOrder where orderDate = '" + dTPSpcDate.Text + "' or orderDate = '" + yesterday1 + "' or orderDate = '" + sameday1 + "' GROUP BY orderNo ";
              SqlDataReader sdr = dp.getDataReader(sel);

              while (sdr.Read())
              {
                  int oeOrderNo = Convert.ToInt32(sdr["orderNo"].ToString());

                  string orderNo = "select (MAX(orderNo)+1) from CopyOrder ";
                  int intorderNo = Convert.ToInt32(dp.getResultString(orderNo));

                  string modifyReason = "0";
                  string edition = "City Edition";
                  byte postStatus = 0;
                  byte syncFlag = 0;
                  int daywiseDefQuanttity = 0;
                  int daywiseChngQuantity = 0;
                  int smsQuantity = 0;

                  DateTime createDate = DateTime.Now;
                  //string auditUser = Session["UserName"].ToString();

                  if (rBSpcDate.Checked)
                  {
                      DateTime orderDate = Convert.ToDateTime(dTPSpcDate.Text);
                      DateTime strOrderDate = Convert.ToDateTime(dTPTransDate.Text);

                      if (frmSubroute == subRoute && toSubroute == subRoute && cmbFrmRoute.Text != "---- Select ----" && cmbToRoute.Text != "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + orderDate + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + frmSubroute + "' and '" + toSubroute + "' ";
                          string insertQuery = "INSERT INTO orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + orderDate + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + frmSubroute + "' and '" + toSubroute + "' AND catagory='" + cmbCat.Text + "' ";


                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");
                          
                      }
                      else if (cmbFrmSRoute.Text != "---- Select ----" && cmbToSRoute.Text != "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + orderDate + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + HttpUtility.HtmlDecode(ddlFrmSubRoute.SelectedItem.Text.Trim()) + "' and '" + HttpUtility.HtmlDecode(ddlToSubRoute.SelectedItem.Text.Trim()) + "' ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + orderDate + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + cmbFrmSRoute.Text.Trim() + "' and '" + cmbToSRoute.Text.Trim() + "' AND catagory='" + cmbCat.Text + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");
                         
                      }

                      else if (cmbFrmSRoute.Text == "---- Select ----" && cmbToSRoute.Text == "---- Select ----" && cmbFrmRoute.Text == "---- Select ----" && cmbToRoute.Text == "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + orderDate + "' AND orderNo = '" + oeOrderNo + "'  ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + orderDate + "' AND orderNo = '" + oeOrderNo + "' AND catagory='" + cmbCat.Text + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");
                          
                      }

                      else
                      {
                          MessageBox.Show("Choose Correct Format...!!", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                      }

                  }

                  if (rBPrevDate.Checked)
                  {
                      DateTime ss = Convert.ToDateTime(dTPTransDate.Text);
                      string strYesterday = ss.AddDays(-1).ToString("dd-MMM-yyyy");
                      DateTime yesterday = Convert.ToDateTime(strYesterday);

                      DateTime strOrderDate = Convert.ToDateTime(dTPTransDate.Text);

                      if (frmSubroute == subRoute && toSubroute == subRoute && cmbFrmRoute.Text != "---- Select ----" && cmbToRoute.Text != "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + yesterday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + frmSubroute + "' and '" + toSubroute + "' ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + yesterday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + frmSubroute + "' and '" + toSubroute + "' AND catagory='" + cmbCat.Text + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");

                      }
                      else if (cmbFrmSRoute.Text != "---- Select ----" && cmbToSRoute.Text != "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + yesterday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + HttpUtility.HtmlDecode(ddlFrmSubRoute.SelectedItem.Text.Trim()) + "' and '" + HttpUtility.HtmlDecode(ddlToSubRoute.SelectedItem.Text.Trim()) + "' ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + yesterday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + cmbFrmSRoute.Text.Trim() + "' and '" + cmbToSRoute.Text.Trim() + "' AND catagory='" + cmbCat.Text + "' ";
                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");

                          
                      }

                      else if (cmbFrmSRoute.Text == "---- Select ----" && cmbToSRoute.Text == "---- Select ----" && cmbFrmRoute.Text == "---- Select ----" && cmbToRoute.Text == "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + yesterday + "' AND orderNo = '" + oeOrderNo + "'  ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + yesterday + "' AND orderNo = '" + oeOrderNo + "' AND catagory='" + cmbCat.Text + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");
                      }

                      else
                      {
                          MessageBox.Show("Choose Correct Format...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      }
                  }

                  if (rBSameDay.Checked)
                  {
                      DateTime ss = Convert.ToDateTime(dTPTransDate.Text);
                      string strSameday = ss.AddDays(-7).ToString("dd/MM/yyyy");
                      DateTime sameday = Convert.ToDateTime(strSameday);

                      DateTime strOrderDate = Convert.ToDateTime(dTPTransDate.Text);

                      if (frmSubroute == subRoute && toSubroute == subRoute && cmbFrmRoute.Text != "---- Select ----" && cmbToRoute.Text != "---- Select ----")
                      {
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + sameday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + frmSubroute + "' and '" + toSubroute + "' AND catagory='" + cmbCat.Text + "' ";
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + sameday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + frmSubroute + "' and '" + toSubroute + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");
                          
                      }
                      else if (cmbFrmSRoute.Text != "---- Select ----" && cmbToSRoute.Text != "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + sameday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + HttpUtility.HtmlDecode(ddlFrmSubRoute.SelectedItem.Text.Trim()) + "' and '" + HttpUtility.HtmlDecode(ddlToSubRoute.SelectedItem.Text.Trim()) + "' ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + sameday + "' AND orderNo = '" + oeOrderNo + "' AND subRoute between '" + cmbFrmSRoute.Text.Trim() + "' and '" + cmbToSRoute.Text.Trim() + "' AND catagory='" + cmbCat.Text + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");
                          
                      }

                      else if (cmbFrmSRoute.Text == "---- Select ----" && cmbToSRoute.Text == "---- Select ----" && cmbFrmRoute.Text == "---- Select ----" && cmbToRoute.Text == "---- Select ----")
                      {
                          //string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + auditUser + "' as auditUser, '" + createDate + "' as createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity from orderEntry where orderDate = '" + sameday + "' AND orderNo = '" + oeOrderNo + "'  ";
                          string insertQuery = "insert into orderEntry(orderNo,orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity,bonusCopy,complementaryCopy,packetType,modifyReason,auditUser,createDate,edition,postStatus,syncFlag,daywiseDefQuanttity,daywiseChngQuantity,smsQuantity) select '" + intorderNo + "' as orderNo, '" + strOrderDate + "' as orderDate,vehicle,subRoute,customerId,catagory,rate,salesType,type,corporate,stationName,quantity+daywiseDefQuanttity+daywiseChngQuantity+smsQuantity,bonusCopy,complementaryCopy,packetType,modifyReason, '" + UserName + "' as auditUser, '" + createDate + "' as createDate,edition,0,0,0,0,0 from CopyOrder where orderDate = '" + sameday + "' AND orderNo = '" + oeOrderNo + "'  AND catagory='" + cmbCat.Text + "' ";

                          SqlDataAdapter da = new SqlDataAdapter();
                          ds = dp.getDataSet(insertQuery, "CopyOrder");

                      }

                      else
                      {
                          MessageBox.Show("Choose Correct Format...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      }
                  }

                  string strcountTargetDate = "SELECT  count(*) from CopyOrder where orderDate = '" + dTPTransDate.Text + "' AND catagory='" + cmbCat.Text + "' ";
                  int countTargetDate = Convert.ToInt32(dp.getResultString(strcountTargetDate));



                  string strcountData = "SELECT  count(*) from CopyOrder where orderDate = '" + dTPSpcDate.Text + "' AND catagory='" + cmbCat.Text + "' ";
                  int countDataFromDate = Convert.ToInt32(dp.getResultString(strcountData));

                  if (countTargetDate == countDataFromDate)
                  {
                      MessageBox.Show("Data Has Copied Successfully ","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                      break;
                  }


              }

              sdr.Close();

              string selOrder = "Select count(*) from CorporateOrder where orderDate='" + dTPTransDate.Text + "' ";
              int rowNumber = Convert.ToInt32(dp.getResultString(selOrder));


              if (rowNumber == 0 && cmbCat.Text == "Daily Newspaper")
              {
                  CorporateCopy();
              }
              confirmation();

          }

      }
      private void CorporateCopy()
      {
          DateTime strOrderDate = Convert.ToDateTime(dTPTransDate.Text);
          
          if (rBSpcDate.Checked)
          {
              FrmDate = Convert.ToDateTime(dTPSpcDate.Text);
          }
          if (rBPrevDate.Checked)
          {
              DateTime ss = Convert.ToDateTime(dTPTransDate.Text);
              string strYesterday = ss.AddDays(-1).ToString("dd-MMM-yyyy");
               FrmDate = Convert.ToDateTime(strYesterday);
          }
          if (rBSameDay.Checked)
          {
              DateTime ss = Convert.ToDateTime(dTPTransDate.Text);
              string strSameday = ss.AddDays(-7).ToString("dd/MM/yyyy");
              FrmDate = Convert.ToDateTime(strSameday);
          }

          string sqlCorp = "INSERT INTO CorporateOrder  SELECT [customerId],[stationName],[cprCustomer],[category] ,[Quantity],'" + strOrderDate + "','" + DateTime.Now + "','" + UserName + "',[status],Region FROM [CorporateOrder] Where orderDate='" + FrmDate + "'";
          dp.ExecuteCommand(sqlCorp);


      }

      private void confirmation()
      {
          string defaultQuantity = "Select count(*) as defQ from orderEntry where orderdate='" + dTPSpcDate.Text + "' AND catagory='" + cmbCat.Text + "'";
          string defQuan = dp.getResultString(defaultQuantity);

          string CopiedQuantity = "Select count(*) as defQ from orderEntry where orderdate='" + dTPTransDate.Text + "' AND catagory='" + cmbCat.Text + "'";
          string CopiedQuan = dp.getResultString(CopiedQuantity);


          lblConfirm.Text = "Copied Order : " + CopiedQuan + " Out Of  " + defQuan;
      }
    }
}
