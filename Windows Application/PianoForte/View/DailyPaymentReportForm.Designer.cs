﻿namespace PianoForte.View
{
    partial class DailyPaymentReportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrystalReportViewer_DailyIncome = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_Daily = new System.Windows.Forms.TabPage();
            this.Button_Search_Daily_Income = new System.Windows.Forms.Button();
            this.DateTimePicker_Daily_Income_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPage_Monthly = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker3_StartDate = new System.Windows.Forms.DateTimePicker();
            this.Button_Generate_Total_Income = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTimePicker3_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker2_StartDate = new System.Windows.Forms.DateTimePicker();
            this.Button_Generate_Monthly_Income = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker2_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker1_StartDate = new System.Windows.Forms.DateTimePicker();
            this.Button_Generate_Course_Income = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker1_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.totalIncomeSummary = new System.ComponentModel.BackgroundWorker();
            this.monthlyIncomeSummary = new System.ComponentModel.BackgroundWorker();
            this.courseIncomeSummary = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage_Daily.SuspendLayout();
            this.TabPage_Monthly.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CrystalReportViewer_DailyIncome);
            this.panel1.Location = new System.Drawing.Point(6, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 509);
            this.panel1.TabIndex = 0;
            // 
            // CrystalReportViewer_DailyIncome
            // 
            this.CrystalReportViewer_DailyIncome.ActiveViewIndex = -1;
            this.CrystalReportViewer_DailyIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReportViewer_DailyIncome.DisplayBackgroundEdge = false;
            this.CrystalReportViewer_DailyIncome.DisplayGroupTree = false;
            this.CrystalReportViewer_DailyIncome.DisplayStatusBar = false;
            this.CrystalReportViewer_DailyIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReportViewer_DailyIncome.Location = new System.Drawing.Point(0, 0);
            this.CrystalReportViewer_DailyIncome.Name = "CrystalReportViewer_DailyIncome";
            this.CrystalReportViewer_DailyIncome.SelectionFormula = "";
            this.CrystalReportViewer_DailyIncome.ShowCloseButton = false;
            this.CrystalReportViewer_DailyIncome.ShowExportButton = false;
            this.CrystalReportViewer_DailyIncome.ShowGotoPageButton = false;
            this.CrystalReportViewer_DailyIncome.ShowGroupTreeButton = false;
            this.CrystalReportViewer_DailyIncome.ShowPageNavigateButtons = false;
            this.CrystalReportViewer_DailyIncome.ShowRefreshButton = false;
            this.CrystalReportViewer_DailyIncome.ShowTextSearchButton = false;
            this.CrystalReportViewer_DailyIncome.ShowZoomButton = false;
            this.CrystalReportViewer_DailyIncome.Size = new System.Drawing.Size(969, 509);
            this.CrystalReportViewer_DailyIncome.TabIndex = 0;
            this.CrystalReportViewer_DailyIncome.ViewTimeSelectionFormula = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage_Daily);
            this.tabControl1.Controls.Add(this.TabPage_Monthly);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 576);
            this.tabControl1.TabIndex = 3;
            // 
            // TabPage_Daily
            // 
            this.TabPage_Daily.Controls.Add(this.Button_Search_Daily_Income);
            this.TabPage_Daily.Controls.Add(this.DateTimePicker_Daily_Income_Date);
            this.TabPage_Daily.Controls.Add(this.panel1);
            this.TabPage_Daily.Controls.Add(this.label1);
            this.TabPage_Daily.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Daily.Name = "TabPage_Daily";
            this.TabPage_Daily.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Daily.Size = new System.Drawing.Size(984, 550);
            this.TabPage_Daily.TabIndex = 0;
            this.TabPage_Daily.Text = "รายวัน";
            this.TabPage_Daily.UseVisualStyleBackColor = true;
            // 
            // Button_Search_Daily_Income
            // 
            this.Button_Search_Daily_Income.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_Search_Daily_Income.Location = new System.Drawing.Point(265, 6);
            this.Button_Search_Daily_Income.Name = "Button_Search_Daily_Income";
            this.Button_Search_Daily_Income.Size = new System.Drawing.Size(75, 23);
            this.Button_Search_Daily_Income.TabIndex = 5;
            this.Button_Search_Daily_Income.Text = "ค้นหา";
            this.Button_Search_Daily_Income.UseVisualStyleBackColor = true;
            this.Button_Search_Daily_Income.Click += new System.EventHandler(this.Button_Search_Daily_Income_Click);
            // 
            // DateTimePicker_Daily_Income_Date
            // 
            this.DateTimePicker_Daily_Income_Date.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker_Daily_Income_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker_Daily_Income_Date.Location = new System.Drawing.Point(43, 6);
            this.DateTimePicker_Daily_Income_Date.Name = "DateTimePicker_Daily_Income_Date";
            this.DateTimePicker_Daily_Income_Date.Size = new System.Drawing.Size(216, 23);
            this.DateTimePicker_Daily_Income_Date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "วันที่";
            // 
            // TabPage_Monthly
            // 
            this.TabPage_Monthly.Controls.Add(this.groupBox3);
            this.TabPage_Monthly.Controls.Add(this.groupBox2);
            this.TabPage_Monthly.Controls.Add(this.groupBox1);
            this.TabPage_Monthly.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Monthly.Name = "TabPage_Monthly";
            this.TabPage_Monthly.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Monthly.Size = new System.Drawing.Size(984, 550);
            this.TabPage_Monthly.TabIndex = 1;
            this.TabPage_Monthly.Text = "รายเดือน";
            this.TabPage_Monthly.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DateTimePicker3_StartDate);
            this.groupBox3.Controls.Add(this.Button_Generate_Total_Income);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DateTimePicker3_EndDate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(6, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "สรรพากร";
            // 
            // DateTimePicker3_StartDate
            // 
            this.DateTimePicker3_StartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker3_StartDate.Location = new System.Drawing.Point(38, 19);
            this.DateTimePicker3_StartDate.Name = "DateTimePicker3_StartDate";
            this.DateTimePicker3_StartDate.Size = new System.Drawing.Size(230, 23);
            this.DateTimePicker3_StartDate.TabIndex = 0;
            // 
            // Button_Generate_Total_Income
            // 
            this.Button_Generate_Total_Income.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_Generate_Total_Income.Location = new System.Drawing.Point(538, 19);
            this.Button_Generate_Total_Income.Name = "Button_Generate_Total_Income";
            this.Button_Generate_Total_Income.Size = new System.Drawing.Size(75, 23);
            this.Button_Generate_Total_Income.TabIndex = 4;
            this.Button_Generate_Total_Income.Text = "ตกลง";
            this.Button_Generate_Total_Income.UseVisualStyleBackColor = true;
            this.Button_Generate_Total_Income.Click += new System.EventHandler(this.Button_Generate_Total_Income_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "เริ่ม";
            // 
            // DateTimePicker3_EndDate
            // 
            this.DateTimePicker3_EndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker3_EndDate.Location = new System.Drawing.Point(302, 19);
            this.DateTimePicker3_EndDate.Name = "DateTimePicker3_EndDate";
            this.DateTimePicker3_EndDate.Size = new System.Drawing.Size(230, 23);
            this.DateTimePicker3_EndDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(274, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "ถึง";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateTimePicker2_StartDate);
            this.groupBox2.Controls.Add(this.Button_Generate_Monthly_Income);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DateTimePicker2_EndDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "เคาน์เตอร์";
            // 
            // DateTimePicker2_StartDate
            // 
            this.DateTimePicker2_StartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker2_StartDate.Location = new System.Drawing.Point(38, 19);
            this.DateTimePicker2_StartDate.Name = "DateTimePicker2_StartDate";
            this.DateTimePicker2_StartDate.Size = new System.Drawing.Size(230, 23);
            this.DateTimePicker2_StartDate.TabIndex = 0;
            // 
            // Button_Generate_Monthly_Income
            // 
            this.Button_Generate_Monthly_Income.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_Generate_Monthly_Income.Location = new System.Drawing.Point(538, 19);
            this.Button_Generate_Monthly_Income.Name = "Button_Generate_Monthly_Income";
            this.Button_Generate_Monthly_Income.Size = new System.Drawing.Size(75, 23);
            this.Button_Generate_Monthly_Income.TabIndex = 4;
            this.Button_Generate_Monthly_Income.Text = "ตกลง";
            this.Button_Generate_Monthly_Income.UseVisualStyleBackColor = true;
            this.Button_Generate_Monthly_Income.Click += new System.EventHandler(this.Button_Generate_Monthly_Income_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "เริ่ม";
            // 
            // DateTimePicker2_EndDate
            // 
            this.DateTimePicker2_EndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker2_EndDate.Location = new System.Drawing.Point(302, 19);
            this.DateTimePicker2_EndDate.Name = "DateTimePicker2_EndDate";
            this.DateTimePicker2_EndDate.Size = new System.Drawing.Size(230, 23);
            this.DateTimePicker2_EndDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(274, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ถึง";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateTimePicker1_StartDate);
            this.groupBox1.Controls.Add(this.Button_Generate_Course_Income);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DateTimePicker1_EndDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "บัญชี";
            // 
            // DateTimePicker1_StartDate
            // 
            this.DateTimePicker1_StartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker1_StartDate.Location = new System.Drawing.Point(38, 19);
            this.DateTimePicker1_StartDate.Name = "DateTimePicker1_StartDate";
            this.DateTimePicker1_StartDate.Size = new System.Drawing.Size(230, 23);
            this.DateTimePicker1_StartDate.TabIndex = 0;
            // 
            // Button_Generate_Course_Income
            // 
            this.Button_Generate_Course_Income.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_Generate_Course_Income.Location = new System.Drawing.Point(538, 19);
            this.Button_Generate_Course_Income.Name = "Button_Generate_Course_Income";
            this.Button_Generate_Course_Income.Size = new System.Drawing.Size(75, 23);
            this.Button_Generate_Course_Income.TabIndex = 4;
            this.Button_Generate_Course_Income.Text = "ตกลง";
            this.Button_Generate_Course_Income.UseVisualStyleBackColor = true;
            this.Button_Generate_Course_Income.Click += new System.EventHandler(this.Button_Generate_Course_Income_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "เริ่ม";
            // 
            // DateTimePicker1_EndDate
            // 
            this.DateTimePicker1_EndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateTimePicker1_EndDate.Location = new System.Drawing.Point(302, 19);
            this.DateTimePicker1_EndDate.Name = "DateTimePicker1_EndDate";
            this.DateTimePicker1_EndDate.Size = new System.Drawing.Size(230, 23);
            this.DateTimePicker1_EndDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(274, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ถึง";
            // 
            // totalIncomeSummary
            // 
            this.totalIncomeSummary.WorkerReportsProgress = true;
            this.totalIncomeSummary.WorkerSupportsCancellation = true;
            this.totalIncomeSummary.DoWork += new System.ComponentModel.DoWorkEventHandler(this.totalIncomeSummary_DoWork);
            this.totalIncomeSummary.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.totalIncomeSummary_RunWorkerCompleted);
            this.totalIncomeSummary.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.totalIncomeSummary_ProgressChanged);
            // 
            // monthlyIncomeSummary
            // 
            this.monthlyIncomeSummary.WorkerReportsProgress = true;
            this.monthlyIncomeSummary.WorkerSupportsCancellation = true;
            this.monthlyIncomeSummary.DoWork += new System.ComponentModel.DoWorkEventHandler(this.monthlyIncomeSummary_DoWork);
            this.monthlyIncomeSummary.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.monthlyIncomeSummary_RunWorkerCompleted);
            this.monthlyIncomeSummary.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.monthlyIncomeSummary_ProgressChanged);
            // 
            // courseIncomeSummary
            // 
            this.courseIncomeSummary.WorkerReportsProgress = true;
            this.courseIncomeSummary.WorkerSupportsCancellation = true;
            this.courseIncomeSummary.DoWork += new System.ComponentModel.DoWorkEventHandler(this.courseIncomeSummary_DoWork);
            this.courseIncomeSummary.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.courseIncomeSummary_RunWorkerCompleted);
            this.courseIncomeSummary.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.courseIncomeSummary_ProgressChanged);
            // 
            // DailyPaymentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 600);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyPaymentReportForm";
            this.Text = "DailyPaymentReportForm";
            this.Load += new System.EventHandler(this.DailyPaymentReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabPage_Daily.ResumeLayout(false);
            this.TabPage_Daily.PerformLayout();
            this.TabPage_Monthly.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage_Daily;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Daily_Income_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabPage_Monthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePicker1_StartDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker1_EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Generate_Course_Income;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DateTimePicker2_StartDate;
        private System.Windows.Forms.Button Button_Generate_Monthly_Income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimePicker2_EndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Search_Daily_Income;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DateTimePicker3_StartDate;
        private System.Windows.Forms.Button Button_Generate_Total_Income;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimePicker3_EndDate;
        private System.Windows.Forms.Label label7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer_DailyIncome;
        public System.ComponentModel.BackgroundWorker totalIncomeSummary;
        public System.ComponentModel.BackgroundWorker monthlyIncomeSummary;
        public System.ComponentModel.BackgroundWorker courseIncomeSummary;
    }
}