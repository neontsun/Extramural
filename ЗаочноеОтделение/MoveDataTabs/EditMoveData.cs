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
    public partial class EditMoveData : Form
    {
        string ID = string.Empty;

        public EditMoveData(string[] values)
        {
            InitializeComponent();

            this.Load += (f, a) =>
            {
                this.ID = values[0];

                shifr.Text = values[1];
                moveLearningYear.Text = values[2];
                moveCourse.Text = values[3];
                moveNumber.Text = values[4];
                moveDate.Text = values[5];
            };


            save.Click += (f, a) => 
            {
                (this.Owner as MainForm).UpdateDataInMoveDataTable(
                    new string[]
                    {
                        "Шифр",
                        "УчебныйГод",
                        "Курс",
                        "НомерПриказа",
                        "ДатаПриказа"
                    },
                    new string[]
                    {
                        shifr.Text,
                        moveLearningYear.Text,
                        moveCourse.Text,
                        moveNumber.Text,
                        moveDate.Text
                    },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as MainForm).LoadDataInMoveDataTable();
                this.Close();

            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
