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

            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

            sheet.Name = "1 курс";

            for (int i = 1; i <= 50; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    sheet.Cells[i, j] = "Данные";
                }
            }

            Excel.Range range1 = sheet.Cells[1, 1];
            Excel.Range range2 = sheet.Cells[9, 9];
            var oRange = sheet.get_Range(range1, range2);
            oRange.EntireColumn.AutoFit();

            oRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;

            ex.Application.ActiveWorkbook.SaveAs("doc.xlsx", Type.Missing, Type.Missing, 
                Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateReportForJournal();
        }
    }
}
