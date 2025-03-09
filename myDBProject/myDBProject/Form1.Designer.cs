namespace myDBProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tab_Connection = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            btn_disconnect = new Button();
            btn_Connection = new Button();
            txt_Password = new TextBox();
            txt_userName = new TextBox();
            txt_hostName = new TextBox();
            lbl_Password = new Label();
            lbl_userName = new Label();
            lbl_serverName = new Label();
            lstvConnectionStrings = new ListView();
            Seq = new ColumnHeader();
            ConnectionName = new ColumnHeader();
            Provider = new ColumnHeader();
            ConnectionString = new ColumnHeader();
            statusStrip_connection = new StatusStrip();
            lbltoolStripStatus = new ToolStripStatusLabel();
            tab_inquiry = new TabPage();
            splitContainer2 = new SplitContainer();
            btn_saveToXML = new Button();
            btn_customers = new Button();
            btn_saveToCSV = new Button();
            btn_Customer_Orders = new Button();
            txt_city = new TextBox();
            txt_country = new TextBox();
            lbl_city = new Label();
            lbl_phone = new Label();
            txt_orderDate = new TextBox();
            txt_contactName = new TextBox();
            lbl_orderDate = new Label();
            lbl_contactName = new Label();
            txt_orderID = new TextBox();
            txt_customerID = new TextBox();
            lbl_orderID = new Label();
            lbl_custtomerID = new Label();
            dgv_resultQuery = new DataGridView();
            tab_addData = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvOrders = new DataGridView();
            orderId = new DataGridViewTextBoxColumn();
            customerId = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            shippedDate = new DataGridViewTextBoxColumn();
            shipVia = new DataGridViewTextBoxColumn();
            shipAddress = new DataGridViewTextBoxColumn();
            shipCity = new DataGridViewTextBoxColumn();
            shipCountry = new DataGridViewTextBoxColumn();
            btn_addOrder = new Button();
            dgv_addCustomer = new DataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            company_name = new DataGridViewTextBoxColumn();
            contact_name = new DataGridViewTextBoxColumn();
            contact_title = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            region = new DataGridViewTextBoxColumn();
            postal_code = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            fax = new DataGridViewTextBoxColumn();
            btn_addCustomer = new Button();
            tab_Connection.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip_connection.SuspendLayout();
            tab_inquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_resultQuery).BeginInit();
            tab_addData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_addCustomer).BeginInit();
            SuspendLayout();
            // 
            // tab_Connection
            // 
            tab_Connection.Controls.Add(tabPage1);
            tab_Connection.Controls.Add(tab_inquiry);
            tab_Connection.Controls.Add(tab_addData);
            tab_Connection.Dock = DockStyle.Fill;
            tab_Connection.Location = new Point(0, 0);
            tab_Connection.Name = "tab_Connection";
            tab_Connection.SelectedIndex = 0;
            tab_Connection.Size = new Size(1367, 641);
            tab_Connection.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1359, 613);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Подключение";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_disconnect);
            splitContainer1.Panel1.Controls.Add(btn_Connection);
            splitContainer1.Panel1.Controls.Add(txt_Password);
            splitContainer1.Panel1.Controls.Add(txt_userName);
            splitContainer1.Panel1.Controls.Add(txt_hostName);
            splitContainer1.Panel1.Controls.Add(lbl_Password);
            splitContainer1.Panel1.Controls.Add(lbl_userName);
            splitContainer1.Panel1.Controls.Add(lbl_serverName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lstvConnectionStrings);
            splitContainer1.Panel2.Controls.Add(statusStrip_connection);
            splitContainer1.Size = new Size(1353, 607);
            splitContainer1.SplitterDistance = 538;
            splitContainer1.TabIndex = 0;
            // 
            // btn_disconnect
            // 
            btn_disconnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_disconnect.FlatStyle = FlatStyle.System;
            btn_disconnect.Font = new Font("Segoe UI", 12F);
            btn_disconnect.Location = new Point(43, 509);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(465, 55);
            btn_disconnect.TabIndex = 5;
            btn_disconnect.Text = "Выход";
            btn_disconnect.UseVisualStyleBackColor = true;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // btn_Connection
            // 
            btn_Connection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Connection.FlatStyle = FlatStyle.System;
            btn_Connection.Font = new Font("Segoe UI", 12F);
            btn_Connection.Location = new Point(43, 429);
            btn_Connection.Name = "btn_Connection";
            btn_Connection.Size = new Size(465, 55);
            btn_Connection.TabIndex = 4;
            btn_Connection.Text = "Подключение";
            btn_Connection.UseVisualStyleBackColor = true;
            btn_Connection.Click += btn_Connection_Click;
            // 
            // txt_Password
            // 
            txt_Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Password.Location = new Point(85, 198);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(376, 23);
            txt_Password.TabIndex = 3;
            txt_Password.Text = "1111";
            txt_Password.TextAlign = HorizontalAlignment.Center;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_userName
            // 
            txt_userName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_userName.Location = new Point(85, 124);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(376, 23);
            txt_userName.TabIndex = 2;
            txt_userName.Text = "just_user";
            txt_userName.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_hostName
            // 
            txt_hostName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_hostName.Location = new Point(85, 55);
            txt_hostName.Name = "txt_hostName";
            txt_hostName.Size = new Size(376, 23);
            txt_hostName.TabIndex = 1;
            txt_hostName.Text = "localhost";
            txt_hostName.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Password
            // 
            lbl_Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Password.FlatStyle = FlatStyle.Flat;
            lbl_Password.Location = new Point(61, 172);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(414, 23);
            lbl_Password.TabIndex = 0;
            lbl_Password.Text = "Пароль";
            lbl_Password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_userName
            // 
            lbl_userName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_userName.FlatStyle = FlatStyle.Flat;
            lbl_userName.Location = new Point(61, 98);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(414, 23);
            lbl_userName.TabIndex = 0;
            lbl_userName.Text = "Имя пользователя";
            lbl_userName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_serverName
            // 
            lbl_serverName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_serverName.FlatStyle = FlatStyle.Flat;
            lbl_serverName.Location = new Point(61, 29);
            lbl_serverName.Name = "lbl_serverName";
            lbl_serverName.Size = new Size(414, 23);
            lbl_serverName.TabIndex = 0;
            lbl_serverName.Text = "Имя сервера";
            lbl_serverName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstvConnectionStrings
            // 
            lstvConnectionStrings.Columns.AddRange(new ColumnHeader[] { Seq, ConnectionName, Provider, ConnectionString });
            lstvConnectionStrings.Dock = DockStyle.Fill;
            lstvConnectionStrings.Location = new Point(0, 0);
            lstvConnectionStrings.Name = "lstvConnectionStrings";
            lstvConnectionStrings.Size = new Size(811, 585);
            lstvConnectionStrings.TabIndex = 1;
            lstvConnectionStrings.UseCompatibleStateImageBehavior = false;
            lstvConnectionStrings.View = View.Details;
            // 
            // Seq
            // 
            Seq.Text = "Seq";
            // 
            // ConnectionName
            // 
            ConnectionName.Text = "ConnectionName";
            ConnectionName.TextAlign = HorizontalAlignment.Center;
            ConnectionName.Width = 100;
            // 
            // Provider
            // 
            Provider.Text = "Provider";
            Provider.TextAlign = HorizontalAlignment.Center;
            Provider.Width = 100;
            // 
            // ConnectionString
            // 
            ConnectionString.Text = "ConnectionString";
            ConnectionString.TextAlign = HorizontalAlignment.Center;
            ConnectionString.Width = 120;
            // 
            // statusStrip_connection
            // 
            statusStrip_connection.Items.AddRange(new ToolStripItem[] { lbltoolStripStatus });
            statusStrip_connection.Location = new Point(0, 585);
            statusStrip_connection.Name = "statusStrip_connection";
            statusStrip_connection.Size = new Size(811, 22);
            statusStrip_connection.TabIndex = 0;
            statusStrip_connection.Text = "statusStrip1";
            // 
            // lbltoolStripStatus
            // 
            lbltoolStripStatus.Name = "lbltoolStripStatus";
            lbltoolStripStatus.Size = new Size(0, 17);
            // 
            // tab_inquiry
            // 
            tab_inquiry.Controls.Add(splitContainer2);
            tab_inquiry.Location = new Point(4, 24);
            tab_inquiry.Name = "tab_inquiry";
            tab_inquiry.Padding = new Padding(3);
            tab_inquiry.Size = new Size(1359, 613);
            tab_inquiry.TabIndex = 1;
            tab_inquiry.Text = "Запрос данных";
            tab_inquiry.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btn_saveToXML);
            splitContainer2.Panel1.Controls.Add(btn_customers);
            splitContainer2.Panel1.Controls.Add(btn_saveToCSV);
            splitContainer2.Panel1.Controls.Add(btn_Customer_Orders);
            splitContainer2.Panel1.Controls.Add(txt_city);
            splitContainer2.Panel1.Controls.Add(txt_country);
            splitContainer2.Panel1.Controls.Add(lbl_city);
            splitContainer2.Panel1.Controls.Add(lbl_phone);
            splitContainer2.Panel1.Controls.Add(txt_orderDate);
            splitContainer2.Panel1.Controls.Add(txt_contactName);
            splitContainer2.Panel1.Controls.Add(lbl_orderDate);
            splitContainer2.Panel1.Controls.Add(lbl_contactName);
            splitContainer2.Panel1.Controls.Add(txt_orderID);
            splitContainer2.Panel1.Controls.Add(txt_customerID);
            splitContainer2.Panel1.Controls.Add(lbl_orderID);
            splitContainer2.Panel1.Controls.Add(lbl_custtomerID);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgv_resultQuery);
            splitContainer2.Size = new Size(1353, 607);
            splitContainer2.SplitterDistance = 253;
            splitContainer2.TabIndex = 0;
            // 
            // btn_saveToXML
            // 
            btn_saveToXML.Font = new Font("Segoe UI", 12F);
            btn_saveToXML.Location = new Point(438, 101);
            btn_saveToXML.Name = "btn_saveToXML";
            btn_saveToXML.Size = new Size(135, 40);
            btn_saveToXML.TabIndex = 9;
            btn_saveToXML.Text = "save XML";
            btn_saveToXML.UseVisualStyleBackColor = true;
            btn_saveToXML.Click += btn_saveToXML_Click;
            // 
            // btn_customers
            // 
            btn_customers.Font = new Font("Segoe UI", 12F);
            btn_customers.Location = new Point(593, 29);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(141, 42);
            btn_customers.TabIndex = 8;
            btn_customers.Text = "Клиенты";
            btn_customers.UseVisualStyleBackColor = true;
            btn_customers.Click += btn_customers_Click;
            // 
            // btn_saveToCSV
            // 
            btn_saveToCSV.Font = new Font("Segoe UI", 12F);
            btn_saveToCSV.Location = new Point(593, 101);
            btn_saveToCSV.Name = "btn_saveToCSV";
            btn_saveToCSV.Size = new Size(141, 40);
            btn_saveToCSV.TabIndex = 10;
            btn_saveToCSV.Text = "save CSV";
            btn_saveToCSV.UseVisualStyleBackColor = true;
            btn_saveToCSV.Click += btn_saveToCSV_Click;
            // 
            // btn_Customer_Orders
            // 
            btn_Customer_Orders.Font = new Font("Segoe UI", 12F);
            btn_Customer_Orders.Location = new Point(438, 29);
            btn_Customer_Orders.Name = "btn_Customer_Orders";
            btn_Customer_Orders.Size = new Size(135, 41);
            btn_Customer_Orders.TabIndex = 7;
            btn_Customer_Orders.Text = "Клиент/Заказ";
            btn_Customer_Orders.UseVisualStyleBackColor = true;
            btn_Customer_Orders.Click += btn_Customer_Orders_Click;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(348, 113);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(66, 23);
            txt_city.TabIndex = 6;
            // 
            // txt_country
            // 
            txt_country.Location = new Point(130, 116);
            txt_country.Name = "txt_country";
            txt_country.Size = new Size(77, 23);
            txt_country.TabIndex = 3;
            // 
            // lbl_city
            // 
            lbl_city.Font = new Font("Segoe UI", 12F);
            lbl_city.Location = new Point(239, 113);
            lbl_city.Name = "lbl_city";
            lbl_city.Size = new Size(103, 23);
            lbl_city.TabIndex = 0;
            lbl_city.Text = "City";
            // 
            // lbl_phone
            // 
            lbl_phone.Font = new Font("Segoe UI", 12F);
            lbl_phone.Location = new Point(17, 118);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(142, 23);
            lbl_phone.TabIndex = 0;
            lbl_phone.Text = "Country";
            // 
            // txt_orderDate
            // 
            txt_orderDate.Location = new Point(348, 72);
            txt_orderDate.Name = "txt_orderDate";
            txt_orderDate.Size = new Size(66, 23);
            txt_orderDate.TabIndex = 5;
            // 
            // txt_contactName
            // 
            txt_contactName.Location = new Point(130, 75);
            txt_contactName.Name = "txt_contactName";
            txt_contactName.Size = new Size(77, 23);
            txt_contactName.TabIndex = 2;
            // 
            // lbl_orderDate
            // 
            lbl_orderDate.Font = new Font("Segoe UI", 12F);
            lbl_orderDate.Location = new Point(239, 72);
            lbl_orderDate.Name = "lbl_orderDate";
            lbl_orderDate.Size = new Size(103, 23);
            lbl_orderDate.TabIndex = 0;
            lbl_orderDate.Text = "Order date";
            // 
            // lbl_contactName
            // 
            lbl_contactName.Font = new Font("Segoe UI", 12F);
            lbl_contactName.Location = new Point(17, 77);
            lbl_contactName.Name = "lbl_contactName";
            lbl_contactName.Size = new Size(142, 23);
            lbl_contactName.TabIndex = 0;
            lbl_contactName.Text = "Contact Name";
            // 
            // txt_orderID
            // 
            txt_orderID.Location = new Point(348, 29);
            txt_orderID.Name = "txt_orderID";
            txt_orderID.Size = new Size(66, 23);
            txt_orderID.TabIndex = 4;
            // 
            // txt_customerID
            // 
            txt_customerID.Location = new Point(130, 32);
            txt_customerID.Name = "txt_customerID";
            txt_customerID.Size = new Size(77, 23);
            txt_customerID.TabIndex = 1;
            // 
            // lbl_orderID
            // 
            lbl_orderID.Font = new Font("Segoe UI", 12F);
            lbl_orderID.Location = new Point(239, 29);
            lbl_orderID.Name = "lbl_orderID";
            lbl_orderID.Size = new Size(103, 23);
            lbl_orderID.TabIndex = 0;
            lbl_orderID.Text = "Order ID";
            // 
            // lbl_custtomerID
            // 
            lbl_custtomerID.Font = new Font("Segoe UI", 12F);
            lbl_custtomerID.Location = new Point(17, 34);
            lbl_custtomerID.Name = "lbl_custtomerID";
            lbl_custtomerID.Size = new Size(142, 23);
            lbl_custtomerID.TabIndex = 0;
            lbl_custtomerID.Text = "Customer ID";
            // 
            // dgv_resultQuery
            // 
            dgv_resultQuery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_resultQuery.Dock = DockStyle.Fill;
            dgv_resultQuery.Location = new Point(0, 0);
            dgv_resultQuery.Name = "dgv_resultQuery";
            dgv_resultQuery.Size = new Size(1353, 350);
            dgv_resultQuery.TabIndex = 0;
            // 
            // tab_addData
            // 
            tab_addData.Controls.Add(tableLayoutPanel1);
            tab_addData.Location = new Point(4, 24);
            tab_addData.Name = "tab_addData";
            tab_addData.Padding = new Padding(3);
            tab_addData.Size = new Size(1359, 613);
            tab_addData.TabIndex = 2;
            tab_addData.Text = "Добавление данных";
            tab_addData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(dgvOrders, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_addOrder, 1, 0);
            tableLayoutPanel1.Controls.Add(dgv_addCustomer, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_addCustomer, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1353, 607);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvOrders
            // 
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { orderId, customerId, orderDate, shippedDate, shipVia, shipAddress, shipCity, shipCountry });
            dgvOrders.Location = new Point(3, 3);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(1197, 297);
            dgvOrders.TabIndex = 0;
            // 
            // orderId
            // 
            orderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderId.HeaderText = "order id";
            orderId.Name = "orderId";
            // 
            // customerId
            // 
            customerId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerId.HeaderText = "customer id";
            customerId.Name = "customerId";
            // 
            // orderDate
            // 
            orderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDate.HeaderText = "order Date";
            orderDate.Name = "orderDate";
            // 
            // shippedDate
            // 
            shippedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shippedDate.HeaderText = "shipped Date";
            shippedDate.Name = "shippedDate";
            // 
            // shipVia
            // 
            shipVia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shipVia.HeaderText = "ship Via";
            shipVia.Name = "shipVia";
            // 
            // shipAddress
            // 
            shipAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shipAddress.HeaderText = "ship Address";
            shipAddress.Name = "shipAddress";
            // 
            // shipCity
            // 
            shipCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shipCity.HeaderText = "ship City";
            shipCity.Name = "shipCity";
            // 
            // shipCountry
            // 
            shipCountry.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            shipCountry.HeaderText = "ship Country";
            shipCountry.Name = "shipCountry";
            // 
            // btn_addOrder
            // 
            btn_addOrder.Dock = DockStyle.Right;
            btn_addOrder.FlatStyle = FlatStyle.System;
            btn_addOrder.Font = new Font("Segoe UI", 12F);
            btn_addOrder.Location = new Point(1209, 3);
            btn_addOrder.Name = "btn_addOrder";
            btn_addOrder.Size = new Size(141, 297);
            btn_addOrder.TabIndex = 0;
            btn_addOrder.Text = "Добавить заказ";
            btn_addOrder.UseVisualStyleBackColor = true;
            btn_addOrder.Click += btn_addOrder_Click;
            // 
            // dgv_addCustomer
            // 
            dgv_addCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_addCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_addCustomer.Columns.AddRange(new DataGridViewColumn[] { customer_id, company_name, contact_name, contact_title, address, city, region, postal_code, country, phone, fax });
            dgv_addCustomer.Location = new Point(3, 306);
            dgv_addCustomer.Name = "dgv_addCustomer";
            dgv_addCustomer.Size = new Size(1197, 298);
            dgv_addCustomer.TabIndex = 1;
            // 
            // customer_id
            // 
            customer_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_id.HeaderText = "customer id";
            customer_id.Name = "customer_id";
            // 
            // company_name
            // 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            company_name.HeaderText = "company_name";
            company_name.Name = "company_name";
            // 
            // contact_name
            // 
            contact_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            contact_name.HeaderText = "contact_name";
            contact_name.Name = "contact_name";
            // 
            // contact_title
            // 
            contact_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            contact_title.HeaderText = "contact_title";
            contact_title.Name = "contact_title";
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "address";
            address.Name = "address";
            // 
            // city
            // 
            city.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            city.HeaderText = "city";
            city.Name = "city";
            // 
            // region
            // 
            region.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            region.HeaderText = "region";
            region.Name = "region";
            // 
            // postal_code
            // 
            postal_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            postal_code.HeaderText = "postal_code";
            postal_code.Name = "postal_code";
            // 
            // country
            // 
            country.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            country.HeaderText = "country";
            country.Name = "country";
            // 
            // phone
            // 
            phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone.HeaderText = "phone";
            phone.Name = "phone";
            // 
            // fax
            // 
            fax.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fax.HeaderText = "fax";
            fax.Name = "fax";
            // 
            // btn_addCustomer
            // 
            btn_addCustomer.Dock = DockStyle.Right;
            btn_addCustomer.FlatStyle = FlatStyle.System;
            btn_addCustomer.Font = new Font("Segoe UI", 12F);
            btn_addCustomer.Location = new Point(1209, 306);
            btn_addCustomer.Name = "btn_addCustomer";
            btn_addCustomer.Size = new Size(141, 298);
            btn_addCustomer.TabIndex = 0;
            btn_addCustomer.Text = "Добавить клиента";
            btn_addCustomer.UseVisualStyleBackColor = true;
            btn_addCustomer.Click += btn_addCustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 641);
            Controls.Add(tab_Connection);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tab_Connection.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip_connection.ResumeLayout(false);
            statusStrip_connection.PerformLayout();
            tab_inquiry.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_resultQuery).EndInit();
            tab_addData.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_addCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_Connection;
        private TabPage tabPage1;
        private TabPage tab_inquiry;
        private SplitContainer splitContainer1;
        private Label lbl_serverName;
        private Button btn_Connection;
        private TextBox txt_Password;
        private TextBox txt_userName;
        private TextBox txt_hostName;
        private Label lbl_Password;
        private Label lbl_userName;
        private Button btn_disconnect;
        private ListView lstvConnectionStrings;
        private ColumnHeader Seq;
        private ColumnHeader ConnectionName;
        private ColumnHeader Provider;
        private ColumnHeader ConnectionString;
        private SplitContainer splitContainer2;
        private TextBox txt_customerID;
        private Label lbl_custtomerID;
        private TextBox txt_country;
        private Label lbl_phone;
        private TextBox txt_contactName;
        private Label lbl_contactName;
        private StatusStrip statusStrip_connection;
        private ToolStripStatusLabel lbltoolStripStatus;
        private TextBox txt_city;
        private Label lbl_city;
        private TextBox txt_orderDate;
        private Label lbl_orderDate;
        private TextBox txt_orderID;
        private Label lbl_orderID;
        private DataGridView dgv_resultQuery;
        
        private Button btn_saveToCSV;
        private Button btn_Customer_Orders;
        private Button btn_saveToXML;
        private Button btn_loadCustomers;
        private Button btn_customers;
        private TabPage tab_addData;
        private Button btn_addOrder;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn orderId;
        private DataGridViewTextBoxColumn customerId;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn shippedDate;
        private DataGridViewTextBoxColumn shipVia;
        private DataGridViewTextBoxColumn shipAddress;
        private DataGridViewTextBoxColumn shipCity;
        private DataGridViewTextBoxColumn shipCountry;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgv_addCustomer;
        private Button btn_addCustomer;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn company_name;
        private DataGridViewTextBoxColumn contact_name;
        private DataGridViewTextBoxColumn contact_title;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn region;
        private DataGridViewTextBoxColumn postal_code;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn fax;
        //private Button btn_loadCustomers;
    }
}
