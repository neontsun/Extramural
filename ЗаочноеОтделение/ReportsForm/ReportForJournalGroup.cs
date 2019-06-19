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
using Excel = Microsoft.Office.Interop.Excel;

namespace ЗаочноеОтделение.ReportsForm
{
    public partial class ReportForJournalGroup : Form
    {
        public ReportForJournalGroup()
        {
            InitializeComponent();

            this.Load += (f, a) => FillGroup();

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



        private void CreateReportForJournal()
        {
            Excel.Application ex = new Excel.Application();
            ex.Visible = true;
            ex.SheetsInNewWorkbook = 4;

            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);

            ex.DisplayAlerts = false;

            // По курсу
            for (int i = 1; i <= 4; i++)
            {

                Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(i);
                sheet.Name = i + " курс";

                sheet.Cells[1, 1] = "ФИО";
                sheet.Cells[1, 2] = "Дата рождения";
                sheet.Cells[1, 3] = "Год поступления";

                var propod = new List<string>();
                using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
                {
                    using (var cmd = connect.CreateCommand())
                    {
                        connect.Open();

                        cmd.CommandText = "SELECT DISTINCT [НаименованиеПредмета], [Фамилия] " +
                                          "FROM ((([Предметы]  " +
                                          "INNER JOIN [Преподаватели] ON  [Предметы].[КодПреподавателя] = [Преподаватели].[КодПреподавателя]) " +
                                          "INNER JOIN [Успеваемость] ON  [Успеваемость].[КодПредмета] = [Предметы].[КодПредмета])" +
                                          "INNER JOIN [Личные данные] ON  [Успеваемость].[Шифр] = [Личные данные].[Шифр])" +
                                          "INNER JOIN [Группы] ON  [Группы].[Код] = [Личные данные].[КодГруппы] " +
                                          "WHERE [Курс] = " + i + " AND  [Группы].[НомерГруппы] = '" + group.Text + "'";


                        using (var reader = cmd.ExecuteReader())
                        {
                            propod.Clear();
                            while (reader.Read())
                            {
                                propod.Add(reader[0].ToString() + ". Преподаватель: " + reader[1].ToString());
                            }
                        }
                    }
                }
                for (int k = 0; k < propod.Count; k++)
                {
                    sheet.Cells[1, k + 4] = propod[k];
                }

                var students = new List<string>();
                using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
                {
                    using (var cmd = connect.CreateCommand())
                    {
                        connect.Open();

                        cmd.CommandText = "SELECT [ФИО], [ДатаРождения], [ГодПоступления], [Шифр] " +
                                          "FROM [Личные данные] " +
                                          "INNER JOIN [Группы] ON [Группы].[Код] = [Личные данные].[КодГруппы] " +
                                          "WHERE [Группы].[НомерГруппы] = '" + group.Text + "'";


                        using (var reader = cmd.ExecuteReader())
                        {
                            var index = 2;
                            students.Clear();
                            while (reader.Read())
                            {
                                sheet.Cells[index, 1] = reader[0].ToString();
                                sheet.Cells[index, 2] = Convert.ToDateTime(reader[1]).ToShortDateString();
                                sheet.Cells[index, 3] = reader[2].ToString();
                                students.Add(reader[3].ToString());
                                index++;
                            }
                        }
                    }
                }

                var stCount = 2;
                foreach (var item in students)
                {
                    var oz = new List<string>();
                    using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
                    {
                        using (var cmd = connect.CreateCommand())
                        {
                            connect.Open();

                            // Сделать шифр спивком и через цикл

                            cmd.CommandText = "SELECT [ОценкаКР] " +
                                              "FROM (([Предметы]   " +
                                              "INNER JOIN [Преподаватели] ON  [Предметы].[КодПреподавателя] = [Преподаватели].[КодПреподавателя]) " +
                                              "LEFT JOIN [Успеваемость] ON  [Успеваемость].[КодПредмета] = [Предметы].[КодПредмета]) " +
                                              "LEFT JOIN [Личные данные] ON  [Успеваемость].[Шифр] = [Личные данные].[Шифр] " +
                                              "WHERE [Курс] = " + i + " AND [НаличиеКР] = 'Да' AND [Личные данные].[Шифр] = '" + item + "' ";
                            
                            using (var reader = cmd.ExecuteReader())
                            {
                                oz.Clear();
                                while (reader.Read())
                                {
                                    oz.Add(reader[0].ToString());
                                }
                            }
                            if (oz.Count == 0)
                            {
                                stCount++;
                            }
                            else
                            {
                                for (int k = 4; k < oz.Count + 4; k++)
                                {
                                    sheet.Cells[stCount, k] = oz.ElementAtOrDefault(k - 4);
                                }
                                stCount++;
                            }
                        }
                    }
                }

                var rangeZ = sheet.get_Range("A1", "AG1");
                Excel.Range range1 = sheet.Cells[1, 1];
                Excel.Range range2 = sheet.Cells[200, 200];

                var rangeO = sheet.get_Range(range1, range2);
                rangeZ.EntireColumn.AutoFit();
                rangeO.EntireColumn.AutoFit();
                rangeO.EntireRow.AutoFit();
                rangeO.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                rangeO.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }


            ex.Application.ActiveWorkbook.SaveAs(@"doc.xlsx", Type.Missing, Type.Missing, 
                Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateReportForJournal();
        }
    }
}
