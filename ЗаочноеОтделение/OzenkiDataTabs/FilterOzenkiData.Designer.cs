namespace ЗаочноеОтделение.OzenkiDataTabs
{
    partial class FilterOzenkiData
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
            this.ozenkiSubject = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ozenkiOtmetka = new System.Windows.Forms.GroupBox();
            this.ozenkiOtmetka2 = new System.Windows.Forms.CheckBox();
            this.ozenkiOtmetka3 = new System.Windows.Forms.CheckBox();
            this.ozenkiOtmetka4 = new System.Windows.Forms.CheckBox();
            this.ozenkiOtmetka5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ozenkiCourse = new System.Windows.Forms.TextBox();
            this.ozenkiOtmetka.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(153, 332);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 32);
            this.save.TabIndex = 92;
            this.save.Text = "Выполнить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(299, 332);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(140, 32);
            this.cancel.TabIndex = 91;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ozenkiSubject
            // 
            this.ozenkiSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiSubject.FormattingEnabled = true;
            this.ozenkiSubject.Items.AddRange(new object[] {
            "Отчислен",
            "Выпущен",
            "Обучается"});
            this.ozenkiSubject.Location = new System.Drawing.Point(113, 158);
            this.ozenkiSubject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ozenkiSubject.Name = "ozenkiSubject";
            this.ozenkiSubject.Size = new System.Drawing.Size(251, 25);
            this.ozenkiSubject.TabIndex = 87;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(113, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 1);
            this.panel5.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(110, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 86;
            this.label5.Text = "Предмет";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(113, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 1);
            this.panel2.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Курс";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(113, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 1);
            this.panel1.TabIndex = 73;
            // 
            // ozenkiOtmetka
            // 
            this.ozenkiOtmetka.Controls.Add(this.ozenkiOtmetka2);
            this.ozenkiOtmetka.Controls.Add(this.ozenkiOtmetka3);
            this.ozenkiOtmetka.Controls.Add(this.ozenkiOtmetka4);
            this.ozenkiOtmetka.Controls.Add(this.ozenkiOtmetka5);
            this.ozenkiOtmetka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozenkiOtmetka.Location = new System.Drawing.Point(113, 225);
            this.ozenkiOtmetka.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ozenkiOtmetka.Name = "ozenkiOtmetka";
            this.ozenkiOtmetka.Size = new System.Drawing.Size(147, 39);
            this.ozenkiOtmetka.TabIndex = 75;
            this.ozenkiOtmetka.TabStop = false;
            // 
            // ozenkiOtmetka2
            // 
            this.ozenkiOtmetka2.AutoSize = true;
            this.ozenkiOtmetka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiOtmetka2.Location = new System.Drawing.Point(5, 13);
            this.ozenkiOtmetka2.Name = "ozenkiOtmetka2";
            this.ozenkiOtmetka2.Size = new System.Drawing.Size(34, 20);
            this.ozenkiOtmetka2.TabIndex = 43;
            this.ozenkiOtmetka2.Text = "2";
            this.ozenkiOtmetka2.UseVisualStyleBackColor = true;
            // 
            // ozenkiOtmetka3
            // 
            this.ozenkiOtmetka3.AutoSize = true;
            this.ozenkiOtmetka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiOtmetka3.Location = new System.Drawing.Point(39, 13);
            this.ozenkiOtmetka3.Name = "ozenkiOtmetka3";
            this.ozenkiOtmetka3.Size = new System.Drawing.Size(34, 20);
            this.ozenkiOtmetka3.TabIndex = 43;
            this.ozenkiOtmetka3.Text = "3";
            this.ozenkiOtmetka3.UseVisualStyleBackColor = true;
            // 
            // ozenkiOtmetka4
            // 
            this.ozenkiOtmetka4.AutoSize = true;
            this.ozenkiOtmetka4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiOtmetka4.Location = new System.Drawing.Point(73, 13);
            this.ozenkiOtmetka4.Name = "ozenkiOtmetka4";
            this.ozenkiOtmetka4.Size = new System.Drawing.Size(34, 20);
            this.ozenkiOtmetka4.TabIndex = 43;
            this.ozenkiOtmetka4.Text = "4";
            this.ozenkiOtmetka4.UseVisualStyleBackColor = true;
            // 
            // ozenkiOtmetka5
            // 
            this.ozenkiOtmetka5.AutoSize = true;
            this.ozenkiOtmetka5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiOtmetka5.Location = new System.Drawing.Point(107, 13);
            this.ozenkiOtmetka5.Name = "ozenkiOtmetka5";
            this.ozenkiOtmetka5.Size = new System.Drawing.Size(34, 20);
            this.ozenkiOtmetka5.TabIndex = 43;
            this.ozenkiOtmetka5.Text = "5";
            this.ozenkiOtmetka5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Оценка";
            // 
            // ozenkiCourse
            // 
            this.ozenkiCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ozenkiCourse.Location = new System.Drawing.Point(113, 83);
            this.ozenkiCourse.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ozenkiCourse.Name = "ozenkiCourse";
            this.ozenkiCourse.Size = new System.Drawing.Size(75, 26);
            this.ozenkiCourse.TabIndex = 93;
            // 
            // FilterOzenkiData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 396);
            this.Controls.Add(this.ozenkiCourse);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ozenkiSubject);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ozenkiOtmetka);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilterOzenkiData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр";
            this.ozenkiOtmetka.ResumeLayout(false);
            this.ozenkiOtmetka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox ozenkiSubject;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ozenkiOtmetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ozenkiOtmetka2;
        private System.Windows.Forms.CheckBox ozenkiOtmetka3;
        private System.Windows.Forms.CheckBox ozenkiOtmetka4;
        private System.Windows.Forms.CheckBox ozenkiOtmetka5;
        private System.Windows.Forms.TextBox ozenkiCourse;
    }
}