using System.ComponentModel;

namespace WinFormsApp3
{
    partial class ProductInfo
    {
        private bool bInput = false;
        private string keyword = "없음";
        private string columnSort = "없음";
        private string columnSortType = "DESC";
        private int nSelectSales = 0;
        private int nSelectCostOfSales = 0;
        private int nSelectLaborCost = 0;
        private IContainer components = (IContainer)null;
        private Button btn_LvRefresh;
        private GroupBox groupBox3;
        private TextBox txt_SelectItemCnt;
        private Label label1;
        private Label label2;
        private TextBox txt_TotalSales;
        private Label label22;
        private TextBox txt_CostOfSales;
        private Label label35;
        private Label label33;
        private Label label42;
        private Label label21;
        private TextBox txt_SalesProfit;
        private TextBox txt_SalesProfitRate;
        private Label label32;
        private Label label37;
        private Label label43;
        private GroupBox groupBox4;
        private Button btn_Search;
        private TextBox txt_Search;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_ProductDelete;
        private Button btn_ProductEdit;
        private Button btn_ProductAdd;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private GroupBox groupBox5;
        private ComboBox comboBox_ProductChannelSort;
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.btn_LvRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_SelectItemCnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalSales = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_CostOfSales = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_SalesProfit = new System.Windows.Forms.TextBox();
            this.txt_SalesProfitRate = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            this.btn_ProductEdit = new System.Windows.Forms.Button();
            this.btn_ProductAdd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox_ProductChannelSort = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LvRefresh
            // 
            this.btn_LvRefresh.Location = new System.Drawing.Point(1200, 20);
            this.btn_LvRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LvRefresh.Name = "btn_LvRefresh";
            this.btn_LvRefresh.Size = new System.Drawing.Size(86, 69);
            this.btn_LvRefresh.TabIndex = 6;
            this.btn_LvRefresh.Text = "새로고침(F5)";
            this.btn_LvRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_SelectItemCnt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_TotalSales);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txt_CostOfSales);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_SalesProfit);
            this.groupBox3.Controls.Add(this.txt_SalesProfitRate);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Location = new System.Drawing.Point(982, 298);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(305, 349);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "선택 상품 합계";
            // 
            // txt_SelectItemCnt
            // 
            this.txt_SelectItemCnt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SelectItemCnt.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SelectItemCnt.Location = new System.Drawing.Point(102, 36);
            this.txt_SelectItemCnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SelectItemCnt.MaxLength = 50;
            this.txt_SelectItemCnt.Name = "txt_SelectItemCnt";
            this.txt_SelectItemCnt.ReadOnly = true;
            this.txt_SelectItemCnt.Size = new System.Drawing.Size(162, 22);
            this.txt_SelectItemCnt.TabIndex = 14;
            this.txt_SelectItemCnt.TabStop = false;
            this.txt_SelectItemCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "선택 상품수 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(270, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "개";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_TotalSales
            // 
            this.txt_TotalSales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalSales.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_TotalSales.Location = new System.Drawing.Point(102, 94);
            this.txt_TotalSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TotalSales.MaxLength = 50;
            this.txt_TotalSales.Name = "txt_TotalSales";
            this.txt_TotalSales.ReadOnly = true;
            this.txt_TotalSales.Size = new System.Drawing.Size(162, 22);
            this.txt_TotalSales.TabIndex = 15;
            this.txt_TotalSales.TabStop = false;
            this.txt_TotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(29, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 145;
            this.label22.Text = "실행원가 :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_CostOfSales
            // 
            this.txt_CostOfSales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CostOfSales.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_CostOfSales.Location = new System.Drawing.Point(102, 129);
            this.txt_CostOfSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CostOfSales.MaxLength = 50;
            this.txt_CostOfSales.Name = "txt_CostOfSales";
            this.txt_CostOfSales.ReadOnly = true;
            this.txt_CostOfSales.Size = new System.Drawing.Size(162, 22);
            this.txt_CostOfSales.TabIndex = 16;
            this.txt_CostOfSales.TabStop = false;
            this.txt_CostOfSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label35.Location = new System.Drawing.Point(270, 168);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(20, 13);
            this.label35.TabIndex = 138;
            this.label35.Text = "원";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(270, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(20, 13);
            this.label33.TabIndex = 147;
            this.label33.Text = "원";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label42.Location = new System.Drawing.Point(270, 202);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(19, 13);
            this.label42.TabIndex = 153;
            this.label42.Text = "%";
            this.label42.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(16, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 131;
            this.label21.Text = "판매가합계 :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_SalesProfit
            // 
            this.txt_SalesProfit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SalesProfit.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SalesProfit.Location = new System.Drawing.Point(102, 164);
            this.txt_SalesProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SalesProfit.MaxLength = 50;
            this.txt_SalesProfit.Name = "txt_SalesProfit";
            this.txt_SalesProfit.ReadOnly = true;
            this.txt_SalesProfit.Size = new System.Drawing.Size(162, 22);
            this.txt_SalesProfit.TabIndex = 17;
            this.txt_SalesProfit.TabStop = false;
            this.txt_SalesProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SalesProfitRate
            // 
            this.txt_SalesProfitRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SalesProfitRate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SalesProfitRate.Location = new System.Drawing.Point(102, 199);
            this.txt_SalesProfitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SalesProfitRate.MaxLength = 50;
            this.txt_SalesProfitRate.Name = "txt_SalesProfitRate";
            this.txt_SalesProfitRate.ReadOnly = true;
            this.txt_SalesProfitRate.Size = new System.Drawing.Size(162, 22);
            this.txt_SalesProfitRate.TabIndex = 18;
            this.txt_SalesProfitRate.TabStop = false;
            this.txt_SalesProfitRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(270, 98);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 13);
            this.label32.TabIndex = 133;
            this.label32.Text = "원";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label37.Location = new System.Drawing.Point(29, 168);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(67, 13);
            this.label37.TabIndex = 134;
            this.label37.Text = "매출이익 :";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label43.Location = new System.Drawing.Point(12, 202);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(84, 13);
            this.label43.TabIndex = 151;
            this.label43.Text = "매익 마진률 :";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Search);
            this.groupBox4.Controls.Add(this.txt_Search);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(981, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(213, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "상품명 검색 (F2)";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(141, 26);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 28);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Search.Location = new System.Drawing.Point(6, 26);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.MaxLength = 5;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(129, 22);
            this.txt_Search.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(963, 631);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "판매 상품목록";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "상품채널";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "상품명";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "판매가";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "실행원가";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "매출이익";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 90;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "매익마진률";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "예상인건비";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "영업이익";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "영업이익률";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ProductDelete);
            this.groupBox2.Controls.Add(this.btn_ProductEdit);
            this.groupBox2.Controls.Add(this.btn_ProductAdd);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(982, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(305, 101);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상품 관리";
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ProductDelete.Location = new System.Drawing.Point(208, 21);
            this.btn_ProductDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(91, 69);
            this.btn_ProductDelete.TabIndex = 12;
            this.btn_ProductDelete.Text = "삭제(&D)";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            // 
            // btn_ProductEdit
            // 
            this.btn_ProductEdit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ProductEdit.Location = new System.Drawing.Point(106, 21);
            this.btn_ProductEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ProductEdit.Name = "btn_ProductEdit";
            this.btn_ProductEdit.Size = new System.Drawing.Size(91, 69);
            this.btn_ProductEdit.TabIndex = 11;
            this.btn_ProductEdit.Text = "수정(&E)";
            this.btn_ProductEdit.UseVisualStyleBackColor = true;
            // 
            // btn_ProductAdd
            // 
            this.btn_ProductAdd.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ProductAdd.Location = new System.Drawing.Point(6, 21);
            this.btn_ProductAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ProductAdd.Name = "btn_ProductAdd";
            this.btn_ProductAdd.Size = new System.Drawing.Size(91, 69);
            this.btn_ProductAdd.TabIndex = 10;
            this.btn_ProductAdd.Text = "추가(&A)";
            this.btn_ProductAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox_ProductChannelSort);
            this.groupBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(981, 91);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(305, 69);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "상품채널 정렬";
            // 
            // comboBox_ProductChannelSort
            // 
            this.comboBox_ProductChannelSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductChannelSort.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_ProductChannelSort.FormattingEnabled = true;
            this.comboBox_ProductChannelSort.Items.AddRange(new object[] {
            "전체보기",
            "인스타그램",
            "페이스북",
            "네이버",
            "다음",
            "카카오",
            "구글",
            "유튜브",
            "영상제작",
            "모바일앱",
            "홈페이지",
            "컨텐츠",
            "기타"});
            this.comboBox_ProductChannelSort.Location = new System.Drawing.Point(7, 25);
            this.comboBox_ProductChannelSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_ProductChannelSort.Name = "comboBox_ProductChannelSort";
            this.comboBox_ProductChannelSort.Size = new System.Drawing.Size(293, 21);
            this.comboBox_ProductChannelSort.TabIndex = 8;
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 659);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_LvRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "더오름CRM 판매 상품관리";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}