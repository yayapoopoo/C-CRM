using System.ComponentModel;

namespace WinFormsApp3
{
    partial class SalesInfo
    {

        private bool bInput = false;
        private bool bList = false;
        private bool bGetList = false;
        private string Keyword = "없음";
        private string columnSort = "없음";
        private string columnSortType = "DESC";
        private IContainer components = (IContainer)null;
        private GroupBox groupBox8;
        private DateTimePicker dateTimePicker_ConfirmationDay;
        private GroupBox groupBox18;
        private ComboBox comboBox_SalesTeam;
        private GroupBox groupBox1;
        private ComboBox comboBox_SalesWorkerName;
        private GroupBox groupBox11;
        private TextBox txt_HIstory;
        private GroupBox groupBox2;
        private TextBox txt_BusinessName;
        private GroupBox groupBox12;
        private GroupBox groupBox3;
        private Label label1;
        private GroupBox groupBox4;
        private Label label2;
        private GroupBox groupBox5;
        private Label label3;
        private Button btn_SalesEdit;
        private Button btn_SalesAdd;
        private GroupBox groupBox6;
        private TextBox txt_FiexedAmountRateInput;
        private Label label4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GroupBox groupBox7;
        private TextBox txt_FiexedAmountRateTotal;
        private Label label5;
        private GroupBox groupBox9;
        private TextBox txt_FiexedAmountTotal;
        private Label label6;
        private GroupBox groupBox10;
        private TextBox txt_SalesProfitTotal;
        private Label label7;
        private GroupBox groupBox13;
        private TextBox txt_CostOfSalesTotal;
        private Label label8;
        private GroupBox groupBox14;
        private TextBox txt_SalesTotal;
        private Label label9;
        private GroupBox groupBox15;
        private Button btn_NextMonth;
        private Button btn_PreMonth;
        private DateTimePicker dateTimePicker_StartDay;
        private DateTimePicker dateTimePicker_LastDay;
        private Label label11;
        private GroupBox groupBox16;
        private Button btn_LvRefresh;
        private Button btn_Delete;
        private GroupBox groupBox17;
        private ComboBox comboBox_TeamSort;
        private GroupBox groupBox19;
        private ComboBox comboBox_WorkerNameSort;
        private ColumnHeader columnHeader11;
        private GroupBox groupBox20;
        private Button btn_Search;
        private TextBox txt_Search;
        private Label label12;
        private WebBrowser wb_Input;
        private NumericUpDown numericUpDown_SalesInput;
        private Label label10;
        private NumericUpDown numericUpDown_CostOfSalesInput;
        private NumericUpDown numericUpDown_FiexedAmountInput;
        private TextBox txt_SalesProfitInput;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private GroupBox groupBox_RouteSort;
        private ComboBox comboBox_RouteSort;
        private GroupBox groupBox21;
        private ComboBox comboBox_SalesTypeSort;
        private GroupBox groupBox_Route;
        private ComboBox comboBox_Route;
        private GroupBox groupBox22;
        private ComboBox comboBox_SalesType;
        private GroupBox groupBox23;
        private DateTimePicker dateTimePicker_FirstDate;
        private GroupBox groupBox24;
        private DateTimePicker dateTimePicker_FirstDateStartDay;
        private DateTimePicker dateTimePicker_FirstDateLastDay;
        private Label label13;
        private Button btn_ToMonth;
        private Button btn_Today;
        /// <summary>
        /// Required designer variable.
        /// </summary>


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
            //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSalesInfo));
            this.groupBox8 = new GroupBox();
            this.dateTimePicker_ConfirmationDay = new DateTimePicker();
            this.wb_Input = new WebBrowser();
            this.groupBox18 = new GroupBox();
            this.comboBox_SalesTeam = new ComboBox();
            this.groupBox1 = new GroupBox();
            this.comboBox_SalesWorkerName = new ComboBox();
            this.groupBox11 = new GroupBox();
            this.txt_HIstory = new TextBox();
            this.groupBox2 = new GroupBox();
            this.txt_BusinessName = new TextBox();
            this.groupBox12 = new GroupBox();
            this.numericUpDown_SalesInput = new NumericUpDown();
            this.label10 = new Label();
            this.groupBox3 = new GroupBox();
            this.numericUpDown_CostOfSalesInput = new NumericUpDown();
            this.label1 = new Label();
            this.groupBox4 = new GroupBox();
            this.txt_SalesProfitInput = new TextBox();
            this.label2 = new Label();
            this.groupBox5 = new GroupBox();
            this.numericUpDown_FiexedAmountInput = new NumericUpDown();
            this.label3 = new Label();
            this.btn_SalesEdit = new Button();
            this.btn_SalesAdd = new Button();
            this.groupBox6 = new GroupBox();
            this.txt_FiexedAmountRateInput = new TextBox();
            this.label4 = new Label();
            this.groupBox7 = new GroupBox();
            this.txt_FiexedAmountRateTotal = new TextBox();
            this.label5 = new Label();
            this.groupBox9 = new GroupBox();
            this.txt_FiexedAmountTotal = new TextBox();
            this.label6 = new Label();
            this.groupBox10 = new GroupBox();
            this.txt_SalesProfitTotal = new TextBox();
            this.label7 = new Label();
            this.groupBox13 = new GroupBox();
            this.txt_CostOfSalesTotal = new TextBox();
            this.label8 = new Label();
            this.groupBox14 = new GroupBox();
            this.txt_SalesTotal = new TextBox();
            this.label9 = new Label();
            this.groupBox15 = new GroupBox();
            this.btn_ToMonth = new Button();
            this.btn_Today = new Button();
            this.btn_NextMonth = new Button();
            this.btn_PreMonth = new Button();
            this.dateTimePicker_StartDay = new DateTimePicker();
            this.dateTimePicker_LastDay = new DateTimePicker();
            this.label11 = new Label();
            this.groupBox16 = new GroupBox();
            this.btn_LvRefresh = new Button();
            this.btn_Delete = new Button();
            this.groupBox17 = new GroupBox();
            this.comboBox_TeamSort = new ComboBox();
            this.groupBox19 = new GroupBox();
            this.comboBox_WorkerNameSort = new ComboBox();
            this.groupBox20 = new GroupBox();
            this.btn_Search = new Button();
            this.txt_Search = new TextBox();
            this.label12 = new Label();
            this.groupBox_RouteSort = new GroupBox();
            this.comboBox_RouteSort = new ComboBox();
            this.groupBox21 = new GroupBox();
            this.comboBox_SalesTypeSort = new ComboBox();
            this.groupBox_Route = new GroupBox();
            this.comboBox_Route = new ComboBox();
            this.groupBox22 = new GroupBox();
            this.comboBox_SalesType = new ComboBox();
            this.groupBox23 = new GroupBox();
            this.dateTimePicker_FirstDate = new DateTimePicker();
            this.groupBox24 = new GroupBox();
            this.dateTimePicker_FirstDateStartDay = new DateTimePicker();
            this.dateTimePicker_FirstDateLastDay = new DateTimePicker();
            this.label13 = new Label();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader12 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.columnHeader13 = new ColumnHeader();
            this.columnHeader14 = new ColumnHeader();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader7 = new ColumnHeader();
            this.columnHeader8 = new ColumnHeader();
            this.columnHeader6 = new ColumnHeader();
            this.columnHeader9 = new ColumnHeader();
            this.columnHeader10 = new ColumnHeader();
            this.columnHeader11 = new ColumnHeader();
            this.groupBox8.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.numericUpDown_SalesInput.BeginInit();
            this.groupBox3.SuspendLayout();
            this.numericUpDown_CostOfSalesInput.BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.numericUpDown_FiexedAmountInput.BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox_RouteSort.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox_Route.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.SuspendLayout();
            this.groupBox8.Controls.Add((Control)this.dateTimePicker_ConfirmationDay);
            this.groupBox8.Controls.Add((Control)this.wb_Input);
            this.groupBox8.Location = new Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(122, 46);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "실적날짜";
            this.dateTimePicker_ConfirmationDay.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.dateTimePicker_ConfirmationDay.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_ConfirmationDay.Location = new Point(6, 18);
            this.dateTimePicker_ConfirmationDay.Name = "dateTimePicker_ConfirmationDay";
            this.dateTimePicker_ConfirmationDay.Size = new Size(108, 22);
            this.dateTimePicker_ConfirmationDay.TabIndex = 2;
            this.dateTimePicker_ConfirmationDay.TabStop = false;
            this.wb_Input.Location = new Point(78, -8);
            this.wb_Input.MinimumSize = new Size(20, 20);
            this.wb_Input.Name = "wb_Input";
            this.wb_Input.ScriptErrorsSuppressed = true;
            this.wb_Input.Size = new Size(34, 20);
            this.wb_Input.TabIndex = 86;
            this.wb_Input.Visible = false;
            this.groupBox18.Controls.Add((Control)this.comboBox_SalesTeam);
            this.groupBox18.Location = new Point(268, 12);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new Size(162, 46);
            this.groupBox18.TabIndex = 3;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "팀";
            this.comboBox_SalesTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_SalesTeam.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_SalesTeam.FormattingEnabled = true;
            this.comboBox_SalesTeam.Location = new Point(6, 17);
            this.comboBox_SalesTeam.Name = "comboBox_SalesTeam";
            this.comboBox_SalesTeam.Size = new Size(150, 21);
            this.comboBox_SalesTeam.TabIndex = 4;
            this.groupBox1.Controls.Add((Control)this.comboBox_SalesWorkerName);
            this.groupBox1.Location = new Point(436, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(162, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "담당자";
            this.comboBox_SalesWorkerName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_SalesWorkerName.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_SalesWorkerName.FormattingEnabled = true;
            this.comboBox_SalesWorkerName.Location = new Point(6, 17);
            this.comboBox_SalesWorkerName.Name = "comboBox_SalesWorkerName";
            this.comboBox_SalesWorkerName.Size = new Size(150, 21);
            this.comboBox_SalesWorkerName.TabIndex = 6;
            this.groupBox11.Controls.Add((Control)this.txt_HIstory);
            this.groupBox11.Location = new Point(1082, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new Size(281, 46);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "내용";
            this.txt_HIstory.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_HIstory.ImeMode = ImeMode.Hangul;
            this.txt_HIstory.Location = new Point(6, 17);
            this.txt_HIstory.MaxLength = 100;
            this.txt_HIstory.Name = "txt_HIstory";
            this.txt_HIstory.Size = new Size(269, 22);
            this.txt_HIstory.TabIndex = 10;
            this.groupBox2.Controls.Add((Control)this.txt_BusinessName);
            this.groupBox2.Location = new Point(914, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(162, 46);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상호";
            this.txt_BusinessName.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_BusinessName.ImeMode = ImeMode.Hangul;
            this.txt_BusinessName.Location = new Point(6, 17);
            this.txt_BusinessName.MaxLength = 100;
            this.txt_BusinessName.Name = "txt_BusinessName";
            this.txt_BusinessName.Size = new Size(150, 22);
            this.txt_BusinessName.TabIndex = 8;
            this.groupBox12.Controls.Add((Control)this.numericUpDown_SalesInput);
            this.groupBox12.Controls.Add((Control)this.label10);
            this.groupBox12.Location = new Point(12, 64);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new Size(150, 46);
            this.groupBox12.TabIndex = 20;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "매출";
            this.numericUpDown_SalesInput.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.numericUpDown_SalesInput.Increment = new Decimal(new int[4]
            {
        10000,
        0,
        0,
        0
            });
            this.numericUpDown_SalesInput.Location = new Point(6, 18);
            this.numericUpDown_SalesInput.Maximum = new Decimal(new int[4]
            {
        999999999,
        0,
        0,
        0
            });
            this.numericUpDown_SalesInput.Minimum = new Decimal(new int[4]
            {
        999999999,
        0,
        0,
        int.MinValue
            });
            this.numericUpDown_SalesInput.Name = "numericUpDown_SalesInput";
            this.numericUpDown_SalesInput.Size = new Size(107, 22);
            this.numericUpDown_SalesInput.TabIndex = 21;
            this.numericUpDown_SalesInput.TextAlign = HorizontalAlignment.Right;
            this.numericUpDown_SalesInput.ThousandsSeparator = true;
            this.label10.AutoSize = true;
            this.label10.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label10.Location = new Point(119, 23);
            this.label10.Name = "label10";
            this.label10.Size = new Size(20, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "원";
            this.groupBox3.Controls.Add((Control)this.numericUpDown_CostOfSalesInput);
            this.groupBox3.Controls.Add((Control)this.label1);
            this.groupBox3.Location = new Point(168, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(150, 46);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "예상 지출";
            this.numericUpDown_CostOfSalesInput.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.numericUpDown_CostOfSalesInput.Increment = new Decimal(new int[4]
            {
        10000,
        0,
        0,
        0
            });
            this.numericUpDown_CostOfSalesInput.Location = new Point(6, 18);
            this.numericUpDown_CostOfSalesInput.Maximum = new Decimal(new int[4]
            {
        999999999,
        0,
        0,
        0
            });
            this.numericUpDown_CostOfSalesInput.Minimum = new Decimal(new int[4]
            {
        999999999,
        0,
        0,
        int.MinValue
            });
            this.numericUpDown_CostOfSalesInput.Name = "numericUpDown_CostOfSalesInput";
            this.numericUpDown_CostOfSalesInput.Size = new Size(107, 22);
            this.numericUpDown_CostOfSalesInput.TabIndex = 23;
            this.numericUpDown_CostOfSalesInput.TextAlign = HorizontalAlignment.Right;
            this.numericUpDown_CostOfSalesInput.ThousandsSeparator = true;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label1.Location = new Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(20, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "원";
            this.groupBox4.Controls.Add((Control)this.txt_SalesProfitInput);
            this.groupBox4.Controls.Add((Control)this.label2);
            this.groupBox4.Location = new Point(324, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(150, 46);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "예상 매출이익";
            this.txt_SalesProfitInput.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_SalesProfitInput.ImeMode = ImeMode.Hangul;
            this.txt_SalesProfitInput.Location = new Point(6, 18);
            this.txt_SalesProfitInput.MaxLength = 12;
            this.txt_SalesProfitInput.Name = "txt_SalesProfitInput";
            this.txt_SalesProfitInput.ReadOnly = true;
            this.txt_SalesProfitInput.Size = new Size(107, 22);
            this.txt_SalesProfitInput.TabIndex = 88;
            this.txt_SalesProfitInput.TabStop = false;
            this.txt_SalesProfitInput.Text = "0";
            this.txt_SalesProfitInput.TextAlign = HorizontalAlignment.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label2.Location = new Point(119, 23);
            this.label2.Name = "label2";
            this.label2.Size = new Size(20, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "원";
            this.groupBox5.Controls.Add((Control)this.numericUpDown_FiexedAmountInput);
            this.groupBox5.Controls.Add((Control)this.label3);
            this.groupBox5.Location = new Point(480, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(150, 46);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "확정 실적";
            this.numericUpDown_FiexedAmountInput.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.numericUpDown_FiexedAmountInput.Increment = new Decimal(new int[4]
            {
        10000,
        0,
        0,
        0
            });
            this.numericUpDown_FiexedAmountInput.Location = new Point(6, 18);
            this.numericUpDown_FiexedAmountInput.Maximum = new Decimal(new int[4]
            {
        999999999,
        0,
        0,
        0
            });
            this.numericUpDown_FiexedAmountInput.Minimum = new Decimal(new int[4]
            {
        999999999,
        0,
        0,
        int.MinValue
            });
            this.numericUpDown_FiexedAmountInput.Name = "numericUpDown_FiexedAmountInput";
            this.numericUpDown_FiexedAmountInput.Size = new Size(107, 22);
            this.numericUpDown_FiexedAmountInput.TabIndex = 26;
            this.numericUpDown_FiexedAmountInput.TextAlign = HorizontalAlignment.Right;
            this.numericUpDown_FiexedAmountInput.ThousandsSeparator = true;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label3.Location = new Point(119, 23);
            this.label3.Name = "label3";
            this.label3.Size = new Size(20, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "원";
            this.btn_SalesEdit.Location = new Point(863, 64);
            this.btn_SalesEdit.Name = "btn_SalesEdit";
            this.btn_SalesEdit.Size = new Size(62, 46);
            this.btn_SalesEdit.TabIndex = 30;
            this.btn_SalesEdit.Text = "수정(&E)";
            this.btn_SalesEdit.UseVisualStyleBackColor = true;
            this.btn_SalesAdd.Location = new Point(795, 64);
            this.btn_SalesAdd.Name = "btn_SalesAdd";
            this.btn_SalesAdd.Size = new Size(62, 46);
            this.btn_SalesAdd.TabIndex = 29;
            this.btn_SalesAdd.Text = "등록(&S)";
            this.btn_SalesAdd.UseVisualStyleBackColor = true;
            this.groupBox6.Controls.Add((Control)this.txt_FiexedAmountRateInput);
            this.groupBox6.Controls.Add((Control)this.label4);
            this.groupBox6.Location = new Point(636, 64);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(150, 46);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "이익 대비 확정 실적률";
            this.txt_FiexedAmountRateInput.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_FiexedAmountRateInput.ImeMode = ImeMode.Hangul;
            this.txt_FiexedAmountRateInput.Location = new Point(6, 18);
            this.txt_FiexedAmountRateInput.MaxLength = 12;
            this.txt_FiexedAmountRateInput.Name = "txt_FiexedAmountRateInput";
            this.txt_FiexedAmountRateInput.ReadOnly = true;
            this.txt_FiexedAmountRateInput.Size = new Size(103, 22);
            this.txt_FiexedAmountRateInput.TabIndex = 28;
            this.txt_FiexedAmountRateInput.TabStop = false;
            this.txt_FiexedAmountRateInput.Text = "0";
            this.txt_FiexedAmountRateInput.TextAlign = HorizontalAlignment.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label4.Location = new Point(115, 23);
            this.label4.Name = "label4";
            this.label4.Size = new Size(19, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "%";
            this.groupBox7.Controls.Add((Control)this.txt_FiexedAmountRateTotal);
            this.groupBox7.Controls.Add((Control)this.label5);
            this.groupBox7.Location = new Point(636, 191);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(180, 46);
            this.groupBox7.TabIndex = 68;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "이익 대비 평균 확정 실적률";
            this.txt_FiexedAmountRateTotal.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_FiexedAmountRateTotal.ImeMode = ImeMode.Hangul;
            this.txt_FiexedAmountRateTotal.Location = new Point(6, 18);
            this.txt_FiexedAmountRateTotal.MaxLength = 12;
            this.txt_FiexedAmountRateTotal.Name = "txt_FiexedAmountRateTotal";
            this.txt_FiexedAmountRateTotal.ReadOnly = true;
            this.txt_FiexedAmountRateTotal.Size = new Size(141, 22);
            this.txt_FiexedAmountRateTotal.TabIndex = 69;
            this.txt_FiexedAmountRateTotal.TabStop = false;
            this.txt_FiexedAmountRateTotal.TextAlign = HorizontalAlignment.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label5.Location = new Point(153, 21);
            this.label5.Name = "label5";
            this.label5.Size = new Size(19, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "%";
            this.groupBox9.Controls.Add((Control)this.txt_FiexedAmountTotal);
            this.groupBox9.Controls.Add((Control)this.label6);
            this.groupBox9.Location = new Point(480, 191);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new Size(150, 46);
            this.groupBox9.TabIndex = 66;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "확정 실적 합계";
            this.txt_FiexedAmountTotal.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_FiexedAmountTotal.ImeMode = ImeMode.Hangul;
            this.txt_FiexedAmountTotal.Location = new Point(6, 18);
            this.txt_FiexedAmountTotal.MaxLength = 12;
            this.txt_FiexedAmountTotal.Name = "txt_FiexedAmountTotal";
            this.txt_FiexedAmountTotal.ReadOnly = true;
            this.txt_FiexedAmountTotal.Size = new Size(107, 22);
            this.txt_FiexedAmountTotal.TabIndex = 67;
            this.txt_FiexedAmountTotal.TabStop = false;
            this.txt_FiexedAmountTotal.TextAlign = HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label6.Location = new Point(119, 23);
            this.label6.Name = "label6";
            this.label6.Size = new Size(20, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "원";
            this.groupBox10.Controls.Add((Control)this.txt_SalesProfitTotal);
            this.groupBox10.Controls.Add((Control)this.label7);
            this.groupBox10.Location = new Point(324, 191);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new Size(150, 46);
            this.groupBox10.TabIndex = 64;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "예상 매출이익 합계";
            this.txt_SalesProfitTotal.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_SalesProfitTotal.ImeMode = ImeMode.Hangul;
            this.txt_SalesProfitTotal.Location = new Point(6, 18);
            this.txt_SalesProfitTotal.MaxLength = 12;
            this.txt_SalesProfitTotal.Name = "txt_SalesProfitTotal";
            this.txt_SalesProfitTotal.ReadOnly = true;
            this.txt_SalesProfitTotal.Size = new Size(107, 22);
            this.txt_SalesProfitTotal.TabIndex = 65;
            this.txt_SalesProfitTotal.TabStop = false;
            this.txt_SalesProfitTotal.TextAlign = HorizontalAlignment.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label7.Location = new Point(119, 23);
            this.label7.Name = "label7";
            this.label7.Size = new Size(20, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "원";
            this.groupBox13.Controls.Add((Control)this.txt_CostOfSalesTotal);
            this.groupBox13.Controls.Add((Control)this.label8);
            this.groupBox13.Location = new Point(168, 191);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new Size(150, 46);
            this.groupBox13.TabIndex = 62;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "예상 지출 합계";
            this.txt_CostOfSalesTotal.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_CostOfSalesTotal.ImeMode = ImeMode.Hangul;
            this.txt_CostOfSalesTotal.Location = new Point(6, 18);
            this.txt_CostOfSalesTotal.MaxLength = 12;
            this.txt_CostOfSalesTotal.Name = "txt_CostOfSalesTotal";
            this.txt_CostOfSalesTotal.ReadOnly = true;
            this.txt_CostOfSalesTotal.Size = new Size(107, 22);
            this.txt_CostOfSalesTotal.TabIndex = 63;
            this.txt_CostOfSalesTotal.TabStop = false;
            this.txt_CostOfSalesTotal.TextAlign = HorizontalAlignment.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label8.Location = new Point(119, 23);
            this.label8.Name = "label8";
            this.label8.Size = new Size(20, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "원";
            this.groupBox14.Controls.Add((Control)this.txt_SalesTotal);
            this.groupBox14.Controls.Add((Control)this.label9);
            this.groupBox14.Location = new Point(12, 191);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new Size(150, 46);
            this.groupBox14.TabIndex = 60;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "매출 합계";
            this.txt_SalesTotal.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_SalesTotal.ImeMode = ImeMode.Hangul;
            this.txt_SalesTotal.Location = new Point(6, 18);
            this.txt_SalesTotal.MaxLength = 12;
            this.txt_SalesTotal.Name = "txt_SalesTotal";
            this.txt_SalesTotal.ReadOnly = true;
            this.txt_SalesTotal.Size = new Size(107, 22);
            this.txt_SalesTotal.TabIndex = 61;
            this.txt_SalesTotal.TabStop = false;
            this.txt_SalesTotal.TextAlign = HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label9.Location = new Point(119, 23);
            this.label9.Name = "label9";
            this.label9.Size = new Size(20, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "원";
            this.groupBox15.Controls.Add((Control)this.btn_ToMonth);
            this.groupBox15.Controls.Add((Control)this.btn_Today);
            this.groupBox15.Controls.Add((Control)this.btn_NextMonth);
            this.groupBox15.Controls.Add((Control)this.btn_PreMonth);
            this.groupBox15.Controls.Add((Control)this.dateTimePicker_StartDay);
            this.groupBox15.Controls.Add((Control)this.dateTimePicker_LastDay);
            this.groupBox15.Controls.Add((Control)this.label11);
            this.groupBox15.Location = new Point(12, 139);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new Size(704, 46);
            this.groupBox15.TabIndex = 40;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "실적날짜 정렬";
            this.btn_ToMonth.Location = new Point(593, 16);
            this.btn_ToMonth.Name = "btn_ToMonth";
            this.btn_ToMonth.Size = new Size(106, 23);
            this.btn_ToMonth.TabIndex = 46;
            this.btn_ToMonth.Text = "당월";
            this.btn_ToMonth.UseVisualStyleBackColor = true;
            this.btn_Today.Location = new Point(481, 15);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new Size(106, 23);
            this.btn_Today.TabIndex = 45;
            this.btn_Today.Text = "당일";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_NextMonth.Location = new Point(369, 15);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.Size = new Size(106, 23);
            this.btn_NextMonth.TabIndex = 44;
            this.btn_NextMonth.Text = "내월(&N)";
            this.btn_NextMonth.UseVisualStyleBackColor = true;
            this.btn_PreMonth.Location = new Point(6, 15);
            this.btn_PreMonth.Name = "btn_PreMonth";
            this.btn_PreMonth.Size = new Size(106, 23);
            this.btn_PreMonth.TabIndex = 41;
            this.btn_PreMonth.Text = "전월(&B)";
            this.btn_PreMonth.UseVisualStyleBackColor = true;
            this.dateTimePicker_StartDay.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.dateTimePicker_StartDay.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_StartDay.Location = new Point(118, 16);
            this.dateTimePicker_StartDay.Name = "dateTimePicker_StartDay";
            this.dateTimePicker_StartDay.Size = new Size(110, 22);
            this.dateTimePicker_StartDay.TabIndex = 42;
            this.dateTimePicker_StartDay.TabStop = false;
            this.dateTimePicker_LastDay.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.dateTimePicker_LastDay.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_LastDay.Location = new Point(253, 16);
            this.dateTimePicker_LastDay.Name = "dateTimePicker_LastDay";
            this.dateTimePicker_LastDay.Size = new Size(110, 22);
            this.dateTimePicker_LastDay.TabIndex = 43;
            this.dateTimePicker_LastDay.TabStop = false;
            this.label11.AutoSize = true;
            this.label11.Location = new Point(232, 20);
            this.label11.Name = "label11";
            this.label11.Size = new Size(14, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "~";
            this.groupBox16.Controls.Add((Control)this.btn_LvRefresh);
            this.groupBox16.Controls.Add((Control)this.btn_Delete);
            this.groupBox16.Location = new Point(1157, 191);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new Size(308, 46);
            this.groupBox16.TabIndex = 49;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "도구";
            this.btn_LvRefresh.Location = new Point(7, 17);
            this.btn_LvRefresh.Name = "btn_LvRefresh";
            this.btn_LvRefresh.Size = new Size(146, 23);
            this.btn_LvRefresh.TabIndex = 50;
            this.btn_LvRefresh.Text = "새로고침(F5)";
            this.btn_LvRefresh.UseVisualStyleBackColor = true;
            this.btn_Delete.Location = new Point(163, 17);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(139, 23);
            this.btn_Delete.TabIndex = 51;
            this.btn_Delete.Text = "삭제(&D)";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.groupBox17.Controls.Add((Control)this.comboBox_TeamSort);
            this.groupBox17.Location = new Point(998, 139);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new Size(162, 46);
            this.groupBox17.TabIndex = 45;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "팀 정렬";
            this.comboBox_TeamSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_TeamSort.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_TeamSort.FormattingEnabled = true;
            this.comboBox_TeamSort.Items.AddRange(new object[1]
            {
        (object) "전체보기"
            });
            this.comboBox_TeamSort.Location = new Point(6, 19);
            this.comboBox_TeamSort.Name = "comboBox_TeamSort";
            this.comboBox_TeamSort.Size = new Size(150, 21);
            this.comboBox_TeamSort.TabIndex = 46;
            this.groupBox19.Controls.Add((Control)this.comboBox_WorkerNameSort);
            this.groupBox19.Location = new Point(1166, 139);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new Size(162, 46);
            this.groupBox19.TabIndex = 47;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "담당자 정렬";
            this.comboBox_WorkerNameSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_WorkerNameSort.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_WorkerNameSort.FormattingEnabled = true;
            this.comboBox_WorkerNameSort.Items.AddRange(new object[1]
            {
        (object) "전체보기"
            });
            this.comboBox_WorkerNameSort.Location = new Point(6, 19);
            this.comboBox_WorkerNameSort.Name = "comboBox_WorkerNameSort";
            this.comboBox_WorkerNameSort.Size = new Size(150, 21);
            this.comboBox_WorkerNameSort.TabIndex = 48;
            this.groupBox20.Controls.Add((Control)this.btn_Search);
            this.groupBox20.Controls.Add((Control)this.txt_Search);
            this.groupBox20.Controls.Add((Control)this.label12);
            this.groupBox20.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.groupBox20.Location = new Point(822, 191);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new Size(329, 46);
            this.groupBox20.TabIndex = 70;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "상호, 내용 검색";
            this.btn_Search.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.btn_Search.Location = new Point(227, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(87, 22);
            this.btn_Search.TabIndex = 72;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.txt_Search.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.txt_Search.ImeMode = ImeMode.Hangul;
            this.txt_Search.Location = new Point(87, 16);
            this.txt_Search.MaxLength = 5;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new Size(134, 22);
            this.txt_Search.TabIndex = 71;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.label12.Location = new Point(12, 21);
            this.label12.Name = "label12";
            this.label12.Size = new Size(69, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "검색 (F2) :";
            this.groupBox_RouteSort.Controls.Add((Control)this.comboBox_RouteSort);
            this.groupBox_RouteSort.Location = new Point(1475, 139);
            this.groupBox_RouteSort.Name = "groupBox_RouteSort";
            this.groupBox_RouteSort.Size = new Size(162, 46);
            this.groupBox_RouteSort.TabIndex = 89;
            this.groupBox_RouteSort.TabStop = false;
            this.groupBox_RouteSort.Text = "유입경로 정렬";
            this.groupBox_RouteSort.UseCompatibleTextRendering = true;
            this.comboBox_RouteSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_RouteSort.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_RouteSort.FormattingEnabled = true;
            this.comboBox_RouteSort.Items.AddRange(new object[24]
            {
        (object) "전체보기",
        (object) "인-통합",
        (object) "아웃-통합",
        (object) "기타",
        (object) "지인영업",
        (object) "광고주소개",
        (object) "네이버-파워링크",
        (object) "네이버-블로그",
        (object) "네이버-카페",
        (object) "네이버-지식인",
        (object) "구글",
        (object) "구글-키워드",
        (object) "구글-GDN",
        (object) "다음",
        (object) "카카오-키워드",
        (object) "페이스북-스폰서",
        (object) "인스타그램-인게",
        (object) "인스타그램-오토",
        (object) "인스타그램-스폰서",
        (object) "인스타그램-DM",
        (object) "인스타그램-개인채널",
        (object) "커뮤니티",
        (object) "아웃바운드디비",
        (object) "아웃바운드디비-공급"
            });
            this.comboBox_RouteSort.Location = new Point(6, 17);
            this.comboBox_RouteSort.Name = "comboBox_RouteSort";
            this.comboBox_RouteSort.Size = new Size(150, 21);
            this.comboBox_RouteSort.TabIndex = 41;
            this.groupBox21.Controls.Add((Control)this.comboBox_SalesTypeSort);
            this.groupBox21.Location = new Point(1334, 139);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new Size(135, 46);
            this.groupBox21.TabIndex = 88;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "매출분류 정렬";
            this.comboBox_SalesTypeSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_SalesTypeSort.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_SalesTypeSort.FormattingEnabled = true;
            this.comboBox_SalesTypeSort.Items.AddRange(new object[4]
            {
        (object) "전체보기",
        (object) "신규매출",
        (object) "연장매출",
        (object) "해지매출"
            });
            this.comboBox_SalesTypeSort.Location = new Point(6, 17);
            this.comboBox_SalesTypeSort.Name = "comboBox_SalesTypeSort";
            this.comboBox_SalesTypeSort.Size = new Size(123, 21);
            this.comboBox_SalesTypeSort.TabIndex = 39;
            this.groupBox_Route.Controls.Add((Control)this.comboBox_Route);
            this.groupBox_Route.Location = new Point(746, 12);
            this.groupBox_Route.Name = "groupBox_Route";
            this.groupBox_Route.Size = new Size(162, 46);
            this.groupBox_Route.TabIndex = 91;
            this.groupBox_Route.TabStop = false;
            this.groupBox_Route.Text = "유입경로";
            this.comboBox_Route.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_Route.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_Route.FormattingEnabled = true;
            this.comboBox_Route.Items.AddRange(new object[21]
            {
        (object) "기타",
        (object) "지인영업",
        (object) "광고주소개",
        (object) "네이버-파워링크",
        (object) "네이버-블로그",
        (object) "네이버-카페",
        (object) "네이버-지식인",
        (object) "구글",
        (object) "구글-키워드",
        (object) "구글-GDN",
        (object) "다음",
        (object) "카카오-키워드",
        (object) "페이스북-스폰서",
        (object) "인스타그램-인게",
        (object) "인스타그램-오토",
        (object) "인스타그램-스폰서",
        (object) "인스타그램-DM",
        (object) "인스타그램-개인채널",
        (object) "커뮤니티",
        (object) "아웃바운드디비",
        (object) "아웃바운드디비-공급"
            });
            this.comboBox_Route.Location = new Point(6, 17);
            this.comboBox_Route.Name = "comboBox_Route";
            this.comboBox_Route.Size = new Size(150, 21);
            this.comboBox_Route.TabIndex = 11;
            this.groupBox22.Controls.Add((Control)this.comboBox_SalesType);
            this.groupBox22.Location = new Point(604, 12);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new Size(136, 46);
            this.groupBox22.TabIndex = 90;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "매출분류";
            this.comboBox_SalesType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_SalesType.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_SalesType.FormattingEnabled = true;
            this.comboBox_SalesType.Items.AddRange(new object[3]
            {
        (object) "신규매출",
        (object) "연장매출",
        (object) "해지매출"
            });
            this.comboBox_SalesType.Location = new Point(6, 17);
            this.comboBox_SalesType.Name = "comboBox_SalesType";
            this.comboBox_SalesType.Size = new Size(123, 21);
            this.comboBox_SalesType.TabIndex = 9;
            this.groupBox23.Controls.Add((Control)this.dateTimePicker_FirstDate);
            this.groupBox23.Location = new Point(140, 12);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new Size(122, 46);
            this.groupBox23.TabIndex = 92;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "최초접촉일";
            this.dateTimePicker_FirstDate.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.dateTimePicker_FirstDate.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_FirstDate.Location = new Point(6, 18);
            this.dateTimePicker_FirstDate.Name = "dateTimePicker_FirstDate";
            this.dateTimePicker_FirstDate.Size = new Size(108, 22);
            this.dateTimePicker_FirstDate.TabIndex = 2;
            this.dateTimePicker_FirstDate.TabStop = false;
            this.groupBox24.Controls.Add((Control)this.dateTimePicker_FirstDateStartDay);
            this.groupBox24.Controls.Add((Control)this.dateTimePicker_FirstDateLastDay);
            this.groupBox24.Controls.Add((Control)this.label13);
            this.groupBox24.Location = new Point(722, 139);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new Size(270, 46);
            this.groupBox24.TabIndex = 93;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "최초상담일 정렬";
            this.dateTimePicker_FirstDateStartDay.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.dateTimePicker_FirstDateStartDay.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_FirstDateStartDay.Location = new Point(11, 16);
            this.dateTimePicker_FirstDateStartDay.Name = "dateTimePicker_FirstDateStartDay";
            this.dateTimePicker_FirstDateStartDay.Size = new Size(110, 22);
            this.dateTimePicker_FirstDateStartDay.TabIndex = 42;
            this.dateTimePicker_FirstDateStartDay.TabStop = false;
            this.dateTimePicker_FirstDateLastDay.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.dateTimePicker_FirstDateLastDay.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_FirstDateLastDay.Location = new Point(146, 16);
            this.dateTimePicker_FirstDateLastDay.Name = "dateTimePicker_FirstDateLastDay";
            this.dateTimePicker_FirstDateLastDay.Size = new Size(110, 22);
            this.dateTimePicker_FirstDateLastDay.TabIndex = 43;
            this.dateTimePicker_FirstDateLastDay.TabStop = false;
            this.label13.AutoSize = true;
            this.label13.Location = new Point(125, 20);
            this.label13.Name = "label13";
            this.label13.Size = new Size(14, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "~";
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            this.columnHeader2.Text = "실적날짜";
            this.columnHeader2.TextAlign = HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            this.columnHeader12.Text = "최초접촉일";
            this.columnHeader12.TextAlign = HorizontalAlignment.Center;
            this.columnHeader12.Width = 120;
            this.columnHeader3.Text = "팀";
            this.columnHeader3.TextAlign = HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            this.columnHeader4.Text = "담당자";
            this.columnHeader4.TextAlign = HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            this.columnHeader13.Text = "매출분류";
            this.columnHeader13.TextAlign = HorizontalAlignment.Center;
            this.columnHeader13.Width = 100;
            this.columnHeader14.Text = "유입경로";
            this.columnHeader14.TextAlign = HorizontalAlignment.Center;
            this.columnHeader14.Width = 180;
            this.columnHeader5.Text = "상호";
            this.columnHeader5.TextAlign = HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            this.columnHeader7.Text = "내용";
            this.columnHeader7.Width = 270;
            this.columnHeader8.Text = "매출";
            this.columnHeader8.TextAlign = HorizontalAlignment.Center;
            this.columnHeader8.Width = 95;
            this.columnHeader6.Text = "예상 지출";
            this.columnHeader6.TextAlign = HorizontalAlignment.Center;
            this.columnHeader6.Width = 95;
            this.columnHeader9.Text = "예상 매출이익";
            this.columnHeader9.TextAlign = HorizontalAlignment.Center;
            this.columnHeader9.Width = 95;
            this.columnHeader10.Text = "확정 실적";
            this.columnHeader10.TextAlign = HorizontalAlignment.Center;
            this.columnHeader10.Width = 95;
            this.columnHeader11.Text = "확정 실적률";
            this.columnHeader11.TextAlign = HorizontalAlignment.Center;
            this.columnHeader11.Width = 95;
            this.AutoScaleDimensions = new SizeF(7f, 12f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1649, 761);
            this.Controls.Add((Control)this.groupBox24);
            this.Controls.Add((Control)this.groupBox23);
            this.Controls.Add((Control)this.groupBox_Route);
            this.Controls.Add((Control)this.groupBox22);
            this.Controls.Add((Control)this.groupBox_RouteSort);
            this.Controls.Add((Control)this.groupBox21);
            this.Controls.Add((Control)this.groupBox20);
            this.Controls.Add((Control)this.groupBox19);
            this.Controls.Add((Control)this.groupBox17);
            this.Controls.Add((Control)this.groupBox16);
            this.Controls.Add((Control)this.groupBox15);
            this.Controls.Add((Control)this.groupBox7);
            this.Controls.Add((Control)this.groupBox9);
            this.Controls.Add((Control)this.groupBox10);
            this.Controls.Add((Control)this.groupBox13);
            this.Controls.Add((Control)this.groupBox14);
            this.Controls.Add((Control)this.groupBox6);
            this.Controls.Add((Control)this.btn_SalesEdit);
            this.Controls.Add((Control)this.btn_SalesAdd);
            this.Controls.Add((Control)this.groupBox5);
            this.Controls.Add((Control)this.groupBox4);
            this.Controls.Add((Control)this.groupBox3);
            this.Controls.Add((Control)this.groupBox12);
            this.Controls.Add((Control)this.groupBox2);
            this.Controls.Add((Control)this.groupBox11);
            this.Controls.Add((Control)this.groupBox1);
            this.Controls.Add((Control)this.groupBox18);
            this.Controls.Add((Control)this.groupBox8);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "더오름CRM 영업실적 입력,관리";
            this.groupBox8.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.numericUpDown_SalesInput.EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.numericUpDown_CostOfSalesInput.EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.numericUpDown_FiexedAmountInput.EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox_RouteSort.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox_Route.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}