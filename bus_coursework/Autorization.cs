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
    public partial class Autorization : Form {

        MyClass.Other other;

        public Autorization() {
            InitializeComponent();
            other = new Other(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e) {
            string login = comboBox.Text;
            string password = textBox.Text;

            Console.WriteLine(login+ " " + password);

            if(other.CheckLoginAndPassword(login, password)) {
                    if(login == "Admin") {
                        this.Hide();
                        var form2 = new Administrator();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    } else if (login == "User"){
                        this.Hide();
                        var form2 = new User();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    } else { MessageBox.Show("Выберите тип группы: администратор или пользователь!", "Ошибка!"); }
                }
            }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
