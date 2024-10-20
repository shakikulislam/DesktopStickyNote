namespace DesktopStickyNote
{
    partial class FormSettings
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.groupBoxRemainderTime = new System.Windows.Forms.GroupBox();
            this.buttonRemainderUpdate = new System.Windows.Forms.Button();
            this.labelNewRemainderTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxRemainderMunite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRemainderHour = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.labelFontStyle = new System.Windows.Forms.Label();
            this.labelFontFamily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAlwaysVisible = new System.Windows.Forms.CheckBox();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelReminder = new System.Windows.Forms.Panel();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.listViewCategory = new System.Windows.Forms.ListView();
            this.columnHeaderCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonCancelCategory = new System.Windows.Forms.Button();
            this.textBoxNewCategory = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.listViewEventList = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFromDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderToDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFromDateFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderToDateFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxEvent = new System.Windows.Forms.GroupBox();
            this.pictureBoxDeleteEvent = new System.Windows.Forms.PictureBox();
            this.buttonCancelEvent = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxAddCategory = new System.Windows.Forms.PictureBox();
            this.comboBoxCaregory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRemainder = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.groupBoxRemainderTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelReminder.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelSideMenu.Controls.Add(this.buttonReminder);
            this.panelSideMenu.Controls.Add(this.buttonSettings);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 3);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(133, 434);
            this.panelSideMenu.TabIndex = 5;
            // 
            // buttonReminder
            // 
            this.buttonReminder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReminder.FlatAppearance.BorderSize = 0;
            this.buttonReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReminder.ForeColor = System.Drawing.Color.White;
            this.buttonReminder.Location = new System.Drawing.Point(0, 42);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(133, 42);
            this.buttonReminder.TabIndex = 1;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(0, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(133, 42);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.White;
            this.panelSetting.Controls.Add(this.groupBoxRemainderTime);
            this.panelSetting.Controls.Add(this.panel1);
            this.panelSetting.Controls.Add(this.labelFontSize);
            this.panelSetting.Controls.Add(this.labelFontStyle);
            this.panelSetting.Controls.Add(this.labelFontFamily);
            this.panelSetting.Controls.Add(this.label3);
            this.panelSetting.Controls.Add(this.label4);
            this.panelSetting.Controls.Add(this.label5);
            this.panelSetting.Controls.Add(this.buttonSelectFont);
            this.panelSetting.Controls.Add(this.label2);
            this.panelSetting.Controls.Add(this.label1);
            this.panelSetting.Controls.Add(this.checkBoxAlwaysVisible);
            this.panelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSetting.Location = new System.Drawing.Point(150, 8);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(365, 290);
            this.panelSetting.TabIndex = 1;
            this.panelSetting.Visible = false;
            // 
            // groupBoxRemainderTime
            // 
            this.groupBoxRemainderTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRemainderTime.Controls.Add(this.buttonRemainderUpdate);
            this.groupBoxRemainderTime.Controls.Add(this.labelNewRemainderTime);
            this.groupBoxRemainderTime.Controls.Add(this.label12);
            this.groupBoxRemainderTime.Controls.Add(this.label11);
            this.groupBoxRemainderTime.Controls.Add(this.comboBoxRemainderMunite);
            this.groupBoxRemainderTime.Controls.Add(this.label7);
            this.groupBoxRemainderTime.Controls.Add(this.comboBoxRemainderHour);
            this.groupBoxRemainderTime.Location = new System.Drawing.Point(9, 59);
            this.groupBoxRemainderTime.Name = "groupBoxRemainderTime";
            this.groupBoxRemainderTime.Size = new System.Drawing.Size(347, 81);
            this.groupBoxRemainderTime.TabIndex = 14;
            this.groupBoxRemainderTime.TabStop = false;
            this.groupBoxRemainderTime.Text = "Remainder Time";
            // 
            // buttonRemainderUpdate
            // 
            this.buttonRemainderUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonRemainderUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemainderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemainderUpdate.ForeColor = System.Drawing.Color.Green;
            this.buttonRemainderUpdate.Location = new System.Drawing.Point(264, 26);
            this.buttonRemainderUpdate.Name = "buttonRemainderUpdate";
            this.buttonRemainderUpdate.Size = new System.Drawing.Size(69, 42);
            this.buttonRemainderUpdate.TabIndex = 15;
            this.buttonRemainderUpdate.Text = "Update";
            this.buttonRemainderUpdate.UseVisualStyleBackColor = true;
            this.buttonRemainderUpdate.Click += new System.EventHandler(this.buttonRemainderUpdate_Click);
            // 
            // labelNewRemainderTime
            // 
            this.labelNewRemainderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewRemainderTime.ForeColor = System.Drawing.Color.Green;
            this.labelNewRemainderTime.Location = new System.Drawing.Point(182, 48);
            this.labelNewRemainderTime.Name = "labelNewRemainderTime";
            this.labelNewRemainderTime.Size = new System.Drawing.Size(82, 20);
            this.labelNewRemainderTime.TabIndex = 17;
            this.labelNewRemainderTime.Text = "00.00";
            this.labelNewRemainderTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "New Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Minute";
            // 
            // comboBoxRemainderMunite
            // 
            this.comboBoxRemainderMunite.DropDownHeight = 150;
            this.comboBoxRemainderMunite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemainderMunite.FormattingEnabled = true;
            this.comboBoxRemainderMunite.IntegralHeight = false;
            this.comboBoxRemainderMunite.ItemHeight = 16;
            this.comboBoxRemainderMunite.Location = new System.Drawing.Point(92, 46);
            this.comboBoxRemainderMunite.Name = "comboBoxRemainderMunite";
            this.comboBoxRemainderMunite.Size = new System.Drawing.Size(87, 24);
            this.comboBoxRemainderMunite.TabIndex = 15;
            this.comboBoxRemainderMunite.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemainderHour_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hour";
            // 
            // comboBoxRemainderHour
            // 
            this.comboBoxRemainderHour.DropDownHeight = 150;
            this.comboBoxRemainderHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemainderHour.FormattingEnabled = true;
            this.comboBoxRemainderHour.IntegralHeight = false;
            this.comboBoxRemainderHour.ItemHeight = 16;
            this.comboBoxRemainderHour.Location = new System.Drawing.Point(28, 46);
            this.comboBoxRemainderHour.Name = "comboBoxRemainderHour";
            this.comboBoxRemainderHour.Size = new System.Drawing.Size(65, 24);
            this.comboBoxRemainderHour.TabIndex = 13;
            this.comboBoxRemainderHour.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemainderHour_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 26);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Settings";
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(171, 198);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(16, 17);
            this.labelFontSize.TabIndex = 6;
            this.labelFontSize.Text = "0";
            // 
            // labelFontStyle
            // 
            this.labelFontStyle.AutoSize = true;
            this.labelFontStyle.Location = new System.Drawing.Point(171, 175);
            this.labelFontStyle.Name = "labelFontStyle";
            this.labelFontStyle.Size = new System.Drawing.Size(16, 17);
            this.labelFontStyle.TabIndex = 5;
            this.labelFontStyle.Text = "0";
            // 
            // labelFontFamily
            // 
            this.labelFontFamily.AutoSize = true;
            this.labelFontFamily.Location = new System.Drawing.Point(171, 152);
            this.labelFontFamily.Name = "labelFontFamily";
            this.labelFontFamily.Size = new System.Drawing.Size(16, 17);
            this.labelFontFamily.TabIndex = 4;
            this.labelFontFamily.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Font Style :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Font Family :";
            // 
            // buttonSelectFont
            // 
            this.buttonSelectFont.Location = new System.Drawing.Point(114, 225);
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.Size = new System.Drawing.Size(127, 28);
            this.buttonSelectFont.TabIndex = 3;
            this.buttonSelectFont.Text = "Select Font";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            this.buttonSelectFont.Click += new System.EventHandler(this.buttonSelectFont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visibility";
            // 
            // checkBoxAlwaysVisible
            // 
            this.checkBoxAlwaysVisible.AutoSize = true;
            this.checkBoxAlwaysVisible.Location = new System.Drawing.Point(82, 32);
            this.checkBoxAlwaysVisible.Name = "checkBoxAlwaysVisible";
            this.checkBoxAlwaysVisible.Size = new System.Drawing.Size(115, 21);
            this.checkBoxAlwaysVisible.TabIndex = 0;
            this.checkBoxAlwaysVisible.Text = "Always Visible";
            this.checkBoxAlwaysVisible.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysVisible.CheckedChanged += new System.EventHandler(this.checkBoxAlwaysVisible_CheckedChanged);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(523, 3);
            this.panelTopBar.TabIndex = 0;
            // 
            // panelReminder
            // 
            this.panelReminder.BackColor = System.Drawing.Color.White;
            this.panelReminder.Controls.Add(this.groupBoxCategory);
            this.panelReminder.Controls.Add(this.listViewEventList);
            this.panelReminder.Controls.Add(this.groupBoxEvent);
            this.panelReminder.Controls.Add(this.pictureBoxAddCategory);
            this.panelReminder.Controls.Add(this.comboBoxCaregory);
            this.panelReminder.Controls.Add(this.panel2);
            this.panelReminder.Controls.Add(this.label15);
            this.panelReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReminder.Location = new System.Drawing.Point(150, 398);
            this.panelReminder.Name = "panelReminder";
            this.panelReminder.Size = new System.Drawing.Size(370, 27);
            this.panelReminder.TabIndex = 11;
            this.panelReminder.Visible = false;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxCategory.Controls.Add(this.listViewCategory);
            this.groupBoxCategory.Controls.Add(this.buttonDeleteCategory);
            this.groupBoxCategory.Controls.Add(this.buttonCancelCategory);
            this.groupBoxCategory.Controls.Add(this.textBoxNewCategory);
            this.groupBoxCategory.Controls.Add(this.buttonAddCategory);
            this.groupBoxCategory.Location = new System.Drawing.Point(10, 70);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(350, 24);
            this.groupBoxCategory.TabIndex = 21;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "New Category";
            this.groupBoxCategory.Visible = false;
            // 
            // listViewCategory
            // 
            this.listViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCategoryId,
            this.columnHeaderCategoryName});
            this.listViewCategory.FullRowSelect = true;
            this.listViewCategory.GridLines = true;
            this.listViewCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCategory.Location = new System.Drawing.Point(6, 81);
            this.listViewCategory.MultiSelect = false;
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.Size = new System.Drawing.Size(338, 0);
            this.listViewCategory.TabIndex = 21;
            this.listViewCategory.UseCompatibleStateImageBehavior = false;
            this.listViewCategory.View = System.Windows.Forms.View.Details;
            this.listViewCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCategory_MouseDoubleClick);
            // 
            // columnHeaderCategoryId
            // 
            this.columnHeaderCategoryId.Text = "Id";
            this.columnHeaderCategoryId.Width = 0;
            // 
            // columnHeaderCategoryName
            // 
            this.columnHeaderCategoryName.Text = "Category";
            this.columnHeaderCategoryName.Width = 300;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(46, 49);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(86, 28);
            this.buttonDeleteCategory.TabIndex = 19;
            this.buttonDeleteCategory.Text = "Delete";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Visible = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonCancelCategory
            // 
            this.buttonCancelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelCategory.Location = new System.Drawing.Point(138, 49);
            this.buttonCancelCategory.Name = "buttonCancelCategory";
            this.buttonCancelCategory.Size = new System.Drawing.Size(86, 28);
            this.buttonCancelCategory.TabIndex = 18;
            this.buttonCancelCategory.Text = "Cancel";
            this.buttonCancelCategory.UseVisualStyleBackColor = true;
            this.buttonCancelCategory.Visible = false;
            this.buttonCancelCategory.Click += new System.EventHandler(this.buttonCancelCategory_Click);
            // 
            // textBoxNewCategory
            // 
            this.textBoxNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewCategory.Location = new System.Drawing.Point(6, 21);
            this.textBoxNewCategory.Name = "textBoxNewCategory";
            this.textBoxNewCategory.Size = new System.Drawing.Size(338, 23);
            this.textBoxNewCategory.TabIndex = 13;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCategory.Location = new System.Drawing.Point(230, 47);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(114, 28);
            this.buttonAddCategory.TabIndex = 17;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // listViewEventList
            // 
            this.listViewEventList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderCategory,
            this.columnHeaderFromDate,
            this.columnHeaderToDate,
            this.columnHeaderDetails,
            this.columnHeaderFromDateFull,
            this.columnHeaderToDateFull});
            this.listViewEventList.FullRowSelect = true;
            this.listViewEventList.GridLines = true;
            this.listViewEventList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEventList.Location = new System.Drawing.Point(10, 256);
            this.listViewEventList.MultiSelect = false;
            this.listViewEventList.Name = "listViewEventList";
            this.listViewEventList.Size = new System.Drawing.Size(351, 2);
            this.listViewEventList.TabIndex = 20;
            this.listViewEventList.UseCompatibleStateImageBehavior = false;
            this.listViewEventList.View = System.Windows.Forms.View.Details;
            this.listViewEventList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewEventList_MouseDoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 0;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 150;
            // 
            // columnHeaderFromDate
            // 
            this.columnHeaderFromDate.Text = "From";
            this.columnHeaderFromDate.Width = 80;
            // 
            // columnHeaderToDate
            // 
            this.columnHeaderToDate.Text = "To";
            this.columnHeaderToDate.Width = 80;
            // 
            // columnHeaderDetails
            // 
            this.columnHeaderDetails.Text = "Details";
            this.columnHeaderDetails.Width = 100;
            // 
            // columnHeaderFromDateFull
            // 
            this.columnHeaderFromDateFull.Text = "From Full";
            this.columnHeaderFromDateFull.Width = 0;
            // 
            // columnHeaderToDateFull
            // 
            this.columnHeaderToDateFull.Text = "To Full";
            this.columnHeaderToDateFull.Width = 0;
            // 
            // groupBoxEvent
            // 
            this.groupBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEvent.Controls.Add(this.pictureBoxDeleteEvent);
            this.groupBoxEvent.Controls.Add(this.buttonCancelEvent);
            this.groupBoxEvent.Controls.Add(this.buttonAddEvent);
            this.groupBoxEvent.Controls.Add(this.label10);
            this.groupBoxEvent.Controls.Add(this.dateTimePickerTo);
            this.groupBoxEvent.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxEvent.Controls.Add(this.label9);
            this.groupBoxEvent.Controls.Add(this.richTextBoxDetails);
            this.groupBoxEvent.Controls.Add(this.label8);
            this.groupBoxEvent.Location = new System.Drawing.Point(10, 70);
            this.groupBoxEvent.Name = "groupBoxEvent";
            this.groupBoxEvent.Size = new System.Drawing.Size(350, 180);
            this.groupBoxEvent.TabIndex = 18;
            this.groupBoxEvent.TabStop = false;
            this.groupBoxEvent.Text = "New Event";
            // 
            // pictureBoxDeleteEvent
            // 
            this.pictureBoxDeleteEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDeleteEvent.Image = global::DesktopStickyNote.Properties.Resources.trash_64;
            this.pictureBoxDeleteEvent.Location = new System.Drawing.Point(241, 140);
            this.pictureBoxDeleteEvent.Name = "pictureBoxDeleteEvent";
            this.pictureBoxDeleteEvent.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxDeleteEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDeleteEvent.TabIndex = 25;
            this.pictureBoxDeleteEvent.TabStop = false;
            this.pictureBoxDeleteEvent.Click += new System.EventHandler(this.pictureBoxDeleteEvent_Click);
            // 
            // buttonCancelEvent
            // 
            this.buttonCancelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancelEvent.Location = new System.Drawing.Point(273, 137);
            this.buttonCancelEvent.Name = "buttonCancelEvent";
            this.buttonCancelEvent.Size = new System.Drawing.Size(71, 30);
            this.buttonCancelEvent.TabIndex = 24;
            this.buttonCancelEvent.Text = "Cancel";
            this.buttonCancelEvent.UseVisualStyleBackColor = false;
            this.buttonCancelEvent.Click += new System.EventHandler(this.buttonCancelEvent_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEvent.Location = new System.Drawing.Point(243, 108);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(101, 30);
            this.buttonAddEvent.TabIndex = 19;
            this.buttonAddEvent.Text = "Update";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "To Date";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CustomFormat = "";
            this.dateTimePickerTo.Location = new System.Drawing.Point(91, 141);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(146, 23);
            this.dateTimePickerTo.TabIndex = 22;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CustomFormat = "";
            this.dateTimePickerFrom.Location = new System.Drawing.Point(91, 110);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(146, 23);
            this.dateTimePickerFrom.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "From Date";
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDetails.Location = new System.Drawing.Point(91, 22);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.Size = new System.Drawing.Size(253, 82);
            this.richTextBoxDetails.TabIndex = 19;
            this.richTextBoxDetails.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Details";
            // 
            // pictureBoxAddCategory
            // 
            this.pictureBoxAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAddCategory.Image = global::DesktopStickyNote.Properties.Resources.edit_property_64;
            this.pictureBoxAddCategory.Location = new System.Drawing.Point(332, 30);
            this.pictureBoxAddCategory.Name = "pictureBoxAddCategory";
            this.pictureBoxAddCategory.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddCategory.TabIndex = 15;
            this.pictureBoxAddCategory.TabStop = false;
            this.pictureBoxAddCategory.Click += new System.EventHandler(this.pictureBoxAddCategory_Click);
            // 
            // comboBoxCaregory
            // 
            this.comboBoxCaregory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCaregory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCaregory.FormattingEnabled = true;
            this.comboBoxCaregory.Location = new System.Drawing.Point(82, 35);
            this.comboBoxCaregory.Name = "comboBoxCaregory";
            this.comboBoxCaregory.Size = new System.Drawing.Size(244, 24);
            this.comboBoxCaregory.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRemainder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 26);
            this.panel2.TabIndex = 12;
            // 
            // labelRemainder
            // 
            this.labelRemainder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemainder.AutoSize = true;
            this.labelRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainder.Location = new System.Drawing.Point(290, 5);
            this.labelRemainder.Name = "labelRemainder";
            this.labelRemainder.Size = new System.Drawing.Size(75, 16);
            this.labelRemainder.TabIndex = 10;
            this.labelRemainder.Text = "Reminder";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Category";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 437);
            this.Controls.Add(this.panelReminder);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.groupBoxRemainderTime.ResumeLayout(false);
            this.groupBoxRemainderTime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelReminder.ResumeLayout(false);
            this.panelReminder.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.groupBoxEvent.ResumeLayout(false);
            this.groupBoxEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.CheckBox checkBoxAlwaysVisible;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label labelFontStyle;
        private System.Windows.Forms.Label labelFontFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelReminder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRemainder;
        private System.Windows.Forms.ComboBox comboBoxCaregory;
        private System.Windows.Forms.TextBox textBoxNewCategory;
        private System.Windows.Forms.PictureBox pictureBoxAddCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.GroupBox groupBoxEvent;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.ListView listViewEventList;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderFromDate;
        private System.Windows.Forms.ColumnHeader columnHeaderToDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderFromDateFull;
        private System.Windows.Forms.ColumnHeader columnHeaderToDateFull;
        private System.Windows.Forms.Button buttonCancelEvent;
        private System.Windows.Forms.PictureBox pictureBoxDeleteEvent;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonCancelCategory;
        private System.Windows.Forms.ListView listViewCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoryId;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxRemainderTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxRemainderMunite;
        private System.Windows.Forms.ComboBox comboBoxRemainderHour;
        private System.Windows.Forms.Label labelNewRemainderTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonRemainderUpdate;

    }
}