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

namespace bus_coursework
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        // Редактировать базу данных
        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Edit_DB();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Посмотреть отчет
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Report_admin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Редактировать статус автобусного парка
        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Edit_status_bus();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Поиск марок автобусов
        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Search_bus();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Выйти с учетной 
        private void button5_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Autorization();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
