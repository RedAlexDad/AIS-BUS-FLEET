using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Автобус
namespace bus_coursework.MyClass {
    class Bus {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Bus(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        // Обновление рейса по ID автобусного парка
        public DataTable UpdateBusCheckByIDBusline(int ID) {
            connection.Open();
            try {
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Индекс_автобуса, " +
                        $"Марка_автобуса, " +
                        $"Модель_автобуса, " +
                        $"Год_выпуска_автобуса, " +
                        $"Номер_рейса, " +
                        $"Название_автобусного_парка, " +
                        $"ФИО_водителя, " +
                        $"ФИО_контролера " +
                    $"FROM " +
                        $"Автобус, " +
                        $"Рейс, " +
                        $"Автобусный_парк, " +
                        $"Водитель, " +
                        $"Контролер " +
                    $"WHERE Автобус.Индекс_рейса = {ID} " +
                    $"AND Рейс.Индекс_рейса = {ID} " +
                    $"AND Автобус.Индекс_автобусного_парка = Автобусный_парк.Индекс_автобусного_парка " +
                    $"AND Автобус.Индекс_водителя = Водитель.Индекс_водителя " +
                    $"AND Автобус.Индекс_контролера = Контролер.Индекс_контролера " +
                    $"ORDER BY Автобус.Индекс_автобуса ",
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

        // БД для отчета
        public DataTable UpdateBus() {
            connection.Open();
            try {
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Автобус.Индекс_автобуса, " +
                        $"Автобус.Марка_автобуса, " +
                        $"Автобус.Модель_автобуса, " +
                        $"Автобус.Год_выпуска_автобуса, " +
                        $"Рейс.Номер_рейса, " +
                        $"Автобусный_парк.Название_автобусного_парка, " +
                        $"Водитель.ФИО_водителя, " +
                        $"Контролер.ФИО_контролера " +
                    $"FROM " +
                        $"Автобус, " +
                        $"Рейс, " +
                        $"Автобусный_парк, " +
                        $"Водитель, " +
                        $"Контролер " +
                    $"WHERE Автобус.Индекс_рейса = Рейс.Индекс_рейса " +
                    $"AND Автобус.Индекс_автобусного_парка = Автобусный_парк.Индекс_автобусного_парка " +
                    $"AND Автобус.Индекс_водителя = Водитель.Индекс_водителя " +
                    $"AND Автобус.Индекс_контролера = Контролер.Индекс_контролера " +
                    $"ORDER BY Автобус.Индекс_автобуса ",
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

        // БД для отчета
        public DataTable UpdateBusWithStatus() {
            connection.Open();
            try {
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Автобус.Индекс_автобуса, " +
                        $"Автобус.Марка_автобуса, " +
                        $"Автобус.Модель_автобуса, " +
                        $"Автобус.Год_выпуска_автобуса, " +
                        $"Рейс.Номер_рейса, " +
                        $"Автобусный_парк.Название_автобусного_парка, " +
                        $"Водитель.ФИО_водителя, " +
                        $"Контролер.ФИО_контролера, " +
                        $"Автобус_Переключатель.Статус " +
                    $"FROM " +
                        $"Автобус, " +
                        $"Рейс, " +
                        $"Автобусный_парк, " +
                        $"Водитель, " +
                        $"Контролер, " +
                        $"Автобус_Переключатель " +
                    $"WHERE Автобус.Индекс_рейса = Рейс.Индекс_рейса " +
                    $"AND Автобус.Индекс_автобусного_парка = Автобусный_парк.Индекс_автобусного_парка " +
                    $"AND Автобус.Индекс_водителя = Водитель.Индекс_водителя " +
                    $"AND Автобус.Индекс_контролера = Контролер.Индекс_контролера " +
                    $"AND Автобус.Статус_автобуса = Автобус_Переключатель.ID_статус " +
                    $"ORDER BY Автобус.Индекс_автобуса ",
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


        public void Add(int ID_bus, string Marka, string Model, string Year_relis, int ID_busline, int ID_busfleet, int ID_driver, int ID_controller, string status) {
            connection.Open();
            try {
                command = new OleDbCommand($"INSERT INTO Автобус (" +
                                        $"Индекс_автобуса, " +
                                        $"Марка_автобуса, " +
                                        $"Модель_автобуса, " +
                                        $"Год_выпуска_автобуса, " +
                                        $"Индекс_рейса, " +
                                        $"Индекс_автобусного_парка, " +
                                        $"Индекс_водителя, " +
                                        $"Индекс_контролера, " +
                                        $"Статус_автобуса) " +
                                    $"VALUES(" +
                                        $"{ID_bus}, " +
                                        $"'{Marka}', " +
                                        $"'{Model}', " +
                                        $"{Year_relis}, " +
                                        $"{ID_busline}, " +
                                        $"{ID_busfleet}, " +
                                        $"{ID_driver}, " +
                                        $"{ID_controller}, " +
                                        $"{status})",
                                        connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
        }

        public void Update(int ID_bus, string Marka, string Model, string Year_relis, int ID_busline, int ID_busfleet, int ID_driver, int ID_controller, string status) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Автобус " +
                                    $"SET Марка_автобуса = '{Marka}', " +
                                        $"Модель_автобуса = '{Model}', " +
                                        $"Год_выпуска_автобуса = '{Year_relis}', " +
                                        $"Индекс_рейса = {ID_busline}, " +
                                        $"Индекс_автобусного_парка = {ID_busfleet}, " +
                                        $"Индекс_водителя = {ID_driver}, " +
                                        $"Индекс_контролера = {ID_controller}, " +
                                        $"Статус_автобуса = {status} " +
                                        $"WHERE Индекс_автобуса = {ID_bus}",
                                        connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
        }

        public void Delete(int ID_bus) {
            connection.Open();
            try {
                command = new OleDbCommand($"DELETE FROM Автобус WHERE Индекс_автобуса = {ID_bus}", connection);
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
