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
    public partial class EditOzenkiData : Form
    {

        string ID = string.Empty;

        public EditOzenkiData(string[] values)
        {
            InitializeComponent();

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
            this.Load += (f, a) =>
            {
                this.ID = values[0];

                ozenkiChipher.Text = values[1];
                ozenkiCourse.Text = values[2];
                ozenkiSubject.Text = values[3];
                ozenkiOzenka.Text = values[4];
                KRIsTrue.Checked = values[5] == "Да" ? true : false;
                KRIsOzenka.Text = values[6];
            };

            save.Click += (f, a) => 
            {
                (this.Owner as MainForm).UpdateDataInOzenkiDataTable(
                    new string[]
                    {
                        "Шифр",
                        "КодПредмета",
                        "Оценка",
                        "НаличиеКР",
                        "ОценкаКР"
                    },
                    new string[]
                    {
                        ozenkiChipher.Text,
                        Datebase.GetSubjectID(ozenkiSubject.Text).ToString(),
                        ozenkiOzenka.Text,
                        KRIsTrue.Checked == true ? "Да" : "Нет",
                        KRIsOzenka.Text
            },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as MainForm).LoadDataInOzenkiDataTable();
                this.Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
