using System.ComponentModel;

namespace WinFormsApp3
{
    partial class CusProductInfo
    {
        private string cusId = "";
        private bool bInput = false;
        private string keyword = "없음";
        private string columnSort = "없음";
        private string columnSortType = "DESC";
        private string cusColumnSort = "없음";
        private string cusColumnSortType = "DESC";
        private int nSelectSales = 0;
        private int nSelectCostOfSales = 0;
        private int nSelectLaborCost = 0;
        private int nCusSelectSales = 0;
        private int nCusSelectCostOfSales = 0;
        private int nCusSelectLaborCost = 0;
        private IContainer components = (IContainer)null;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Button btn_GetProduct;
        private Label label34;
        private Label label35;
        private TextBox txt_LaborCosts;
        private Label label36;
        private TextBox txt_SalesProfit;
        private Label label37;
        private Label label32;
        private TextBox txt_TotalSales;
        private Label label21;
        private Label label44;
        private TextBox txt_OperatingProfitRate;
        private Label label45;
        private Label label42;
        private TextBox txt_SalesProfitRate;
        private Label label43;
        private Label label38;
        private TextBox txt_OperatingProfit;
        private Label label39;
        private Label label33;
        private TextBox txt_CostOfSales;
        private Label label22;
        private ColumnHeader columnHeader16;
        private GroupBox groupBox4;
        private Button btn_Search;
        private TextBox txt_Search;
        private GroupBox groupBox3;
        private TextBox txt_SelectItemCnt;
        private Label label1;
        private Label label2;
        private GroupBox groupBox5;
        private TextBox txt_ContractSelectItemCnt;
        private Label label3;
        private Label label4;
        private TextBox txt_ContractTotalSales;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_ContractCostOfSales;
        private Label label8;
        private TextBox txt_ContractOperatingProfitRate;
        private Label label9;
        private TextBox txt_ContractLaborCosts;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txt_ContractOperatingProfit;
        private Label label14;
        private TextBox txt_ContractSalesProfit;
        private TextBox txt_ContractSalesProfitRate;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btn_CusProductSave;
        private Button btn_RemoveProduct;
        private Button btn_LvRefresh;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private GroupBox groupBox6;
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
        private void InitializeComponent()
        {
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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
            this.btn_GetProduct = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_LaborCosts = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txt_SalesProfit = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_TotalSales = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_OperatingProfitRate = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txt_SalesProfitRate = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_OperatingProfit = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_CostOfSales = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_SelectItemCnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_ContractSelectItemCnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ContractTotalSales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ContractCostOfSales = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ContractOperatingProfitRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ContractLaborCosts = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ContractOperatingProfit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ContractSalesProfit = new System.Windows.Forms.TextBox();
            this.txt_ContractSalesProfitRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_CusProductSave = new System.Windows.Forms.Button();
            this.btn_RemoveProduct = new System.Windows.Forms.Button();
            this.btn_LvRefresh = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_ProductChannelSort = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(964, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "판매 상품목록";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 588);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(964, 425);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "고객 계약 상품목록";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "상품채널";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "상품명";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "매출액";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "실행원가";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "매출이익";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "매익마진률";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 90;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "예상인건비";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 90;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "영업이익";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 90;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "영업이익률";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader20.Width = 90;
            // 
            // btn_GetProduct
            // 
            this.btn_GetProduct.Location = new System.Drawing.Point(281, 524);
            this.btn_GetProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GetProduct.Name = "btn_GetProduct";
            this.btn_GetProduct.Size = new System.Drawing.Size(170, 56);
            this.btn_GetProduct.TabIndex = 17;
            this.btn_GetProduct.Text = "▼ 선택 상품 가져오기(&G)";
            this.btn_GetProduct.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(270, 240);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(20, 13);
            this.label34.TabIndex = 139;
            this.label34.Text = "원";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // txt_LaborCosts
            // 
            this.txt_LaborCosts.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_LaborCosts.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_LaborCosts.Location = new System.Drawing.Point(102, 236);
            this.txt_LaborCosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LaborCosts.MaxLength = 50;
            this.txt_LaborCosts.Name = "txt_LaborCosts";
            this.txt_LaborCosts.ReadOnly = true;
            this.txt_LaborCosts.Size = new System.Drawing.Size(162, 22);
            this.txt_LaborCosts.TabIndex = 14;
            this.txt_LaborCosts.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(16, 240);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(80, 13);
            this.label36.TabIndex = 136;
            this.label36.Text = "예상인건비 :";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.txt_SalesProfit.TabIndex = 12;
            this.txt_SalesProfit.TabStop = false;
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
            this.txt_TotalSales.TabIndex = 10;
            this.txt_TotalSales.TabStop = false;
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
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label44.Location = new System.Drawing.Point(270, 310);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(19, 13);
            this.label44.TabIndex = 156;
            this.label44.Text = "%";
            this.label44.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_OperatingProfitRate
            // 
            this.txt_OperatingProfitRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_OperatingProfitRate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_OperatingProfitRate.Location = new System.Drawing.Point(102, 306);
            this.txt_OperatingProfitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OperatingProfitRate.MaxLength = 50;
            this.txt_OperatingProfitRate.Name = "txt_OperatingProfitRate";
            this.txt_OperatingProfitRate.ReadOnly = true;
            this.txt_OperatingProfitRate.Size = new System.Drawing.Size(162, 22);
            this.txt_OperatingProfitRate.TabIndex = 16;
            this.txt_OperatingProfitRate.TabStop = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label45.Location = new System.Drawing.Point(16, 310);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(80, 13);
            this.label45.TabIndex = 154;
            this.label45.Text = "영업이익률 :";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.txt_SalesProfitRate.TabIndex = 13;
            this.txt_SalesProfitRate.TabStop = false;
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
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.Location = new System.Drawing.Point(270, 275);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 13);
            this.label38.TabIndex = 150;
            this.label38.Text = "원";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_OperatingProfit
            // 
            this.txt_OperatingProfit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_OperatingProfit.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_OperatingProfit.Location = new System.Drawing.Point(102, 271);
            this.txt_OperatingProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OperatingProfit.MaxLength = 50;
            this.txt_OperatingProfit.Name = "txt_OperatingProfit";
            this.txt_OperatingProfit.ReadOnly = true;
            this.txt_OperatingProfit.Size = new System.Drawing.Size(162, 22);
            this.txt_OperatingProfit.TabIndex = 15;
            this.txt_OperatingProfit.TabStop = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(30, 275);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(67, 13);
            this.label39.TabIndex = 148;
            this.label39.Text = "영업이익 :";
            this.label39.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.txt_CostOfSales.TabIndex = 11;
            this.txt_CostOfSales.TabStop = false;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Search);
            this.groupBox4.Controls.Add(this.txt_Search);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(982, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(213, 69);
            this.groupBox4.TabIndex = 2;
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
            this.btn_Search.TabIndex = 4;
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
            this.txt_Search.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_SelectItemCnt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_TotalSales);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.txt_CostOfSales);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.txt_OperatingProfitRate);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.txt_LaborCosts);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.txt_OperatingProfit);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_SalesProfit);
            this.groupBox3.Controls.Add(this.txt_SalesProfitRate);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Location = new System.Drawing.Point(982, 168);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(304, 349);
            this.groupBox3.TabIndex = 8;
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
            this.txt_SelectItemCnt.TabIndex = 9;
            this.txt_SelectItemCnt.TabStop = false;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_ContractSelectItemCnt);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txt_ContractTotalSales);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_ContractCostOfSales);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_ContractOperatingProfitRate);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txt_ContractLaborCosts);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txt_ContractOperatingProfit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txt_ContractSalesProfit);
            this.groupBox5.Controls.Add(this.txt_ContractSalesProfitRate);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(982, 588);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(304, 349);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "계약 상품 합계";
            // 
            // txt_ContractSelectItemCnt
            // 
            this.txt_ContractSelectItemCnt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractSelectItemCnt.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractSelectItemCnt.Location = new System.Drawing.Point(102, 36);
            this.txt_ContractSelectItemCnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractSelectItemCnt.MaxLength = 50;
            this.txt_ContractSelectItemCnt.Name = "txt_ContractSelectItemCnt";
            this.txt_ContractSelectItemCnt.ReadOnly = true;
            this.txt_ContractSelectItemCnt.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractSelectItemCnt.TabIndex = 22;
            this.txt_ContractSelectItemCnt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "상품수 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 159;
            this.label4.Text = "개";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContractTotalSales
            // 
            this.txt_ContractTotalSales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractTotalSales.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractTotalSales.Location = new System.Drawing.Point(102, 94);
            this.txt_ContractTotalSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractTotalSales.MaxLength = 50;
            this.txt_ContractTotalSales.Name = "txt_ContractTotalSales";
            this.txt_ContractTotalSales.ReadOnly = true;
            this.txt_ContractTotalSales.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractTotalSales.TabIndex = 23;
            this.txt_ContractTotalSales.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 145;
            this.label5.Text = "실행원가 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(270, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 139;
            this.label6.Text = "원";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(270, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContractCostOfSales
            // 
            this.txt_ContractCostOfSales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractCostOfSales.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractCostOfSales.Location = new System.Drawing.Point(102, 129);
            this.txt_ContractCostOfSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractCostOfSales.MaxLength = 50;
            this.txt_ContractCostOfSales.Name = "txt_ContractCostOfSales";
            this.txt_ContractCostOfSales.ReadOnly = true;
            this.txt_ContractCostOfSales.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractCostOfSales.TabIndex = 24;
            this.txt_ContractCostOfSales.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(270, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 138;
            this.label8.Text = "원";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContractOperatingProfitRate
            // 
            this.txt_ContractOperatingProfitRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractOperatingProfitRate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractOperatingProfitRate.Location = new System.Drawing.Point(102, 306);
            this.txt_ContractOperatingProfitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractOperatingProfitRate.MaxLength = 50;
            this.txt_ContractOperatingProfitRate.Name = "txt_ContractOperatingProfitRate";
            this.txt_ContractOperatingProfitRate.ReadOnly = true;
            this.txt_ContractOperatingProfitRate.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractOperatingProfitRate.TabIndex = 29;
            this.txt_ContractOperatingProfitRate.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(270, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 147;
            this.label9.Text = "원";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContractLaborCosts
            // 
            this.txt_ContractLaborCosts.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractLaborCosts.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractLaborCosts.Location = new System.Drawing.Point(102, 236);
            this.txt_ContractLaborCosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractLaborCosts.MaxLength = 50;
            this.txt_ContractLaborCosts.Name = "txt_ContractLaborCosts";
            this.txt_ContractLaborCosts.ReadOnly = true;
            this.txt_ContractLaborCosts.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractLaborCosts.TabIndex = 27;
            this.txt_ContractLaborCosts.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "영업이익률 :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(30, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 148;
            this.label11.Text = "영업이익 :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 136;
            this.label12.Text = "예상인건비 :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(270, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 153;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContractOperatingProfit
            // 
            this.txt_ContractOperatingProfit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractOperatingProfit.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractOperatingProfit.Location = new System.Drawing.Point(102, 271);
            this.txt_ContractOperatingProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractOperatingProfit.MaxLength = 50;
            this.txt_ContractOperatingProfit.Name = "txt_ContractOperatingProfit";
            this.txt_ContractOperatingProfit.ReadOnly = true;
            this.txt_ContractOperatingProfit.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractOperatingProfit.TabIndex = 28;
            this.txt_ContractOperatingProfit.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(29, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 131;
            this.label14.Text = "매출합계 :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ContractSalesProfit
            // 
            this.txt_ContractSalesProfit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractSalesProfit.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractSalesProfit.Location = new System.Drawing.Point(102, 164);
            this.txt_ContractSalesProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractSalesProfit.MaxLength = 50;
            this.txt_ContractSalesProfit.Name = "txt_ContractSalesProfit";
            this.txt_ContractSalesProfit.ReadOnly = true;
            this.txt_ContractSalesProfit.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractSalesProfit.TabIndex = 25;
            this.txt_ContractSalesProfit.TabStop = false;
            // 
            // txt_ContractSalesProfitRate
            // 
            this.txt_ContractSalesProfitRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ContractSalesProfitRate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ContractSalesProfitRate.Location = new System.Drawing.Point(102, 199);
            this.txt_ContractSalesProfitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ContractSalesProfitRate.MaxLength = 50;
            this.txt_ContractSalesProfitRate.Name = "txt_ContractSalesProfitRate";
            this.txt_ContractSalesProfitRate.ReadOnly = true;
            this.txt_ContractSalesProfitRate.Size = new System.Drawing.Size(162, 22);
            this.txt_ContractSalesProfitRate.TabIndex = 26;
            this.txt_ContractSalesProfitRate.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(270, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 150;
            this.label15.Text = "원";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(270, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 133;
            this.label16.Text = "원";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(29, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 134;
            this.label17.Text = "매출이익 :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(12, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 151;
            this.label18.Text = "매익 마진률 :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_CusProductSave
            // 
            this.btn_CusProductSave.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CusProductSave.Location = new System.Drawing.Point(982, 944);
            this.btn_CusProductSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CusProductSave.Name = "btn_CusProductSave";
            this.btn_CusProductSave.Size = new System.Drawing.Size(305, 69);
            this.btn_CusProductSave.TabIndex = 30;
            this.btn_CusProductSave.Text = "계약 상품 저장하기(&S)";
            this.btn_CusProductSave.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveProduct
            // 
            this.btn_RemoveProduct.Location = new System.Drawing.Point(457, 524);
            this.btn_RemoveProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RemoveProduct.Name = "btn_RemoveProduct";
            this.btn_RemoveProduct.Size = new System.Drawing.Size(170, 56);
            this.btn_RemoveProduct.TabIndex = 18;
            this.btn_RemoveProduct.Text = "▲ 선택 상품 삭제(&R)";
            this.btn_RemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btn_LvRefresh
            // 
            this.btn_LvRefresh.Location = new System.Drawing.Point(1201, 15);
            this.btn_LvRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LvRefresh.Name = "btn_LvRefresh";
            this.btn_LvRefresh.Size = new System.Drawing.Size(86, 69);
            this.btn_LvRefresh.TabIndex = 5;
            this.btn_LvRefresh.Text = "새로고침(F5)";
            this.btn_LvRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_ProductChannelSort);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(982, 91);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(305, 69);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "상품채널 정렬";
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
            this.comboBox_ProductChannelSort.TabIndex = 7;
            // 
            // CusProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 1022);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_LvRefresh);
            this.Controls.Add(this.btn_CusProductSave);
            this.Controls.Add(this.btn_RemoveProduct);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_GetProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CusProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "더오름CRM 계약 상품관리";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}