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

namespace data
{
    public partial class Form1 : Form
    {

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
        string GetAnimal(int value)
        {
            if (value == 0) return "Крыса";
            if (value == 1) return "Бык";
            if (value == 2) return "Тигр";
            if (value == 3) return "Кролик";
            if (value == 4) return "Дракон";
            if (value == 5) return "Змея";
            if (value == 6) return "Лошадь";
            if (value == 7) return "Коза";
            if (value == 8) return "Обезьяна";
            if (value == 9) return "Петух";
            if (value == 10) return "Собака";
            return "Свинья";
        }
        string GetDayOfWeek(DayOfWeek value)
        {
            if (value == DayOfWeek.Monday) return "Понедельник";
            if (value == DayOfWeek.Tuesday) return "Вторник";
            if (value == DayOfWeek.Wednesday) return "Среда";
            if (value == DayOfWeek.Thursday) return "Четверг";
            if (value == DayOfWeek.Friday) return "Пятница";
            if (value == DayOfWeek.Saturday) return "Суббота";
            return "Воскресенье";
        }

        private void DateChangeed(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            DateTime now = DateTime.Now;
            TimeSpan time = now - birthday;


            CurrentDate.Text = now.ToString("g");
            CurrentDateFull.Text = now.ToString("F");


            Week.Text = GetDayOfWeek(birthday.DayOfWeek);
            if (DateTime.IsLeapYear(birthday.Year))
            {
                Leap.Text = "Год вискокосный";
            }
            else
            {
                Leap.Text = "Год не високосный";
            }

            if (now <= birthday)
            {
                TotalDays.Text = "Вы прожили " + (int)time.TotalDays + " дней";


                Years.Text = "Вы прожили " + (int)time.TotalDays / 365 + " лет";
                Months.Text = "Вы прожили еще " + (int)time.TotalDays % 365 / 30 + " месяцев";
                Days.Text = "Вы прожили еще " + (int)time.TotalDays % 365 % 30 + " дня";
            }
            else
            {
                TotalDays.Text = "Вы еще не родились(";
            }

            string zodiakName = GetZodiak(birthday.Day, birthday.Month);
            Zodiak.Text = "Ваш знак " + zodiakName;
            ZodiakDescription.Text = File.ReadAllText("Resources/Texts/" + zodiakName + ".txt");
            ZodiakImage.ImageLocation = $"Resources/Images/" + zodiakName + ".png";

            DateTime CurrentBirthday = birthday.AddYears(now.Year - birthday.Year);

            if (CurrentBirthday < now)
            {
                NextBirthday.Text = "До предыдущего дня рождения " + Math.Round((now - CurrentBirthday).TotalDays);
            }
            else
            {
                NextBirthday.Text = "До следующего дня рождения " + Math.Round((CurrentBirthday - now).TotalDays);

            }

            int chineseYear = (birthday.Year - 4) % 12;
            Chinease.Text = "Вы по китайскому гороскопу " + GetAnimal(chineseYear);

            ChineaseDescription.Text = File.ReadAllText($"Resources/Ch/" + GetAnimal(chineseYear) + ".txt");


        }
    }
}