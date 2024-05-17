namespace Курсовая_работа_Магазин
{
    partial class Form1
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВКонецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВКонецToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварПоПроизводителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеТовараПередУказанногоТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварПередДругимТоваромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоПроизводителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьТоварывналичииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxExistingId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearchMaker = new System.Windows.Forms.TextBox();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.отобразитьТоварывналичииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem,
            this.удалитьТоварToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВКонецToolStripMenuItem,
            this.добавитьВКонецToolStripMenuItem1,
            this.добавитьТоварПоПроизводителюToolStripMenuItem,
            this.добавлениеТовараПередУказанногоТовараToolStripMenuItem,
            this.добавитьТоварПередДругимТоваромToolStripMenuItem});
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // добавитьВКонецToolStripMenuItem
            // 
            this.добавитьВКонецToolStripMenuItem.Name = "добавитьВКонецToolStripMenuItem";
            this.добавитьВКонецToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.добавитьВКонецToolStripMenuItem.Text = "Добавить в начало";
            this.добавитьВКонецToolStripMenuItem.Click += new System.EventHandler(this.добавитьВКонецToolStripMenuItem_Click);
            // 
            // добавитьВКонецToolStripMenuItem1
            // 
            this.добавитьВКонецToolStripMenuItem1.Name = "добавитьВКонецToolStripMenuItem1";
            this.добавитьВКонецToolStripMenuItem1.Size = new System.Drawing.Size(307, 22);
            this.добавитьВКонецToolStripMenuItem1.Text = "Добавить в конец";
            this.добавитьВКонецToolStripMenuItem1.Click += new System.EventHandler(this.добавитьВКонецToolStripMenuItem1_Click);
            // 
            // добавитьТоварПоПроизводителюToolStripMenuItem
            // 
            this.добавитьТоварПоПроизводителюToolStripMenuItem.Name = "добавитьТоварПоПроизводителюToolStripMenuItem";
            this.добавитьТоварПоПроизводителюToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.добавитьТоварПоПроизводителюToolStripMenuItem.Text = "Добавить товар по производителю";
            this.добавитьТоварПоПроизводителюToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварПоПроизводителюToolStripMenuItem_Click);
            // 
            // добавлениеТовараПередУказанногоТовараToolStripMenuItem
            // 
            this.добавлениеТовараПередУказанногоТовараToolStripMenuItem.Name = "добавлениеТовараПередУказанногоТовараToolStripMenuItem";
            this.добавлениеТовараПередУказанногоТовараToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.добавлениеТовараПередУказанногоТовараToolStripMenuItem.Text = "добавить товар перед указанным товаром";
            this.добавлениеТовараПередУказанногоТовараToolStripMenuItem.Click += new System.EventHandler(this.добавлениеТовараПередУказанногоТовараToolStripMenuItem_Click);
            // 
            // добавитьТоварПередДругимТоваромToolStripMenuItem
            // 
            this.добавитьТоварПередДругимТоваромToolStripMenuItem.Name = "добавитьТоварПередДругимТоваромToolStripMenuItem";
            this.добавитьТоварПередДругимТоваромToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.добавитьТоварПередДругимТоваромToolStripMenuItem.Text = "добавить товар после указанного товара";
            this.добавитьТоварПередДругимТоваромToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварПередДругимТоваромToolStripMenuItem_Click);
            // 
            // удалитьТоварToolStripMenuItem
            // 
            this.удалитьТоварToolStripMenuItem.Name = "удалитьТоварToolStripMenuItem";
            this.удалитьТоварToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.удалитьТоварToolStripMenuItem.Text = "Удалить товар(Купить)";
            this.удалитьТоварToolStripMenuItem.Click += new System.EventHandler(this.удалитьТоварToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоНазваниюToolStripMenuItem,
            this.поискПоПроизводителюToolStripMenuItem});
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.найтиToolStripMenuItem.Text = "Найти";
            // 
            // поискПоНазваниюToolStripMenuItem
            // 
            this.поискПоНазваниюToolStripMenuItem.Name = "поискПоНазваниюToolStripMenuItem";
            this.поискПоНазваниюToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.поискПоНазваниюToolStripMenuItem.Text = "Поиск по названию";
            this.поискПоНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поискПоНазваниюToolStripMenuItem_Click);
            // 
            // поискПоПроизводителюToolStripMenuItem
            // 
            this.поискПоПроизводителюToolStripMenuItem.Name = "поискПоПроизводителюToolStripMenuItem";
            this.поискПоПроизводителюToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.поискПоПроизводителюToolStripMenuItem.Text = "Поиск по производителю";
            this.поискПоПроизводителюToolStripMenuItem.Click += new System.EventHandler(this.поискПоПроизводителюToolStripMenuItem_Click);
            // 
            // отобразитьТоварывналичииToolStripMenuItem
            // 
            this.отобразитьТоварывналичииToolStripMenuItem.Name = "отобразитьТоварывналичииToolStripMenuItem";
            this.отобразитьТоварывналичииToolStripMenuItem.Size = new System.Drawing.Size(186, 20);
            this.отобразитьТоварывналичииToolStripMenuItem.Text = "Отобразить товары в наличии";
            this.отобразитьТоварывналичииToolStripMenuItem.Click += new System.EventHandler(this.отобразитьТоварывналичииToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.year,
            this.maker,
            this.quantity});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(525, 479);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id товара";
            this.id.MinimumWidth = 15;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Название товара";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Категория";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // year
            // 
            this.year.HeaderText = "Год производства";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Width = 80;
            // 
            // maker
            // 
            this.maker.HeaderText = "Производитель";
            this.maker.Name = "maker";
            this.maker.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 91;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxId.Location = new System.Drawing.Point(740, 27);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 23);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(740, 128);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategory.Location = new System.Drawing.Point(740, 93);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 23);
            this.textBoxCategory.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(740, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(545, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(545, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(545, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Категория товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(545, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Год производства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(545, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Производитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(545, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество";
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaker.Location = new System.Drawing.Point(740, 158);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaker.TabIndex = 12;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity.Location = new System.Drawing.Point(740, 196);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantity.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(545, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(392, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id товара, около которго вы хотите добавить новый товар";
            // 
            // textBoxExistingId
            // 
            this.textBoxExistingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExistingId.Location = new System.Drawing.Point(652, 365);
            this.textBoxExistingId.Name = "textBoxExistingId";
            this.textBoxExistingId.Size = new System.Drawing.Size(100, 23);
            this.textBoxExistingId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(878, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Введите название товара для поиска";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchName.Location = new System.Drawing.Point(957, 71);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchName.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(878, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Введите производителя для поиска";
            // 
            // textBoxSearchMaker
            // 
            this.textBoxSearchMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchMaker.Location = new System.Drawing.Point(957, 161);
            this.textBoxSearchMaker.Name = "textBoxSearchMaker";
            this.textBoxSearchMaker.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchMaker.TabIndex = 20;
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 507);
            this.Controls.Add(this.textBoxSearchMaker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxExistingId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxMaker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьТоварывналичииToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.ToolStripMenuItem добавитьВКонецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВКонецToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварПоПроизводителюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеТовараПередУказанногоТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварПередДругимТоваромToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxExistingId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоПроизводителюToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearchMaker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
    }
}

