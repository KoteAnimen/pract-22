using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_22
{
    public partial class PlaceWorkers : Form
    {
        public PlaceWorkers()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if(цехComboBox.Text != "")
            {
                Data.resolution = true;
                Data.namePlace = цехComboBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Введите название цеха", "Ошибка");
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Data.resolution = false;
        }

        private void PlaceWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.СписокЦехов". При необходимости она может быть перемещена или удалена.
            this.списокЦеховTableAdapter.Fill(this.listWorkersDataSet.СписокЦехов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.listWorkersDataSet.Workers);

        }
    }
}
