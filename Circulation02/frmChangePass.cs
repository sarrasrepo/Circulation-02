using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulation02
{
    public partial class frmChangePass : Form
    {
        DataProvider dp=new DataProvider();
        public string UserName { get; set; }
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlQry = "SELECT count(*) FROM userList WHERE userName='"+txtUser.Text+"' AND userPassword='"+txtOld.Text+"'";
            int count = Convert.ToInt32(dp.getResultString(sqlQry));

            if (count==1)
            {
                if (txtNew.Text==txtReNew.Text && txtNew.Text!="" && txtReNew.Text!="")
                {
                    try
                    {
                        string sqlUpdate = "Update userList set userPassword='" + txtNew.Text + "' where userName='" + txtUser.Text + "' and userPassword='" + txtOld.Text + "' and delStatus<>1 ";
                        dp.ExecuteCommand(sqlUpdate);
                        MessageBox.Show("Password changed successfully! ", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Password didn't match!! Re-type new password ", "Warning",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    txtReNew.Focus();
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect!! ", "Warning",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                txtOld.Focus();
            }
            
        }
    }
}
