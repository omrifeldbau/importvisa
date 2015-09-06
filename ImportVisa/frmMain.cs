using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportVisa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectTarget_Click(object sender, EventArgs e)
        {
            if (openTarget.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = openTarget.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectSources_Click(object sender, EventArgs e)
        {
            if (openSources.ShowDialog() == DialogResult.OK)
            {
                foreach (string fn in openSources.FileNames)
                {
                    lbSources.Items.Add(fn);
                }
            }
        }
    }
}
