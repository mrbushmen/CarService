namespace CarServiceDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbOrdersOwner = new System.Windows.Forms.ComboBox();
            this.dtpOrdersDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbOrdersWorker = new System.Windows.Forms.ComboBox();
            this.cmbOrdersService = new System.Windows.Forms.ComboBox();
            this.cmbOrdersCar = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUnpaid = new System.Windows.Forms.TextBox();
            this.btnOwnerEdit = new System.Windows.Forms.Button();
            this.btnOwnerAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwnerPhone = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.dataGridViewOwners = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCarOwner = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarYear = new System.Windows.Forms.TextBox();
            this.btnCarEdit = new System.Windows.Forms.Button();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarMark = new System.Windows.Forms.TextBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkerSpec = new System.Windows.Forms.TextBox();
            this.btnWorkerEdit = new System.Windows.Forms.Button();
            this.btnWorkerAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWorkerPhone = new System.Windows.Forms.TextBox();
            this.txtWorkerName = new System.Windows.Forms.TextBox();
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.btnServiceEdit = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьскрытьIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 349);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxPaid);
            this.tabPage1.Controls.Add(this.btnOrderEdit);
            this.tabPage1.Controls.Add(this.btnOrderAdd);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.cmbOrdersOwner);
            this.tabPage1.Controls.Add(this.dtpOrdersDate);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.cmbOrdersWorker);
            this.tabPage1.Controls.Add(this.cmbOrdersService);
            this.tabPage1.Controls.Add(this.cmbOrdersCar);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.dataGridViewOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(659, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(255, 296);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(75, 17);
            this.checkBoxPaid.TabIndex = 49;
            this.checkBoxPaid.Text = "Оплачено";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Location = new System.Drawing.Point(350, 189);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(160, 23);
            this.btnOrderEdit.TabIndex = 48;
            this.btnOrderEdit.Text = "Редактировать";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.BtnOrderEdit_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(350, 160);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(160, 23);
            this.btnOrderAdd.TabIndex = 47;
            this.btnOrderAdd.Text = "Добавить";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.BtnOrderAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Владелец";
            // 
            // cmbOrdersOwner
            // 
            this.cmbOrdersOwner.FormattingEnabled = true;
            this.cmbOrdersOwner.Location = new System.Drawing.Point(91, 162);
            this.cmbOrdersOwner.Name = "cmbOrdersOwner";
            this.cmbOrdersOwner.Size = new System.Drawing.Size(242, 21);
            this.cmbOrdersOwner.TabIndex = 45;
            this.cmbOrdersOwner.SelectedIndexChanged += new System.EventHandler(this.CbOrdersOwner_SelectedIndexChanged);
            // 
            // dtpOrdersDate
            // 
            this.dtpOrdersDate.Location = new System.Drawing.Point(91, 270);
            this.dtpOrdersDate.Name = "dtpOrdersDate";
            this.dtpOrdersDate.Size = new System.Drawing.Size(242, 20);
            this.dtpOrdersDate.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 273);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Дата";
            // 
            // cmbOrdersWorker
            // 
            this.cmbOrdersWorker.FormattingEnabled = true;
            this.cmbOrdersWorker.Location = new System.Drawing.Point(91, 243);
            this.cmbOrdersWorker.Name = "cmbOrdersWorker";
            this.cmbOrdersWorker.Size = new System.Drawing.Size(242, 21);
            this.cmbOrdersWorker.TabIndex = 41;
            this.cmbOrdersWorker.SelectedIndexChanged += new System.EventHandler(this.CbOrdersWorker_SelectedIndexChanged);
            // 
            // cmbOrdersService
            // 
            this.cmbOrdersService.FormattingEnabled = true;
            this.cmbOrdersService.Location = new System.Drawing.Point(91, 216);
            this.cmbOrdersService.Name = "cmbOrdersService";
            this.cmbOrdersService.Size = new System.Drawing.Size(242, 21);
            this.cmbOrdersService.TabIndex = 40;
            this.cmbOrdersService.SelectedIndexChanged += new System.EventHandler(this.CbOrdersService_SelectedIndexChanged);
            // 
            // cmbOrdersCar
            // 
            this.cmbOrdersCar.FormattingEnabled = true;
            this.cmbOrdersCar.Location = new System.Drawing.Point(91, 189);
            this.cmbOrdersCar.Name = "cmbOrdersCar";
            this.cmbOrdersCar.Size = new System.Drawing.Size(242, 21);
            this.cmbOrdersCar.TabIndex = 39;
            this.cmbOrdersCar.SelectedIndexChanged += new System.EventHandler(this.CbOrdersCar_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 243);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Работник";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 216);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Услуга";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 189);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Автомобиль";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(659, 150);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrders_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtUnpaid);
            this.tabPage2.Controls.Add(this.btnOwnerEdit);
            this.tabPage2.Controls.Add(this.btnOwnerAdd);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtOwnerPhone);
            this.tabPage2.Controls.Add(this.txtOwnerName);
            this.tabPage2.Controls.Add(this.dataGridViewOwners);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(659, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Задолженность";
            // 
            // txtUnpaid
            // 
            this.txtUnpaid.Location = new System.Drawing.Point(102, 214);
            this.txtUnpaid.Name = "txtUnpaid";
            this.txtUnpaid.ReadOnly = true;
            this.txtUnpaid.Size = new System.Drawing.Size(134, 20);
            this.txtUnpaid.TabIndex = 9;
            // 
            // btnOwnerEdit
            // 
            this.btnOwnerEdit.Location = new System.Drawing.Point(350, 189);
            this.btnOwnerEdit.Name = "btnOwnerEdit";
            this.btnOwnerEdit.Size = new System.Drawing.Size(160, 23);
            this.btnOwnerEdit.TabIndex = 7;
            this.btnOwnerEdit.Text = "Редактировать";
            this.btnOwnerEdit.UseVisualStyleBackColor = true;
            this.btnOwnerEdit.Click += new System.EventHandler(this.BtnOwnerEdit_Click);
            // 
            // btnOwnerAdd
            // 
            this.btnOwnerAdd.Location = new System.Drawing.Point(350, 160);
            this.btnOwnerAdd.Name = "btnOwnerAdd";
            this.btnOwnerAdd.Size = new System.Drawing.Size(160, 23);
            this.btnOwnerAdd.TabIndex = 6;
            this.btnOwnerAdd.Text = "Добавить";
            this.btnOwnerAdd.UseVisualStyleBackColor = true;
            this.btnOwnerAdd.Click += new System.EventHandler(this.BtnOwnerAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // txtOwnerPhone
            // 
            this.txtOwnerPhone.Location = new System.Drawing.Point(102, 188);
            this.txtOwnerPhone.Name = "txtOwnerPhone";
            this.txtOwnerPhone.Size = new System.Drawing.Size(134, 20);
            this.txtOwnerPhone.TabIndex = 3;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(102, 162);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(134, 20);
            this.txtOwnerName.TabIndex = 2;
            // 
            // dataGridViewOwners
            // 
            this.dataGridViewOwners.AllowUserToAddRows = false;
            this.dataGridViewOwners.AllowUserToDeleteRows = false;
            this.dataGridViewOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwners.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOwners.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOwners.Name = "dataGridViewOwners";
            this.dataGridViewOwners.ReadOnly = true;
            this.dataGridViewOwners.Size = new System.Drawing.Size(659, 150);
            this.dataGridViewOwners.TabIndex = 1;
            this.dataGridViewOwners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOwners_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cmbCarOwner);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtCarYear);
            this.tabPage3.Controls.Add(this.btnCarEdit);
            this.tabPage3.Controls.Add(this.btnCarAdd);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtCarModel);
            this.tabPage3.Controls.Add(this.txtCarMark);
            this.tabPage3.Controls.Add(this.dataGridViewCars);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(659, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Автомобили";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Владелец";
            // 
            // cmbCarOwner
            // 
            this.cmbCarOwner.FormattingEnabled = true;
            this.cmbCarOwner.Location = new System.Drawing.Point(83, 240);
            this.cmbCarOwner.Name = "cmbCarOwner";
            this.cmbCarOwner.Size = new System.Drawing.Size(136, 21);
            this.cmbCarOwner.TabIndex = 16;
            this.cmbCarOwner.SelectedIndexChanged += new System.EventHandler(this.CbCarOwner_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Год выпуска";
            // 
            // txtCarYear
            // 
            this.txtCarYear.Location = new System.Drawing.Point(83, 214);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(136, 20);
            this.txtCarYear.TabIndex = 14;
            // 
            // btnCarEdit
            // 
            this.btnCarEdit.Location = new System.Drawing.Point(350, 189);
            this.btnCarEdit.Name = "btnCarEdit";
            this.btnCarEdit.Size = new System.Drawing.Size(160, 23);
            this.btnCarEdit.TabIndex = 13;
            this.btnCarEdit.Text = "Редактировать";
            this.btnCarEdit.UseVisualStyleBackColor = true;
            this.btnCarEdit.Click += new System.EventHandler(this.BtnCarEdit_Click);
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.Location = new System.Drawing.Point(350, 160);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(160, 23);
            this.btnCarAdd.TabIndex = 12;
            this.btnCarAdd.Text = "Добавить";
            this.btnCarAdd.UseVisualStyleBackColor = true;
            this.btnCarAdd.Click += new System.EventHandler(this.BtnCarAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Марка";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(83, 188);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(136, 20);
            this.txtCarModel.TabIndex = 9;
            // 
            // txtCarMark
            // 
            this.txtCarMark.Location = new System.Drawing.Point(83, 162);
            this.txtCarMark.Name = "txtCarMark";
            this.txtCarMark.Size = new System.Drawing.Size(136, 20);
            this.txtCarMark.TabIndex = 8;
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AllowUserToAddRows = false;
            this.dataGridViewCars.AllowUserToDeleteRows = false;
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCars.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.Size = new System.Drawing.Size(659, 150);
            this.dataGridViewCars.TabIndex = 1;
            this.dataGridViewCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCars_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtWorkerSpec);
            this.tabPage4.Controls.Add(this.btnWorkerEdit);
            this.tabPage4.Controls.Add(this.btnWorkerAdd);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtWorkerPhone);
            this.tabPage4.Controls.Add(this.txtWorkerName);
            this.tabPage4.Controls.Add(this.dataGridViewWorkers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(659, 323);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Работники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Специализация";
            // 
            // txtWorkerSpec
            // 
            this.txtWorkerSpec.Location = new System.Drawing.Point(97, 214);
            this.txtWorkerSpec.Name = "txtWorkerSpec";
            this.txtWorkerSpec.Size = new System.Drawing.Size(136, 20);
            this.txtWorkerSpec.TabIndex = 24;
            // 
            // btnWorkerEdit
            // 
            this.btnWorkerEdit.Location = new System.Drawing.Point(350, 189);
            this.btnWorkerEdit.Name = "btnWorkerEdit";
            this.btnWorkerEdit.Size = new System.Drawing.Size(160, 23);
            this.btnWorkerEdit.TabIndex = 23;
            this.btnWorkerEdit.Text = "Редактировать";
            this.btnWorkerEdit.UseVisualStyleBackColor = true;
            this.btnWorkerEdit.Click += new System.EventHandler(this.BtnWorkerEdit_Click);
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.Location = new System.Drawing.Point(350, 160);
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Size = new System.Drawing.Size(160, 23);
            this.btnWorkerAdd.TabIndex = 22;
            this.btnWorkerAdd.Text = "Добавить";
            this.btnWorkerAdd.UseVisualStyleBackColor = true;
            this.btnWorkerAdd.Click += new System.EventHandler(this.BtnWorkerAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Телефон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Имя";
            // 
            // txtWorkerPhone
            // 
            this.txtWorkerPhone.Location = new System.Drawing.Point(97, 188);
            this.txtWorkerPhone.Name = "txtWorkerPhone";
            this.txtWorkerPhone.Size = new System.Drawing.Size(136, 20);
            this.txtWorkerPhone.TabIndex = 19;
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.Location = new System.Drawing.Point(97, 162);
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Size = new System.Drawing.Size(136, 20);
            this.txtWorkerName.TabIndex = 18;
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.AllowUserToAddRows = false;
            this.dataGridViewWorkers.AllowUserToDeleteRows = false;
            this.dataGridViewWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.ReadOnly = true;
            this.dataGridViewWorkers.Size = new System.Drawing.Size(659, 150);
            this.dataGridViewWorkers.TabIndex = 1;
            this.dataGridViewWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewWorkers_CellClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.txtServiceCost);
            this.tabPage5.Controls.Add(this.btnServiceEdit);
            this.tabPage5.Controls.Add(this.btnServiceAdd);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.txtServiceDescription);
            this.tabPage5.Controls.Add(this.txtServiceType);
            this.tabPage5.Controls.Add(this.dataGridViewServices);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(659, 323);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Услуги";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 217);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Стоимость";
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(79, 214);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(229, 20);
            this.txtServiceCost.TabIndex = 34;
            // 
            // btnServiceEdit
            // 
            this.btnServiceEdit.Location = new System.Drawing.Point(350, 189);
            this.btnServiceEdit.Name = "btnServiceEdit";
            this.btnServiceEdit.Size = new System.Drawing.Size(160, 23);
            this.btnServiceEdit.TabIndex = 33;
            this.btnServiceEdit.Text = "Редактировать";
            this.btnServiceEdit.UseVisualStyleBackColor = true;
            this.btnServiceEdit.Click += new System.EventHandler(this.BtnServiceEdit_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(350, 160);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(160, 23);
            this.btnServiceAdd.TabIndex = 32;
            this.btnServiceAdd.Text = "Добавить";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.BtnServiceAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 191);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Описание";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 165);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Тип услуги";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(79, 188);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(229, 20);
            this.txtServiceDescription.TabIndex = 29;
            // 
            // txtServiceType
            // 
            this.txtServiceType.Location = new System.Drawing.Point(79, 162);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(229, 20);
            this.txtServiceType.TabIndex = 28;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewServices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            this.dataGridViewServices.Size = new System.Drawing.Size(659, 150);
            this.dataGridViewServices.TabIndex = 1;
            this.dataGridViewServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewServices_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьскрытьIdToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // отобразитьскрытьIdToolStripMenuItem
            // 
            this.отобразитьскрытьIdToolStripMenuItem.Name = "отобразитьскрытьIdToolStripMenuItem";
            this.отобразитьскрытьIdToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.отобразитьскрытьIdToolStripMenuItem.Text = "Отобразить/скрыть Id";
            this.отобразитьскрытьIdToolStripMenuItem.Click += new System.EventHandler(this.HideIdToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Сервисный центр";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewOwners;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button btnOwnerEdit;
        private System.Windows.Forms.Button btnOwnerAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOwnerPhone;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarYear;
        private System.Windows.Forms.Button btnCarEdit;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkerSpec;
        private System.Windows.Forms.Button btnWorkerEdit;
        private System.Windows.Forms.Button btnWorkerAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWorkerPhone;
        private System.Windows.Forms.TextBox txtWorkerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Button btnServiceEdit;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.DateTimePicker dtpOrdersDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbOrdersWorker;
        private System.Windows.Forms.ComboBox cmbOrdersService;
        private System.Windows.Forms.ComboBox cmbOrdersCar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbOrdersOwner;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUnpaid;
        private System.Windows.Forms.ComboBox cmbCarOwner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьскрытьIdToolStripMenuItem;
    }
}

