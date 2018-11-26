using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulation02.Forms
{
    public partial class frmUserFinder : Form
    {
        DataTable dt = new DataTable();
        DataProvider dp = new DataProvider();
        private string strSQL = "";
        public frmUserFinder()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {

            lvUser.View = View.Details;
            lvUser.FullRowSelect = true;
            lvUser.GridLines = true;
            


            lvUser.Columns.Add("Id", 120, HorizontalAlignment.Left);
            lvUser.Columns.Add("Full Name", 120, HorizontalAlignment.Left);
            lvUser.Columns.Add("Designation", 120, HorizontalAlignment.Left);
            lvUser.Columns.Add("Mobile No", 120, HorizontalAlignment.Left);
            lvUser.Columns.Add("E-mail", 120, HorizontalAlignment.Left);
            lvUser.Columns.Add("User Name", 120, HorizontalAlignment.Left);
            
        }

        private void frmUserFinder_Load(object sender, EventArgs e)
        {
            cmbFindBy.Items.Add("User ID");
            cmbFindBy.Items.Add("User Name");
           

            cmbFindBy.SelectedIndex = 1;

            cmbCriteria.Items.Add("Starts With");
            cmbCriteria.Items.Add("Contains");

            cmbCriteria.SelectedIndex = 1;


            string strSQL = "select top(50) userId,fullName,userDesignation,userMobile,userEmail,userName from userList ORDER BY userId ";

            LoadList(strSQL, "userList");
        }

        private void SetValue()
        {

            this.Owner.Controls.Find("txtUserId", true).First().Text = lvUser.SelectedItems[0].SubItems[0].Text;
            this.Owner.Controls.Find("txtFn", true).First().Text = lvUser.SelectedItems[0].SubItems[1].Text;

            this.Owner.Controls.Find("txtDesg", true).First().Text = lvUser.SelectedItems[0].SubItems[2].Text;
            this.Owner.Controls.Find("txtMob", true).First().Text = lvUser.SelectedItems[0].SubItems[3].Text;


            this.Owner.Controls.Find("txtEmail", true).First().Text = lvUser.SelectedItems[0].SubItems[4].Text;
            this.Owner.Controls.Find("txtUn", true).First().Text = lvUser.SelectedItems[0].SubItems[5].Text;

        }

        private void LoadList(string strSQL, string myString)
        {
           dbConnection ReportDB = new dbConnection();
           

            dt = dp.getDataTable(strSQL, myString);

            lvUser.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(drow["userId"].ToString().Trim());
                    lvi.SubItems.Add(drow["fullName"].ToString().Trim());
                    lvi.SubItems.Add(drow["userDesignation"].ToString().Trim());
                    lvi.SubItems.Add(drow["userMobile"].ToString().Trim());
                    lvi.SubItems.Add(drow["userEmail"].ToString().Trim());
                    lvi.SubItems.Add(drow["userName"].ToString().Trim());
                    lvUser.Items.Add(lvi);

                }
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbFindBy.Text == "User Name")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(10) userId,fullName,userDesignation,userMobile,userEmail,userName from userList where userName like '"+txtFilter.Text.Trim()+"%'";
                    LoadList(strSQL, "userList");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(10) userId,fullName,userDesignation,userMobile,userEmail,userName from userList where userName like'%" + txtFilter.Text.Trim() + "%'";
                    LoadList(strSQL, "userList");
                }

            }


            if (cmbFindBy.Text == "User ID")
            {
                if (cmbCriteria.Text == "Starts With")
                {
                    strSQL = "select top(10) userId,fullName,userDesignation,userMobile,userEmail,userName from userList where userId like '" + txtFilter.Text.Trim() + "%'";
                    LoadList(strSQL, "userList");
                }
                if (cmbCriteria.Text == "Contains")
                {
                    strSQL = "select top(10) userId,fullName,userDesignation,userMobile,userEmail,userName from userList where userId like '%" + txtFilter.Text.Trim() + "%'";
                    LoadList(strSQL, "userList");
                }

            }
        }

        private void lvUser_DoubleClick(object sender, EventArgs e)
        {
            SetValue();
            this.Close();
        }
    }
}
