using ProgLib.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (prepodTabDataTable.SelectedItems.Count > 0)
                    new EditPrepodData(new string[]
                    {
                        prepodTabDataTable.SelectedItems[0].Text,
                        prepodTabDataTable.SelectedItems[0].SubItems[1].Text,
                        prepodTabDataTable.SelectedItems[0].SubItems[2].Text,
                        prepodTabDataTable.SelectedItems[0].SubItems[3].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
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
                this.LoadDataInPrepodDataTable();
            };



            prepodDeleteNote.Click += (f, a) =>
            {

                if (prepodTabDataTable.SelectedItems.Count > 0)
                {
                    string str = prepodTabDataTable.SelectedItems[0].Text;
                    DeleteDataInPrepodDataTable(str);
                    LoadDataInPrepodDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
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

        internal void DeleteDataInPrepodDataTable(string id)
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
                                      "FROM [Диплом] " +
                                      "WHERE [Руководитель] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE " +
                                      "FROM [Предметы] " +
                                      "WHERE [КодПреподавателя] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE " +
                                      "FROM [Преподаватели] " +
                                      "WHERE [КодПреподавателя] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Filter(ListView Table, String Request)
        {
            // Инициализация подключения к базе данных и запрос данных 
            OleDbDataBase _database = new OleDbDataBase(new FileInfo(Properties.Settings.Default.ConnectionPath));
            OleDbResult _result = _database.Request(Request);

            // Вывод сообщеня об ошибке при её наличии
            if (_result.Message != "Command(s) completed successfully.")
                MessageBox.Show(_result.Message, "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Сбор данных
            DataTable _data = _result.Table;
            _database.Dispose();

            // Очистка данных в ListView и заполнение новыми
            Table.Items.Clear();
            foreach (DataRow _row in _data.Rows)
            {
                ListViewItem Row = new ListViewItem(
                    _row.ItemArray.Select(x => x.ToString()).ToArray());

                Table.Items.Add(Row);
            }
        }

        internal void UpdateDataInPrepodDataTable(string[] fields, string[] values, string[] where)
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

                    // Сборка данных в запрос
                    cmd.CommandText = "UPDATE [Преподаватели] " +
                                      "SET ";

                    for (int i = 0; i < fields.Length; i++)
                    {
                        cmd.CommandText += "[" + fields[i] + "] = '" + values[i] + "', ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2) + " WHERE [КодПреподавателя] = " + where[0];
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
