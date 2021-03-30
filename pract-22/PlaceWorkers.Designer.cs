namespace pract_22
{
    partial class PlaceWorkers
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
            System.Windows.Forms.Label цехLabel;
            this.Enter = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new pract_22.listWorkersDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.цехComboBox = new System.Windows.Forms.ComboBox();
            this.workersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.списокЦеховBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокЦеховTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СписокЦеховTableAdapter();
            цехLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(12, 91);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(281, 42);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Ввод";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 139);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(281, 42);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // listWorkersDataSet
            // 
            this.listWorkersDataSet.DataSetName = "listWorkersDataSet";
            this.listWorkersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = pract_22.listWorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СписокЦеховTableAdapter = this.списокЦеховTableAdapter;
            this.tableAdapterManager.СправочникРаботниковTableAdapter = null;
            this.tableAdapterManager.СправочникТарифовTableAdapter = null;
            this.tableAdapterManager.ТабельTableAdapter = null;
            // 
            // цехLabel
            // 
            цехLabel.AutoSize = true;
            цехLabel.Location = new System.Drawing.Point(12, 27);
            цехLabel.Name = "цехLabel";
            цехLabel.Size = new System.Drawing.Size(37, 17);
            цехLabel.TabIndex = 3;
            цехLabel.Text = "Цех:";
            // 
            // цехComboBox
            // 
            this.цехComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Цех", true));
            this.цехComboBox.DataSource = this.списокЦеховBindingSource;
            this.цехComboBox.DisplayMember = "НаименованиеЦеха";
            this.цехComboBox.FormattingEnabled = true;
            this.цехComboBox.Location = new System.Drawing.Point(12, 47);
            this.цехComboBox.Name = "цехComboBox";
            this.цехComboBox.Size = new System.Drawing.Size(281, 24);
            this.цехComboBox.TabIndex = 4;
            // 
            // workersBindingSource1
            // 
            this.workersBindingSource1.DataMember = "Workers";
            this.workersBindingSource1.DataSource = this.listWorkersDataSet;
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
            // PlaceWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 201);
            this.ControlBox = false;
            this.Controls.Add(цехLabel);
            this.Controls.Add(this.цехComboBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Enter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlaceWorkers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Укажите цех";
            this.Load += new System.EventHandler(this.PlaceWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Cancel;
        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private listWorkersDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private listWorkersDataSetTableAdapters.СписокЦеховTableAdapter списокЦеховTableAdapter;
        private System.Windows.Forms.ComboBox цехComboBox;
        private System.Windows.Forms.BindingSource workersBindingSource1;
        private System.Windows.Forms.BindingSource списокЦеховBindingSource;
    }
}