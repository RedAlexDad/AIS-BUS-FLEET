﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Пассажиры
namespace bus_coursework.MyClass {
    class Controller {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Controller(string Conn) {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public void Add(int ID_controller, string FIO, string phone) {
            connection.Open();
            try {
                Console.WriteLine(ID_controller + " " + FIO + " " + phone);

                command = new OleDbCommand($"INSERT INTO " +
                    $"Контролер (Индекс_контролера, ФИО_контролера, Номер_телефона_контролера) " +
                    $"VALUES({ID_controller}, '{FIO}', '{phone}')", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные добавлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: " + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Update(int ID_controller, string FIO, string phone) {
            connection.Open();
            try {
                command = new OleDbCommand($"UPDATE Контролер " +
                    $"SET ФИО_контролера = '{FIO}', " +
                    $"Номер_телефона_контролера = '{phone}' " +
                    $"WHERE Индекс_контролера = {ID_controller}", connection);

                // Проверка на правильность запрсоа
                command.ExecuteNonQuery();

                MessageBox.Show("Данные обновлены", "Успешно");
            } catch(Exception error) {
                MessageBox.Show("Ошибка выполнения запроса!\nТип ошибки: \n" + error, "Ошибка!");
            };

            // Закрываем соединение с БД
            connection.Close();
        }

        public void Delete(int ID_controller) {
        connection.Open();
        try {
            command = new OleDbCommand($"DELETE FROM Контролер WHERE Индекс_контролера = {ID_controller}", connection);

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
