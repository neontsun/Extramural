using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SubjectDataTabs.Prepod
{
    public partial class Prepod : Form
    {
        /// <summary>
        /// Создание интерфейса для вкладки "Движение"
        /// </summary>
        internal void CreatePrepodTab()
        {
            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            prepodTabDataTable.Width = this.Width - 25;
            // Высота
            prepodTabDataTable.Height = this.Height - 200;
            // Ширина полосы разделения у меню
            diplomTabToolsSeparatorHorizontal.Width = this.Width;
            // Меняем размер разделителя у таблицы
            moveTabDataTableSeparator.Width = this.Width - 27;

            // Событие клика по кнопке "Добавить запись"
            prepodTabCreateNote.Click += (f, a) =>
            {
                new AddPrepodData()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Событие клика по кнопке "Редактировать запись"
            prepodTabEditNote.Click += (f, a) =>
            {
                new EditPrepodData()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Событие клика по кнопке "Фильтр выборки"
            prepodTabFilter.Click += (f, a) =>
            {
                new FilterPrepodData()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Событие при клике на кнопку "Сбросить фильтр"
            prepodTabFilterClear.Click += (f, a) =>
            {
                MessageBox.Show("Фильтр сброшен");
            };
        }


        public Prepod()
        {
            InitializeComponent();

            CreatePrepodTab();

            this.Load += (f, a) => LoadDataInPrepodDataTable();
        }


        /// <summary>
        /// Метод, который подкгружает данные во вкладку selfTab
        /// </summary>
        internal void LoadDataInPrepodDataTable()
        {
            // Цвета строки
            var goodColor = Color.FromArgb(160, 235, 176);
            var neutralColor = Color.FromArgb(186, 186, 186);
            var badColor = Color.FromArgb(51, 54, 51);

            // Создаем подключение к бд и передаем строку подключения в параметры
            using (var conn = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Открываем подключение
                conn.Open();
                // Создаем команду
                using (var cmd = conn.CreateCommand())
                {
                    // Создаем запрос к бд
                    cmd.CommandText = "SELECT [КодПреподавателя]," +
                                      "       [Фамилия]," +
                                      "       [Имя]," +
                                      "       [Отчество] " +
                                      "FROM [Преподаватели]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        prepodTabDataTable.Items.Clear();

                        // Пока идет чтение построчно
                        while (reader.Read())
                        {
                            // Добавляем строку
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.BackColor = goodColor;

                            prepodTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
