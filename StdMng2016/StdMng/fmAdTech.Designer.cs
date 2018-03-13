namespace StdMng2016.StdMng
{
    partial class fmAdTech
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAdTech));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLINQPre = new System.Windows.Forms.Button();
            this.btnLINQNext = new System.Windows.Forms.Button();
            this.btnLINQFirst = new System.Windows.Forms.Button();
            this.txtLINQNum = new System.Windows.Forms.MaskedTextBox();
            this.btnLINQLast = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLINQGo = new System.Windows.Forms.Button();
            this.lblLINQTOTAL = new System.Windows.Forms.Label();
            this.lblLINQPage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gvLINQ = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gvBeforPivot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gvPivot2005 = new System.Windows.Forms.DataGridView();
            this.gvPivot2000 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnOkRec = new System.Windows.Forms.Button();
            this.txtAcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvArea = new System.Windows.Forms.TreeView();
            this.ilRecurse = new System.Windows.Forms.ImageList(this.components);
            this.bwRecurse = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLINQ)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBeforPivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPivot2005)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPivot2000)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLINQPre);
            this.tabPage1.Controls.Add(this.btnLINQNext);
            this.tabPage1.Controls.Add(this.btnLINQFirst);
            this.tabPage1.Controls.Add(this.txtLINQNum);
            this.tabPage1.Controls.Add(this.btnLINQLast);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnLINQGo);
            this.tabPage1.Controls.Add(this.lblLINQTOTAL);
            this.tabPage1.Controls.Add(this.lblLINQPage);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.gvLINQ);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "区间数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLINQPre
            // 
            this.btnLINQPre.Location = new System.Drawing.Point(8, 472);
            this.btnLINQPre.Name = "btnLINQPre";
            this.btnLINQPre.Size = new System.Drawing.Size(75, 23);
            this.btnLINQPre.TabIndex = 18;
            this.btnLINQPre.Text = "前一页";
            this.btnLINQPre.UseVisualStyleBackColor = true;
            this.btnLINQPre.Click += new System.EventHandler(this.btnLINQPre_Click);
            // 
            // btnLINQNext
            // 
            this.btnLINQNext.Location = new System.Drawing.Point(89, 472);
            this.btnLINQNext.Name = "btnLINQNext";
            this.btnLINQNext.Size = new System.Drawing.Size(75, 23);
            this.btnLINQNext.TabIndex = 19;
            this.btnLINQNext.Text = "后一页";
            this.btnLINQNext.UseVisualStyleBackColor = true;
            this.btnLINQNext.Click += new System.EventHandler(this.btnLINQNext_Click);
            // 
            // btnLINQFirst
            // 
            this.btnLINQFirst.Location = new System.Drawing.Point(170, 472);
            this.btnLINQFirst.Name = "btnLINQFirst";
            this.btnLINQFirst.Size = new System.Drawing.Size(75, 23);
            this.btnLINQFirst.TabIndex = 17;
            this.btnLINQFirst.Text = "最前页";
            this.btnLINQFirst.UseVisualStyleBackColor = true;
            this.btnLINQFirst.Click += new System.EventHandler(this.btnLINQFirst_Click);
            // 
            // txtLINQNum
            // 
            this.txtLINQNum.Location = new System.Drawing.Point(375, 474);
            this.txtLINQNum.Mask = "99999";
            this.txtLINQNum.Name = "txtLINQNum";
            this.txtLINQNum.Size = new System.Drawing.Size(46, 21);
            this.txtLINQNum.TabIndex = 21;
            this.txtLINQNum.ValidatingType = typeof(int);
            // 
            // btnLINQLast
            // 
            this.btnLINQLast.Location = new System.Drawing.Point(251, 472);
            this.btnLINQLast.Name = "btnLINQLast";
            this.btnLINQLast.Size = new System.Drawing.Size(75, 23);
            this.btnLINQLast.TabIndex = 16;
            this.btnLINQLast.Text = "最后页";
            this.btnLINQLast.UseVisualStyleBackColor = true;
            this.btnLINQLast.Click += new System.EventHandler(this.btnLINQLast_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "页";
            // 
            // btnLINQGo
            // 
            this.btnLINQGo.Location = new System.Drawing.Point(332, 472);
            this.btnLINQGo.Name = "btnLINQGo";
            this.btnLINQGo.Size = new System.Drawing.Size(37, 23);
            this.btnLINQGo.TabIndex = 15;
            this.btnLINQGo.Text = "跳到";
            this.btnLINQGo.UseVisualStyleBackColor = true;
            this.btnLINQGo.Click += new System.EventHandler(this.btnLINQGo_Click);
            // 
            // lblLINQTOTAL
            // 
            this.lblLINQTOTAL.Location = new System.Drawing.Point(104, 454);
            this.lblLINQTOTAL.Name = "lblLINQTOTAL";
            this.lblLINQTOTAL.Size = new System.Drawing.Size(33, 12);
            this.lblLINQTOTAL.TabIndex = 14;
            this.lblLINQTOTAL.Text = "1000";
            // 
            // lblLINQPage
            // 
            this.lblLINQPage.Location = new System.Drawing.Point(29, 454);
            this.lblLINQPage.Name = "lblLINQPage";
            this.lblLINQPage.Size = new System.Drawing.Size(29, 12);
            this.lblLINQPage.TabIndex = 13;
            this.lblLINQPage.Text = "1000";
            this.lblLINQPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "页";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "/共";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "页";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "第";
            // 
            // gvLINQ
            // 
            this.gvLINQ.AllowUserToAddRows = false;
            this.gvLINQ.AllowUserToDeleteRows = false;
            this.gvLINQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLINQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLINQ.Location = new System.Drawing.Point(6, 6);
            this.gvLINQ.Name = "gvLINQ";
            this.gvLINQ.ReadOnly = true;
            this.gvLINQ.RowTemplate.Height = 23;
            this.gvLINQ.Size = new System.Drawing.Size(486, 437);
            this.gvLINQ.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据透视";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gvBeforPivot);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvPivot2005);
            this.splitContainer1.Panel2.Controls.Add(this.gvPivot2000);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(818, 505);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 1;
            // 
            // gvBeforPivot
            // 
            this.gvBeforPivot.AllowUserToAddRows = false;
            this.gvBeforPivot.AllowUserToDeleteRows = false;
            this.gvBeforPivot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBeforPivot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBeforPivot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBeforPivot.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvBeforPivot.Location = new System.Drawing.Point(13, 33);
            this.gvBeforPivot.Name = "gvBeforPivot";
            this.gvBeforPivot.ReadOnly = true;
            this.gvBeforPivot.RowTemplate.Height = 23;
            this.gvBeforPivot.Size = new System.Drawing.Size(346, 436);
            this.gvBeforPivot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "透视前";
            // 
            // gvPivot2005
            // 
            this.gvPivot2005.AllowUserToAddRows = false;
            this.gvPivot2005.AllowUserToDeleteRows = false;
            this.gvPivot2005.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPivot2005.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvPivot2005.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "--";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPivot2005.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvPivot2005.Location = new System.Drawing.Point(19, 287);
            this.gvPivot2005.Name = "gvPivot2005";
            this.gvPivot2005.ReadOnly = true;
            this.gvPivot2005.RowTemplate.Height = 23;
            this.gvPivot2005.Size = new System.Drawing.Size(384, 182);
            this.gvPivot2005.TabIndex = 1;
            // 
            // gvPivot2000
            // 
            this.gvPivot2000.AllowUserToAddRows = false;
            this.gvPivot2000.AllowUserToDeleteRows = false;
            this.gvPivot2000.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPivot2000.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvPivot2000.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPivot2000.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvPivot2000.Location = new System.Drawing.Point(19, 33);
            this.gvPivot2000.Name = "gvPivot2000";
            this.gvPivot2000.ReadOnly = true;
            this.gvPivot2000.RowTemplate.Height = 23;
            this.gvPivot2000.Size = new System.Drawing.Size(384, 182);
            this.gvPivot2000.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sql2005透视，使用Pivot运算符";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sql2000透视";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnOkRec);
            this.tabPage3.Controls.Add(this.txtAcode);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tvArea);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(824, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "递归";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnOkRec
            // 
            this.btnOkRec.Location = new System.Drawing.Point(184, 11);
            this.btnOkRec.Name = "btnOkRec";
            this.btnOkRec.Size = new System.Drawing.Size(75, 23);
            this.btnOkRec.TabIndex = 7;
            this.btnOkRec.Text = "确 定";
            this.btnOkRec.UseVisualStyleBackColor = true;
            this.btnOkRec.Click += new System.EventHandler(this.btnOkRec_Click);
            // 
            // txtAcode
            // 
            this.txtAcode.Location = new System.Drawing.Point(76, 11);
            this.txtAcode.Name = "txtAcode";
            this.txtAcode.Size = new System.Drawing.Size(93, 21);
            this.txtAcode.TabIndex = 6;
            this.txtAcode.Text = "420114000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "地区编码";
            // 
            // tvArea
            // 
            this.tvArea.ImageIndex = 0;
            this.tvArea.ImageList = this.ilRecurse;
            this.tvArea.Location = new System.Drawing.Point(19, 38);
            this.tvArea.Name = "tvArea";
            this.tvArea.SelectedImageIndex = 0;
            this.tvArea.Size = new System.Drawing.Size(327, 465);
            this.tvArea.TabIndex = 4;
            // 
            // ilRecurse
            // 
            this.ilRecurse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilRecurse.ImageStream")));
            this.ilRecurse.TransparentColor = System.Drawing.Color.Transparent;
            this.ilRecurse.Images.SetKeyName(0, "province.gif");
            this.ilRecurse.Images.SetKeyName(1, "city.gif");
            this.ilRecurse.Images.SetKeyName(2, "county.gif");
            this.ilRecurse.Images.SetKeyName(3, "town.gif");
            this.ilRecurse.Images.SetKeyName(4, "village.gif");
            // 
            // bwRecurse
            // 
            this.bwRecurse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRecurse_DoWork);
            this.bwRecurse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRecurse_RunWorkerCompleted);
            // 
            // fmAdTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 537);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "fmAdTech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "高级数据库技术应用";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmAdTech_FormClosed);
            this.Load += new System.EventHandler(this.fmAdTech_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLINQ)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBeforPivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPivot2005)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPivot2000)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblLINQTOTAL;
        private System.Windows.Forms.Label lblLINQPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gvLINQ;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLINQPre;
        private System.Windows.Forms.Button btnLINQNext;
        private System.Windows.Forms.Button btnLINQFirst;
        private System.Windows.Forms.MaskedTextBox txtLINQNum;
        private System.Windows.Forms.Button btnLINQLast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLINQGo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvBeforPivot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvPivot2005;
        private System.Windows.Forms.DataGridView gvPivot2000;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOkRec;
        private System.Windows.Forms.TextBox txtAcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvArea;
        private System.Windows.Forms.ImageList ilRecurse;
        private System.ComponentModel.BackgroundWorker bwRecurse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}