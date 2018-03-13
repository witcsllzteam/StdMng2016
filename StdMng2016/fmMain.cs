using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StdMng2016.StdMng;

namespace StdMng2016
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void tsbtnStdAdo_Click(object sender, EventArgs e)
        {
            fmStdADO fmado = new fmStdADO();
            fmado.MdiParent = this;
            fmado.Show();

        }

        private void tsbtnStdDataset_Click(object sender, EventArgs e)
        {
            fmDataSet formDataSet = new fmDataSet();
            formDataSet.MdiParent = this;
            formDataSet.Show();
        }

        private void tsbtnStdEF_Click(object sender, EventArgs e)
        {
            fmEDM fedm = new fmEDM();
            fedm.MdiParent = this;
            fedm.Show();
        }

        private void tsbtnLINQ_Click(object sender, EventArgs e)
        {
            fmLINQ fl = new fmLINQ();
            fl.MdiParent = this;
            fl.Show();

        }

        private void tsBtnAdvTech_Click(object sender, EventArgs e)
        {
            fmAdTech fa = new fmAdTech();
            fa.MdiParent = this;
            fa.Show();
        }

     
    }
}
