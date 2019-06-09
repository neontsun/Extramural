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

namespace ЗаочноеОтделение.SelfDataTabs.Groups
{
    public partial class AddGroups : Form
    {
        public AddGroups()
        {
            InitializeComponent();

            save.Click += (f, a) => Add();
            cancel.Click += (f, a) => this.Close();

            this.Load += (f, a) => 
            {
                groupSpec.Items.Clear();

                using (var connec = new OleDbConnection(Properties.Settings.Default.connect))
                {
                    connec.Open();
                    using (var cmd = connec.CreateCommand())
                    {
                        cmd.CommandText = "SELECT [КодСпециальности], [НаименованиеСпециальности] " +
                                          "FROM [Специальность]";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                groupSpec.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
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
                    "НомерГруппы",
                    "КодСпециальности",
                    "ГодПоступления"
                };
                var values = new string[]
                {
                    groupNumber.Text,
                    Datebase.GetSpecID(groupSpec.Text).ToString(),
                    groupYearIn.Text
                };
                Datebase.InsertData("Группы", field, values);
                (this.Owner as Groups).LoadDataInGroupsDataTable();
                this.Close();
            }
        }
    }
}
