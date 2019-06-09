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

namespace ЗаочноеОтделение.OzenkiDataTabs
{
    public partial class AddOzenkiData : Form
    {
        public AddOzenkiData()
        {
            InitializeComponent();

            save.Click += (f, a) => Add();
            cancel.Click += (f, a) => this.Close();

            this.Load += (f, a) =>
            {
                ozenkiSubject.Items.Clear();

                using (var connec = new OleDbConnection(Properties.Settings.Default.connect))
                {
                    connec.Open();
                    using (var cmd = connec.CreateCommand())
                    {
                        cmd.CommandText = "SELECT [НаименованиеПредмета], [КоличествоЧасов], [Курс] " +
                                          "FROM [Предметы]";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ozenkiSubject.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + "ч" + reader[2].ToString() + "к");
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
                        if ((item as TextBox).Name != "label10")
                        {
                            countTextBox++;
                        }
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
                    "Шифр",
                    "КодПредмета",
                    "Оценка",
                    "НаличиеКР",
                    "ОценкаКР"
                };
                var values = new object[]
                {
                    ozenkiChipher.Text,
                    Datebase.GetSubjectID(ozenkiSubject.Text).ToString(),
                    Convert.ToInt32(ozenkiOzenka.Text),
                    thisIsKR.Checked ? "Да" : "Нет",
                    Convert.ToInt32(ozenkiCourse.Text)
                };
                Datebase.InsertData("Успеваемость", field, values);
                (this.Owner as MainForm).LoadDataInOzenkiDataTable();
                this.Close();
            }
        }
    }
}
