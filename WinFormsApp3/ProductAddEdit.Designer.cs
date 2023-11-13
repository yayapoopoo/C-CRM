
namespace WinFormsApp3
{
    partial class ProductAddEdit
    {
        private bool bInput = false;
        private string id = "";
        private TextBox txt_SalesProfit;
        private Label label5;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown_CostOfSales;
        private NumericUpDown numericUpDown_Sales;
        private TextBox txt_ProductName;
        private Label label1;
        private Label label10;
        private Label label7;
        private Label label9;
        private Button btn_Save;
        private ComboBox comboBox_ProductChannel;
        private Label label17;
        private GroupBox groupBox13;
        private TextBox txt_SalesProfitRate;
        private Label label12;
        private Label label13;


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txt_SalesProfit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_CostOfSales = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Sales = new System.Windows.Forms.NumericUpDown();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBox_ProductChannel = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txt_SalesProfitRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CostOfSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sales)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SalesProfit
            // 
            this.txt_SalesProfit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SalesProfit.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SalesProfit.Location = new System.Drawing.Point(101, 165);
            this.txt_SalesProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SalesProfit.MaxLength = 100;
            this.txt_SalesProfit.Name = "txt_SalesProfit";
            this.txt_SalesProfit.ReadOnly = true;
            this.txt_SalesProfit.Size = new System.Drawing.Size(167, 22);
            this.txt_SalesProfit.TabIndex = 5;
            this.txt_SalesProfit.TabStop = false;
            this.txt_SalesProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(274, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(274, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(274, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "원";
            // 
            // numericUpDown_CostOfSales
            // 
            this.numericUpDown_CostOfSales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_CostOfSales.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_CostOfSales.Location = new System.Drawing.Point(101, 130);
            this.numericUpDown_CostOfSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_CostOfSales.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown_CostOfSales.Name = "numericUpDown_CostOfSales";
            this.numericUpDown_CostOfSales.Size = new System.Drawing.Size(167, 22);
            this.numericUpDown_CostOfSales.TabIndex = 4;
            this.numericUpDown_CostOfSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_CostOfSales.ThousandsSeparator = true;
            // 
            // numericUpDown_Sales
            // 
            this.numericUpDown_Sales.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_Sales.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Sales.Location = new System.Drawing.Point(101, 95);
            this.numericUpDown_Sales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_Sales.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown_Sales.Name = "numericUpDown_Sales";
            this.numericUpDown_Sales.Size = new System.Drawing.Size(167, 22);
            this.numericUpDown_Sales.TabIndex = 3;
            this.numericUpDown_Sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Sales.ThousandsSeparator = true;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_ProductName.Location = new System.Drawing.Point(101, 60);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductName.MaxLength = 50;
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(192, 22);
            this.txt_ProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "실행원가 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(28, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "매출이익 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "상품명 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(41, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "판매가 :";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(10, 340);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(284, 44);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "등록(&S)";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // comboBox_ProductChannel
            // 
            this.comboBox_ProductChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductChannel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_ProductChannel.FormattingEnabled = true;
            this.comboBox_ProductChannel.Items.AddRange(new object[] {
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
            this.comboBox_ProductChannel.Location = new System.Drawing.Point(101, 26);
            this.comboBox_ProductChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_ProductChannel.Name = "comboBox_ProductChannel";
            this.comboBox_ProductChannel.Size = new System.Drawing.Size(193, 21);
            this.comboBox_ProductChannel.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(28, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "상품채널 :";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txt_SalesProfitRate);
            this.groupBox13.Controls.Add(this.label12);
            this.groupBox13.Controls.Add(this.label13);
            this.groupBox13.Controls.Add(this.txt_SalesProfit);
            this.groupBox13.Controls.Add(this.label5);
            this.groupBox13.Controls.Add(this.label3);
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Controls.Add(this.numericUpDown_CostOfSales);
            this.groupBox13.Controls.Add(this.numericUpDown_Sales);
            this.groupBox13.Controls.Add(this.txt_ProductName);
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Controls.Add(this.label10);
            this.groupBox13.Controls.Add(this.label7);
            this.groupBox13.Controls.Add(this.label9);
            this.groupBox13.Controls.Add(this.btn_Save);
            this.groupBox13.Controls.Add(this.comboBox_ProductChannel);
            this.groupBox13.Controls.Add(this.label17);
            this.groupBox13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox13.Location = new System.Drawing.Point(12, 15);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Size = new System.Drawing.Size(305, 401);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "상품";
            // 
            // txt_SalesProfitRate
            // 
            this.txt_SalesProfitRate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SalesProfitRate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SalesProfitRate.Location = new System.Drawing.Point(101, 200);
            this.txt_SalesProfitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SalesProfitRate.MaxLength = 100;
            this.txt_SalesProfitRate.Name = "txt_SalesProfitRate";
            this.txt_SalesProfitRate.ReadOnly = true;
            this.txt_SalesProfitRate.Size = new System.Drawing.Size(167, 22);
            this.txt_SalesProfitRate.TabIndex = 6;
            this.txt_SalesProfitRate.TabStop = false;
            this.txt_SalesProfitRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(274, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(15, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "매익마진률 :";
            // 
            // ProductAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 432);
            this.Controls.Add(this.groupBox13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "상품 등록";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CostOfSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sales)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        private TextBox textBox1;
    }
}