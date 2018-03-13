namespace StdMng2016.StdMng
{
    partial class fmDataSet
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
            System.Windows.Forms.Label snoLabel;
            System.Windows.Forms.Label snameLabel;
            System.Windows.Forms.Label sGenderLabel;
            System.Windows.Forms.Label sBirthLabel;
            System.Windows.Forms.Label sdeptLabel;
            System.Windows.Forms.Label sImageLabel;
            System.Windows.Forms.Label sIDNumLabel;
            System.Windows.Forms.Label sEmailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDataSet));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.snoTextBox = new System.Windows.Forms.TextBox();
            this.t_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsStd = new StdMng2016.DsStd();
            this.snameTextBox = new System.Windows.Forms.TextBox();
            this.sGenderTextBox = new System.Windows.Forms.TextBox();
            this.sBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sdeptComboBox = new System.Windows.Forms.ComboBox();
            this.t_SdeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sImagePictureBox = new System.Windows.Forms.PictureBox();
            this.sIDNumTextBox = new System.Windows.Forms.TextBox();
            this.sEmailTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCouseAvg = new System.Windows.Forms.Label();
            this.lblCourseNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_SCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_SCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_StudentTableAdapter = new StdMng2016.DsStdTableAdapters.t_StudentTableAdapter();
            this.tableAdapterManager = new StdMng2016.DsStdTableAdapters.TableAdapterManager();
            this.t_SCTableAdapter = new StdMng2016.DsStdTableAdapters.t_SCTableAdapter();
            this.t_SdeptTableAdapter = new StdMng2016.DsStdTableAdapters.t_SdeptTableAdapter();
            this.t_StudentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_StudentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            snoLabel = new System.Windows.Forms.Label();
            snameLabel = new System.Windows.Forms.Label();
            sGenderLabel = new System.Windows.Forms.Label();
            sBirthLabel = new System.Windows.Forms.Label();
            sdeptLabel = new System.Windows.Forms.Label();
            sImageLabel = new System.Windows.Forms.Label();
            sIDNumLabel = new System.Windows.Forms.Label();
            sEmailLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SdeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImagePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_SCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_StudentBindingNavigator)).BeginInit();
            this.t_StudentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // snoLabel
            // 
            snoLabel.AutoSize = true;
            snoLabel.Location = new System.Drawing.Point(28, 35);
            snoLabel.Name = "snoLabel";
            snoLabel.Size = new System.Drawing.Size(29, 12);
            snoLabel.TabIndex = 0;
            snoLabel.Text = "sno:";
            // 
            // snameLabel
            // 
            snameLabel.AutoSize = true;
            snameLabel.Location = new System.Drawing.Point(28, 62);
            snameLabel.Name = "snameLabel";
            snameLabel.Size = new System.Drawing.Size(41, 12);
            snameLabel.TabIndex = 2;
            snameLabel.Text = "sname:";
            // 
            // sGenderLabel
            // 
            sGenderLabel.AutoSize = true;
            sGenderLabel.Location = new System.Drawing.Point(28, 89);
            sGenderLabel.Name = "sGenderLabel";
            sGenderLabel.Size = new System.Drawing.Size(53, 12);
            sGenderLabel.TabIndex = 4;
            sGenderLabel.Text = "SGender:";
            // 
            // sBirthLabel
            // 
            sBirthLabel.AutoSize = true;
            sBirthLabel.Location = new System.Drawing.Point(28, 117);
            sBirthLabel.Name = "sBirthLabel";
            sBirthLabel.Size = new System.Drawing.Size(47, 12);
            sBirthLabel.TabIndex = 6;
            sBirthLabel.Text = "SBirth:";
            // 
            // sdeptLabel
            // 
            sdeptLabel.AutoSize = true;
            sdeptLabel.Location = new System.Drawing.Point(28, 143);
            sdeptLabel.Name = "sdeptLabel";
            sdeptLabel.Size = new System.Drawing.Size(41, 12);
            sdeptLabel.TabIndex = 8;
            sdeptLabel.Text = "Sdept:";
            // 
            // sImageLabel
            // 
            sImageLabel.AutoSize = true;
            sImageLabel.Location = new System.Drawing.Point(28, 238);
            sImageLabel.Name = "sImageLabel";
            sImageLabel.Size = new System.Drawing.Size(47, 12);
            sImageLabel.TabIndex = 10;
            sImageLabel.Text = "SImage:";
            // 
            // sIDNumLabel
            // 
            sIDNumLabel.AutoSize = true;
            sIDNumLabel.Location = new System.Drawing.Point(28, 172);
            sIDNumLabel.Name = "sIDNumLabel";
            sIDNumLabel.Size = new System.Drawing.Size(53, 12);
            sIDNumLabel.TabIndex = 14;
            sIDNumLabel.Text = "s IDNum:";
            // 
            // sEmailLabel
            // 
            sEmailLabel.AutoSize = true;
            sEmailLabel.Location = new System.Drawing.Point(28, 199);
            sEmailLabel.Name = "sEmailLabel";
            sEmailLabel.Size = new System.Drawing.Size(53, 12);
            sEmailLabel.TabIndex = 16;
            sEmailLabel.Text = "s Email:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(snoLabel);
            this.panel1.Controls.Add(this.snoTextBox);
            this.panel1.Controls.Add(snameLabel);
            this.panel1.Controls.Add(this.snameTextBox);
            this.panel1.Controls.Add(sGenderLabel);
            this.panel1.Controls.Add(this.sGenderTextBox);
            this.panel1.Controls.Add(sBirthLabel);
            this.panel1.Controls.Add(this.sBirthDateTimePicker);
            this.panel1.Controls.Add(sdeptLabel);
            this.panel1.Controls.Add(this.sdeptComboBox);
            this.panel1.Controls.Add(sImageLabel);
            this.panel1.Controls.Add(this.sImagePictureBox);
            this.panel1.Controls.Add(sIDNumLabel);
            this.panel1.Controls.Add(this.sIDNumTextBox);
            this.panel1.Controls.Add(sEmailLabel);
            this.panel1.Controls.Add(this.sEmailTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 483);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // snoTextBox
            // 
            this.snoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "sno", true));
            this.snoTextBox.Location = new System.Drawing.Point(87, 32);
            this.snoTextBox.Name = "snoTextBox";
            this.snoTextBox.Size = new System.Drawing.Size(200, 21);
            this.snoTextBox.TabIndex = 1;
            // 
            // t_StudentBindingSource
            // 
            this.t_StudentBindingSource.DataMember = "t_Student";
            this.t_StudentBindingSource.DataSource = this.dsStd;
            // 
            // dsStd
            // 
            this.dsStd.DataSetName = "DsStd";
            this.dsStd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snameTextBox
            // 
            this.snameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "sname", true));
            this.snameTextBox.Location = new System.Drawing.Point(87, 59);
            this.snameTextBox.Name = "snameTextBox";
            this.snameTextBox.Size = new System.Drawing.Size(200, 21);
            this.snameTextBox.TabIndex = 3;
            // 
            // sGenderTextBox
            // 
            this.sGenderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "SGender", true));
            this.sGenderTextBox.Location = new System.Drawing.Point(87, 86);
            this.sGenderTextBox.Name = "sGenderTextBox";
            this.sGenderTextBox.Size = new System.Drawing.Size(200, 21);
            this.sGenderTextBox.TabIndex = 5;
            // 
            // sBirthDateTimePicker
            // 
            this.sBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_StudentBindingSource, "SBirth", true));
            this.sBirthDateTimePicker.Location = new System.Drawing.Point(87, 113);
            this.sBirthDateTimePicker.Name = "sBirthDateTimePicker";
            this.sBirthDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.sBirthDateTimePicker.TabIndex = 7;
            // 
            // sdeptComboBox
            // 
            this.sdeptComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.t_StudentBindingSource, "Sdept", true));
            this.sdeptComboBox.DataSource = this.t_SdeptBindingSource;
            this.sdeptComboBox.DisplayMember = "SdeptName";
            this.sdeptComboBox.FormattingEnabled = true;
            this.sdeptComboBox.Location = new System.Drawing.Point(87, 140);
            this.sdeptComboBox.Name = "sdeptComboBox";
            this.sdeptComboBox.Size = new System.Drawing.Size(200, 20);
            this.sdeptComboBox.TabIndex = 9;
            this.sdeptComboBox.ValueMember = "SdeptID";
            // 
            // t_SdeptBindingSource
            // 
            this.t_SdeptBindingSource.DataMember = "t_Sdept";
            this.t_SdeptBindingSource.DataSource = this.dsStd;
            // 
            // sImagePictureBox
            // 
            this.sImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.t_StudentBindingSource, "SImage", true));
            this.sImagePictureBox.Location = new System.Drawing.Point(87, 238);
            this.sImagePictureBox.Name = "sImagePictureBox";
            this.sImagePictureBox.Size = new System.Drawing.Size(193, 202);
            this.sImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sImagePictureBox.TabIndex = 11;
            this.sImagePictureBox.TabStop = false;
            // 
            // sIDNumTextBox
            // 
            this.sIDNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "sIDNum", true));
            this.sIDNumTextBox.Location = new System.Drawing.Point(87, 169);
            this.sIDNumTextBox.Name = "sIDNumTextBox";
            this.sIDNumTextBox.Size = new System.Drawing.Size(200, 21);
            this.sIDNumTextBox.TabIndex = 15;
            // 
            // sEmailTextBox
            // 
            this.sEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "sEmail", true));
            this.sEmailTextBox.Location = new System.Drawing.Point(87, 196);
            this.sEmailTextBox.Name = "sEmailTextBox";
            this.sEmailTextBox.Size = new System.Drawing.Size(200, 21);
            this.sEmailTextBox.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCouseAvg);
            this.panel2.Controls.Add(this.lblCourseNum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.t_SCDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(496, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 483);
            this.panel2.TabIndex = 1;
            // 
            // lblCouseAvg
            // 
            this.lblCouseAvg.AutoSize = true;
            this.lblCouseAvg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "CAvg", true));
            this.lblCouseAvg.Location = new System.Drawing.Point(110, 263);
            this.lblCouseAvg.Name = "lblCouseAvg";
            this.lblCouseAvg.Size = new System.Drawing.Size(41, 12);
            this.lblCouseAvg.TabIndex = 2;
            this.lblCouseAvg.Text = "label2";
            // 
            // lblCourseNum
            // 
            this.lblCourseNum.AutoSize = true;
            this.lblCourseNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_StudentBindingSource, "CCount", true));
            this.lblCourseNum.Location = new System.Drawing.Point(110, 237);
            this.lblCourseNum.Name = "lblCourseNum";
            this.lblCourseNum.Size = new System.Drawing.Size(41, 12);
            this.lblCourseNum.TabIndex = 2;
            this.lblCourseNum.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "平均分：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选课门数：";
            // 
            // t_SCDataGridView
            // 
            this.t_SCDataGridView.AutoGenerateColumns = false;
            this.t_SCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_SCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.t_SCDataGridView.DataSource = this.t_SCBindingSource;
            this.t_SCDataGridView.Location = new System.Drawing.Point(26, 25);
            this.t_SCDataGridView.Name = "t_SCDataGridView";
            this.t_SCDataGridView.RowTemplate.Height = 23;
            this.t_SCDataGridView.Size = new System.Drawing.Size(345, 186);
            this.t_SCDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sno";
            this.dataGridViewTextBoxColumn1.HeaderText = "学号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // t_SCBindingSource
            // 
            this.t_SCBindingSource.DataMember = "FK__t_SC__Sno__07F6335A";
            this.t_SCBindingSource.DataSource = this.t_StudentBindingSource;
            // 
            // t_StudentTableAdapter
            // 
            this.t_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_CourseTableAdapter = null;
            this.tableAdapterManager.t_SCTableAdapter = this.t_SCTableAdapter;
            this.tableAdapterManager.t_SdeptTableAdapter = this.t_SdeptTableAdapter;
            this.tableAdapterManager.t_StudentTableAdapter = this.t_StudentTableAdapter;
            this.tableAdapterManager.UpdateOrder = StdMng2016.DsStdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_SCTableAdapter
            // 
            this.t_SCTableAdapter.ClearBeforeFill = true;
            // 
            // t_SdeptTableAdapter
            // 
            this.t_SdeptTableAdapter.ClearBeforeFill = true;
            // 
            // t_StudentBindingNavigator
            // 
            this.t_StudentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_StudentBindingNavigator.BindingSource = this.t_StudentBindingSource;
            this.t_StudentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_StudentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_StudentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.t_StudentBindingNavigatorSaveItem});
            this.t_StudentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_StudentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_StudentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_StudentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_StudentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_StudentBindingNavigator.Name = "t_StudentBindingNavigator";
            this.t_StudentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_StudentBindingNavigator.Size = new System.Drawing.Size(986, 25);
            this.t_StudentBindingNavigator.TabIndex = 1;
            this.t_StudentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_StudentBindingNavigatorSaveItem
            // 
            this.t_StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_StudentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_StudentBindingNavigatorSaveItem.Image")));
            this.t_StudentBindingNavigatorSaveItem.Name = "t_StudentBindingNavigatorSaveItem";
            this.t_StudentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_StudentBindingNavigatorSaveItem.Text = "保存数据";
            this.t_StudentBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_StudentBindingNavigatorSaveItem_Click_1);
            // 
            // fmDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 489);
            this.Controls.Add(this.t_StudentBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "fmDataSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "数据集技术";
            this.Load += new System.EventHandler(this.fmDataSet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SdeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImagePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_SCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_StudentBindingNavigator)).EndInit();
            this.t_StudentBindingNavigator.ResumeLayout(false);
            this.t_StudentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DsStd dsStd;
        private System.Windows.Forms.BindingSource t_StudentBindingSource;
        private DsStdTableAdapters.t_StudentTableAdapter t_StudentTableAdapter;
        private DsStdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_StudentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton t_StudentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox snoTextBox;
        private System.Windows.Forms.TextBox snameTextBox;
        private System.Windows.Forms.TextBox sGenderTextBox;
        private System.Windows.Forms.DateTimePicker sBirthDateTimePicker;
        private System.Windows.Forms.ComboBox sdeptComboBox;
        private System.Windows.Forms.PictureBox sImagePictureBox;
        private System.Windows.Forms.TextBox sIDNumTextBox;
        private System.Windows.Forms.TextBox sEmailTextBox;
        private DsStdTableAdapters.t_SdeptTableAdapter t_SdeptTableAdapter;
        private System.Windows.Forms.BindingSource t_SdeptBindingSource;
        private DsStdTableAdapters.t_SCTableAdapter t_SCTableAdapter;
        private System.Windows.Forms.BindingSource t_SCBindingSource;
        private System.Windows.Forms.DataGridView t_SCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblCouseAvg;
        private System.Windows.Forms.Label lblCourseNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}