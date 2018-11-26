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
    public partial class frmUserAuth : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        public string UserName { get; set; }
        public frmUserAuth()
        {
            InitializeComponent();
        }
        private void frmUserAuth_Load(object sender, EventArgs e)
        {
            BindcmbBox();
        }
        private void BindcmbBox()
        {
            string strSql = "SELECT  userName from userList where delStatus<>1 Order By userName ASC ";

            dt = dp.getDataTable(strSql, "userList");
            cmbUserName.Text = "--- Select---";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbUserName.Items.Add(dt.Rows[i]["userName"]);

            }
            string sqlGrpName = "SELECT  groupName from userGroup where delStatus<>1 Order By groupName ASC ";

            dt = dp.getDataTable(sqlGrpName, "userGroup");
            cmbGrpName.Text = "--- Select ---";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbGrpName.Items.Add(dt.Rows[i]["groupName"]);

            }



        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            string strSql = "select * from userList where userId=(select max(userId) from userList where delStatus<>1)";
            dt = dp.getDataTable(strSql, "userList");

            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["userId"].ToString();
                cmbUserName.Text = row["userName"].ToString();
                
            }

            string sqlGrpName = "select groupName, groupDescription from userGroup where groupId=(select groupId from userList where userName='"+cmbUserName.Text+"')";
            dt = dp.getDataTable(sqlGrpName, "userGroup");

            foreach (DataRow row in dt.Rows)
            {
                cmbGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();
                
                
            }

            return;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            string strSql = "select * from userList where userId=(select min(userId) from userList where delStatus<>1)";
            dt = dp.getDataTable(strSql, "userList");

            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["userId"].ToString();
                cmbUserName.Text = row["userName"].ToString();

            }

            string sqlGrpName = "select groupName, groupDescription from userGroup where groupId in (select groupId from userList where userName='" + cmbUserName.Text + "')";
            dt = dp.getDataTable(sqlGrpName, "userGroup");

            foreach (DataRow row in dt.Rows)
            {
                cmbGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();


            }

            return;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cmbGrpName.Text = "--- Select ---";
            txtGrpDesc.ResetText();
            
            if (txtUserId.Text=="")
            {
                string strSql = "select * from userList where userId=(select max(userId) from userList where delStatus<>1)";
                dt = dp.getDataTable(strSql, "userList");
            }
            else
            {
                int userId = Convert.ToInt32(txtUserId.Text);
                string strSql = "select top 1 * from userList where userId >'"+userId+"' order by userId";
                //int row = Convert.ToInt32(dp.getResultString(strSql));

                dt = dp.getDataTable(strSql, "userList");
                
            }

            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["userId"].ToString();
                cmbUserName.Text = row["userName"].ToString();

            }

            string sqlGrpName = "select groupName, groupDescription from userGroup where delstatus<>1 and groupId in (select groupId from userList where userName='" + cmbUserName.Text + "' and delstatus<>1)";
            dt = dp.getDataTable(sqlGrpName, "userGroup");

            foreach (DataRow row in dt.Rows)
            {
                 cmbGrpName.Text = row ["groupName"].ToString();
                 txtGrpDesc.Text = row ["groupDescription"].ToString();
            
            }
            
            return;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            cmbGrpName.Text = "--- Select ---";
            txtGrpDesc.ResetText();
            if (txtUserId.Text == "")
            {
                string strSql = "select * from userList where userId=(select min(userId) from userList where delStatus<>1)";
                dt = dp.getDataTable(strSql, "userList");
            }
            else
            {
                int userId = Convert.ToInt32(txtUserId.Text);
                string strSql = "select top 1 * from userList where userId <'" + userId  + "' order by userId DESC";
                dt = dp.getDataTable(strSql, "userList");

            }

            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["userId"].ToString();
                cmbUserName.Text = row["userName"].ToString();

            }

            string sqlGrpName = "select groupName, groupDescription from userGroup where groupId in (select groupId from userList where userName='" + cmbUserName.Text + "')";
            dt = dp.getDataTable(sqlGrpName, "userGroup");

            foreach (DataRow row in dt.Rows)
            {
                cmbGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();


            }

            return;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grpBoxHdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            grpBoxDtl.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            BindcmbBox();
        }

        private void cmbGrpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selGroupDesc = "SELECT groupDescription from userGroup where  groupName='" + cmbGrpName.Text + "'";
            this.txtGrpDesc.Text = dp.getResultString(selGroupDesc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT groupId from userList where userName='" + cmbUserName.Text.Replace("'", "''") + "' AND delStatus<>1";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (rowNumber > 0)
            {
                MessageBox.Show("Group Already Exists...!!");
                return;

            }

            else
            {
                try
                {
                    string sqlGrpId="select groupId from userGroup where groupName='"+cmbGrpName.Text+"' and delstatus<>1";
                    int grpId = Convert.ToInt32(dp.getResultString(sqlGrpId));
                    string sqlStr = "update userList set groupId='" + grpId + "', audUser='" + UserName + "' where userName='" + cmbUserName.Text + "'";
                    //string sqlStr = "EXEC Insert_UserGroup '"
                    //            + txtGrpName.Text.Replace("'", "''") + "','"
                    //            + txtGrpDesc.Text.Replace("'", "''") + "','" + DateTime.Now + "','shakib'";
                    dp.ExecuteCommand(sqlStr);
                    MessageBox.Show("Group For The User Added Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

            return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
                try
                {
                    string sqlGrpId="select groupId from userGroup where groupName='"+cmbGrpName.Text+"' and delstatus<>1";
                    int grpId = Convert.ToInt32(dp.getResultString(sqlGrpId));
                    string sqlStr = "update userList set groupId='"+grpId+"' where userName='"+cmbUserName.Text+"'";
                    //string sqlStr = "EXEC Insert_UserGroup '"
                    //            + txtGrpName.Text.Replace("'", "''") + "','"
                    //            + txtGrpDesc.Text.Replace("'", "''") + "','" + DateTime.Now + "','shakib'";
                    dp.ExecuteCommand(sqlStr);
                    MessageBox.Show("Group For The User Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlGrpId = "select groupId from userGroup where groupName='" + cmbGrpName.Text + "'";
                int grpId = Convert.ToInt32(dp.getResultString(sqlGrpId));
                string sqlStr = "update userList set groupId='0' where userName='" + cmbUserName.Text + "'";
                //string sqlStr = "EXEC Insert_UserGroup '"
                //            + txtGrpName.Text.Replace("'", "''") + "','"
                //            + txtGrpDesc.Text.Replace("'", "''") + "','" + DateTime.Now + "','shakib'";
                dp.ExecuteCommand(sqlStr);
                MessageBox.Show("Group For The User Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

       
        }
    }


