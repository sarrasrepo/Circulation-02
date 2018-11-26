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
    public partial class frmOrdSync : Form
    {
        public string UserName { get; set; }
        private DataProvider dp = new DataProvider();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public frmOrdSync()
        {
            InitializeComponent();
        }

        private void frmOrdSync_Load(object sender, EventArgs e)
        {
            BindCmbCategory();

            cmbSalesType.Items.Add("All");
            cmbSalesType.Items.Add("Cash");
            cmbSalesType.Items.Add("Credit");

            cmbSalesType.SelectedIndex = 0;
        }

        private void BindCmbCategory()
        {
            string sqlCat = "SELECT  CatName from CATEGORY where delStatus<>1 Order By CatName ASC ";
            ds = dp.getDataSet(sqlCat, "CatName");
            cmbCat.DataSource = ds.Tables[0];
            cmbCat.DisplayMember = "CatName";
            cmbCat.Text = "---- Select ----";
        }

        private void LoadData()
        {
            double totalQuantity = 0;
            string strCusNmae = "Select stationName,quantity,complementaryCopy,bonusCopy,daywiseChngQuantity,daywiseDefQuanttity from Daily_Order where orderDate BETWEEN '" + dTpOrdDateFrm.Text + "' AND '" + dTPOrdDateTo.Text + "' AND Catagory='" + cmbCat.Text + "' AND postStatus=0  order by stationName";


            if (cmbSalesType.Text != "All")
            {
                strCusNmae = strCusNmae + "AND salesType='" + cmbSalesType.Text + "'";
            }

            var con = Properties.Settings.Default.ALOCIRConnectionString;
            dt.Rows.Clear();
            SqlConnection sqlCon=new SqlConnection(con);
            SqlDataAdapter sda=new SqlDataAdapter(strCusNmae,sqlCon);
            sda.Fill(dt);
            gVOrdSync.DataSource = dt;
            sqlCon.Close();
            

            foreach (DataGridViewRow gR in gVOrdSync.Rows)
            {
                lblTotOrdVal.Text = Convert.ToString(gVOrdSync.Rows.Count);

                double Quantity = Convert.ToDouble(gVOrdSync.Rows[gR.Index].Cells[1].Value)+Convert.ToDouble(gVOrdSync.Rows[gR.Index].Cells[2].Value) 
                                        + Convert.ToDouble(gVOrdSync.Rows[gR.Index].Cells[3].Value)+ Convert.ToDouble(gVOrdSync.Rows[gR.Index].Cells[4].Value) 
                                        + Convert.ToDouble(gVOrdSync.Rows[gR.Index].Cells[5].Value);


                totalQuantity += Quantity;
                lblOrdCopyVal.Text = totalQuantity.ToString("#,###");


            }
        }

        private void btnPrvw_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var cMsg = MessageBox.Show("Do You Want To Synchronize Data ?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (cMsg == DialogResult.Yes)
            {
                string sqlQry = "UPDATE orderEntry SET postStatus=1 WHERE orderDate BETWEEN '" + dTpOrdDateFrm.Text +
                                "' AND '" + dTPOrdDateTo.Text + "' AND Catagory='" + cmbCat.Text + "'  AND postStatus=0";
                dp.ExecuteCommand(sqlQry);
                MessageBox.Show("Synchronized Successfully..!!", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            var confirmMsg = MessageBox.Show("Do You Want To Reverse ?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (confirmMsg==DialogResult.Yes)
            {
                string strReverse = "Update orderEntry set postStatus=0 where orderDate BETWEEN '" + dTpOrdDateFrm.Text + "' AND '" + dTPOrdDateTo.Text + "' AND Catagory='" + cmbCat.Text + "'  AND postStatus=1";
                dp.ExecuteCommand(strReverse);
                MessageBox.Show("Reversed Successfully..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

            else
            {
                return;
            }

           
        }
    }
}
