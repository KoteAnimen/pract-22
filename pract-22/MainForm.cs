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

        private void CountPlaceWorkers_Click(object sender, EventArgs e)
        {
            CountWorkersByPlace count = new CountWorkersByPlace();
            count.ShowDialog();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, вариант 1. Задание 1.Создать таблицы:" + "\n"  + "Таблица 1.Справочник работников." + "\n" + "Структура таблицы: Табельный номер, Фамилия, Разряд, Цех" + "\n" + "Таблица 2.Справочник тарифов." + "\n" + "Структура таблицы: Разряд, Тариф(руб./ час.)" + "\n" + "Таблица 3.Табель." + "\n" + "Структура таблицы: Табельный номер, Отработанное время в часах, Номер месяца" + "\n" + "Таблица 4.Список цехов." + "\n" + "Структура таблицы: Цех, Наименование цеха." + "\n" + "Задание 2.С помощью SQL - запроса сформировать список работников цеха.Список должен содержать поля: Наименование цеха, Фамилия, Разряд, Тариф." + "\n" +"Задание 3.Создать SQL - запрос для подсчета количества работников, работающих в одном цехе, который должен содержать поля: Цех, Количество работников.", "О программе");
        }
    }

    public static class Data
    {
        public static string namePlace;
        public static bool resolution;
    }
}
