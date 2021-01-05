namespace DuplicateFiles
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("C:\\*.*");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("D:\\*.*");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbContent = new System.Windows.Forms.CheckBox();
            this.cbDateChange = new System.Windows.Forms.CheckBox();
            this.cbSize = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numSizeOver = new System.Windows.Forms.NumericUpDown();
            this.numSizeLess = new System.Windows.Forms.NumericUpDown();
            this.cbHidden = new System.Windows.Forms.CheckBox();
            this.cbSystemic = new System.Windows.Forms.CheckBox();
            this.cbSizeOver = new System.Windows.Forms.CheckBox();
            this.cbSizeLess = new System.Windows.Forms.CheckBox();
            this.cbOnlyForReading = new System.Windows.Forms.CheckBox();
            this.cbZeroByteFiles = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTurnOn = new System.Windows.Forms.TabPage();
            this.lvTurnOn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpExclude = new System.Windows.Forms.TabPage();
            this.lvExclude = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeLess)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpTurnOn.SuspendLayout();
            this.tpExclude.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbContent);
            this.groupBox1.Controls.Add(this.cbDateChange);
            this.groupBox1.Controls.Add(this.cbSize);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Критерий поиска";
            // 
            // cbContent
            // 
            this.cbContent.AutoSize = true;
            this.cbContent.Location = new System.Drawing.Point(309, 19);
            this.cbContent.Name = "cbContent";
            this.cbContent.Size = new System.Drawing.Size(91, 17);
            this.cbContent.TabIndex = 3;
            this.cbContent.Text = "Содержимое";
            this.cbContent.UseVisualStyleBackColor = true;
            // 
            // cbDateChange
            // 
            this.cbDateChange.AutoSize = true;
            this.cbDateChange.Checked = true;
            this.cbDateChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDateChange.Location = new System.Drawing.Point(173, 19);
            this.cbDateChange.Name = "cbDateChange";
            this.cbDateChange.Size = new System.Drawing.Size(111, 17);
            this.cbDateChange.TabIndex = 2;
            this.cbDateChange.Text = "Дата изменений";
            this.cbDateChange.UseVisualStyleBackColor = true;
            // 
            // cbSize
            // 
            this.cbSize.AutoSize = true;
            this.cbSize.Checked = true;
            this.cbSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSize.Location = new System.Drawing.Point(80, 19);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(65, 17);
            this.cbSize.TabIndex = 1;
            this.cbSize.Text = "Размер";
            this.cbSize.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Location = new System.Drawing.Point(6, 19);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(48, 17);
            this.cbName.TabIndex = 0;
            this.cbName.Text = "Имя";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheckBox,
            this.chName,
            this.chPath,
            this.chSize,
            this.chCreated});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 70);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 371);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // chCheckBox
            // 
            this.chCheckBox.Text = "";
            this.chCheckBox.Width = 45;
            // 
            // chName
            // 
            this.chName.Text = "Имя";
            this.chName.Width = 160;
            // 
            // chPath
            // 
            this.chPath.Text = "Путь";
            this.chPath.Width = 233;
            // 
            // chSize
            // 
            this.chSize.Text = "Размер";
            this.chSize.Width = 80;
            // 
            // chCreated
            // 
            this.chCreated.Text = "Создано";
            this.chCreated.Width = 136;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.numSizeOver);
            this.groupBox2.Controls.Add(this.numSizeLess);
            this.groupBox2.Controls.Add(this.cbHidden);
            this.groupBox2.Controls.Add(this.cbSystemic);
            this.groupBox2.Controls.Add(this.cbSizeOver);
            this.groupBox2.Controls.Add(this.cbSizeLess);
            this.groupBox2.Controls.Add(this.cbOnlyForReading);
            this.groupBox2.Controls.Add(this.cbZeroByteFiles);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Игнорировать";
            // 
            // numSizeOver
            // 
            this.numSizeOver.Enabled = false;
            this.numSizeOver.Location = new System.Drawing.Point(112, 87);
            this.numSizeOver.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numSizeOver.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSizeOver.Name = "numSizeOver";
            this.numSizeOver.Size = new System.Drawing.Size(75, 20);
            this.numSizeOver.TabIndex = 7;
            this.numSizeOver.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numSizeLess
            // 
            this.numSizeLess.Location = new System.Drawing.Point(112, 64);
            this.numSizeLess.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numSizeLess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSizeLess.Name = "numSizeLess";
            this.numSizeLess.Size = new System.Drawing.Size(75, 20);
            this.numSizeLess.TabIndex = 6;
            this.numSizeLess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbHidden
            // 
            this.cbHidden.AutoSize = true;
            this.cbHidden.Checked = true;
            this.cbHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHidden.Location = new System.Drawing.Point(173, 42);
            this.cbHidden.Name = "cbHidden";
            this.cbHidden.Size = new System.Drawing.Size(72, 17);
            this.cbHidden.TabIndex = 5;
            this.cbHidden.Text = "Скрытые";
            this.cbHidden.UseVisualStyleBackColor = true;
            // 
            // cbSystemic
            // 
            this.cbSystemic.AutoSize = true;
            this.cbSystemic.Checked = true;
            this.cbSystemic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSystemic.Location = new System.Drawing.Point(173, 19);
            this.cbSystemic.Name = "cbSystemic";
            this.cbSystemic.Size = new System.Drawing.Size(84, 17);
            this.cbSystemic.TabIndex = 4;
            this.cbSystemic.Text = "Системные";
            this.cbSystemic.UseVisualStyleBackColor = true;
            // 
            // cbSizeOver
            // 
            this.cbSizeOver.AutoSize = true;
            this.cbSizeOver.Location = new System.Drawing.Point(6, 88);
            this.cbSizeOver.Name = "cbSizeOver";
            this.cbSizeOver.Size = new System.Drawing.Size(98, 17);
            this.cbSizeOver.TabIndex = 3;
            this.cbSizeOver.Text = "Размер более";
            this.cbSizeOver.UseVisualStyleBackColor = true;
            this.cbSizeOver.CheckedChanged += new System.EventHandler(this.cbSizeOver_CheckedChanged);
            // 
            // cbSizeLess
            // 
            this.cbSizeLess.AutoSize = true;
            this.cbSizeLess.Checked = true;
            this.cbSizeLess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSizeLess.Location = new System.Drawing.Point(6, 65);
            this.cbSizeLess.Name = "cbSizeLess";
            this.cbSizeLess.Size = new System.Drawing.Size(100, 17);
            this.cbSizeLess.TabIndex = 2;
            this.cbSizeLess.Text = "Размер менее";
            this.cbSizeLess.UseVisualStyleBackColor = true;
            this.cbSizeLess.CheckedChanged += new System.EventHandler(this.cbSizeLess_CheckedChanged);
            // 
            // cbOnlyForReading
            // 
            this.cbOnlyForReading.AutoSize = true;
            this.cbOnlyForReading.Checked = true;
            this.cbOnlyForReading.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOnlyForReading.Location = new System.Drawing.Point(6, 42);
            this.cbOnlyForReading.Name = "cbOnlyForReading";
            this.cbOnlyForReading.Size = new System.Drawing.Size(121, 17);
            this.cbOnlyForReading.TabIndex = 1;
            this.cbOnlyForReading.Text = "Только для чтения";
            this.cbOnlyForReading.UseVisualStyleBackColor = true;
            // 
            // cbZeroByteFiles
            // 
            this.cbZeroByteFiles.AutoSize = true;
            this.cbZeroByteFiles.Checked = true;
            this.cbZeroByteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZeroByteFiles.Location = new System.Drawing.Point(6, 19);
            this.cbZeroByteFiles.Name = "cbZeroByteFiles";
            this.cbZeroByteFiles.Size = new System.Drawing.Size(160, 17);
            this.cbZeroByteFiles.TabIndex = 0;
            this.cbZeroByteFiles.Text = "Файлы с нулевым байтом";
            this.cbZeroByteFiles.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTurnOn);
            this.tabControl1.Controls.Add(this.tpExclude);
            this.tabControl1.ItemSize = new System.Drawing.Size(285, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 198);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 204);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tpTurnOn
            // 
            this.tpTurnOn.Controls.Add(this.lvTurnOn);
            this.tpTurnOn.Location = new System.Drawing.Point(4, 34);
            this.tpTurnOn.Name = "tpTurnOn";
            this.tpTurnOn.Padding = new System.Windows.Forms.Padding(3);
            this.tpTurnOn.Size = new System.Drawing.Size(565, 166);
            this.tpTurnOn.TabIndex = 0;
            this.tpTurnOn.Text = "Включить";
            this.tpTurnOn.UseVisualStyleBackColor = true;
            // 
            // lvTurnOn
            // 
            this.lvTurnOn.CheckBoxes = true;
            this.lvTurnOn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvTurnOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTurnOn.FullRowSelect = true;
            this.lvTurnOn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTurnOn.HideSelection = false;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            this.lvTurnOn.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvTurnOn.Location = new System.Drawing.Point(3, 3);
            this.lvTurnOn.MultiSelect = false;
            this.lvTurnOn.Name = "lvTurnOn";
            this.lvTurnOn.Size = new System.Drawing.Size(559, 160);
            this.lvTurnOn.TabIndex = 0;
            this.lvTurnOn.UseCompatibleStateImageBehavior = false;
            this.lvTurnOn.View = System.Windows.Forms.View.Details;
            this.lvTurnOn.SelectedIndexChanged += new System.EventHandler(this.lvTurnOn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Диск или папка";
            this.columnHeader1.Width = 552;
            // 
            // tpExclude
            // 
            this.tpExclude.Controls.Add(this.lvExclude);
            this.tpExclude.Location = new System.Drawing.Point(4, 34);
            this.tpExclude.Name = "tpExclude";
            this.tpExclude.Padding = new System.Windows.Forms.Padding(3);
            this.tpExclude.Size = new System.Drawing.Size(565, 166);
            this.tpExclude.TabIndex = 1;
            this.tpExclude.Text = "Исключить";
            this.tpExclude.UseVisualStyleBackColor = true;
            // 
            // lvExclude
            // 
            this.lvExclude.CheckBoxes = true;
            this.lvExclude.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExclude.FullRowSelect = true;
            this.lvExclude.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvExclude.HideSelection = false;
            this.lvExclude.Location = new System.Drawing.Point(3, 3);
            this.lvExclude.MultiSelect = false;
            this.lvExclude.Name = "lvExclude";
            this.lvExclude.Size = new System.Drawing.Size(559, 160);
            this.lvExclude.TabIndex = 1;
            this.lvExclude.UseCompatibleStateImageBehavior = false;
            this.lvExclude.View = System.Windows.Forms.View.Details;
            this.lvExclude.SelectedIndexChanged += new System.EventHandler(this.lvExclude_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Диск или папка";
            this.columnHeader2.Width = 552;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 418);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(503, 418);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(612, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(612, 227);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(612, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(658, 447);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteAll.TabIndex = 12;
            this.btnDeleteAll.Text = "Удалить выбранные";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Visible = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Поиск файлов-дубликатов";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeLess)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpTurnOn.ResumeLayout(false);
            this.tpExclude.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbContent;
        private System.Windows.Forms.CheckBox cbDateChange;
        private System.Windows.Forms.CheckBox cbSize;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numSizeOver;
        private System.Windows.Forms.NumericUpDown numSizeLess;
        private System.Windows.Forms.CheckBox cbHidden;
        private System.Windows.Forms.CheckBox cbSystemic;
        private System.Windows.Forms.CheckBox cbSizeOver;
        private System.Windows.Forms.CheckBox cbSizeLess;
        private System.Windows.Forms.CheckBox cbOnlyForReading;
        private System.Windows.Forms.CheckBox cbZeroByteFiles;
        private System.Windows.Forms.TabPage tpTurnOn;
        private System.Windows.Forms.TabPage tpExclude;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chCheckBox;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chCreated;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ListView lvTurnOn;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.ListView lvExclude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

