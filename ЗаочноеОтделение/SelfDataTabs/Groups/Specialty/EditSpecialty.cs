using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SelfDataTabs.Groups.Specialty
{
    public partial class EditSpecialty : Form
    {
        string ID = string.Empty;

        public EditSpecialty(string[] values)
        {
            InitializeComponent();

            this.Load += (f, a) =>
            {
                this.ID = values[0];

                specCode.Text = values[1];
                specName.Text = values[2];
            };

            save.Click += (f, a) => 
            {
                (this.Owner as Specialty).UpdateDataInSpecDataTable(
                    new string[]
                    {
                        "КодСпециальности",
                        "НаименованиеСпециальности"
                    },
                    new string[]
                    {
                        specCode.Text,
                        specName.Text
                    },
                    new string[]
                    {
                        this.ID
                    }
                );
                (this.Owner as Specialty).LoadDataInSpecialtyDataTable();
                this.Close();
            };
            cancel.Click += (f, a) => this.Close();
        }
    }
}
