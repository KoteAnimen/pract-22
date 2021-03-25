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
    public partial class WorkersDirectory : Form
    {
        public WorkersDirectory()
        {
            InitializeComponent();
        }

        private void справочникРаботниковBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.справочникРаботниковBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.listWorkersDataSet);

        }

        private void WorkersDirectory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.СправочникРаботников". При необходимости она может быть перемещена или удалена.
            this.справочникРаботниковTableAdapter.Fill(this.listWorkersDataSet.СправочникРаботников);

        }
    }
}
