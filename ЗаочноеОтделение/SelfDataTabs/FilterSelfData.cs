using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SelfDataTabs
{
    public partial class FilterSelfData : Form
    {
        /// <summary>
        /// Массив месяцев
        /// </summary>
        string[] month = new string[]
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FilterSelfData()
        {
            // Стандартная функция отрисовки контролов
            InitializeComponent();

            // Очищаем списки месяцев и годов
            birthdayYear.Items.Clear();

            // Заполняем список годов
            birthdayYear.Items.Add("Не выбрано");
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 100; i--)
                birthdayYear.Items.Add(i.ToString());
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String Request =
               "SELECT [КодГруппы]," +
               "       [Шифр]," +
               "       [НомерГруппы]," +
               "       [ФИО]," +
               "       [Пол]," +
               "       [ДатаРождения]," +
               "       [ДомашнийАдрес]," +
               "       [Телефон]," +
               "       [МестоРаботы]," +
               "       [ИзучаемыйЯзык]," +
               "       [Образование]," +
               "       [Статус] " +
               "FROM [Личные данные] " +
               "INNER JOIN [Группы] ON [Личные данные].[КодГруппы] = [Группы].[Код]";

            String Where = "";
            if (genderM.Checked || genderF.Checked || birthdayYear.SelectedIndex > 0 || languageE.Checked || languageF.Checked || languageN.Checked || status.SelectedIndex > 0)
            {
                Where += " Where ";

                if (genderM.Checked || genderF.Checked)
                {
                    Where += ((genderM.Checked) ? "[Личные данные].[Пол] = 'Мужской' and " : "");
                    Where += ((genderF.Checked) ? "[Личные данные].[Пол] = 'Женский' and " : "");
                }

                Where += (birthdayYear.SelectedIndex > 0)
                    ? $"Year([Личные данные].[ДатаРождения]) = {birthdayYear.Items[birthdayYear.SelectedIndex].ToString()} and "
                    : "";

                if (languageE.Checked || languageF.Checked || languageN.Checked)
                {
                    Where += ((languageE.Checked) ? "[Личные данные].[ИзучаемыйЯзык] = 'Английский' and " : "");
                    Where += ((languageF.Checked) ? "[Личные данные].[ИзучаемыйЯзык] = 'Французкий' and " : "");
                    Where += ((languageN.Checked) ? "[Личные данные].[ИзучаемыйЯзык] = 'Немецкий' and " : "");
                }

                Where += ((status.SelectedIndex > 0) ? $"[Личные данные].[Статус] = '{status.Items[status.SelectedIndex].ToString()}' and " : "");

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as MainForm).Filter(
                (this.Owner as MainForm).selfTabDataTable,
                Request + Where);

            Close();
        }
    }
}
