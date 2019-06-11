using ProgLib.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.OzenkiDataTabs
{
    public partial class FilterOzenkiData : Form
    {
        public FilterOzenkiData()
        {
            InitializeComponent();

            OleDbDataBase _database = new OleDbDataBase(new FileInfo(Properties.Settings.Default.ConnectionPath));
            OleDbResult _result = _database.Request("Select [НаименованиеПредмета] from [Предметы]");

            // Сбор данных
            DataTable _data = _result.Table;
            _database.Dispose();

            ozenkiSubject.Items.Clear();
            ozenkiSubject.Items.Add("Не выбрано");
            foreach (DataRow _row in _result.Table.Rows)
                ozenkiSubject.Items.Add(_row[0].ToString());

            ozenkiSubject.SelectedIndex = 0;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String Request =
                "SELECT [Код]," +
                "       [Шифр]," +
                "       [Курс]," +
                "       [НаименованиеПредмета]," +
                "       [Оценка]," +
                "       [НаличиеКР]," +
                "       [ОценкаКР] " +
                "FROM [Успеваемость] " +
                "INNER JOIN [Предметы] ON [Успеваемость].[КодПредмета] = [Предметы].[КодПредмета]";

            String Where = "";
            if (ozenkiCourse.Text != "" || ozenkiSubject.SelectedIndex > 0 || ozenkiOtmetka2.Checked || ozenkiOtmetka3.Checked || ozenkiOtmetka4.Checked || ozenkiOtmetka5.Checked)
            {
                Where += " Where ";

                Where += (ozenkiCourse.Text != "") ? $"[Предметы].[Курс] = {ozenkiCourse.Text} and " : "";
                Where += (ozenkiSubject.SelectedIndex > 0) ? $"[Предметы].[НаименованиеПредмета] = '{ozenkiSubject.Items[ozenkiSubject.SelectedIndex].ToString()}' and " : "";

                Where += (ozenkiOtmetka2.Checked) ? $"[Оценка] = '2' and " : "";
                Where += (ozenkiOtmetka3.Checked) ? $"[Оценка] = '3' and " : "";
                Where += (ozenkiOtmetka4.Checked) ? $"[Оценка] = '4' and " : "";
                Where += (ozenkiOtmetka5.Checked) ? $"[Оценка] = '5' and " : "";

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as MainForm).Filter(
                (this.Owner as MainForm).ozenkiTabDataTable,
                Request + Where);

            Close();
        }
    }
}
