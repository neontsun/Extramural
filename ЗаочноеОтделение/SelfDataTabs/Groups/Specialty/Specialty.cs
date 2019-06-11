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

namespace ЗаочноеОтделение.SelfDataTabs.Groups.Specialty
{
    public partial class Specialty : Form
    {

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Specialty()
        {
            // Стандартный метод отрисовки интерфейса
            InitializeComponent();

            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            specialtyDataTable.Width = this.Width - 25;
            // Высота
            specialtyDataTable.Height = this.Height - 200;
            // Ширина полосы разделения у меню
            specialtyToolsSeparatorHorizontal.Width = this.Width;
            // Меняем размер разделителя у таблицы
            panel1.Width = this.Width - 27;

            //Клик по кнопке "Добавить запись"
            specialtyCreateNote.Click += (f, a) => 
            {
                new AddSpecialty()
                {
                    Owner = this
                }.ShowDialog();
            };
            //Клик по кнопке "Редактировать запись"
            specialtyEditNote.Click += (f, a) => 
            {
                new EditSpecialty()
                {
                    Owner = this
                }.ShowDialog();
            };
            //Клик по кнопке "Фильтр выборки"
            specialtyFilter.Click += (f, a) => 
            {
                new FilterSpecialty()
                {
                    Owner = this
                }.ShowDialog();
            };
            //Клик по кнопке "Сбросить фильтр"
            specialtyFilterClear.Click += (f, a) => 
            {
                this.LoadDataInSpecialtyDataTable();
            };

            specialtyDeleteNote.Click += (f, a) =>
            {

                if (specialtyDataTable.SelectedItems.Count > 0)
                {
                    string str = specialtyDataTable.SelectedItems[0].Text;
                    DeleteDataInSpecDataTable(str);
                    LoadDataInSpecialtyDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };


            // Событие при загрузке формы
            this.Load += (f, a) => LoadDataInSpecialtyDataTable();
        }


        /// <summary>
        /// Метод, который подкгружает данные в таблицу при загрузке формы
        /// </summary>
        internal void LoadDataInSpecialtyDataTable()
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
                    cmd.CommandText = "SELECT [Код],[Специальность].[КодСпециальности], " +
                                      "       [НаименованиеСпециальности] " +
                                      "FROM [Специальность]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        specialtyDataTable.Items.Clear();

                        // Пока идет чтение построчно
                        while (reader.Read())
                        {
                            // Добавляем строку
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.BackColor = goodColor;
                            //if (reader[10].ToString() == "Отчислен")
                            //    item.ForeColor = Color.White;

                            specialtyDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }


        internal void DeleteDataInSpecDataTable(string id)
        {
            // Создаем подключение к бд и передаем строку подключения в параметры
            using (var conn = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Открываем подключение
                conn.Open();
                // Создаем команду
                using (var cmd = conn.CreateCommand())
                {
                    // Отдельно запросы...

                    // Создаем запрос к бд
                    cmd.CommandText = "DELETE " +
                                      "FROM [Специальность] " +
                                      "WHERE [Код] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
