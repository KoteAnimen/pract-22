
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
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.infWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infWorkersTableAdapter = new pract_22.listWorkersDataSetTableAdapters.infWorkersTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.infWorkersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникРаботниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЦеховToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникТарифовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infWorkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infWorkersDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listWorkersDataSet
            // 
            this.listWorkersDataSet.DataSetName = "listWorkersDataSet";
            this.listWorkersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infWorkersBindingSource
            // 
            this.infWorkersBindingSource.DataMember = "infWorkers";
            this.infWorkersBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // infWorkersTableAdapter
            // 
            this.infWorkersTableAdapter.ClearBeforeFill = true;
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
            // infWorkersDataGridView
            // 
            this.infWorkersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infWorkersDataGridView.AutoGenerateColumns = false;
            this.infWorkersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infWorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infWorkersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.infWorkersDataGridView.DataSource = this.infWorkersBindingSource;
            this.infWorkersDataGridView.Location = new System.Drawing.Point(16, 33);
            this.infWorkersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.infWorkersDataGridView.Name = "infWorkersDataGridView";
            this.infWorkersDataGridView.ReadOnly = true;
            this.infWorkersDataGridView.Size = new System.Drawing.Size(1035, 506);
            this.infWorkersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ТабельныйНомер";
            this.dataGridViewTextBoxColumn1.HeaderText = "ТабельныйНомер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Разряд";
            this.dataGridViewTextBoxColumn3.HeaderText = "Разряд";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Тариф";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тариф";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ОтрабВремяВЧасах";
            this.dataGridViewTextBoxColumn5.HeaderText = "ОтрабВремяВЧасах";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "НаименованиеЦеха";
            this.dataGridViewTextBoxColumn6.HeaderText = "НаименованиеЦеха";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.справкаToolStripMenuItem});
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
            this.справочникРаботниковToolStripMenuItem,
            this.списокЦеховToolStripMenuItem,
            this.справочникТарифовToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.операцииToolStripMenuItem.Text = "Меню";
            // 
            // справочникРаботниковToolStripMenuItem
            // 
            this.справочникРаботниковToolStripMenuItem.Name = "справочникРаботниковToolStripMenuItem";
            this.справочникРаботниковToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.справочникРаботниковToolStripMenuItem.Text = "Справочник работников";
            // 
            // списокЦеховToolStripMenuItem
            // 
            this.списокЦеховToolStripMenuItem.Name = "списокЦеховToolStripMenuItem";
            this.списокЦеховToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.списокЦеховToolStripMenuItem.Text = "Список цехов";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справочникТарифовToolStripMenuItem
            // 
            this.справочникТарифовToolStripMenuItem.Name = "справочникТарифовToolStripMenuItem";
            this.справочникТарифовToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.справочникТарифовToolStripMenuItem.Text = "Справочник тарифов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.infWorkersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Работники предприятия";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infWorkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infWorkersDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource infWorkersBindingSource;
        private listWorkersDataSetTableAdapters.infWorkersTableAdapter infWorkersTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView infWorkersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникРаботниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЦеховToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникТарифовToolStripMenuItem;
    }
}

