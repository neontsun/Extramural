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

namespace ЗаочноеОтделение.SelfDataTabs
{
    public partial class AddSelfData : Form
    {
        public AddSelfData()
        {
            InitializeComponent();

            save.Click += (f, a) => Add();
            cancel.Click += (f, a) => this.Close();

            this.Load += (f, a) =>
            {
                group.Items.Clear();

                using (var connec = new OleDbConnection(Properties.Settings.Default.connect))
                {
                    connec.Open();
                    using (var cmd = connec.CreateCommand())
                    {
                        cmd.CommandText = "SELECT [НомерГруппы] " +
                                          "FROM [Группы]";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                group.Items.Add(reader[0].ToString());
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
            if (countTextBox != 0 || countCombobox != 0 || !genderF.Checked && !genderM.Checked 
                || !languageE.Checked && !languageF.Checked && !languageN.Checked)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                var field = new string[] 
                {
                    "Шифр",
                    "КодГруппы",
                    "ФИО",
                    "Пол",
                    "ДатаРождения",
                    "ДомашнийАдрес",
                    "Телефон",
                    "МестоРаботы",
                    "ИзучаемыйЯзык",
                    "Образование",
                    "Статус"
                };
                var values = new string[]
                {
                    cipher.Text,
                    Datebase.GetGroupID(group.Text).ToString(),
                    fio.Text,
                    genderF.Checked ? genderF.Text : genderM.Text,
                    Convert.ToDateTime(birthday.Text).ToString(),
                    adress.Text,
                    phone.Text,
                    jobPlace.Text,
                    languageE.Checked ? languageE.Text : (languageF.Checked ? languageF.Text : languageN.Text),
                    education.Text,
                    status.Text
                };
                Datebase.InsertData("Личные данные", field, values);
                (this.Owner as MainForm).LoadDataInSelfDataTable();
                this.Close();
            }
        }
    }
}
