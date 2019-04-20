using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
