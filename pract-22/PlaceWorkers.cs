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
            if(place.Text != "")
            {
                Data.resolution = true;
                Data.namePlace = place.Text;
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
    }
}
