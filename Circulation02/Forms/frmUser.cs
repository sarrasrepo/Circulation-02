using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Circulation02.Forms
{
    public partial class frmUser : Form
    {
        
        DataTable dt= new DataTable();
        DataProvider dp=new DataProvider();
        frmLogin login =new frmLogin();

        public string UserName { get; set; }
        


       
        public frmUser()

        {
            
            InitializeComponent();

            
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string desg = txtDesg.Text;
            string mob = txtMob.Text;
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            string rpass = txtRpass.Text;

            string getData = "";

            string qry = "select * from USERLIST where userName='" + txtUn.Text + "'";
            DataTable dt = dp.getDataTable(qry, "USERLIST");

            foreach (DataRow row in dt.Rows)
            {
                getData = row["userName"].ToString();
            }

            if (getData != "")
            {
                MessageBox.Show("User Already Exists.......!!");
                return ;
            }

            else
            {
                try
                {
                    if (txtPass.Text!=txtRpass.Text)
                    {
                        MessageBox.Show("Password Didn't Match! Please Re-type Password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtRpass.Focus();
                        return;
                    }
                    string strSql ="EXEC Insert_userList '"
                            + txtFn.Text + "','"
                            + txtDesg.Text+ "','','"
                            + txtMob.Text + "','"
                            + txtEmail.Text + "','"
                            + txtUn.Text + "','"
                            + txtPass.Text + "','"+ DateTime.Now +"','"+UserName+"'";

                    dp.ExecuteCommand(strSql);

                    MessageBox.Show("User Inserted Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    foreach (Control c in gbUsrInfo.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                        {
                            ((TextBox)(c)).Text = string.Empty;
                        }
                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        

        

      

        private void btnLast_Click(object sender, EventArgs e)
        {
            
            string qry = "select * from userList where userId=(select max(userId) from userList)";
            dt = dp.getDataTable(qry, "USERLIST");

            foreach (DataRow row in dt.Rows)
            {
              
                txtUserId.Text = row["userId"].ToString();
                txtFn.Text = row["fullName"].ToString();
                txtDesg.Text = row["userDesignation"].ToString();
                txtMob.Text = row["userMobile"].ToString();
                txtEmail.Text = row["userEmail"].ToString();
                txtUn.Text = row["userName"].ToString();
                
            }

            return;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            string qry = "select * from userList where userId=(select min(userId) from userList)";
            dt = dp.getDataTable(qry, "USERLIST");

            foreach (DataRow row in dt.Rows)
            {

                txtUserId.Text = row["userId"].ToString();
                txtFn.Text = row["fullName"].ToString();
                txtDesg.Text = row["userDesignation"].ToString();
                txtMob.Text = row["userMobile"].ToString();
                txtEmail.Text = row["userEmail"].ToString();
                txtUn.Text = row["userName"].ToString();

            }

            return;
        }

        private void btnNext_Click(object sender, EventArgs e)
        { 
            if (txtUserId.Text == "")
            {
                string qry = "select * from USERLIST where delstatus <> 1 AND userid = (select MAX(userid) from USERLIST where delstatus <> 1)";
                dt = dp.getDataTable(qry, "USERLIST");
            }
            else
            {
                int userId = Convert.ToInt32(txtUserId.Text);
                string qry = "select top 1 * from USERLIST where delstatus <> 1 AND userid >'" + userId+ "' ";
                dt = dp.getDataTable(qry, "USERLIST");
                
            }

            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["userId"].ToString();
                txtFn.Text = row["fullName"].ToString();
                txtDesg.Text = row["userDesignation"].ToString();
                txtMob.Text = row["userMobile"].ToString();
                txtEmail.Text = row["userEmail"].ToString();
                txtUn.Text = row["userName"].ToString();

            }
            return;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                string qry = "select * from USERLIST where delstatus <> 1 AND userid = (select min(userid) from USERLIST where delstatus <> 1)";
                dt = dp.getDataTable(qry, "USERLIST");
            }
            else
            {
                int userId = Convert.ToInt32(txtUserId.Text);
                string qry = "select top 1 * from USERLIST where delstatus <> 1 AND userid <'" + userId + "' order by userId desc ";
                dt = dp.getDataTable(qry, "USERLIST");
            }

            foreach (DataRow row in dt.Rows)
            {
                txtUserId.Text = row["userId"].ToString();
                txtFn.Text = row["fullName"].ToString();
                txtDesg.Text = row["userDesignation"].ToString();
                txtMob.Text = row["userMobile"].ToString();
                txtEmail.Text = row["userEmail"].ToString();
                txtUn.Text = row["userName"].ToString();

            }
            return;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gbUsrInfo.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            gbUserTop.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to Update ???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.Yes)
                {
                    string strsql = "update userlist set fullName='" + txtFn.Text + "', userDesignation='" +
                                    txtDesg.Text + "', userMobile='" + txtMob.Text + "', userEmail='" + txtEmail.Text +
                                    "', userPassword='" + txtPass.Text + "', createDate='" + DateTime.Now +
                                    "' where userId='" + txtUserId.Text + "'";
                    dp.ExecuteCommand(strsql);

                    MessageBox.Show("User Updated Successfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Do you really want to Delete ???","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            try
            {
                if (result==DialogResult.Yes)
                {
                    string strsql = "delete userlist where userId='" + txtUserId.Text + "'";
                    dp.ExecuteCommand(strsql);
                    MessageBox.Show("User Deleted Successfully");

                    gbUsrInfo.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    gbUserTop.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnUsrFinder_Click(object sender, EventArgs e)
        {
            frmUserFinder userFinder=new frmUserFinder();
            userFinder.Owner=this;
            userFinder.Show();
        }

      
        

        
    }
}
