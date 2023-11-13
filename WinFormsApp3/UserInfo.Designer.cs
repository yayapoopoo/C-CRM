
using System.ComponentModel;

namespace WinFormsApp3
{
    partial class UserInfo
    {
        private bool bList = false;
        private bool bDetail = false;
        private bool bInput = false;
        private IContainer components = (IContainer)null;
        private Button btn_LvRefresh;
        private Button btn_Delete;
        private Button btn_Add;
        private Button btn_Edit;
        private GroupBox groupBox1;
        private Button btn_TeamNameSet;
        private TextBox txt_TeamName;
        private Label label2;
        private Button btn_PasswordSet;
        private TextBox txt_WorkerName;
        private Label label3;
        private Label label1;
        private ComboBox comboBox_Access;
        private TextBox txt_Password;
        private Label label18;
        private Label label17;
        private TextBox txt_Id;
        private Label label5;
        private ListViewEx listView_Main;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ComboBox comboBox_WorkerPosition;
        private Label label4;
        private DateTimePicker dateTimePicker_StartDay;
        private ColumnHeader columnHeader8;
        private GroupBox groupBox2;
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

        private void InitializeComponent()
        {
            this.btn_LvRefresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_StartDay = new System.Windows.Forms.DateTimePicker();
            this.comboBox_WorkerPosition = new System.Windows.Forms.ComboBox();
            this.btn_TeamNameSet = new System.Windows.Forms.Button();
            this.txt_TeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PasswordSet = new System.Windows.Forms.Button();
            this.txt_WorkerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Access = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_Main = new WinFormsApp3.ListViewEx();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LvRefresh
            // 
            this.btn_LvRefresh.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LvRefresh.Location = new System.Drawing.Point(909, 15);
            this.btn_LvRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LvRefresh.Name = "btn_LvRefresh";
            this.btn_LvRefresh.Size = new System.Drawing.Size(268, 32);
            this.btn_LvRefresh.TabIndex = 2;
            this.btn_LvRefresh.Text = "새로고침(F5)";
            this.btn_LvRefresh.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(910, 424);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(267, 32);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(909, 384);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(268, 32);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "신규등록";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(909, 344);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(268, 32);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "정보수정 (아이디,이름 수정불가)";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker_StartDay);
            this.groupBox1.Controls.Add(this.comboBox_WorkerPosition);
            this.groupBox1.Controls.Add(this.btn_TeamNameSet);
            this.groupBox1.Controls.Add(this.txt_TeamName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_PasswordSet);
            this.groupBox1.Controls.Add(this.txt_WorkerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Access);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(909, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "세부정보";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 458;
            this.label4.Text = "평가시작일 :";
            // 
            // dateTimePicker_StartDay
            // 
            this.dateTimePicker_StartDay.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_StartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_StartDay.Location = new System.Drawing.Point(103, 165);
            this.dateTimePicker_StartDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_StartDay.Name = "dateTimePicker_StartDay";
            this.dateTimePicker_StartDay.Size = new System.Drawing.Size(143, 22);
            this.dateTimePicker_StartDay.TabIndex = 457;
            this.dateTimePicker_StartDay.TabStop = false;
            // 
            // comboBox_WorkerPosition
            // 
            this.comboBox_WorkerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_WorkerPosition.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_WorkerPosition.FormattingEnabled = true;
            this.comboBox_WorkerPosition.Items.AddRange(new object[] {
            "대표",
            "부대표",
            "사장",
            "부사장",
            "전무",
            "상무",
            "이사",
            "본부장",
            "부장",
            "실장",
            "차장",
            "과장",
            "팀장",
            "대리",
            "주임",
            "매니저",
            "파트장",
            "사원"});
            this.comboBox_WorkerPosition.Location = new System.Drawing.Point(103, 200);
            this.comboBox_WorkerPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_WorkerPosition.Name = "comboBox_WorkerPosition";
            this.comboBox_WorkerPosition.Size = new System.Drawing.Size(143, 21);
            this.comboBox_WorkerPosition.TabIndex = 10;
            this.comboBox_WorkerPosition.TabStop = false;
            // 
            // btn_TeamNameSet
            // 
            this.btn_TeamNameSet.Location = new System.Drawing.Point(201, 130);
            this.btn_TeamNameSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TeamNameSet.Name = "btn_TeamNameSet";
            this.btn_TeamNameSet.Size = new System.Drawing.Size(45, 28);
            this.btn_TeamNameSet.TabIndex = 9;
            this.btn_TeamNameSet.TabStop = false;
            this.btn_TeamNameSet.Text = "변경";
            this.btn_TeamNameSet.UseVisualStyleBackColor = true;
            // 
            // txt_TeamName
            // 
            this.txt_TeamName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TeamName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_TeamName.Location = new System.Drawing.Point(103, 130);
            this.txt_TeamName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TeamName.MaxLength = 20;
            this.txt_TeamName.Name = "txt_TeamName";
            this.txt_TeamName.Size = new System.Drawing.Size(92, 22);
            this.txt_TeamName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 456;
            this.label2.Text = "팀이름 :";
            // 
            // btn_PasswordSet
            // 
            this.btn_PasswordSet.Location = new System.Drawing.Point(201, 60);
            this.btn_PasswordSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PasswordSet.Name = "btn_PasswordSet";
            this.btn_PasswordSet.Size = new System.Drawing.Size(45, 28);
            this.btn_PasswordSet.TabIndex = 6;
            this.btn_PasswordSet.TabStop = false;
            this.btn_PasswordSet.Text = "변경";
            this.btn_PasswordSet.UseVisualStyleBackColor = true;
            // 
            // txt_WorkerName
            // 
            this.txt_WorkerName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_WorkerName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_WorkerName.Location = new System.Drawing.Point(103, 95);
            this.txt_WorkerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_WorkerName.MaxLength = 20;
            this.txt_WorkerName.Name = "txt_WorkerName";
            this.txt_WorkerName.Size = new System.Drawing.Size(143, 22);
            this.txt_WorkerName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "직책 :";
            // 
            // comboBox_Access
            // 
            this.comboBox_Access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Access.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Access.FormattingEnabled = true;
            this.comboBox_Access.Items.AddRange(new object[] {
            "개인제어",
            "팀제어",
            "모두제어"});
            this.comboBox_Access.Location = new System.Drawing.Point(103, 235);
            this.comboBox_Access.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Access.Name = "comboBox_Access";
            this.comboBox_Access.Size = new System.Drawing.Size(143, 21);
            this.comboBox_Access.TabIndex = 11;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Password.Location = new System.Drawing.Point(103, 60);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(92, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(30, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "비밀번호 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(30, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "제어권한 :";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Id.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Id.Location = new System.Drawing.Point(103, 25);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Id.MaxLength = 20;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(92, 22);
            this.txt_Id.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "아이디 :";
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.GridLines = true;
            this.listView_Main.Location = new System.Drawing.Point(3, 19);
            this.listView_Main.MultiSelect = false;
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(885, 422);
            this.listView_Main.TabIndex = 1;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "아이디";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이름";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "팀이름";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "직책";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "제어권한";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "자동디비분배";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "평가시작일";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.listView_Main);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 444);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "계정 리스트";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_LvRefresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "더오름CRM 계정관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


    }
}
#endregion