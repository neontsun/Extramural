using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        #endregion



        /// <summary>
        /// Конструктор класса основной формы
        /// </summary>
        public MainForm()
        {
            // Стандартная функция отрисовки контролов
            InitializeComponent();

            // Считываем размер экрана пользователя
            // Ширина
            tabs.Width = Screen.PrimaryScreen.Bounds.Size.Width;
            // Высота
            tabs.Height = Screen.PrimaryScreen.Bounds.Size.Height - 150;

            // Событие при клике на кнопку меню "Настройки",
            // создаем объект формы настроек и открываем ее
            topMenu.Items[1].Click += (f, a) => new Settings().ShowDialog();

            // Создаем вкладку "Личные данные"
            CreateSelfDataTab();
            // Создаем вкладку "Успеваемость"
            CreateOzenkiTab();
            // Создаем вкладку "Предметы"
            CreateSubjectTab();
            // Создаем вкладку "Дипломный проект"
            CreateDiplomTab();
            // Создаем вкладку "Движение"
            CreateMoveTab();
        }
    }
}
