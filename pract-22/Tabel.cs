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
    public partial class Tabel : Form
    {
        public Tabel()
        {
            InitializeComponent();
        }

        private void ТабельBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.табельBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.listWorkersDataSet);

        }

        private void Tabel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.СправочникРаботников". При необходимости она может быть перемещена или удалена.
            this.справочникРаботниковTableAdapter.Fill(this.listWorkersDataSet.СправочникРаботников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.Табель". При необходимости она может быть перемещена или удалена.
            this.табельTableAdapter.Fill(this.listWorkersDataSet.Табель);

        }
    }
}
