using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SelfDataTabs.Groups
{
    public partial class FilterGroups : Form
    {
        public FilterGroups()
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
                "SELECT [НомерГруппы], " +
                "       [Специальность].[КодСпециальности] & ' ' & [НаименованиеСпециальности], " +
                "       [ГодПоступления] " +
                "FROM [Группы] " +
                "INNER JOIN [Специальность] ON [Группы].[КодСпециальности] = [Специальность].[Код]";

            String Where = "";
            if (groupCode.Text != "" || groupYearIn.Text != "" || groupYearOut.Text != "")
            {
                Where += " Where ";

                Where += (groupCode.Text != "") ? $"[НомерГруппы] = '{groupCode.Text}' and " : "";
                Where += (groupYearIn.Text != "") ? $"[НаименованиеСпециальности] Like '%{groupYearIn.Text}%' and " : "";
                Where += (groupYearOut.Text != "") ? $"[ГодПоступления] = {groupYearOut.Text} and " : "";

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as Groups).Filter(
                (this.Owner as Groups).groupsDataTable,
                Request + Where);

            Close();
        }
    }
}
