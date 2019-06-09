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

namespace ЗаочноеОтделение.SubjectDataTabs
{
    public partial class AddSubjectData : Form
    {
        public AddSubjectData()
        {
            InitializeComponent();

            save.Click += (f, a) => Add();
            cancel.Click += (f, a) => this.Close();

            this.Load += (f, a) =>
            {
                subjectPropod.Items.Clear();

                using (var connec = new OleDbConnection(Properties.Settings.Default.connect))
                {
                    connec.Open();
                    using (var cmd = connec.CreateCommand())
                    {
                        cmd.CommandText = "SELECT [Фамилия], [Имя], [Отчество] " +
                                          "FROM [Преподаватели]";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subjectPropod.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                            }
                        }
                    }
                }
            };
        }

        public void Add()
        {
            int countTextBox = 0;
            int countCombobox = 0;
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Text == string.Empty)
                    {
                        countTextBox++;
                    }
                }
                if (item is ComboBox)
                {
                    if ((item as ComboBox).Text == string.Empty)
                    {
                        countCombobox++;
                    }
                }
            }
            if (countTextBox != 0 || countCombobox != 0)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                var field = new string[]
                {
                    "НаименованиеПредмета",
                    "КоличествоЧасов",
                    "КодПреподавателя",
                    "Курс"
                };
                var values = new string[]
                {
                    subjectName.Text,
                    subjectHours.Text,
                    Datebase.GetPrepodID(subjectPropod.Text).ToString(),
                    subjectCourse.Text
                };
                Datebase.InsertData("Предметы", field, values);
                (this.Owner as MainForm).LoadDataInSubjectDataTable();
                this.Close();
            }
        }
    }
}
