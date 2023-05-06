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
    class Passenger {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Passenger(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        // Обновление рейса по ID автобусного парка
        public DataTable UpdatePassageCheck(int ID) {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Пассажир WHERE Индекс_автобуса = {ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public DataTable get_fio_director_by_id(int ID) {
            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Руководитель WHERE Индекс_руководителя = {ID}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(int ID_passanger, int ID_bus, string FIO, string category) {
            connection.Open();
            try {
                //Console.WriteLine(ID_passanger + " " + ID_bus + " " + FIO + " " + category);
                command = new OleDbCommand($"INSERT INTO Пассажир (Индекс_пассажира, Индекс_автобуса, ФИО_пассажира, Категория_пассажира) VALUES({ID_passanger}, {ID_bus}, {FIO}, {category})", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Update(int ID_passanger, int ID_bus, string FIO, string category) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Пассажир " +
                    $"SET Индекс_автобуса = {ID_bus}, " +
                    $"ФИО_пассажира = '{FIO}', " +
                    $"Категория_пассажира = '{category}' " +
                    $"WHERE Индекс_пассажира = {ID_passanger}", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Delete(int ID_passanger) {
        Console.WriteLine("DELETE ID PASSAGENER: " + ID_passanger);
        try {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Пассажир WHERE Индекс_пассажира = {ID_passanger}", connection);

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
