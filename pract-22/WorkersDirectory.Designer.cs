
namespace pract_22
{
    partial class WorkersDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersDirectory));
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.справочникРаботниковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочникРаботниковTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СправочникРаботниковTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.справочникРаботниковBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.справочникРаботниковBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.справочникРаботниковDataGridView = new System.Windows.Forms.DataGridView();
            this.списокЦеховBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокЦеховTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СписокЦеховTableAdapter();
            this.списокЦеховСправочникРаботниковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокЦеховСправочникРаботниковBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.списокЦеховBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.справочникТарифовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочникТарифовTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СправочникТарифовTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Разряд = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Цех = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковBindingNavigator)).BeginInit();
            this.справочникРаботниковBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховСправочникРаботниковBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховСправочникРаботниковBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listWorkersDataSet
            // 
            this.listWorkersDataSet.DataSetName = "listWorkersDataSet";
            this.listWorkersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // справочникРаботниковBindingSource
            // 
            this.справочникРаботниковBindingSource.DataMember = "СправочникРаботников";
            this.справочникРаботниковBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // справочникРаботниковTableAdapter
            // 
            this.справочникРаботниковTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pract_22.listWorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СписокЦеховTableAdapter = this.списокЦеховTableAdapter;
            this.tableAdapterManager.СправочникРаботниковTableAdapter = this.справочникРаботниковTableAdapter;
            this.tableAdapterManager.СправочникТарифовTableAdapter = this.справочникТарифовTableAdapter;
            this.tableAdapterManager.ТабельTableAdapter = null;
            // 
            // справочникРаботниковBindingNavigator
            // 
            this.справочникРаботниковBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.справочникРаботниковBindingNavigator.BindingSource = this.справочникРаботниковBindingSource;
            this.справочникРаботниковBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.справочникРаботниковBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.справочникРаботниковBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.справочникРаботниковBindingNavigatorSaveItem});
            this.справочникРаботниковBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.справочникРаботниковBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.справочникРаботниковBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.справочникРаботниковBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.справочникРаботниковBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.справочникРаботниковBindingNavigator.Name = "справочникРаботниковBindingNavigator";
            this.справочникРаботниковBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.справочникРаботниковBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.справочникРаботниковBindingNavigator.TabIndex = 0;
            this.справочникРаботниковBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // справочникРаботниковBindingNavigatorSaveItem
            // 
            this.справочникРаботниковBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справочникРаботниковBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("справочникРаботниковBindingNavigatorSaveItem.Image")));
            this.справочникРаботниковBindingNavigatorSaveItem.Name = "справочникРаботниковBindingNavigatorSaveItem";
            this.справочникРаботниковBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.справочникРаботниковBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.справочникРаботниковBindingNavigatorSaveItem.Click += new System.EventHandler(this.СправочникРаботниковBindingNavigatorSaveItem_Click_1);
            // 
            // справочникРаботниковDataGridView
            // 
            this.справочникРаботниковDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.справочникРаботниковDataGridView.AutoGenerateColumns = false;
            this.справочникРаботниковDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.справочникРаботниковDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.справочникРаботниковDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Разряд,
            this.Цех});
            this.справочникРаботниковDataGridView.DataSource = this.справочникРаботниковBindingSource;
            this.справочникРаботниковDataGridView.Location = new System.Drawing.Point(12, 28);
            this.справочникРаботниковDataGridView.Name = "справочникРаботниковDataGridView";
            this.справочникРаботниковDataGridView.Size = new System.Drawing.Size(776, 410);
            this.справочникРаботниковDataGridView.TabIndex = 1;
            // 
            // списокЦеховBindingSource
            // 
            this.списокЦеховBindingSource.DataMember = "СписокЦехов";
            this.списокЦеховBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // списокЦеховTableAdapter
            // 
            this.списокЦеховTableAdapter.ClearBeforeFill = true;
            // 
            // списокЦеховСправочникРаботниковBindingSource
            // 
            this.списокЦеховСправочникРаботниковBindingSource.DataMember = "СписокЦеховСправочникРаботников";
            this.списокЦеховСправочникРаботниковBindingSource.DataSource = this.списокЦеховBindingSource;
            // 
            // списокЦеховСправочникРаботниковBindingSource1
            // 
            this.списокЦеховСправочникРаботниковBindingSource1.DataMember = "СписокЦеховСправочникРаботников";
            this.списокЦеховСправочникРаботниковBindingSource1.DataSource = this.списокЦеховBindingSource;
            // 
            // списокЦеховBindingSource1
            // 
            this.списокЦеховBindingSource1.DataMember = "СписокЦехов";
            this.списокЦеховBindingSource1.DataSource = this.listWorkersDataSet;
            // 
            // справочникТарифовBindingSource
            // 
            this.справочникТарифовBindingSource.DataMember = "СправочникТарифов";
            this.справочникТарифовBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // справочникТарифовTableAdapter
            // 
            this.справочникТарифовTableAdapter.ClearBeforeFill = true;
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
            // Разряд
            // 
            this.Разряд.DataPropertyName = "Разряд";
            this.Разряд.DataSource = this.справочникТарифовBindingSource;
            this.Разряд.DisplayMember = "Разряд";
            this.Разряд.HeaderText = "Разряд";
            this.Разряд.Name = "Разряд";
            // 
            // Цех
            // 
            this.Цех.DataPropertyName = "Цех";
            this.Цех.DataSource = this.списокЦеховBindingSource1;
            this.Цех.DisplayMember = "НаименованиеЦеха";
            this.Цех.HeaderText = "Цех";
            this.Цех.Name = "Цех";
            // 
            // WorkersDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.справочникРаботниковDataGridView);
            this.Controls.Add(this.справочникРаботниковBindingNavigator);
            this.Name = "WorkersDirectory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник работников";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkersDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковBindingNavigator)).EndInit();
            this.справочникРаботниковBindingNavigator.ResumeLayout(false);
            this.справочникРаботниковBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.справочникРаботниковDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховСправочникРаботниковBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховСправочникРаботниковBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource справочникРаботниковBindingSource;
        private listWorkersDataSetTableAdapters.СправочникРаботниковTableAdapter справочникРаботниковTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator справочникРаботниковBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton справочникРаботниковBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView справочникРаботниковDataGridView;
        private listWorkersDataSetTableAdapters.СписокЦеховTableAdapter списокЦеховTableAdapter;
        private System.Windows.Forms.BindingSource списокЦеховBindingSource;
        private listWorkersDataSetTableAdapters.СправочникТарифовTableAdapter справочникТарифовTableAdapter;
        private System.Windows.Forms.BindingSource списокЦеховBindingSource1;
        private System.Windows.Forms.BindingSource списокЦеховСправочникРаботниковBindingSource;
        private System.Windows.Forms.BindingSource списокЦеховСправочникРаботниковBindingSource1;
        private System.Windows.Forms.BindingSource справочникТарифовBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Разряд;
        private System.Windows.Forms.DataGridViewComboBoxColumn Цех;
    }
}