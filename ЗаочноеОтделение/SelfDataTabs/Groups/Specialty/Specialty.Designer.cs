namespace ЗаочноеОтделение.SelfDataTabs.Groups.Specialty
{
    partial class Specialty
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
            this.specialtyDataTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialtyToolsSeparatorVertical2 = new System.Windows.Forms.Panel();
            this.specialtyToolsSeparatorVertical1 = new System.Windows.Forms.Panel();
            this.specialtyToolsSeparatorHorizontal = new System.Windows.Forms.Panel();
            this.specialtyEditNote = new System.Windows.Forms.Button();
            this.specialtyFilterClear = new System.Windows.Forms.Button();
            this.specialtyCreateNote = new System.Windows.Forms.Button();
            this.specialtyFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // specialtyDataTable
            // 
            this.specialtyDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialtyDataTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.specialtyDataTable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyDataTable.FullRowSelect = true;
            this.specialtyDataTable.GridLines = true;
            this.specialtyDataTable.Location = new System.Drawing.Point(12, 116);
            this.specialtyDataTable.Name = "specialtyDataTable";
            this.specialtyDataTable.Size = new System.Drawing.Size(858, 486);
            this.specialtyDataTable.TabIndex = 28;
            this.specialtyDataTable.UseCompatibleStateImageBehavior = false;
            this.specialtyDataTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Код специальности";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование специальности";
            this.columnHeader2.Width = 498;
            // 
            // specialtyToolsSeparatorVertical2
            // 
            this.specialtyToolsSeparatorVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.specialtyToolsSeparatorVertical2.Location = new System.Drawing.Point(528, 32);
            this.specialtyToolsSeparatorVertical2.Name = "specialtyToolsSeparatorVertical2";
            this.specialtyToolsSeparatorVertical2.Size = new System.Drawing.Size(1, 33);
            this.specialtyToolsSeparatorVertical2.TabIndex = 26;
            // 
            // specialtyToolsSeparatorVertical1
            // 
            this.specialtyToolsSeparatorVertical1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.specialtyToolsSeparatorVertical1.Location = new System.Drawing.Point(172, 32);
            this.specialtyToolsSeparatorVertical1.Name = "specialtyToolsSeparatorVertical1";
            this.specialtyToolsSeparatorVertical1.Size = new System.Drawing.Size(1, 33);
            this.specialtyToolsSeparatorVertical1.TabIndex = 27;
            // 
            // specialtyToolsSeparatorHorizontal
            // 
            this.specialtyToolsSeparatorHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.specialtyToolsSeparatorHorizontal.Location = new System.Drawing.Point(0, 69);
            this.specialtyToolsSeparatorHorizontal.Name = "specialtyToolsSeparatorHorizontal";
            this.specialtyToolsSeparatorHorizontal.Size = new System.Drawing.Size(885, 1);
            this.specialtyToolsSeparatorHorizontal.TabIndex = 25;
            // 
            // specialtyEditNote
            // 
            this.specialtyEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialtyEditNote.FlatAppearance.BorderSize = 0;
            this.specialtyEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialtyEditNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyEditNote.Image = global::ЗаочноеОтделение.Properties.Resources.edit;
            this.specialtyEditNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.specialtyEditNote.Location = new System.Drawing.Point(549, 36);
            this.specialtyEditNote.Name = "specialtyEditNote";
            this.specialtyEditNote.Size = new System.Drawing.Size(187, 28);
            this.specialtyEditNote.TabIndex = 21;
            this.specialtyEditNote.Text = "Редактировать запись";
            this.specialtyEditNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.specialtyEditNote.UseVisualStyleBackColor = true;
            // 
            // specialtyFilterClear
            // 
            this.specialtyFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialtyFilterClear.FlatAppearance.BorderSize = 0;
            this.specialtyFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialtyFilterClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyFilterClear.Image = global::ЗаочноеОтделение.Properties.Resources.filterClear;
            this.specialtyFilterClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.specialtyFilterClear.Location = new System.Drawing.Point(352, 36);
            this.specialtyFilterClear.Name = "specialtyFilterClear";
            this.specialtyFilterClear.Size = new System.Drawing.Size(160, 28);
            this.specialtyFilterClear.TabIndex = 22;
            this.specialtyFilterClear.Text = "Сбросить фильтр";
            this.specialtyFilterClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.specialtyFilterClear.UseVisualStyleBackColor = true;
            // 
            // specialtyCreateNote
            // 
            this.specialtyCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialtyCreateNote.FlatAppearance.BorderSize = 0;
            this.specialtyCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialtyCreateNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyCreateNote.Image = global::ЗаочноеОтделение.Properties.Resources.createNotes;
            this.specialtyCreateNote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.specialtyCreateNote.Location = new System.Drawing.Point(8, 36);
            this.specialtyCreateNote.Name = "specialtyCreateNote";
            this.specialtyCreateNote.Size = new System.Drawing.Size(149, 28);
            this.specialtyCreateNote.TabIndex = 23;
            this.specialtyCreateNote.Text = "Добавить запись";
            this.specialtyCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.specialtyCreateNote.UseVisualStyleBackColor = true;
            // 
            // specialtyFilter
            // 
            this.specialtyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialtyFilter.FlatAppearance.BorderSize = 0;
            this.specialtyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialtyFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyFilter.Image = global::ЗаочноеОтделение.Properties.Resources.filter;
            this.specialtyFilter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.specialtyFilter.Location = new System.Drawing.Point(198, 36);
            this.specialtyFilter.Name = "specialtyFilter";
            this.specialtyFilter.Size = new System.Drawing.Size(143, 28);
            this.specialtyFilter.TabIndex = 24;
            this.specialtyFilter.Text = "Фильтр выборки";
            this.specialtyFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.specialtyFilter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(13, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 1);
            this.panel1.TabIndex = 29;
            // 
            // Specialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.specialtyDataTable);
            this.Controls.Add(this.specialtyToolsSeparatorVertical2);
            this.Controls.Add(this.specialtyToolsSeparatorVertical1);
            this.Controls.Add(this.specialtyToolsSeparatorHorizontal);
            this.Controls.Add(this.specialtyEditNote);
            this.Controls.Add(this.specialtyFilterClear);
            this.Controls.Add(this.specialtyCreateNote);
            this.Controls.Add(this.specialtyFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Specialty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специальности";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView specialtyDataTable;
        private System.Windows.Forms.Panel specialtyToolsSeparatorVertical2;
        private System.Windows.Forms.Panel specialtyToolsSeparatorVertical1;
        private System.Windows.Forms.Panel specialtyToolsSeparatorHorizontal;
        private System.Windows.Forms.Button specialtyEditNote;
        private System.Windows.Forms.Button specialtyFilterClear;
        private System.Windows.Forms.Button specialtyCreateNote;
        private System.Windows.Forms.Button specialtyFilter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
    }
}