namespace ЗаочноеОтделение.SelfDataTabs
{
    partial class FilterSelfData
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
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.birthdayYear = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.language = new System.Windows.Forms.GroupBox();
            this.languageN = new System.Windows.Forms.CheckBox();
            this.languageF = new System.Windows.Forms.CheckBox();
            this.languageE = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gender = new System.Windows.Forms.GroupBox();
            this.genderF = new System.Windows.Forms.CheckBox();
            this.genderM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.language.SuspendLayout();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(193, 374);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 32);
            this.save.TabIndex = 86;
            this.save.Text = "Выполнить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(339, 374);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(140, 32);
            this.cancel.TabIndex = 85;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // birthdayYear
            // 
            this.birthdayYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayYear.FormattingEnabled = true;
            this.birthdayYear.Items.AddRange(new object[] {
            "Отчислен",
            "Выпущен",
            "Обучается"});
            this.birthdayYear.Location = new System.Drawing.Point(60, 147);
            this.birthdayYear.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.birthdayYear.Name = "birthdayYear";
            this.birthdayYear.Size = new System.Drawing.Size(131, 25);
            this.birthdayYear.TabIndex = 84;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Не выбрано",
            "Отчислен",
            "Выпущен",
            "Обучается"});
            this.status.Location = new System.Drawing.Point(60, 303);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(251, 25);
            this.status.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(60, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 1);
            this.panel4.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Статус";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(60, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 1);
            this.panel3.TabIndex = 78;
            // 
            // language
            // 
            this.language.Controls.Add(this.languageN);
            this.language.Controls.Add(this.languageF);
            this.language.Controls.Add(this.languageE);
            this.language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.language.Location = new System.Drawing.Point(60, 214);
            this.language.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(320, 39);
            this.language.TabIndex = 80;
            this.language.TabStop = false;
            // 
            // languageN
            // 
            this.languageN.AutoSize = true;
            this.languageN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageN.Location = new System.Drawing.Point(225, 13);
            this.languageN.Name = "languageN";
            this.languageN.Size = new System.Drawing.Size(93, 20);
            this.languageN.TabIndex = 43;
            this.languageN.Text = "Немецкий";
            this.languageN.UseVisualStyleBackColor = true;
            // 
            // languageF
            // 
            this.languageF.AutoSize = true;
            this.languageF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageF.Location = new System.Drawing.Point(113, 13);
            this.languageF.Name = "languageF";
            this.languageF.Size = new System.Drawing.Size(109, 20);
            this.languageF.TabIndex = 43;
            this.languageF.Text = "Французкий";
            this.languageF.UseVisualStyleBackColor = true;
            // 
            // languageE
            // 
            this.languageE.AutoSize = true;
            this.languageE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageE.Location = new System.Drawing.Point(6, 13);
            this.languageE.Name = "languageE";
            this.languageE.Size = new System.Drawing.Size(104, 20);
            this.languageE.TabIndex = 43;
            this.languageE.Text = "Английский";
            this.languageE.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Изучаемый язык";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(60, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 1);
            this.panel2.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Год рождения";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(60, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1);
            this.panel1.TabIndex = 73;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.genderF);
            this.gender.Controls.Add(this.genderM);
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender.Location = new System.Drawing.Point(60, 58);
            this.gender.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(181, 39);
            this.gender.TabIndex = 75;
            this.gender.TabStop = false;
            // 
            // genderF
            // 
            this.genderF.AutoSize = true;
            this.genderF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderF.Location = new System.Drawing.Point(93, 13);
            this.genderF.Name = "genderF";
            this.genderF.Size = new System.Drawing.Size(86, 20);
            this.genderF.TabIndex = 43;
            this.genderF.Text = "Женский";
            this.genderF.UseVisualStyleBackColor = true;
            // 
            // genderM
            // 
            this.genderM.AutoSize = true;
            this.genderM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderM.Location = new System.Drawing.Point(6, 13);
            this.genderM.Name = "genderM";
            this.genderM.Size = new System.Drawing.Size(85, 20);
            this.genderM.TabIndex = 43;
            this.genderM.Text = "Мужской";
            this.genderM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Пол";
            // 
            // FilterSelfData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 431);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.birthdayYear);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilterSelfData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр";
            this.language.ResumeLayout(false);
            this.language.PerformLayout();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox birthdayYear;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox language;
        private System.Windows.Forms.CheckBox languageN;
        private System.Windows.Forms.CheckBox languageF;
        private System.Windows.Forms.CheckBox languageE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.CheckBox genderF;
        private System.Windows.Forms.CheckBox genderM;
        private System.Windows.Forms.Label label1;
    }
}