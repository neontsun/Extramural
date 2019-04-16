namespace ЗаочноеОтделение
{
    partial class MainForm
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.selfTab = new System.Windows.Forms.TabPage();
            this.selfTabToolsSeparatorVertical2 = new System.Windows.Forms.Panel();
            this.selfTabToolsSeparatorVertical1 = new System.Windows.Forms.Panel();
            this.selfTabToolsSeparatorHorizontal = new System.Windows.Forms.Panel();
            this.selfTabDataTable = new System.Windows.Forms.ListView();
            this.ozenkiTab = new System.Windows.Forms.TabPage();
            this.ozenkiTabToolsSeparatorVertical2 = new System.Windows.Forms.Panel();
            this.ozenkiTabToolsSeparatorVertical1 = new System.Windows.Forms.Panel();
            this.ozenkiTabToolsSeparatorHorizontal = new System.Windows.Forms.Panel();
            this.ozenkiTabDataTable = new System.Windows.Forms.ListView();
            this.subjectTab = new System.Windows.Forms.TabPage();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectTabDataTable = new System.Windows.Forms.ListView();
            this.subjectTabToolsSeparatorHorizontal = new System.Windows.Forms.Panel();
            this.subjectTabToolsSeparatorVertical1 = new System.Windows.Forms.Panel();
            this.subjectTabToolsSeparatorVertical2 = new System.Windows.Forms.Panel();
            this.selfTabEditNote = new System.Windows.Forms.Button();
            this.selfTabFilterClear = new System.Windows.Forms.Button();
            this.selfTabCreateNote = new System.Windows.Forms.Button();
            this.selfTabFilter = new System.Windows.Forms.Button();
            this.ozenkiTabEditNote = new System.Windows.Forms.Button();
            this.ozenkiTabFilterClear = new System.Windows.Forms.Button();
            this.ozenkiTabFilter = new System.Windows.Forms.Button();
            this.ozenkiTabCreateNote = new System.Windows.Forms.Button();
            this.subjectTabEditNote = new System.Windows.Forms.Button();
            this.subjectTabFilterClear = new System.Windows.Forms.Button();
            this.subjectTabFilter = new System.Windows.Forms.Button();
            this.subjectTabCreateNote = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.selfTab.SuspendLayout();
            this.ozenkiTab.SuspendLayout();
            this.subjectTab.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.selfTab);
            this.tabs.Controls.Add(this.ozenkiTab);
            this.tabs.Controls.Add(this.subjectTab);
            this.tabs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabs.Location = new System.Drawing.Point(-1, 40);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1156, 664);
            this.tabs.TabIndex = 0;
            // 
            // selfTab
            // 
            this.selfTab.Controls.Add(this.selfTabToolsSeparatorVertical2);
            this.selfTab.Controls.Add(this.selfTabToolsSeparatorVertical1);
            this.selfTab.Controls.Add(this.selfTabToolsSeparatorHorizontal);
            this.selfTab.Controls.Add(this.selfTabEditNote);
            this.selfTab.Controls.Add(this.selfTabFilterClear);
            this.selfTab.Controls.Add(this.selfTabCreateNote);
            this.selfTab.Controls.Add(this.selfTabFilter);
            this.selfTab.Controls.Add(this.selfTabDataTable);
            this.selfTab.Location = new System.Drawing.Point(4, 26);
            this.selfTab.Name = "selfTab";
            this.selfTab.Padding = new System.Windows.Forms.Padding(3);
            this.selfTab.Size = new System.Drawing.Size(1148, 634);
            this.selfTab.TabIndex = 0;
            this.selfTab.Text = "Личные данные";
            this.selfTab.UseVisualStyleBackColor = true;
            // 
            // selfTabToolsSeparatorVertical2
            // 
            this.selfTabToolsSeparatorVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selfTabToolsSeparatorVertical2.Location = new System.Drawing.Point(528, 4);
            this.selfTabToolsSeparatorVertical2.Name = "selfTabToolsSeparatorVertical2";
            this.selfTabToolsSeparatorVertical2.Size = new System.Drawing.Size(1, 33);
            this.selfTabToolsSeparatorVertical2.TabIndex = 3;
            // 
            // selfTabToolsSeparatorVertical1
            // 
            this.selfTabToolsSeparatorVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selfTabToolsSeparatorVertical1.Location = new System.Drawing.Point(172, 4);
            this.selfTabToolsSeparatorVertical1.Name = "selfTabToolsSeparatorVertical1";
            this.selfTabToolsSeparatorVertical1.Size = new System.Drawing.Size(1, 33);
            this.selfTabToolsSeparatorVertical1.TabIndex = 3;
            // 
            // selfTabToolsSeparatorHorizontal
            // 
            this.selfTabToolsSeparatorHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selfTabToolsSeparatorHorizontal.Location = new System.Drawing.Point(0, 41);
            this.selfTabToolsSeparatorHorizontal.Name = "selfTabToolsSeparatorHorizontal";
            this.selfTabToolsSeparatorHorizontal.Size = new System.Drawing.Size(1148, 1);
            this.selfTabToolsSeparatorHorizontal.TabIndex = 2;
            // 
            // selfTabDataTable
            // 
            this.selfTabDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selfTabDataTable.Location = new System.Drawing.Point(8, 96);
            this.selfTabDataTable.Name = "selfTabDataTable";
            this.selfTabDataTable.Size = new System.Drawing.Size(1134, 486);
            this.selfTabDataTable.TabIndex = 0;
            this.selfTabDataTable.UseCompatibleStateImageBehavior = false;
            this.selfTabDataTable.View = System.Windows.Forms.View.Details;
            // 
            // ozenkiTab
            // 
            this.ozenkiTab.Controls.Add(this.ozenkiTabEditNote);
            this.ozenkiTab.Controls.Add(this.ozenkiTabToolsSeparatorVertical2);
            this.ozenkiTab.Controls.Add(this.ozenkiTabToolsSeparatorVertical1);
            this.ozenkiTab.Controls.Add(this.ozenkiTabToolsSeparatorHorizontal);
            this.ozenkiTab.Controls.Add(this.ozenkiTabFilterClear);
            this.ozenkiTab.Controls.Add(this.ozenkiTabFilter);
            this.ozenkiTab.Controls.Add(this.ozenkiTabCreateNote);
            this.ozenkiTab.Controls.Add(this.ozenkiTabDataTable);
            this.ozenkiTab.Location = new System.Drawing.Point(4, 26);
            this.ozenkiTab.Name = "ozenkiTab";
            this.ozenkiTab.Padding = new System.Windows.Forms.Padding(3);
            this.ozenkiTab.Size = new System.Drawing.Size(1148, 634);
            this.ozenkiTab.TabIndex = 1;
            this.ozenkiTab.Text = "Успеваемость";
            this.ozenkiTab.UseVisualStyleBackColor = true;
            // 
            // ozenkiTabToolsSeparatorVertical2
            // 
            this.ozenkiTabToolsSeparatorVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ozenkiTabToolsSeparatorVertical2.Location = new System.Drawing.Point(528, 4);
            this.ozenkiTabToolsSeparatorVertical2.Name = "ozenkiTabToolsSeparatorVertical2";
            this.ozenkiTabToolsSeparatorVertical2.Size = new System.Drawing.Size(1, 33);
            this.ozenkiTabToolsSeparatorVertical2.TabIndex = 8;
            // 
            // ozenkiTabToolsSeparatorVertical1
            // 
            this.ozenkiTabToolsSeparatorVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ozenkiTabToolsSeparatorVertical1.Location = new System.Drawing.Point(172, 4);
            this.ozenkiTabToolsSeparatorVertical1.Name = "ozenkiTabToolsSeparatorVertical1";
            this.ozenkiTabToolsSeparatorVertical1.Size = new System.Drawing.Size(1, 33);
            this.ozenkiTabToolsSeparatorVertical1.TabIndex = 5;
            // 
            // ozenkiTabToolsSeparatorHorizontal
            // 
            this.ozenkiTabToolsSeparatorHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ozenkiTabToolsSeparatorHorizontal.Location = new System.Drawing.Point(0, 41);
            this.ozenkiTabToolsSeparatorHorizontal.Name = "ozenkiTabToolsSeparatorHorizontal";
            this.ozenkiTabToolsSeparatorHorizontal.Size = new System.Drawing.Size(1148, 1);
            this.ozenkiTabToolsSeparatorHorizontal.TabIndex = 3;
            // 
            // ozenkiTabDataTable
            // 
            this.ozenkiTabDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ozenkiTabDataTable.Location = new System.Drawing.Point(8, 96);
            this.ozenkiTabDataTable.Name = "ozenkiTabDataTable";
            this.ozenkiTabDataTable.Size = new System.Drawing.Size(1134, 486);
            this.ozenkiTabDataTable.TabIndex = 1;
            this.ozenkiTabDataTable.UseCompatibleStateImageBehavior = false;
            this.ozenkiTabDataTable.View = System.Windows.Forms.View.Details;
            // 
            // subjectTab
            // 
            this.subjectTab.Controls.Add(this.subjectTabEditNote);
            this.subjectTab.Controls.Add(this.subjectTabToolsSeparatorVertical2);
            this.subjectTab.Controls.Add(this.subjectTabToolsSeparatorVertical1);
            this.subjectTab.Controls.Add(this.subjectTabToolsSeparatorHorizontal);
            this.subjectTab.Controls.Add(this.subjectTabFilterClear);
            this.subjectTab.Controls.Add(this.subjectTabFilter);
            this.subjectTab.Controls.Add(this.subjectTabCreateNote);
            this.subjectTab.Controls.Add(this.subjectTabDataTable);
            this.subjectTab.Location = new System.Drawing.Point(4, 26);
            this.subjectTab.Name = "subjectTab";
            this.subjectTab.Size = new System.Drawing.Size(1148, 634);
            this.subjectTab.TabIndex = 2;
            this.subjectTab.Text = "Предметы";
            this.subjectTab.UseVisualStyleBackColor = true;
            // 
            // topMenu
            // 
            this.topMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reports,
            this.Settings});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1180, 25);
            this.topMenu.TabIndex = 2;
            this.topMenu.Text = "menuStrip1";
            // 
            // Reports
            // 
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(64, 21);
            this.Reports.Text = "Отчеты";
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(92, 21);
            this.Settings.Text = "Настройки";
            // 
            // subjectTabDataTable
            // 
            this.subjectTabDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectTabDataTable.Location = new System.Drawing.Point(8, 96);
            this.subjectTabDataTable.Name = "subjectTabDataTable";
            this.subjectTabDataTable.Size = new System.Drawing.Size(1134, 486);
            this.subjectTabDataTable.TabIndex = 1;
            this.subjectTabDataTable.UseCompatibleStateImageBehavior = false;
            this.subjectTabDataTable.View = System.Windows.Forms.View.Details;
            // 
            // subjectTabToolsSeparatorHorizontal
            // 
            this.subjectTabToolsSeparatorHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectTabToolsSeparatorHorizontal.Location = new System.Drawing.Point(0, 41);
            this.subjectTabToolsSeparatorHorizontal.Name = "subjectTabToolsSeparatorHorizontal";
            this.subjectTabToolsSeparatorHorizontal.Size = new System.Drawing.Size(1148, 1);
            this.subjectTabToolsSeparatorHorizontal.TabIndex = 4;
            // 
            // subjectTabToolsSeparatorVertical1
            // 
            this.subjectTabToolsSeparatorVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectTabToolsSeparatorVertical1.Location = new System.Drawing.Point(172, 4);
            this.subjectTabToolsSeparatorVertical1.Name = "subjectTabToolsSeparatorVertical1";
            this.subjectTabToolsSeparatorVertical1.Size = new System.Drawing.Size(1, 33);
            this.subjectTabToolsSeparatorVertical1.TabIndex = 6;
            // 
            // subjectTabToolsSeparatorVertical2
            // 
            this.subjectTabToolsSeparatorVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectTabToolsSeparatorVertical2.Location = new System.Drawing.Point(528, 4);
            this.subjectTabToolsSeparatorVertical2.Name = "subjectTabToolsSeparatorVertical2";
            this.subjectTabToolsSeparatorVertical2.Size = new System.Drawing.Size(1, 33);
            this.subjectTabToolsSeparatorVertical2.TabIndex = 9;
            // 
            // selfTabEditNote
            // 
            this.selfTabEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selfTabEditNote.FlatAppearance.BorderSize = 0;
            this.selfTabEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfTabEditNote.Image = global::ЗаочноеОтделение.Properties.Resources.edit;
            this.selfTabEditNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selfTabEditNote.Location = new System.Drawing.Point(549, 8);
            this.selfTabEditNote.Name = "selfTabEditNote";
            this.selfTabEditNote.Size = new System.Drawing.Size(187, 28);
            this.selfTabEditNote.TabIndex = 1;
            this.selfTabEditNote.Text = "Редактировать запись";
            this.selfTabEditNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selfTabEditNote.UseVisualStyleBackColor = true;
            // 
            // selfTabFilterClear
            // 
            this.selfTabFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selfTabFilterClear.FlatAppearance.BorderSize = 0;
            this.selfTabFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfTabFilterClear.Image = global::ЗаочноеОтделение.Properties.Resources.filterClear;
            this.selfTabFilterClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selfTabFilterClear.Location = new System.Drawing.Point(352, 8);
            this.selfTabFilterClear.Name = "selfTabFilterClear";
            this.selfTabFilterClear.Size = new System.Drawing.Size(160, 28);
            this.selfTabFilterClear.TabIndex = 1;
            this.selfTabFilterClear.Text = "Сбросить фильтр";
            this.selfTabFilterClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selfTabFilterClear.UseVisualStyleBackColor = true;
            // 
            // selfTabCreateNote
            // 
            this.selfTabCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selfTabCreateNote.FlatAppearance.BorderSize = 0;
            this.selfTabCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfTabCreateNote.Image = global::ЗаочноеОтделение.Properties.Resources.createNotes;
            this.selfTabCreateNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selfTabCreateNote.Location = new System.Drawing.Point(8, 8);
            this.selfTabCreateNote.Name = "selfTabCreateNote";
            this.selfTabCreateNote.Size = new System.Drawing.Size(149, 28);
            this.selfTabCreateNote.TabIndex = 1;
            this.selfTabCreateNote.Text = "Добавить запись";
            this.selfTabCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selfTabCreateNote.UseVisualStyleBackColor = true;
            // 
            // selfTabFilter
            // 
            this.selfTabFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selfTabFilter.FlatAppearance.BorderSize = 0;
            this.selfTabFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfTabFilter.Image = global::ЗаочноеОтделение.Properties.Resources.filter;
            this.selfTabFilter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selfTabFilter.Location = new System.Drawing.Point(198, 8);
            this.selfTabFilter.Name = "selfTabFilter";
            this.selfTabFilter.Size = new System.Drawing.Size(143, 28);
            this.selfTabFilter.TabIndex = 1;
            this.selfTabFilter.Text = "Фильтр выборки";
            this.selfTabFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selfTabFilter.UseVisualStyleBackColor = true;
            // 
            // ozenkiTabEditNote
            // 
            this.ozenkiTabEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ozenkiTabEditNote.FlatAppearance.BorderSize = 0;
            this.ozenkiTabEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozenkiTabEditNote.Image = global::ЗаочноеОтделение.Properties.Resources.edit;
            this.ozenkiTabEditNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ozenkiTabEditNote.Location = new System.Drawing.Point(549, 8);
            this.ozenkiTabEditNote.Name = "ozenkiTabEditNote";
            this.ozenkiTabEditNote.Size = new System.Drawing.Size(187, 28);
            this.ozenkiTabEditNote.TabIndex = 9;
            this.ozenkiTabEditNote.Text = "Редактировать запись";
            this.ozenkiTabEditNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ozenkiTabEditNote.UseVisualStyleBackColor = true;
            // 
            // ozenkiTabFilterClear
            // 
            this.ozenkiTabFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ozenkiTabFilterClear.FlatAppearance.BorderSize = 0;
            this.ozenkiTabFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozenkiTabFilterClear.Image = global::ЗаочноеОтделение.Properties.Resources.filterClear;
            this.ozenkiTabFilterClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ozenkiTabFilterClear.Location = new System.Drawing.Point(352, 8);
            this.ozenkiTabFilterClear.Name = "ozenkiTabFilterClear";
            this.ozenkiTabFilterClear.Size = new System.Drawing.Size(160, 28);
            this.ozenkiTabFilterClear.TabIndex = 7;
            this.ozenkiTabFilterClear.Text = "Сбросить фильтр";
            this.ozenkiTabFilterClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ozenkiTabFilterClear.UseVisualStyleBackColor = true;
            // 
            // ozenkiTabFilter
            // 
            this.ozenkiTabFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ozenkiTabFilter.FlatAppearance.BorderSize = 0;
            this.ozenkiTabFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozenkiTabFilter.Image = global::ЗаочноеОтделение.Properties.Resources.filter;
            this.ozenkiTabFilter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ozenkiTabFilter.Location = new System.Drawing.Point(198, 8);
            this.ozenkiTabFilter.Name = "ozenkiTabFilter";
            this.ozenkiTabFilter.Size = new System.Drawing.Size(143, 28);
            this.ozenkiTabFilter.TabIndex = 6;
            this.ozenkiTabFilter.Text = "Фильтр выборки";
            this.ozenkiTabFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ozenkiTabFilter.UseVisualStyleBackColor = true;
            // 
            // ozenkiTabCreateNote
            // 
            this.ozenkiTabCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ozenkiTabCreateNote.FlatAppearance.BorderSize = 0;
            this.ozenkiTabCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozenkiTabCreateNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiTabCreateNote.Image = global::ЗаочноеОтделение.Properties.Resources.createNotes;
            this.ozenkiTabCreateNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ozenkiTabCreateNote.Location = new System.Drawing.Point(8, 8);
            this.ozenkiTabCreateNote.Name = "ozenkiTabCreateNote";
            this.ozenkiTabCreateNote.Size = new System.Drawing.Size(149, 28);
            this.ozenkiTabCreateNote.TabIndex = 4;
            this.ozenkiTabCreateNote.Text = "Добавить запись";
            this.ozenkiTabCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ozenkiTabCreateNote.UseVisualStyleBackColor = true;
            // 
            // subjectTabEditNote
            // 
            this.subjectTabEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectTabEditNote.FlatAppearance.BorderSize = 0;
            this.subjectTabEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectTabEditNote.Image = global::ЗаочноеОтделение.Properties.Resources.edit;
            this.subjectTabEditNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.subjectTabEditNote.Location = new System.Drawing.Point(549, 8);
            this.subjectTabEditNote.Name = "subjectTabEditNote";
            this.subjectTabEditNote.Size = new System.Drawing.Size(187, 28);
            this.subjectTabEditNote.TabIndex = 10;
            this.subjectTabEditNote.Text = "Редактировать запись";
            this.subjectTabEditNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subjectTabEditNote.UseVisualStyleBackColor = true;
            // 
            // subjectTabFilterClear
            // 
            this.subjectTabFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectTabFilterClear.FlatAppearance.BorderSize = 0;
            this.subjectTabFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectTabFilterClear.Image = global::ЗаочноеОтделение.Properties.Resources.filterClear;
            this.subjectTabFilterClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.subjectTabFilterClear.Location = new System.Drawing.Point(352, 8);
            this.subjectTabFilterClear.Name = "subjectTabFilterClear";
            this.subjectTabFilterClear.Size = new System.Drawing.Size(160, 28);
            this.subjectTabFilterClear.TabIndex = 8;
            this.subjectTabFilterClear.Text = "Сбросить фильтр";
            this.subjectTabFilterClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subjectTabFilterClear.UseVisualStyleBackColor = true;
            // 
            // subjectTabFilter
            // 
            this.subjectTabFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectTabFilter.FlatAppearance.BorderSize = 0;
            this.subjectTabFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectTabFilter.Image = global::ЗаочноеОтделение.Properties.Resources.filter;
            this.subjectTabFilter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.subjectTabFilter.Location = new System.Drawing.Point(198, 8);
            this.subjectTabFilter.Name = "subjectTabFilter";
            this.subjectTabFilter.Size = new System.Drawing.Size(143, 28);
            this.subjectTabFilter.TabIndex = 7;
            this.subjectTabFilter.Text = "Фильтр выборки";
            this.subjectTabFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subjectTabFilter.UseVisualStyleBackColor = true;
            // 
            // subjectTabCreateNote
            // 
            this.subjectTabCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectTabCreateNote.FlatAppearance.BorderSize = 0;
            this.subjectTabCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectTabCreateNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectTabCreateNote.Image = global::ЗаочноеОтделение.Properties.Resources.createNotes;
            this.subjectTabCreateNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.subjectTabCreateNote.Location = new System.Drawing.Point(8, 8);
            this.subjectTabCreateNote.Name = "subjectTabCreateNote";
            this.subjectTabCreateNote.Size = new System.Drawing.Size(149, 28);
            this.subjectTabCreateNote.TabIndex = 5;
            this.subjectTabCreateNote.Text = "Добавить запись";
            this.subjectTabCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subjectTabCreateNote.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 727);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.tabs);
            this.MainMenuStrip = this.topMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Заочное отделение";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabs.ResumeLayout(false);
            this.selfTab.ResumeLayout(false);
            this.ozenkiTab.ResumeLayout(false);
            this.subjectTab.ResumeLayout(false);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage selfTab;
        private System.Windows.Forms.TabPage ozenkiTab;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem Reports;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ListView selfTabDataTable;
        private System.Windows.Forms.Button selfTabFilterClear;
        private System.Windows.Forms.Button selfTabFilter;
        private System.Windows.Forms.Button selfTabCreateNote;
        private System.Windows.Forms.Panel selfTabToolsSeparatorHorizontal;
        private System.Windows.Forms.Panel selfTabToolsSeparatorVertical1;
        private System.Windows.Forms.ListView ozenkiTabDataTable;
        private System.Windows.Forms.Panel ozenkiTabToolsSeparatorHorizontal;
        private System.Windows.Forms.Panel ozenkiTabToolsSeparatorVertical1;
        private System.Windows.Forms.Button ozenkiTabCreateNote;
        private System.Windows.Forms.Button ozenkiTabFilterClear;
        private System.Windows.Forms.Button ozenkiTabFilter;
        private System.Windows.Forms.Button selfTabEditNote;
        private System.Windows.Forms.Panel selfTabToolsSeparatorVertical2;
        private System.Windows.Forms.Panel ozenkiTabToolsSeparatorVertical2;
        private System.Windows.Forms.Button ozenkiTabEditNote;
        private System.Windows.Forms.TabPage subjectTab;
        private System.Windows.Forms.Button subjectTabEditNote;
        private System.Windows.Forms.Panel subjectTabToolsSeparatorVertical2;
        private System.Windows.Forms.Button subjectTabFilterClear;
        private System.Windows.Forms.Button subjectTabFilter;
        private System.Windows.Forms.Panel subjectTabToolsSeparatorVertical1;
        private System.Windows.Forms.Button subjectTabCreateNote;
        private System.Windows.Forms.Panel subjectTabToolsSeparatorHorizontal;
        private System.Windows.Forms.ListView subjectTabDataTable;
    }
}

