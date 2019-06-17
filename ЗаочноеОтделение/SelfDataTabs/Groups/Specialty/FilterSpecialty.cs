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

namespace ЗаочноеОтделение.SelfDataTabs.Groups.Specialty
{
    public partial class FilterSpecialty : Form
    {
        public FilterSpecialty()
        {
            InitializeComponent();

            OleDbDataBase _database = new OleDbDataBase(new FileInfo(Properties.Settings.Default.ConnectionPath));
            OleDbResult _result = _database.Request("Select [КодСпециальности] from [Специальность]");

            // Сбор данных
            DataTable _data = _result.Table;
            _database.Dispose();

            specCode.Items.Clear();
            specCode.Items.Add("Не выбрано");
            foreach (DataRow _row in _result.Table.Rows)
                specCode.Items.Add(_row[0].ToString());

            specCode.SelectedIndex = 0;

            save.Click += (f, a) => 
            {
                String Request =
                "SELECT [Специальность].[Код], [Специальность].[КодСпециальности], " +
                "       [НаименованиеСпециальности] " +
                "FROM [Специальность]";

                String Where = "";
                if (specCode.SelectedIndex > 0 || _name.Text != "")
                {
                    Where += " Where ";

                    Where += (specCode.SelectedIndex > 0) ? $"[Специальность].[КодСпециальности] = '{specCode.Items[specCode.SelectedIndex].ToString()}' and " : "";
                    Where += (_name.Text != "") ? $"[НаименованиеСпециальности] Like '%{_name.Text}%' and " : "";

                    Where = Where.Remove(Where.Length - 5);
                }

            (this.Owner as Specialty).Filter(
                (this.Owner as Specialty).specialtyDataTable,
                Request + Where);

                Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
