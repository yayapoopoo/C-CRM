using System.ComponentModel;

namespace WinFormsApp3
{
    partial class SalesRank
    {


        private bool bInput = false;
        private bool bGetList = false;
        private string columnSort = "없음";
        private string columnSortType = "DESC";
        private IContainer components = (IContainer)null;
        private GroupBox groupBox14;
        private Button btn_NextMonth;
        private Button btn_PreMonth;
        private DateTimePicker dateTimePicker_StartDay;
        private DateTimePicker dateTimePicker_LastDay;
        private Label label6;
        private GroupBox groupBox10;
        private ComboBox comboBox_TeamSort;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox1;
        private GroupBox groupBox7;
        private TextBox txt_NewRouteFriendTotal;
        private Label label5;
        private GroupBox groupBox9;
        private TextBox txt_FiexedAmountTotal;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_NewRouteOutTotal;
        private Label label7;
        private GroupBox groupBox13;
        private TextBox txt_NewRouteInTotal;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox txt_SalesTotal;
        private Label label9;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GroupBox groupBox4;
        private TextBox txt_NewSalesTotal;
        private Label label2;
        private GroupBox groupBox5;
        private TextBox txt_ExtendedSalesTotal;
        private Label label3;
        private GroupBox groupBox6;
        private TextBox txt_TerminationSalesTotal;
        private Label label4;
        private Button btn_NextMonthSame;
        private Button btn_PreMonthSame;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private GroupBox groupBox8;
        private TextBox txt_ListPreSales;
        private Label label10;
        private GroupBox groupBox11;
        private TextBox txt_ElongationRate;
        private Label label11;
        private Button btn_ToMonth;
        private Button btn_Today;
        private Button btn_NextDay;
        private Button btn_PreDay;
        private GroupBox groupBox12;
        private TextBox txt_PreSalesTotal;
        private Label label12;
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
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btn_NextDay = new System.Windows.Forms.Button();
            this.btn_PreDay = new System.Windows.Forms.Button();
            this.btn_ToMonth = new System.Windows.Forms.Button();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_NextMonthSame = new System.Windows.Forms.Button();
            this.btn_PreMonthSame = new System.Windows.Forms.Button();
            this.btn_NextMonth = new System.Windows.Forms.Button();
            this.btn_PreMonth = new System.Windows.Forms.Button();
            this.dateTimePicker_StartDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_LastDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBox_TeamSort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_NewRouteFriendTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_FiexedAmountTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NewRouteOutTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txt_NewRouteInTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_SalesTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_NewSalesTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_ExtendedSalesTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_TerminationSalesTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_ListPreSales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txt_ElongationRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txt_PreSalesTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox14.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btn_NextDay);
            this.groupBox14.Controls.Add(this.btn_PreDay);
            this.groupBox14.Controls.Add(this.btn_ToMonth);
            this.groupBox14.Controls.Add(this.btn_Today);
            this.groupBox14.Controls.Add(this.btn_NextMonthSame);
            this.groupBox14.Controls.Add(this.btn_PreMonthSame);
            this.groupBox14.Controls.Add(this.btn_NextMonth);
            this.groupBox14.Controls.Add(this.btn_PreMonth);
            this.groupBox14.Controls.Add(this.dateTimePicker_StartDay);
            this.groupBox14.Controls.Add(this.dateTimePicker_LastDay);
            this.groupBox14.Controls.Add(this.label6);
            this.groupBox14.Location = new System.Drawing.Point(12, 15);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox14.Size = new System.Drawing.Size(1159, 58);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "날짜";
            // 
            // btn_NextDay
            // 
            this.btn_NextDay.Location = new System.Drawing.Point(566, 20);
            this.btn_NextDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NextDay.Name = "btn_NextDay";
            this.btn_NextDay.Size = new System.Drawing.Size(106, 29);
            this.btn_NextDay.TabIndex = 35;
            this.btn_NextDay.Text = "내일";
            this.btn_NextDay.UseVisualStyleBackColor = true;
            // 
            // btn_PreDay
            // 
            this.btn_PreDay.Location = new System.Drawing.Point(454, 20);
            this.btn_PreDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PreDay.Name = "btn_PreDay";
            this.btn_PreDay.Size = new System.Drawing.Size(106, 29);
            this.btn_PreDay.TabIndex = 34;
            this.btn_PreDay.Text = "어제";
            this.btn_PreDay.UseVisualStyleBackColor = true;
            // 
            // btn_ToMonth
            // 
            this.btn_ToMonth.Location = new System.Drawing.Point(790, 20);
            this.btn_ToMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ToMonth.Name = "btn_ToMonth";
            this.btn_ToMonth.Size = new System.Drawing.Size(106, 29);
            this.btn_ToMonth.TabIndex = 33;
            this.btn_ToMonth.Text = "당월";
            this.btn_ToMonth.UseVisualStyleBackColor = true;
            // 
            // btn_Today
            // 
            this.btn_Today.Location = new System.Drawing.Point(678, 20);
            this.btn_Today.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(106, 29);
            this.btn_Today.TabIndex = 32;
            this.btn_Today.Text = "당일";
            this.btn_Today.UseVisualStyleBackColor = true;
            // 
            // btn_NextMonthSame
            // 
            this.btn_NextMonthSame.Location = new System.Drawing.Point(118, 20);
            this.btn_NextMonthSame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NextMonthSame.Name = "btn_NextMonthSame";
            this.btn_NextMonthSame.Size = new System.Drawing.Size(106, 29);
            this.btn_NextMonthSame.TabIndex = 3;
            this.btn_NextMonthSame.Text = "내월 동일 날짜";
            this.btn_NextMonthSame.UseVisualStyleBackColor = true;
            // 
            // btn_PreMonthSame
            // 
            this.btn_PreMonthSame.Location = new System.Drawing.Point(6, 20);
            this.btn_PreMonthSame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PreMonthSame.Name = "btn_PreMonthSame";
            this.btn_PreMonthSame.Size = new System.Drawing.Size(106, 29);
            this.btn_PreMonthSame.TabIndex = 2;
            this.btn_PreMonthSame.Text = "전월 동일 날짜";
            this.btn_PreMonthSame.UseVisualStyleBackColor = true;
            // 
            // btn_NextMonth
            // 
            this.btn_NextMonth.Location = new System.Drawing.Point(342, 20);
            this.btn_NextMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.Size = new System.Drawing.Size(106, 29);
            this.btn_NextMonth.TabIndex = 5;
            this.btn_NextMonth.Text = "내월(&N)";
            this.btn_NextMonth.UseVisualStyleBackColor = true;
            // 
            // btn_PreMonth
            // 
            this.btn_PreMonth.Location = new System.Drawing.Point(230, 20);
            this.btn_PreMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PreMonth.Name = "btn_PreMonth";
            this.btn_PreMonth.Size = new System.Drawing.Size(106, 29);
            this.btn_PreMonth.TabIndex = 4;
            this.btn_PreMonth.Text = "전월(&B)";
            this.btn_PreMonth.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_StartDay
            // 
            this.dateTimePicker_StartDay.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_StartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_StartDay.Location = new System.Drawing.Point(902, 20);
            this.dateTimePicker_StartDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_StartDay.Name = "dateTimePicker_StartDay";
            this.dateTimePicker_StartDay.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker_StartDay.TabIndex = 6;
            this.dateTimePicker_StartDay.TabStop = false;
            this.dateTimePicker_StartDay.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_LastDay
            // 
            this.dateTimePicker_LastDay.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_LastDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_LastDay.Location = new System.Drawing.Point(1037, 20);
            this.dateTimePicker_LastDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_LastDay.Name = "dateTimePicker_LastDay";
            this.dateTimePicker_LastDay.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker_LastDay.TabIndex = 7;
            this.dateTimePicker_LastDay.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1016, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "~";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBox_TeamSort);
            this.groupBox10.Location = new System.Drawing.Point(1177, 15);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(168, 58);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "팀";
            // 
            // comboBox_TeamSort
            // 
            this.comboBox_TeamSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeamSort.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_TeamSort.FormattingEnabled = true;
            this.comboBox_TeamSort.Location = new System.Drawing.Point(6, 24);
            this.comboBox_TeamSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_TeamSort.Name = "comboBox_TeamSort";
            this.comboBox_TeamSort.Size = new System.Drawing.Size(155, 21);
            this.comboBox_TeamSort.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(1351, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(169, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개별";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 130;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_NewRouteFriendTotal);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(948, 80);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(150, 58);
            this.groupBox7.TabIndex = 123;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "신규-지인/소개 합계";
            // 
            // txt_NewRouteFriendTotal
            // 
            this.txt_NewRouteFriendTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NewRouteFriendTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_NewRouteFriendTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_NewRouteFriendTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewRouteFriendTotal.MaxLength = 12;
            this.txt_NewRouteFriendTotal.Name = "txt_NewRouteFriendTotal";
            this.txt_NewRouteFriendTotal.ReadOnly = true;
            this.txt_NewRouteFriendTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_NewRouteFriendTotal.TabIndex = 69;
            this.txt_NewRouteFriendTotal.TabStop = false;
            this.txt_NewRouteFriendTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(119, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "원";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_FiexedAmountTotal);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Location = new System.Drawing.Point(1104, 80);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(150, 58);
            this.groupBox9.TabIndex = 122;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "확정 실적 합계";
            // 
            // txt_FiexedAmountTotal
            // 
            this.txt_FiexedAmountTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_FiexedAmountTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_FiexedAmountTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_FiexedAmountTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FiexedAmountTotal.MaxLength = 12;
            this.txt_FiexedAmountTotal.Name = "txt_FiexedAmountTotal";
            this.txt_FiexedAmountTotal.ReadOnly = true;
            this.txt_FiexedAmountTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_FiexedAmountTotal.TabIndex = 67;
            this.txt_FiexedAmountTotal.TabStop = false;
            this.txt_FiexedAmountTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "원";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_NewRouteOutTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(792, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(150, 58);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "신규-아웃 합계";
            // 
            // txt_NewRouteOutTotal
            // 
            this.txt_NewRouteOutTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NewRouteOutTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_NewRouteOutTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_NewRouteOutTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewRouteOutTotal.MaxLength = 12;
            this.txt_NewRouteOutTotal.Name = "txt_NewRouteOutTotal";
            this.txt_NewRouteOutTotal.ReadOnly = true;
            this.txt_NewRouteOutTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_NewRouteOutTotal.TabIndex = 65;
            this.txt_NewRouteOutTotal.TabStop = false;
            this.txt_NewRouteOutTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(119, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "원";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txt_NewRouteInTotal);
            this.groupBox13.Controls.Add(this.label8);
            this.groupBox13.Location = new System.Drawing.Point(636, 80);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Size = new System.Drawing.Size(150, 58);
            this.groupBox13.TabIndex = 120;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "신규-인 합계";
            // 
            // txt_NewRouteInTotal
            // 
            this.txt_NewRouteInTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NewRouteInTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_NewRouteInTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_NewRouteInTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewRouteInTotal.MaxLength = 12;
            this.txt_NewRouteInTotal.Name = "txt_NewRouteInTotal";
            this.txt_NewRouteInTotal.ReadOnly = true;
            this.txt_NewRouteInTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_NewRouteInTotal.TabIndex = 63;
            this.txt_NewRouteInTotal.TabStop = false;
            this.txt_NewRouteInTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(119, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "원";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_SalesTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(150, 58);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "매출 합계";
            // 
            // txt_SalesTotal
            // 
            this.txt_SalesTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SalesTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SalesTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_SalesTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SalesTotal.MaxLength = 12;
            this.txt_SalesTotal.Name = "txt_SalesTotal";
            this.txt_SalesTotal.ReadOnly = true;
            this.txt_SalesTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_SalesTotal.TabIndex = 61;
            this.txt_SalesTotal.TabStop = false;
            this.txt_SalesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(119, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "원";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_NewSalesTotal);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(168, 80);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(150, 58);
            this.groupBox4.TabIndex = 124;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "신규매출 합계";
            // 
            // txt_NewSalesTotal
            // 
            this.txt_NewSalesTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NewSalesTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_NewSalesTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_NewSalesTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewSalesTotal.MaxLength = 12;
            this.txt_NewSalesTotal.Name = "txt_NewSalesTotal";
            this.txt_NewSalesTotal.ReadOnly = true;
            this.txt_NewSalesTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_NewSalesTotal.TabIndex = 61;
            this.txt_NewSalesTotal.TabStop = false;
            this.txt_NewSalesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "원";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_ExtendedSalesTotal);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(324, 80);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(150, 58);
            this.groupBox5.TabIndex = 125;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "연장매출 합계";
            // 
            // txt_ExtendedSalesTotal
            // 
            this.txt_ExtendedSalesTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ExtendedSalesTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ExtendedSalesTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_ExtendedSalesTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ExtendedSalesTotal.MaxLength = 12;
            this.txt_ExtendedSalesTotal.Name = "txt_ExtendedSalesTotal";
            this.txt_ExtendedSalesTotal.ReadOnly = true;
            this.txt_ExtendedSalesTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_ExtendedSalesTotal.TabIndex = 61;
            this.txt_ExtendedSalesTotal.TabStop = false;
            this.txt_ExtendedSalesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "원";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_TerminationSalesTotal);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(480, 80);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(150, 58);
            this.groupBox6.TabIndex = 126;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "해지매출 합계";
            // 
            // txt_TerminationSalesTotal
            // 
            this.txt_TerminationSalesTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TerminationSalesTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_TerminationSalesTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_TerminationSalesTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TerminationSalesTotal.MaxLength = 12;
            this.txt_TerminationSalesTotal.Name = "txt_TerminationSalesTotal";
            this.txt_TerminationSalesTotal.ReadOnly = true;
            this.txt_TerminationSalesTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_TerminationSalesTotal.TabIndex = 61;
            this.txt_TerminationSalesTotal.TabStop = false;
            this.txt_TerminationSalesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(119, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "원";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_ListPreSales);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(1260, 80);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(150, 58);
            this.groupBox8.TabIndex = 127;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "리스트 전월 매출 합계";
            // 
            // txt_ListPreSales
            // 
            this.txt_ListPreSales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ListPreSales.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ListPreSales.Location = new System.Drawing.Point(6, 22);
            this.txt_ListPreSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ListPreSales.MaxLength = 12;
            this.txt_ListPreSales.Name = "txt_ListPreSales";
            this.txt_ListPreSales.ReadOnly = true;
            this.txt_ListPreSales.Size = new System.Drawing.Size(107, 22);
            this.txt_ListPreSales.TabIndex = 67;
            this.txt_ListPreSales.TabStop = false;
            this.txt_ListPreSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(119, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "원";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txt_ElongationRate);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Location = new System.Drawing.Point(1572, 80);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Size = new System.Drawing.Size(93, 58);
            this.groupBox11.TabIndex = 128;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "매출 연장률";
            // 
            // txt_ElongationRate
            // 
            this.txt_ElongationRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ElongationRate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ElongationRate.Location = new System.Drawing.Point(6, 22);
            this.txt_ElongationRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ElongationRate.MaxLength = 12;
            this.txt_ElongationRate.Name = "txt_ElongationRate";
            this.txt_ElongationRate.ReadOnly = true;
            this.txt_ElongationRate.Size = new System.Drawing.Size(54, 22);
            this.txt_ElongationRate.TabIndex = 67;
            this.txt_ElongationRate.TabStop = false;
            this.txt_ElongationRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(66, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "%";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txt_PreSalesTotal);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Location = new System.Drawing.Point(1416, 80);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Size = new System.Drawing.Size(150, 58);
            this.groupBox12.TabIndex = 129;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "실제 전월 매출 합계";
            // 
            // txt_PreSalesTotal
            // 
            this.txt_PreSalesTotal.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PreSalesTotal.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_PreSalesTotal.Location = new System.Drawing.Point(6, 22);
            this.txt_PreSalesTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PreSalesTotal.MaxLength = 12;
            this.txt_PreSalesTotal.Name = "txt_PreSalesTotal";
            this.txt_PreSalesTotal.ReadOnly = true;
            this.txt_PreSalesTotal.Size = new System.Drawing.Size(107, 22);
            this.txt_PreSalesTotal.TabIndex = 67;
            this.txt_PreSalesTotal.TabStop = false;
            this.txt_PreSalesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(119, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "원";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "순위";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "이름";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader23.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "팀";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "매출액";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "신규매출";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "연장매출";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "해지매출";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "신규-인";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "신규-아웃";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "신규-지인/소개";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "확정실적";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "전월매출";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 130;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "매출 연장률";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 130;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.listBox3);
            this.groupBox16.Controls.Add(this.listBox2);
            this.groupBox16.Controls.Add(this.listBox1);
            this.groupBox16.Location = new System.Drawing.Point(12, 145);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(1653, 672);
            this.groupBox16.TabIndex = 130;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "매출 그래프";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(440, 289);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(566, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(440, 289);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(1092, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(440, 289);
            this.listBox3.TabIndex = 2;
            // 
            // SalesRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 829);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "더오름CRM 매출";
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private GroupBox groupBox15;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox16;
        private ListBox listBox1;
        private BackgroundWorker backgroundWorker1;
        private ListBox listBox3;
        private ListBox listBox2;
    }
}