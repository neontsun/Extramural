namespace ЗаочноеОтделение.SelfDataTabs.Groups
{
    partial class AddGroups
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
            this.groupNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupSpec = new System.Windows.Forms.ComboBox();
            this.groupYearIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupYearOut = new System.Windows.Forms.TextBox();
            this.groupCurrentCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupNumber
            // 
            this.groupNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNumber.Location = new System.Drawing.Point(143, 93);
            this.groupNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.Size = new System.Drawing.Size(126, 26);
            this.groupNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер группы";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(143, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(143, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 1);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Специальность";
            // 
            // groupSpec
            // 
            this.groupSpec.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupSpec.FormattingEnabled = true;
            this.groupSpec.Items.AddRange(new object[] {
            "Отчислен",
            "Выпущен",
            "Обучается"});
            this.groupSpec.Location = new System.Drawing.Point(143, 169);
            this.groupSpec.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupSpec.Name = "groupSpec";
            this.groupSpec.Size = new System.Drawing.Size(207, 28);
            this.groupSpec.TabIndex = 32;
            // 
            // groupYearIn
            // 
            this.groupYearIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupYearIn.Location = new System.Drawing.Point(461, 93);
            this.groupYearIn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupYearIn.Name = "groupYearIn";
            this.groupYearIn.Size = new System.Drawing.Size(126, 26);
            this.groupYearIn.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(453, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Год поступления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(453, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Год окончания";
            // 
            // groupYearOut
            // 
            this.groupYearOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupYearOut.Location = new System.Drawing.Point(461, 169);
            this.groupYearOut.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupYearOut.Name = "groupYearOut";
            this.groupYearOut.Size = new System.Drawing.Size(126, 26);
            this.groupYearOut.TabIndex = 35;
            // 
            // groupCurrentCourse
            // 
            this.groupCurrentCourse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupCurrentCourse.Location = new System.Drawing.Point(143, 247);
            this.groupCurrentCourse.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupCurrentCourse.Name = "groupCurrentCourse";
            this.groupCurrentCourse.Size = new System.Drawing.Size(126, 26);
            this.groupCurrentCourse.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(140, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Текущий курс";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(142, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 1);
            this.panel3.TabIndex = 5;
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(301, 323);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 32);
            this.save.TabIndex = 39;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(447, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(140, 32);
            this.cancel.TabIndex = 40;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 367);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.groupCurrentCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupYearOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupYearIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupSpec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupNumber);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddGroups";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox groupNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupSpec;
        private System.Windows.Forms.TextBox groupYearIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox groupYearOut;
        private System.Windows.Forms.TextBox groupCurrentCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}