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

namespace ЗаочноеОтделение.SubjectDataTabs
{
    public partial class FilterSubjectData : Form
    {
        public FilterSubjectData()
        {
            InitializeComponent();

            OleDbDataBase _database = new OleDbDataBase(new FileInfo(Properties.Settings.Default.ConnectionPath));
            OleDbResult _result;

            _result = _database.Request("Select [НаименованиеПредмета] from [Предметы]");
            SubjectName.Items.Clear();
            SubjectName.Items.Add("Не выбрано");
            foreach (DataRow _row in _result.Table.Rows)
                SubjectName.Items.Add(_row[0].ToString());
            SubjectName.SelectedIndex = 0;

            _result = _database.Request("Select [Фамилия] from [Преподаватели]");
            Teacher.Items.Clear();
            Teacher.Items.Add("Не выбрано");
            foreach (DataRow _row in _result.Table.Rows)
                Teacher.Items.Add(_row[0].ToString());
            Teacher.SelectedIndex = 0;

            _database.Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String Request =
                "SELECT [КодПредмета]," +
                "       [НаименованиеПредмета]," +
                "       [КоличествоЧасов]," +
                "       [Фамилия] & ' ' & LEFT([Имя], 1) & '.' & LEFT([Отчество], 1) & '.', " +
                "       [Курс]" +
                "FROM [Предметы] " +
                "INNER JOIN [Преподаватели] ON [Преподаватели].[КодПреподавателя] = [Предметы].[КодПреподавателя]";

            String Where = "";
            if (SubjectName.SelectedIndex > 0 || Teacher.SelectedIndex > 0 || Course.Text != "")
            {
                Where += " Where ";

                Where += ((SubjectName.SelectedIndex > 0) ? $"[Предметы].[НаименованиеПредмета] = '{SubjectName.Items[SubjectName.SelectedIndex].ToString()}' and " : "");
                Where += ((Teacher.SelectedIndex > 0) ? $"[Преподаватели].[Фамилия] = '{Teacher.Items[Teacher.SelectedIndex].ToString()}' and " : "");
                Where += ((Course.Text != "") ? $"[Предметы].[Курс] = {Course.Text} and " : "");

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as MainForm).Filter(
                (this.Owner as MainForm).subjectTabDataTable,
                Request + Where);

            Close();
        }
    }
}
