using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus_coursework.Controller
{
    class Query
    {
        OleDbConnection     connection;
        OleDbCommand        command;
        OleDbDataAdapter    dataAdapter;
        DataTable           bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateLineBus()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Руководитель", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(string FIO, string phone)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Руководитель (ФИО_руководителя, Номер_телефона_руководителя) VALUES(@FIO, @phone)", connection);
            command.Parameters.AddWithValue("ФИО_руководителя", FIO);
            command.Parameters.AddWithValue("Номер_телефона_руководителя", phone);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Руководитель WHERE Индекс_руководителя = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        internal void Add(string text1, string text2, int v)
        {
            throw new NotImplementedException();
        }
    }
}
