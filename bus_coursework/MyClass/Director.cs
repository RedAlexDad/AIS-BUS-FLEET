using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Руководитель
namespace bus_coursework.MyClass {
    class Director {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable, bufferTableDirector;

        public Director(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
            bufferTableDirector = new DataTable();
        }

        public string GetFIODirectorByID(int ID) {
            connection.Open();
            command = new OleDbCommand($"SELECT ФИО_руководителя FROM Руководитель WHERE Индекс_руководителя = {ID}", connection);

            OleDbDataReader reader = command.ExecuteReader();

            if(reader.Read()) {
                string name = reader.GetString(0);
                //Console.WriteLine("Name: " + name);
                connection.Close();
                return name;
            } else {
                //Console.WriteLine($"Запись с ID = {ID} не найдена.");
                connection.Close();
                return null;
            }
        }

        public DataTable GetFIODirector() {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT Индекс_руководителя, ФИО_руководителя FROM Руководитель", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
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

        // Руководитель
        public DataTable UpdateArmChair() {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Руководитель", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(int ID_director, string FIO, string phone) {
            connection.Open();
            try {
                command = new OleDbCommand($"INSERT INTO Руководитель (Индекс_руководителя, ФИО_руководителя, Номер_телефона_руководителя) VALUES({ID_director}, '{FIO}', '{phone}')", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Update(int ID_director, string FIO, string phone) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Руководитель " +
                    $"SET ФИО_руководителя = '{FIO}', " +
                    $"Номер_телефона_руководителя = '{phone}' " +
                    $"WHERE Индекс_руководителя = {ID_director}", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Delete(int ID) {
            connection.Open();
            try {
                command = new OleDbCommand($"DELETE FROM Руководитель WHERE Индекс_руководителя = {ID}", connection);
                // Проверка на правильность запрсоа
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
