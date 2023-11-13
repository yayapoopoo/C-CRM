using System.ComponentModel;

namespace WinFormsApp3
{
    partial class Main
    {
        private bool bList = false;
        private bool bCusInfo = false;
        private bool bHistory = false;
        private double dbCnt = 0.0;
        private bool pageGetList = false;
        private string keyword = "없음";
        private string columnSort = "없음";
        private string columnSortType = "DESC";
        private int nCusSelectSales = 0;
        private int nCusSelectCostOfSales = 0;
        private int nCusSelectLaborCost = 0;
        private bool trayIcon = false;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private string cusId = "";
        private IContainer components = (IContainer)null;
        private ToolStrip toolStrip_Main;
        private ToolStripButton btn_SalesInfo;
        private ToolStripButton btn_SalesRanking;
        private ToolStripButton btn_DbInfo;
        private ToolStripButton btn_ProductInfo;
        private ToolStripButton btn_UsersInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox_CusList;
        private ListViewEx listView_Main;
        private GroupBox groupBox_Memo;
        private Button btn_HistoryInput;
        private TextBox txt_HistoryInput;
        private Label label12;
        private TextBox txt_HistoryLog;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Button btn_Search;
        private TextBox txt_Search;
        private GroupBox groupBox_WorkerSort;
        private Button btn_WorkerSortRefresh;
        private ComboBox comboBox_WorkerSort;
        private GroupBox groupBox6;
        private Button btn_LvRefresh;
        private ComboBox comboBox_CusStateSort;
        private Panel panel_Loading;
        private Label label41;
        private ProgressBar progressBar_Loading;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader18;
        private GroupBox groupBox5;
        private Button btn_미처리;
        private Button btn_계약완료;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tray_Open;
        private ToolStripMenuItem tray_Exit;
        private GroupBox groupBox10;
        private ComboBox comboBox_CusRouteSort;
        private ContextMenuStrip contextMenuStrip_ListView;
        private ToolStripMenuItem toolStripMenuItem_WorkerSet;
        private Button btn_리5달12달;
        private Button btn_리2달4주;
        private Button btn_리3주8주;
        private Button btn_리1주2주;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            toolStrip_Main = new ToolStrip();
            btn_DbInfo = new ToolStripButton();
            btn_ProductInfo = new ToolStripButton();
            btn_SalesInfo = new ToolStripButton();
            btn_SalesRanking = new ToolStripButton();
            btn_UsersInfo = new ToolStripButton();
            btn_Consulting = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox_CusInfo = new GroupBox();
            textBox10 = new TextBox();
            label37 = new Label();
            groupBox3 = new GroupBox();
            radioButton_BmNull = new RadioButton();
            radioButton_BmOnline = new RadioButton();
            radioButton_BmOffline = new RadioButton();
            radioButton_BmOnOff = new RadioButton();
            label29 = new Label();
            groupBox7 = new GroupBox();
            radioButton_CusTypeIndividual = new RadioButton();
            radioButton_CusTypeEntrepreneur = new RadioButton();
            radioButton_CusTypeCorporation = new RadioButton();
            radioButton_CusTypeGroup = new RadioButton();
            label30 = new Label();
            button3 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            textBox8 = new TextBox();
            label71 = new Label();
            textBox9 = new TextBox();
            label72 = new Label();
            textBox7 = new TextBox();
            label70 = new Label();
            label45 = new Label();
            label44 = new Label();
            label14 = new Label();
            label28 = new Label();
            label42 = new Label();
            label43 = new Label();
            label48 = new Label();
            label49 = new Label();
            label50 = new Label();
            label51 = new Label();
            label52 = new Label();
            label53 = new Label();
            label54 = new Label();
            label55 = new Label();
            label64 = new Label();
            label65 = new Label();
            label66 = new Label();
            label67 = new Label();
            label68 = new Label();
            label69 = new Label();
            label8 = new Label();
            label25 = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            textBox6 = new TextBox();
            label31 = new Label();
            textBox5 = new TextBox();
            label26 = new Label();
            textBox4 = new TextBox();
            label24 = new Label();
            textBox3 = new TextBox();
            label23 = new Label();
            textBox2 = new TextBox();
            label22 = new Label();
            label19 = new Label();
            label21 = new Label();
            textBox1 = new TextBox();
            btn_InstagramClipboard = new Button();
            btn_InstagramOpen = new Button();
            btn_BlogOpen = new Button();
            btn_HomepageOpen = new Button();
            button1 = new Button();
            btn_ContractEndDayOneMonth = new Button();
            btn_WorkerTeamListUpdate = new Button();
            btn_WorkerNameListUpdate = new Button();
            comboBox_WorkerTeam = new ComboBox();
            comboBox_WorkerName = new ComboBox();
            comboBox_CusRoute = new ComboBox();
            dateTimePicker_ContractEndDay = new DateTimePicker();
            label27 = new Label();
            txt_BusinessInstagram = new TextBox();
            label18 = new Label();
            txt_BusinessBlog = new TextBox();
            label17 = new Label();
            txt_BusinessHomepage = new TextBox();
            label10 = new Label();
            txt_BusinessPeriod = new TextBox();
            label9 = new Label();
            txt_BusinessPlace = new TextBox();
            label7 = new Label();
            txt_BusinessType = new TextBox();
            label6 = new Label();
            comboBox_CusChannel = new ComboBox();
            label5 = new Label();
            txt_CusTel = new TextBox();
            label4 = new Label();
            txt_CusName = new TextBox();
            label3 = new Label();
            txt_BusinessName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label20 = new Label();
            txt_RegiDate = new TextBox();
            label16 = new Label();
            label15 = new Label();
            comboBox_CusState = new ComboBox();
            label11 = new Label();
            btn_Save = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox10 = new GroupBox();
            comboBox_CusRouteSort = new ComboBox();
            groupBox8 = new GroupBox();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label13 = new Label();
            groupBox5 = new GroupBox();
            btn_리5달12달 = new Button();
            btn_리2달4주 = new Button();
            btn_리3주8주 = new Button();
            btn_리1주2주 = new Button();
            btn_미처리 = new Button();
            btn_계약완료 = new Button();
            groupBox4 = new GroupBox();
            btn_Search = new Button();
            txt_Search = new TextBox();
            groupBox_WorkerSort = new GroupBox();
            btn_WorkerSortRefresh = new Button();
            comboBox_WorkerSort = new ComboBox();
            groupBox6 = new GroupBox();
            btn_LvRefresh = new Button();
            comboBox_CusStateSort = new ComboBox();
            groupBox_CusList = new GroupBox();
            panel_Loading = new Panel();
            label41 = new Label();
            progressBar_Loading = new ProgressBar();
            listView_Main = new ListViewEx();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            groupBox_Memo = new GroupBox();
            btn_HistoryInput = new Button();
            txt_HistoryInput = new TextBox();
            label12 = new Label();
            txt_HistoryLog = new TextBox();
            tray_Open = new ToolStripMenuItem();
            tray_Exit = new ToolStripMenuItem();
            toolStripMenuItem_WorkerSet = new ToolStripMenuItem();
            backgroundWorker1 = new BackgroundWorker();
            toolStrip_Main.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox_CusInfo.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox_WorkerSort.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox_CusList.SuspendLayout();
            panel_Loading.SuspendLayout();
            groupBox_Memo.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip_Main
            // 
            toolStrip_Main.AutoSize = false;
            toolStrip_Main.Dock = DockStyle.None;
            toolStrip_Main.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip_Main.ImeMode = ImeMode.Hangul;
            toolStrip_Main.Items.AddRange(new ToolStripItem[] { btn_DbInfo, btn_ProductInfo, btn_SalesInfo, btn_SalesRanking, btn_UsersInfo, btn_Consulting });
            toolStrip_Main.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip_Main.Location = new Point(0, 0);
            toolStrip_Main.Name = "toolStrip_Main";
            toolStrip_Main.RenderMode = ToolStripRenderMode.System;
            toolStrip_Main.Size = new Size(935, 70);
            toolStrip_Main.TabIndex = 34;
            toolStrip_Main.Text = "toolStrip1";
            // 
            // btn_DbInfo
            // 
            btn_DbInfo.AutoSize = false;
            btn_DbInfo.Image = Properties.Resources.btn_DbInfo_Image;
            btn_DbInfo.ImageScaling = ToolStripItemImageScaling.None;
            btn_DbInfo.ImageTransparentColor = Color.Magenta;
            btn_DbInfo.Margin = new Padding(5);
            btn_DbInfo.Name = "btn_DbInfo";
            btn_DbInfo.Size = new Size(60, 70);
            btn_DbInfo.Text = "업체\r\n정보(&A)";
            btn_DbInfo.TextAlign = ContentAlignment.BottomCenter;
            btn_DbInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_DbInfo.Click += btn_DbInfo_Click;
            // 
            // btn_ProductInfo
            // 
            btn_ProductInfo.AutoSize = false;
            btn_ProductInfo.Image = Properties.Resources.btn_ProductInfo_Image;
            btn_ProductInfo.ImageScaling = ToolStripItemImageScaling.None;
            btn_ProductInfo.ImageTransparentColor = Color.Magenta;
            btn_ProductInfo.Margin = new Padding(5);
            btn_ProductInfo.Name = "btn_ProductInfo";
            btn_ProductInfo.Size = new Size(60, 70);
            btn_ProductInfo.Text = "판매\r\n상품관리";
            btn_ProductInfo.TextAlign = ContentAlignment.BottomCenter;
            btn_ProductInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ProductInfo.Click += btn_ProductInfo_Click;
            // 
            // btn_SalesInfo
            // 
            btn_SalesInfo.AutoSize = false;
            btn_SalesInfo.Image = Properties.Resources.btn_SalesPrediction_Image;
            btn_SalesInfo.ImageScaling = ToolStripItemImageScaling.None;
            btn_SalesInfo.ImageTransparentColor = Color.Magenta;
            btn_SalesInfo.Margin = new Padding(5);
            btn_SalesInfo.Name = "btn_SalesInfo";
            btn_SalesInfo.Size = new Size(60, 70);
            btn_SalesInfo.Text = "영업실적\r\n입력,관리";
            btn_SalesInfo.TextAlign = ContentAlignment.BottomCenter;
            btn_SalesInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btn_SalesRanking
            // 
            btn_SalesRanking.AutoSize = false;
            btn_SalesRanking.Image = Properties.Resources.btn_SalesRanking_Image;
            btn_SalesRanking.ImageScaling = ToolStripItemImageScaling.None;
            btn_SalesRanking.ImageTransparentColor = Color.Magenta;
            btn_SalesRanking.Margin = new Padding(5);
            btn_SalesRanking.Name = "btn_SalesRanking";
            btn_SalesRanking.Size = new Size(60, 70);
            btn_SalesRanking.Text = "실적\r\n순위";
            btn_SalesRanking.TextAlign = ContentAlignment.BottomCenter;
            btn_SalesRanking.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btn_UsersInfo
            // 
            btn_UsersInfo.AutoSize = false;
            btn_UsersInfo.Image = Properties.Resources.btn_UsersInfo_Image;
            btn_UsersInfo.ImageScaling = ToolStripItemImageScaling.None;
            btn_UsersInfo.ImageTransparentColor = Color.Magenta;
            btn_UsersInfo.Margin = new Padding(5);
            btn_UsersInfo.Name = "btn_UsersInfo";
            btn_UsersInfo.Size = new Size(60, 70);
            btn_UsersInfo.Text = "계정\r\n관리";
            btn_UsersInfo.TextAlign = ContentAlignment.BottomCenter;
            btn_UsersInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_UsersInfo.Click += btn_Consulting_Click;
            // 
            // btn_Consulting
            // 
            btn_Consulting.AutoSize = false;
            btn_Consulting.Image = Properties.Resources.toolStripButton_CallRank_Image;
            btn_Consulting.ImageScaling = ToolStripItemImageScaling.None;
            btn_Consulting.ImageTransparentColor = Color.Magenta;
            btn_Consulting.Margin = new Padding(5);
            btn_Consulting.Name = "btn_Consulting";
            btn_Consulting.Size = new Size(60, 70);
            btn_Consulting.Text = "마케팅\r\n관리";
            btn_Consulting.TextAlign = ContentAlignment.BottomCenter;
            btn_Consulting.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 632F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox_CusInfo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 74);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1862, 1191);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // groupBox_CusInfo
            // 
            groupBox_CusInfo.Controls.Add(textBox10);
            groupBox_CusInfo.Controls.Add(label37);
            groupBox_CusInfo.Controls.Add(groupBox3);
            groupBox_CusInfo.Controls.Add(label29);
            groupBox_CusInfo.Controls.Add(groupBox7);
            groupBox_CusInfo.Controls.Add(label30);
            groupBox_CusInfo.Controls.Add(button3);
            groupBox_CusInfo.Controls.Add(button4);
            groupBox_CusInfo.Controls.Add(groupBox2);
            groupBox_CusInfo.Controls.Add(label8);
            groupBox_CusInfo.Controls.Add(label25);
            groupBox_CusInfo.Controls.Add(label36);
            groupBox_CusInfo.Controls.Add(label35);
            groupBox_CusInfo.Controls.Add(label34);
            groupBox_CusInfo.Controls.Add(label33);
            groupBox_CusInfo.Controls.Add(label32);
            groupBox_CusInfo.Controls.Add(textBox6);
            groupBox_CusInfo.Controls.Add(label31);
            groupBox_CusInfo.Controls.Add(textBox5);
            groupBox_CusInfo.Controls.Add(label26);
            groupBox_CusInfo.Controls.Add(textBox4);
            groupBox_CusInfo.Controls.Add(label24);
            groupBox_CusInfo.Controls.Add(textBox3);
            groupBox_CusInfo.Controls.Add(label23);
            groupBox_CusInfo.Controls.Add(textBox2);
            groupBox_CusInfo.Controls.Add(label22);
            groupBox_CusInfo.Controls.Add(label19);
            groupBox_CusInfo.Controls.Add(label21);
            groupBox_CusInfo.Controls.Add(textBox1);
            groupBox_CusInfo.Controls.Add(btn_InstagramClipboard);
            groupBox_CusInfo.Controls.Add(btn_InstagramOpen);
            groupBox_CusInfo.Controls.Add(btn_BlogOpen);
            groupBox_CusInfo.Controls.Add(btn_HomepageOpen);
            groupBox_CusInfo.Controls.Add(button1);
            groupBox_CusInfo.Controls.Add(btn_ContractEndDayOneMonth);
            groupBox_CusInfo.Controls.Add(btn_WorkerTeamListUpdate);
            groupBox_CusInfo.Controls.Add(btn_WorkerNameListUpdate);
            groupBox_CusInfo.Controls.Add(comboBox_WorkerTeam);
            groupBox_CusInfo.Controls.Add(comboBox_WorkerName);
            groupBox_CusInfo.Controls.Add(comboBox_CusRoute);
            groupBox_CusInfo.Controls.Add(dateTimePicker_ContractEndDay);
            groupBox_CusInfo.Controls.Add(label27);
            groupBox_CusInfo.Controls.Add(txt_BusinessInstagram);
            groupBox_CusInfo.Controls.Add(label18);
            groupBox_CusInfo.Controls.Add(txt_BusinessBlog);
            groupBox_CusInfo.Controls.Add(label17);
            groupBox_CusInfo.Controls.Add(txt_BusinessHomepage);
            groupBox_CusInfo.Controls.Add(label10);
            groupBox_CusInfo.Controls.Add(txt_BusinessPeriod);
            groupBox_CusInfo.Controls.Add(label9);
            groupBox_CusInfo.Controls.Add(txt_BusinessPlace);
            groupBox_CusInfo.Controls.Add(label7);
            groupBox_CusInfo.Controls.Add(txt_BusinessType);
            groupBox_CusInfo.Controls.Add(label6);
            groupBox_CusInfo.Controls.Add(comboBox_CusChannel);
            groupBox_CusInfo.Controls.Add(label5);
            groupBox_CusInfo.Controls.Add(txt_CusTel);
            groupBox_CusInfo.Controls.Add(label4);
            groupBox_CusInfo.Controls.Add(txt_CusName);
            groupBox_CusInfo.Controls.Add(label3);
            groupBox_CusInfo.Controls.Add(txt_BusinessName);
            groupBox_CusInfo.Controls.Add(label2);
            groupBox_CusInfo.Controls.Add(label1);
            groupBox_CusInfo.Controls.Add(label20);
            groupBox_CusInfo.Controls.Add(txt_RegiDate);
            groupBox_CusInfo.Controls.Add(label16);
            groupBox_CusInfo.Controls.Add(label15);
            groupBox_CusInfo.Controls.Add(comboBox_CusState);
            groupBox_CusInfo.Controls.Add(label11);
            groupBox_CusInfo.Controls.Add(btn_Save);
            groupBox_CusInfo.Dock = DockStyle.Fill;
            groupBox_CusInfo.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_CusInfo.Location = new Point(3, 4);
            groupBox_CusInfo.Margin = new Padding(3, 4, 3, 4);
            groupBox_CusInfo.Name = "groupBox_CusInfo";
            groupBox_CusInfo.Padding = new Padding(3, 4, 3, 4);
            groupBox_CusInfo.Size = new Size(626, 1183);
            groupBox_CusInfo.TabIndex = 0;
            groupBox_CusInfo.TabStop = false;
            groupBox_CusInfo.Text = "업체정보";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.ImeMode = ImeMode.Hangul;
            textBox10.Location = new Point(409, 181);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.MaxLength = 20;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(200, 22);
            textBox10.TabIndex = 280;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label37.Location = new Point(329, 184);
            label37.Name = "label37";
            label37.Size = new Size(74, 13);
            label37.TabIndex = 281;
            label37.Text = "전화번호2 :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton_BmNull);
            groupBox3.Controls.Add(radioButton_BmOnline);
            groupBox3.Controls.Add(radioButton_BmOffline);
            groupBox3.Controls.Add(radioButton_BmOnOff);
            groupBox3.Location = new Point(408, 403);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(200, 75);
            groupBox3.TabIndex = 277;
            groupBox3.TabStop = false;
            // 
            // radioButton_BmNull
            // 
            radioButton_BmNull.AutoSize = true;
            radioButton_BmNull.Checked = true;
            radioButton_BmNull.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_BmNull.Location = new Point(93, 42);
            radioButton_BmNull.Margin = new Padding(3, 4, 3, 4);
            radioButton_BmNull.Name = "radioButton_BmNull";
            radioButton_BmNull.Size = new Size(51, 17);
            radioButton_BmNull.TabIndex = 14;
            radioButton_BmNull.TabStop = true;
            radioButton_BmNull.Text = "모름";
            radioButton_BmNull.UseVisualStyleBackColor = true;
            // 
            // radioButton_BmOnline
            // 
            radioButton_BmOnline.AutoSize = true;
            radioButton_BmOnline.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_BmOnline.Location = new Point(13, 15);
            radioButton_BmOnline.Margin = new Padding(3, 4, 3, 4);
            radioButton_BmOnline.Name = "radioButton_BmOnline";
            radioButton_BmOnline.Size = new Size(64, 17);
            radioButton_BmOnline.TabIndex = 11;
            radioButton_BmOnline.Text = "온라인";
            radioButton_BmOnline.UseVisualStyleBackColor = true;
            // 
            // radioButton_BmOffline
            // 
            radioButton_BmOffline.AutoSize = true;
            radioButton_BmOffline.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_BmOffline.Location = new Point(93, 13);
            radioButton_BmOffline.Margin = new Padding(3, 4, 3, 4);
            radioButton_BmOffline.Name = "radioButton_BmOffline";
            radioButton_BmOffline.Size = new Size(77, 17);
            radioButton_BmOffline.TabIndex = 12;
            radioButton_BmOffline.Text = "오프라인";
            radioButton_BmOffline.UseVisualStyleBackColor = true;
            // 
            // radioButton_BmOnOff
            // 
            radioButton_BmOnOff.AutoSize = true;
            radioButton_BmOnOff.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_BmOnOff.Location = new Point(13, 43);
            radioButton_BmOnOff.Margin = new Padding(3, 4, 3, 4);
            radioButton_BmOnOff.Name = "radioButton_BmOnOff";
            radioButton_BmOnOff.Size = new Size(70, 17);
            radioButton_BmOnOff.TabIndex = 13;
            radioButton_BmOnOff.Text = "온/오프";
            radioButton_BmOnOff.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(341, 416);
            label29.Name = "label29";
            label29.Size = new Size(61, 13);
            label29.TabIndex = 279;
            label29.Text = "BM유형 :";
            label29.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(radioButton_CusTypeIndividual);
            groupBox7.Controls.Add(radioButton_CusTypeEntrepreneur);
            groupBox7.Controls.Add(radioButton_CusTypeCorporation);
            groupBox7.Controls.Add(radioButton_CusTypeGroup);
            groupBox7.Location = new Point(116, 403);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(200, 75);
            groupBox7.TabIndex = 276;
            groupBox7.TabStop = false;
            // 
            // radioButton_CusTypeIndividual
            // 
            radioButton_CusTypeIndividual.AutoSize = true;
            radioButton_CusTypeIndividual.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_CusTypeIndividual.Location = new Point(103, 42);
            radioButton_CusTypeIndividual.Margin = new Padding(3, 4, 3, 4);
            radioButton_CusTypeIndividual.Name = "radioButton_CusTypeIndividual";
            radioButton_CusTypeIndividual.Size = new Size(51, 17);
            radioButton_CusTypeIndividual.TabIndex = 10;
            radioButton_CusTypeIndividual.Text = "개인";
            radioButton_CusTypeIndividual.UseVisualStyleBackColor = true;
            // 
            // radioButton_CusTypeEntrepreneur
            // 
            radioButton_CusTypeEntrepreneur.AutoSize = true;
            radioButton_CusTypeEntrepreneur.Checked = true;
            radioButton_CusTypeEntrepreneur.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_CusTypeEntrepreneur.Location = new Point(13, 15);
            radioButton_CusTypeEntrepreneur.Margin = new Padding(3, 4, 3, 4);
            radioButton_CusTypeEntrepreneur.Name = "radioButton_CusTypeEntrepreneur";
            radioButton_CusTypeEntrepreneur.Size = new Size(90, 17);
            radioButton_CusTypeEntrepreneur.TabIndex = 7;
            radioButton_CusTypeEntrepreneur.TabStop = true;
            radioButton_CusTypeEntrepreneur.Text = "개인사업자";
            radioButton_CusTypeEntrepreneur.UseVisualStyleBackColor = true;
            // 
            // radioButton_CusTypeCorporation
            // 
            radioButton_CusTypeCorporation.AutoSize = true;
            radioButton_CusTypeCorporation.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_CusTypeCorporation.Location = new Point(103, 13);
            radioButton_CusTypeCorporation.Margin = new Padding(3, 4, 3, 4);
            radioButton_CusTypeCorporation.Name = "radioButton_CusTypeCorporation";
            radioButton_CusTypeCorporation.Size = new Size(90, 17);
            radioButton_CusTypeCorporation.TabIndex = 8;
            radioButton_CusTypeCorporation.Text = "법인사업자";
            radioButton_CusTypeCorporation.UseVisualStyleBackColor = true;
            // 
            // radioButton_CusTypeGroup
            // 
            radioButton_CusTypeGroup.AutoSize = true;
            radioButton_CusTypeGroup.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_CusTypeGroup.Location = new Point(13, 43);
            radioButton_CusTypeGroup.Margin = new Padding(3, 4, 3, 4);
            radioButton_CusTypeGroup.Name = "radioButton_CusTypeGroup";
            radioButton_CusTypeGroup.Size = new Size(83, 17);
            radioButton_CusTypeGroup.TabIndex = 9;
            radioButton_CusTypeGroup.Text = "단체/기관";
            radioButton_CusTypeGroup.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(43, 420);
            label30.Name = "label30";
            label30.Size = new Size(67, 13);
            label30.TabIndex = 278;
            label30.Text = "사업유형 :";
            label30.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(544, 1130);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(76, 29);
            button3.TabIndex = 59;
            button3.Text = "계약상세";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(6, 1130);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(76, 29);
            button4.TabIndex = 60;
            button4.Text = "정보 저장";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label71);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label72);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label70);
            groupBox2.Controls.Add(label45);
            groupBox2.Controls.Add(label44);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label28);
            groupBox2.Controls.Add(label42);
            groupBox2.Controls.Add(label43);
            groupBox2.Controls.Add(label48);
            groupBox2.Controls.Add(label49);
            groupBox2.Controls.Add(label50);
            groupBox2.Controls.Add(label51);
            groupBox2.Controls.Add(label52);
            groupBox2.Controls.Add(label53);
            groupBox2.Controls.Add(label54);
            groupBox2.Controls.Add(label55);
            groupBox2.Controls.Add(label64);
            groupBox2.Controls.Add(label65);
            groupBox2.Controls.Add(label66);
            groupBox2.Controls.Add(label67);
            groupBox2.Controls.Add(label68);
            groupBox2.Controls.Add(label69);
            groupBox2.Location = new Point(6, 708);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(614, 414);
            groupBox2.TabIndex = 275;
            groupBox2.TabStop = false;
            groupBox2.Text = "계약 상품";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(111, 356);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ScrollBars = ScrollBars.Vertical;
            textBox8.Size = new Size(493, 47);
            textBox8.TabIndex = 316;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label71.Location = new Point(21, 356);
            label71.Name = "label71";
            label71.Size = new Size(84, 13);
            label71.TabIndex = 315;
            label71.Text = "마케터 메모 :";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(111, 303);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ScrollBars = ScrollBars.Vertical;
            textBox9.Size = new Size(493, 47);
            textBox9.TabIndex = 314;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label72.Location = new Point(21, 307);
            label72.Name = "label72";
            label72.Size = new Size(84, 13);
            label72.TabIndex = 313;
            label72.Text = "지원팀 메모 :";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(111, 197);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox7.Size = new Size(493, 73);
            textBox7.TabIndex = 312;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label70.Location = new Point(51, 200);
            label70.Name = "label70";
            label70.Size = new Size(54, 13);
            label70.TabIndex = 311;
            label70.Text = "비고란 :";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label45.Location = new Point(396, 54);
            label45.Name = "label45";
            label45.Size = new Size(46, 13);
            label45.TabIndex = 308;
            label45.Text = "꽃순이";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label44.Location = new Point(360, 54);
            label44.Name = "label44";
            label44.Size = new Size(41, 13);
            label44.TabIndex = 307;
            label44.Text = "이관 :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Blue;
            label14.Location = new Point(396, 167);
            label14.Name = "label14";
            label14.Size = new Size(34, 13);
            label14.TabIndex = 304;
            label14.Text = "90일";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(332, 167);
            label28.Name = "label28";
            label28.Size = new Size(67, 13);
            label28.TabIndex = 303;
            label28.Text = "계약일수 :";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label42.Location = new Point(197, 54);
            label42.Name = "label42";
            label42.Size = new Size(46, 13);
            label42.TabIndex = 298;
            label42.Text = "비비비";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label43.Location = new Point(134, 54);
            label43.Name = "label43";
            label43.Size = new Size(67, 13);
            label43.TabIndex = 297;
            label43.Text = "계약사원 :";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label48.ForeColor = Color.Blue;
            label48.Location = new Point(197, 112);
            label48.Name = "label48";
            label48.Size = new Size(72, 13);
            label48.TabIndex = 296;
            label48.Text = "인기더오름";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label49.Location = new Point(146, 112);
            label49.Name = "label49";
            label49.Size = new Size(54, 13);
            label49.TabIndex = 295;
            label49.Text = "상품명 :";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label50.Location = new Point(198, 140);
            label50.Name = "label50";
            label50.Size = new Size(278, 13);
            label50.TabIndex = 294;
            label50.Text = "광고집행전: 계정 활성화 및 최적화 서비스제공";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label51.Location = new Point(134, 140);
            label51.Name = "label51";
            label51.Size = new Size(67, 13);
            label51.TabIndex = 293;
            label51.Text = "상품상세 :";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label52.Location = new Point(396, 83);
            label52.Name = "label52";
            label52.Size = new Size(85, 13);
            label52.TabIndex = 292;
            label52.Text = "주안눈썹문신";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label53.Location = new Point(345, 83);
            label53.Name = "label53";
            label53.Size = new Size(54, 13);
            label53.TabIndex = 291;
            label53.Text = "키워드 :";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label54.ForeColor = Color.Blue;
            label54.Location = new Point(196, 167);
            label54.Name = "label54";
            label54.Size = new Size(81, 13);
            label54.TabIndex = 290;
            label54.Text = "1,320,000 원";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label55.Location = new Point(159, 167);
            label55.Name = "label55";
            label55.Size = new Size(41, 13);
            label55.TabIndex = 289;
            label55.Text = "금액 :";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label64.Location = new Point(396, 24);
            label64.Name = "label64";
            label64.Size = new Size(77, 13);
            label64.TabIndex = 280;
            label64.Text = "2022-10-10";
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label65.Location = new Point(332, 24);
            label65.Name = "label65";
            label65.Size = new Size(67, 13);
            label65.TabIndex = 279;
            label65.Text = "실행날짜 :";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label66.Location = new Point(197, 83);
            label66.Name = "label66";
            label66.Size = new Size(33, 13);
            label66.TabIndex = 278;
            label66.Text = "관리";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.FlatStyle = FlatStyle.Flat;
            label67.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label67.Location = new Point(198, 24);
            label67.Name = "label67";
            label67.Size = new Size(33, 13);
            label67.TabIndex = 277;
            label67.Text = "신규";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label68.Location = new Point(133, 83);
            label68.Name = "label68";
            label68.Size = new Size(67, 13);
            label68.TabIndex = 276;
            label68.Text = "상품구분 :";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label69.Location = new Point(134, 24);
            label69.Name = "label69";
            label69.Size = new Size(67, 13);
            label69.TabIndex = 275;
            label69.Text = "계약구분 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Red;
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(567, 19);
            label8.Name = "label8";
            label8.Size = new Size(46, 13);
            label8.TabIndex = 186;
            label8.Text = "올에즈";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(0, 192, 0);
            label25.Location = new Point(524, 19);
            label25.Name = "label25";
            label25.Size = new Size(46, 13);
            label25.TabIndex = 185;
            label25.Text = "더오름";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(585, 531);
            label36.Name = "label36";
            label36.Size = new Size(20, 13);
            label36.TabIndex = 169;
            label36.Text = "원";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(584, 502);
            label35.Name = "label35";
            label35.Size = new Size(20, 13);
            label35.TabIndex = 168;
            label35.Text = "원";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(296, 532);
            label34.Name = "label34";
            label34.Size = new Size(20, 13);
            label34.TabIndex = 167;
            label34.Text = "원";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(296, 502);
            label33.Name = "label33";
            label33.Size = new Size(20, 13);
            label33.TabIndex = 166;
            label33.Text = "원";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(585, 561);
            label32.Name = "label32";
            label32.Size = new Size(20, 13);
            label32.TabIndex = 165;
            label32.Text = "원";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ImeMode = ImeMode.Hangul;
            textBox6.Location = new Point(409, 558);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.MaxLength = 5;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(170, 22);
            textBox6.TabIndex = 164;
            textBox6.TabStop = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(336, 561);
            label31.Name = "label31";
            label31.Size = new Size(67, 13);
            label31.TabIndex = 163;
            label31.Text = "영업이익 :";
            label31.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ImeMode = ImeMode.Hangul;
            textBox5.Location = new Point(409, 528);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.MaxLength = 5;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(170, 22);
            textBox5.TabIndex = 162;
            textBox5.TabStop = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(323, 532);
            label26.Name = "label26";
            label26.Size = new Size(80, 13);
            label26.TabIndex = 161;
            label26.Text = "매출이익률 :";
            label26.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ImeMode = ImeMode.Hangul;
            textBox4.Location = new Point(117, 529);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.MaxLength = 5;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(170, 22);
            textBox4.TabIndex = 160;
            textBox4.TabStop = false;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(45, 532);
            label24.Name = "label24";
            label24.Size = new Size(67, 13);
            label24.TabIndex = 159;
            label24.Text = "매출이익 :";
            label24.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ImeMode = ImeMode.Hangul;
            textBox3.Location = new Point(408, 499);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.MaxLength = 5;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(170, 22);
            textBox3.TabIndex = 158;
            textBox3.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(337, 502);
            label23.Name = "label23";
            label23.Size = new Size(67, 13);
            label23.TabIndex = 157;
            label23.Text = "실행원가 :";
            label23.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ImeMode = ImeMode.Hangul;
            textBox2.Location = new Point(117, 499);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(170, 22);
            textBox2.TabIndex = 156;
            textBox2.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(44, 503);
            label22.Name = "label22";
            label22.Size = new Size(67, 13);
            label22.TabIndex = 155;
            label22.Text = "매출합계 :";
            label22.TextAlign = ContentAlignment.TopRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(18, 591);
            label19.Name = "label19";
            label19.Size = new Size(93, 13);
            label19.TabIndex = 154;
            label19.Text = "현재진행상품 :";
            // 
            // label21
            // 
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(59, 23);
            label21.TabIndex = 3;
            label21.Text = "업체정보";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ImeMode = ImeMode.Hangul;
            textBox1.Location = new Point(117, 588);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.MaxLength = 50;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(493, 84);
            textBox1.TabIndex = 153;
            textBox1.Text = "인기더오름50\r\n한국인리얼봇팔로워\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_InstagramClipboard
            // 
            btn_InstagramClipboard.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_InstagramClipboard.Location = new Point(533, 374);
            btn_InstagramClipboard.Margin = new Padding(3, 4, 3, 4);
            btn_InstagramClipboard.Name = "btn_InstagramClipboard";
            btn_InstagramClipboard.Size = new Size(76, 29);
            btn_InstagramClipboard.TabIndex = 151;
            btn_InstagramClipboard.Text = "복사";
            btn_InstagramClipboard.UseVisualStyleBackColor = true;
            // 
            // btn_InstagramOpen
            // 
            btn_InstagramOpen.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_InstagramOpen.Location = new Point(451, 373);
            btn_InstagramOpen.Margin = new Padding(3, 4, 3, 4);
            btn_InstagramOpen.Name = "btn_InstagramOpen";
            btn_InstagramOpen.Size = new Size(76, 29);
            btn_InstagramOpen.TabIndex = 15;
            btn_InstagramOpen.Text = "열기(&O)";
            btn_InstagramOpen.UseVisualStyleBackColor = true;
            // 
            // btn_BlogOpen
            // 
            btn_BlogOpen.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BlogOpen.Location = new Point(533, 338);
            btn_BlogOpen.Margin = new Padding(3, 4, 3, 4);
            btn_BlogOpen.Name = "btn_BlogOpen";
            btn_BlogOpen.Size = new Size(76, 29);
            btn_BlogOpen.TabIndex = 13;
            btn_BlogOpen.Text = "열기";
            btn_BlogOpen.UseVisualStyleBackColor = true;
            // 
            // btn_HomepageOpen
            // 
            btn_HomepageOpen.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_HomepageOpen.Location = new Point(533, 303);
            btn_HomepageOpen.Margin = new Padding(3, 4, 3, 4);
            btn_HomepageOpen.Name = "btn_HomepageOpen";
            btn_HomepageOpen.Size = new Size(76, 29);
            btn_HomepageOpen.TabIndex = 11;
            btn_HomepageOpen.Text = "열기";
            btn_HomepageOpen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(470, 1210);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 33;
            button1.Text = "계약 상세";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // btn_ContractEndDayOneMonth
            // 
            btn_ContractEndDayOneMonth.Cursor = Cursors.Hand;
            btn_ContractEndDayOneMonth.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ContractEndDayOneMonth.Location = new Point(533, 680);
            btn_ContractEndDayOneMonth.Margin = new Padding(3, 4, 3, 4);
            btn_ContractEndDayOneMonth.Name = "btn_ContractEndDayOneMonth";
            btn_ContractEndDayOneMonth.Size = new Size(76, 29);
            btn_ContractEndDayOneMonth.TabIndex = 22;
            btn_ContractEndDayOneMonth.Text = "연장";
            btn_ContractEndDayOneMonth.UseVisualStyleBackColor = true;
            // 
            // btn_WorkerTeamListUpdate
            // 
            btn_WorkerTeamListUpdate.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_WorkerTeamListUpdate.Location = new Point(241, 148);
            btn_WorkerTeamListUpdate.Margin = new Padding(3, 4, 3, 4);
            btn_WorkerTeamListUpdate.Name = "btn_WorkerTeamListUpdate";
            btn_WorkerTeamListUpdate.Size = new Size(76, 29);
            btn_WorkerTeamListUpdate.TabIndex = 149;
            btn_WorkerTeamListUpdate.Text = "새로고침";
            btn_WorkerTeamListUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_WorkerNameListUpdate
            // 
            btn_WorkerNameListUpdate.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_WorkerNameListUpdate.Location = new Point(241, 184);
            btn_WorkerNameListUpdate.Margin = new Padding(3, 4, 3, 4);
            btn_WorkerNameListUpdate.Name = "btn_WorkerNameListUpdate";
            btn_WorkerNameListUpdate.Size = new Size(76, 29);
            btn_WorkerNameListUpdate.TabIndex = 148;
            btn_WorkerNameListUpdate.Text = "새로고침";
            btn_WorkerNameListUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBox_WorkerTeam
            // 
            comboBox_WorkerTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_WorkerTeam.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_WorkerTeam.FormattingEnabled = true;
            comboBox_WorkerTeam.Location = new Point(117, 150);
            comboBox_WorkerTeam.Margin = new Padding(3, 4, 3, 4);
            comboBox_WorkerTeam.Name = "comboBox_WorkerTeam";
            comboBox_WorkerTeam.Size = new Size(118, 21);
            comboBox_WorkerTeam.TabIndex = 147;
            // 
            // comboBox_WorkerName
            // 
            comboBox_WorkerName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_WorkerName.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_WorkerName.FormattingEnabled = true;
            comboBox_WorkerName.Location = new Point(117, 184);
            comboBox_WorkerName.Margin = new Padding(3, 4, 3, 4);
            comboBox_WorkerName.Name = "comboBox_WorkerName";
            comboBox_WorkerName.Size = new Size(118, 21);
            comboBox_WorkerName.TabIndex = 146;
            // 
            // comboBox_CusRoute
            // 
            comboBox_CusRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CusRoute.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CusRoute.FormattingEnabled = true;
            comboBox_CusRoute.Items.AddRange(new object[] { "인바운드", "아웃바운드", "세미나", "기존", "소개", "핫셀러", "애드픽", "기타" });
            comboBox_CusRoute.Location = new Point(117, 116);
            comboBox_CusRoute.Margin = new Padding(3, 4, 3, 4);
            comboBox_CusRoute.Name = "comboBox_CusRoute";
            comboBox_CusRoute.Size = new Size(200, 21);
            comboBox_CusRoute.TabIndex = 145;
            // 
            // dateTimePicker_ContractEndDay
            // 
            dateTimePicker_ContractEndDay.Checked = false;
            dateTimePicker_ContractEndDay.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_ContractEndDay.Format = DateTimePickerFormat.Short;
            dateTimePicker_ContractEndDay.Location = new Point(409, 682);
            dateTimePicker_ContractEndDay.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_ContractEndDay.Name = "dateTimePicker_ContractEndDay";
            dateTimePicker_ContractEndDay.Size = new Size(118, 22);
            dateTimePicker_ContractEndDay.TabIndex = 21;
            dateTimePicker_ContractEndDay.Value = new DateTime(2022, 10, 7, 16, 41, 8, 0);
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(322, 686);
            label27.Name = "label27";
            label27.Size = new Size(80, 13);
            label27.TabIndex = 106;
            label27.Text = "상품종료일 :";
            label27.TextAlign = ContentAlignment.TopRight;
            // 
            // txt_BusinessInstagram
            // 
            txt_BusinessInstagram.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessInstagram.ImeMode = ImeMode.Hangul;
            txt_BusinessInstagram.Location = new Point(117, 373);
            txt_BusinessInstagram.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessInstagram.MaxLength = 100;
            txt_BusinessInstagram.Name = "txt_BusinessInstagram";
            txt_BusinessInstagram.Size = new Size(328, 22);
            txt_BusinessInstagram.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(13, 376);
            label18.Name = "label18";
            label18.Size = new Size(97, 13);
            label18.TabIndex = 93;
            label18.Text = "기타채널 주소 :";
            // 
            // txt_BusinessBlog
            // 
            txt_BusinessBlog.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessBlog.ImeMode = ImeMode.Hangul;
            txt_BusinessBlog.Location = new Point(117, 338);
            txt_BusinessBlog.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessBlog.MaxLength = 100;
            txt_BusinessBlog.Name = "txt_BusinessBlog";
            txt_BusinessBlog.Size = new Size(410, 22);
            txt_BusinessBlog.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(27, 344);
            label17.Name = "label17";
            label17.Size = new Size(84, 13);
            label17.TabIndex = 91;
            label17.Text = "블로그 주소 :";
            // 
            // txt_BusinessHomepage
            // 
            txt_BusinessHomepage.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessHomepage.ImeMode = ImeMode.Hangul;
            txt_BusinessHomepage.Location = new Point(117, 303);
            txt_BusinessHomepage.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessHomepage.MaxLength = 100;
            txt_BusinessHomepage.Name = "txt_BusinessHomepage";
            txt_BusinessHomepage.Size = new Size(410, 22);
            txt_BusinessHomepage.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 311);
            label10.Name = "label10";
            label10.Size = new Size(80, 13);
            label10.TabIndex = 89;
            label10.Text = "인스타그램 :";
            // 
            // txt_BusinessPeriod
            // 
            txt_BusinessPeriod.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessPeriod.ImeMode = ImeMode.Hangul;
            txt_BusinessPeriod.Location = new Point(409, 216);
            txt_BusinessPeriod.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessPeriod.MaxLength = 50;
            txt_BusinessPeriod.Name = "txt_BusinessPeriod";
            txt_BusinessPeriod.Size = new Size(200, 22);
            txt_BusinessPeriod.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(350, 220);
            label9.Name = "label9";
            label9.Size = new Size(54, 13);
            label9.TabIndex = 87;
            label9.Text = "이메일 :";
            // 
            // txt_BusinessPlace
            // 
            txt_BusinessPlace.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessPlace.ImeMode = ImeMode.Hangul;
            txt_BusinessPlace.Location = new Point(515, 259);
            txt_BusinessPlace.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessPlace.MaxLength = 50;
            txt_BusinessPlace.Name = "txt_BusinessPlace";
            txt_BusinessPlace.Size = new Size(94, 22);
            txt_BusinessPlace.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(468, 262);
            label7.Name = "label7";
            label7.Size = new Size(41, 13);
            label7.TabIndex = 83;
            label7.Text = "지역 :";
            // 
            // txt_BusinessType
            // 
            txt_BusinessType.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessType.ImeMode = ImeMode.Hangul;
            txt_BusinessType.Location = new Point(117, 221);
            txt_BusinessType.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessType.MaxLength = 15;
            txt_BusinessType.Name = "txt_BusinessType";
            txt_BusinessType.Size = new Size(199, 22);
            txt_BusinessType.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(70, 225);
            label6.Name = "label6";
            label6.Size = new Size(41, 13);
            label6.TabIndex = 81;
            label6.Text = "업종 :";
            // 
            // comboBox_CusChannel
            // 
            comboBox_CusChannel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CusChannel.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CusChannel.FormattingEnabled = true;
            comboBox_CusChannel.Items.AddRange(new object[] { "더나인", "더오름", "올에즈", "유선", "DM", "상담유형-콜", "상담유형-톡", "기타" });
            comboBox_CusChannel.Location = new Point(409, 116);
            comboBox_CusChannel.Margin = new Padding(3, 4, 3, 4);
            comboBox_CusChannel.Name = "comboBox_CusChannel";
            comboBox_CusChannel.Size = new Size(200, 21);
            comboBox_CusChannel.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(362, 120);
            label5.Name = "label5";
            label5.Size = new Size(41, 13);
            label5.TabIndex = 78;
            label5.Text = "채널 :";
            // 
            // txt_CusTel
            // 
            txt_CusTel.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CusTel.ImeMode = ImeMode.Hangul;
            txt_CusTel.Location = new Point(409, 151);
            txt_CusTel.Margin = new Padding(3, 4, 3, 4);
            txt_CusTel.MaxLength = 20;
            txt_CusTel.Name = "txt_CusTel";
            txt_CusTel.Size = new Size(200, 22);
            txt_CusTel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(329, 154);
            label4.Name = "label4";
            label4.Size = new Size(74, 13);
            label4.TabIndex = 77;
            label4.Text = "전화번호1 :";
            // 
            // txt_CusName
            // 
            txt_CusName.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CusName.ImeMode = ImeMode.Hangul;
            txt_CusName.Location = new Point(409, 83);
            txt_CusName.Margin = new Padding(3, 4, 3, 4);
            txt_CusName.MaxLength = 20;
            txt_CusName.Name = "txt_CusName";
            txt_CusName.Size = new Size(200, 22);
            txt_CusName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(336, 87);
            label3.Name = "label3";
            label3.Size = new Size(67, 13);
            label3.TabIndex = 74;
            label3.Text = "고객성함 :";
            // 
            // txt_BusinessName
            // 
            txt_BusinessName.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusinessName.ImeMode = ImeMode.Hangul;
            txt_BusinessName.Location = new Point(117, 83);
            txt_BusinessName.Margin = new Padding(3, 4, 3, 4);
            txt_BusinessName.MaxLength = 20;
            txt_BusinessName.Name = "txt_BusinessName";
            txt_BusinessName.Size = new Size(199, 22);
            txt_BusinessName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 86);
            label2.Name = "label2";
            label2.Size = new Size(41, 13);
            label2.TabIndex = 72;
            label2.Text = "상호 :";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 156);
            label1.Name = "label1";
            label1.Size = new Size(67, 13);
            label1.TabIndex = 45;
            label1.Text = "담당파트 :";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(45, 187);
            label20.Name = "label20";
            label20.Size = new Size(67, 13);
            label20.TabIndex = 43;
            label20.Text = "관리사원 :";
            label20.TextAlign = ContentAlignment.TopRight;
            // 
            // txt_RegiDate
            // 
            txt_RegiDate.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_RegiDate.ImeMode = ImeMode.Hangul;
            txt_RegiDate.Location = new Point(409, 47);
            txt_RegiDate.Margin = new Padding(3, 4, 3, 4);
            txt_RegiDate.MaxLength = 5;
            txt_RegiDate.Name = "txt_RegiDate";
            txt_RegiDate.ReadOnly = true;
            txt_RegiDate.Size = new Size(200, 22);
            txt_RegiDate.TabIndex = 42;
            txt_RegiDate.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(348, 51);
            label16.Name = "label16";
            label16.Size = new Size(54, 13);
            label16.TabIndex = 41;
            label16.Text = "등록일 :";
            label16.TextAlign = ContentAlignment.TopRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(44, 120);
            label15.Name = "label15";
            label15.Size = new Size(67, 13);
            label15.TabIndex = 40;
            label15.Text = "유입경로 :";
            label15.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox_CusState
            // 
            comboBox_CusState.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CusState.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CusState.FormattingEnabled = true;
            comboBox_CusState.Items.AddRange(new object[] { "확인필", "미수금", "미진행", "일시정지", "진행", "종료" });
            comboBox_CusState.Location = new Point(117, 48);
            comboBox_CusState.Margin = new Padding(3, 4, 3, 4);
            comboBox_CusState.Name = "comboBox_CusState";
            comboBox_CusState.Size = new Size(200, 21);
            comboBox_CusState.TabIndex = 1;
            comboBox_CusState.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(44, 52);
            label11.Name = "label11";
            label11.Size = new Size(67, 13);
            label11.TabIndex = 38;
            label11.Text = "진행현황 :";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Save.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Location = new Point(6, 1210);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(150, 38);
            btn_Save.TabIndex = 30;
            btn_Save.Text = "정보 저장(&S)";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox_CusList, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox_Memo, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(635, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 312F));
            tableLayoutPanel2.Size = new Size(1224, 1183);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 180);
            panel1.TabIndex = 60;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox10);
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox_WorkerSort);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1211, 176);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(comboBox_CusRouteSort);
            groupBox10.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox10.Location = new Point(235, 99);
            groupBox10.Margin = new Padding(3, 4, 3, 4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 4, 3, 4);
            groupBox10.Size = new Size(212, 69);
            groupBox10.TabIndex = 74;
            groupBox10.TabStop = false;
            groupBox10.Text = "유입경로 정렬";
            // 
            // comboBox_CusRouteSort
            // 
            comboBox_CusRouteSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CusRouteSort.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CusRouteSort.FormattingEnabled = true;
            comboBox_CusRouteSort.Items.AddRange(new object[] { "전체보기", "인바운드", "아웃바운드", "세미나", "기존", "소개", "핫셀러", "애드픽", "더나인", "더오름", "올에즈", "유선", "DM", "기타" });
            comboBox_CusRouteSort.Location = new Point(6, 26);
            comboBox_CusRouteSort.Margin = new Padding(3, 4, 3, 4);
            comboBox_CusRouteSort.Name = "comboBox_CusRouteSort";
            comboBox_CusRouteSort.Size = new Size(200, 21);
            comboBox_CusRouteSort.TabIndex = 45;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(button2);
            groupBox8.Controls.Add(dateTimePicker2);
            groupBox8.Controls.Add(dateTimePicker1);
            groupBox8.Controls.Add(label13);
            groupBox8.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.Location = new Point(505, 99);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(427, 69);
            groupBox8.TabIndex = 66;
            groupBox8.TabStop = false;
            groupBox8.Text = "검색";
            // 
            // button2
            // 
            button2.Location = new Point(318, 22);
            button2.Name = "button2";
            button2.Size = new Size(83, 26);
            button2.TabIndex = 73;
            button2.Text = "검색";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(163, 25);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(118, 22);
            dateTimePicker2.TabIndex = 59;
            dateTimePicker2.Value = new DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(16, 26);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(118, 22);
            dateTimePicker1.TabIndex = 59;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(140, 29);
            label13.Name = "label13";
            label13.Size = new Size(17, 13);
            label13.TabIndex = 72;
            label13.Text = "~";
            label13.TextAlign = ContentAlignment.TopRight;
            label13.Click += label13_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_리5달12달);
            groupBox5.Controls.Add(btn_리2달4주);
            groupBox5.Controls.Add(btn_리3주8주);
            groupBox5.Controls.Add(btn_리1주2주);
            groupBox5.Controls.Add(btn_미처리);
            groupBox5.Controls.Add(btn_계약완료);
            groupBox5.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(573, 19);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(632, 69);
            groupBox5.TabIndex = 65;
            groupBox5.TabStop = false;
            groupBox5.Text = "간편 정렬";
            // 
            // btn_리5달12달
            // 
            btn_리5달12달.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_리5달12달.Location = new Point(491, 26);
            btn_리5달12달.Margin = new Padding(3, 4, 3, 4);
            btn_리5달12달.Name = "btn_리5달12달";
            btn_리5달12달.Size = new Size(91, 29);
            btn_리5달12달.TabIndex = 53;
            btn_리5달12달.Text = "종료";
            btn_리5달12달.UseVisualStyleBackColor = true;
            // 
            // btn_리2달4주
            // 
            btn_리2달4주.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_리2달4주.Location = new Point(394, 26);
            btn_리2달4주.Margin = new Padding(3, 4, 3, 4);
            btn_리2달4주.Name = "btn_리2달4주";
            btn_리2달4주.Size = new Size(91, 29);
            btn_리2달4주.TabIndex = 52;
            btn_리2달4주.Text = "진행";
            btn_리2달4주.UseVisualStyleBackColor = true;
            // 
            // btn_리3주8주
            // 
            btn_리3주8주.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_리3주8주.Location = new Point(297, 26);
            btn_리3주8주.Margin = new Padding(3, 4, 3, 4);
            btn_리3주8주.Name = "btn_리3주8주";
            btn_리3주8주.Size = new Size(91, 29);
            btn_리3주8주.TabIndex = 51;
            btn_리3주8주.Text = "일시정지";
            btn_리3주8주.UseVisualStyleBackColor = true;
            // 
            // btn_리1주2주
            // 
            btn_리1주2주.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_리1주2주.Location = new Point(200, 26);
            btn_리1주2주.Margin = new Padding(3, 4, 3, 4);
            btn_리1주2주.Name = "btn_리1주2주";
            btn_리1주2주.Size = new Size(91, 29);
            btn_리1주2주.TabIndex = 50;
            btn_리1주2주.Text = "미진행";
            btn_리1주2주.UseVisualStyleBackColor = true;
            // 
            // btn_미처리
            // 
            btn_미처리.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_미처리.Location = new Point(6, 26);
            btn_미처리.Margin = new Padding(3, 4, 3, 4);
            btn_미처리.Name = "btn_미처리";
            btn_미처리.Size = new Size(91, 29);
            btn_미처리.TabIndex = 47;
            btn_미처리.Text = "확인필";
            btn_미처리.UseVisualStyleBackColor = true;
            // 
            // btn_계약완료
            // 
            btn_계약완료.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_계약완료.Location = new Point(103, 26);
            btn_계약완료.Margin = new Padding(3, 4, 3, 4);
            btn_계약완료.Name = "btn_계약완료";
            btn_계약완료.Size = new Size(91, 29);
            btn_계약완료.TabIndex = 46;
            btn_계약완료.Text = "미수금";
            btn_계약완료.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_Search);
            groupBox4.Controls.Add(txt_Search);
            groupBox4.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(6, 19);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(241, 69);
            groupBox4.TabIndex = 41;
            groupBox4.TabStop = false;
            groupBox4.Text = "상호/성함/전화 검색 (F2)";
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.Location = new Point(167, 26);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(68, 28);
            btn_Search.TabIndex = 43;
            btn_Search.Text = "검색";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.ImeMode = ImeMode.Hangul;
            txt_Search.Location = new Point(6, 26);
            txt_Search.Margin = new Padding(3, 4, 3, 4);
            txt_Search.MaxLength = 20;
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(155, 22);
            txt_Search.TabIndex = 42;
            // 
            // groupBox_WorkerSort
            // 
            groupBox_WorkerSort.Controls.Add(btn_WorkerSortRefresh);
            groupBox_WorkerSort.Controls.Add(comboBox_WorkerSort);
            groupBox_WorkerSort.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_WorkerSort.Location = new Point(6, 99);
            groupBox_WorkerSort.Margin = new Padding(3, 4, 3, 4);
            groupBox_WorkerSort.Name = "groupBox_WorkerSort";
            groupBox_WorkerSort.Padding = new Padding(3, 4, 3, 4);
            groupBox_WorkerSort.Size = new Size(223, 69);
            groupBox_WorkerSort.TabIndex = 47;
            groupBox_WorkerSort.TabStop = false;
            groupBox_WorkerSort.Text = "담당자 정렬";
            // 
            // btn_WorkerSortRefresh
            // 
            btn_WorkerSortRefresh.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_WorkerSortRefresh.Location = new Point(141, 24);
            btn_WorkerSortRefresh.Margin = new Padding(3, 4, 3, 4);
            btn_WorkerSortRefresh.Name = "btn_WorkerSortRefresh";
            btn_WorkerSortRefresh.Size = new Size(76, 29);
            btn_WorkerSortRefresh.TabIndex = 49;
            btn_WorkerSortRefresh.Text = "새로고침";
            btn_WorkerSortRefresh.UseVisualStyleBackColor = true;
            // 
            // comboBox_WorkerSort
            // 
            comboBox_WorkerSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_WorkerSort.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_WorkerSort.FormattingEnabled = true;
            comboBox_WorkerSort.Items.AddRange(new object[] { "전체보기" });
            comboBox_WorkerSort.Location = new Point(6, 26);
            comboBox_WorkerSort.Margin = new Padding(3, 4, 3, 4);
            comboBox_WorkerSort.Name = "comboBox_WorkerSort";
            comboBox_WorkerSort.Size = new Size(126, 21);
            comboBox_WorkerSort.TabIndex = 48;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_LvRefresh);
            groupBox6.Controls.Add(comboBox_CusStateSort);
            groupBox6.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(259, 19);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(308, 69);
            groupBox6.TabIndex = 44;
            groupBox6.TabStop = false;
            groupBox6.Text = "진행현황 정렬";
            // 
            // btn_LvRefresh
            // 
            btn_LvRefresh.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LvRefresh.Location = new Point(189, 25);
            btn_LvRefresh.Margin = new Padding(3, 4, 3, 4);
            btn_LvRefresh.Name = "btn_LvRefresh";
            btn_LvRefresh.Size = new Size(113, 29);
            btn_LvRefresh.TabIndex = 46;
            btn_LvRefresh.Text = "새로고침(F5)";
            btn_LvRefresh.UseVisualStyleBackColor = true;
            // 
            // comboBox_CusStateSort
            // 
            comboBox_CusStateSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CusStateSort.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CusStateSort.FormattingEnabled = true;
            comboBox_CusStateSort.Items.AddRange(new object[] { "확인필", "미수금", "미진행", "일시정지", "진행", "종료" });
            comboBox_CusStateSort.Location = new Point(6, 26);
            comboBox_CusStateSort.Margin = new Padding(3, 4, 3, 4);
            comboBox_CusStateSort.Name = "comboBox_CusStateSort";
            comboBox_CusStateSort.Size = new Size(177, 21);
            comboBox_CusStateSort.TabIndex = 45;
            // 
            // groupBox_CusList
            // 
            groupBox_CusList.Controls.Add(panel_Loading);
            groupBox_CusList.Controls.Add(listView_Main);
            groupBox_CusList.Dock = DockStyle.Fill;
            groupBox_CusList.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_CusList.Location = new Point(3, 192);
            groupBox_CusList.Margin = new Padding(3, 4, 3, 4);
            groupBox_CusList.Name = "groupBox_CusList";
            groupBox_CusList.Padding = new Padding(3, 4, 3, 4);
            groupBox_CusList.Size = new Size(1218, 675);
            groupBox_CusList.TabIndex = 80;
            groupBox_CusList.TabStop = false;
            groupBox_CusList.Text = "계약 목록";
            groupBox_CusList.Enter += groupBox_CusList_Enter;
            // 
            // panel_Loading
            // 
            panel_Loading.Controls.Add(label41);
            panel_Loading.Controls.Add(progressBar_Loading);
            panel_Loading.Location = new Point(411, 239);
            panel_Loading.Margin = new Padding(3, 4, 3, 4);
            panel_Loading.Name = "panel_Loading";
            panel_Loading.Size = new Size(350, 106);
            panel_Loading.TabIndex = 58;
            // 
            // label41
            // 
            label41.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label41.Location = new Point(3, 19);
            label41.Name = "label41";
            label41.Size = new Size(343, 29);
            label41.TabIndex = 0;
            label41.Text = "데이터를 받아오는 중입니다. 잠시만 기다려 주세요";
            label41.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar_Loading
            // 
            progressBar_Loading.Location = new Point(27, 51);
            progressBar_Loading.Margin = new Padding(3, 4, 3, 4);
            progressBar_Loading.Maximum = 10000;
            progressBar_Loading.Name = "progressBar_Loading";
            progressBar_Loading.Size = new Size(297, 29);
            progressBar_Loading.TabIndex = 53;
            // 
            // listView_Main
            // 
            listView_Main.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader18, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader19, columnHeader20, columnHeader21 });
            listView_Main.Dock = DockStyle.Fill;
            listView_Main.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView_Main.FullRowSelect = true;
            listView_Main.GridLines = true;
            listView_Main.Location = new Point(3, 19);
            listView_Main.MultiSelect = false;
            listView_Main.Name = "listView_Main";
            listView_Main.Size = new Size(1212, 652);
            listView_Main.TabIndex = 81;
            listView_Main.UseCompatibleStateImageBehavior = false;
            listView_Main.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Id";
            columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "등록일";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 105;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "만료일";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 85;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "수금일";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 55;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "상호";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 120;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "업종";
            columnHeader18.TextAlign = HorizontalAlignment.Center;
            columnHeader18.Width = 90;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "고객성함";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "직함";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 70;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "전화번호";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 110;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "상품유형";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "월예산";
            columnHeader17.TextAlign = HorizontalAlignment.Center;
            columnHeader17.Width = 90;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "담당팀";
            columnHeader19.TextAlign = HorizontalAlignment.Center;
            columnHeader19.Width = 90;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "담당자";
            columnHeader20.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "진행현황";
            columnHeader21.TextAlign = HorizontalAlignment.Center;
            columnHeader21.Width = 140;
            // 
            // groupBox_Memo
            // 
            groupBox_Memo.Controls.Add(btn_HistoryInput);
            groupBox_Memo.Controls.Add(txt_HistoryInput);
            groupBox_Memo.Controls.Add(label12);
            groupBox_Memo.Controls.Add(txt_HistoryLog);
            groupBox_Memo.Dock = DockStyle.Fill;
            groupBox_Memo.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Memo.Location = new Point(3, 875);
            groupBox_Memo.Margin = new Padding(3, 4, 3, 4);
            groupBox_Memo.Name = "groupBox_Memo";
            groupBox_Memo.Padding = new Padding(3, 4, 3, 4);
            groupBox_Memo.Size = new Size(1218, 304);
            groupBox_Memo.TabIndex = 90;
            groupBox_Memo.TabStop = false;
            groupBox_Memo.Text = "상담이력";
            // 
            // btn_HistoryInput
            // 
            btn_HistoryInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_HistoryInput.Cursor = Cursors.Hand;
            btn_HistoryInput.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_HistoryInput.Location = new Point(1124, 260);
            btn_HistoryInput.Margin = new Padding(3, 4, 3, 4);
            btn_HistoryInput.Name = "btn_HistoryInput";
            btn_HistoryInput.Size = new Size(87, 28);
            btn_HistoryInput.TabIndex = 93;
            btn_HistoryInput.Text = "입력";
            btn_HistoryInput.UseVisualStyleBackColor = true;
            // 
            // txt_HistoryInput
            // 
            txt_HistoryInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_HistoryInput.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_HistoryInput.ImeMode = ImeMode.Hangul;
            txt_HistoryInput.Location = new Point(111, 261);
            txt_HistoryInput.Margin = new Padding(3, 4, 3, 4);
            txt_HistoryInput.MaxLength = 200;
            txt_HistoryInput.Name = "txt_HistoryInput";
            txt_HistoryInput.Size = new Size(1007, 22);
            txt_HistoryInput.TabIndex = 92;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 266);
            label12.Name = "label12";
            label12.Size = new Size(99, 13);
            label12.TabIndex = 28;
            label12.Text = "이력 입력 (F3) :";
            // 
            // txt_HistoryLog
            // 
            txt_HistoryLog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_HistoryLog.BackColor = SystemColors.Control;
            txt_HistoryLog.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_HistoryLog.ImeMode = ImeMode.Hangul;
            txt_HistoryLog.Location = new Point(6, 26);
            txt_HistoryLog.Margin = new Padding(3, 4, 3, 4);
            txt_HistoryLog.Multiline = true;
            txt_HistoryLog.Name = "txt_HistoryLog";
            txt_HistoryLog.ReadOnly = true;
            txt_HistoryLog.ScrollBars = ScrollBars.Vertical;
            txt_HistoryLog.Size = new Size(1205, 225);
            txt_HistoryLog.TabIndex = 91;
            txt_HistoryLog.TabStop = false;
            // 
            // tray_Open
            // 
            tray_Open.Name = "tray_Open";
            tray_Open.Size = new Size(98, 22);
            tray_Open.Text = "열기";
            // 
            // tray_Exit
            // 
            tray_Exit.Name = "tray_Exit";
            tray_Exit.Size = new Size(98, 22);
            tray_Exit.Text = "종료";
            // 
            // toolStripMenuItem_WorkerSet
            // 
            toolStripMenuItem_WorkerSet.Name = "toolStripMenuItem_WorkerSet";
            toolStripMenuItem_WorkerSet.Size = new Size(126, 22);
            toolStripMenuItem_WorkerSet.Text = "디비 분배";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 1273);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip_Main);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1200, 1178);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "더오름CRM";
            Load += Main_Load;
            toolStrip_Main.ResumeLayout(false);
            toolStrip_Main.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox_CusInfo.ResumeLayout(false);
            groupBox_CusInfo.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox_WorkerSort.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox_CusList.ResumeLayout(false);
            panel_Loading.ResumeLayout(false);
            groupBox_Memo.ResumeLayout(false);
            groupBox_Memo.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox groupBox8;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private GroupBox groupBox_CusInfo;
        private Label label8;
        private Label label25;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private TextBox textBox6;
        private Label label31;
        private TextBox textBox5;
        private Label label26;
        private TextBox textBox4;
        private Label label24;
        private TextBox textBox3;
        private Label label23;
        private TextBox textBox2;
        private Label label22;
        private Label label19;
        private Label label21;
        private TextBox textBox1;
        private Button btn_InstagramClipboard;
        private Button btn_InstagramOpen;
        private Button btn_BlogOpen;
        private Button btn_HomepageOpen;
        private Button button1;
        private Button btn_ContractEndDayOneMonth;
        private Button btn_WorkerTeamListUpdate;
        private Button btn_WorkerNameListUpdate;
        private ComboBox comboBox_WorkerTeam;
        private ComboBox comboBox_WorkerName;
        private ComboBox comboBox_CusRoute;
        private DateTimePicker dateTimePicker_ContractEndDay;
        private Label label27;
        private TextBox txt_BusinessInstagram;
        private Label label18;
        private TextBox txt_BusinessBlog;
        private Label label17;
        private TextBox txt_BusinessHomepage;
        private Label label10;
        private TextBox txt_BusinessPeriod;
        private Label label9;
        private Label label7;
        private TextBox txt_BusinessType;
        private Label label6;
        private ComboBox comboBox_CusChannel;
        private Label label5;
        private TextBox txt_CusTel;
        private Label label4;
        private TextBox txt_CusName;
        private Label label3;
        private TextBox txt_BusinessName;
        private Label label2;
        private Label label1;
        private Label label20;
        private TextBox txt_RegiDate;
        private Label label16;
        private Label label15;
        private ComboBox comboBox_CusState;
        private Label label11;
        private Button btn_Save;
        private GroupBox groupBox2;
        private Label label45;
        private Label label44;
        private Label label14;
        private Label label28;
        private Label label42;
        private Label label43;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private BackgroundWorker backgroundWorker1;
        private TextBox textBox7;
        private Label label70;
        private TextBox textBox8;
        private Label label71;
        private TextBox textBox9;
        private Label label72;
        private Button button3;
        private Button button4;
        private TextBox txt_BusinessPlace;
        private GroupBox groupBox3;
        private RadioButton radioButton_BmNull;
        private RadioButton radioButton_BmOnline;
        private RadioButton radioButton_BmOffline;
        private RadioButton radioButton_BmOnOff;
        private Label label29;
        private GroupBox groupBox7;
        private RadioButton radioButton_CusTypeIndividual;
        private RadioButton radioButton_CusTypeEntrepreneur;
        private RadioButton radioButton_CusTypeCorporation;
        private RadioButton radioButton_CusTypeGroup;
        private Label label30;
        private TextBox textBox10;
        private Label label37;
        private ToolStripButton btn_Consulting;
    }
}