﻿namespace _1_Lab_Library
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookFund = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoundedYear = new System.Windows.Forms.TextBox();
            this.chkDigitalLibrary = new System.Windows.Forms.CheckBox();
            this.btnCreateLibrary = new System.Windows.Forms.Button();
            this.btnShowHex = new System.Windows.Forms.Button();
            this.lblObjectCount = new System.Windows.Forms.Label();
            this.btnClose_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.standartConstruct = new System.Windows.Forms.CheckBox();
            this.builder = new System.Windows.Forms.CheckBox();
            this.btnUpdateFields = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sixteenx = new System.Windows.Forms.Label();
            this.listViewforTests = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRunTest = new System.Windows.Forms.Button();
            this.ContainerLibraries = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textfromcont = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(4, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Библиотека";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фонд книг";
            // 
            // txtBookFund
            // 
            this.txtBookFund.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookFund.Location = new System.Drawing.Point(4, 89);
            this.txtBookFund.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookFund.Name = "txtBookFund";
            this.txtBookFund.Size = new System.Drawing.Size(181, 26);
            this.txtBookFund.TabIndex = 3;
            this.txtBookFund.Text = "100";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Абонентская плата";
            // 
            // txtFee
            // 
            this.txtFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFee.Location = new System.Drawing.Point(4, 146);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(181, 26);
            this.txtFee.TabIndex = 7;
            this.txtFee.Text = "100";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Места";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSeats
            // 
            this.txtSeats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeats.Location = new System.Drawing.Point(4, 202);
            this.txtSeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(181, 26);
            this.txtSeats.TabIndex = 5;
            this.txtSeats.Text = "100";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Год основания";
            // 
            // txtFoundedYear
            // 
            this.txtFoundedYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoundedYear.Location = new System.Drawing.Point(4, 258);
            this.txtFoundedYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoundedYear.Name = "txtFoundedYear";
            this.txtFoundedYear.Size = new System.Drawing.Size(181, 26);
            this.txtFoundedYear.TabIndex = 9;
            this.txtFoundedYear.Text = "1999";
            this.txtFoundedYear.TextChanged += new System.EventHandler(this.txtFoundedYear_TextChanged);
            // 
            // chkDigitalLibrary
            // 
            this.chkDigitalLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDigitalLibrary.AutoSize = true;
            this.chkDigitalLibrary.Location = new System.Drawing.Point(4, 303);
            this.chkDigitalLibrary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDigitalLibrary.Name = "chkDigitalLibrary";
            this.chkDigitalLibrary.Size = new System.Drawing.Size(231, 24);
            this.chkDigitalLibrary.TabIndex = 11;
            this.chkDigitalLibrary.Text = "Электронная библиотека";
            this.chkDigitalLibrary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkDigitalLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkDigitalLibrary.UseVisualStyleBackColor = true;
            // 
            // btnCreateLibrary
            // 
            this.btnCreateLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateLibrary.Location = new System.Drawing.Point(4, 338);
            this.btnCreateLibrary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateLibrary.Name = "btnCreateLibrary";
            this.btnCreateLibrary.Size = new System.Drawing.Size(217, 54);
            this.btnCreateLibrary.TabIndex = 12;
            this.btnCreateLibrary.Text = "Создать библиотеку";
            this.btnCreateLibrary.UseVisualStyleBackColor = true;
            this.btnCreateLibrary.Click += new System.EventHandler(this.btnCreateLibrary_Click_1);
            // 
            // btnShowHex
            // 
            this.btnShowHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHex.Location = new System.Drawing.Point(4, 531);
            this.btnShowHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowHex.Name = "btnShowHex";
            this.btnShowHex.Size = new System.Drawing.Size(217, 54);
            this.btnShowHex.TabIndex = 18;
            this.btnShowHex.Text = "Показать фонд в 16-ричном формате";
            this.btnShowHex.UseVisualStyleBackColor = true;
            this.btnShowHex.Click += new System.EventHandler(this.btnShowHex_Click);
            // 
            // lblObjectCount
            // 
            this.lblObjectCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObjectCount.AutoSize = true;
            this.lblObjectCount.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblObjectCount.Location = new System.Drawing.Point(394, 62);
            this.lblObjectCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjectCount.Name = "lblObjectCount";
            this.lblObjectCount.Size = new System.Drawing.Size(312, 30);
            this.lblObjectCount.TabIndex = 19;
            this.lblObjectCount.Text = "Количество библиотек: 0 ";
            // 
            // btnClose_Click
            // 
            this.btnClose_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose_Click.Location = new System.Drawing.Point(1259, 619);
            this.btnClose_Click.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose_Click.Name = "btnClose_Click";
            this.btnClose_Click.Size = new System.Drawing.Size(184, 54);
            this.btnClose_Click.TabIndex = 25;
            this.btnClose_Click.Text = "Выход";
            this.btnClose_Click.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-3, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Создание библиотек";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.standartConstruct);
            this.panel1.Controls.Add(this.builder);
            this.panel1.Controls.Add(this.btnUpdateFields);
            this.panel1.Controls.Add(this.txtSeats);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFoundedYear);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBookFund);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnShowHex);
            this.panel1.Controls.Add(this.txtFee);
            this.panel1.Controls.Add(this.btnCreateLibrary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkDigitalLibrary);
            this.panel1.Location = new System.Drawing.Point(3, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 625);
            this.panel1.TabIndex = 28;
            // 
            // standartConstruct
            // 
            this.standartConstruct.AutoSize = true;
            this.standartConstruct.Location = new System.Drawing.Point(6, 403);
            this.standartConstruct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.standartConstruct.Name = "standartConstruct";
            this.standartConstruct.Size = new System.Drawing.Size(238, 24);
            this.standartConstruct.TabIndex = 21;
            this.standartConstruct.Text = "Стандартный конструктор";
            this.standartConstruct.UseVisualStyleBackColor = true;
            this.standartConstruct.CheckedChanged += new System.EventHandler(this.standartConstruct_CheckedChanged);
            // 
            // builder
            // 
            this.builder.AutoSize = true;
            this.builder.Checked = true;
            this.builder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.builder.Location = new System.Drawing.Point(4, 438);
            this.builder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.builder.Name = "builder";
            this.builder.Size = new System.Drawing.Size(119, 24);
            this.builder.TabIndex = 20;
            this.builder.Text = "Строитель";
            this.builder.UseVisualStyleBackColor = true;
            this.builder.CheckedChanged += new System.EventHandler(this.builder_CheckedChanged);
            // 
            // btnUpdateFields
            // 
            this.btnUpdateFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFields.Location = new System.Drawing.Point(3, 470);
            this.btnUpdateFields.Name = "btnUpdateFields";
            this.btnUpdateFields.Size = new System.Drawing.Size(217, 54);
            this.btnUpdateFields.TabIndex = 13;
            this.btnUpdateFields.Text = "Обновить";
            this.btnUpdateFields.UseVisualStyleBackColor = true;
            this.btnUpdateFields.Click += new System.EventHandler(this.btnUpdateFields_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(730, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 37);
            this.label10.TabIndex = 29;
            this.label10.Text = "Библиотека";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(453, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "Удалить библиотеку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(657, 555);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 54);
            this.button2.TabIndex = 34;
            this.button2.Text = "Очистить контейнер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // sixteenx
            // 
            this.sixteenx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sixteenx.AutoSize = true;
            this.sixteenx.Location = new System.Drawing.Point(284, 651);
            this.sixteenx.Name = "sixteenx";
            this.sixteenx.Size = new System.Drawing.Size(0, 20);
            this.sixteenx.TabIndex = 35;
            // 
            // listViewforTests
            // 
            this.listViewforTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewforTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewforTests.HideSelection = false;
            this.listViewforTests.Location = new System.Drawing.Point(1087, 118);
            this.listViewforTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewforTests.Name = "listViewforTests";
            this.listViewforTests.Size = new System.Drawing.Size(356, 428);
            this.listViewforTests.TabIndex = 38;
            this.listViewforTests.UseCompatibleStateImageBehavior = false;
            this.listViewforTests.View = System.Windows.Forms.View.Details;
            this.listViewforTests.SelectedIndexChanged += new System.EventHandler(this.listViewforTests_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "ColumnHeader";
            this.columnHeader1.Text = "Тип опер.";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Стр. данных";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Время (мс)";
            this.columnHeader3.Width = 70;
            // 
            // btnRunTest
            // 
            this.btnRunTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTest.Location = new System.Drawing.Point(1087, 555);
            this.btnRunTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(184, 54);
            this.btnRunTest.TabIndex = 39;
            this.btnRunTest.Text = "Выполнить тест замер";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // ContainerLibraries
            // 
            this.ContainerLibraries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerLibraries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ContainerLibraries.HideSelection = false;
            this.ContainerLibraries.Location = new System.Drawing.Point(453, 118);
            this.ContainerLibraries.Name = "ContainerLibraries";
            this.ContainerLibraries.Size = new System.Drawing.Size(628, 428);
            this.ContainerLibraries.TabIndex = 40;
            this.ContainerLibraries.UseCompatibleStateImageBehavior = false;
            this.ContainerLibraries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Название";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Фонд Книг";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Абонент. плата";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Места";
            this.columnHeader7.Width = 45;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Год основания";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Элек. библиотека?";
            this.columnHeader9.Width = 70;
            // 
            // textfromcont
            // 
            this.textfromcont.AutoSize = true;
            this.textfromcont.Location = new System.Drawing.Point(284, 608);
            this.textfromcont.Name = "textfromcont";
            this.textfromcont.Size = new System.Drawing.Size(0, 20);
            this.textfromcont.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1535, 762);
            this.Controls.Add(this.textfromcont);
            this.Controls.Add(this.ContainerLibraries);
            this.Controls.Add(this.btnRunTest);
            this.Controls.Add(this.listViewforTests);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sixteenx);
            this.Controls.Add(this.lblObjectCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose_Click);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Библиотека_Осин_Серегин_23ВП2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookFund;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoundedYear;
        private System.Windows.Forms.CheckBox chkDigitalLibrary;
        private System.Windows.Forms.Button btnCreateLibrary;
        private System.Windows.Forms.Button btnShowHex;
        private System.Windows.Forms.Label lblObjectCount;
        private System.Windows.Forms.Button btnClose_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sixteenx;
        private System.Windows.Forms.Button btnUpdateFields;
        private System.Windows.Forms.ListView listViewforTests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.ListView ContainerLibraries;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label textfromcont;
        private System.Windows.Forms.CheckBox builder;
        private System.Windows.Forms.CheckBox standartConstruct;
    }
}

