using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.MoveDataTabs
{
    public partial class AddMoveData : Form
    {
        public AddMoveData()
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
                    "Шифр",
                    "УчебныйГод",
                    "Курс",
                    "НомерПриказа",
                    "ДатаПриказа"
                };
                var values = new string[]
                {
                    shi.Text,
                    moveLearningYear.Text,
                    moveCourse.Text,
                    moveNumber.Text,
                    Convert.ToDateTime(moveDate.Text).ToString()
                };
                Datebase.InsertData("Движение", field, values);
                (this.Owner as MainForm).LoadDataInMoveDataTable();
                this.Close();
            }
        }
    }
}
