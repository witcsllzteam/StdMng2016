using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StdMng2016.StdMng
{
    public partial class fmDataSet : Form
    {
        public fmDataSet()
        {
            InitializeComponent();
        }

        private void t_StudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_StudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsStd);

        }

        private void fmDataSet_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsStd.t_SC”中。您可以根据需要移动或删除它。
            this.t_SCTableAdapter.Fill(this.dsStd.t_SC);
            // TODO: 这行代码将数据加载到表“dsStd.t_Sdept”中。您可以根据需要移动或删除它。
            this.t_SdeptTableAdapter.Fill(this.dsStd.t_Sdept);
            // TODO: 这行代码将数据加载到表“dsStd.t_Student”中。您可以根据需要移动或删除它。
            this.t_StudentTableAdapter.Fill(this.dsStd.t_Student);             

        }

        private void t_StudentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.t_StudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsStd);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
