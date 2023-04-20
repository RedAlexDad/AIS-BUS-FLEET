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
        //Director director;

        // Для отображения запроса с зависимыми от текущей формы данными, заведем глобальную переменную:
        public static class glvar { public static string mynum { get; set; } }

        public Edit_DB() {
            InitializeComponent();
            linebus = new LineBus(ConnectionString.ConnStr);
            busfleet = new BusFleet(ConnectionString.ConnStr);

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.bus_dataset.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобусный_парк". При необходимости она может быть перемещена или удалена.
            this.автобусный_паркTableAdapter.Fill(this.bus_dataset.Автобусный_парк);

            // Название столбца и ширина столбца
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

        // Кнопка Обновления
        private void button8_Click(object sender, EventArgs e) {
            рейсDataGridView.DataSource = linebus.UpdateLineBusCheck(int.Parse(индекс_автобусного_паркаTextBox.Text));

            //Console.WriteLine(int.Parse(индекс_руководителяTextBox.Text));
            //Console.WriteLine(busfleet.get_fio_director_by_id(int.Parse(индекс_автобусного_паркаTextBox.Text)).ToString());

            //рейсDataGridView.DataSource = busfleet.get_fio_director_by_id(int.Parse(индекс_руководителяTextBox.Text)).ToString();

            //string test = director.get_fio_director_by_id(int.Parse(индекс_руководителяTextBox.Text)).ToString();
            //Console.WriteLine(test);
            //индекс_руководителяTextBox.Text = "FIO";
        }

        private void индекс_руководителяTextBox_TextChanged(object sender, EventArgs e) {
            
        }
    }
}
