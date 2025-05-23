﻿using bus_coursework.MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bus_coursework {
    public partial class Edit_DB : Form {

        MyClass.Busline busline;
        MyClass.BusFleet busfleet;
        MyClass.Director director;
        MyClass.Bus bus;
        MyClass.Passenger passenger;
        MyClass.Controller controller;
        MyClass.Driver driver;

        // Для отображения правильности запроса и другие функции
        public static class id_class {
            // По умолчанию будет присвоить значение 1
            public static int id_passenger { get; set; } = 1;
            public static int id_controller { get; set; } = 1;
            public static int id_driver { get; set; } = 1;
            public static int id_director { get; set; } = 1;
            public static int id_bus { get; set; } = 1;
            public static int id_busline { get; set; } = 1;
            public static int id_busfleet { get; set; } = 1;

            // Регулярные выражение, преобразующие любые символы в числовом виде в строковом типе
            public static string RegularExpressionText(string str) {
                try {
                    return Regex.Replace(str, "[^0-9]", String.Empty);
                } catch { return null; }
            }

            // Регулярные выражение, преобразующие любые символы в числовом виде в численном типе
            public static int RegularExpressionTextIntoValue(string str) {
                try {
                    return int.Parse(Regex.Replace(str, "[^0-9]", String.Empty));
                } catch { return 0; }
            }
        }

        public Edit_DB() {
            InitializeComponent();
            busline = new Busline(ConnectionString.ConnStr);
            busfleet = new BusFleet(ConnectionString.ConnStr);
            director = new Director(ConnectionString.ConnStr);
            bus = new Bus(ConnectionString.ConnStr);
            passenger = new Passenger(ConnectionString.ConnStr);
            controller = new Controller(ConnectionString.ConnStr);
            driver = new Driver(ConnectionString.ConnStr);
        }

        // Отображение всех БД - DataGridView
        #region
        // Отображение БД автобуса
        private void DatdBaseBusGirdView() {
            // Автобус
            // Название столбца и ширина столбца
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

        // Отображение БД рейса
        private void DatdBaseBusLineGirdView() {
            // Рейс
            //Название столбца и ширина столбца
            рейсDataGridView.Columns[0].HeaderText = "ID";
            рейсDataGridView.Columns[0].Width = 30;
            // Номер рейса
            рейсDataGridView.Columns[1].Width = 50;
            // Откуда
            рейсDataGridView.Columns[2].Width = 200;
            // Куда
            рейсDataGridView.Columns[3].Width = 200;
            // Отправление, DefaultCellStyle.Format = "HH:mm" - преобразование формат ячеек на "HH:mm"
            рейсDataGridView.Columns[4].DefaultCellStyle.Format = "HH:mm";
            рейсDataGridView.Columns[4].Width = 80;
            // Прибытие
            рейсDataGridView.Columns[5].DefaultCellStyle.Format = "HH:mm";
            рейсDataGridView.Columns[5].Width = 80;
            // Стоимость проезда
            рейсDataGridView.Columns[6].HeaderText = "Стоимость";
            рейсDataGridView.Columns[6].Width = 80;
            // Индекс автобусного парка, true - отображать, false - скрыть
            рейсDataGridView.Columns[7].Visible = false;
        }

        // Отображение БД пассажира
        private void DataBasePassengerGirdView() {
            // Пассажир
            // Индекс пассажира
            пассажирDataGridView.Columns[0].HeaderText = "ID";
            пассажирDataGridView.Columns[0].Width = 30;
            // Индекс Автобус
            пассажирDataGridView.Columns[1].Visible = false;
            пассажирDataGridView.Columns[1].HeaderText = "ID Автобус";
            пассажирDataGridView.Columns[1].Width = 30;
            // ФИО пассажира
            пассажирDataGridView.Columns[2].HeaderText = "ФИО";
            пассажирDataGridView.Columns[2].Width = 200;
            // Категория пассажира (полный, неполный)
            пассажирDataGridView.Columns[3].HeaderText = "Категория";
            пассажирDataGridView.Columns[3].Width = 80;
        }
        #endregion


        private void автобусный_паркBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.автобусный_паркBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus_dataset);
        }

        // Загрузочная форма при запуска
        private void Edit_DB_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.bus_dataset.Пассажир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.bus_dataset.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Контролер". При необходимости она может быть перемещена или удалена.
            this.контролерTableAdapter.Fill(this.bus_dataset.Контролер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.bus_dataset.Водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Руководитель". При необходимости она может быть перемещена или удалена.
            this.руководительTableAdapter.Fill(this.bus_dataset.Руководитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобусный_парк". При необходимости она может быть перемещена или удалена.
            this.автобусный_паркTableAdapter.Fill(this.bus_dataset.Автобусный_парк);

            // Развернуть на полный экран
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


        }


        // Обновление БД при нажатии назад и вперед во вкладке АВТОБУСНЫЙ ПАРК
        #region
        // Кнопка добавление
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            индекс_автобусного_паркаTextBox.Text = (id_class.RegularExpressionTextIntoValue(bindingNavigatorCountItem.Text)).ToString();
        }
        // Кнопка удаление
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            busfleet.Delete(id_class.id_busfleet);
        }
        // Кнопка сохранение
        private void сохранитьToolStripButton_Click(object sender, EventArgs e) {
            try {
                busfleet.Add(int.Parse(индекс_автобусного_паркаTextBox.Text), название_автобусного_паркаTextBox.Text, адрес_автобусного_паркаTextBox.Text, int.Parse(индекс_руководителяTextBox.Text));
            } catch(Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        // Кнопка обновление
        private void toolStripButton31_Click(object sender, EventArgs e) {
            try {
                busfleet.Update(int.Parse(индекс_автобусного_паркаTextBox.Text), название_автобусного_паркаTextBox.Text, адрес_автобусного_паркаTextBox.Text, int.Parse(индекс_руководителяTextBox.Text));
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        // Кнопка навигации
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e) {
            id_class.id_busfleet = int.Parse(индекс_автобусного_паркаTextBox.Text);

            рейсDataGridView.DataSource = busline.UpdateLineBusCheck(int.Parse(индекс_автобусного_паркаTextBox.Text));

            // Вызов функции для отображения БД рейса
            DatdBaseBusLineGirdView();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e) {
            id_class.id_busfleet = int.Parse(индекс_автобусного_паркаTextBox.Text);

            рейсDataGridView.DataSource = busline.UpdateLineBusCheck(int.Parse(индекс_автобусного_паркаTextBox.Text));

            // Вызов функции для отображения БД рейса
            DatdBaseBusLineGirdView();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e) {
            id_class.id_busfleet = int.Parse(индекс_автобусного_паркаTextBox.Text);

            рейсDataGridView.DataSource = busline.UpdateLineBusCheck(int.Parse(индекс_автобусного_паркаTextBox.Text));

            // Вызов функции для отображения БД рейса
            DatdBaseBusLineGirdView();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e) {
            id_class.id_busfleet = int.Parse(индекс_автобусного_паркаTextBox.Text);

            рейсDataGridView.DataSource = busline.UpdateLineBusCheck(int.Parse(индекс_автобусного_паркаTextBox.Text));

            // Вызов функции для отображения БД рейса
            DatdBaseBusLineGirdView();
        }
        #endregion

        // Возврат к меню
        private void toolStripButton32_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Administrator();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Обновление БД при нажатии назад и вперед во вкладке РЕЙС
        #region

        // Кнопка добавление
        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e) {
            индекс_рейсаTextBox.Text = (id_class.RegularExpressionTextIntoValue(bindingNavigatorCountItem1.Text)).ToString();
        }

        // Кнопка удаление
        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e) {
            passenger.Delete(id_class.id_busline);
        }
        // Кнопка сохранение
        private void toolStripButton1_Click(object sender, EventArgs e) {
            try {
                busline.Add(int.Parse(индекс_рейсаTextBox.Text), номер_рейсаTextBox.Text, откудаTextBox.Text, кудаTextBox.Text, отправлениеDateTimePicker.Text, прибытиеDateTimePicker.Text, double.Parse(стоимость_проездаTextBox.Text), int.Parse(индекс_автобусного_паркаTextBox1.Text));
            } catch(Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        // Кнопка обновление
        private void toolStripButton30_Click(object sender, EventArgs e) {
            try {
                busline.Update(int.Parse(индекс_рейсаTextBox.Text), номер_рейсаTextBox.Text, откудаTextBox.Text, кудаTextBox.Text, отправлениеDateTimePicker.Text, прибытиеDateTimePicker.Text, double.Parse(стоимость_проездаTextBox.Text), int.Parse(индекс_автобусного_паркаTextBox1.Text));
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
    

        private void bindingNavigatorMoveLastItem1_Click(object sender, EventArgs e) {
            id_class.id_busline = int.Parse(индекс_рейсаTextBox.Text);

            автобусDataGridView.DataSource = bus.UpdateBusCheckByIDBusline(int.Parse(индекс_рейсаTextBox.Text));

            // Вызов функции для отображения БД автобуса
            DatdBaseBusGirdView();
        }

        private void bindingNavigatorMoveNextItem1_Click(object sender, EventArgs e) {
            id_class.id_busline = int.Parse(индекс_рейсаTextBox.Text);

            автобусDataGridView.DataSource = bus.UpdateBusCheckByIDBusline(int.Parse(индекс_рейсаTextBox.Text));
            
            // Вызов функции для отображения БД автобуса
            DatdBaseBusGirdView();
        }

        private void bindingNavigatorMovePreviousItem1_Click(object sender, EventArgs e) {
            id_class.id_busline = int.Parse(индекс_рейсаTextBox.Text);

            автобусDataGridView.DataSource = bus.UpdateBusCheckByIDBusline(int.Parse(индекс_рейсаTextBox.Text));

            // Вызов функции для отображения БД автобуса
            DatdBaseBusGirdView();
        }

        private void bindingNavigatorMoveFirstItem1_Click(object sender, EventArgs e) {
            id_class.id_busline = int.Parse(индекс_рейсаTextBox.Text);

            автобусDataGridView.DataSource = bus.UpdateBusCheckByIDBusline(int.Parse(индекс_рейсаTextBox.Text));

            // Вызов функции для отображения БД автобуса
            DatdBaseBusGirdView();
        }
        #endregion


        // Вкладка АВТОБУС
        // Обновление БД при нажатии назад и вперед
        #region
        // Кнопка добавление
        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e) {
            индекс_автобусаTextBox.Text = (id_class.RegularExpressionTextIntoValue(bindingNavigatorCountItem2.Text)).ToString();
        }
        // Кнопка удаление
        private void bindingNavigatorDeleteItem2_Click(object sender, EventArgs e) {
            bus.Delete(id_class.id_bus);
        }
        // Кнопка сохранение
        private void toolStripButton2_Click(object sender, EventArgs e) {
            try {
                bus.Add(int.Parse(индекс_автобусаTextBox.Text), марка_автобусаTextBox.Text, модель_автобусаTextBox.Text, год_выпуска_автобусаTextBox.Text, int.Parse(индекс_рейсаTextBox1.Text), int.Parse(индекс_автобусного_паркаTextBox2.Text), int.Parse(индекс_водителяTextBox.Text), int.Parse(индекс_контролераTextBox.Text), статус_автобусаTextBox.Text);
            } catch (Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        // Кнопка обновление
        private void toolStripButton29_Click(object sender, EventArgs e) {
            try {
            bus.Update(int.Parse(индекс_автобусаTextBox.Text), марка_автобусаTextBox.Text, модель_автобусаTextBox.Text, год_выпуска_автобусаTextBox.Text, int.Parse(индекс_рейсаTextBox1.Text), int.Parse(индекс_автобусного_паркаTextBox2.Text), int.Parse(индекс_водителяTextBox.Text), int.Parse(индекс_контролераTextBox.Text), статус_автобусаTextBox.Text);
            } catch (Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        private void bindingNavigatorMoveFirstItem2_Click(object sender, EventArgs e) {
            id_class.id_bus = int.Parse(индекс_автобусаTextBox.Text);

            пассажирDataGridView.DataSource = passenger.UpdatePassageCheck(int.Parse(индекс_автобусаTextBox.Text));

            // Вызов функции для отображения БД пассажира
            DataBasePassengerGirdView();
        }

        private void bindingNavigatorMovePreviousItem2_Click(object sender, EventArgs e) {
            id_class.id_bus = int.Parse(индекс_автобусаTextBox.Text);

            пассажирDataGridView.DataSource = passenger.UpdatePassageCheck(int.Parse(индекс_автобусаTextBox.Text));

            // Вызов функции для отображения БД пассажира
            DataBasePassengerGirdView();
        }

        private void bindingNavigatorMoveNextItem2_Click(object sender, EventArgs e) {
            id_class.id_bus = int.Parse(индекс_автобусаTextBox.Text);

            пассажирDataGridView.DataSource = passenger.UpdatePassageCheck(int.Parse(индекс_автобусаTextBox.Text));

            // Вызов функции для отображения БД пассажира
            DataBasePassengerGirdView();
        }

        private void bindingNavigatorMoveLastItem2_Click(object sender, EventArgs e) {
            id_class.id_bus = int.Parse(индекс_автобусаTextBox.Text);

            пассажирDataGridView.DataSource = passenger.UpdatePassageCheck(int.Parse(индекс_автобусаTextBox.Text));

            // Вызов функции для отображения БД пассажира
            DataBasePassengerGirdView();
        }
        #endregion

        // ВКЛАДКА ПАССАЖИР
        // При переключении назад, вперед сохраняет ID
        #region
        // Сохранение данные ПАССАЖИР
        private void toolStripButton24_Click(object sender, EventArgs e) {
            try {
            passenger.Add(int.Parse(индекс_пассажираTextBox.Text), int.Parse(индекс_автобусаTextBox1.Text), ФИО_пассажираTextBox.Text, категория_пассажираTextBox.Text);
            } catch (Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        // Кнопка удаления
        private void toolStripButton16_Click(object sender, EventArgs e) {
            passenger.Delete(id_class.id_passenger);
        }

        // Кнопка добавления
        private void toolStripButton15_Click(object sender, EventArgs e) {
            индекс_пассажираTextBox.Text = (id_class.RegularExpressionTextIntoValue(toolStripLabel3.Text)).ToString();
        }
        // Кнопка обновления данных
        private void toolStripButton26_Click(object sender, EventArgs e) {
            try { 
            passenger.Update(int.Parse(индекс_пассажираTextBox.Text), int.Parse(индекс_автобусаTextBox1.Text), ФИО_пассажираTextBox.Text, категория_пассажираTextBox.Text);
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        private void toolStripButton20_Click(object sender, EventArgs e) {
            id_class.id_passenger = int.Parse(индекс_пассажираTextBox.Text);
        }

        private void toolStripButton19_Click(object sender, EventArgs e) {
            id_class.id_passenger = int.Parse(индекс_пассажираTextBox.Text);
        }

        private void toolStripButton18_Click(object sender, EventArgs e) {
            id_class.id_passenger = int.Parse(индекс_пассажираTextBox.Text);
        }

        private void toolStripButton17_Click(object sender, EventArgs e) {
            id_class.id_passenger = int.Parse(индекс_пассажираTextBox.Text);
        }

        #endregion

        // ВКЛАДКА КОНТРОЛЛЕР
        // При переключении назад, вперед сохраняет ID
        #region
        // Кнопка сохранение
        private void toolStripButton23_Click(object sender, EventArgs e) {
            try {
            controller.Add(int.Parse(индекс_контролераTextBox1.Text), ФИО_контролераTextBox.Text, номер_телефона_контролераTextBox.Text);
            } catch(Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        // Кнопка удаление
        private void toolStripButton10_Click(object sender, EventArgs e) {
            controller.Delete(id_class.id_controller);
        }
        
        // Кнопка добавление
        private void toolStripButton9_Click(object sender, EventArgs e) {
            индекс_контролераTextBox1.Text = (id_class.RegularExpressionTextIntoValue(toolStripLabel2.Text)).ToString();
        }

        // Кнопка обновление
        private void toolStripButton25_Click(object sender, EventArgs e) {
            try {
            controller.Update(id_class.id_controller, ФИО_контролераTextBox.Text, номер_телефона_контролераTextBox.Text);
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e) {
            id_class.id_controller = int.Parse(индекс_контролераTextBox1.Text);
        }

        private void toolStripButton12_Click(object sender, EventArgs e) {
            id_class.id_controller = int.Parse(индекс_контролераTextBox1.Text);
        }

        private void toolStripButton13_Click(object sender, EventArgs e) {
            id_class.id_controller = int.Parse(индекс_контролераTextBox1.Text);
        }

        private void toolStripButton14_Click(object sender, EventArgs e) {
            id_class.id_controller = int.Parse(индекс_контролераTextBox1.Text);
        }
        #endregion

        // ВКЛАДКА ВОДИТЕЛЬ
        // При переключении назад, вперед сохраняет ID
        #region
        // Кнопка добавление
        private void toolStripButton3_Click(object sender, EventArgs e) {
            индекс_водителяTextBox1.Text = (id_class.RegularExpressionTextIntoValue(toolStripLabel1.Text)).ToString();
        }
        // Кнопка удаление
        private void toolStripButton4_Click(object sender, EventArgs e) {
            driver.Delete(id_class.id_driver);
        }
        // Кнопка сохранение
        private void toolStripButton22_Click(object sender, EventArgs e) {
            try {
            driver.Add(int.Parse(индекс_водителяTextBox1.Text), ФИО_водителяTextBox.Text, номер_телефона_водителяTextBox.Text, int.Parse(стаж_водителяTextBox.Text));
            } catch(Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        // Кнопка обновление
        private void toolStripButton27_Click(object sender, EventArgs e) {
            try {
            driver.Update(id_class.id_driver, ФИО_водителяTextBox.Text, номер_телефона_водителяTextBox.Text, int.Parse(стаж_водителяTextBox.Text));
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        // Переключение вперед и назад
        private void toolStripButton5_Click(object sender, EventArgs e) {
            id_class.id_driver = int.Parse(индекс_водителяTextBox1.Text);
        }

        private void toolStripButton6_Click(object sender, EventArgs e) {
            id_class.id_driver = int.Parse(индекс_водителяTextBox1.Text);
        }

        private void toolStripButton7_Click(object sender, EventArgs e) {
            id_class.id_driver = int.Parse(индекс_водителяTextBox1.Text);
        }

        private void toolStripButton8_Click(object sender, EventArgs e) {
            id_class.id_driver = int.Parse(индекс_водителяTextBox1.Text);
        }
        #endregion

        // ВКЛАДКА РУКОВОДИТЕЛЬ
        // При переключении назад, вперед сохраняет ID
        #region
        // Кнопка обновление
        private void toolStripButton28_Click(object sender, EventArgs e) {
            try {
            director.Update(id_class.id_director, ФИО_руководителяTextBox.Text, номер_телефона_руководителяTextBox.Text);
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        // Кнопка сохранение
        private void toolStripButton21_Click(object sender, EventArgs e) {
            try {
            director.Add(int.Parse(индекс_руководителяTextBox1.Text), ФИО_руководителяTextBox.Text, номер_телефона_руководителяTextBox.Text);
            } catch(Exception error) {
                MessageBox.Show("Ошибка заполнения для сохранения!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }
        // Кнопка удаление
        private void bindingNavigatorDeleteItem3_Click(object sender, EventArgs e) {
            director.Delete(id_class.id_director);
        }

        // Кнопка добавление
        private void bindingNavigatorAddNewItem3_Click(object sender, EventArgs e) {
            индекс_руководителяTextBox1.Text = (id_class.RegularExpressionTextIntoValue(bindingNavigatorCountItem3.Text)).ToString();
        }

        // Переключение вперед и назад 
        private void bindingNavigatorMoveFirstItem3_Click(object sender, EventArgs e) {
            id_class.id_director = int.Parse(индекс_руководителяTextBox1.Text);
        }

        private void bindingNavigatorMovePreviousItem3_Click(object sender, EventArgs e) {
            id_class.id_director = int.Parse(индекс_руководителяTextBox1.Text);
        }

        private void bindingNavigatorMoveNextItem3_Click(object sender, EventArgs e) {
            id_class.id_director = int.Parse(индекс_руководителяTextBox1.Text);
        }

        private void bindingNavigatorMoveLastItem3_Click(object sender, EventArgs e) {
            id_class.id_director = int.Parse(индекс_руководителяTextBox1.Text);
        }
        #endregion

        // Прочие (ПУСТЫЕ)
        #region
        private void индекс_руководителяTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        // Обновление информации о автобусах по индексу рейса
        private void button1_Click(object sender, EventArgs e) {

        }

        private void bindingNavigator4_RefreshItems(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }
        private void label10_Click(object sender, EventArgs e) {

        }

        private void индекс_автобусного_паркаLabel_Click_1(object sender, EventArgs e) {

        }

        private void индекс_автобусного_паркаLabel1_Click(object sender, EventArgs e) {

        }

        private void фИО_пассажираTextBox_TextChanged(object sender, EventArgs e) {

        }



        private void label1_Click(object sender, EventArgs e) {

        }
        private void индекс_автобусного_паркаLabel_Click(object sender, EventArgs e) {

        }

        private void индекс_автобусного_паркаTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void рейсDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        #endregion


    }
}
