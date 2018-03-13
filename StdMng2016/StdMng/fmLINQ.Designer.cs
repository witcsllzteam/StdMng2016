namespace StdMng2016.StdMng
{
    partial class fmLINQ
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvStd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGrp1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnJoin1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelExm4 = new System.Windows.Forms.Button();
            this.btnSelExm3 = new System.Windows.Forms.Button();
            this.btnSelExm2 = new System.Windows.Forms.Button();
            this.btnSPExm1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGrp2 = new System.Windows.Forms.Button();
            this.btnGrp3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStd)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gvStd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.04989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.95011F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gvStd
            // 
            this.gvStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStd.Location = new System.Drawing.Point(3, 3);
            this.gvStd.Name = "gvStd";
            this.gvStd.RowTemplate.Height = 23;
            this.gvStd.Size = new System.Drawing.Size(956, 256);
            this.gvStd.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 193);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGrp3);
            this.groupBox3.Controls.Add(this.btnGrp2);
            this.groupBox3.Controls.Add(this.btnGrp1);
            this.groupBox3.Location = new System.Drawing.Point(650, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 163);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分组";
            // 
            // btnGrp1
            // 
            this.btnGrp1.Location = new System.Drawing.Point(15, 20);
            this.btnGrp1.Name = "btnGrp1";
            this.btnGrp1.Size = new System.Drawing.Size(282, 23);
            this.btnGrp1.TabIndex = 0;
            this.btnGrp1.Text = "查询学生选课门数及平均成绩";
            this.btnGrp1.UseVisualStyleBackColor = true;
            this.btnGrp1.Click += new System.EventHandler(this.btnGrp1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnJoin1);
            this.groupBox2.Location = new System.Drawing.Point(333, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "联接";
            // 
            // btnJoin1
            // 
            this.btnJoin1.Location = new System.Drawing.Point(11, 107);
            this.btnJoin1.Name = "btnJoin1";
            this.btnJoin1.Size = new System.Drawing.Size(282, 23);
            this.btnJoin1.TabIndex = 0;
            this.btnJoin1.Text = "查询学生所在系，学号，姓名，课程名 ,成绩";
            this.btnJoin1.UseVisualStyleBackColor = true;
            this.btnJoin1.Click += new System.EventHandler(this.btnJoin1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelExm4);
            this.groupBox1.Controls.Add(this.btnSelExm3);
            this.groupBox1.Controls.Add(this.btnSelExm2);
            this.groupBox1.Controls.Add(this.btnSPExm1);
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择  投影  筛选 排序";
            // 
            // btnSelExm4
            // 
            this.btnSelExm4.Location = new System.Drawing.Point(6, 107);
            this.btnSelExm4.Name = "btnSelExm4";
            this.btnSelExm4.Size = new System.Drawing.Size(266, 23);
            this.btnSelExm4.TabIndex = 0;
            this.btnSelExm4.Text = "查询1号课程的最好成绩和次好成绩";
            this.btnSelExm4.UseVisualStyleBackColor = true;
            this.btnSelExm4.Click += new System.EventHandler(this.btnSelExm4_Click);
            // 
            // btnSelExm3
            // 
            this.btnSelExm3.Location = new System.Drawing.Point(6, 78);
            this.btnSelExm3.Name = "btnSelExm3";
            this.btnSelExm3.Size = new System.Drawing.Size(266, 23);
            this.btnSelExm3.TabIndex = 0;
            this.btnSelExm3.Text = "查询系别为IS且性别为女的学生";
            this.btnSelExm3.UseVisualStyleBackColor = true;
            this.btnSelExm3.Click += new System.EventHandler(this.btnSelExm3_Click);
            // 
            // btnSelExm2
            // 
            this.btnSelExm2.Location = new System.Drawing.Point(6, 49);
            this.btnSelExm2.Name = "btnSelExm2";
            this.btnSelExm2.Size = new System.Drawing.Size(266, 23);
            this.btnSelExm2.TabIndex = 0;
            this.btnSelExm2.Text = "查询学号为20107777的学生，并构造新类型";
            this.btnSelExm2.UseVisualStyleBackColor = true;
            this.btnSelExm2.Click += new System.EventHandler(this.btnSelExm2_Click);
            // 
            // btnSPExm1
            // 
            this.btnSPExm1.Location = new System.Drawing.Point(6, 20);
            this.btnSPExm1.Name = "btnSPExm1";
            this.btnSPExm1.Size = new System.Drawing.Size(266, 23);
            this.btnSPExm1.TabIndex = 0;
            this.btnSPExm1.Text = "查询学号为20107777的学生";
            this.btnSPExm1.UseVisualStyleBackColor = true;
            this.btnSPExm1.Click += new System.EventHandler(this.btnSPExm1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询学生学号，姓名，成绩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnJoin1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "查询学生学号，姓名，课程名 ,成绩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnJoin1_Click);
            // 
            // btnGrp2
            // 
            this.btnGrp2.Location = new System.Drawing.Point(15, 64);
            this.btnGrp2.Name = "btnGrp2";
            this.btnGrp2.Size = new System.Drawing.Size(282, 23);
            this.btnGrp2.TabIndex = 0;
            this.btnGrp2.Text = "查询男女生的人数";
            this.btnGrp2.UseVisualStyleBackColor = true;
            this.btnGrp2.Click += new System.EventHandler(this.btnGrp2_Click);
            // 
            // btnGrp3
            // 
            this.btnGrp3.Location = new System.Drawing.Point(15, 107);
            this.btnGrp3.Name = "btnGrp3";
            this.btnGrp3.Size = new System.Drawing.Size(282, 23);
            this.btnGrp3.TabIndex = 0;
            this.btnGrp3.Text = "查询每个系的学生人数";
            this.btnGrp3.UseVisualStyleBackColor = true;
            this.btnGrp3.Click += new System.EventHandler(this.btnGrp3_Click);
            // 
            // fmLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fmLINQ";
            this.Text = "LINQ查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmLINQ_FormClosed);
            this.Load += new System.EventHandler(this.fmLINQ_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gvStd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSPExm1;
        private System.Windows.Forms.Button btnSelExm2;
        private System.Windows.Forms.Button btnSelExm3;
        private System.Windows.Forms.Button btnSelExm4;
        private System.Windows.Forms.Button btnJoin1;
        private System.Windows.Forms.Button btnGrp1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGrp3;
        private System.Windows.Forms.Button btnGrp2;
    }
}