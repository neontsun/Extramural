using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


            //Клик по кнопке "Добавить запись"
            specialtyCreateNote.Click += (f, a) => new AddSpecialty().ShowDialog();
            //Клик по кнопке "Редактировать запись"
            specialtyEditNote.Click += (f, a) => new EditSpecialty().ShowDialog();
            //Клик по кнопке "Фильтр выборки"
            specialtyFilter.Click += (f, a) => new FilterSpecialty().ShowDialog();
            //Клик по кнопке "Сбросить фильтр"
            specialtyFilterClear.Click += (f, a) => 
            {
                MessageBox.Show("Фильтр сброшен");
            };
        }
    }
}
