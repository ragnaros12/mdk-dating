using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace data
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> animals = new Dictionary<int, string>()
        {
            { 0, "Крыса" }, { 1, "Бык" }, { 2, "Тигр" },
            { 3, "Кролик" }, { 4, "Дракон" }, { 5, "Змея" },
            { 6, "Лошадь" }, { 7, "Коза" }, { 8, "Обезьяна" },
            { 9, "Петух" }, { 10, "Собака" }, { 11, "Свинья" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        string GetZodiak(int d, int m)
        {
            if ((d >= 21 && m == 3) || (d <= 20 && m == 4)) return "Овен";
            if ((d >= 21 && m == 4) || (d <= 20 && m == 5)) return "Телец";
            if ((d >= 21 && m == 5) || (d <= 21 && m == 6)) return "Близнецы";
            if ((d >= 22 && m == 6) || (d <= 22 && m == 7)) return "Рак";
            if ((d >= 23 && m == 7) || (d <= 23 && m == 8)) return "Лев";
            if ((d >= 24 && m == 8) || (d <= 23 && m == 9)) return "Дева";
            if ((d >= 24 && m == 9) || (d <= 23 && m == 10)) return "Весы";
            if ((d >= 24 && m == 10) || (d <= 22 && m == 11)) return "Скорпион";
            if ((d >= 23 && m == 11) || (d <= 21 && m == 12)) return "Стрелец";
            if ((d >= 22 && m == 12) || (d <= 20 && m == 1)) return "Козерог";
            if ((d >= 21 && m == 1) || (d <= 18 && m == 2)) return "Водолей";
            else return "Рыбы";
        }

        private void DateChangeed(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            DateTime now = DateTime.Now;
            TimeSpan time = now - birthday;


            CurrentDate.Text = now.ToString("g");
            CurrentDateFull.Text = now.ToString("F");


            Week.Text = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(birthday.DayOfWeek);
            Leap.Text = DateTime.IsLeapYear(birthday.Year) ? "Год вискокосный" : "Год не високосный";
            TotalDays.Text = $"Вы прожили {(int)time.TotalDays} дней";


            TotalDays.Text = $"Вы прожили {(int)time.TotalDays} дней";


            Years.Text = $"Вы прожили {(int)time.TotalDays / 365} лет";
            Months.Text = $"Вы прожили еще {(int)time.TotalDays % 365 / 30} месяцев";
            Days.Text = $"Вы прожили еще {(int)time.TotalDays % 365 % 30} дня";

            string zodiakName = GetZodiak(birthday.Day, birthday.Month);
            Zodiak.Text = $"Ваш знак {zodiakName}";
            ZodiakDescription.Text = File.ReadAllText($"Resources/Texts/{zodiakName}.txt");
            ZodiakImage.ImageLocation = $"Resources/Images/{zodiakName}.png";

            DateTime CurrentBirthday = birthday.AddYears(now.Year - birthday.Year);


            NextBirthday.Text = $"{(CurrentBirthday < now ? "До предыдущего дня рождения": "До следующего дня рождения") } {Math.Abs(Math.Round((now - CurrentBirthday).TotalDays))} дней";

            int chineseYear = (birthday.Year - 4) % 12;
            Chinease.Text = $"Вы по китайскому гороскопу {animals[chineseYear]}";

            ChineaseDescription.Text = File.ReadAllText($"Resources/Ch/{animals[chineseYear]}.txt");


        }
    }
}