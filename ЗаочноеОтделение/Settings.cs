using System.Windows.Forms;

namespace ЗаочноеОтделение
{
    public partial class Settings : Form
    {
        // Переменная пути к базе данных на диске
        string path = string.Empty;
        string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=@;";

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Settings()
        {
            // Стандартная функция отрисовки контролов
            InitializeComponent();

            // Если путь к базе данных в параметрах приложения 
            // не пустой, то подгружаем их в переменную
            if (Properties.Settings.Default.ConnectionPath != string.Empty)
                path = Properties.Settings.Default.ConnectionPath;
            // Иначе выводим сообщение
            else
                path = "Не выбрано";
            
            // Записываем в лейбл путь
            location.Text = path;

            // Событие при клике по кнопке "Изменить"
            changeLocation.Click += (f, a) => 
            {
                // Создаем объект диалога выбора файла
                using (var fd = new OpenFileDialog())
                {
                    // Ставим фильтр объектов в окне выбора файлов
                    fd.Filter = "mdb files (*.mdb)|*.mdb";
                    // Если была нажата кнопка ОК в окне
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        // Очищаем строку подключения строку подключения
                        Properties.Settings.Default.connect = connStr;
                        Properties.Settings.Default.Save();

                        // Записываем в переменную пути путь к выбранному файлу
                        path = fd.FileName;
                        // Записываем в лейбл путь
                        location.Text = path;

                        // Сохраняем путь в переменную из параметров 
                        Properties.Settings.Default.ConnectionPath = path;
                        Properties.Settings.Default.Save();

                        // Сохраняем строку подключения
                        Properties.Settings.Default.connect = Properties.Settings.Default.connect.Replace("@", path);
                        Properties.Settings.Default.Save();
                    }
                }
            };

            // Событие при клике на "Очистить"
            clearPath.Click += (f, a) => 
            {
                // Очищаем строку подключения строку подключения
                Properties.Settings.Default.ConnectionPath = string.Empty;
                // Очищаем строку подключения строку подключения
                Properties.Settings.Default.connect = connStr;
                // Сохраняем
                Properties.Settings.Default.Save();
                // Ставим путь
                location.Text = "Не выбрано";
            };
        }
    }
}
