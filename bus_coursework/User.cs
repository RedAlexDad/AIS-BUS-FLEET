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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e) {
            // Развернуть на полный экран
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        // Посмотреть отчет
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Report_user();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        // Выйти с учетной записи
        private void button5_Click(object sender, EventArgs e) {
            this.Hide();
            var form2 = new Autorization();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
