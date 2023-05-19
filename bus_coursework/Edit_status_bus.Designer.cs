namespace bus_coursework.MyClass {
    partial class Edit_status_bus {
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
            System.Windows.Forms.Label индекс_контролераLabel;
            System.Windows.Forms.Label индекс_водителяLabel;
            System.Windows.Forms.Label индекс_автобусного_паркаLabel2;
            System.Windows.Forms.Label индекс_рейсаLabel1;
            System.Windows.Forms.Label год_выпуска_автобусаLabel;
            System.Windows.Forms.Label модель_автобусаLabel;
            System.Windows.Forms.Label марка_автобусаLabel;
            System.Windows.Forms.Label индекс_автобусаLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_status_bus));
            this.индекс_контролераTextBox = new System.Windows.Forms.TextBox();
            this.индекс_водителяTextBox = new System.Windows.Forms.TextBox();
            this.индекс_автобусного_паркаTextBox2 = new System.Windows.Forms.TextBox();
            this.индекс_рейсаTextBox1 = new System.Windows.Forms.TextBox();
            this.год_выпуска_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.модель_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.марка_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.индекс_автобусаTextBox = new System.Windows.Forms.TextBox();
            this.автобусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_dataset = new bus_coursework.bus_dataset();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.автобусTableAdapter = new bus_coursework.bus_datasetTableAdapters.АвтобусTableAdapter();
            this.tableAdapterManager = new bus_coursework.bus_datasetTableAdapters.TableAdapterManager();
            this.автобусBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.автобусDataGridView = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            индекс_контролераLabel = new System.Windows.Forms.Label();
            индекс_водителяLabel = new System.Windows.Forms.Label();
            индекс_автобусного_паркаLabel2 = new System.Windows.Forms.Label();
            индекс_рейсаLabel1 = new System.Windows.Forms.Label();
            год_выпуска_автобусаLabel = new System.Windows.Forms.Label();
            модель_автобусаLabel = new System.Windows.Forms.Label();
            марка_автобусаLabel = new System.Windows.Forms.Label();
            индекс_автобусаLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingNavigator)).BeginInit();
            this.автобусBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автобусDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // индекс_контролераLabel
            // 
            индекс_контролераLabel.AutoSize = true;
            индекс_контролераLabel.Location = new System.Drawing.Point(527, 250);
            индекс_контролераLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            индекс_контролераLabel.Name = "индекс_контролераLabel";
            индекс_контролераLabel.Size = new System.Drawing.Size(104, 16);
            индекс_контролераLabel.TabIndex = 36;
            индекс_контролераLabel.Text = "ID контролера:";
            // 
            // индекс_водителяLabel
            // 
            индекс_водителяLabel.AutoSize = true;
            индекс_водителяLabel.Location = new System.Drawing.Point(543, 218);
            индекс_водителяLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            индекс_водителяLabel.Name = "индекс_водителяLabel";
            индекс_водителяLabel.Size = new System.Drawing.Size(88, 16);
            индекс_водителяLabel.TabIndex = 33;
            индекс_водителяLabel.Text = "ID водителя:";
            // 
            // индекс_автобусного_паркаLabel2
            // 
            индекс_автобусного_паркаLabel2.AutoSize = true;
            индекс_автобусного_паркаLabel2.Location = new System.Drawing.Point(478, 186);
            индекс_автобусного_паркаLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            индекс_автобусного_паркаLabel2.Name = "индекс_автобусного_паркаLabel2";
            индекс_автобусного_паркаLabel2.Size = new System.Drawing.Size(152, 16);
            индекс_автобусного_паркаLabel2.TabIndex = 32;
            индекс_автобусного_паркаLabel2.Text = "ID автобусного парка:";
            // 
            // индекс_рейсаLabel1
            // 
            индекс_рейсаLabel1.AutoSize = true;
            индекс_рейсаLabel1.Location = new System.Drawing.Point(566, 154);
            индекс_рейсаLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            индекс_рейсаLabel1.Name = "индекс_рейсаLabel1";
            индекс_рейсаLabel1.Size = new System.Drawing.Size(65, 16);
            индекс_рейсаLabel1.TabIndex = 30;
            индекс_рейсаLabel1.Text = "ID рейса:";
            // 
            // год_выпуска_автобусаLabel
            // 
            год_выпуска_автобусаLabel.AutoSize = true;
            год_выпуска_автобусаLabel.Location = new System.Drawing.Point(539, 122);
            год_выпуска_автобусаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            год_выпуска_автобусаLabel.Name = "год_выпуска_автобусаLabel";
            год_выпуска_автобусаLabel.Size = new System.Drawing.Size(91, 16);
            год_выпуска_автобусаLabel.TabIndex = 28;
            год_выпуска_автобусаLabel.Text = "Год выпуска:";
            // 
            // модель_автобусаLabel
            // 
            модель_автобусаLabel.AutoSize = true;
            модель_автобусаLabel.Location = new System.Drawing.Point(99, 186);
            модель_автобусаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            модель_автобусаLabel.Name = "модель_автобусаLabel";
            модель_автобусаLabel.Size = new System.Drawing.Size(60, 16);
            модель_автобусаLabel.TabIndex = 26;
            модель_автобусаLabel.Text = "Модель:";
            // 
            // марка_автобусаLabel
            // 
            марка_автобусаLabel.AutoSize = true;
            марка_автобусаLabel.Location = new System.Drawing.Point(107, 154);
            марка_автобусаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            марка_автобусаLabel.Name = "марка_автобусаLabel";
            марка_автобусаLabel.Size = new System.Drawing.Size(52, 16);
            марка_автобусаLabel.TabIndex = 24;
            марка_автобусаLabel.Text = "Марка:";
            // 
            // индекс_автобусаLabel
            // 
            индекс_автобусаLabel.AutoSize = true;
            индекс_автобусаLabel.Location = new System.Drawing.Point(71, 122);
            индекс_автобусаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            индекс_автобусаLabel.Name = "индекс_автобусаLabel";
            индекс_автобусаLabel.Size = new System.Drawing.Size(88, 16);
            индекс_автобусаLabel.TabIndex = 22;
            индекс_автобусаLabel.Text = "ID автобуса:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(978, 156);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 16);
            label1.TabIndex = 45;
            label1.Text = "Статус:";
            // 
            // индекс_контролераTextBox
            // 
            this.индекс_контролераTextBox.Location = new System.Drawing.Point(639, 247);
            this.индекс_контролераTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.индекс_контролераTextBox.Name = "индекс_контролераTextBox";
            this.индекс_контролераTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_контролераTextBox.TabIndex = 37;
            // 
            // индекс_водителяTextBox
            // 
            this.индекс_водителяTextBox.Location = new System.Drawing.Point(639, 215);
            this.индекс_водителяTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.индекс_водителяTextBox.Name = "индекс_водителяTextBox";
            this.индекс_водителяTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_водителяTextBox.TabIndex = 35;
            // 
            // индекс_автобусного_паркаTextBox2
            // 
            this.индекс_автобусного_паркаTextBox2.Location = new System.Drawing.Point(639, 183);
            this.индекс_автобусного_паркаTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.индекс_автобусного_паркаTextBox2.Name = "индекс_автобусного_паркаTextBox2";
            this.индекс_автобусного_паркаTextBox2.Size = new System.Drawing.Size(276, 22);
            this.индекс_автобусного_паркаTextBox2.TabIndex = 34;
            // 
            // индекс_рейсаTextBox1
            // 
            this.индекс_рейсаTextBox1.Location = new System.Drawing.Point(639, 151);
            this.индекс_рейсаTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.индекс_рейсаTextBox1.Name = "индекс_рейсаTextBox1";
            this.индекс_рейсаTextBox1.Size = new System.Drawing.Size(276, 22);
            this.индекс_рейсаTextBox1.TabIndex = 31;
            // 
            // год_выпуска_автобусаTextBox
            // 
            this.год_выпуска_автобусаTextBox.Location = new System.Drawing.Point(639, 119);
            this.год_выпуска_автобусаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.год_выпуска_автобусаTextBox.Name = "год_выпуска_автобусаTextBox";
            this.год_выпуска_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.год_выпуска_автобусаTextBox.TabIndex = 29;
            // 
            // модель_автобусаTextBox
            // 
            this.модель_автобусаTextBox.Location = new System.Drawing.Point(167, 183);
            this.модель_автобусаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.модель_автобусаTextBox.Name = "модель_автобусаTextBox";
            this.модель_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.модель_автобусаTextBox.TabIndex = 27;
            // 
            // марка_автобусаTextBox
            // 
            this.марка_автобусаTextBox.Location = new System.Drawing.Point(167, 151);
            this.марка_автобусаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.марка_автобусаTextBox.Name = "марка_автобусаTextBox";
            this.марка_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.марка_автобусаTextBox.TabIndex = 25;
            // 
            // индекс_автобусаTextBox
            // 
            this.индекс_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусBindingSource, "Индекс_автобуса", true));
            this.индекс_автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bus_dataset, "Автобус.Индекс_автобуса", true));
            this.индекс_автобусаTextBox.Location = new System.Drawing.Point(167, 119);
            this.индекс_автобусаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.индекс_автобусаTextBox.Name = "индекс_автобусаTextBox";
            this.индекс_автобусаTextBox.Size = new System.Drawing.Size(276, 22);
            this.индекс_автобусаTextBox.TabIndex = 23;
            // 
            // автобусBindingSource
            // 
            this.автобусBindingSource.DataMember = "Автобус";
            this.автобусBindingSource.DataSource = this.bus_dataset;
            // 
            // bus_dataset
            // 
            this.bus_dataset.DataSetName = "bus_dataset";
            this.bus_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 42);
            this.label5.TabIndex = 40;
            this.label5.Text = "Автобус";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(32, 31);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1787, 68);
            this.pictureBox3.TabIndex = 41;
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
            // автобусBindingNavigator
            // 
            this.автобусBindingNavigator.AddNewItem = null;
            this.автобусBindingNavigator.BindingSource = this.автобусBindingSource;
            this.автобусBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автобусBindingNavigator.DeleteItem = null;
            this.автобусBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.автобусBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.автобусBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автобусBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автобусBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автобусBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автобусBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автобусBindingNavigator.Name = "автобусBindingNavigator";
            this.автобусBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автобусBindingNavigator.Size = new System.Drawing.Size(1832, 31);
            this.автобусBindingNavigator.TabIndex = 42;
            this.автобусBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Enabled = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 24);
            this.toolStripButton1.Text = "Назад к меню";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // автобусDataGridView
            // 
            this.автобусDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.автобусDataGridView.Location = new System.Drawing.Point(13, 282);
            this.автобусDataGridView.Name = "автобусDataGridView";
            this.автобусDataGridView.RowHeadersWidth = 51;
            this.автобусDataGridView.RowTemplate.Height = 24;
            this.автобусDataGridView.Size = new System.Drawing.Size(1806, 463);
            this.автобусDataGridView.TabIndex = 42;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(981, 183);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(161, 20);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "В автобусном парке";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(981, 209);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 44;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "В пути";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // Edit_status_bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 853);
            this.Controls.Add(label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.автобусDataGridView);
            this.Controls.Add(this.автобусBindingNavigator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(индекс_контролераLabel);
            this.Controls.Add(this.индекс_контролераTextBox);
            this.Controls.Add(индекс_водителяLabel);
            this.Controls.Add(this.индекс_водителяTextBox);
            this.Controls.Add(индекс_автобусного_паркаLabel2);
            this.Controls.Add(this.индекс_автобусного_паркаTextBox2);
            this.Controls.Add(индекс_рейсаLabel1);
            this.Controls.Add(this.индекс_рейсаTextBox1);
            this.Controls.Add(год_выпуска_автобусаLabel);
            this.Controls.Add(this.год_выпуска_автобусаTextBox);
            this.Controls.Add(модель_автобусаLabel);
            this.Controls.Add(this.модель_автобусаTextBox);
            this.Controls.Add(марка_автобусаLabel);
            this.Controls.Add(this.марка_автобусаTextBox);
            this.Controls.Add(индекс_автобусаLabel);
            this.Controls.Add(this.индекс_автобусаTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_status_bus";
            this.Text = "Редактирование статуса автобуса";
            this.Load += new System.EventHandler(this.Edit_status_bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусBindingNavigator)).EndInit();
            this.автобусBindingNavigator.ResumeLayout(false);
            this.автобусBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автобусDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox индекс_контролераTextBox;
        private System.Windows.Forms.TextBox индекс_водителяTextBox;
        private System.Windows.Forms.TextBox индекс_автобусного_паркаTextBox2;
        private System.Windows.Forms.TextBox индекс_рейсаTextBox1;
        private System.Windows.Forms.TextBox год_выпуска_автобусаTextBox;
        private System.Windows.Forms.TextBox модель_автобусаTextBox;
        private System.Windows.Forms.TextBox марка_автобусаTextBox;
        private System.Windows.Forms.TextBox индекс_автобусаTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private bus_dataset bus_dataset;
        private System.Windows.Forms.BindingSource автобусBindingSource;
        private bus_datasetTableAdapters.АвтобусTableAdapter автобусTableAdapter;
        private bus_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автобусBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView автобусDataGridView;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}