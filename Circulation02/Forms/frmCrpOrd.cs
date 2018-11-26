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
    public partial class frmCrpOrd : Form
    {
        public string UserName { get; set; }
        private DataProvider dp = new DataProvider();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        string connectionString = "Data Source=(local); User ID=sa;Password=erp;Initial Catalog=ALODAT;Trusted_connection=false;Integrated Security=false;Pooling=false;";
        public frmCrpOrd()
        {
            InitializeComponent();
        }

        private void frmCrpOrd_Load(object sender, EventArgs e)
        {
            BindCrpCust();
            Region();
        

        }
        private void BindCrpCust()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT LTRIM(NAMECUST) AS NAMECUST FROM ARCUS where IDCUST='10100-3114' or IDCUST='10100-3146' or IDCUST='10100-3326' or IDCUST='10100-2658'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(ds);
            cmbCrpCust.DisplayMember = "NAMECUST".Replace("'", "''");
            cmbCrpCust.DataSource = ds.Tables[0];
            con.Close();
            cmbCrpCust.Text="---- Select ----";
           
        }

        private void Region()
        {
            string query = "select distName from district order by distName asc";
            ds = dp.getDataSet(query, "distName");
            cmbRgn.DisplayMember = "distName";
            cmbRgn.DataSource = ds.Tables[0];
            cmbRgn.Text="---- Select ----";
        }

        private void Station()
        {
            string query = "SELECT DISTINCT stationName from orderEntry where orderDate='" + dTPOrdDate.Text + "'  and customerId='" + txtAgntId.Text + "'  Order By stationName ASC ";
            ds = dp.getDataSet(query, "stationName");
            cmbStat.DisplayMember = "stationName";
            cmbStat.DataSource = ds.Tables[0];
            cmbStat.Text="---- Select ----";
        }

        private void cmbRgn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRgn.Focused)
            {
                cmbStat.Enabled = true;
                Station();
     
                
            }
               }

        private void btnAgntFinder_Click(object sender, EventArgs e)
        {
            frmFinderAgnt finderAgnt=new frmFinderAgnt();
            finderAgnt.Owner = this;
            finderAgnt.sourceform = "frmCrpOrd";
            finderAgnt.ShowDialog();
        }

        private void cmbStat_SelectedIndexChanged(object sender, EventArgs e)
        
        
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            int rowNumber = 0;
            string custID = "";

            string cprCustID = "Select IDCUST from ARCUS where NAMECUST='" + cmbCrpCust.Text.Replace("'", "''") + "' AND IDACCTSET='10100'";
            SqlCommand cmdId = new SqlCommand(cprCustID, con);
            SqlDataReader sdr = cmdId.ExecuteReader();
            while (sdr.Read())
            {
                custID = sdr["IDCUST"].ToString();
            }
            sdr.Close();

            string countRow = "select count(*) from CorporateOrder where orderDate='" + dTPOrdDate.Text + "' AND customerId='" + txtAgntId.Text + "' AND stationName='" + cmbStat.Text.Replace("'", "''") + "' AND cprCustomer='" + custID + "' and region='" + cmbRgn.Text.Replace("'", "''") + "'";
            rowNumber = Convert.ToInt32(dp.getResultString(countRow));
            if (rowNumber == 0)
            {
                txtQty.Text = "0";
            }
            else
            {
                string sqlQty = "SELECT Quantity from CorporateOrder where orderDate='" + dTPOrdDate.Text + "' AND customerId='" + txtAgntId.Text + "' AND stationName='" + cmbStat.Text.Replace("'", "''") + "' AND cprCustomer='" + custID + "' and region='" + cmbRgn.Text.Replace("'", "''") + "'";
                txtQty.Text = dp.getResultString(sqlQty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
       
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            int checkOrder = 0;

            string custID = "";

            string cprCustID = "Select IDCUST from ARCUS where NAMECUST='" + cmbCrpCust.Text.Replace("'", "''") + "' AND IDACCTSET='10100'";
            SqlCommand cmdId = new SqlCommand(cprCustID, con);
            SqlDataReader sdr = cmdId.ExecuteReader();
            while (sdr.Read())
            {
                custID = sdr["IDCUST"].ToString();
            }
            sdr.Close();

            string countOrder = "select count(*) from CorporateOrder where orderDate='" + dTPOrdDate.Text + "' AND customerId='" + txtAgntId.Text + "' AND stationName='" + cmbStat.Text.Replace("'", "''") + "' AND cprCustomer='" + custID + "' and region='" + cmbRgn.Text.Replace("'", "''") + "'";
            checkOrder = Convert.ToInt32(dp.getResultString(countOrder));

            if (checkOrder == 0)
            {
                string InertOrder = "INSERT INTO CorporateOrder VALUES('" + txtAgntId.Text + "','" + cmbStat.Text.Replace("'", "''") + "','" + custID + "','Daily Newspaper','" + txtQty.Text + "','" + dTPOrdDate.Text + "','" + DateTime.Now + "','" + UserName + "','1','" + cmbRgn.Text.Replace("'", "''") + "')";
                dp.ExecuteCommand(InertOrder);
            }
            else
            {
                string UpdateOrder = "UPDATE CorporateOrder set Quantity='" + txtQty.Text + "' where  orderDate='" + dTPOrdDate.Text + "' AND customerId='" + txtAgntId.Text + "' AND stationName='" + cmbStat.Text.Replace("'", "''") + "' AND cprCustomer='" + custID + "' and region='" + cmbRgn.Text.Replace("'", "''") + "'";
                dp.ExecuteCommand(UpdateOrder);
            }

            }
    }
}
