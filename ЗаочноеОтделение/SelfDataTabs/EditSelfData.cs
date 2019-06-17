using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗаочноеОтделение.SelfDataTabs
{
    public partial class EditSelfData : Form
    {
        string ID = string.Empty;

        public EditSelfData(string[] values)
        {
            InitializeComponent();
            
            this.Load += (f, a) => 
            {
                this.ID = values[0];

                cipher.Text = values[0];
                group.Text = values[1];
                fio.Text = values[2];
                if (values[3] == "Мужской")
                    genderM.Checked = true;
                else
                    genderF.Checked = true;

                birthday.Text = Convert.ToDateTime(values[4]).ToString();
                adress.Text = values[5];
                phone.Text = values[6];
                jobPlace.Text = values[7];

                if (values[8] == "Английский")
                    languageE.Checked = true;
                else if (values[8] == "Французкий")
                    languageF.Checked = true;
                else
                    languageN.Checked = true;

                education.Text = values[9];
                status.Text = values[10];
            };
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            (this.Owner as MainForm).UpdateDataInSelfDataTable(
                new string[]
                {
                    "Шифр",
                    "КодГруппы",
                    "ФИО",
                    "Пол",
                    "ДатаРождения",
                    "ДомашнийАдрес",
                    "Телефон",
                    "МестоРаботы",
                    "ИзучаемыйЯзык",
                    "Образование",
                    "Статус"
                },
                new string[]
                {
                    cipher.Text,
                    Datebase.GetGroupID(group.Text).ToString(),
                    fio.Text,
                    genderF.Checked ? genderF.Text : genderM.Text,
                    Convert.ToDateTime(birthday.Text).ToString(),
                    adress.Text,
                    phone.Text,
                    jobPlace.Text,
                    languageE.Checked ? languageE.Text : (languageF.Checked ? languageF.Text : languageN.Text),
                    education.Text,
                    status.Text
                },
                new string[] 
                {
                    this.ID
                }
            );
            (this.Owner as MainForm).LoadDataInSelfDataTable();
            this.Close();
        }
    }
}
