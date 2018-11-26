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
    public partial class frmEmpHierarchy : Form
    {
        DataProvider dp = new DataProvider();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public string UserName { get; set; }
        public frmEmpHierarchy()
        {
            InitializeComponent();
        }

        private void frmEmpHierarchy_Load(object sender, EventArgs e)
        {
            BindGM();
        }

        private void BindGM()
        {
            dt.Clear();
            dt.Rows.Clear();
            var con = Properties.Settings.Default.ALOCIRConnectionString;
            string selGM = "SELECT gmName,auditUser,createDate from generalManager where delStatus<>1";
            SqlDataAdapter sda=new SqlDataAdapter(selGM,con);
            sda.Fill(dt);
            gVGM.DataSource = dt;
            
        }

        private void BindCmbGM()
        {
            string query = "SELECT  gmName from generalManager where delStatus<>1 Order By gmName ASC ";
            ds = dp.getDataSet(query, "gmName");
            cmbGM.DisplayMember = "gmName";
            cmbGM.DataSource = ds.Tables[0];
            cmbGM.Text= "---- Select ----";

        }

        private void BindCmbGMRM()
        {
            string query = "SELECT  gmName from generalManager where delStatus<>1 Order By gmName ASC ";
            ds = dp.getDataSet(query, "gmName");
            cmbGMRM.DisplayMember = "gmName";
            cmbGMRM.DataSource = ds.Tables[0];
            cmbGMRM.Text = "---- Select ----";

        }

        private void BindCmbManager()
        {
            string query = "SELECT  managerName from manager where delStatus<>1 Order By gmName ASC ";
            ds = dp.getDataSet(query, "managerName");
            cmbManager.DisplayMember = "managerName";
            cmbManager.DataSource = ds.Tables[0];
            cmbManager.Text = "---- Select ----";

        }

        private void BindGrdManager()
        {
            DataTable dts=new DataTable();
            dts.Clear();
            var con = Properties.Settings.Default.ALOCIRConnectionString;
            string sqlManager = " select gmName,managerName,createDate from manager where delStatus<>1";
            SqlDataAdapter sda = new SqlDataAdapter(sqlManager, con);
            sda.Fill(dts);
            gVManager.DataSource = dts;
            
        }

        private void BindGrdRM()
        {
            DataTable dts1 = new DataTable();
            dts1.Clear();
            var con = Properties.Settings.Default.ALOCIRConnectionString;
            string sqlRM = " SELECT gmName,managerName,rmName,createDate from regionalManager where delStatus<>1";
            SqlDataAdapter sda = new SqlDataAdapter(sqlRM, con);
            sda.Fill(dts1);
            gVRM.DataSource = dts1;

        }
        private void btnSaveGM_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from generalManager where delStatus<>1 AND gmName='" + txtGM.Text.Replace("''","'") + "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

          
                if (rowNumber == 0)
                {
                   try
                    {
                        string cmd = "EXEC Insert_gm '" + txtGM.Text.Replace("''","'") + "' ,'"
                                     + UserName + "' ,'"
                                     + DateTime.Now + "' ";

                             dp.ExecuteCommand(cmd);
                             MessageBox.Show("Name added successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else
                {
                    MessageBox.Show("Name already exists, try another name","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                }

            BindGM();
            }

        private void tCEmpHier_Click(object sender, EventArgs e)
        {
            if (tCEmpHier.SelectedIndex==0)
            {
                BindGM();
            }
            if (tCEmpHier.SelectedIndex==1)
            {
                BindCmbGM();
                BindGrdManager();
            }
            if (tCEmpHier.SelectedIndex==2)
            {
                BindCmbGMRM();
                BindCmbManager();
                BindGrdRM();
            }
        }

        private void btnSaveManager_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from manager where delStatus<>1 AND managerName='" + txtManager.Text + "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

          
            
               if (rowNumber == 0)
                {
                    string cmd = "EXEC Insert_manager '" + cmbGM.Text.Replace("''","'") + "' ,'"
                                          + txtManager.Text.Replace("''","'") + "' ,'"
                                          + UserName + "' ,'"
                                          + DateTime.Now + "' ";

                    dp.ExecuteCommand(cmd);
                   MessageBox.Show("Name added successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   MessageBox.Show("Name already exists, try another name","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                  
                }

            BindGrdManager();
            }

        private void btnRM_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from regionalManager where delStatus<>1 AND rmName='" + txtRM.Text.Replace("''","'") + "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (rowNumber == 0)
                {
                     string cmd = "EXEC Insert_rm '" + cmbGMRM.Text.Replace("''","'") + "' ,'"
                                     + cmbManager.Text + "' ,'"
                                     + txtRM.Text + "' ,'"
                                     + UserName+ "' ,'"
                                     + DateTime.Now + "' ";

                     dp.ExecuteCommand(cmd);
                 MessageBox.Show("Name added successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Name already exists, try another name","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                }
            BindGrdRM();
            }

            

            
        }

        
       

            
        }

          

