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
    public partial class frmCategorySetup : Form
    {
        public string UserName { get; set; }

        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        string connStr = "Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";
  
        public frmCategorySetup()
        {
            InitializeComponent();
        }

        private void frmCategorySetup_Load(object sender, EventArgs e)
        {
            
            BindGridView();

        }

        private void BindGridView()
        {
            dt.Rows.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("select CATNAME,CREATEDATE,AUDUSER from CATEGORY where delStatus<>1", con);
            sda.Fill(dt);
            gvCategory.DataSource = dt;
            con.Close();

        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dgRow = gvCategory.Rows[indexRow];

            txtCatName.Text = dgRow.Cells[0].Value.ToString();

            btnSave.Text = "Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from CATEGORY where delStatus<>1 AND CATNAME='" + txtCatName.Text +
                               "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (btnSave.Text == "Save")
            {


                if (rowNumber == 0)
                {
                    string sqlCmd = "INSERT INTO CATEGORY VALUES('" + txtCatName.Text + "','" + DateTime.Now + "','" +
                                    UserName + "',0)";
                    dp.ExecuteCommand(sqlCmd);

                    MessageBox.Show("Category Added Successfully ", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category Already Exist! Please Try Another One ", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }


            if (btnSave.Text == "Update")
            {
                DataGridViewRow gvRow = gvCategory.SelectedRows[0];
                string sqlCatId = "select CATID from CATEGORY where CATNAME='" + gvRow.Cells[0].Value.ToString() + "'";

                int catId = Convert.ToInt32(dp.getResultString(sqlCatId));

                string strUpdate = "UPDATE CATEGORY set CATNAME='" + txtCatName.Text + "',createDate='" +
                                   DateTime.Now + "',audUser='" + UserName + "' where CATID='" + catId + "'";
                dp.ExecuteCommand(strUpdate);

                MessageBox.Show("Category Updated Successfully ", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnSave.Text = "Save";

            }
            txtCatName.Clear();
            BindGridView();
        }
    }
}
