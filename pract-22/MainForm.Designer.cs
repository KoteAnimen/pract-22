
namespace pract_22
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenListPlaces = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTarifsDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWorkersDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkersTabel = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowListPlaceWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.CountPlaceWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.workersTableAdapter = new pract_22.listWorkersDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.GetWorkersSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.GetWorkersSalary});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenListPlaces,
            this.OpenTarifsDirectory,
            this.OpenWorkersDirectory,
            this.WorkersTabel});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.операцииToolStripMenuItem.Text = "Меню";
            // 
            // OpenListPlaces
            // 
            this.OpenListPlaces.Name = "OpenListPlaces";
            this.OpenListPlaces.Size = new System.Drawing.Size(210, 22);
            this.OpenListPlaces.Text = "Список цехов";
            this.OpenListPlaces.Click += new System.EventHandler(this.OpenListPlaces_Click);
            // 
            // OpenTarifsDirectory
            // 
            this.OpenTarifsDirectory.Name = "OpenTarifsDirectory";
            this.OpenTarifsDirectory.Size = new System.Drawing.Size(210, 22);
            this.OpenTarifsDirectory.Text = "Справочник тарифов";
            this.OpenTarifsDirectory.Click += new System.EventHandler(this.OpenTarifsDirectory_Click);
            // 
            // OpenWorkersDirectory
            // 
            this.OpenWorkersDirectory.Name = "OpenWorkersDirectory";
            this.OpenWorkersDirectory.Size = new System.Drawing.Size(210, 22);
            this.OpenWorkersDirectory.Text = "Справочник работников";
            this.OpenWorkersDirectory.Click += new System.EventHandler(this.OpenWorkersDirectory_Click);
            // 
            // WorkersTabel
            // 
            this.WorkersTabel.Name = "WorkersTabel";
            this.WorkersTabel.Size = new System.Drawing.Size(210, 22);
            this.WorkersTabel.Text = "Табель работников";
            this.WorkersTabel.Click += new System.EventHandler(this.WorkersTabel_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowListPlaceWorkers,
            this.CountPlaceWorkers,
            this.ShowAll});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // ShowListPlaceWorkers
            // 
            this.ShowListPlaceWorkers.Name = "ShowListPlaceWorkers";
            this.ShowListPlaceWorkers.Size = new System.Drawing.Size(309, 22);
            this.ShowListPlaceWorkers.Text = "Показать список работников цеха";
            this.ShowListPlaceWorkers.Click += new System.EventHandler(this.ShowListPlaceWorkers_Click);
            // 
            // CountPlaceWorkers
            // 
            this.CountPlaceWorkers.Name = "CountPlaceWorkers";
            this.CountPlaceWorkers.Size = new System.Drawing.Size(309, 22);
            this.CountPlaceWorkers.Text = "Подсчитать количество работников в цехе";
            this.CountPlaceWorkers.Click += new System.EventHandler(this.CountPlaceWorkers_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(309, 22);
            this.ShowAll.Text = "Показать все";
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUs});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(149, 22);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.workersDataGridView.DataSource = this.workersBindingSource;
            this.workersDataGridView.Location = new System.Drawing.Point(12, 27);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.ReadOnly = true;
            this.workersDataGridView.Size = new System.Drawing.Size(1043, 515);
            this.workersDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ТабельныйНомер";
            this.dataGridViewTextBoxColumn1.HeaderText = "ТабельныйНомер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Разряд";
            this.dataGridViewTextBoxColumn3.HeaderText = "Разряд";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Цех";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цех";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ОтрабВремяВЧасах";
            this.dataGridViewTextBoxColumn5.HeaderText = "ОтрабВремяВЧасах";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // listWorkersDataSet
            // 
            this.listWorkersDataSet.DataSetName = "listWorkersDataSet";
            this.listWorkersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = pract_22.listWorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СписокЦеховTableAdapter = null;
            this.tableAdapterManager.СправочникРаботниковTableAdapter = null;
            this.tableAdapterManager.СправочникТарифовTableAdapter = null;
            this.tableAdapterManager.ТабельTableAdapter = null;
            // 
            // GetWorkersSalary
            // 
            this.GetWorkersSalary.Name = "GetWorkersSalary";
            this.GetWorkersSalary.Size = new System.Drawing.Size(249, 20);
            this.GetWorkersSalary.Text = "Сформировать ведомость начислений зп";
            this.GetWorkersSalary.Click += new System.EventHandler(this.GetWorkersSalary_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.workersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Работники предприятия";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenWorkersDirectory;
        private System.Windows.Forms.ToolStripMenuItem OpenListPlaces;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripMenuItem OpenTarifsDirectory;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowListPlaceWorkers;
        private System.Windows.Forms.ToolStripMenuItem CountPlaceWorkers;
        private System.Windows.Forms.ToolStripMenuItem ShowAll;
        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private listWorkersDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripMenuItem WorkersTabel;
        private System.Windows.Forms.ToolStripMenuItem GetWorkersSalary;
    }
}

