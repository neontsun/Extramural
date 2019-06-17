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
    public partial class EditPrepodData : Form
    {
        string ID = string.Empty;

        public EditPrepodData(string[] values)
        {
            InitializeComponent();
            this.Load += (f, a) =>
            {
                this.ID = values[0];

                prepodLastName.Text = values[1];
                prepodName.Text = values[2];
                prepodMiddleName.Text = values[3];
            };


            save.Click += (f, a) => 
            {
                (this.Owner as Prepod).UpdateDataInPrepodDataTable(
                    new string[]
                    {
                        "Фамилия",
                        "Имя",
                        "Отчество"
                    },
                    new string[]
                    {
                        prepodLastName.Text,
                        prepodName.Text,
                        prepodMiddleName.Text
                    },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as Prepod).LoadDataInPrepodDataTable();
                this.Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
