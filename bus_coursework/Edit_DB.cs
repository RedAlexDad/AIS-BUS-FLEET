using bus_coursework.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bus_coursework {
    public partial class Edit_DB : Form {

        LineBus linebus;
        BusFleet busfleet;
        Director director;
        Bus bus;
        Passage passage;

        // Для отображения запроса с зависимыми от текущей формы данными, заведем глобальную переменную:
        public static class glvar { public static string mynum { get; set; } }

        public Edit_DB() {
            InitializeComponent();
            linebus = new LineBus(ConnectionString.ConnStr);
            //busfleet = new BusFleet(ConnectionString.ConnStr);
            //director = new Director(ConnectionString.ConnStr);
            bus = new Bus(ConnectionString.ConnStr);
            passage = new Passage(ConnectionString.ConnStr);

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

        private void автобусный_паркBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.автобусный_паркBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus_dataset);

        }

        private void Edit_DB_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset1.Пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.bus_dataset.Пассажир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset1.Автобус". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset1.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.bus_dataset.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Контролер". При необходимости она может быть перемещена или удалена.
            this.контролерTableAdapter.Fill(this.bus_dataset.Контролер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.bus_dataset.Водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Руководитель". При необходимости она может быть перемещена или удалена.
            this.руководительTableAdapter.Fill(this.bus_dataset.Руководитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Пассажир". При необходимости она может быть перемещена или удалена.
            this.пассажирTableAdapter.Fill(this.bus_dataset.Пассажир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобус". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.bus_dataset.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобусный_парк". При необходимости она может быть перемещена или удалена.
            this.автобусный_паркTableAdapter.Fill(this.bus_dataset.Автобусный_парк);


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
            автобусDataGridView.Columns[3].Width = 30;
            // ID рейс
            автобусDataGridView.Columns[4].HeaderText = "ID рейс";
            автобусDataGridView.Columns[4].Width = 50;
            // Индекс автобусного парка, true - отображать, false - скрыть
            автобусDataGridView.Columns[5].Visible = false;
            // ID водитель
            автобусDataGridView.Columns[6].HeaderText = "ID водитель";
            автобусDataGridView.Columns[6].Width = 200;
            // ID контролер
            автобусDataGridView.Columns[7].HeaderText = "ID контролер";
            автобусDataGridView.Columns[7].Width = 200;
            // Статус автобуса, true - отображать, false - скрыть
            автобусDataGridView.Columns[8].Visible = false;

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

        // Кнопка Обновления
        private void button8_Click(object sender, EventArgs e) {
            рейсDataGridView.DataSource = linebus.UpdateLineBusCheck(int.Parse(индекс_автобусного_паркаTextBox.Text));

            // Не отображается, возвращает пустое значение
            //Console.WriteLine(int.Parse(индекс_руководителяTextBox.Text));
            //Console.WriteLine(director.get_fio_director_by_id(int.Parse(индекс_руководителяTextBox.Text)));
            //рейсDataGridView.DataSource = director.get_fio_director_by_id(int.Parse(индекс_руководителяTextBox.Text)).ToString();

            //string test = director.get_fio_director_by_id(int.Parse(индекс_руководителяTextBox.Text)).ToString();
            //Console.WriteLine(test);
            //индекс_руководителяTextBox.Text = "FIO";
        }

        private void индекс_руководителяTextBox_TextChanged(object sender, EventArgs e) {
            
        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        // Обновление информации о автобусах по индексу рейса
        private void button1_Click(object sender, EventArgs e) {
            автобусDataGridView.DataSource = bus.UpdateBusCheck(int.Parse(индекс_рейсаTextBox.Text));
        }



        private void bindingNavigator4_RefreshItems(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        // Обновление информации о пассажирах по индексу автобуса
        private void button2_Click(object sender, EventArgs e) {
            пассажирDataGridView.DataSource = passage.UpdatePassageCheck(int.Parse(индекс_автобусаTextBox.Text));
        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void индекс_автобусного_паркаLabel_Click_1(object sender, EventArgs e) {

        }

        private void индекс_автобусного_паркаLabel1_Click(object sender, EventArgs e) {

        }
    }
}
