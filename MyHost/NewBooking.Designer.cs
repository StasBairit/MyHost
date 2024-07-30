namespace MyHost
{
    partial class NewBooking
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPasprt = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxPS = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tbxFS = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tbxLS = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyHost.MyDataSet();
            this.customersTableAdapter = new MyHost.MyDataSetTableAdapters.customersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.discountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDiscounts = new MyHost.MyDiscounts();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDeposite = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountsTableAdapter = new MyHost.MyDataSetTableAdapters.discountsTableAdapter();
            this.discountsTableAdapter1 = new MyHost.MyDiscountsTableAdapters.discountsTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxChildren = new System.Windows.Forms.TextBox();
            this.tbxAdults = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDiscounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mtbxPhone);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxPasprt);
            this.tabPage1.Controls.Add(this.tbxFName);
            this.tabPage1.Controls.Add(this.tbxLName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новый гость";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // mtbxPhone
            // 
            this.mtbxPhone.Location = new System.Drawing.Point(144, 135);
            this.mtbxPhone.Mask = "(0000)00-00-00";
            this.mtbxPhone.Name = "mtbxPhone";
            this.mtbxPhone.Size = new System.Drawing.Size(205, 20);
            this.mtbxPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Контактный телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // tbxPasprt
            // 
            this.tbxPasprt.Location = new System.Drawing.Point(144, 96);
            this.tbxPasprt.Name = "tbxPasprt";
            this.tbxPasprt.Size = new System.Drawing.Size(205, 20);
            this.tbxPasprt.TabIndex = 2;
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(144, 56);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(361, 20);
            this.tbxFName.TabIndex = 1;
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(144, 21);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(361, 20);
            this.tbxLName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список зарегистрированных гостей";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 50);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxPS);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.tbxFS);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.tbxLS);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 43);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтр";
            // 
            // tbxPS
            // 
            this.tbxPS.Enabled = false;
            this.tbxPS.Location = new System.Drawing.Point(494, 17);
            this.tbxPS.Name = "tbxPS";
            this.tbxPS.Size = new System.Drawing.Size(124, 20);
            this.tbxPS.TabIndex = 5;
            this.tbxPS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPS_KeyUp);
            this.tbxPS.Leave += new System.EventHandler(this.tbxPS_Leave);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(417, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Телефон";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // tbxFS
            // 
            this.tbxFS.Enabled = false;
            this.tbxFS.Location = new System.Drawing.Point(268, 15);
            this.tbxFS.Name = "tbxFS";
            this.tbxFS.Size = new System.Drawing.Size(143, 20);
            this.tbxFS.TabIndex = 3;
            this.tbxFS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxFS_KeyUp);
            this.tbxFS.Leave += new System.EventHandler(this.tbxFS_Leave);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(214, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Имя";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tbxLS
            // 
            this.tbxLS.Enabled = false;
            this.tbxLS.Location = new System.Drawing.Point(87, 16);
            this.tbxLS.Name = "tbxLS";
            this.tbxLS.Size = new System.Drawing.Size(121, 20);
            this.tbxLS.TabIndex = 1;
            this.tbxLS.TextChanged += new System.EventHandler(this.tbxLS_TextChanged);
            this.tbxLS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLS_KeyPress);
            this.tbxLS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxLS_KeyUp);
            this.tbxLS.Leave += new System.EventHandler(this.tbxLS_Leave);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Фамилия";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customerlnameDataGridViewTextBoxColumn,
            this.customerfnameDataGridViewTextBoxColumn,
            this.customerpassportDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowHeaderCellChanged);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Visible = false;
            this.customeridDataGridViewTextBoxColumn.Width = 20;
            // 
            // customerlnameDataGridViewTextBoxColumn
            // 
            this.customerlnameDataGridViewTextBoxColumn.DataPropertyName = "customer_lname";
            this.customerlnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.customerlnameDataGridViewTextBoxColumn.Name = "customerlnameDataGridViewTextBoxColumn";
            this.customerlnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerfnameDataGridViewTextBoxColumn
            // 
            this.customerfnameDataGridViewTextBoxColumn.DataPropertyName = "customer_fname";
            this.customerfnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.customerfnameDataGridViewTextBoxColumn.Name = "customerfnameDataGridViewTextBoxColumn";
            this.customerfnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerpassportDataGridViewTextBoxColumn
            // 
            this.customerpassportDataGridViewTextBoxColumn.DataPropertyName = "customer_passport";
            this.customerpassportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.customerpassportDataGridViewTextBoxColumn.Name = "customerpassportDataGridViewTextBoxColumn";
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.discountsBindingSource1;
            this.comboBox1.DisplayMember = "discount_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(551, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "discount_id";
            // 
            // discountsBindingSource1
            // 
            this.discountsBindingSource1.DataMember = "discounts";
            this.discountsBindingSource1.DataSource = this.myDiscounts;
            // 
            // myDiscounts
            // 
            this.myDiscounts.DataSetName = "MyDiscounts";
            this.myDiscounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Скидка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxDeposite);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(188, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предоплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Предоплата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Оплачен";
            // 
            // tbxDeposite
            // 
            this.tbxDeposite.Enabled = false;
            this.tbxDeposite.Location = new System.Drawing.Point(89, 56);
            this.tbxDeposite.Name = "tbxDeposite";
            this.tbxDeposite.Size = new System.Drawing.Size(85, 20);
            this.tbxDeposite.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(89, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(16, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сроки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "От";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(34, 59);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(13, 9);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(47, 13);
            this.lblRoomNumber.TabIndex = 11;
            this.lblRoomNumber.Text = "Номер: ";
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "discounts";
            this.discountsBindingSource.DataSource = this.myDataSet;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // discountsTableAdapter1
            // 
            this.discountsTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxChildren);
            this.groupBox3.Controls.Add(this.tbxAdults);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(376, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 87);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Количество";
            // 
            // tbxChildren
            // 
            this.tbxChildren.Location = new System.Drawing.Point(68, 49);
            this.tbxChildren.Name = "tbxChildren";
            this.tbxChildren.Size = new System.Drawing.Size(89, 20);
            this.tbxChildren.TabIndex = 2;
            this.tbxChildren.Text = "0";
            // 
            // tbxAdults
            // 
            this.tbxAdults.Location = new System.Drawing.Point(68, 15);
            this.tbxAdults.Name = "tbxAdults";
            this.tbxAdults.Size = new System.Drawing.Size(89, 20);
            this.tbxAdults.TabIndex = 1;
            this.tbxAdults.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "детей";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "взрослых";
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewBooking";
            this.Text = "Регистрация гостя";
            this.Load += new System.EventHandler(this.NewBooking_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDiscounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MyHost.MyDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.MaskedTextBox mtbxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPasprt;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDeposite;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private MyHost.MyDataSetTableAdapters.discountsTableAdapter discountsTableAdapter;
        private MyDiscounts myDiscounts;
        private System.Windows.Forms.BindingSource discountsBindingSource1;
        private MyHost.MyDiscountsTableAdapters.discountsTableAdapter discountsTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxChildren;
        private System.Windows.Forms.TextBox tbxAdults;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxPS;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox tbxFS;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox tbxLS;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}