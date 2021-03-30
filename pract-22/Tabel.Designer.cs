namespace pract_22
{
    partial class Tabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabel));
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.табельBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.табельTableAdapter = new pract_22.listWorkersDataSetTableAdapters.ТабельTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.справочникРаботниковTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СправочникРаботниковTableAdapter();
            this.табельBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.табельBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.табельDataGridView = new System.Windows.Forms.DataGridView();
            this.ТабельныйНомер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.справочникРаботниковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingNavigator)).BeginInit();
            this.табельBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.табельDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listWorkersDataSet
            // 
            this.listWorkersDataSet.DataSetName = "listWorkersDataSet";
            this.listWorkersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // табельBindingSource
            // 
            this.табельBindingSource.DataMember = "Табель";
            this.табельBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // табельTableAdapter
            // 
            this.табельTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pract_22.listWorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СписокЦеховTableAdapter = null;
            this.tableAdapterManager.СправочникРаботниковTableAdapter = this.справочникРаботниковTableAdapter;
            this.tableAdapterManager.СправочникТарифовTableAdapter = null;
            this.tableAdapterManager.ТабельTableAdapter = this.табельTableAdapter;
            // 
            // справочникРаботниковTableAdapter
            // 
            this.справочникРаботниковTableAdapter.ClearBeforeFill = true;
            // 
            // табельBindingNavigator
            // 
            this.табельBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.табельBindingNavigator.BindingSource = this.табельBindingSource;
            this.табельBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.табельBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.табельBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.табельBindingNavigatorSaveItem});
            this.табельBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.табельBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.табельBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.табельBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.табельBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.табельBindingNavigator.Name = "табельBindingNavigator";
            this.табельBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.табельBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.табельBindingNavigator.TabIndex = 0;
            this.табельBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // табельBindingNavigatorSaveItem
            // 
            this.табельBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.табельBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("табельBindingNavigatorSaveItem.Image")));
            this.табельBindingNavigatorSaveItem.Name = "табельBindingNavigatorSaveItem";
            this.табельBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.табельBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.табельBindingNavigatorSaveItem.Click += new System.EventHandler(this.ТабельBindingNavigatorSaveItem_Click);
            // 
            // табельDataGridView
            // 
            this.табельDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.табельDataGridView.AutoGenerateColumns = false;
            this.табельDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.табельDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.табельDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ТабельныйНомер,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.табельDataGridView.DataSource = this.табельBindingSource;
            this.табельDataGridView.Location = new System.Drawing.Point(12, 28);
            this.табельDataGridView.Name = "табельDataGridView";
            this.табельDataGridView.Size = new System.Drawing.Size(776, 410);
            this.табельDataGridView.TabIndex = 1;
            // 
            // ТабельныйНомер
            // 
            this.ТабельныйНомер.DataPropertyName = "ТабельныйНомер";
            this.ТабельныйНомер.DataSource = this.справочникРаботниковBindingSource;
            this.ТабельныйНомер.DisplayMember = "ТабельныйНомер";
            this.ТабельныйНомер.HeaderText = "ТабельныйНомер";
            this.ТабельныйНомер.Name = "ТабельныйНомер";
            // 
            // справочникРаботниковBindingSource
            // 
            this.справочникРаботниковBindingSource.DataMember = "СправочникРаботников";
            this.справочникРаботниковBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ОтрабВремяВЧасах";
            this.dataGridViewTextBoxColumn2.HeaderText = "ОтрабВремяВЧасах";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "НомерМесяца";
            this.dataGridViewTextBoxColumn3.HeaderText = "НомерМесяца";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.табельDataGridView);
            this.Controls.Add(this.табельBindingNavigator);
            this.Name = "Tabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табель работников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.табельBindingNavigator)).EndInit();
            this.табельBindingNavigator.ResumeLayout(false);
            this.табельBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.табельDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource табельBindingSource;
        private listWorkersDataSetTableAdapters.ТабельTableAdapter табельTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator табельBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton табельBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView табельDataGridView;
        private listWorkersDataSetTableAdapters.СправочникРаботниковTableAdapter справочникРаботниковTableAdapter;
        private System.Windows.Forms.BindingSource справочникРаботниковBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn ТабельныйНомер;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}