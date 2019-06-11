using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SubjectDataTabs.Prepod
{
    public partial class FilterPrepodData : Form
    {
        public FilterPrepodData()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String Request =
                "SELECT [КодПреподавателя]," +
                "       [Фамилия]," +
                "       [Имя]," +
                "       [Отчество] " +
                "FROM [Преподаватели]";

            String Where = "";
            if (tName.Text != "" || Surname.Text != "")
            {
                Where += " Where ";

                Where += (tName.Text != "") ? $"[Имя] Like '%{tName.Text}%' and " : "";
                Where += (Surname.Text != "") ? $"[Фамилия] Like '%{Surname.Text}%' and " : "";

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as Prepod).Filter(
                (this.Owner as Prepod).prepodTabDataTable,
                Request + Where);

            Close();
        }
    }
}
