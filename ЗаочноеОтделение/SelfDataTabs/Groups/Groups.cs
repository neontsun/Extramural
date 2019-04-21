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

namespace ЗаочноеОтделение.SelfDataTabs.Groups
{
    public partial class Groups : Form
    {

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Groups()
        {
            // Стандартный метод построения интерфейса
            InitializeComponent();

            // Клик по кнопке "Показать специальность"
            groupsShowSpecialty.Click += (f, a) => new Specialty.Specialty().ShowDialog();
            // Клик по кнопке "Добавить запись"
            groupsCreateNote.Click += (f, a) => new AddGroups().ShowDialog();
            // Клик по кнопке "Добавить запись"
            groupsEditNote.Click += (f, a) => new EditGroups().ShowDialog();
            // Клик по кнопке "Сбросить фильтр"
            groupsFilterClear.Click += (f, a) => 
            {
                MessageBox.Show("Фильтр сброшен");
            };
            // Клик по кнопке "Фильтр"
            groupsFilter.Click += (f, a) => new FilterGroups().ShowDialog();


            // Событие при загрузке формы
            this.Load += (f, a) => LoadDataInGroupsDataTable();
        }



        /// <summary>
        /// Метод, который подкгружает данные в таблицу при загрузке формы
        /// </summary>
        internal void LoadDataInGroupsDataTable()
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
                    cmd.CommandText = "SELECT [НомерГруппы], " +
                                      "       [Специальность].[КодСпециальности] & ' ' & [НаименованиеСпециальности], " +
                                      "       [ГодПоступления], " +
                                      "       [ГодОкончания], " +
                                      "       [ТекущийКурс]" +
                                      "FROM [Группы] " +
                                      "INNER JOIN [Специальность] ON [Группы].[КодСпециальности] = [Специальность].[Код]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        groupsDataTable.Items.Clear();

                        // Пока идет чтение построчно
                        while (reader.Read())
                        {
                            // Добавляем строку
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(reader[4].ToString());
                            item.BackColor = goodColor;
                            //if (reader[10].ToString() == "Отчислен")
                            //    item.ForeColor = Color.White;

                            groupsDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
