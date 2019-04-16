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
            birthdayMonth.Items.Clear();
            birthdayYear.Items.Clear();

            // Заполняем список месяцев
            for (int i = 0; i < 12; i++)
                birthdayMonth.Items.Add(month[i]);

            // Заполняем список годов
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 100; i--)
                birthdayYear.Items.Add(i.ToString());
        }
    }
}
