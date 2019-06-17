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
    public partial class EditSubjectData : Form
    {
        string ID = string.Empty;

        public EditSubjectData(string[] values)
        {
            InitializeComponent();

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
            this.Load += (f, a) =>
            {
                this.ID = values[0];

                subjectName.Text = values[1];
                subjectHours.Text = values[2];
                subjectPropod.Text = values[3];
                subjectCourse.Text = values[4];
            };

            save.Click += (f, a) => 
            {
                (this.Owner as MainForm).UpdateDataInSubjectDataTable(
                    new string[]
                    {
                        "НаименованиеПредмета",
                        "КоличествоЧасов",
                        "КодПреподавателя",
                        "Курс"
                    },
                    new string[]
                    {
                        subjectName.Text,
                        subjectHours.Text,
                        Datebase.GetPrepodID(subjectPropod.Text).ToString(),
                        subjectCourse.Text
            },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as MainForm).LoadDataInSubjectDataTable();
                this.Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
