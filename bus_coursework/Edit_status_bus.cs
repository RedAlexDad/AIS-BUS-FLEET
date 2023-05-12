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
using static bus_coursework.Edit_DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bus_coursework.MyClass {
    public partial class Edit_status_bus : Form {
        MyClass.Bus bus;
        MyClass.Other other;

        int indexRow = 0;
        int indexGlobal = 0;

        public Edit_status_bus() {
            InitializeComponent();

            bus = new Bus(ConnectionString.ConnStr);
            other = new Other(ConnectionString.ConnStr);
        }

        int RegularExpressionTextIntoValue(string str) {
            try {
                return int.Parse(Regex.Replace(str, "[^0-9]", String.Empty));
            } catch { return 0; }
        }

        // Отображение БД автобуса
        private void DataBaseBusGirdView() {
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
            автобусDataGridView.Columns[4].HeaderText = "Номер рейса";
            автобусDataGridView.Columns[4].Width = 50;
            // Индекс автобусного парка
            автобусDataGridView.Columns[5].HeaderText = "Название автобусного парка";
            автобусDataGridView.Columns[5].Width = 150;
            // ID водитель
            автобусDataGridView.Columns[6].HeaderText = "ФИО водителя";
            автобусDataGridView.Columns[6].Width = 200;
            // ID контролер
            автобусDataGridView.Columns[7].HeaderText = "ФИО контролера";
            автобусDataGridView.Columns[7].Width = 200;
            // Cтатус автобуса
            автобусDataGridView.Columns[8].HeaderText = "Статус";
            автобусDataGridView.Columns[8].Width = 200;
        }

        private void Edit_status_bus_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобус". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);
            bindingNavigatorPositionItem.Enabled = false;

            // Развернуть на полный экран
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            // АВТОБУС
            try {
                автобусDataGridView.DataSource = bus.UpdateBusWithStatus();
                DataBaseBusGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД автобуса!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        private void UpdateInfoTextBox(int index) {
            // Выделяет строку
            DataGridViewRow row = автобусDataGridView.Rows[index];

            индекс_автобусаTextBox.Text = row.Cells[0].Value.ToString();
            марка_автобусаTextBox.Text = row.Cells[1].Value.ToString();
            модель_автобусаTextBox.Text = row.Cells[2].Value.ToString();
            год_выпуска_автобусаTextBox.Text = row.Cells[3].Value.ToString();
            индекс_рейсаTextBox1.Text = row.Cells[4].Value.ToString();
            индекс_автобусного_паркаTextBox2.Text = row.Cells[5].Value.ToString();
            индекс_водителяTextBox.Text = row.Cells[6].Value.ToString();
            индекс_контролераTextBox.Text = row.Cells[7].Value.ToString();

            if(row.Cells[8].Value.ToString() == "В автобусном парке") {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if(row.Cells[8].Value.ToString() == "В пути") {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void автобусBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.автобусBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus_dataset);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e) {
            bindingNavigatorPositionItem.Enabled = false;
            indexGlobal = 0;

            bindingNavigatorPositionItem.Text = indexGlobal.ToString();
            //Console.WriteLine($"Position 0: {indexGlobal}");

            автобусDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            автобусDataGridView.Rows[indexRow].Selected = true;
            автобусDataGridView.CurrentCell = автобусDataGridView[0, indexGlobal];
            UpdateInfoTextBox(indexGlobal);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e) {
            bindingNavigatorPositionItem.Enabled = false;
            if(indexRow != -1 && indexRow <= RegularExpressionTextIntoValue(bindingNavigatorCountItem.Text) - 1) {
                indexGlobal = indexGlobal - 1;

                bindingNavigatorPositionItem.Text = indexGlobal.ToString();
                //Console.WriteLine($"Position -1: {indexGlobal}");

                автобусDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                автобусDataGridView.Rows[indexRow].Selected = true;
                автобусDataGridView.CurrentCell = автобусDataGridView[0, indexGlobal];
                UpdateInfoTextBox(indexGlobal);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e) {
            bindingNavigatorPositionItem.Enabled = false;
            if(indexRow != -1 && indexRow <= RegularExpressionTextIntoValue(bindingNavigatorCountItem.Text) - 1) {
                indexGlobal = indexGlobal + 1;

                bindingNavigatorPositionItem.Text = indexGlobal.ToString();
                //Console.WriteLine($"Position -1: {indexGlobal}");

                автобусDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                автобусDataGridView.Rows[indexRow].Selected = true;
                автобусDataGridView.CurrentCell = автобусDataGridView[0, indexGlobal];
                UpdateInfoTextBox(indexGlobal);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e) {
            bindingNavigatorPositionItem.Enabled = false;
            indexGlobal = RegularExpressionTextIntoValue(bindingNavigatorCountItem.Text) - 1;

            bindingNavigatorPositionItem.Text = indexGlobal.ToString();
            //Console.WriteLine($"Position max: {indexGlobal}");

            автобусDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            автобусDataGridView.Rows[indexRow].Selected = true;
            автобусDataGridView.CurrentCell = автобусDataGridView[0, indexGlobal];
            UpdateInfoTextBox(indexGlobal);
        }


        //UPD: Работает, но конфликтует с кнопкой переключателей, т.к. не ссылается инедкс
        // Чтобы включить его, нужно зайти в Edit_status_bus.Designer.cs и раскомментировать
        //this.автобусDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.автобусDataGridView_CellContentClick);
        #region
        // Выделяет строчку при нажатии мыши пользователем
        //private void автобусDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        //    // Выделяет строку
        //    indexRow = e.RowIndex;
        //    DataGridViewRow row = автобусDataGridView.Rows[indexRow];

        //    indexGlobal = row.Index;
        //    bindingNavigatorPositionItem.Text = indexGlobal.ToString();

        //    Console.WriteLine(indexGlobal);

        //    индекс_автобусаTextBox.Text = row.Cells[0].Value.ToString();
        //    марка_автобусаTextBox.Text = row.Cells[1].Value.ToString();
        //    модель_автобусаTextBox.Text = row.Cells[2].Value.ToString();
        //    год_выпуска_автобусаTextBox.Text = row.Cells[3].Value.ToString();
        //    индекс_рейсаTextBox1.Text = row.Cells[4].Value.ToString();
        //    индекс_автобусного_паркаTextBox2.Text = row.Cells[5].Value.ToString();
        //    индекс_водителяTextBox.Text = row.Cells[6].Value.ToString();
        //    индекс_контролераTextBox.Text = row.Cells[7].Value.ToString();

        //    if(row.Cells[8].Value.ToString() == "В автобусном парке") {
        //        radioButton1.Checked = true;
        //        radioButton2.Checked = false;
        //    }
        //    if(row.Cells[8].Value.ToString() == "В пути") {
        //        radioButton1.Checked = false;
        //        radioButton2.Checked = true;
        //    }
        //}
        #endregion

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            //radioButton1.Checked = true;
            //radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            //radioButton1.Checked = false;
            //radioButton2.Checked = true;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e) {
            radioButton1.Checked = true;
            other.UpdateStatusBus(int.Parse(индекс_автобусаTextBox.Text), 1);

            // АВТОБУС
            try {
                автобусDataGridView.DataSource = bus.UpdateBusWithStatus();
                DataBaseBusGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД автобуса!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e) {
            radioButton1.Checked = false;
            other.UpdateStatusBus(int.Parse(индекс_автобусаTextBox.Text), 2);

            // АВТОБУС
            try {
                автобусDataGridView.DataSource = bus.UpdateBusWithStatus();
                DataBaseBusGirdView();
            } catch(Exception error) {
                MessageBox.Show("Ошибка обновления БД автобуса!\nТип ошибки:\n\n" + error, "Ошибка!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Administrator();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
