namespace StdMng2016
{
    partial class fmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.tspMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnStdAdo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStdDataset = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStdEF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnLINQ = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAdvTech = new System.Windows.Forms.ToolStripButton();
            this.stMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspMain.SuspendLayout();
            this.stMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspMain
            // 
            this.tspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStdAdo,
            this.tsbtnStdDataset,
            this.tsbtnStdEF,
            this.toolStripSeparator1,
            this.tsbtnLINQ,
            this.tsBtnAdvTech});
            this.tspMain.Location = new System.Drawing.Point(0, 0);
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(1144, 56);
            this.tspMain.TabIndex = 1;
            this.tspMain.Text = "toolStrip1";
            // 
            // tsbtnStdAdo
            // 
            this.tsbtnStdAdo.Image = global::StdMng2016.Properties.Resources.Std1;
            this.tsbtnStdAdo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnStdAdo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStdAdo.Name = "tsbtnStdAdo";
            this.tsbtnStdAdo.Size = new System.Drawing.Size(66, 53);
            this.tsbtnStdAdo.Text = "ADO.NET";
            this.tsbtnStdAdo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStdAdo.ToolTipText = "ADO.NET";
            this.tsbtnStdAdo.Click += new System.EventHandler(this.tsbtnStdAdo_Click);
            // 
            // tsbtnStdDataset
            // 
            this.tsbtnStdDataset.Image = global::StdMng2016.Properties.Resources.std3;
            this.tsbtnStdDataset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnStdDataset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStdDataset.Name = "tsbtnStdDataset";
            this.tsbtnStdDataset.Size = new System.Drawing.Size(57, 53);
            this.tsbtnStdDataset.Text = "DataSet";
            this.tsbtnStdDataset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStdDataset.Click += new System.EventHandler(this.tsbtnStdDataset_Click);
            // 
            // tsbtnStdEF
            // 
            this.tsbtnStdEF.Image = global::StdMng2016.Properties.Resources.std2;
            this.tsbtnStdEF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnStdEF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStdEF.Name = "tsbtnStdEF";
            this.tsbtnStdEF.Size = new System.Drawing.Size(112, 53);
            this.tsbtnStdEF.Text = "Entity Framework";
            this.tsbtnStdEF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStdEF.Click += new System.EventHandler(this.tsbtnStdEF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnLINQ
            // 
            this.tsbtnLINQ.Image = global::StdMng2016.Properties.Resources.btn_Query;
            this.tsbtnLINQ.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnLINQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLINQ.Name = "tsbtnLINQ";
            this.tsbtnLINQ.Size = new System.Drawing.Size(70, 53);
            this.tsbtnLINQ.Text = "LINQ 查询";
            this.tsbtnLINQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnLINQ.Click += new System.EventHandler(this.tsbtnLINQ_Click);
            // 
            // tsBtnAdvTech
            // 
            this.tsBtnAdvTech.Image = global::StdMng2016.Properties.Resources.btn_QueryWH;
            this.tsBtnAdvTech.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAdvTech.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdvTech.Name = "tsBtnAdvTech";
            this.tsBtnAdvTech.Size = new System.Drawing.Size(96, 53);
            this.tsBtnAdvTech.Text = "高级数据库技术";
            this.tsBtnAdvTech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnAdvTech.Click += new System.EventHandler(this.tsBtnAdvTech_Click);
            // 
            // stMain
            // 
            this.stMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stMain.Location = new System.Drawing.Point(0, 657);
            this.stMain.Name = "stMain";
            this.stMain.Size = new System.Drawing.Size(1144, 25);
            this.stMain.TabIndex = 3;
            this.stMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.toolStripStatusLabel1.Image = global::StdMng2016.Properties.Resources.copyright_1;
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(382, 20);
            this.toolStripStatusLabel1.Text = "版权所有 武汉工程大学 计算机科学与工程学院 刘黎志";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StdMng2016.Properties.Resources.BackNew1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 682);
            this.Controls.Add(this.stMain);
            this.Controls.Add(this.tspMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库开发技术2016";
            this.tspMain.ResumeLayout(false);
            this.tspMain.PerformLayout();
            this.stMain.ResumeLayout(false);
            this.stMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspMain;
        private System.Windows.Forms.ToolStripButton tsbtnStdAdo;
        private System.Windows.Forms.ToolStripButton tsbtnStdDataset;
        private System.Windows.Forms.ToolStripButton tsbtnStdEF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnLINQ;
        private System.Windows.Forms.ToolStripButton tsBtnAdvTech;
        private System.Windows.Forms.StatusStrip stMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

