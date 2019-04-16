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
            selfTabDataTable.Height = tabs.Height - 150; 
            // Ширина полосы разделения у меню
            selfTabToolsSeparatorHorizontal.Width = tabs.Width;

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
            ozenkiTabDataTable.Height = tabs.Height - 150;
            // Ширина полосы разделения у меню
            ozenkiTabToolsSeparatorHorizontal.Width = tabs.Width;
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
            subjectTabDataTable.Height = tabs.Height - 150;
            // Ширина полосы разделения у меню
            subjectTabToolsSeparatorHorizontal.Width = tabs.Width;
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
        }
    }
}
