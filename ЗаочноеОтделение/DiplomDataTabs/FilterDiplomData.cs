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

namespace ЗаочноеОтделение.DiplomDataTabs
{
    public partial class FilterDiplomData : Form
    {
        public FilterDiplomData()
        {
            InitializeComponent();

            OleDbDataBase _database = new OleDbDataBase(new FileInfo(Properties.Settings.Default.ConnectionPath));
            OleDbResult _result = _database.Request("Select [Фамилия] from [Преподаватели]");

            // Сбор данных
            DataTable _data = _result.Table;
            _database.Dispose();

            Teacher.Items.Clear();
            Teacher.Items.Add("Не выбрано");
            foreach (DataRow _row in _result.Table.Rows)
                Teacher.Items.Add(_row[0].ToString());

            Teacher.SelectedIndex = 0;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String Request =
                "SELECT [Шифр]," +
                "       [Тема]," +
                "       [Фамилия] & ' ' & LEFT([Имя], 1) & '.' & LEFT([Отчество], 1) & '.', " +
                "       [СрокиСдачи], " +
                "       [Выдан], " +
                "       [Сдан]" +
                "FROM [Диплом] " +
                "INNER JOIN [Преподаватели] ON [Преподаватели].[КодПреподавателя] = [Диплом].[Руководитель]";

            String Where = "";
            if (Theme.Text != "" || Teacher.SelectedIndex > 0)
            {
                Where += " Where ";

                Where += (Theme.Text != "") ? $"[Тема] Like '%{Theme.Text}%' and " : "";
                Where += (Teacher.SelectedIndex > 0) ? $"[Фамилия] = '{Teacher.Items[Teacher.SelectedIndex].ToString()}' and " : "";

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as MainForm).Filter(
                (this.Owner as MainForm).diplomTabDataTable,
                Request + Where);

            Close();
        }
    }
}
