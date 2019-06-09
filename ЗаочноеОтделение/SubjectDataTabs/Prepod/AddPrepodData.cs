using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SubjectDataTabs.Prepod
{
    public partial class AddPrepodData : Form
    {
        public AddPrepodData()
        {
            InitializeComponent();

            save.Click += (f, a) => Add();
            cancel.Click += (f, a) => this.Close();
        }

        public void Add()
        {
            int countTextBox = 0;
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Text == string.Empty)
                    {
                        countTextBox++;
                    }
                }
            }
            if (countTextBox != 0)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                var field = new string[]
                {
                    "Фамилия",
                    "Имя",
                    "Отчество"
                };
                var values = new string[]
                {
                    prepodLastName.Text,
                    prepodName.Text,
                    prepodMiddleName.Text,
                };
                Datebase.InsertData("Преподаватели", field, values);
                (this.Owner as Prepod).LoadDataInPrepodDataTable();
                this.Close();
            }
        }
    }
}
