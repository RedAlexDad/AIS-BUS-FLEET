using bus_coursework.MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_coursework {
    public partial class Report_admin : Form {

        MyClass.Busline busline;
        MyClass.BusFleet busfleet;
        MyClass.Director director;
        MyClass.Bus bus;
        MyClass.Passenger passenger;
        MyClass.Controller controller;
        MyClass.Driver driver;
        MyClass.Other other;

        public Report_admin() {
            InitializeComponent();
            busline = new Busline(ConnectionString.ConnStr);
            busfleet = new BusFleet(ConnectionString.ConnStr);
            director = new Director(ConnectionString.ConnStr);
            bus = new Bus(ConnectionString.ConnStr);
            passenger = new Passenger(ConnectionString.ConnStr);
            controller = new Controller(ConnectionString.ConnStr);
            driver = new Driver(ConnectionString.ConnStr);
            other = new Other(ConnectionString.ConnStr);
        }

        private void автобусBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.автобусBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus_dataset);

        }

        // Отображение БД автобуса
        private void DataBaseBusGirdView() {
            автобусDataGridView.Columns[0].HeaderText = "ID";
            автобусDataGridView.Columns[0].Width = 30;
            // Марка
            автобусDataGridView.Columns[1].HeaderText = "Марка";
            автобусDataGridView.Columns[1].Width = 70;
            // Модель
            автобусDataGridView.Columns[2].HeaderText = "Модель";
            автобусDataGridView.Columns[2].Width = 150;
            // Год выпуска
            автобусDataGridView.Columns[3].HeaderText = "Год выпуска";
            автобусDataGridView.Columns[3].Width = 50;
            // ID рейс
            автобусDataGridView.Columns[4].HeaderText = "ID рейс";
            автобусDataGridView.Columns[4].Width = 50;
            // Индекс автобусного парка, true - отображать, false - скрыть
            автобусDataGridView.Columns[5].HeaderText = "ID автобусный парк";
            автобусDataGridView.Columns[5].Width = 150;
            // ID водитель
            автобусDataGridView.Columns[6].HeaderText = "ID водитель";
            автобусDataGridView.Columns[6].Width = 200;
            // ID контролер
            автобусDataGridView.Columns[7].HeaderText = "ID контролер";
            автобусDataGridView.Columns[7].Width = 200;
        }

        // Отображение БД автобусного парка
        private void DataBaseBusFleetGirdView() {
            автобусный_паркDataGridView.Columns[0].HeaderText = "ID";
            автобусный_паркDataGridView.Columns[0].Width = 30;
            // Название
            автобусный_паркDataGridView.Columns[1].HeaderText = "Название";
            автобусный_паркDataGridView.Columns[1].Width = 200;
            // Адрес
            автобусный_паркDataGridView.Columns[2].HeaderText = "Адрес";
            автобусный_паркDataGridView.Columns[2].Width = 350;
            // ФИО руководителя
            автобусный_паркDataGridView.Columns[3].HeaderText = "ФИО руководителя";
            автобусный_паркDataGridView.Columns[3].Width = 250;
        }

        // Отображение БД рейс
        private void DataBaseBuslineGirdView() {
            рейсDataGridView.Columns[0].HeaderText = "ID";
            рейсDataGridView.Columns[0].Width = 30;
            // Номер рейса
            рейсDataGridView.Columns[1].HeaderText = "Номер";
            рейсDataGridView.Columns[1].Width = 50;
            // Откуда
            рейсDataGridView.Columns[2].HeaderText = "Откуда";
            рейсDataGridView.Columns[2].Width = 300;
            // Куда
            рейсDataGridView.Columns[3].HeaderText = "Куда";
            рейсDataGridView.Columns[3].Width = 300;
            // Отправление
            рейсDataGridView.Columns[4].HeaderText = "Отправление";
            рейсDataGridView.Columns[4].Width = 100;
            рейсDataGridView.Columns[4].DefaultCellStyle.Format = "HH:mm";
            // Прибытие
            рейсDataGridView.Columns[5].HeaderText = "Прибытие";
            рейсDataGridView.Columns[5].Width = 100;
            рейсDataGridView.Columns[5].DefaultCellStyle.Format = "HH:mm";
            // Стоимость проезда
            рейсDataGridView.Columns[6].HeaderText = "Стоимость проезда";
            рейсDataGridView.Columns[6].Width = 80;
            // Название автобусного парка
            рейсDataGridView.Columns[7].HeaderText = "Название автобусного парка";
            рейсDataGridView.Columns[7].Width = 250;
        }

        // Отображение БД Руководитель
        private void DataBaseDirectorGirdView() {
            руководительDataGridView.Columns[0].HeaderText = "ID";
            руководительDataGridView.Columns[0].Width = 30;
            // Номер рейса
            руководительDataGridView.Columns[1].HeaderText = "ФИО";
            руководительDataGridView.Columns[1].Width = 250;
            // Откуда
            руководительDataGridView.Columns[2].HeaderText = "Номер телефона";
            руководительDataGridView.Columns[2].Width = 100;
        }

        // Отображение БД Водитель
        private void DataBaseDriverGirdView() {
            водительDataGridView.Columns[0].HeaderText = "ID";
            водительDataGridView.Columns[0].Width = 30;
            // Номер рейса
            водительDataGridView.Columns[1].HeaderText = "ФИО";
            водительDataGridView.Columns[1].Width = 250;
            // Откуда
            водительDataGridView.Columns[2].HeaderText = "Номер телефона";
            водительDataGridView.Columns[2].Width = 100;
            // Стаж
            водительDataGridView.Columns[3].HeaderText = "Стаж";
            водительDataGridView.Columns[3].Width = 40;
        }

        // Отображение БД Контролер
        private void DataBaseControllerGirdView() {
            контролерDataGridView.Columns[0].HeaderText = "ID";
            контролерDataGridView.Columns[0].Width = 30;
            // ФИО
            контролерDataGridView.Columns[1].HeaderText = "ФИО";
            контролерDataGridView.Columns[1].Width = 250;
            // Номер телефона
            контролерDataGridView.Columns[2].HeaderText = "Номер телефона";
            контролерDataGridView.Columns[2].Width = 100;
        }

        // Отображение БД Пассажир
        private void DataBasePassengerGirdView() {
            пассажирDataGridView.Columns[0].HeaderText = "ID";
            пассажирDataGridView.Columns[0].Width = 30;
            // Номер рейса
            пассажирDataGridView.Columns[1].HeaderText = "Номер рейса";
            пассажирDataGridView.Columns[1].Width = 70;
            // ФИО
            пассажирDataGridView.Columns[2].HeaderText = "ФИО";
            пассажирDataGridView.Columns[2].Width = 250;
            // Категория
            пассажирDataGridView.Columns[3].HeaderText = "Категория";
            пассажирDataGridView.Columns[3].Width = 80;
        }

        private void Report_admin_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.bus_dataset.Пассажир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Контролер". При необходимости она может быть перемещена или удалена.
            this.контролерTableAdapter.Fill(this.bus_dataset.Контролер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.bus_dataset.Водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Руководитель". При необходимости она может быть перемещена или удалена.
            this.руководительTableAdapter.Fill(this.bus_dataset.Руководитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.bus_dataset.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобусный_парк". При необходимости она может быть перемещена или удалена.
            this.автобусный_паркTableAdapter.Fill(this.bus_dataset.Автобусный_парк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобус". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);

            // Развернуть на полный экран
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // АВТОБУС
            try {
                автобусDataGridView.DataSource = bus.UpdateBus();
                DataBaseBusGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД автобуса!\nТип ошибки:\n\n" + error, "Ошибка!");
            }

            // АВТОБУСНЫЙ ПАРК
            try {
                автобусный_паркDataGridView.DataSource = busfleet.UpdateBusFleet();
                DataBaseBusFleetGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД автобусного парка!\nТип ошибки:\n\n" + error, "Ошибка!");
            }

            // РЕЙС
            try {
                рейсDataGridView.DataSource = busline.UpdateBusline();
                DataBaseBuslineGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД РЕЙС!\nТип ошибки:\n\n" + error, "Ошибка!");
            }

            // РУКОВОДИТЕЛЬ
            DataBaseDirectorGirdView();

            // ВОДИТЕЛЬ
            DataBaseDriverGirdView();

            // КОНТРОЛЕР
            DataBaseControllerGirdView();

            // ПАССАЖИР
            try {
                пассажирDataGridView.DataSource = passenger.UpdatePassenger();
                DataBasePassengerGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД РЕЙС!\nТип ошибки:\n\n" + error, "Ошибка!");
            }

            // Подсчет сумма проданных билетов
            try {
                dataGridView1.DataSource = other.UpdateCountINFO();

                dataGridView1.Columns[0].HeaderText = "Номер рейса";
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].HeaderText = "Кол-во пассажиров";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].HeaderText = "Общая прибыль за рейс";
                dataGridView1.Columns[2].Width = 100;

            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД Подсчет сумма проданных билетов!\nТип ошибки:\n\n" + error, "Ошибка!");
            }

            // БД для отчета - прибыль каждой модели автобуса
            // UPD: 18:00, 09.05.2023г.
            // Отменено в связи отсутствия поддержки оконной функции в ACCESS
            #region
            // Подсчет прибылей каждой модели автобуса
            //try {
            //    dataGridView2.DataSource = other.ProfitOfEachBusModel();

            //    //dataGridView1.Columns[0].HeaderText = "Номер рейса";
            //    //dataGridView1.Columns[0].Width = 80;
            //    //dataGridView1.Columns[1].HeaderText = "Кол-во пассажиров";
            //    //dataGridView1.Columns[1].Width = 80;
            //    //dataGridView1.Columns[2].HeaderText = "Общая прибыль за рейс";
            //    //dataGridView1.Columns[2].Width = 100;

            //} catch(Exception error) {
            //    MessageBox.Show("Ошибка обновления БД РЕЙС!\nТип ошибки:\n\n" + error, "Ошибка!");
            //}
            #endregion
            
            // Состояние транспорта
            try {
                dataGridView3.DataSource = other.TransportStatus();

                dataGridView3.Columns[0].HeaderText = "Марка";
                dataGridView3.Columns[0].Width = 80;
                dataGridView3.Columns[1].HeaderText = "ФИО водителя";
                dataGridView3.Columns[1].Width = 230;
                dataGridView3.Columns[2].HeaderText = "ФИО контролера";
                dataGridView3.Columns[2].Width = 230;
                dataGridView3.Columns[3].HeaderText = "Модель";
                dataGridView3.Columns[3].Width = 100;
                dataGridView3.Columns[4].HeaderText = "Год выпуска";
                dataGridView3.Columns[4].Width = 80;
                dataGridView3.Columns[5].HeaderText = "Номер рейса";
                dataGridView3.Columns[5].Width = 50;
                dataGridView3.Columns[6].HeaderText = "Название автобусного парка";
                dataGridView3.Columns[6].Width = 250;
                dataGridView3.Columns[7].HeaderText = "Состояние транспорта";
                dataGridView3.Columns[7].Width = 250;
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД Состояние транспорта!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        // Кнопка возрата к меню
        private void toolStripButton32_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Administrator();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
