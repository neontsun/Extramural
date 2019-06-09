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
    public partial class AddSpecialty : Form
    {
        public AddSpecialty()
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
                    "КодСпециальности",
                    "НаименованиеСпециальности"
                };
                var values = new string[]
                {
                    specCode.Text,
                    specName.Text
                };
                Datebase.InsertData("Специальность", field, values);
                (this.Owner as Specialty).LoadDataInSpecialtyDataTable();
                this.Close();
            }
        }
    }
}
