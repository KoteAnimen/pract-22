namespace pract_22
{
    partial class AddPlace
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
            System.Windows.Forms.Label наименованиеЦехаLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.listWorkersDataSet = new pract_22.listWorkersDataSet();
            this.списокЦеховBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокЦеховTableAdapter = new pract_22.listWorkersDataSetTableAdapters.СписокЦеховTableAdapter();
            this.tableAdapterManager = new pract_22.listWorkersDataSetTableAdapters.TableAdapterManager();
            this.цехTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеЦехаTextBox = new System.Windows.Forms.TextBox();
            цехLabel = new System.Windows.Forms.Label();
            наименованиеЦехаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(наименованиеЦехаLabel);
            this.groupBox1.Controls.Add(this.наименованиеЦехаTextBox);
            this.groupBox1.Controls.Add(цехLabel);
            this.groupBox1.Controls.Add(this.цехTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(368, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цех";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(17, 130);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(157, 41);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(228, 130);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(157, 41);
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
            // списокЦеховBindingSource
            // 
            this.списокЦеховBindingSource.DataMember = "СписокЦехов";
            this.списокЦеховBindingSource.DataSource = this.listWorkersDataSet;
            // 
            // списокЦеховTableAdapter
            // 
            this.списокЦеховTableAdapter.ClearBeforeFill = true;
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
            цехLabel.Location = new System.Drawing.Point(126, 26);
            цехLabel.Name = "цехLabel";
            цехLabel.Size = new System.Drawing.Size(37, 17);
            цехLabel.TabIndex = 0;
            цехLabel.Text = "Цех:";
            // 
            // цехTextBox
            // 
            this.цехTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокЦеховBindingSource, "Цех", true));
            this.цехTextBox.Location = new System.Drawing.Point(169, 23);
            this.цехTextBox.Name = "цехTextBox";
            this.цехTextBox.Size = new System.Drawing.Size(156, 23);
            this.цехTextBox.TabIndex = 1;
            // 
            // наименованиеЦехаLabel
            // 
            наименованиеЦехаLabel.AutoSize = true;
            наименованиеЦехаLabel.Location = new System.Drawing.Point(16, 64);
            наименованиеЦехаLabel.Name = "наименованиеЦехаLabel";
            наименованиеЦехаLabel.Size = new System.Drawing.Size(144, 17);
            наименованиеЦехаLabel.TabIndex = 2;
            наименованиеЦехаLabel.Text = "Наименование цеха:";
            // 
            // наименованиеЦехаTextBox
            // 
            this.наименованиеЦехаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.списокЦеховBindingSource, "НаименованиеЦеха", true));
            this.наименованиеЦехаTextBox.Location = new System.Drawing.Point(169, 61);
            this.наименованиеЦехаTextBox.Name = "наименованиеЦехаTextBox";
            this.наименованиеЦехаTextBox.Size = new System.Drawing.Size(156, 23);
            this.наименованиеЦехаTextBox.TabIndex = 3;
            // 
            // AddPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 187);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить цех";
            this.Load += new System.EventHandler(this.AddPlace_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listWorkersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЦеховBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Cancel;
        private listWorkersDataSet listWorkersDataSet;
        private System.Windows.Forms.BindingSource списокЦеховBindingSource;
        private listWorkersDataSetTableAdapters.СписокЦеховTableAdapter списокЦеховTableAdapter;
        private listWorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox цехTextBox;
        private System.Windows.Forms.TextBox наименованиеЦехаTextBox;
    }
}