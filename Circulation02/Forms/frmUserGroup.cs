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
    public partial class frmUserGroup : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp= new DataProvider();
        public string UserName { get; set; }
        public frmUserGroup()
        {
            InitializeComponent();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

            string qry = "select * from userGroup where groupId=(select max(groupId) from userGroup where delStatus<>1)";
            dt = dp.getDataTable(qry, "userGroup");

            foreach (DataRow row in dt.Rows)
            {

                txtGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();
                txtGroupId.Text = row["groupId"].ToString();


            }

            return;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            string qry = "select * from userGroup where groupId=(select min(groupId) from userGroup)";
            dt = dp.getDataTable(qry, "userGroup");

            foreach (DataRow row in dt.Rows)
            {

                txtGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();
                txtGroupId.Text = row["groupId"].ToString();


            }

            return;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtGroupId.Text == "")
            {
                string qry = "select * from userGroup where groupId=(select max(groupId) from userGroup Where delStatus<>1)";
                dt = dp.getDataTable(qry, "userGroup");
            }
            else
            {
                int groupId = Convert.ToInt32(txtGroupId.Text);
                string qry = "select * from userGroup where  groupId ='" + (groupId + 1) + "' ";
                dt = dp.getDataTable(qry, "userGroup");
            }

            foreach (DataRow row in dt.Rows)
            {

                txtGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();
                txtGroupId.Text = row["groupId"].ToString();

            }
            return;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (txtGroupId.Text == "")
            {
                string qry = "select * from userGroup where groupId=(select min(groupId) from userGroup)";
                dt = dp.getDataTable(qry, "userGroup");
            }
            else
            {
                int groupId = Convert.ToInt32(txtGroupId.Text);
                string qry = "select * from userGroup where  groupId ='" + (groupId - 1) + "' ";
                dt = dp.getDataTable(qry, "userGroup");
            }

            foreach (DataRow row in dt.Rows)
            {

                txtGrpName.Text = row["groupName"].ToString();
                txtGrpDesc.Text = row["groupDescription"].ToString();
                txtGroupId.Text = row["groupId"].ToString();

            }
            return;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gbUserGrpHdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            gbUserGrpDtl.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from userGroup where groupName='" + txtGrpName.Text.Replace("'","''")+ "' AND delStatus<>1";
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
                    //string sqlStr = "INSERT INTO  userGroup (groupId,groupName, groupDescription,createDate,audUser,delStatus) VALUES ('"++"','"+txtGrpName.Text.Replace("'","''") + "','"+txtGrpDesc.Text.Replace("'","''") +"', '"+ DateTime.Now +"','shakib','0')";
                    string sqlStr = "EXEC Insert_UserGroup '"
                                + txtGrpName.Text.Replace ("'", "''") + "','"
                                + txtGrpDesc.Text.Replace("'", "''") + "','" + DateTime.Now + "','"+UserName+"'";
                    dp.ExecuteCommand(sqlStr);
                    MessageBox.Show("Group Created Successfully");
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
                string sqlStr = "EXEC Update_UserGroup '"
                                + txtGroupId.Text + "','"
                                + txtGrpName.Text.Replace("'", "''") + "','"
                                + txtGrpDesc.Text.Replace("'", "''") + "','"
                                + DateTime.Now + "','shakib'";

                dp.ExecuteCommand(sqlStr);

                MessageBox.Show("Group Updated Successfully");
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
               string strSql = "Delete UserGroup Where groupId = '" +txtGroupId.Text+ "'";
                dp.ExecuteCommand(strSql);
                MessageBox.Show("Group Deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            gbUserGrpHdr.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            gbUserGrpDtl.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());

         
        }

        
    }
}
