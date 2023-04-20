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

namespace bus_coursework
{
    public partial class Edit_DB : Form
    {
        public Edit_DB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void автобусный_паркBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автобусный_паркBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus_dataset);

        }

        private void Edit_DB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Рейс". При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.bus_dataset.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобусный_парк". При необходимости она может быть перемещена или удалена.
            this.автобусный_паркTableAdapter.Fill(this.bus_dataset.Автобусный_парк);

        }

        private void индекс_автобусного_паркаLabel_Click(object sender, EventArgs e)
        {

        }

        private void индекс_автобусного_паркаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Для отображения запроса с зависимыми от текущей формы данными, заведем глобальную переменную:
        public static class glvar { public static string mynum { get; set; } }

        private void рейсDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // И перед открытием второй формы, сохраним в нее номер заказа:
            glvar.mynum = this.рейсDataGridView.CurrentCell.Value.ToString();

            TestForm f2 = new TestForm();
            f2.Show();
        }
    }
}
