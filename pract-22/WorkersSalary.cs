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
    public partial class WorkersSalary : Form
    {
        public WorkersSalary()
        {
            InitializeComponent();
        }

        private void WorkersSalary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.task3". При необходимости она может быть перемещена или удалена.
            this.task3TableAdapter.Fill(this.listWorkersDataSet.task3);

        }
    }
}
