using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Пассажиры
namespace bus_coursework.MyClass {
    class Driver {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Driver(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public void Add(int ID_driver, string FIO, string phone, int experience) {
            connection.Open();
            try {
                //Console.WriteLine(ID_passanger + " " + ID_bus + " " + FIO + " " + category);
                command = new OleDbCommand($"INSERT INTO Водитель (Индекс_водителя, ФИО_водителя, Номер_телефона_водителя, Стаж_водителя) VALUES({ID_driver}, {FIO}, {phone}, {experience})", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Update(int ID_driver, string FIO, string phone, int experience) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Водитель " +
                    $"SET ФИО_водителя = '{FIO}', " +
                    $"Номер_телефона_водителя = '{phone}', " +
                    $"Стаж_водителя = {experience} " +
                    $"WHERE Индекс_водителя = {ID_driver}", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Delete(int ID_driver) {
        //Console.WriteLine("DELETE ID ID_driver: " + ID_driver);
        try {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Водитель WHERE Индекс_водителя = {ID_driver}", connection);

            // Проверка на правильность запрсоа
            command.ExecuteNonQuery();

            MessageBox.Show("Данные удалены", "Успешно");
        } catch(Exception error) {
            MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
        }
        // Закрываем соединение с БД
        connection.Close();
        }

    }
}
