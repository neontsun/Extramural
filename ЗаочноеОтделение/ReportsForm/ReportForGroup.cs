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
using Word = Microsoft.Office.Interop.Word;

namespace ЗаочноеОтделение.ReportsForm
{
    public partial class ReportForGroup : Form
    {
        public ReportForGroup()
        {
            InitializeComponent();

            this.Load += (f, a) => FillGroup();
            create.Click += (f, a) => 
            {
                if (group.Text != string.Empty)
                    CreateReport();
            };
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

        private void CreateReport()
        {
            using (var conn = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Открываем подключение
                conn.Open();
                // Создаем команду
                using (var cmd = conn.CreateCommand())
                {
                    // Создаем запрос к бд
                    cmd.CommandText = "SELECT COUNT([Шифр]) " +
                                      "FROM [Личные данные] " +
                                      "INNER JOIN [Группы] ON [Личные данные].[КодГруппы] = [Группы].[Код] " +
                                      "WHERE [НомерГруппы] = @Number";
                    cmd.Parameters.AddWithValue("@Number", group.Text);
                    var count = (int)cmd.ExecuteScalar();

                    // Создаем запрос к бд
                    cmd.CommandText = "SELECT " +
                                      "     [Шифр], " +
                                      "     [НомерГруппы], " +
                                      "     [ФИО], " +
                                      "     [Пол], " +
                                      "     [ДатаРождения], " +
                                      "     [ДомашнийАдрес], " +
                                      "     [Телефон], " +
                                      "     [МестоРаботы], " +
                                      "     [ИзучаемыйЯзык], " +
                                      "     [Образование], " +
                                      "     [Статус] " +
                                      "FROM [Личные данные] " +
                                      "INNER JOIN [Группы] ON [Личные данные].[КодГруппы] = [Группы].[Код] " +
                                      "WHERE [НомерГруппы] = @Number";
                    cmd.Parameters.AddWithValue("@Number", group.Text);

                    string[,] values = new string[count, 11];
                    using (var reader = cmd.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            values[index, 0] = reader[0].ToString();
                            values[index, 1] = reader[1].ToString();
                            values[index, 2] = reader[2].ToString();
                            values[index, 3] = reader[3].ToString();
                            values[index, 4] = reader[4].ToString();
                            values[index, 5] = reader[5].ToString();
                            values[index, 6] = reader[6].ToString();
                            values[index, 7] = reader[7].ToString();
                            values[index, 8] = reader[8].ToString();
                            values[index, 9] = reader[9].ToString();
                            values[index, 10] = reader[10].ToString();
                            index++;
                        }
                    }


                    Word.Application wApp = new Word.Application();
                    Word.Document doc = wApp.Documents.Add(Visible: true);

                    Word.Range r = doc.Range();
                    r.Text = "Hi";
                    r.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                    Word.Table table = doc.Tables.Add(r, count, 11);
                    table.Borders.Enable = 1;
                    
                    foreach (Word.Row row in table.Rows)
                    {
                        int index_col = 0;
                        foreach (Word.Cell cell in row.Cells)
                        {
                            cell.Range.Text = values[cell.RowIndex - 1, index_col];
                            cell.Range.Font.Name = "Century Gothic";
                            cell.Range.Font.Size = 10;
                            cell.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            index_col++;
                        }
                    }

                    doc.Save();
                }
            }
        }
    }
}
