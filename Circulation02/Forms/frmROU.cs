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
    public partial class frmROU : Form
    {
        public string UserName { get; set; }

        DataTable dt=new DataTable();
        DataProvider dp= new DataProvider();
        DataSet ds= new DataSet();
        SqlConnection  con= new SqlConnection();
        SqlDataAdapter sda=new SqlDataAdapter();
        string connStr = "Data Source=(local);User ID=sa;Password=erp;Initial Catalog=ALOCIR;Trusted_connection=false;Integrated Security=false;Pooling=false;";
  
        public frmROU()
        {
            InitializeComponent();
        }

        private void frmROU_Load(object sender, EventArgs e)
        {
            BindReasonType();
            BindGridView();
        }

        private void BindReasonType()
        {
            cmbRsnType.Text="--- Select ---";
            cmbRsnType.Items.Add("Return");
            cmbRsnType.Items.Add("CTP");
            cmbRsnType.Items.Add("Vehicle");

        }

        private void BindGridView()
        {   
            dt.Rows.Clear();
            con = new SqlConnection(connStr);
            sda = new SqlDataAdapter("SELECT reasonType,reasonDetails,createDate from reasonOfUnsold where delStatus<>1", con);
            sda.Fill(dt);
            gvROU.DataSource = dt;
            con.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selCountrow = "SELECT COUNT(*) from reasonOfUnsold where delStatus<>1 AND reasonDetails='" + txtRsn.Text + "'  ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (rowNumber==0)
            {
                try
                {
                    string cmd = "EXEC Insert_reasonOfUnsold '" +cmbRsnType.Text+ "','"
                                                 + txtRsn.Text + "' ,'"
                                                 + UserName+ "' ,'"
                                                 + DateTime.Now + "' ";

                    dp.ExecuteCommand(cmd);

                    MessageBox.Show("Reason Added Successfully ", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Reason Already Exists ! ", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                
            }
            txtRsn.Clear();
            BindReasonType();
            BindGridView();

        }


    }
}
