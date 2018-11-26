using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TreeNode = System.Windows.Forms.TreeNode;
using TreeNodeCollection = System.Windows.Forms.TreeNodeCollection;

namespace Circulation02.Forms
{
    public partial class frmGrpAuth : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private DataProvider dp = new DataProvider();

        public string UserName { get; set; }
        
        public frmGrpAuth()
        {
            InitializeComponent();

        }



        private void frmGrpAuth_Load(object sender, EventArgs e)
        {
            BindcmbGrpName();
            
            TreeView();
        
        }

       

        private void BindcmbGrpName()
        {
            cmbGrpName.Items.Clear();
            txtGrpDesc.Clear();
            string strSql = "SELECT  groupName from userGroup where delStatus<>1 Order By groupName ASC ";

           dt = dp.getDataTable(strSql, "userGroup");

            cmbGrpName.Text = "--- Select Group ---";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbGrpName.Items.Add(dt.Rows[i]["groupName"]);

            }



        }

        private void TreeView()
        {
            tVGrpAuth.Nodes.Clear();
            string selFunctionName = "select distinct functionName,functionId from groupFunction order by functionId";
            SqlDataReader sdr = dp.getDataReader(selFunctionName);
        

            while (sdr.Read())
            {
                TreeNode root = new TreeNode(sdr["functionName"].ToString());
                tVGrpAuth.ExpandAll();
                tVGrpAuth.Nodes.Add(root);

                string funcName = (string) sdr["functionName"];
                string sqlBtnName = "select button from groupFunction where functionName='" + funcName + "' order by btnId";
                dt = dp.getDataTable(sqlBtnName,"groupFunction");
                
                foreach (DataRow row in dt.Rows)
                {
                    if (row["button"].ToString()!= "N/A")
                    {
                        TreeNode childNode = new TreeNode(row["button"].ToString());
                        root.Nodes.Add(childNode);
               
                    }
                    
                }
                

            }

             sdr.Close();
        }


   

        private void cmbGrpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFncName = "";
            int j = 0;
            int intFncId = 0;

            foreach (TreeNode n in tVGrpAuth.Nodes)
            {
                n.Checked = false;
                foreach (TreeNode c in n.Nodes)
                {
                    c.Checked = false;
                }
               
            }
            

            string selGroupDesc = "SELECT groupDescription from userGroup where  groupName='" + cmbGrpName.Text + "'";
            this.txtGrpDesc.Text = dp.getResultString(selGroupDesc);

            string selGroupId = "SELECT groupId from userGroup where delStatus<>1 AND groupName='" + cmbGrpName.Text +
                                "'";
            int groupId = Convert.ToInt32(dp.getResultString(selGroupId));

            string selFunctionName = "SELECT distinct functionId FROM GropuPermission where groupId='" + groupId + "' order by functionId";
            SqlDataReader sdr = dp.getDataReader(selFunctionName);


            while (sdr.Read())
            {
                
                intFncId = Convert.ToInt32(sdr["functionId"]);

                string selFunName = "SELECT distinct functionName FROM groupFunction where functionId='" + intFncId + "'";
                strFncName = dp.getResultString(selFunName);

                int i = j;
                //for (i = j; i < this.chkListForm.Items.Count; i++)
                foreach (TreeNode rNode in tVGrpAuth.Nodes)
                {
                    
                    if (rNode.Text== strFncName)
                    {
                        rNode.Checked=true;

                        string sqlbtnId = "select btnId from GropuPermission where functionId='" + intFncId + "' and groupId='" + groupId + "' and btnId<> 0 ";
                        SqlDataReader sdrBtnId = dp.getDataReader(sqlbtnId);

                   
                        while (sdrBtnId.Read())
                        {
                            string sqlBtnName = "select button from groupFunction where functionId='" + intFncId + "' and btnId='" + sdrBtnId["btnId"].ToString() + "'";
                            string btnName  = Convert.ToString(dp.getResultString(sqlBtnName));
                            //string bName = btnSdr["button"].ToString();

                            if (btnName != "N/A")
                            {
                                foreach (TreeNode cNode in rNode.Nodes)
                                {
                                    if (cNode.Text == btnName)
                                    {
                                        cNode.Checked = true;
                                        break;
                                    }
                                }
                            }
                            
                            
                        }
                        sdrBtnId.Close();
                        break;
                        
                    }
                    
                    
                }
            }

            sdr.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool chkPermission = false;

            //for (int i = 0; i < chkListForm.Items.Count; i++)
            foreach (TreeNode pN in tVGrpAuth.Nodes)
          
            {
                string selGroupId = "SELECT groupId from userGroup where delStatus<>1 AND groupName='" +
                                cmbGrpName.Text + "'";
                int groupId = Convert.ToInt32(dp.getResultString(selGroupId));

                string selFunction = "SELECT functionId from groupFunction where functionName='" +
                                         pN.Text + "'";
                int functionId = Convert.ToInt32(dp.getResultString(selFunction));

                 if (pN.Checked == true)
                
                 {  string countRow = "Select count(*) from GropuPermission where groupId='" + groupId + "' ";
                     int rowNumber = Convert.ToInt32(dp.getResultString(countRow));


                     if (rowNumber == 0)
                     {
                         try
                         {
                             string cmd = "EXEC Insert_GroupAuthorization '"
                                          + groupId + "','"
                                          + functionId + "', '','"
                                          + DateTime.Now + "','" + UserName + "'";

                             dp.ExecuteCommand(cmd);
                             chkPermission = true;

                         }

                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message);

                         }

                     }

                     else
                     {
                         if (chkPermission == false)
                         {

                             try
                             {
                                 string cmd = "EXEC Update_GroupAuthorization '"
                                              + groupId + "'";

                                 dp.ExecuteCommand(cmd);

                                 chkPermission = true;
                             }
                             catch (Exception ex)
                             {

                                 MessageBox.Show(ex.Message);

                             }
                         }

                         try
                         {
                             string cmd = "EXEC Insert_GroupAuthorization '"
                                          + groupId + "','"
                                          + functionId + "','','"
                                          + DateTime.Now + "','" + UserName + "'";

                             dp.ExecuteCommand(cmd);

                         }

                         catch (Exception ex)
                         {
                             MessageBox.Show(ex.Message);

                         }


                     }

                     foreach (TreeNode cN in pN.Nodes)
                     {
                         if (cN.Checked==true)
                         {
                             string sqlBtnId = "SELECT btnId from groupFunction where functionId='" + functionId + "' and  button='" +
                                                  cN.Text + "'";
                             int btnId = Convert.ToInt32(dp.getResultString(sqlBtnId));

                             try
                             {
                                 string cmd = "EXEC Insert_GroupAuthorization '"
                                              + groupId + "','"
                                              + functionId + "','"
                                              + btnId + "', '"
                                              + DateTime.Now + "','" + UserName + "'";

                                 dp.ExecuteCommand(cmd);

                             }

                             catch (Exception ex)
                             {
                                 MessageBox.Show(ex.Message);

                             }
                             
                         }
                         
                     }
                   
                }

                 if (pN.Checked == false)
                 {
                     string cmd = "delete gropuPermission where groupId='" + groupId + "' and functionId='" + functionId +"'";
                     dp.ExecuteCommand(cmd);
                 }
            }

            MessageBox.Show("Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Reset The Group ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string strSql = "select groupId from userGroup where groupName='" + cmbGrpName.Text + "'";
                int grpId = Convert.ToInt32(dp.getResultString(strSql));

                string cmd = "EXEC Update_GroupAuthorization '" + grpId + "'";
                dp.ExecuteCommand(cmd);

                foreach (TreeNode n in tVGrpAuth.Nodes)
                {
                    n.Checked = false;
                    foreach (TreeNode c in n.Nodes)
                    {
                        c.Checked = false;
                    }
                 }
            

                MessageBox.Show("Reset Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return;

        }

       
    }
}
