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
    public partial class Add_info_db : Form
    {
        public Add_info_db()
        {
            InitializeComponent();
        }

        private void автобусBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автобусBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bus_dataset);

        }

        private void Add_info_db_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bus_dataset.Автобус". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.bus_dataset.Автобус);

        }

        private void автобусDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
