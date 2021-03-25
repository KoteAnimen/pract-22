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
    public partial class ListPlaces : Form
    {
        public ListPlaces()
        {
            InitializeComponent();
        }

        private void списокЦеховBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.списокЦеховBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.listWorkersDataSet);

        }

        private void ListPlaces_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.СписокЦехов". При необходимости она может быть перемещена или удалена.
            this.списокЦеховTableAdapter.Fill(this.listWorkersDataSet.СписокЦехов);

        }
    }
}
