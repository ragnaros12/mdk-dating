namespace data
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.CurrentDateFull = new System.Windows.Forms.Label();
            this.Week = new System.Windows.Forms.Label();
            this.Leap = new System.Windows.Forms.Label();
            this.TotalDays = new System.Windows.Forms.Label();
            this.Years = new System.Windows.Forms.Label();
            this.Months = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.Zodiak = new System.Windows.Forms.Label();
            this.ZodiakDescription = new System.Windows.Forms.Label();
            this.ZodiakImage = new System.Windows.Forms.PictureBox();
            this.NextBirthday = new System.Windows.Forms.Label();
            this.Chinease = new System.Windows.Forms.Label();
            this.ChineaseDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ZodiakImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateChangeed);
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Location = new System.Drawing.Point(13, 40);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(78, 13);
            this.CurrentDate.TabIndex = 1;
            this.CurrentDate.Text = "Текущая дата";
            // 
            // CurrentDateFull
            // 
            this.CurrentDateFull.AutoSize = true;
            this.CurrentDateFull.Location = new System.Drawing.Point(13, 57);
            this.CurrentDateFull.Name = "CurrentDateFull";
            this.CurrentDateFull.Size = new System.Drawing.Size(117, 13);
            this.CurrentDateFull.TabIndex = 2;
            this.CurrentDateFull.Text = "Полная текущая дата";
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Location = new System.Drawing.Point(13, 178);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(45, 13);
            this.Week.TabIndex = 3;
            this.Week.Text = "Неделя";
            // 
            // Leap
            // 
            this.Leap.AutoSize = true;
            this.Leap.Location = new System.Drawing.Point(13, 195);
            this.Leap.Name = "Leap";
            this.Leap.Size = new System.Drawing.Size(79, 13);
            this.Leap.TabIndex = 4;
            this.Leap.Text = "Високосность";
            // 
            // TotalDays
            // 
            this.TotalDays.AutoSize = true;
            this.TotalDays.Location = new System.Drawing.Point(13, 212);
            this.TotalDays.Name = "TotalDays";
            this.TotalDays.Size = new System.Drawing.Size(28, 13);
            this.TotalDays.TabIndex = 5;
            this.TotalDays.Text = "Дни";
            // 
            // Years
            // 
            this.Years.AutoSize = true;
            this.Years.Location = new System.Drawing.Point(10, 273);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(31, 13);
            this.Years.TabIndex = 6;
            this.Years.Text = "Года";
            // 
            // Months
            // 
            this.Months.AutoSize = true;
            this.Months.Location = new System.Drawing.Point(10, 286);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(108, 13);
            this.Months.TabIndex = 7;
            this.Months.Text = "Оствшиеся  месяца";
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(10, 299);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(91, 13);
            this.Days.TabIndex = 8;
            this.Days.Text = "Оставшиеся дни";
            // 
            // Zodiak
            // 
            this.Zodiak.AutoSize = true;
            this.Zodiak.Location = new System.Drawing.Point(216, 256);
            this.Zodiak.Name = "Zodiak";
            this.Zodiak.Size = new System.Drawing.Size(77, 13);
            this.Zodiak.TabIndex = 9;
            this.Zodiak.Text = "Знак зодиака";
            // 
            // ZodiakDescription
            // 
            this.ZodiakDescription.AutoSize = true;
            this.ZodiakDescription.Location = new System.Drawing.Point(216, 277);
            this.ZodiakDescription.MaximumSize = new System.Drawing.Size(400, 0);
            this.ZodiakDescription.Name = "ZodiakDescription";
            this.ZodiakDescription.Size = new System.Drawing.Size(90, 13);
            this.ZodiakDescription.TabIndex = 10;
            this.ZodiakDescription.Text = "Описание знака";
            // 
            // ZodiakImage
            // 
            this.ZodiakImage.Location = new System.Drawing.Point(219, 19);
            this.ZodiakImage.Name = "ZodiakImage";
            this.ZodiakImage.Size = new System.Drawing.Size(247, 225);
            this.ZodiakImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ZodiakImage.TabIndex = 11;
            this.ZodiakImage.TabStop = false;
            // 
            // NextBirthday
            // 
            this.NextBirthday.AutoSize = true;
            this.NextBirthday.Location = new System.Drawing.Point(13, 371);
            this.NextBirthday.Name = "NextBirthday";
            this.NextBirthday.Size = new System.Drawing.Size(64, 13);
            this.NextBirthday.TabIndex = 12;
            this.NextBirthday.Text = "Дней до др";
            // 
            // Chinease
            // 
            this.Chinease.AutoSize = true;
            this.Chinease.Location = new System.Drawing.Point(590, 20);
            this.Chinease.Name = "Chinease";
            this.Chinease.Size = new System.Drawing.Size(113, 13);
            this.Chinease.TabIndex = 13;
            this.Chinease.Text = "Китайское животное";
            // 
            // ChineaseDescription
            // 
            this.ChineaseDescription.AutoSize = true;
            this.ChineaseDescription.Location = new System.Drawing.Point(590, 40);
            this.ChineaseDescription.MaximumSize = new System.Drawing.Size(300, 0);
            this.ChineaseDescription.Name = "ChineaseDescription";
            this.ChineaseDescription.Size = new System.Drawing.Size(170, 13);
            this.ChineaseDescription.TabIndex = 14;
            this.ChineaseDescription.Text = "Описание китайского животное";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 500);
            this.Controls.Add(this.ChineaseDescription);
            this.Controls.Add(this.Chinease);
            this.Controls.Add(this.NextBirthday);
            this.Controls.Add(this.ZodiakImage);
            this.Controls.Add(this.ZodiakDescription);
            this.Controls.Add(this.Zodiak);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.TotalDays);
            this.Controls.Add(this.Leap);
            this.Controls.Add(this.Week);
            this.Controls.Add(this.CurrentDateFull);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ZodiakImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label CurrentDateFull;
        private System.Windows.Forms.Label Week;
        private System.Windows.Forms.Label Leap;
        private System.Windows.Forms.Label TotalDays;
        private System.Windows.Forms.Label Years;
        private System.Windows.Forms.Label Months;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label Zodiak;
        private System.Windows.Forms.Label ZodiakDescription;
        private System.Windows.Forms.PictureBox ZodiakImage;
        private System.Windows.Forms.Label NextBirthday;
        private System.Windows.Forms.Label Chinease;
        private System.Windows.Forms.Label ChineaseDescription;
    }
}

