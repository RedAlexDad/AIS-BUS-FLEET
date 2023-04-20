namespace bus_coursework
{
    partial class Edit_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_DB));
            System.Windows.Forms.Label индекс_автобусного_паркаLabel;
            System.Windows.Forms.Label название_автобусного_паркаLabel;
            System.Windows.Forms.Label адрес_автобусного_паркаLabel;
            System.Windows.Forms.Label индекс_руководителяLabel;
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bus_dataset = new bus_coursework.bus_dataset();
            this.автобусный_паркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автобусный_паркTableAdapter = new bus_coursework.bus_datasetTableAdapters.Автобусный_паркTableAdapter();
            this.tableAdapterManager = new bus_coursework.bus_datasetTableAdapters.TableAdapterManager();
            this.автобусный_паркBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.автобусный_паркBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.индекс_автобусного_паркаTextBox = new System.Windows.Forms.TextBox();
            this.название_автобусного_паркаTextBox = new System.Windows.Forms.TextBox();
            this.адрес_автобусного_паркаTextBox = new System.Windows.Forms.TextBox();
            this.индекс_руководителяTextBox = new System.Windows.Forms.TextBox();
            this.рейсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсTableAdapter = new bus_coursework.bus_datasetTableAdapters.РейсTableAdapter();
            this.рейсDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            индекс_автобусного_паркаLabel = new System.Windows.Forms.Label();
            название_автобусного_паркаLabel = new System.Windows.Forms.Label();
            адрес_автобусного_паркаLabel = new System.Windows.Forms.Label();
            индекс_руководителяLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусный_паркBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусный_паркBindingNavigator)).BeginInit();
            this.автобусный_паркBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 629);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.рейсDataGridView);
            this.tabPage1.Controls.Add(индекс_руководителяLabel);
            this.tabPage1.Controls.Add(this.индекс_руководителяTextBox);
            this.tabPage1.Controls.Add(адрес_автобусного_паркаLabel);
            this.tabPage1.Controls.Add(this.адрес_автобусного_паркаTextBox);
            this.tabPage1.Controls.Add(название_автобусного_паркаLabel);
            this.tabPage1.Controls.Add(this.название_автобусного_паркаTextBox);
            this.tabPage1.Controls.Add(индекс_автобусного_паркаLabel);
            this.tabPage1.Controls.Add(this.индекс_автобусного_паркаTextBox);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1153, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автобусный парк";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1052, 9);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "b";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1099, 9);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 37);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(379, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 37);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(331, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 37);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(284, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автобусный парк";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1153, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рейс";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1153, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Автобус";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(426, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 37);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 55);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bus_dataset
            // 
            this.bus_dataset.DataSetName = "bus_dataset";
            this.bus_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автобусный_паркBindingSource
            // 
            this.автобусный_паркBindingSource.DataMember = "Автобусный парк";
            this.автобусный_паркBindingSource.DataSource = this.bus_dataset;
            // 
            // автобусный_паркTableAdapter
            // 
            this.автобусный_паркTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DB_UsersTableAdapter = null;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = bus_coursework.bus_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Автобус_ПереключательTableAdapter = null;
            this.tableAdapterManager.АвтобусTableAdapter = null;
            this.tableAdapterManager.Автобусный_паркTableAdapter = this.автобусный_паркTableAdapter;
            this.tableAdapterManager.ВодительTableAdapter = null;
            this.tableAdapterManager.КонтролерTableAdapter = null;
            this.tableAdapterManager.ПассажирTableAdapter = null;
            this.tableAdapterManager.Резерв_Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.РейсTableAdapter = this.рейсTableAdapter;
            this.tableAdapterManager.РуководительTableAdapter = null;
            // 
            // автобусный_паркBindingNavigator
            // 
            this.автобусный_паркBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автобусный_паркBindingNavigator.BindingSource = this.автобусный_паркBindingSource;
            this.автобусный_паркBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автобусный_паркBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автобусный_паркBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.автобусный_паркBindingNavigatorSaveItem});
            this.автобусный_паркBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автобусный_паркBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автобусный_паркBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автобусный_паркBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автобусный_паркBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автобусный_паркBindingNavigator.Name = "автобусный_паркBindingNavigator";
            this.автобусный_паркBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автобусный_паркBindingNavigator.Size = new System.Drawing.Size(1181, 25);
            this.автобусный_паркBindingNavigator.TabIndex = 2;
            this.автобусный_паркBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
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
            // автобусный_паркBindingNavigatorSaveItem
            // 
            this.автобусный_паркBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автобусный_паркBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автобусный_паркBindingNavigatorSaveItem.Image")));
            this.автобусный_паркBindingNavigatorSaveItem.Name = "автобусный_паркBindingNavigatorSaveItem";
            this.автобусный_паркBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.автобусный_паркBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.автобусный_паркBindingNavigatorSaveItem.Click += new System.EventHandler(this.автобусный_паркBindingNavigatorSaveItem_Click);
            // 
            // индекс_автобусного_паркаLabel
            // 
            индекс_автобусного_паркаLabel.AutoSize = true;
            индекс_автобусного_паркаLabel.Location = new System.Drawing.Point(27, 89);
            индекс_автобусного_паркаLabel.Name = "индекс_автобусного_паркаLabel";
            индекс_автобусного_паркаLabel.Size = new System.Drawing.Size(111, 13);
            индекс_автобусного_паркаLabel.TabIndex = 8;
            индекс_автобусного_паркаLabel.Text = "ID автобусный парк:";
            индекс_автобусного_паркаLabel.Click += new System.EventHandler(this.индекс_автобусного_паркаLabel_Click);
            // 
            // индекс_автобусного_паркаTextBox
            // 
            this.индекс_автобусного_паркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусный_паркBindingSource, "Индекс_автобусного_парка", true));
            this.индекс_автобусного_паркаTextBox.Location = new System.Drawing.Point(144, 86);
            this.индекс_автобусного_паркаTextBox.Name = "индекс_автобусного_паркаTextBox";
            this.индекс_автобусного_паркаTextBox.Size = new System.Drawing.Size(325, 20);
            this.индекс_автобусного_паркаTextBox.TabIndex = 9;
            this.индекс_автобусного_паркаTextBox.TextChanged += new System.EventHandler(this.индекс_автобусного_паркаTextBox_TextChanged);
            // 
            // название_автобусного_паркаLabel
            // 
            название_автобусного_паркаLabel.AutoSize = true;
            название_автобусного_паркаLabel.Location = new System.Drawing.Point(78, 115);
            название_автобусного_паркаLabel.Name = "название_автобусного_паркаLabel";
            название_автобусного_паркаLabel.Size = new System.Drawing.Size(60, 13);
            название_автобусного_паркаLabel.TabIndex = 10;
            название_автобусного_паркаLabel.Text = "Название:";
            // 
            // название_автобусного_паркаTextBox
            // 
            this.название_автобусного_паркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусный_паркBindingSource, "Название_автобусного_парка", true));
            this.название_автобусного_паркаTextBox.Location = new System.Drawing.Point(144, 112);
            this.название_автобусного_паркаTextBox.Name = "название_автобусного_паркаTextBox";
            this.название_автобусного_паркаTextBox.Size = new System.Drawing.Size(325, 20);
            this.название_автобусного_паркаTextBox.TabIndex = 11;
            // 
            // адрес_автобусного_паркаLabel
            // 
            адрес_автобусного_паркаLabel.AutoSize = true;
            адрес_автобусного_паркаLabel.Location = new System.Drawing.Point(97, 141);
            адрес_автобусного_паркаLabel.Name = "адрес_автобусного_паркаLabel";
            адрес_автобусного_паркаLabel.Size = new System.Drawing.Size(41, 13);
            адрес_автобусного_паркаLabel.TabIndex = 12;
            адрес_автобусного_паркаLabel.Text = "Адрес:";
            // 
            // адрес_автобусного_паркаTextBox
            // 
            this.адрес_автобусного_паркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусный_паркBindingSource, "Адрес_автобусного парка", true));
            this.адрес_автобусного_паркаTextBox.Location = new System.Drawing.Point(144, 138);
            this.адрес_автобусного_паркаTextBox.Name = "адрес_автобусного_паркаTextBox";
            this.адрес_автобусного_паркаTextBox.Size = new System.Drawing.Size(325, 20);
            this.адрес_автобусного_паркаTextBox.TabIndex = 13;
            // 
            // индекс_руководителяLabel
            // 
            индекс_руководителяLabel.AutoSize = true;
            индекс_руководителяLabel.Location = new System.Drawing.Point(44, 167);
            индекс_руководителяLabel.Name = "индекс_руководителяLabel";
            индекс_руководителяLabel.Size = new System.Drawing.Size(94, 13);
            индекс_руководителяLabel.TabIndex = 14;
            индекс_руководителяLabel.Text = "ID руководитель:";
            // 
            // индекс_руководителяTextBox
            // 
            this.индекс_руководителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автобусный_паркBindingSource, "Индекс_руководителя", true));
            this.индекс_руководителяTextBox.Location = new System.Drawing.Point(144, 164);
            this.индекс_руководителяTextBox.Name = "индекс_руководителяTextBox";
            this.индекс_руководителяTextBox.Size = new System.Drawing.Size(325, 20);
            this.индекс_руководителяTextBox.TabIndex = 15;
            // 
            // рейсBindingSource
            // 
            this.рейсBindingSource.DataMember = "Рейс";
            this.рейсBindingSource.DataSource = this.bus_dataset;
            // 
            // рейсTableAdapter
            // 
            this.рейсTableAdapter.ClearBeforeFill = true;
            // 
            // рейсDataGridView
            // 
            this.рейсDataGridView.AutoGenerateColumns = false;
            this.рейсDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рейсDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.рейсDataGridView.DataSource = this.рейсBindingSource;
            this.рейсDataGridView.Location = new System.Drawing.Point(23, 246);
            this.рейсDataGridView.Name = "рейсDataGridView";
            this.рейсDataGridView.Size = new System.Drawing.Size(1117, 341);
            this.рейсDataGridView.TabIndex = 16;
            this.рейсDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.рейсDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Индекс_рейса";
            this.dataGridViewTextBoxColumn1.HeaderText = "Индекс_рейса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер рейса";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер рейса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Откуда";
            this.dataGridViewTextBoxColumn3.HeaderText = "Откуда";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Куда";
            this.dataGridViewTextBoxColumn4.HeaderText = "Куда";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Отправление";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отправление";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Прибытие";
            this.dataGridViewTextBoxColumn6.HeaderText = "Прибытие";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Стоимость_проезда";
            this.dataGridViewTextBoxColumn7.HeaderText = "Стоимость_проезда";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Индекс_автобусного_парка";
            this.dataGridViewTextBoxColumn8.HeaderText = "Индекс_автобусного_парка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Рейс:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(605, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Edit_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 648);
            this.Controls.Add(this.автобусный_паркBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Edit_DB";
            this.Text = "Редактирование базы данных";
            this.Load += new System.EventHandler(this.Edit_DB_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bus_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусный_паркBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автобусный_паркBindingNavigator)).EndInit();
            this.автобусный_паркBindingNavigator.ResumeLayout(false);
            this.автобусный_паркBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private bus_dataset bus_dataset;
        private System.Windows.Forms.BindingSource автобусный_паркBindingSource;
        private bus_datasetTableAdapters.Автобусный_паркTableAdapter автобусный_паркTableAdapter;
        private bus_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автобусный_паркBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton автобусный_паркBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox индекс_автобусного_паркаTextBox;
        private System.Windows.Forms.TextBox название_автобусного_паркаTextBox;
        private System.Windows.Forms.TextBox индекс_руководителяTextBox;
        private System.Windows.Forms.TextBox адрес_автобусного_паркаTextBox;
        private bus_datasetTableAdapters.РейсTableAdapter рейсTableAdapter;
        private System.Windows.Forms.BindingSource рейсBindingSource;
        private System.Windows.Forms.DataGridView рейсDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}