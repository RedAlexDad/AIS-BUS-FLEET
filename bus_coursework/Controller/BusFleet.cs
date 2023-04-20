using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Автобусный парк
namespace bus_coursework.Controller {
    class BusFleet {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public BusFleet(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        // UPD 20.04.2023, 20:14; - Отменено в связи отсутствии необходимости
        // Обновление по ID за счет кнопок - следующий или предыдущий
        //public DataTable get_id_for_button(int ID) {
        //    connection.Open();
        //    dataAdapter = new OleDbDataAdapter($"SELECT Индекс_автобусного_парка FROM Автобусный парк WHERE Индекс_автобусного_парка = {ID}", connection);
        //    bufferTable.Clear();
        //    dataAdapter.Fill(bufferTable);
        //    connection.Close();
        //    return bufferTable;
        //}

        public DataTable get_fio_director_by_id(int ID) {
            connection.Open();
            //dataAdapter = new OleDbDataAdapter($"SELECT * FROM Рейс WHERE Индекс_автобусного_парка = {ID}", connection);
            dataAdapter = new OleDbDataAdapter($"SELECT * FROM Автобусный парк WHERE Индекс_руководителя = {ID}", connection);
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

        public void Add(string FIO, string phone) {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Руководитель (ФИО_руководителя, Номер_телефона_руководителя) VALUES(@FIO, @phone)", connection);
            command.Parameters.AddWithValue("ФИО_руководителя", FIO);
            command.Parameters.AddWithValue("Номер_телефона_руководителя", phone);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void Delete(int ID) {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Руководитель WHERE Индекс_руководителя = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        internal void Add(string text1, string text2, int v) {
            throw new NotImplementedException();
        }
    }
}
