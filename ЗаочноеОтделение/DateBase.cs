using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаочноеОтделение
{
    public static class Datebase
    {
        /// <summary>
        /// Внесение данных в таблицу БД.
        /// </summary>
        /// <param name="Table">Таблица для внесения.</param>
        /// <param name="Field">Массив полей.</param>
        /// <param name="Value">Массив значений.</param>
        public static void InsertData(string Table, string[] Field, object[] Value)
        {
            // Создаем подключение
            using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Формируем запрос
                using (var cmd = connect.CreateCommand())
                {
                    // Открываем соединение
                    connect.Open();


                    // Сборка данных в запрос
                    cmd.CommandText = "INSERT INTO [" + Table + "] (";

                    foreach (var ArrEllField in Field)
                    {
                        cmd.CommandText += "[" + ArrEllField + "], ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2);
                    cmd.CommandText += ")";

                    cmd.CommandText += " VALUES (";


                    foreach (var ArrEllValue in Value)
                    {
                        cmd.CommandText += "'" + ArrEllValue + "', ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2);
                    cmd.CommandText += ")";


                    // Отправляем запрос на выполнение
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        /// <summary>
        /// Возвращает ID группы
        /// </summary>
        public static int GetGroupID(string number)
        {
            // Создаем подключение
            using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Формируем запрос
                using (var cmd = connect.CreateCommand())
                {
                    // Открываем соединение
                    connect.Open();

                    cmd.CommandText = "SELECT [Код] " +
                                      "FROM [Группы] " +
                                      "WHERE [НомерГруппы] = @Group";
                    cmd.Parameters.AddWithValue("@Group", number);

                    // Отправляем запрос на выполнение
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Возвращает ID специальности
        /// </summary>
        public static int GetSpecID(string name)
        {
            // Создаем подключение
            using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Формируем запрос
                using (var cmd = connect.CreateCommand())
                {
                    // Открываем соединение
                    connect.Open();

                    cmd.CommandText = "SELECT [Код] " +
                                      "FROM [Специальность] " +
                                      "WHERE [КодСпециальности] & \" \" & [НаименованиеСпециальности] = @Name";
                    cmd.Parameters.AddWithValue("@Name", name);

                    // Отправляем запрос на выполнение
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Возвращает ID предмета
        /// </summary>
        public static int GetSubjectID(string sub)
        {
            // Создаем подключение
            using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Формируем запрос
                using (var cmd = connect.CreateCommand())
                {
                    // Открываем соединение
                    connect.Open();

                    cmd.CommandText = "SELECT [КодПредмета] " +
                                      "FROM [Предметы] " +
                                      "WHERE [НаименованиеПредмета] & \" \" & [КоличествоЧасов] & \"ч\" & [Курс] & \"к\" = @sub";
                    cmd.Parameters.AddWithValue("@sub", sub);

                    // Отправляем запрос на выполнение
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Возвращает ID преподавателя
        /// </summary>
        public static int GetPrepodID(string name)
        {
            // Создаем подключение
            using (var connect = new OleDbConnection(Properties.Settings.Default.connect))
            {
                // Формируем запрос
                using (var cmd = connect.CreateCommand())
                {
                    // Открываем соединение
                    connect.Open();

                    cmd.CommandText = "SELECT [КодПреподавателя] " +
                                      "FROM [Преподаватели] " +
                                      "WHERE [Фамилия] & \" \" & [Имя] & \" \" & [Отчество] = @name";
                    cmd.Parameters.AddWithValue("@name", name);

                    // Отправляем запрос на выполнение
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
