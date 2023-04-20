using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static bus_coursework.Edit_DB;
using System.Configuration;
using bus_coursework.Controller;

namespace bus_coursework
{
    
    public partial class TestForm : Form
    {

        //Query controller;

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            //controller = new Query(ConnectionString.ConnStr);

            string conStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Papin/source/repos/bus_coursework/bus_coursework/Application.mdb\r\n";
            
            //string sql = @"SELECT * FROM Рейс " + glvar.mynum;
            string sql = @"SELECT * FROM Рейс ";
            //string sql = @"Select idOrder, PrName, Quantity, PrPrice, Quantity*PrPrice as
            //               SumCost from Items i Inner join Products p on i.IdProduct = p.IdProduct
            //               where idOrder = 1";

            // пример текст SQL запроса


            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = new SqlCommand(sql, connection);

                DataSet ds = new DataSet();
                myadapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                // Название столбца
                dataGridView1.Columns[1].HeaderText = "Название продукта";
                // Ширина столбца
                dataGridView1.Columns[1].Width = 150;

                dataGridView1.Columns[2].HeaderText = "Заголовок столбца";

                dataGridView1.Columns[3].HeaderText = "Стоимость продукта [единица]";
                dataGridView1.Columns[3].Width = 100;

                dataGridView1.Columns[4].HeaderText = "Сумма стоимостей продуктов";
                dataGridView1.Columns[4].Width = 100;


                dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridView1.Columns[0].Visible = false;
            }
        }
    }
}
