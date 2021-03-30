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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.listWorkersDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listWorkersDataSet.infWorkers". При необходимости она может быть перемещена или удалена.
            

        }

        private void OpenWorkersDirectory_Click(object sender, EventArgs e)
        {
            WorkersDirectory workers = new WorkersDirectory();
            workers.ShowDialog();

        }

        private void OpenListPlaces_Click(object sender, EventArgs e)
        {
            ListPlaces places = new ListPlaces();
            places.ShowDialog();

        }

        private void OpenTarifsDirectory_Click(object sender, EventArgs e)
        {
            TarifsDirectory tarifs = new TarifsDirectory();
            tarifs.ShowDialog();

        }

        private void ShowListPlaceWorkers_Click(object sender, EventArgs e)
        {
            PlaceWorkers place = new PlaceWorkers();
            place.ShowDialog();
            if(Data.resolution == true)
            {
                workersTableAdapter.FillByPlace(listWorkersDataSet.Workers, Data.namePlace);
            }            
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            this.workersTableAdapter.Fill(this.listWorkersDataSet.Workers);
        }
    }

    public static class Data
    {
        public static string namePlace;
        public static bool resolution;
    }
}
