using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


// Рейс
namespace bus_coursework.MyClass {
    class Busline {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Busline(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        // Обновление рейса по ID автобусного парка
        public DataTable UpdateLineBusCheck(int ID) {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Рейс WHERE Индекс_автобусного_парка = {ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        // Функция, которая проверяет время рейса, т.е. время отправление не должно быть раньше прибытия
        public bool check_time(string departure, string arrival) {
            return int.Parse(Regex.Replace(arrival, "[^0-9]", String.Empty)) > int.Parse(Regex.Replace(departure, "[^0-9]", String.Empty));
        }

        // ID, номер рейса, откуда, куда, отправление (время), прибытие (время), стоимость проезда (вещественное число)
        public void Add(int ID_busline, string number, string from_where, string to_where, string departure, string arrival, double fare, int ID_busfeet) {
            if(!check_time(departure, arrival)) { MessageBox.Show("Ошибка заполнения время отправления или прибытия.\nПроверьте их", "Ошибка"); return; }

            connection.Open();
            try {
                command = new OleDbCommand($"INSERT INTO Рейс (" +
                    $"Индекс_рейса, " +
                    $"Номер_рейса, " +
                    $"Откуда, " +
                    $"Куда, " +
                    $"Отправление, " +
                    $"Прибытие, " +
                    $"Стоимость_проезда, " +
                    $"Индекс_автобусного_парка) " +
                    $"VALUES(" +
                    $"{ID_busline}, " + 
                    $"'{number}', " + 
                    $"'{from_where}', " + 
                    $"'{to_where}', " + 
                    $"'{departure}', " + 
                    $"'{arrival}', " + 
                    $"{fare}, " + 
                    $"{ID_busfeet})", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            connection.Close();
        }

        public void Update(int ID_busline, string number, string from_where, string to_where, string departure, string arrival, double fare, int ID_busfeet) {
            if(!check_time(departure, arrival)) { MessageBox.Show("Ошибка заполнения время отправления или прибытия.\nПроверьте их", "Ошибка"); return; }

            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Рейс " +
                    $"SET Номер_рейса = '{number}', " +
                        $"Откуда = '{from_where}', " +
                        $"Куда = '{to_where}', " +
                        $"Отправление = '{departure}', " +
                        $"Прибытие = '{arrival}', " +
                        $"Стоимость_проезда = {fare}, " +
                        $"Индекс_автобусного_парка = {ID_busfeet} " +
                        $"WHERE Индекс_рейса = {ID_busline}", 
                        connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            connection.Close();
        }

        public void Delete(int ID_busline) {
            connection.Open();
            try {
                command = new OleDbCommand($"DELETE FROM Рейс WHERE Индекс_рейса = {ID_busline}", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
        }
    }
}
