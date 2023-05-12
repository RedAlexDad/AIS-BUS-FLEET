using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;


// Рейс
namespace bus_coursework.MyClass {
    class Other {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable0, bufferTable1, bufferTableSearchBusByMarka, bufferCheckLoginAndPassword;

        public Other(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable0 = new DataTable();
            bufferTable1 = new DataTable();
            bufferTableSearchBusByMarka = new DataTable();
        }

        // БД для отчета - подсчет сумма проданных билетов
        public DataTable UpdateCountINFO() {
            connection.Open();
            try {
                //dataAdapter = new OleDbDataAdapter($"SELECT * FROM Автобус WHERE Индекс_рейса = {ID}", connection);
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Рейс.Номер_рейса, " +
                        $"COUNT(Пассажир.Индекс_пассажира), " +
                        $"SUM(Рейс.Стоимость_проезда) " +
                    $"FROM Рейс " +
                        $"INNER JOIN (Автобус INNER JOIN Пассажир ON Автобус.[Индекс_автобуса] = Пассажир.Индекс_автобуса) " +
                        $"ON Рейс.Индекс_рейса = Автобус.Индекс_рейса " +
                    $"GROUP BY Рейс.Номер_рейса",
                    connection);

                bufferTable0.Clear();
                dataAdapter.Fill(bufferTable0);
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
            return bufferTable0;
        }

        // БД для отчета - прибыль каждой модели автобуса
        // UPD: 18:00, 09.05.2023г.
        // Отменено в связи отсутствия поддержки оконной функции в ACCESS
        #region
        //public DataTable ProfitOfEachBusModel() {
        //    connection.Open();
        //    try {
        //        //dataAdapter = new OleDbDataAdapter($"SELECT * FROM Автобус WHERE Индекс_рейса = {ID}", connection);
        //        dataAdapter = new OleDbDataAdapter(
        //            $"SELECT " +
        //                $"Автобус.Марка_автобуса, " +
        //                $"Автобус.Модель_автобуса, " +
        //                $"Автобус.Год_выпуска_автобуса, " +
        //                $"Автобусный_парк.Название_автобусного_парка, " +
        //                $"Рейс.Номер_рейса, " +
        //                $"SUM(Рейс.Стоимость_проезда) OVER (PARTITION BY Рейс.Стоимость_проезда) AS SUM_BUSLINE, " +
        //                $"Водитель.ФИО_водителя, " +
        //                $"Контролер.ФИО_контролера " +
        //                //$"COUNT(Автобус.Индекс_пассажира) OVER (PARTITION BY Автобус.Индекс_пассажира) AS COUNT_PASSENGER " +
        //            $"FROM Автобус, Рейс, Водитель, Контролер, Автобусный_парк " +
        //                $"WHERE Автобус.Индекс_рейса = Рейс.Индекс_рейса " +
        //                $"AND Автобус.Индекс_водителя = Водитель.Индекс_водителя " +
        //                $"AND Автобус.Индекс_контролера = Контролер.Индекс_контролера " +
        //                $"AND Автобус.Индекс_автобусного_парка = Автобусный_парк.Индекс_автобусного_парка " +
        //                $"AND Рейс.Индекс_автобусного_парка = Автобусный_парк.Индекс_автобусного_парка ",
        //            //$"GROUP BY Автобус.Марка_автобуса, Автобус.Модель_автобуса",
        //            connection);

        //        bufferTable.Clear();
        //        dataAdapter.Fill(bufferTable);
        //    } catch(Exception error) {
        //        MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
        //    };
        //    // Закрываем соединение с БД
        //    connection.Close();
        //    return bufferTable;
        //}
        #endregion

        // Обновление рейса по ID автобусного парка
        public DataTable TransportStatus() {
            connection.Open();
            try {
                //dataAdapter = new OleDbDataAdapter($"SELECT * FROM Автобус WHERE Индекс_рейса = {ID}", connection);
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Марка_автобуса, " +
                        $"ФИО_водителя, " +
                        $"ФИО_контролера, " +
                        $"Модель_автобуса, " +
                        $"Год_выпуска_автобуса, " +
                        $"Номер_рейса, " +
                        $"Название_автобусного_парка, " +
                        $"IIf(Год_выпуска_автобуса<=(Format(Date(), 'yyyy') - 5)," +
                        $"'Из срока эксплутации (нестабильное) ','В сроке эксплутации (стабильное)') " +
                    $"FROM " +
                        $"Автобус, " +
                        $"Рейс, " +
                        $"Автобусный_парк, " +
                        $"Водитель, " +
                        $"Контролер " +
                    $"WHERE Автобус.Индекс_рейса = Рейс.Индекс_рейса " +
                    $"AND Автобус.Индекс_автобусного_парка = Автобусный_парк.Индекс_автобусного_парка " +
                    $"AND Автобус.Индекс_водителя = Водитель.Индекс_водителя " +
                    $"AND Автобус.Индекс_контролера = Контролер.Индекс_контролера",
                    connection);

                bufferTable1.Clear();
                dataAdapter.Fill(bufferTable1);
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };
            // Закрываем соединение с БД
            connection.Close();
            return bufferTable1;
        }

        // Таблица автобус со статусом
        public void UpdateStatusBus(int ID_bus, int ID_status) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Автобус " +
                    $"SET Статус_автобуса = {ID_status} " +
                    $"WHERE Индекс_автобуса = {ID_bus}",
                    connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        // Поиск автобус по названию марок
        public DataTable SearchBusByNameMarka(string NameMarka) {
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
                        $"ФИО_контролера, " +
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
                    $"AND Автобус.Марка_автобуса LIKE ('%{NameMarka}%') ",
                    connection);

                bufferTableSearchBusByMarka.Clear();
                dataAdapter.Fill(bufferTableSearchBusByMarka);

            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
            return bufferTableSearchBusByMarka;
        }

        // Проверка логина и пароля
        public bool CheckLoginAndPassword(string login, string password) {
            connection.Open();
            try {
                command = new OleDbCommand(
                    $"SELECT " +
                        $"* " +
                    $"FROM " +
                        $"DB_Users " +
                    $"WHERE TypeGroupUser LIKE ('{login}') " +
                    $"AND Pass LIKE ('{password}') ",
                    connection);
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;

            while(reader.Read()) { count++; }

            // Закрываем соединение с БД
            connection.Close();

            //Console.WriteLine($"count: {count}");

            if(count > 1) { MessageBox.Show("Дублирующие логин и пароль", "Примечание!"); return false; }
            if(count == 1) { /*MessageBox.Show("Логин и пароль верные", "Успешно!"); */return true; }
            if(count < 1) { MessageBox.Show("Логин и пароль неверные", "Ошибка!"); return false; }

            return false;
        }
    }
}
