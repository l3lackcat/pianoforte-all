﻿namespace PianoForte.View
{
    partial class TeacherMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMainForm));
            this.DataGridView_TeacherInfo = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBox_SearchCriteria_Student = new System.Windows.Forms.GroupBox();
            this.RadioButton_Show_AllTeacher = new System.Windows.Forms.RadioButton();
            this.RadioButton_Search_TeacherID = new System.Windows.Forms.RadioButton();
            this.ComboBox_Status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_TeacherID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Search = new System.Windows.Forms.Button();
            this.RadioButton_Search_Info = new System.Windows.Forms.RadioButton();
            this.TextBox_Nickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Lastname = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_PreviousPage = new System.Windows.Forms.Button();
            this.Button_NextPage = new System.Windows.Forms.Button();
            this.TextBox_PageNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_NumberPerPage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TeacherInfo)).BeginInit();
            this.GroupBox_SearchCriteria_Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_TeacherInfo
            // 
            this.DataGridView_TeacherInfo.AllowUserToAddRows = false;
            this.DataGridView_TeacherInfo.AllowUserToDeleteRows = false;
            this.DataGridView_TeacherInfo.AllowUserToResizeColumns = false;
            this.DataGridView_TeacherInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridView_TeacherInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.DataGridView_TeacherInfo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DataGridView_TeacherInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView_TeacherInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.DataGridView_TeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TeacherInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.Firstname,
            this.Lastname,
            this.Nickname,
            this.Phone1,
            this.Phone2,
            this.Phone3,
            this.Email,
            this.Status,
            this.ViewButton,
            this.EditButton});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_TeacherInfo.DefaultCellStyle = dataGridViewCellStyle36;
            this.DataGridView_TeacherInfo.Location = new System.Drawing.Point(12, 144);
            this.DataGridView_TeacherInfo.MultiSelect = false;
            this.DataGridView_TeacherInfo.Name = "DataGridView_TeacherInfo";
            this.DataGridView_TeacherInfo.ReadOnly = true;
            this.DataGridView_TeacherInfo.RowHeadersVisible = false;
            this.DataGridView_TeacherInfo.RowTemplate.ReadOnly = true;
            this.DataGridView_TeacherInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_TeacherInfo.Size = new System.Drawing.Size(992, 420);
            this.DataGridView_TeacherInfo.TabIndex = 6;
            this.DataGridView_TeacherInfo.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_TeacherInfo_CellMouseLeave);
            this.DataGridView_TeacherInfo.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_TeacherInfo_CellMouseEnter);
            this.DataGridView_TeacherInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_TeacherInfo_CellClick);
            // 
            // TeacherId
            // 
            this.TeacherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TeacherId.DataPropertyName = "id";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TeacherId.DefaultCellStyle = dataGridViewCellStyle27;
            this.TeacherId.HeaderText = "รหัสอาจารย์";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeacherId.Width = 80;
            // 
            // Firstname
            // 
            this.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Firstname.DataPropertyName = "firstname";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Firstname.DefaultCellStyle = dataGridViewCellStyle28;
            this.Firstname.HeaderText = "ชื่อ";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Firstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Firstname.Width = 110;
            // 
            // Lastname
            // 
            this.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Lastname.DataPropertyName = "lastname";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Lastname.DefaultCellStyle = dataGridViewCellStyle29;
            this.Lastname.HeaderText = "นามสกุล";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lastname.Width = 110;
            // 
            // Nickname
            // 
            this.Nickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nickname.DataPropertyName = "nickname";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Nickname.DefaultCellStyle = dataGridViewCellStyle30;
            this.Nickname.HeaderText = "ชื่อเล่น";
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            this.Nickname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nickname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone1
            // 
            this.Phone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Phone1.DataPropertyName = "phone1";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phone1.DefaultCellStyle = dataGridViewCellStyle31;
            this.Phone1.HeaderText = "เบอร์โทร";
            this.Phone1.Name = "Phone1";
            this.Phone1.ReadOnly = true;
            this.Phone1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Phone1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Phone1.Width = 90;
            // 
            // Phone2
            // 
            this.Phone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Phone2.DataPropertyName = "phone2";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phone2.DefaultCellStyle = dataGridViewCellStyle32;
            this.Phone2.HeaderText = "เบอร์โทร";
            this.Phone2.Name = "Phone2";
            this.Phone2.ReadOnly = true;
            this.Phone2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Phone2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Phone2.Width = 90;
            // 
            // Phone3
            // 
            this.Phone3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Phone3.DataPropertyName = "phone3";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phone3.DefaultCellStyle = dataGridViewCellStyle33;
            this.Phone3.HeaderText = "เบอร์โทร";
            this.Phone3.Name = "Phone3";
            this.Phone3.ReadOnly = true;
            this.Phone3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Phone3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Phone3.Width = 90;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.DataPropertyName = "email";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle34;
            this.Email.HeaderText = "อีเมล์";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Email.Width = 184;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "status";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle35;
            this.Status.HeaderText = "สถานะ";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 80;
            // 
            // ViewButton
            // 
            this.ViewButton.HeaderText = "";
            this.ViewButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewButton.Image")));
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.ReadOnly = true;
            this.ViewButton.Width = 20;
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "";
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Width = 20;
            // 
            // GroupBox_SearchCriteria_Student
            // 
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.RadioButton_Show_AllTeacher);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.RadioButton_Search_TeacherID);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.ComboBox_Status);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.label1);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.Textbox_TeacherID);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.label5);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.Button_Search);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.RadioButton_Search_Info);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.TextBox_Nickname);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.label3);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.label2);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.TextBox_Firstname);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.label4);
            this.GroupBox_SearchCriteria_Student.Controls.Add(this.TextBox_Lastname);
            this.GroupBox_SearchCriteria_Student.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GroupBox_SearchCriteria_Student.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_SearchCriteria_Student.Name = "GroupBox_SearchCriteria_Student";
            this.GroupBox_SearchCriteria_Student.Size = new System.Drawing.Size(992, 126);
            this.GroupBox_SearchCriteria_Student.TabIndex = 11;
            this.GroupBox_SearchCriteria_Student.TabStop = false;
            this.GroupBox_SearchCriteria_Student.Text = "กำหนดข้อมูลการค้นหา";
            // 
            // RadioButton_Show_AllTeacher
            // 
            this.RadioButton_Show_AllTeacher.AutoSize = true;
            this.RadioButton_Show_AllTeacher.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RadioButton_Show_AllTeacher.Location = new System.Drawing.Point(6, 22);
            this.RadioButton_Show_AllTeacher.Name = "RadioButton_Show_AllTeacher";
            this.RadioButton_Show_AllTeacher.Size = new System.Drawing.Size(95, 20);
            this.RadioButton_Show_AllTeacher.TabIndex = 11;
            this.RadioButton_Show_AllTeacher.Text = "แสดงทั้งหมด";
            this.RadioButton_Show_AllTeacher.UseVisualStyleBackColor = true;
            this.RadioButton_Show_AllTeacher.CheckedChanged += new System.EventHandler(this.RadioButton_Show_AllTeacher_CheckedChanged);
            this.RadioButton_Show_AllTeacher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadioButton_Show_AllTeacher_KeyDown);
            // 
            // RadioButton_Search_TeacherID
            // 
            this.RadioButton_Search_TeacherID.AutoSize = true;
            this.RadioButton_Search_TeacherID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RadioButton_Search_TeacherID.Location = new System.Drawing.Point(6, 39);
            this.RadioButton_Search_TeacherID.Name = "RadioButton_Search_TeacherID";
            this.RadioButton_Search_TeacherID.Size = new System.Drawing.Size(141, 20);
            this.RadioButton_Search_TeacherID.TabIndex = 0;
            this.RadioButton_Search_TeacherID.Text = "ค้นหาด้วยรหัสอาจารย์";
            this.RadioButton_Search_TeacherID.UseVisualStyleBackColor = true;
            this.RadioButton_Search_TeacherID.CheckedChanged += new System.EventHandler(this.RadioButton_Search_TeacherID_CheckedChanged);
            this.RadioButton_Search_TeacherID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadioButton_Search_TeacherID_KeyDown);
            // 
            // ComboBox_Status
            // 
            this.ComboBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Status.Enabled = false;
            this.ComboBox_Status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ComboBox_Status.FormattingEnabled = true;
            this.ComboBox_Status.Location = new System.Drawing.Point(776, 58);
            this.ComboBox_Status.Name = "ComboBox_Status";
            this.ComboBox_Status.Size = new System.Drawing.Size(80, 24);
            this.ComboBox_Status.TabIndex = 20;
            this.ComboBox_Status.Visible = false;
            this.ComboBox_Status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_Status_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "รหัสอาจารย์";
            // 
            // Textbox_TeacherID
            // 
            this.Textbox_TeacherID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Textbox_TeacherID.Location = new System.Drawing.Point(100, 59);
            this.Textbox_TeacherID.Name = "Textbox_TeacherID";
            this.Textbox_TeacherID.Size = new System.Drawing.Size(50, 23);
            this.Textbox_TeacherID.TabIndex = 2;
            this.Textbox_TeacherID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_TeacherID_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(726, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "สถานะ";
            this.label5.Visible = false;
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_Search.Location = new System.Drawing.Point(451, 97);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(90, 23);
            this.Button_Search.TabIndex = 10;
            this.Button_Search.Text = "ค้นหา";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // RadioButton_Search_Info
            // 
            this.RadioButton_Search_Info.AutoSize = true;
            this.RadioButton_Search_Info.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RadioButton_Search_Info.Location = new System.Drawing.Point(190, 39);
            this.RadioButton_Search_Info.Name = "RadioButton_Search_Info";
            this.RadioButton_Search_Info.Size = new System.Drawing.Size(140, 20);
            this.RadioButton_Search_Info.TabIndex = 12;
            this.RadioButton_Search_Info.Text = "ค้นหาด้วยข้อมูลทั่วไป";
            this.RadioButton_Search_Info.UseVisualStyleBackColor = true;
            this.RadioButton_Search_Info.CheckedChanged += new System.EventHandler(this.RadioButton_Search_Info_CheckedChanged);
            this.RadioButton_Search_Info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadioButton_Search_Info_KeyDown);
            // 
            // TextBox_Nickname
            // 
            this.TextBox_Nickname.Enabled = false;
            this.TextBox_Nickname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TextBox_Nickname.Location = new System.Drawing.Point(600, 59);
            this.TextBox_Nickname.Name = "TextBox_Nickname";
            this.TextBox_Nickname.Size = new System.Drawing.Size(120, 23);
            this.TextBox_Nickname.TabIndex = 18;
            this.TextBox_Nickname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Nickname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(364, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(208, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ชื่อ";
            // 
            // TextBox_Firstname
            // 
            this.TextBox_Firstname.Enabled = false;
            this.TextBox_Firstname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TextBox_Firstname.Location = new System.Drawing.Point(238, 59);
            this.TextBox_Firstname.Name = "TextBox_Firstname";
            this.TextBox_Firstname.Size = new System.Drawing.Size(120, 23);
            this.TextBox_Firstname.TabIndex = 16;
            this.TextBox_Firstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Firstname_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(550, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "ชื่อเล่น";
            // 
            // TextBox_Lastname
            // 
            this.TextBox_Lastname.Enabled = false;
            this.TextBox_Lastname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TextBox_Lastname.Location = new System.Drawing.Point(424, 59);
            this.TextBox_Lastname.Name = "TextBox_Lastname";
            this.TextBox_Lastname.Size = new System.Drawing.Size(120, 23);
            this.TextBox_Lastname.TabIndex = 17;
            this.TextBox_Lastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Lastname_KeyDown);
            // 
            // Button_Add
            // 
            this.Button_Add.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_Add.Location = new System.Drawing.Point(904, 570);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(100, 25);
            this.Button_Add.TabIndex = 12;
            this.Button_Add.Text = "เพิ่ม";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_PreviousPage
            // 
            this.Button_PreviousPage.Location = new System.Drawing.Point(466, 570);
            this.Button_PreviousPage.Name = "Button_PreviousPage";
            this.Button_PreviousPage.Size = new System.Drawing.Size(25, 25);
            this.Button_PreviousPage.TabIndex = 17;
            this.Button_PreviousPage.Text = "<";
            this.Button_PreviousPage.UseVisualStyleBackColor = true;
            this.Button_PreviousPage.Click += new System.EventHandler(this.Button_PreviousPage_Click);
            // 
            // Button_NextPage
            // 
            this.Button_NextPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Button_NextPage.Location = new System.Drawing.Point(528, 570);
            this.Button_NextPage.Name = "Button_NextPage";
            this.Button_NextPage.Size = new System.Drawing.Size(25, 25);
            this.Button_NextPage.TabIndex = 16;
            this.Button_NextPage.Text = ">";
            this.Button_NextPage.UseVisualStyleBackColor = true;
            this.Button_NextPage.Click += new System.EventHandler(this.Button_NextPage_Click);
            // 
            // TextBox_PageNumber
            // 
            this.TextBox_PageNumber.Enabled = false;
            this.TextBox_PageNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TextBox_PageNumber.Location = new System.Drawing.Point(497, 571);
            this.TextBox_PageNumber.Name = "TextBox_PageNumber";
            this.TextBox_PageNumber.Size = new System.Drawing.Size(25, 23);
            this.TextBox_PageNumber.TabIndex = 15;
            this.TextBox_PageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_PageNumber.TextChanged += new System.EventHandler(this.TextBox_PageNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "จำนวนต่อหน้า";
            // 
            // ComboBox_NumberPerPage
            // 
            this.ComboBox_NumberPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_NumberPerPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ComboBox_NumberPerPage.FormattingEnabled = true;
            this.ComboBox_NumberPerPage.Location = new System.Drawing.Point(88, 571);
            this.ComboBox_NumberPerPage.Name = "ComboBox_NumberPerPage";
            this.ComboBox_NumberPerPage.Size = new System.Drawing.Size(50, 24);
            this.ComboBox_NumberPerPage.TabIndex = 13;
            this.ComboBox_NumberPerPage.SelectedIndexChanged += new System.EventHandler(this.ComboBox_NumberPerPage_SelectedIndexChanged);
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 600);
            this.Controls.Add(this.Button_PreviousPage);
            this.Controls.Add(this.Button_NextPage);
            this.Controls.Add(this.TextBox_PageNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBox_NumberPerPage);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.GroupBox_SearchCriteria_Student);
            this.Controls.Add(this.DataGridView_TeacherInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherMainForm";
            this.Text = "Teacher Manager";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TeacherInfo)).EndInit();
            this.GroupBox_SearchCriteria_Student.ResumeLayout(false);
            this.GroupBox_SearchCriteria_Student.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_TeacherInfo;
        private System.Windows.Forms.GroupBox GroupBox_SearchCriteria_Student;
        private System.Windows.Forms.RadioButton RadioButton_Show_AllTeacher;
        private System.Windows.Forms.RadioButton RadioButton_Search_TeacherID;
        private System.Windows.Forms.ComboBox ComboBox_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_TeacherID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.RadioButton RadioButton_Search_Info;
        private System.Windows.Forms.TextBox TextBox_Nickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn ViewButton;
        private System.Windows.Forms.DataGridViewImageColumn EditButton;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_PreviousPage;
        private System.Windows.Forms.Button Button_NextPage;
        private System.Windows.Forms.TextBox TextBox_PageNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_NumberPerPage;
    }
}