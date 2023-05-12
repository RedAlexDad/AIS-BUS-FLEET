using bus_coursework.MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bus_coursework {
    public partial class Search_bus : Form {

        MyClass.Other other;
        MyClass.Bus bus;
        public Search_bus() {
            InitializeComponent();

            other = new Other(ConnectionString.ConnStr);
            bus = new Bus(ConnectionString.ConnStr);
        }

        // Отображение БД автобуса
        private void DataBaseBusGirdView() {
            // Автобус
            // Название столбца и ширина столбца
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[0].Width = 30;
            // Марка
            dataGridView.Columns[1].HeaderText = "Марка";
            dataGridView.Columns[1].Width = 70;
            // Модель
            dataGridView.Columns[2].HeaderText = "Модель";
            dataGridView.Columns[2].Width = 150;
            // Год выпуска
            dataGridView.Columns[3].HeaderText = "Год выпуска";
            dataGridView.Columns[3].Width = 50;
            // ID рейс
            dataGridView.Columns[4].HeaderText = "Номер рейса";
            dataGridView.Columns[4].Width = 50;
            // Индекс автобусного парка
            dataGridView.Columns[5].HeaderText = "Название автобусного парка";
            dataGridView.Columns[5].Width = 150;
            // ID водитель
            dataGridView.Columns[6].HeaderText = "ФИО водителя";
            dataGridView.Columns[6].Width = 200;
            // ID контролер
            dataGridView.Columns[7].HeaderText = "ФИО контролера";
            dataGridView.Columns[7].Width = 200;
            // Cтатус автобуса
            dataGridView.Columns[8].HeaderText = "Статус";
            dataGridView.Columns[8].Width = 200;
        }

        private void Search_bus_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);

            // АВТОБУС
            try {
                dataGridView.DataSource = bus.UpdateBusWithStatus();
                DataBaseBusGirdView();

            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД поиска автобуса!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        private void марка_автобусаTextBox_TextChanged(object sender, EventArgs e) {
            try {
                dataGridView.DataSource = other.SearchBusByNameMarka(марка_автобусаTextBox.Text);

            // Обновление БД
            DataBaseBusGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД поиска автобуса!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        private void UpdateInfoTextBox(int index) {
            //Console.WriteLine(index.ToString());
            try {
                // Выделяет строку
                DataGridViewRow row = dataGridView.Rows[index];

                индекс_автобусаTextBox.Text = row.Cells[0].Value.ToString();
                модель_автобусаTextBox.Text = row.Cells[2].Value.ToString();
                год_выпуска_автобусаTextBox.Text = row.Cells[3].Value.ToString();
                индекс_рейсаTextBox.Text = row.Cells[4].Value.ToString();
                индекс_автобусного_паркаTextBox.Text = row.Cells[5].Value.ToString();
                индекс_водителяTextBox.Text = row.Cells[6].Value.ToString();
                индекс_контролераTextBox.Text = row.Cells[7].Value.ToString();
                статус_автобусаTextBox.Text = row.Cells[8].Value.ToString();
            } catch { MessageBox.Show("Ошибка заполнения таблицы и поиска автобуса", "Ошибка!"); }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            //Console.WriteLine(e.RowIndex.ToString());
            try {
                UpdateInfoTextBox(e.RowIndex);
            } catch { MessageBox.Show("Ошибка заполнения таблицы и поиска автобуса", "Ошибка!"); }
        }
    }
}
