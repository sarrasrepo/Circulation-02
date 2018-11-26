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
    public partial class frmPageSetup : Form
    {
        public string UserName { get; set; }

        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        string connStr = "Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";
  
        public frmPageSetup()
        {
            InitializeComponent();
        }

        private void frmPageSetup_Load(object sender, EventArgs e)
        {

            BindGridView();
        }

        private void BindGridView()
        {
            dt.Rows.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("select PageName,createDate,audUser from PageSetup where delStatus<>1", con);
            sda.Fill(dt);
            gvPageStp.DataSource = dt;
            con.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string selCountrow = "SELECT COUNT(*) from PageSetup where delStatus<>1 AND PageName='" + txtPageName.Text +
                                 "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (btnSave.Text == "Save")
            {


                if (rowNumber == 0)
                {
                    string sqlCmd = "INSERT INTO PageSetup VALUES('" + txtPageName.Text + "','" + DateTime.Now + "','" +
                                    UserName + "',0)";
                    dp.ExecuteCommand(sqlCmd);

                    MessageBox.Show("Page Added Successfully ", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Page Already Exist! Please Try Another One ", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }


            if (btnSave.Text == "Update")

            {
                DataGridViewRow gvRow = gvPageStp.SelectedRows[0];
                string sqlPageId = "select PageId from PageSetup where PageName='" + gvRow.Cells[0].Value.ToString() + "'";
                
                int pageId = Convert.ToInt32(dp.getResultString(sqlPageId));

                string strUpdate = "UPDATE PageSetup set PageName='" + txtPageName.Text + "',createDate='" +
                                   DateTime.Now + "',audUser='" + UserName + "' where pageId='" + pageId + "'";
                dp.ExecuteCommand(strUpdate);

                MessageBox.Show("Page Updated Successfully ", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnSave.Text = "Save";

            }
            txtPageName.Clear();
            BindGridView();
        }

        private void gvPageStp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dgRow = gvPageStp.Rows[indexRow];

            txtPageName.Text = dgRow.Cells[0].Value.ToString();
            
            btnSave.Text = "Update";
        }


    }
}
