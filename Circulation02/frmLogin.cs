using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circulation02.Forms;

namespace Circulation02
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
            {
            cmbCompany.Items.Add("Mediastar Limited - Prothom Alo");
            cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompany.SelectedIndex = 0;
            dtpSessionDate.Value = DateTime.Now;

            this.AcceptButton = btnOK;

           

            }

        private void btnOK_Click(object sender, EventArgs e)
            {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Enter User ID");
                txtUserID.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password");
                txtPassword.Focus();
                return;
            }   

            //string userName="";
            string userPassword=txtPassword.Text;
            bool userFound = false;
            

            //var conv  = System.Text.Encoding.UTF8.GetBytes(userPassword);
            //var decUserPassword = System.Convert.ToBase64String(conv);


            string strSQL = "select  * from USERLIST where username='" + txtUserID.Text + "' and userPassword='" + userPassword + "' and delStatus <> 1";

            //DataSet ds = new DataSet("USERLIST");

            DataTable dtable = new DataTable();
            DataProvider dtprovider = new DataProvider();

            dtable = dtprovider.getDataTable(strSQL, "USERLIST");

            
         
            foreach (DataRow dr in dtable.Rows)
            {

              
                if (dr["userName"].ToString() == txtUserID.Text && dr["userPassword"].ToString() == userPassword)

                {
                    //CommonClass commonClass = new CommonClass();
                    //commonClass.LoginName = txtUserID.Text;

                    userFound = true;
                    frmHome MasterForm = new frmHome();
                    MasterForm.Owner = this;
                    this.Hide();
                    MasterForm.UserName = txtUserID.Text;
                    MasterForm.Show();

                    }
                
                break;
            }

            if (!userFound)
            {
                
            MessageBox.Show("You Have Entered Wrong Username Or Password !");
                txtUserID.Focus();
                return;

            }
            
            
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePass changePass=new frmChangePass();
            changePass.ShowDialog();

        }

        
           }

    }

