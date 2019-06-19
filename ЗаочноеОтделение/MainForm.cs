using ProgLib.Data.OleDb;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ЗаочноеОтделение.DiplomDataTabs;
using ЗаочноеОтделение.MoveDataTabs;
using ЗаочноеОтделение.OzenkiDataTabs;
using ЗаочноеОтделение.SelfDataTabs;
using ЗаочноеОтделение.SelfDataTabs.Groups;
using ЗаочноеОтделение.SubjectDataTabs;
using ЗаочноеОтделение.SubjectDataTabs.Prepod;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

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
            selfTabCreateNote.Click += (f, a) => 
            {
                new AddSelfData()
                {
                    Owner = this
                }.ShowDialog();
            };

            // Событие при клике на кнопку "Редактировать запись"
            selfTabEditNote.Click += (f, a) => 
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (selfTabDataTable.SelectedItems.Count > 0)
                    new EditSelfData(new string[] 
                    {
                        selfTabDataTable.SelectedItems[0].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[1].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[2].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[3].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[4].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[5].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[6].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[7].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[8].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[9].Text,
                        selfTabDataTable.SelectedItems[0].SubItems[10].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };

            // Событие при клике на кнопку "Фильтр"
            selfTabFilter.Click += (f, a) => 
            {
                new FilterSelfData()
                {
                    Owner = this
                }.ShowDialog();
            };

            // Событие при клике на кнопку "Сбросить фильтр"
            selfTabFilterClear.Click += (f, a) => 
            {
                this.LoadDataInSelfDataTable();
            };

            // Событие при клике на кнопку "Показать группы"
            selfTabShowGroups.Click += (f, a) => 
            {
                new Groups()
                {
                    Owner = this
                }.ShowDialog();
            };

            selfTabDeleteNote.Click += (f, a) => 
            {

                if (selfTabDataTable.SelectedItems.Count > 0)
                {
                    string str = selfTabDataTable.SelectedItems[0].Text;
                    DeleteDataInSelfDataTable(str);
                    LoadDataInSelfDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
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
            ozenkiTabCreateNote.Click += (f, a) => 
            {
                new AddOzenkiData()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Событие при нажатие на кнопку "Редактировать запись"
            ozenkiTabEditNote.Click += (f, a) => 
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (ozenkiTabDataTable.SelectedItems.Count > 0)
                    new EditOzenkiData(new string[]
                    {
                        ozenkiTabDataTable.SelectedItems[0].Text,
                        ozenkiTabDataTable.SelectedItems[0].SubItems[1].Text,
                        ozenkiTabDataTable.SelectedItems[0].SubItems[2].Text,
                        ozenkiTabDataTable.SelectedItems[0].SubItems[3].Text,
                        ozenkiTabDataTable.SelectedItems[0].SubItems[4].Text,
                        ozenkiTabDataTable.SelectedItems[0].SubItems[5].Text,
                        ozenkiTabDataTable.SelectedItems[0].SubItems[6].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
            // Событие при нажатие на кнопку "Очистить фильтр"
            ozenkiTabFilterClear.Click += (f, a) => 
            {
                this.LoadDataInOzenkiDataTable();
            };
            // Событие при нажатие на кнопку "Фильтр"
            ozenkiTabFilter.Click += (f, a) => 
            {
                new FilterOzenkiData()
                {
                    Owner = this
                }.ShowDialog();
            };

            ozenkiTabDeleteNote.Click += (f, a) =>
            {

                if (ozenkiTabDataTable.SelectedItems.Count > 0)
                {
                    string str = ozenkiTabDataTable.SelectedItems[0].Text;
                    DeleteDataInOzenkiDataTable(str);
                    LoadDataInOzenkiDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
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
            // Меняем размер разделителя у таблицы
            subjectTabDataTableSeparator.Width = tabs.Width - 27;

            subjectTabCreateNote.Click += (f, a) => 
            {
                new AddSubjectData()
                {
                    Owner = this
                }.ShowDialog();
            };
            subjectTabEditNote.Click += (f, a) =>
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (subjectTabDataTable.SelectedItems.Count > 0)
                    new EditSubjectData(new string[]
                    {
                        subjectTabDataTable.SelectedItems[0].Text,
                        subjectTabDataTable.SelectedItems[0].SubItems[1].Text,
                        subjectTabDataTable.SelectedItems[0].SubItems[2].Text,
                        subjectTabDataTable.SelectedItems[0].SubItems[3].Text,
                        subjectTabDataTable.SelectedItems[0].SubItems[4].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
            subjectTabFilter.Click += (f, a) => 
            {
                new FilterSubjectData()
                {
                    Owner = this
                }.ShowDialog();
            };
            subjectTabFilterClear.Click += (f, a) => 
            {
                this.LoadDataInSubjectDataTable();
            };

            subjectTabShowTeacher.Click += (f, a) => 
            {
                new Prepod()
                {
                    Owner = this
                }.ShowDialog();
            };

            subjectTabDeleteNote.Click += (f, a) =>
            {

                if (subjectTabDataTable.SelectedItems.Count > 0)
                {
                    string str = subjectTabDataTable.SelectedItems[0].Text;
                    DeleteDataInSubjectDataTable(str);
                    LoadDataInSubjectDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
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

            diplomTabCreateNote.Click += (f, a) =>
            {
                new AddDiplomData()
                {
                    Owner = this
                }.ShowDialog();
            };
            diplomTabEditNote.Click += (f, a) =>
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (diplomTabDataTable.SelectedItems.Count > 0)
                    new EditDiplomData(new string[]
                    {
                        diplomTabDataTable.SelectedItems[0].Text,
                        diplomTabDataTable.SelectedItems[0].SubItems[1].Text,
                        diplomTabDataTable.SelectedItems[0].SubItems[2].Text,
                        diplomTabDataTable.SelectedItems[0].SubItems[3].Text,
                        diplomTabDataTable.SelectedItems[0].SubItems[4].Text,
                        diplomTabDataTable.SelectedItems[0].SubItems[5].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
            diplomTabFilter.Click += (f, a) =>
            {
                new FilterDiplomData()
                {
                    Owner = this
                }.ShowDialog();
            };
            diplomTabFilterClear.Click += (f, a) =>
            {
                this.LoadDataInDiplomDataTable();
            };

            diplomTabShowTeacher.Click += (f, a) => 
            {
                new Prepod
                {
                    Owner = this
                }.ShowDialog();
            };

            diplomTabDeleteNote.Click += (f, a) =>
            {

                if (diplomTabDataTable.SelectedItems.Count > 0)
                {
                    string str = diplomTabDataTable.SelectedItems[0].Text;
                    DeleteDataInDiplomDataTable(str);
                    LoadDataInDiplomDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };

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
            moveTabCreateNote.Click += (f, a) => 
            {
                new AddMoveData()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Событие клика по кнопке "Редактировать запись"
            moveTabEditNote.Click += (f, a) => 
            {
                // Если количество выбранных записей в таблице 
                // больше нуля, то открываем форму редактирования
                if (moveTabDataTable.SelectedItems.Count > 0)
                    new EditMoveData(new string[]
                    {
                        moveTabDataTable.SelectedItems[0].Text,
                        moveTabDataTable.SelectedItems[0].SubItems[1].Text,
                        moveTabDataTable.SelectedItems[0].SubItems[2].Text,
                        moveTabDataTable.SelectedItems[0].SubItems[3].Text,
                        moveTabDataTable.SelectedItems[0].SubItems[4].Text,
                        moveTabDataTable.SelectedItems[0].SubItems[5].Text
                    })
                    {
                        Owner = this
                    }.ShowDialog();
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
            // Событие клика по кнопке "Фильтр выборки"
            moveTabFilter.Click += (f, a) => 
            {
                new FilterMoveData()
                {
                    Owner = this
                }.ShowDialog();
            };
            // Событие при клике на кнопку "Сбросить фильтр"
            moveTabFilterClear.Click += (f, a) =>
            {
                this.LoadDataInMoveDataTable();
            };

            moveTabDeleteNote.Click += (f, a) =>
            {

                if (moveTabDataTable.SelectedItems.Count > 0)
                {
                    string str = moveTabDataTable.SelectedItems[0].Text;
                    DeleteDataInMoveDataTable(str);
                    LoadDataInMoveDataTable();
                }
                // Иначе показываем ошибку
                else
                    MessageBox.Show("Выберите запись для редактирования");
            };
        }

        #endregion
        

        /// <summary>
        /// Конструктор класса основной формы
        /// </summary>
        public MainForm()
        {
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

            // Формирование отчета "Личная карточка"
            Reports.DropDownItems[0].Click += (f, a) => new ReportsForm.SelfCard().ShowDialog();
            Reports.DropDownItems[1].Click += (f, a) => new ReportsForm.Diplom().ShowDialog();
            //Reports.DropDownItems[2].Click += (f, a) => new ReportsForm.Diplom().ShowDialog();
            Reports.DropDownItems[3].Click += (f, a) => new ReportsForm.ReportForJournalGroup().ShowDialog();
            Reports.DropDownItems[4].Click += (f, a) => new ReportsForm.ReportForGroup().ShowDialog();


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
                if (Properties.Settings.Default.ConnectionPath != string.Empty)
                    this.LoadDataInSelfDataTable();
                else
                    MessageBox.Show("Укажите путь к базе данных.");
            };

            #endregion
        }

        #region Методы

       
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
                            item.BackColor = goodColor;

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
                    cmd.CommandText = "SELECT [Успеваемость].[Код], " +
                                      "       [Шифр]," +
                                      "       [Курс]," +
                                      "       [НаименованиеПредмета] & \" \" & [КоличествоЧасов] & \"ч\" & [Курс] & \"к\"," +
                                      "       [Оценка]," +
                                      "       [НаличиеКР]," +
                                      "       [ОценкаКР] " +
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
                            item.SubItems.Add(reader[5].ToString());
                            item.SubItems.Add(reader[6].ToString());
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
                    cmd.CommandText = "SELECT [Код], " +
                                      "       [Шифр]," +
                                      "       [УчебныйГод]," +
                                      "       [Курс]," +
                                      "       [НомерПриказа]," +
                                      "       [ДатаПриказа] " +
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
                            item.SubItems.Add(reader[4].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader[5]).ToShortDateString());
                            item.BackColor = goodColor;

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
                    cmd.CommandText = "SELECT [КодПредмета]," +
                                      "       [НаименованиеПредмета]," +
                                      "       [КоличествоЧасов]," +
                                      "       [Фамилия] & ' ' & [Имя] & ' ' & [Отчество], " +
                                      "       [Курс]" +
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
                            item.SubItems.Add(reader[4].ToString());
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
                                      "       [Фамилия] & ' ' & [Имя] & ' ' & [Отчество], " +
                                      "       [СрокиСдачи], " +
                                      "       [Выдан], " +
                                      "       [Сдан]" +
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
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(reader[4].ToString());
                            item.SubItems.Add(reader[5].ToString());
                            item.BackColor = goodColor;
                            //if (reader[10].ToString() == "Отчислен")
                            //    item.ForeColor = Color.White;

                            diplomTabDataTable.Items.Add(item);
                        }
                    }
                }
            }
        }




        internal void DeleteDataInSelfDataTable(string id)
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
                    
                    cmd.CommandText = "DELETE " +
                                      "FROM [Личные данные] " +
                                      "WHERE [Шифр] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteDataInOzenkiDataTable(string id)
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
                                      "FROM [Успеваемость] " +
                                      "WHERE [Код] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteDataInMoveDataTable(string id)
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
                                      "FROM [Движение] " +
                                      "WHERE [Код] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteDataInSubjectDataTable(string id)
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
                    
                    cmd.CommandText = "DELETE " +
                                      "FROM [Предметы] " +
                                      "WHERE [кодПредмета] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteDataInDiplomDataTable(string id)
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
                                      "WHERE [Шифр] = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }




        internal void UpdateDataInSelfDataTable(string[] fields, string[] values, string[] where)
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
                    cmd.CommandText = "UPDATE [Личные данные] " +
                                      "SET ";

                    for (int i = 0; i < fields.Length; i++)
                    {
                        cmd.CommandText += "[" + fields[i] + "] = '" + values[i] + "', ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2) + " WHERE [Шифр] = '" + where[0] + "'";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void UpdateDataInOzenkiDataTable(string[] fields, string[] values, string[] where)
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
                    cmd.CommandText = "UPDATE [Успеваемость] " +
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

        internal void UpdateDataInMoveDataTable(string[] fields, string[] values, string[] where)
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
                    cmd.CommandText = "UPDATE [Движение] " +
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

        internal void UpdateDataInSubjectDataTable(string[] fields, string[] values, string[] where)
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
                    cmd.CommandText = "UPDATE [Предметы] " +
                                      "SET ";

                    for (int i = 0; i < fields.Length; i++)
                    {
                        cmd.CommandText += "[" + fields[i] + "] = '" + values[i] + "', ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2) + " WHERE [КодПредмета] = " + where[0];
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void UpdateDataInDiplomDataTable(string[] fields, string[] values, string[] where)
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
                    cmd.CommandText = "UPDATE [Диплом] " +
                                      "SET ";

                    for (int i = 0; i < fields.Length; i++)
                    {
                        cmd.CommandText += "[" + fields[i] + "] = '" + values[i] + "', ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2) + " WHERE [Шифр] = '" + where[0] + "'";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
        
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
    }
}
