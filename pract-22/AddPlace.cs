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
    public partial class AddPlace : Form
    {
        public AddPlace()
        {
            InitializeComponent();
        }

        private void СписокЦеховBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.списокЦеховBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.listWorkersDataSet);

        }

        private void AddPlace_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.СписокЦехов". При необходимости она может быть перемещена или удалена.
            this.списокЦеховTableAdapter.Fill(this.listWorkersDataSet.СписокЦехов);
            списокЦеховBindingSource.AddNew();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(цехTextBox.Text == "")
            {
                MessageBox.Show("Введите цех", "Ошибка");
                return;
            }
            if (наименованиеЦехаTextBox.Text == "")
            {
                MessageBox.Show("Введите наименование цеха", "Ошибка");
                return;
            }

            try
            {
                списокЦеховTableAdapter.Insert(цехTextBox.Text, наименованиеЦехаTextBox.Text);
                Close();
            }
            catch
            {
                MessageBox.Show("Ключевое поле цех уже имеет такое обозначение", "Ошибка");
            }

            

        }
    }
}
