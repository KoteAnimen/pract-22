
namespace pract_22
{
    partial class TarifsDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifsDirectory));
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.справочникТарифовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.справочникТарифовTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СправочникТарифовTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.справочникТарифовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.справочникТарифовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.справочникТарифовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовBindingNavigator)).BeginInit();
            this.справочникТарифовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listWorkersDataSet
            // 
            this.listWorkersDataSet.DataSetName = "listWorkersDataSet";
            this.listWorkersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pract_22.listWorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СписокЦеховTableAdapter = null;
            this.tableAdapterManager.СправочникРаботниковTableAdapter = null;
            this.tableAdapterManager.СправочникТарифовTableAdapter = this.справочникТарифовTableAdapter;
            this.tableAdapterManager.ТабельTableAdapter = null;
            // 
            // справочникТарифовBindingNavigator
            // 
            this.справочникТарифовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.справочникТарифовBindingNavigator.BindingSource = this.справочникТарифовBindingSource;
            this.справочникТарифовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.справочникТарифовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.справочникТарифовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.справочникТарифовBindingNavigatorSaveItem});
            this.справочникТарифовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.справочникТарифовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.справочникТарифовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.справочникТарифовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.справочникТарифовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.справочникТарифовBindingNavigator.Name = "справочникТарифовBindingNavigator";
            this.справочникТарифовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.справочникТарифовBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.справочникТарифовBindingNavigator.TabIndex = 0;
            this.справочникТарифовBindingNavigator.Text = "bindingNavigator1";
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
            // справочникТарифовBindingNavigatorSaveItem
            // 
            this.справочникТарифовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справочникТарифовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("справочникТарифовBindingNavigatorSaveItem.Image")));
            this.справочникТарифовBindingNavigatorSaveItem.Name = "справочникТарифовBindingNavigatorSaveItem";
            this.справочникТарифовBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.справочникТарифовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.справочникТарифовBindingNavigatorSaveItem.Click += new System.EventHandler(this.справочникТарифовBindingNavigatorSaveItem_Click);
            // 
            // справочникТарифовDataGridView
            // 
            this.справочникТарифовDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.справочникТарифовDataGridView.AutoGenerateColumns = false;
            this.справочникТарифовDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.справочникТарифовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.справочникТарифовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.справочникТарифовDataGridView.DataSource = this.справочникТарифовBindingSource;
            this.справочникТарифовDataGridView.Location = new System.Drawing.Point(12, 28);
            this.справочникТарифовDataGridView.Name = "справочникТарифовDataGridView";
            this.справочникТарифовDataGridView.Size = new System.Drawing.Size(776, 410);
            this.справочникТарифовDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Разряд";
            this.dataGridViewTextBoxColumn1.HeaderText = "Разряд";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тариф";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тариф";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TarifsDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.справочникТарифовDataGridView);
            this.Controls.Add(this.справочникТарифовBindingNavigator);
            this.Name = "TarifsDirectory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник тарифов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TarifsDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовBindingNavigator)).EndInit();
            this.справочникТарифовBindingNavigator.ResumeLayout(false);
            this.справочникТарифовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.справочникТарифовDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource справочникТарифовBindingSource;
        private listWorkersDataSetTableAdapters.СправочникТарифовTableAdapter справочникТарифовTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator справочникТарифовBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton справочникТарифовBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView справочникТарифовDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}