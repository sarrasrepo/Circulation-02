using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Circulation02.Forms
{
    public partial class frmSalesArea : Form
    {
        public string UserName { get; set; }
        DataProvider dp= new DataProvider();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        string connStr = "Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";
  
        public frmSalesArea()
        {
            InitializeComponent();
        }

        private void frmSalesArea_Load(object sender, EventArgs e)
        {
            BindRM();
            BindAgent();
            BindStation();
        }

    #region Binding
        private void BindRM()
        {
            string query = "SELECT  rmName from regionalManager where delStatus<>1 Order By rmName ASC ";
            ds = dp.getDataSet(query, "rmName");
            cmbRM.DataSource = ds.Tables[0];
            cmbRM.DisplayMember = "rmname";
            cmbRM.Text="---- Select ----";
        }

        private void BindAgent()
        {
            string query = "SELECT  hkrNameEng from hawkerInformation where delStatus<>1 Order By hkrNameEng ASC ";
            ds = dp.getDataSet(query, "hkrNameEng");
            cmbAgent.DataSource = ds.Tables[0];
            cmbAgent.DisplayMember = "hkrNameEng";
            cmbAgent.Text= "---- Select ----";
        }

        private void BindStation()
        {
            string query = "SELECT  stationName from station where delStatus<>1  Order By stationName ASC ";
            ds = dp.getDataSet(query, "stationName");
            cmbStation.DataSource = ds.Tables[0];
            cmbStation.DisplayMember = "stationName";
            cmbStation.Text= "---- Select ----";
        }

        private void BindGridView()
        {
            dt.Rows.Clear();
            SqlConnection con=new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT rmName,CustomerName,stationName,createDate from distribution where delStatus <> 1 and rmName = '" + cmbRM.Text + "'",con);
            sda.Fill(dt);
            gvSalesArea.DataSource = dt;
            con.Close();
        }

    #endregion


       

        private void cmbRM_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void gvSalesArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dgRow = gvSalesArea.Rows[indexRow];

            cmbRM.Text = dgRow.Cells[0].Value.ToString();
            cmbAgent.Text = dgRow.Cells[1].Value.ToString();
            cmbStation.Text = dgRow.Cells[2].Value.ToString();
            btnSave.Text = "Update";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string agentId = "";
            string selCountrow = "SELECT COUNT(*) from distribution where delStatus<>1 AND rmName='" + cmbRM.Text + "' AND customerName = '" + cmbAgent.Text.Replace("'", "''") + "' AND stationName='" + cmbStation.Text.Replace("'", "''") + "'";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            string sqlRmId = "select rmId from regionalManager where rmName='"+cmbRM.Text.Replace("'","''")+"'";
            int rmId = Convert.ToInt32(dp.getResultString(sqlRmId));

            string sqlAgntId = "SELECT hkrid from hawkerInformation where delStatus<>1 AND hkrNameEng ='"+cmbAgent.Text.Replace("'","''")+"'";
            int agntId = Convert.ToInt32(dp.getResultString(sqlAgntId));
           
            string sqlStatId = "SELECT stationId from station where delStatus<>1 AND stationName='" + cmbStation.Text.Replace("'", "''") + "'";
            int stationId = Convert.ToInt32(dp.getResultString(sqlStatId));

            if (btnSave.Text == "Save")
            {
                if(rowNumber==0)
                {
                try
                {
                    string cmd = "EXEC Insert_distribution '" + rmId + "' ,'"
                                 + cmbRM.Text.Replace("'", "''") + "' ,'"
                                 + agntId + "' ,'"
                                 + cmbAgent.Text.Replace("'", "''") + "' ,'"
                                 + stationId + "' ,'"
                                 + cmbStation.Text.Replace("'", "''") + "' ,'"
                                 + UserName + "' ,'"
                                 + DateTime.Now + "' ";

                    dp.ExecuteCommand(cmd);
                    MessageBox.Show("Data Added Successfully ", "Sucess", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

            if (btnSave.Text == "Update")
            {
                DataGridViewRow gvRow = gvSalesArea.SelectedRows[0];

                string sqlDistid = "SELECT dsId from distribution where delStatus<>1 AND rmName='" +
                                   gvRow.Cells[0].Value.ToString().Replace("'", "''") + "' AND customerName = '" +
                                   gvRow.Cells[1].Value.ToString().Replace("'", "''") + "' AND stationName='" +
                                   gvRow.Cells[2].Value.ToString().Replace("'", "''") + "'";
                int distId = Convert.ToInt32(dp.getResultString(sqlDistid));

                if (distId > 0)
                {
                    try
                    {
                        string cmd = "EXEC Update_distribution '" + distId + "','"
                                     + rmId + "' ,'"
                                     + cmbRM.Text.Replace("'", "''") + "' ,'"
                                     + agntId + "' ,'"
                                     + cmbAgent.Text.Replace("'", "''") + "' ,'"
                                     + stationId + "' ,'"
                                     + cmbStation.Text.Replace("'","''") + "' ,'"
                                     + UserName + "' ,'"
                                     + DateTime.Now + "' ";

                        dp.ExecuteCommand(cmd);
                        MessageBox.Show("Data Updated Successfully", "Sucess", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            BindGridView();
            }

           

        }
    }
