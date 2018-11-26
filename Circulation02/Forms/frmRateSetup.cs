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
    public partial class frmRateSetup : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public frmRateSetup()
        {
            InitializeComponent();
        }

        private void BindCategory()
        {
            string sqlCategory = "SELECT  CatName from CATEGORY where delStatus<>1 Order By CatName ASC ";
            ds = dp.getDataSet(sqlCategory, "CatName");
            cmbCategory.DataSource = ds.Tables[0];
            cmbCategory.DisplayMember = "CatName";
            cmbCategory.Text = "---- Select ----";

        }

        private void readData(string value)
        {

            bool flaghasDta = true;

            string sqlRate = "select day,noOfPage,rate from weeklyRateSetup where category='" + value + "'";
            SqlDataReader sdr = dp.getDataReader(sqlRate);

            while (sdr.Read())
            {
                string strDay = sdr["day"].ToString();

                if (strDay == "SAT")
                {
                    txtSatPage.Text = sdr["noOfPage"].ToString();
                    txtSatRate.Text = sdr["rate"].ToString();
                }

                if (strDay == "SUN")
                {
                    txtSunPage.Text = sdr["noOfPage"].ToString();
                    txtSunRate.Text = sdr["rate"].ToString();
                }

                if (strDay == "MON")
                {
                    txtMonPage.Text = sdr["noOfPage"].ToString();
                    txtMonRate.Text = sdr["rate"].ToString();
                }

                if (strDay == "TUE")
                {
                    txtTuePage.Text = sdr["noOfPage"].ToString();
                    txtTueRate.Text = sdr["rate"].ToString();
                }

                if (strDay == "WED")
                {
                    txtWedPage.Text = sdr["noOfPage"].ToString();
                    txtWedRate.Text = sdr["rate"].ToString();
                }

                if (strDay == "THU")
                {
                    txtThuPage.Text = sdr["noOfPage"].ToString();
                    txtThuRate.Text = sdr["rate"].ToString();
                }

                if (strDay == "FRI")
                {
                    txtFriPage.Text = sdr["noOfPage"].ToString();
                    txtFriRate.Text = sdr["rate"].ToString();
                }

                flaghasDta = false;

            }

            if (flaghasDta == true)
            {
                txtSatPage.Text = "";
                txtSunPage.Text = "";
                txtMonPage.Text = "";
                txtTuePage.Text = "";
                txtWedPage.Text = "";
                txtThuPage.Text = "";
                txtFriPage.Text = "";

                txtSatRate.Text = "";
                txtSunRate.Text = "";
                txtMonRate.Text = "";
                txtTueRate.Text = "";
                txtWedRate.Text = "";
                txtThuRate.Text = "";
                txtFriRate.Text = "";
            }

        }





        private void frmRateSetup_Load(object sender, EventArgs e)
        {
            BindCategory();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = cmbCategory.SelectedIndex;

            string value = cmbCategory.GetItemText(cmbCategory.Items[index]);
            readData(value);

            string selCountrow = "SELECT COUNT(*) from weeklyRateSetup where category='" + value + "' ";
            int rowNumber = Convert.ToInt32(dp.getResultString(selCountrow));

            if (rowNumber == 0)
            {
                btnSave.Text = "Add";
            }

            if (rowNumber != 0)
            {
                btnSave.Text = "Update";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Add")

            {
                try
                {

                    string cmd = "INSERT INTO weeklyRateSetup (day, noOfPage, rate,category) VALUES ('" + lblSat.Text +
                                 "', '" + txtSatPage.Text + "', '" + txtSatRate.Text + "','" + cmbCategory.Text + "') , ('" +
                                 lblSun.Text + "', '" + txtSunPage.Text + "', '" + txtSunRate.Text + "','" + cmbCategory.Text +
                                 "'), ('" + lblMon.Text + "', '" + txtMonPage.Text + "', '" + txtMonRate.Text + "','" +
                                 cmbCategory.Text + "'),  ('" + lblTue.Text + "', '" + txtTuePage.Text + "', '" +
                                 txtTueRate.Text + "','" + cmbCategory.Text + "'), ('" + lblWed.Text + "', '" +
                                 txtWedPage.Text + "', '" + txtWedRate.Text + "','" + cmbCategory.Text + "'), ('" +
                                 lblThu.Text + "', '" + txtThuPage.Text + "', '" + txtThuRate.Text + "','" +
                                 cmbCategory.Text + "'), ('" + lblFri.Text + "', '" + txtFriPage.Text + "', '" +
                                 txtFriRate.Text + "','" + cmbCategory.Text + "')";
                    dp.ExecuteCommand(cmd);
                    MessageBox.Show("Rate Added Successfully ", "Sucess", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (btnSave.Text == "Update")
            {
                try
                {
                    string sel = "select day,noOfPage,rate from weeklyRateSetup where category='" + cmbCategory.Text + "'";
                    SqlDataReader sdr = dp.getDataReader(sel);

                    while (sdr.Read())
                    {
                        string strDay = sdr["day"].ToString();

                        if (strDay == "SAT")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtSatPage.Text + "', rate = '" + txtSatRate.Text +
                                     "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                            
                        }

                        if (strDay == "SUN")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtSunPage.Text + "', rate = '" + txtSunRate.Text +
                                       "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                            
                        }

                        if (strDay == "MON")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtMonPage.Text + "', rate = '" + txtMonRate.Text +
                                      "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                           
                        }

                        if (strDay == "TUE")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtSatPage.Text + "', rate = '" + txtSatRate.Text +
                                      "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                           
                        }

                        if (strDay == "WED")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtWedPage.Text + "', rate = '" + txtWedRate.Text +
                                     "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                           
                        }

                        if (strDay == "THU")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtThuPage.Text + "', rate = '" + txtThuRate.Text +
                                        "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                           
                        }

                        if (strDay == "FRI")
                        {
                            string cmd = "update weeklyRateSetup set noOfPage = '" + txtFriPage.Text + "', rate = '" + txtFriRate.Text +
                                     "' where day = '" + strDay + "' and category='" + cmbCategory.Text + "'  ";
                            dp.ExecuteCommand(cmd);
                            
                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Rate Updated Successfully ", "Sucess", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }

            btnSave.Text = "Update";
        }



    }

}

