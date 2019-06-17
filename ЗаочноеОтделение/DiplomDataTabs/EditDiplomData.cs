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

namespace ЗаочноеОтделение.DiplomDataTabs
{
    public partial class EditDiplomData : Form
    {
        string ID = string.Empty;

        public EditDiplomData(string[] values)
        {
            InitializeComponent();

            this.Load += (f, a) =>
            {
                diplomPropod.Items.Clear();

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
                                diplomPropod.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                            }
                        }
                    }
                }
            };
            this.Load += (f, a) =>
            {
                this.ID = values[0];

                diplomName.Text = values[1];
                diplomPropod.Text = values[2];
                diplomSroki.Text = values[3];
                diplomIn.Text = values[4];
                diplomOut.Text = values[5];
            };

            save.Click += (f, a) => 
            {
                (this.Owner as MainForm).UpdateDataInDiplomDataTable(
                    new string[]
                    {
                        "Тема",
                        "Руководитель",
                        "СрокиСдачи",
                        "Выдан",
                        "Сдан"
                    },
                    new string[]
                    {
                        diplomName.Text,
                        Datebase.GetPrepodID(diplomPropod.Text).ToString(),
                        diplomSroki.Text,
                        diplomIn.Text,
                        diplomOut.Text
                    },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as MainForm).LoadDataInDiplomDataTable();
                this.Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
