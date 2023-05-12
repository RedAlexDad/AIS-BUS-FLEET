namespace bus_coursework {
    partial class Search_bus {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label индекс_автобусаLabel;
            System.Windows.Forms.Label статус_автобусаLabel;
            System.Windows.Forms.Label модель_автобусаLabel;
            System.Windows.Forms.Label год_выпуска_автобусаLabel;
            System.Windows.Forms.Label индекс_рейсаLabel;
            System.Windows.Forms.Label индекс_автобусного_паркаLabel;
            System.Windows.Forms.Label индекс_водителяLabel;
            System.Windows.Forms.Label индекс_контролераLabel;
            this.bus_dataset = new bus_coursework.bus_dataset();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.автобусTableAdapter = new bus_coursework.bus_datasetTableAdapters.АвтобусTableAdapter();
            this.tableAdapterManager = new bus_coursework.bus_datasetTableAdapters.TableAdapterManager();
            this.автобусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.марка_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.индекс_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.статус_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.модель_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.год_выпуска_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.индекс_рейсаTextBox = new System.Windows.Forms.TextBox();
            this.индекс_автобусного_паркаTextBox = new System.Windows.Forms.TextBox();
            this.индекс_водителяTextBox = new System.Windows.Forms.TextBox();
            this.индекс_контролераTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            индекс_автобусаLabel = new System.Windows.Forms.Label();
            статус_автобусаLabel = new System.Windows.Forms.Label();
            модель_автобусаLabel = new System.Windows.Forms.Label();
            год_выпуска_автобусаLabel = new System.Windows.Forms.Label();
            индекс_рейсаLabel = new System.Windows.Forms.Label();
            индекс_автобусного_паркаLabel = new System.Windows.Forms.Label();
            индекс_водителяLabel = new System.Windows.Forms.Label();
            индекс_контролераLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bus_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(960, 154);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 16);
            label1.TabIndex = 68;
            label1.Text = "Поиск:";
            // 
            // индекс_автобусаLabel
            // 
            индекс_автобусаLabel.AutoSize = true;
            индекс_автобусаLabel.Location = new System.Drawing.Point(73, 128);
            индекс_автобусаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            индекс_автобусаLabel.Name = "индекс_автобусаLabel";
            индекс_автобусаLabel.Size = new System.Drawing.Size(88, 16);
            индекс_автобусаLabel.TabIndex = 46;
            индекс_автобусаLabel.Text = "ID автобуса:";
            // 
            // статус_автобусаLabel
            // 
            статус_автобусаLabel.AutoSize = true;
            статус_автобусаLabel.Location = new System.Drawing.Point(502, 213);
            статус_автобусаLabel.Name = "статус_автобусаLabel";
            статус_автобусаLabel.Size = new System.Drawing.Size(121, 16);
            статус_автобусаLabel.TabIndex = 70;
            статус_автобусаLabel.Text = "Статус автобуса:";
            // 
            // bus_dataset
            // 
            this.bus_dataset.DataSetName = "bus_dataset";
            this.bus_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(13, 37);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1208, 68);
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // автобусTableAdapter
            // 
            this.автобусTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DB_UsersTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bus_coursework.bus_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Автобус_ПереключательTableAdapter = null;
            this.tableAdapterManager.АвтобусTableAdapter = this.автобусTableAdapter;
            this.tableAdapterManager.Автобусный_паркTableAdapter = null;
            this.tableAdapterManager.ВодительTableAdapter = null;
            this.tableAdapterManager.КонтролерTableAdapter = null;
            this.tableAdapterManager.ПассажирTableAdapter = null;
            this.tableAdapterManager.Резерв_Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.РейсTableAdapter = null;
            this.tableAdapterManager.РуководительTableAdapter = null;
            // 
            // автобусBindingSource
            // 
            this.автобусBindingSource.DataMember = "Автобус";
            this.автобусBindingSource.DataSource = this.bus_dataset;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 42);
            this.label5.TabIndex = 62;
            this.label5.Text = "Автобус";
            // 
            // марка_автобусаTextBox
            // 
            this.марка_автобусаTextBox.Location = new System.Drawing.Point(1015, 151);
            this.марка_автобусаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.марка_автобусаTextBox.Name = "марка_автобусаTextBox";
            this.марка_автобусаTextBox.Size = new System.Drawing.Size(149, 22);
            this.марка_автобусаTextBox.TabIndex = 49;
            this.марка_автобусаTextBox.TextChanged += new System.EventHandler(this.марка_автобусаTextBox_TextChanged);
            // 
            // индекс_автобусаTextBox
            // 
            this.индекс_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Индекс_автобуса", true));
            this.индекс_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bus_dataset, "Автобус.Индекс_автобуса", true));
            this.индекс_автобусаTextBox.Location = new System.Drawing.Point(167, 125);
            this.индекс_автобусаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.индекс_автобусаTextBox.Name = "индекс_автобусаTextBox";
            this.индекс_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_автобусаTextBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 42);
            this.label2.TabIndex = 69;
            this.label2.Text = "Поиск автобус по названию марки";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 256);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1227, 489);
            this.dataGridView.TabIndex = 70;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // статус_автобусаTextBox
            // 
            this.статус_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Статус_автобуса", true));
            this.статус_автобусаTextBox.Location = new System.Drawing.Point(629, 210);
            this.статус_автобусаTextBox.Name = "статус_автобусаTextBox";
            this.статус_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.статус_автобусаTextBox.TabIndex = 71;
            // 
            // модель_автобусаLabel
            // 
            модель_автобусаLabel.AutoSize = true;
            модель_автобусаLabel.Location = new System.Drawing.Point(101, 157);
            модель_автобусаLabel.Name = "модель_автобусаLabel";
            модель_автобусаLabel.Size = new System.Drawing.Size(60, 16);
            модель_автобусаLabel.TabIndex = 72;
            модель_автобусаLabel.Text = "Модель:";
            // 
            // модель_автобусаTextBox
            // 
            this.модель_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Модель_автобуса", true));
            this.модель_автобусаTextBox.Location = new System.Drawing.Point(167, 154);
            this.модель_автобусаTextBox.Name = "модель_автобусаTextBox";
            this.модель_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.модель_автобусаTextBox.TabIndex = 73;
            // 
            // год_выпуска_автобусаLabel
            // 
            год_выпуска_автобусаLabel.AutoSize = true;
            год_выпуска_автобусаLabel.Location = new System.Drawing.Point(70, 185);
            год_выпуска_автобусаLabel.Name = "год_выпуска_автобусаLabel";
            год_выпуска_автобусаLabel.Size = new System.Drawing.Size(91, 16);
            год_выпуска_автобусаLabel.TabIndex = 73;
            год_выпуска_автобусаLabel.Text = "Год выпуска:";
            // 
            // год_выпуска_автобусаTextBox
            // 
            this.год_выпуска_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Год_выпуска_автобуса", true));
            this.год_выпуска_автобусаTextBox.Location = new System.Drawing.Point(167, 182);
            this.год_выпуска_автобусаTextBox.Name = "год_выпуска_автобусаTextBox";
            this.год_выпуска_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.год_выпуска_автобусаTextBox.TabIndex = 74;
            // 
            // индекс_рейсаLabel
            // 
            индекс_рейсаLabel.AutoSize = true;
            индекс_рейсаLabel.Location = new System.Drawing.Point(61, 213);
            индекс_рейсаLabel.Name = "индекс_рейсаLabel";
            индекс_рейсаLabel.Size = new System.Drawing.Size(100, 16);
            индекс_рейсаLabel.TabIndex = 74;
            индекс_рейсаLabel.Text = "Индекс рейса:";
            // 
            // индекс_рейсаTextBox
            // 
            this.индекс_рейсаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Индекс_рейса", true));
            this.индекс_рейсаTextBox.Location = new System.Drawing.Point(167, 210);
            this.индекс_рейсаTextBox.Name = "индекс_рейсаTextBox";
            this.индекс_рейсаTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_рейсаTextBox.TabIndex = 75;
            // 
            // индекс_автобусного_паркаLabel
            // 
            индекс_автобусного_паркаLabel.AutoSize = true;
            индекс_автобусного_паркаLabel.Location = new System.Drawing.Point(471, 128);
            индекс_автобусного_паркаLabel.Name = "индекс_автобусного_паркаLabel";
            индекс_автобусного_паркаLabel.Size = new System.Drawing.Size(152, 16);
            индекс_автобусного_паркаLabel.TabIndex = 75;
            индекс_автобусного_паркаLabel.Text = "ID автобусного парка:";
            // 
            // индекс_автобусного_паркаTextBox
            // 
            this.индекс_автобусного_паркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Индекс_автобусного_парка", true));
            this.индекс_автобусного_паркаTextBox.Location = new System.Drawing.Point(629, 125);
            this.индекс_автобусного_паркаTextBox.Name = "индекс_автобусного_паркаTextBox";
            this.индекс_автобусного_паркаTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_автобусного_паркаTextBox.TabIndex = 76;
            // 
            // индекс_водителяLabel
            // 
            индекс_водителяLabel.AutoSize = true;
            индекс_водителяLabel.Location = new System.Drawing.Point(517, 157);
            индекс_водителяLabel.Name = "индекс_водителяLabel";
            индекс_водителяLabel.Size = new System.Drawing.Size(106, 16);
            индекс_водителяLabel.TabIndex = 76;
            индекс_водителяLabel.Text = "ФИО водителя:";
            // 
            // индекс_водителяTextBox
            // 
            this.индекс_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Индекс_водителя", true));
            this.индекс_водителяTextBox.Location = new System.Drawing.Point(629, 154);
            this.индекс_водителяTextBox.Name = "индекс_водителяTextBox";
            this.индекс_водителяTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_водителяTextBox.TabIndex = 77;
            // 
            // индекс_контролераLabel
            // 
            индекс_контролераLabel.AutoSize = true;
            индекс_контролераLabel.Location = new System.Drawing.Point(501, 185);
            индекс_контролераLabel.Name = "индекс_контролераLabel";
            индекс_контролераLabel.Size = new System.Drawing.Size(122, 16);
            индекс_контролераLabel.TabIndex = 77;
            индекс_контролераLabel.Text = "ФИО контролера:";
            // 
            // индекс_контролераTextBox
            // 
            this.индекс_контролераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Индекс_контролера", true));
            this.индекс_контролераTextBox.Location = new System.Drawing.Point(629, 182);
            this.индекс_контролераTextBox.Name = "индекс_контролераTextBox";
            this.индекс_контролераTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_контролераTextBox.TabIndex = 78;
            // 
            // Search_bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 765);
            this.Controls.Add(индекс_контролераLabel);
            this.Controls.Add(this.индекс_контролераTextBox);
            this.Controls.Add(индекс_водителяLabel);
            this.Controls.Add(this.индекс_водителяTextBox);
            this.Controls.Add(индекс_автобусного_паркаLabel);
            this.Controls.Add(this.индекс_автобусного_паркаTextBox);
            this.Controls.Add(индекс_рейсаLabel);
            this.Controls.Add(this.индекс_рейсаTextBox);
            this.Controls.Add(год_выпуска_автобусаLabel);
            this.Controls.Add(this.год_выпуска_автобусаTextBox);
            this.Controls.Add(модель_автобусаLabel);
            this.Controls.Add(this.модель_автобусаTextBox);
            this.Controls.Add(статус_автобусаLabel);
            this.Controls.Add(this.статус_автобусаTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(label1);
            this.Controls.Add(this.марка_автобусаTextBox);
            this.Controls.Add(индекс_автобусаLabel);
            this.Controls.Add(this.индекс_автобусаTextBox);
            this.Name = "Search_bus";
            this.Text = "Search_bus";
            this.Load += new System.EventHandler(this.Search_bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bus_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bus_dataset bus_dataset;
        private System.Windows.Forms.PictureBox pictureBox3;
        private bus_datasetTableAdapters.АвтобусTableAdapter автобусTableAdapter;
        private bus_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource автобусBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox марка_автобусаTextBox;
        private System.Windows.Forms.TextBox индекс_автобусаTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox статус_автобусаTextBox;
        private System.Windows.Forms.TextBox модель_автобусаTextBox;
        private System.Windows.Forms.TextBox год_выпуска_автобусаTextBox;
        private System.Windows.Forms.TextBox индекс_рейсаTextBox;
        private System.Windows.Forms.TextBox индекс_автобусного_паркаTextBox;
        private System.Windows.Forms.TextBox индекс_водителяTextBox;
        private System.Windows.Forms.TextBox индекс_контролераTextBox;
    }
}