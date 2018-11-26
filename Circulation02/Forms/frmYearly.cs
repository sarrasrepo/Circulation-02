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
    public partial class frmYearly : Form
    {
        public frmYearly()
        {
            InitializeComponent();
        }


        private void frmYearly_Load(object sender, EventArgs e)
        {
            DataGridViewLinkColumn editlink = new DataGridViewLinkColumn();
            editlink.UseColumnTextForLinkValue = true;
            editlink.HeaderText = "Action";
            editlink.DataPropertyName = "lnkColumn";
            editlink.LinkBehavior = LinkBehavior.SystemDefault;
            editlink.Text = "Edit";
            dataGridView1.Columns.Add(editlink);
            
        }
    }
}
