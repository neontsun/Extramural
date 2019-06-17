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
            groupsShowSpecialty.Click += (f, a) => 
            {
                new Specialty.Specialty()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Клик по кнопке "Добавить запись"
            groupsCreateNote.Click += (f, a) => 
            {
                new AddGroups()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Клик по кнопке "Добавить запись"
            groupsEditNote.Click += (f, a) => 
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (groupsDataTable.SelectedItems.Count > 0)
                    new EditGroups(new string[]
                    {
                        groupsDataTable.SelectedItems[0].Text,
                        groupsDataTable.SelectedItems[0].SubItems[1].Text,
                        groupsDataTable.SelectedItems[0].SubItems[2].Text,
                        groupsDataTable.SelectedItems[0].SubItems[3].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
            // Клик по кнопке "Сбросить фильтр"
            groupsFilterClear.Click += (f, a) => 
            {
                this.LoadDataInGroupsDataTable();
            };
            // Клик по кнопке "Фильтр"
            groupsFilter.Click += (f, a) => 
            {
                new FilterGroups()
                {
                    Owner = this
                }.ShowDialog();
            };

            groupsDeleteNote.Click += (f, a) =>
            {

                if (groupsDataTable.SelectedItems.Count > 0)
                {
                    string str = groupsDataTable.SelectedItems[0].Text;
                    DeleteDataInGroupDataTable(str);
                    LoadDataInGroupsDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };


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
                    cmd.CommandText = "SELECT [Группы].[Код], [НомерГруппы], " +
                                      "       [Специальность].[КодСпециальности] & ' ' & [НаименованиеСпециальности], " +
                                      "       [ГодПоступления] " + 
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
                            item.BackColor = goodColor;
                            //if (reader[10].ToString() == "Отчислен")
                            //    item.ForeColor = Color.White;

                            groupsDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }


        internal void DeleteDataInGroupDataTable(string id)
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
                                      "FROM [Группы] " +
                                      "WHERE [Код] = @ID";
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

        internal void UpdateDataInGroupDataTable(string[] fields, string[] values, string[] where)
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
                    cmd.CommandText = "UPDATE [Группы] " +
                                      "SET ";

                    for (int i = 0; i < fields.Length; i++)
                    {
                        cmd.CommandText += "[" + fields[i] + "] = '" + values[i] + "', ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2) + " WHERE [Код] = " + where[0];
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
