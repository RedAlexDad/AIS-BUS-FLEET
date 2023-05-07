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
    class Other {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Other(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        // БД для отчета - подсчет сумма проданных билетов
        public DataTable UpdateCountINFO() {
            connection.Open();
            try {
                //dataAdapter = new OleDbDataAdapter($"SELECT * FROM Автобус WHERE Индекс_рейса = {ID}", connection);
                dataAdapter = new OleDbDataAdapter(
                    $"SELECT " +
                        $"Рейс.Номер_рейса, " +
                        $"Count(Пассажир.Индекс_пассажира), " +
                        $"Sum(Рейс.Стоимость_проезда) " +
                    $"FROM Рейс " +
                        $"INNER JOIN (Автобус INNER JOIN Пассажир ON Автобус.[Индекс_автобуса] = Пассажир.Индекс_автобуса) " +
                        $"ON Рейс.Индекс_рейса = Автобус.Индекс_рейса " +
                    $"GROUP BY Рейс.Номер_рейса",
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
