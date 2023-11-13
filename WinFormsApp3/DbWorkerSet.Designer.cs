using System.ComponentModel;

namespace WinFormsApp3
{
    partial class DbWorkerSet
    {
        private string[] dbId = (string[])null;
        private bool bList = false;
        private IContainer components = (IContainer)null;
        private GroupBox groupBox_WorkerSort;
        private Button btn_DbWorkerInput;
        private WebBrowser wb_WorkerSort;
        private ComboBox comboBox_Worker;
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
            this.groupBox_WorkerSort = new GroupBox();
            this.btn_DbWorkerInput = new Button();
            this.wb_WorkerSort = new WebBrowser();
            this.comboBox_Worker = new ComboBox();
            this.groupBox_WorkerSort.SuspendLayout();
            this.SuspendLayout();
            this.groupBox_WorkerSort.Controls.Add((Control)this.btn_DbWorkerInput);
            this.groupBox_WorkerSort.Controls.Add((Control)this.wb_WorkerSort);
            this.groupBox_WorkerSort.Controls.Add((Control)this.comboBox_Worker);
            this.groupBox_WorkerSort.Font = new Font("굴림", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)129);
            this.groupBox_WorkerSort.Location = new Point(12, 12);
            this.groupBox_WorkerSort.Name = "groupBox_WorkerSort";
            this.groupBox_WorkerSort.Size = new Size(223, 55);
            this.groupBox_WorkerSort.TabIndex = 48;
            this.groupBox_WorkerSort.TabStop = false;
            this.groupBox_WorkerSort.Text = "담당자 선택";
            this.btn_DbWorkerInput.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.btn_DbWorkerInput.Location = new Point(141, 19);
            this.btn_DbWorkerInput.Name = "btn_DbWorkerInput";
            this.btn_DbWorkerInput.Size = new Size(76, 23);
            this.btn_DbWorkerInput.TabIndex = 49;
            this.btn_DbWorkerInput.Text = "분배하기";
            this.btn_DbWorkerInput.UseVisualStyleBackColor = true;
            this.wb_WorkerSort.Location = new Point(155, -7);
            this.wb_WorkerSort.MinimumSize = new Size(20, 20);
            this.wb_WorkerSort.Name = "wb_WorkerSort";
            this.wb_WorkerSort.ScriptErrorsSuppressed = true;
            this.wb_WorkerSort.Size = new Size(34, 20);
            this.wb_WorkerSort.TabIndex = 60;
            this.wb_WorkerSort.Visible = false;
            this.comboBox_Worker.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_Worker.Font = new Font("굴림", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)129);
            this.comboBox_Worker.FormattingEnabled = true;
            this.comboBox_Worker.Location = new Point(6, 21);
            this.comboBox_Worker.Name = "comboBox_Worker";
            this.comboBox_Worker.Size = new Size(126, 21);
            this.comboBox_Worker.TabIndex = 48;
            this.AutoScaleDimensions = new SizeF(7f, 12f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size((int)byte.MaxValue, 78);
            this.Controls.Add((Control)this.groupBox_WorkerSort);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "디비 분배";
            this.groupBox_WorkerSort.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}