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
using ЗаочноеОтделение.MoveDataTabs;
using ЗаочноеОтделение.OzenkiDataTabs;
using ЗаочноеОтделение.SelfDataTabs;
using ЗаочноеОтделение.SelfDataTabs.Groups;

namespace ЗаочноеОтделение
{
    public partial class MainForm : Form
    {
        #region Функции постройки интерфейса

        /// <summary>
        /// Создание интерфейса для вкладки "Личные данные"
        /// </summary>
        internal void CreateSelfDataTab()
        {
            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            selfTabDataTable.Width = tabs.Width - 25;
            // Высота
            selfTabDataTable.Height = tabs.Height - 200; 
            // Ширина полосы разделения у меню
            selfTabToolsSeparatorHorizontal.Width = tabs.Width;
            // Позиция кнопки ниже таблицы
            selfTabShowGroups.Location = 
                new Point(selfTabDataTable.Location.X, 
                selfTabDataTable.Location.Y + selfTabDataTable.Height + 15);
            // Меняем размер разделителя у таблицы
            selfTabDataTableSeparator.Width = tabs.Width - 27;
            // Событие при клике на кнопку "Добавить запись"
            // Создаем новый объект формы добавления записи (AddSelfData)
            // и открываем ее
            selfTabCreateNote.Click += (f, a) => new AddSelfData().ShowDialog();

            // Событие при клике на кнопку "Редактировать запись"
            selfTabEditNote.Click += (f, a) => 
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (selfTabDataTable.SelectedItems.Count > 0)
                    new EditSelfData().ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };

            // Событие при клике на кнопку "Фильтр"
            selfTabFilter.Click += (f, a) => new FilterSelfData().ShowDialog();

            // Событие при клике на кнопку "Сбросить фильтр"
            selfTabFilterClear.Click += (f, a) => 
            {
                MessageBox.Show("Фильтр сброшен");
            };

            // Событие при клике на кнопку "Показать группы"
            selfTabShowGroups.Click += (f, a) => new Groups().ShowDialog();
        }

        /// <summary>
        /// Создание интерфейса для вкладки "Успеваемость"
        /// </summary>
        internal void CreateOzenkiTab()
        {
            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            ozenkiTabDataTable.Width = tabs.Width - 25;
            // Высота
            ozenkiTabDataTable.Height = tabs.Height - 200;
            // Ширина полосы разделения у меню
            ozenkiTabToolsSeparatorHorizontal.Width = tabs.Width;
            // Меняем размер разделителя у таблицы
            ozenkiTabDataTableSeparator.Width = tabs.Width - 27;

            // Событие при нажатие на кнопку "Добавить запись"
            ozenkiTabCreateNote.Click += (f, a) => new AddOzenkiData().ShowDialog();
            // Событие при нажатие на кнопку "Редактировать запись"
            ozenkiTabEditNote.Click += (f, a) => new EditOzenkiData().ShowDialog();
            // Событие при нажатие на кнопку "Очистить фильтр"
            ozenkiTabFilterClear.Click += (f, a) => 
            {
                MessageBox.Show("Фильтр сброшен");
            };
            // Событие при нажатие на кнопку "Фильтр"
            ozenkiTabFilter.Click += (f, a) => new FilterOzenkiData().ShowDialog();
        }

        /// <summary>
        /// Создание интерфейса для вкладки "Предметы"
        /// </summary>
        internal void CreateSubjectTab()
        {
            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            subjectTabDataTable.Width = tabs.Width - 25;
            // Высота
            subjectTabDataTable.Height = tabs.Height - 200;
            // Ширина полосы разделения у меню
            subjectTabToolsSeparatorHorizontal.Width = tabs.Width;
            // Позиция кнопок ниже таблицы
            subjectTabShowTeacher.Location =
                new Point(subjectTabDataTable.Location.X, 
                subjectTabDataTable.Location.Y + subjectTabDataTable.Height + 15);
            subjectTabShowSubjectInCourse.Location =
                new Point(subjectTab.Location.X + subjectTabShowTeacher.Width + 15,
                subjectTabDataTable.Location.Y + subjectTabDataTable.Height + 15);
            // Меняем размер разделителя у таблицы
            subjectTabDataTableSeparator.Width = tabs.Width - 27;
        }

        /// <summary>
        /// Создание интерфейса для вкладки "Дипломный проект"
        /// </summary>
        internal void CreateDiplomTab()
        {
            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            diplomTabDataTable.Width = tabs.Width - 25;
            // Высота
            diplomTabDataTable.Height = tabs.Height - 200;
            // Ширина полосы разделения у меню
            diplomTabToolsSeparatorHorizontal.Width = tabs.Width;
            // Позиция кнопки ниже таблицы
            diplomTabShowTeacher.Location =
                new Point(diplomTabDataTable.Location.X,
                diplomTabDataTable.Location.Y + diplomTabDataTable.Height + 15);
            // Меняем размер разделителя у таблицы
            diplomTabDataTableSeparator.Width = tabs.Width - 27;
        }

        /// <summary>
        /// Создание интерфейса для вкладки "Движение"
        /// </summary>
        internal void CreateMoveTab()
        {
            // Меняем размер таблицы в зависимости от размера формы.
            // Из-за того, что мы открываем в полный экран программу, 
            // мы подстраиваем таблицу под размер
            // Ширина
            moveTabDataTable.Width = tabs.Width - 25;
            // Высота
            moveTabDataTable.Height = tabs.Height - 200;
            // Ширина полосы разделения у меню
            moveTabToolsSeparatorHorizontal.Width = tabs.Width;
            // Меняем размер разделителя у таблицы
            moveTabDataTableSeparator.Width = tabs.Width - 27;
            
            // Событие клика по кнопке "Добавить запись"
            moveTabCreateNote.Click += (f, a) => new AddMoveData().ShowDialog();
            // Событие клика по кнопке "Редактировать запись"
            moveTabEditNote.Click += (f, a) => new EditMoveData().ShowDialog();
            // Событие клика по кнопке "Фильтр выборки"
            moveTabFilter.Click += (f, a) => new FilterMoveData().ShowDialog();
            // Событие при клике на кнопку "Сбросить фильтр"
            moveTabFilterClear.Click += (f, a) =>
            {
                MessageBox.Show("Фильтр сброшен");
            };
        }

        #endregion



        /// <summary>
        /// Конструктор класса основной формы
        /// </summary>
        public MainForm()
        {
            // TODO: Переделать метод подгружения данных. Сделать через связи внутри приложения. Создать для этого классы.


            #region Построение интерфейса

            // Стандартная функция отрисовки контролов
            InitializeComponent();

            // Считываем размер экрана пользователя
            // Ширина
            tabs.Width = Screen.PrimaryScreen.Bounds.Size.Width;
            // Высота
            tabs.Height = Screen.PrimaryScreen.Bounds.Size.Height - 150;

            // Создаем вкладку "Личные данные"
            this.CreateSelfDataTab();
            // Создаем вкладку "Успеваемость"
            this.CreateOzenkiTab();
            // Создаем вкладку "Предметы"
            this.CreateSubjectTab();
            // Создаем вкладку "Дипломный проект"
            this.CreateDiplomTab();
            // Создаем вкладку "Движение"
            this.CreateMoveTab();

            #endregion

            #region Функционал

            // Событие при клике на кнопку меню "Настройки",
            // создаем объект формы настроек и открываем ее
            topMenu.Items[1].Click += (f, a) => new Settings().ShowDialog();

            // Событие при смене вкладки
            tabs.SelectedIndexChanged += (f, a) =>
            {
                // Проверяем индекс вкладки
                switch (tabs.SelectedIndex)
                {
                    case 0: this.LoadDataInSelfDataTable(); break;
                    case 1: this.LoadDataInOzenkiDataTable(); break;
                    case 2: this.LoadDataInMoveDataTable(); break;
                    case 3: this.LoadDataInSubjectDataTable(); break;
                    case 4: this.LoadDataInDiplomDataTable(); break;
                }
            };

            // Событие при загрузке формы
            this.Load += (f, a) =>
            {
                //MessageBox.Show(Properties.Settings.Default.connect);

                // Так как изначально у нас главная вкладка - Личные данные,
                // то при запуске программы заполняем таблицу на данной вкладке
                this.LoadDataInSelfDataTable();
            };

            #endregion
        }




        /// <summary>
        /// Метод, который подкгружает данные во вкладку selfTab
        /// </summary>
        internal void LoadDataInSelfDataTable()
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
                    cmd.CommandText = "SELECT [Шифр]," +
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

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        selfTabDataTable.Items.Clear();

                        // Пока идет чтение построчно
                        while (reader.Read())
                        {
                            // Добавляем строку
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(reader[4].ToString());
                            item.SubItems.Add(reader[5].ToString());
                            item.SubItems.Add(reader[6].ToString());
                            item.SubItems.Add(reader[7].ToString());
                            item.SubItems.Add(reader[8].ToString());
                            item.SubItems.Add(reader[9].ToString());
                            item.SubItems.Add(reader[10].ToString());
                            item.BackColor = badColor;
                            if (reader[10].ToString() == "Отчислен")
                                item.ForeColor = Color.White;
                            
                            selfTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который подкгружает данные во вкладку ozenkiTab
        /// </summary>
        internal void LoadDataInOzenkiDataTable()
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
                    cmd.CommandText = "SELECT [Шифр]," +
                                      "       [Курс]," +
                                      "       [НаименованиеПредмета]," +
                                      "       [Оценка]," +
                                      "       [Успеваемость].[Статус]," +
                                      "       [Дата] " +
                                      "FROM [Успеваемость] " +
                                      "INNER JOIN [Предметы] ON [Успеваемость].[КодПредмета] = [Предметы].[КодПредмета]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        ozenkiTabDataTable.Items.Clear();

                        // Пока идет чтение построчно
                        while (reader.Read())
                        {
                            // Добавляем строку
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(reader[4].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader[5]).ToShortDateString());
                            item.BackColor = goodColor;
                            //if (reader[10].ToString() == "Отчислен")
                            //    item.ForeColor = Color.White;

                            ozenkiTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который подкгружает данные во вкладку moveTab
        /// </summary>
        internal void LoadDataInMoveDataTable()
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
                    cmd.CommandText = "SELECT [Шифр]," +
                                      "       [УчебныйГод]," +
                                      "       [Курс]," +
                                      "       [НомерПриказа]," +
                                      "       [ДатаПриказа]," +
                                      "       [Движение].[Статус] " +
                                      "FROM [Движение]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        moveTabDataTable.Items.Clear();

                        // Пока идет чтение построчно
                        while (reader.Read())
                        {
                            // Добавляем строку
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader[4]).ToShortDateString());
                            item.SubItems.Add(reader[5].ToString());
                            item.BackColor = goodColor;
                            //if (reader[10].ToString() == "Отчислен")
                            //    item.ForeColor = Color.White;

                            moveTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который подкгружает данные во вкладку subjectTab
        /// </summary>
        internal void LoadDataInSubjectDataTable()
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
                    cmd.CommandText = "SELECT [НаименованиеПредмета]," +
                                      "       [КоличествоЧасов]," +
                                      "       [Фамилия] & ' ' & LEFT([Имя], 1) & '.' & LEFT([Отчество], 1) & '.', " +
                                      "       [Статус]" +
                                      "FROM [Предметы] " +
                                      "INNER JOIN [Преподаватели] ON [Преподаватели].[КодПреподавателя] = [Предметы].[КодПреподавателя]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        subjectTabDataTable.Items.Clear();

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

                            subjectTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который подкгружает данные во вкладку diplomTab
        /// </summary>
        internal void LoadDataInDiplomDataTable()
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
                    cmd.CommandText = "SELECT [Шифр]," +
                                      "       [Тема]," +
                                      "       [Фамилия] & ' ' & LEFT([Имя], 1) & '.' & LEFT([Отчество], 1) & '.'" +
                                      "FROM [Диплом] " +
                                      "INNER JOIN [Преподаватели] ON [Преподаватели].[КодПреподавателя] = [Диплом].[Руководитель]";

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Очищаем таблицу
                        diplomTabDataTable.Items.Clear();

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

                            diplomTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
