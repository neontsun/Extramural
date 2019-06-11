using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.MoveDataTabs
{
    public partial class FilterMoveData : Form
    {
        public FilterMoveData()
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
                "Select [Шифр], [УчебныйГод], [Курс], [НомерПриказа], [ДатаПриказа] from [Движение]";

            String Where = "\n";
            if (moveCurrentYear.Text != "" || moveNumber.Text != "" || moveDate.Text != "")
            {
                Where += " Where ";

                Where += (moveCurrentYear.Text != "") ? $"[Движение].[УчебныйГод] Like '%{moveCurrentYear.Text}%' and " : "";
                Where += (moveNumber.Text != "") ? $"[Движение].[НомерПриказа] = {moveNumber.Text} and " : "";
                Where += (moveDate.Text != "") ? $"Year([Движение].[ДатаПриказа]) = {moveDate.Text} and " : "";

                Where = Where.Remove(Where.Length - 5);
            }

            (this.Owner as MainForm).Filter(
                (this.Owner as MainForm).moveTabDataTable,
                Request + Where);

            Close();
        }
    }
}
