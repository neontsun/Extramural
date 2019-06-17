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
    public partial class EditGroups : Form
    {
        string ID = string.Empty;

        public EditGroups(string[] values)
        {
            InitializeComponent();

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
            this.Load += (f, a) =>
            {
                this.ID = values[0];

                groupNumber.Text = values[1];
                groupSpec.Text = values[2];
                groupYearIn.Text = values[3];
            };

            save.Click += (f, a) => 
            {
                (this.Owner as Groups).UpdateDataInGroupDataTable(
                    new string[]
                    {
                        "НомерГруппы",
                        "КодСпециальности",
                        "ГодПоступления"
                    },
                    new string[]
                    {
                        groupNumber.Text,
                        Datebase.GetSpecID(groupSpec.Text).ToString(),
                        groupYearIn.Text
                    },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as Groups).LoadDataInGroupsDataTable();
                this.Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
