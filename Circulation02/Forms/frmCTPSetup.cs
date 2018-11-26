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
    public partial class frmCTPSetup : Form
    {
        public string UserName { get; set; }

        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        string connStr = "Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";
  
        public frmCTPSetup()
        {
            InitializeComponent();
        }

        private void frmCTPSetup_Load(object sender, EventArgs e)
        {
            BindCmb();

        }

        private void BindCmb()
        {
            cmbPress.Text = "--- Select ---";
            cmbPress.Items.Add("Dhaka");
            cmbPress.Items.Add("Chittagong");
            cmbPress.Items.Add("Bogra");
        }

        private void BindGridView()
        {
            dt.Rows.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("select pageId,PageName,deFaultTime from CTPSETUP where PRESS ='"+cmbPress.Text+"'", con);
            sda.Fill(dt);
            gvCTPStp.DataSource = dt;
            con.Close();

        }

        private void BindGridView_Page()
        {
            dt.Rows.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("select PageId,PageName from PAGESETUP", con);
            sda.Fill(dt);
            gvCTPStp.DataSource = dt;
            con.Close();

        }
        private void cmbPress_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCount = "select Count(*) from CTPSETUP where press='" + cmbPress.Text + "'";
            int rowNumber = Convert.ToInt32(dp.getResultString(strCount));

            if (rowNumber==0)
            {
                BindGridView_Page();
                btnSave.Text = "Save";
            }
            else
            {
                BindGridView();
                    btnSave.Text = "Update";
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strCount = "select Count(*) from CTPSETUP where press='" + cmbPress.Text + "'";
            int rowNumber = Convert.ToInt32(dp.getResultString(strCount));

            if (rowNumber==0)
            {

                
                foreach (DataGridViewRow gvItem in gvCTPStp.Rows)
                {
                  
                   string sqlInsert = "INSERT INTO CTPSETUP VALUES('" + cmbPress.Text + "','" + gvItem.Cells[2].Value+ "','" + gvItem.Cells[0].Value + "','" + DateTime.Now + "','" + UserName + "','" + gvItem.Cells[1].Value + "')";
                    dp.ExecuteCommand(sqlInsert);
                    
                }
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (rowNumber != 0)
            {
                foreach (DataGridViewRow gvRow in gvCTPStp.Rows)
                {
                    string sqlUpdate = "UPDATE CTPSETUP set press='" + cmbPress.Text + "',deFaultTime='" + gvRow.Cells[2].Value + "', createDate='" + DateTime.Now + "',audUser='" + UserName + "'  where pageId='" + gvRow.Cells[0].Value + "' and press= '" + cmbPress.Text + "'";
                    dp.ExecuteCommand(sqlUpdate);
                }

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
                

            
        }
    }
}
