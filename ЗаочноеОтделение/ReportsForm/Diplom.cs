using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ЗаочноеОтделение.ReportsForm
{
    public partial class Diplom : Form
    {
        public Diplom()
        {
            InitializeComponent();

            group.SelectedValueChanged += (f, a) =>
            {
                if (group.Text != string.Empty)
                {
                    label2.Visible = true;
                    student.Visible = true;
                    FillGroup(group.Text);
                }
            };

            this.Load += (f, a) => FillGroup();
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wd)
        {
            var range = wd.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
            range.Underline = Word.WdUnderline.wdUnderlineSingle;
        }

        private void FillGroup()
        {
            using (var conn = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Открываем подключение
                conn.Open();
                // Создаем команду
                using (var cmd = conn.CreateCommand())
                {
                    // Создаем запрос к бд
                    cmd.CommandText = "SELECT [НомерГруппы]" +
                                      "FROM [Группы]";

                    

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            group.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }

        private void FillGroup(string group)
        {
            using (var conn = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Открываем подключение
                conn.Open();
                // Создаем команду
                using (var cmd = conn.CreateCommand())
                {
                    // Создаем запрос к бд
                    cmd.CommandText = "SELECT [ФИО]" +
                                      "FROM [Личные данные] " +
                                      "INNER JOIN [Группы] ON [Личные данные].[КодГруппы] = [Группы].[Код] " +
                                      "WHERE [Группы].[НомерГруппы] = @Group";
                    cmd.Parameters.AddWithValue("@Group", group);

                    student.Items.Clear();
                    student.Text = string.Empty;

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            string[] values = new string[1];

            using (var conn = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Открываем подключение
                conn.Open();
                // Создаем команду
                using (var cmd = conn.CreateCommand())
                {
                    // Создаем запрос к бд
                    cmd.CommandText = "SELECT [Тема] " +
                                      "FROM [Личные данные] as ld " +
                                      "INNER JOIN [Диплом] as d ON ld.[Шифр] = d.[Шифр] " +
                                      "WHERE ld.[ФИО] = @FIO";
                    cmd.Parameters.AddWithValue("@FIO", student.Text);

                    // Получаем данные из бд
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            values[0] = reader[0].ToString();
                        }
                    }
                }

                var template = Directory.GetCurrentDirectory()
                .Remove(Directory.GetCurrentDirectory().Length - 10) + "\\Templates\\Дипломный проект.doc";
                var finishTemplate = Directory.GetCurrentDirectory()
                .Remove(Directory.GetCurrentDirectory().Length - 10) + "\\Готовые отчеты\\Дипломный проект.doc";

                var wA = new Word.Application();
                wA.Visible = false;

                var wordDoc = wA.Documents.Open(template);

                try
                {
                    ReplaceWordStub("{tema}", values[0], wordDoc);

                    wordDoc.SaveAs2(finishTemplate);
                    wA.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка");
                }
            }
        }
    }
}
