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
using Circulation02.Forms;

namespace Circulation02
{
    public partial class frmHome : Form
    {
        DataProvider dp= new DataProvider();
        public string UserName { get; set; }
        frmUser User = new frmUser();
        frmUserGroup userGroup = new frmUserGroup();
        frmUserAuth userAuth = new frmUserAuth();
        frmGrpAuth grpAuth = new frmGrpAuth();
        frmSalesArea salesArea = new frmSalesArea();
        public frmHome()
        {
            
            InitializeComponent();

        }

        //private void RemoveNodeRecurrently (TreeNodeCollection childNodeCollection, string text)
        //{
        //    foreach (TreeNode childNode in childNodeCollection)
        //    {
        //        //if (childNode.Nodes.Count > 0)
        //          //  RemoveNodeRecurrently(childNode.Nodes, text);

        //        if (childNode.Name == "NodeCDMS")
        //        {
        //            TreeNode parentNode = childNode.Parent;
        //            parentNode.Nodes.Remove();
        //            break;
        //        }
        //    }
        //}

       
        private void CustomizePermission()
        {
            
            string funcName = "";

            string strSql = "Select distinct functionName from View_PermissionCustomize where userName='" + UserName + "'";
            SqlDataReader sdr = dp.getDataReader(strSql);

           
            while (sdr.Read())
            {
                string fn = sdr["functionName"].ToString();

                if (sdr["functionName"].ToString() == "FORM_createUser")
                {
                    string sqlbtnName = "Select button from View_PermissionCustomize where userName='" + UserName + "' and functionName='"+ sdr["functionName"].ToString()+"'";
                    SqlDataReader sdrBtnName = dp.getDataReader(sqlbtnName);
                    while (sdrBtnName.Read())
                    {
                        foreach (var btn in User.groupBox3.Controls.OfType<Button>())
                        {
                            string bname = sdrBtnName["button"].ToString();
                            string btnName = btn.Text;

                            if (bname == btnName)
                            {
                                btn.Visible = true;
                                break;
                           }
                          
                        }
                   
                    }
                    
                }
                if (sdr["functionName"].ToString() == "FORM_userGroup")
                {
                    string sqlbtnName = "Select button from View_PermissionCustomize where userName='" + UserName + "' and functionName='" + sdr["functionName"].ToString() + "'";
                    SqlDataReader sdrBtnName = dp.getDataReader(sqlbtnName);
                    while (sdrBtnName.Read())
                    {
                        foreach (var btn in userGroup.groupBox3.Controls.OfType<Button>())
                        {
                            string bname = sdrBtnName["button"].ToString();
                            string btnName = btn.Text;

                            if (bname == btnName)
                            {
                                btn.Visible = true;
                                break;
                            }


                        }

                    }

                }
                if (sdr["functionName"].ToString() == "FORM_userAuthorization")
                {
                    string sqlbtnName = "Select button from View_PermissionCustomize where userName='" + UserName + "' and functionName='" + sdr["functionName"].ToString() + "'";
                    SqlDataReader sdrBtnName = dp.getDataReader(sqlbtnName);
                    while (sdrBtnName.Read())
                    {
                        foreach (var btn in userAuth.groupBox3.Controls.OfType<Button>())
                        {
                            string bname = sdrBtnName["button"].ToString();
                            string btnName = btn.Text;

                            if (bname == btnName)
                            {
                                btn.Visible = true;
                                break;
                            }


                        }

                    }

                }

                if (sdr["functionName"].ToString() == "FORM_groupAuthorization")
                {
                    string sqlbtnName = "Select button from View_PermissionCustomize where userName='" + UserName + "' and functionName='" + sdr["functionName"].ToString() + "'";
                    SqlDataReader sdrBtnName = dp.getDataReader(sqlbtnName);
                    while (sdrBtnName.Read())
                    {
                        foreach (var btn in grpAuth.groupBox3.Controls.OfType<Button>())
                        {
                            string bname = sdrBtnName["button"].ToString();
                            string btnName = btn.Text;

                            if (bname == btnName)
                            {
                                btn.Visible = true;
                                break;
                            }


                        }

                    }

                }
                
            }

            sdr.Close();
        
        }

        
        private  void treeViewMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Text == "User")
            {
                User.Owner = this;
                User.UserName = UserName;
                User.ShowDialog();
                

            }

            if (e.Node.Text == "User Group")
            {
                
                userGroup.Owner = this;
                userGroup.UserName = UserName;
                userGroup.ShowDialog();
                

            }

            if (e.Node.Text == "Group Authorization")
            {
            
                grpAuth.Owner = this;
                grpAuth.UserName = UserName;
                grpAuth.ShowDialog();
            }

            if (e.Node.Text == "User Authorization")
            {
               
                userAuth.Owner = this;
                userAuth.UserName = UserName;
                userAuth.ShowDialog();
            }

            if (e.Node.Text == "Agent Information")
            {
                frmAgentInfo agentInfo = new frmAgentInfo();
                agentInfo.UserName = UserName;
                agentInfo.Owner = this;
                agentInfo.ShowDialog();

            }

            if (e.Node.Text == "Employee Hierarchy")
            {
                frmEmpHierarchy empHierarchy = new frmEmpHierarchy();
                empHierarchy.UserName = UserName;
                empHierarchy.Owner = this;
                empHierarchy.ShowDialog();

            }

            if (e.Node.Text == "Sales Area")
            {
                salesArea.UserName = UserName;
                salesArea.Owner = this;
                salesArea.ShowDialog();
            }

            if (e.Node.Text == "Weekly Rate Setup")
            {
                frmRateSetup rateSetup = new frmRateSetup();
                rateSetup.Owner = this;
                rateSetup.ShowDialog();

            }
            if (e.Node.Text == "Reason Of Unsold")
            {
                frmROU rou = new frmROU();
                rou.UserName = UserName;
                rou.Owner = this;
                rou.ShowDialog();

            }

            if (e.Node.Text == "CTP Setup")
            {
                frmCTPSetup ctpSetup = new frmCTPSetup();
                ctpSetup.UserName = UserName;
                ctpSetup.Owner = this;
                ctpSetup.ShowDialog();
            }

            if (e.Node.Text == "Page Setup")
            {
                frmPageSetup pageSetup = new frmPageSetup();
                pageSetup.UserName = UserName;
                pageSetup.Owner = this;
                pageSetup.ShowDialog();
            }

            if (e.Node.Text == "Category Setup")
            {
                frmCategorySetup categorySetup = new frmCategorySetup();
                categorySetup.UserName = UserName;
                categorySetup.Owner = this;
                categorySetup.ShowDialog();
            }

            if (e.Node.Text == "Region")
            {
                frmRegion region = new frmRegion();
                region.UserName = UserName;
                region.Owner = this;
                region.ShowDialog();
            }

            if (e.Node.Text == "Population")
            {
                frmPopulation population = new frmPopulation();
                population.UserName = UserName;
                population.Owner = this;
                population.ShowDialog();
            }

            if (e.Node.Text == "Route")
            {
                frmRoute route = new frmRoute();
                route.Owner = this;
                route.ShowDialog();
            }

            if (e.Node.Text == "Sub-Route")
            {
                frmSubRoute subRoute = new frmSubRoute();
                subRoute.Owner = this;
                subRoute.ShowDialog();
            }

            if (e.Node.Text == "Vehicle")
            {
                frmVehicleInfo vehicleInfo = new frmVehicleInfo();
                vehicleInfo.Owner = this;
                vehicleInfo.ShowDialog();
            }

            if (e.Node.Text == "Transport Maintenance")
            {
                frmTransportMaintenance transportMaintenance = new frmTransportMaintenance();
                transportMaintenance.Owner = this;
                transportMaintenance.ShowDialog();
            }

            if (e.Node.Text == "Order Entry")
            {
                frmOrdEntry ordEntry = new frmOrdEntry();
                ordEntry.UserName = UserName;
                ordEntry.Owner = this;
                ordEntry.ShowDialog();
            }

            if (e.Node.Text == "Copy Order")
            {
                frmCopyOrd copyOrd = new frmCopyOrd();
                copyOrd.Owner = this;
                copyOrd.ShowDialog();
            }

            if (e.Node.Text == "Modify Order")
            {
                frmModifyOrd modifyOrd = new frmModifyOrd();
                modifyOrd.Owner = this;
                modifyOrd.ShowDialog();
            }

            if (e.Node.Text == "Return Entry")
            {
                frmRtnEntry rtnEntry = new frmRtnEntry();
                rtnEntry.Owner = this;
                rtnEntry.ShowDialog();
            }

            if (e.Node.Text == "Regular Modify")
            {
                frmRegularMod regularMod = new frmRegularMod();
                regularMod.Owner = this;
                regularMod.ShowDialog();
            }

            if (e.Node.Text == "Challan Modify")
            {
                frmChallanMod challanMod = new frmChallanMod();
                challanMod.Owner = this;
                challanMod.ShowDialog();
            }

            if (e.Node.Text == "Order Synchronize")
            {
                frmOrdSync ordSync = new frmOrdSync();
                ordSync.Owner = this;
                ordSync.ShowDialog();
            }
            if (e.Node.Text == "Corporate Order")
            {
                frmCrpOrd crpOrd = new frmCrpOrd();
                crpOrd.UserName = UserName;
                crpOrd.Owner = this;
                crpOrd.ShowDialog();
            }

            if (e.Node.Text == "Rate Change")
            {
                frmRateChange rateChange = new frmRateChange();
                rateChange.Owner = this;
                rateChange.ShowDialog();
            }

            if (e.Node.Text == "Yearly")
            {
                frmYearly yearly = new frmYearly();
                yearly.Owner = this;
                yearly.ShowDialog();
            }

            if (e.Node.Text == "Monthly")
            {
                frmMonthly monthly = new frmMonthly();
                monthly.Owner = this;
                monthly.ShowDialog();
            }

            if (e.Node.Text == "Quarterly")
            {
                frmQuarterly quarterly = new frmQuarterly();
                quarterly.Owner = this;
                quarterly.ShowDialog();
            }

            if (e.Node.Text == "Competitor Name")
            {
                frmCompetitorName competitorName = new frmCompetitorName();
                competitorName.Owner = this;
                competitorName.ShowDialog();
            }

            if (e.Node.Text == "Competitor Sales")
            {
                frmCompetitorSales competitosSales = new frmCompetitorSales();
                competitosSales.Owner = this;
                competitosSales.ShowDialog();
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            treeViewMain.Nodes[0].Expand();
            lblName.Text = UserName;
            CustomizePermission();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin login =new frmLogin();
            login.Show();
        }

        
    }
}