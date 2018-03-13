using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StdMng2016.StdMng
{
    public partial class fmAdTech : Form
    {
        StdMng2015NEntities se = new StdMng2015NEntities();
        //当前页码        
        int curLINQPage;
        //数据表的总页数        
        int totalLINQPageCount;
        //每页的记录数
        int pageSize;


        //递归应用
        private DataSet dsArea;
        TreeNode rootNode;
        string a_code;


        public fmAdTech()
        {
            InitializeComponent();
        }

        private void fmAdTech_Load(object sender, EventArgs e)
        {
            //区间数据
            pageSize = Properties.Settings.Default.PageSize;                      
            curLINQPage = 1;          
            totalLINQPageCount = se.t_MassData.Count() / pageSize 
                                + (se.t_MassData.Count() % pageSize == 0 ? 0 : 1);         
            lblLINQPage.Text = curLINQPage.ToString();           
            lblLINQTOTAL.Text = totalLINQPageCount.ToString();          
            GetIntervalDataByLINQ(curLINQPage, pageSize);

            //数据透视
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.StdMng2015NConnectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select [Year],[Quarter],Amount from t_Pivot";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "BeforePivot");

                cmd.CommandText = "PivotTable2000";
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds, "Pivot2000");

                cmd.CommandText = "PivotTable2005";
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds, "Pivot2005");

                gvBeforPivot.DataSource = ds.Tables["BeforePivot"];
                gvPivot2000.DataSource = ds.Tables["Pivot2000"];
                gvPivot2005.DataSource = ds.Tables["Pivot2005"];

            }
        }

        //LINQ方式取区间数据
        private void GetIntervalDataByLINQ(int curPage, int pageSize)
        {
            gvLINQ.DataSource =
            se.t_MassData.OrderBy(t => t.ID).
                           Skip((curPage - 1) * pageSize).
                           Take(pageSize);

            lblLINQPage.Text = curPage.ToString();
        }


        private void fmAdTech_FormClosed(object sender, FormClosedEventArgs e)
        {
            se.Dispose();
        }

        private void btnLINQPre_Click(object sender, EventArgs e)
        {
            if (curLINQPage == 1)
            {
                return;
            }
            else
            {
                curLINQPage -= 1;
                GetIntervalDataByLINQ(curLINQPage, pageSize);
            }
        }

        private void btnLINQNext_Click(object sender, EventArgs e)
        {
            if (curLINQPage == totalLINQPageCount)
            {
                return;
            }
            else
            {
                curLINQPage += 1;
                GetIntervalDataByLINQ(curLINQPage, pageSize);
            }
        }

        private void btnLINQFirst_Click(object sender, EventArgs e)
        {
            curLINQPage = 1;
            GetIntervalDataByLINQ(curLINQPage, pageSize);
        }

        private void btnLINQLast_Click(object sender, EventArgs e)
        {
            curLINQPage = totalLINQPageCount;
            GetIntervalDataByLINQ(curLINQPage, pageSize);
        }

        private void btnLINQGo_Click(object sender, EventArgs e)
        {
            int pageInput = curLINQPage;

            if (txtLINQNum.Text.Trim() != "")
                pageInput = Convert.ToInt32(txtLINQNum.Text.Trim());

            if (pageInput <= totalLINQPageCount)
            {
                curLINQPage = pageInput;
                GetIntervalDataByLINQ(curLINQPage, pageSize);
            }
        }

        private void GetAreaData()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.StdMng2015NConnectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                //GetAreaChildNodesByTempTable
                //GetAreaChildNodesByTableVariable
                //GetAreaChildNodesByCTE
                cmd.CommandText = "GetAreaChildNodesByCTE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(new SqlParameter[] 
                { 
                    new  SqlParameter("@a_code",a_code) 
                }
                );

                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsArea = new DataSet();
                da.Fill(dsArea);
            }
        }

        private void BindNodes(DataTable dtArea, TreeNode node)
        {
            DataRow[] rows = dtArea.Select("a_parent = '" + node.Name + "'");

            foreach (DataRow row in rows)
            {
                TreeNode newNode = new TreeNode();
                newNode.Name = row["a_code"].ToString();
                newNode.Text = row["a_name"].ToString();
                newNode.ImageIndex = Convert.ToInt32(row["level"]);
                node.Nodes.Add(newNode);
                BindNodes(dtArea, newNode);
            }
        }



        private void bwRecurse_DoWork(object sender, DoWorkEventArgs e)
        {
            GetAreaData();

            if (dsArea.Tables[0].Rows.Count > 0)
            {
                DataRow rootRow = dsArea.Tables[0].Select("a_code = '" + txtAcode.Text + "'")[0];
                rootNode = new TreeNode();
                rootNode.Name = rootRow["a_code"].ToString();
                rootNode.Text = rootRow["a_name"].ToString();
                rootNode.ImageIndex = Convert.ToInt32(rootRow["level"]);
                BindNodes(dsArea.Tables[0], rootNode);
            }     
        }

        private void bwRecurse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //注意异步方式不能对窗体中的控件做修改，所以rootNode只能在递归完后再添加
            tvArea.Nodes.Add(rootNode);
            rootNode.Expand();
            this.Cursor = Cursors.Default;
        }

        private void btnOkRec_Click(object sender, EventArgs e)
        {
            if (tvArea.Nodes.Count > 0)
                tvArea.Nodes.Clear();

            a_code = txtAcode.Text.Trim();

            //同步方式            
            //this.Cursor = Cursors.WaitCursor;
            //GetAreaData();

            //if (dsArea.Tables[0].Rows.Count > 0)
            //{
            //    DataRow rootRow = dsArea.Tables[0].Select("a_code = '" + txtAcode.Text + "'")[0];
            //    rootNode = new TreeNode();
            //    rootNode.Name = rootRow["a_code"].ToString();
            //    rootNode.Text = rootRow["a_name"].ToString();
            //    rootNode.ImageIndex = Convert.ToInt32(rootRow["level"]);
            //    tvArea.Nodes.Add(rootNode);
            //    BindNodes(dsArea.Tables[0], rootNode);
            //    rootNode.Expand();
            //    this.Cursor = Cursors.Default;
            //}

            //异步方式
            this.Cursor = Cursors.WaitCursor;
            bwRecurse.RunWorkerAsync();
        }
    }
}
