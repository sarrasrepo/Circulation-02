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
    public partial class frmChallanMod : Form
    {
        public string UserName { get; set; }
        private DataProvider dp = new DataProvider();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        string connStr = "Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";
  
        public frmChallanMod()
        {
            InitializeComponent();
        }
        private void frmChallanMod_Load(object sender, EventArgs e)
        {
            BindCmbCategory();
        }
        private void BindCmbCategory()
        {
            string sqlCat = "SELECT  CatName from CATEGORY where delStatus<>1 Order By CatName ASC ";
            ds = dp.getDataSet(sqlCat, "CatName");
            cmbCat.DataSource = ds.Tables[0];
            cmbCat.DisplayMember = "CatName";
            cmbCat.Text= "---- Select ----";
        }

        private void BindSubroute()
        {
            DateTime orderDate = Convert.ToDateTime(dTPOrdDate.Text);
            string sqlQry = "SELECT  subRoute from regularModify where postStatus<>1 AND orderDate = '" + orderDate + "' and Category='" + cmbCat.Text + "' GROUP BY subRoute Order By subRoute ASC ";
            ds = dp.getDataSet(sqlQry, "subRoute");
            cmbSRoute.DataSource = ds.Tables[0];
            cmbSRoute.DisplayMember = "subRoute";
            cmbSRoute.Text = "---- Select ----";
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.Focused)
            {
                BindSubroute();    
            }
            
        }

        private void BindGridView()
        {
            dt.Rows.Clear();
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter("Select RTRIM(hkrNameEng) as hkrNameEng,stationName,quantity,daywiseDefQuanttity,smsQuantity,daywiseChngQuantity,bonusCopy,packetType from regularModify where subRoute='" + cmbSRoute.Text.Replace("'", "''") + "' AND orderDate = '" + dTPOrdDate.Text + "' AND Category='" + cmbCat.Text + "' order by sortingOrder,hkrNameEng DESC", con);
            sda.Fill(dt);
            gVChallanMod.DataSource = dt;
            con.Close();
            
            foreach (DataGridViewRow row in gVChallanMod.Rows)
            {
                gVChallanMod.Rows[row.Index].Cells[5].Style.BackColor = System.Drawing.Color.Yellow;
                gVChallanMod.Rows[row.Index].Cells[6].Style.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void cmbSRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSRoute.Focused)
            {
                BindGridView();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime orderDate = Convert.ToDateTime(dTPOrdDate.Text);
            string sRoute = cmbSRoute.Text;
            string cat = cmbCat.Text;

            foreach (DataGridViewRow gR in gVChallanMod.Rows)
            {
                string sqlAgntId = "Select distinct customerId from regularModify where hkrNameEng='" + gR.Cells[0].Value + "'";
                int agntId = Convert.ToInt32(dp.getResultString(sqlAgntId));
                string station = gR.Cells[1].Value.ToString();
                int bCopy = Convert.ToInt32(gR.Cells[6].Value);
                string pType = gR.Cells[7].Value.ToString();
                int dWCQty = Convert.ToInt32(gR.Cells[5].Value);

                string cmd = "EXEC Update_chalanModify '"+orderDate+"','"+sRoute+"','"+agntId+"','"+station+"','"+bCopy+"','"+pType+"','"+UserName+"','"+DateTime.Now+"','"+dWCQty+"','"+cat+"'";
                dp.ExecuteCommand(cmd);

            }

            MessageBox.Show("Data Updated Successfully !","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            BindGridView();

        }

        
       

       
    }
}
