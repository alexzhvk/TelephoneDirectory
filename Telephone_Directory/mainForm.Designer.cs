namespace Telephone_Directory
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deleteFiltersBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.propertyLabel1 = new System.Windows.Forms.Label();
            this.propertyLabel2 = new System.Windows.Forms.Label();
            this.propertyLabel3 = new System.Windows.Forms.Label();
            this.propertyLabel4 = new System.Windows.Forms.Label();
            this.propTextBox1 = new System.Windows.Forms.TextBox();
            this.propTextBox2 = new System.Windows.Forms.TextBox();
            this.propTextBox3 = new System.Windows.Forms.TextBox();
            this.propTextBox4 = new System.Windows.Forms.TextBox();
            this.propTextBox7 = new System.Windows.Forms.TextBox();
            this.propTextBox6 = new System.Windows.Forms.TextBox();
            this.propTextBox5 = new System.Windows.Forms.TextBox();
            this.propertyLabel7 = new System.Windows.Forms.Label();
            this.propertyLabel6 = new System.Windows.Forms.Label();
            this.propertyLabel5 = new System.Windows.Forms.Label();
            this.tipsStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripTips = new System.Windows.Forms.ToolStripStatusLabel();
            this.importBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.connectionsTableBtn = new System.Windows.Forms.Button();
            this.operatorsTableBtn = new System.Windows.Forms.Button();
            this.subscribersTableBtn = new System.Windows.Forms.Button();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tipsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Niagara Solid", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(22, 701);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(850, 63);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitBtn, "RU: выход");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteFiltersBtn
            // 
            this.deleteFiltersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteFiltersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFiltersBtn.Font = new System.Drawing.Font("Niagara Solid", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFiltersBtn.Location = new System.Drawing.Point(1214, 701);
            this.deleteFiltersBtn.Name = "deleteFiltersBtn";
            this.deleteFiltersBtn.Size = new System.Drawing.Size(298, 63);
            this.deleteFiltersBtn.TabIndex = 18;
            this.deleteFiltersBtn.Text = "Delete filters";
            this.toolTip1.SetToolTip(this.deleteFiltersBtn, "RU: выход");
            this.deleteFiltersBtn.UseVisualStyleBackColor = true;
            this.deleteFiltersBtn.Click += new System.EventHandler(this.deleteFiltersBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Niagara Solid", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.Location = new System.Drawing.Point(897, 701);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(298, 63);
            this.filterBtn.TabIndex = 19;
            this.filterBtn.Text = "Search";
            this.toolTip1.SetToolTip(this.filterBtn, "RU: выход");
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // propertyLabel1
            // 
            this.propertyLabel1.AutoSize = true;
            this.propertyLabel1.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel1.Location = new System.Drawing.Point(897, 546);
            this.propertyLabel1.Name = "propertyLabel1";
            this.propertyLabel1.Size = new System.Drawing.Size(51, 29);
            this.propertyLabel1.TabIndex = 12;
            this.propertyLabel1.Text = "prop1:";
            // 
            // propertyLabel2
            // 
            this.propertyLabel2.AutoSize = true;
            this.propertyLabel2.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel2.Location = new System.Drawing.Point(896, 581);
            this.propertyLabel2.Name = "propertyLabel2";
            this.propertyLabel2.Size = new System.Drawing.Size(55, 29);
            this.propertyLabel2.TabIndex = 13;
            this.propertyLabel2.Text = "prop2:";
            // 
            // propertyLabel3
            // 
            this.propertyLabel3.AutoSize = true;
            this.propertyLabel3.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel3.Location = new System.Drawing.Point(897, 619);
            this.propertyLabel3.Name = "propertyLabel3";
            this.propertyLabel3.Size = new System.Drawing.Size(55, 29);
            this.propertyLabel3.TabIndex = 14;
            this.propertyLabel3.Text = "prop3:";
            // 
            // propertyLabel4
            // 
            this.propertyLabel4.AutoSize = true;
            this.propertyLabel4.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel4.Location = new System.Drawing.Point(897, 653);
            this.propertyLabel4.Name = "propertyLabel4";
            this.propertyLabel4.Size = new System.Drawing.Size(54, 29);
            this.propertyLabel4.TabIndex = 15;
            this.propertyLabel4.Text = "prop4:";
            // 
            // propTextBox1
            // 
            this.propTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox1.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox1.Location = new System.Drawing.Point(966, 545);
            this.propTextBox1.Multiline = true;
            this.propTextBox1.Name = "propTextBox1";
            this.propTextBox1.Size = new System.Drawing.Size(229, 30);
            this.propTextBox1.TabIndex = 16;
            // 
            // propTextBox2
            // 
            this.propTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox2.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox2.Location = new System.Drawing.Point(966, 582);
            this.propTextBox2.Multiline = true;
            this.propTextBox2.Name = "propTextBox2";
            this.propTextBox2.Size = new System.Drawing.Size(229, 30);
            this.propTextBox2.TabIndex = 20;
            // 
            // propTextBox3
            // 
            this.propTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox3.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox3.Location = new System.Drawing.Point(966, 618);
            this.propTextBox3.Multiline = true;
            this.propTextBox3.Name = "propTextBox3";
            this.propTextBox3.Size = new System.Drawing.Size(229, 30);
            this.propTextBox3.TabIndex = 21;
            // 
            // propTextBox4
            // 
            this.propTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox4.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox4.Location = new System.Drawing.Point(966, 654);
            this.propTextBox4.Multiline = true;
            this.propTextBox4.Name = "propTextBox4";
            this.propTextBox4.Size = new System.Drawing.Size(229, 30);
            this.propTextBox4.TabIndex = 22;
            // 
            // propTextBox7
            // 
            this.propTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox7.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox7.Location = new System.Drawing.Point(1283, 618);
            this.propTextBox7.Multiline = true;
            this.propTextBox7.Name = "propTextBox7";
            this.propTextBox7.Size = new System.Drawing.Size(229, 30);
            this.propTextBox7.TabIndex = 29;
            // 
            // propTextBox6
            // 
            this.propTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox6.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox6.Location = new System.Drawing.Point(1283, 582);
            this.propTextBox6.Multiline = true;
            this.propTextBox6.Name = "propTextBox6";
            this.propTextBox6.Size = new System.Drawing.Size(229, 30);
            this.propTextBox6.TabIndex = 28;
            // 
            // propTextBox5
            // 
            this.propTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propTextBox5.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propTextBox5.Location = new System.Drawing.Point(1283, 545);
            this.propTextBox5.Multiline = true;
            this.propTextBox5.Name = "propTextBox5";
            this.propTextBox5.Size = new System.Drawing.Size(229, 30);
            this.propTextBox5.TabIndex = 27;
            // 
            // propertyLabel7
            // 
            this.propertyLabel7.AutoSize = true;
            this.propertyLabel7.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel7.Location = new System.Drawing.Point(1217, 621);
            this.propertyLabel7.Name = "propertyLabel7";
            this.propertyLabel7.Size = new System.Drawing.Size(54, 29);
            this.propertyLabel7.TabIndex = 25;
            this.propertyLabel7.Text = "prop7:";
            // 
            // propertyLabel6
            // 
            this.propertyLabel6.AutoSize = true;
            this.propertyLabel6.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel6.Location = new System.Drawing.Point(1216, 583);
            this.propertyLabel6.Name = "propertyLabel6";
            this.propertyLabel6.Size = new System.Drawing.Size(55, 29);
            this.propertyLabel6.TabIndex = 24;
            this.propertyLabel6.Text = "prop6:";
            // 
            // propertyLabel5
            // 
            this.propertyLabel5.AutoSize = true;
            this.propertyLabel5.Font = new System.Drawing.Font("Niagara Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyLabel5.Location = new System.Drawing.Point(1215, 546);
            this.propertyLabel5.Name = "propertyLabel5";
            this.propertyLabel5.Size = new System.Drawing.Size(55, 29);
            this.propertyLabel5.TabIndex = 23;
            this.propertyLabel5.Text = "prop5:";
            // 
            // tipsStrip
            // 
            this.tipsStrip.BackColor = System.Drawing.Color.Honeydew;
            this.tipsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTips});
            this.tipsStrip.Location = new System.Drawing.Point(0, 767);
            this.tipsStrip.Name = "tipsStrip";
            this.tipsStrip.Size = new System.Drawing.Size(1524, 22);
            this.tipsStrip.TabIndex = 30;
            this.tipsStrip.Text = "statusStrip1";
            // 
            // toolStripTips
            // 
            this.toolStripTips.Name = "toolStripTips";
            this.toolStripTips.Size = new System.Drawing.Size(118, 17);
            this.toolStripTips.Text = "toolStripStatusLabel1";
            // 
            // importBtn
            // 
            this.importBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Import;
            this.importBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Location = new System.Drawing.Point(722, 541);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(150, 150);
            this.importBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.importBtn, "RU: импортировать данные с текстового файла");
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Update;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(544, 541);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(150, 150);
            this.updateBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.updateBtn, "RU: редактировать активную запись");
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Delete;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(368, 541);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 150);
            this.deleteBtn.TabIndex = 9;
            this.toolTip1.SetToolTip(this.deleteBtn, "RU: удалить активную запись");
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Add;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(193, 541);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(150, 150);
            this.addBtn.TabIndex = 8;
            this.toolTip1.SetToolTip(this.addBtn, "RU: добавить запись");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Admin;
            this.adminPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanelBtn.Location = new System.Drawing.Point(22, 541);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Size = new System.Drawing.Size(150, 150);
            this.adminPanelBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.adminPanelBtn, "RU: перейти на панель администратора");
            this.adminPanelBtn.UseVisualStyleBackColor = true;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // connectionsTableBtn
            // 
            this.connectionsTableBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Connection;
            this.connectionsTableBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectionsTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionsTableBtn.Location = new System.Drawing.Point(22, 370);
            this.connectionsTableBtn.Name = "connectionsTableBtn";
            this.connectionsTableBtn.Size = new System.Drawing.Size(150, 150);
            this.connectionsTableBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.connectionsTableBtn, "RU: открыть таблицу подключений");
            this.connectionsTableBtn.UseVisualStyleBackColor = true;
            this.connectionsTableBtn.Click += new System.EventHandler(this.connectionsTableBtn_Click);
            // 
            // operatorsTableBtn
            // 
            this.operatorsTableBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.Operator;
            this.operatorsTableBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.operatorsTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorsTableBtn.Location = new System.Drawing.Point(22, 200);
            this.operatorsTableBtn.Name = "operatorsTableBtn";
            this.operatorsTableBtn.Size = new System.Drawing.Size(150, 150);
            this.operatorsTableBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.operatorsTableBtn, "RU: открыть таблицу операторов");
            this.operatorsTableBtn.UseVisualStyleBackColor = true;
            this.operatorsTableBtn.Click += new System.EventHandler(this.operatorsTableBtn_Click);
            // 
            // subscribersTableBtn
            // 
            this.subscribersTableBtn.BackgroundImage = global::Telephone_Directory.Properties.Resources.User;
            this.subscribersTableBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subscribersTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscribersTableBtn.Location = new System.Drawing.Point(22, 27);
            this.subscribersTableBtn.Name = "subscribersTableBtn";
            this.subscribersTableBtn.Size = new System.Drawing.Size(150, 150);
            this.subscribersTableBtn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.subscribersTableBtn, "RU: открыть таблицу абонентов");
            this.subscribersTableBtn.UseVisualStyleBackColor = true;
            this.subscribersTableBtn.Click += new System.EventHandler(this.subscribersTableBtn_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.operatorsToolStripMenuItem,
            this.connectionsToolStripMenuItem1});
            this.tablesToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.Spreadsheet;
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.User;
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectionsToolStripMenuItem.Text = "Subscribers";
            this.connectionsToolStripMenuItem.ToolTipText = "RU: открыть таблицу абонентов";
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // operatorsToolStripMenuItem
            // 
            this.operatorsToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.Operator;
            this.operatorsToolStripMenuItem.Name = "operatorsToolStripMenuItem";
            this.operatorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.operatorsToolStripMenuItem.Text = "Operators";
            this.operatorsToolStripMenuItem.ToolTipText = "RU: открыть таблицу операторов";
            this.operatorsToolStripMenuItem.Click += new System.EventHandler(this.operatorsToolStripMenuItem_Click);
            // 
            // connectionsToolStripMenuItem1
            // 
            this.connectionsToolStripMenuItem1.Image = global::Telephone_Directory.Properties.Resources.Connection;
            this.connectionsToolStripMenuItem1.Name = "connectionsToolStripMenuItem1";
            this.connectionsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.connectionsToolStripMenuItem1.Text = "Connections";
            this.connectionsToolStripMenuItem1.ToolTipText = "RU: открыть таблицу подключений";
            this.connectionsToolStripMenuItem1.Click += new System.EventHandler(this.connectionsToolStripMenuItem1_Click);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.Clear;
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.clearDatabaseToolStripMenuItem.Text = "Clear database";
            this.clearDatabaseToolStripMenuItem.ToolTipText = "RU: очистить базу данных";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.Admin;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adminToolStripMenuItem.Text = "Admin panel";
            this.adminToolStripMenuItem.ToolTipText = "RU: перейти на панель администратора";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.Info;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "RU: справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Telephone_Directory.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "RU: выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1524, 789);
            this.Controls.Add(this.tipsStrip);
            this.Controls.Add(this.propTextBox7);
            this.Controls.Add(this.propTextBox6);
            this.Controls.Add(this.propTextBox5);
            this.Controls.Add(this.propertyLabel7);
            this.Controls.Add(this.propertyLabel6);
            this.Controls.Add(this.propertyLabel5);
            this.Controls.Add(this.propTextBox4);
            this.Controls.Add(this.propTextBox3);
            this.Controls.Add(this.propTextBox2);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.deleteFiltersBtn);
            this.Controls.Add(this.propTextBox1);
            this.Controls.Add(this.propertyLabel4);
            this.Controls.Add(this.propertyLabel3);
            this.Controls.Add(this.propertyLabel2);
            this.Controls.Add(this.propertyLabel1);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.adminPanelBtn);
            this.Controls.Add(this.connectionsTableBtn);
            this.Controls.Add(this.operatorsTableBtn);
            this.Controls.Add(this.subscribersTableBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone directory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tipsStrip.ResumeLayout(false);
            this.tipsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button subscribersTableBtn;
        private System.Windows.Forms.Button operatorsTableBtn;
        private System.Windows.Forms.Button connectionsTableBtn;
        private System.Windows.Forms.Button adminPanelBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label propertyLabel1;
        private System.Windows.Forms.Label propertyLabel2;
        private System.Windows.Forms.Label propertyLabel3;
        private System.Windows.Forms.Label propertyLabel4;
        private System.Windows.Forms.TextBox propTextBox1;
        private System.Windows.Forms.Button deleteFiltersBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.TextBox propTextBox2;
        private System.Windows.Forms.TextBox propTextBox3;
        private System.Windows.Forms.TextBox propTextBox4;
        private System.Windows.Forms.TextBox propTextBox7;
        private System.Windows.Forms.TextBox propTextBox6;
        private System.Windows.Forms.TextBox propTextBox5;
        private System.Windows.Forms.Label propertyLabel7;
        private System.Windows.Forms.Label propertyLabel6;
        private System.Windows.Forms.Label propertyLabel5;
        private System.Windows.Forms.StatusStrip tipsStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTips;
    }
}

