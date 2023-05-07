using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Автобусный парк
namespace bus_coursework.MyClass {
    class BusFleet {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public BusFleet(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        // ID, название, адрес, ID руководителя
        public void Add(int ID_busfleet, string name, string address, int ID_director) {
            connection.Open();
            try {
                command = new OleDbCommand($"INSERT INTO Автобусный_парк (" +
                    $"Индекс_автобусного_парка, " +
                    $"Название_автобусного_парка, " +
                    $"Адрес_автобусного_парка, " +
                    $"Индекс_руководителя) " +
                    $"VALUES(" +
                    $"{ID_busfleet}, " +
                    $"'{name}', " +
                    $"'{address}', " +
                    $"{ID_director})", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            connection.Close();
        }

        public void Update(int ID_busfleet, string name, string address, int ID_director) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Автобусный_парк " +
                    $"SET Название_автобусного_парка = '{name}', " +
                        $"Адрес_автобусного_парка = '{address}', " +
                        $"Индекс_руководителя = {ID_director} " +
                        $"WHERE Индекс_автобусного_парка = {ID_busfleet}",
                        connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            connection.Close();
        }

        public void Delete(int ID_busfleet) {
            connection.Open();
            try {
                command = new OleDbCommand($"DELETE FROM Автобусный_парк WHERE Индекс_автобусного_парка = {ID_busfleet}", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
        }

        // БД для отчета
        public DataTable UpdateBusFleet() {
            connection.Open();
            try {
                //dataAdapter = new OleDbDataAdapter($"SELECT * FROM Автобус WHERE Индекс_рейса = {ID}", connection);
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Индекс_автобусного_парка, " +
                        $"Название_автобусного_парка, " +
                        $"Адрес_автобусного_парка, " +
                        $"Руководитель.ФИО_руководителя " +
                    $"FROM " +
                        $"Автобусный_парк, " +
                        $"Руководитель " +
                    $"WHERE Автобусный_парк.Индекс_руководителя = Руководитель.Индекс_руководителя",
                    connection);

                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
            return bufferTable;
        }


    }
}
