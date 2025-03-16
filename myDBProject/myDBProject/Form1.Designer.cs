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
            components = new System.ComponentModel.Container();
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
            label19 = new Label();
            btn_saveToXML = new Button();
            btn_customers = new Button();
            btn_saveToCSV = new Button();
            btn_Customer_Orders = new Button();
            txt_city = new TextBox();
            txt_country = new TextBox();
            lbl_city = new Label();
            lbl_phone = new Label();
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
            Page_Customers = new TabPage();
            txtShipAddress = new TextBox();
            txtShipName = new TextBox();
            txtFreight = new TextBox();
            txtShipVia = new TextBox();
            txtShippedDate = new TextBox();
            txtShipCountry = new TextBox();
            btn_DeleteCustomer = new Button();
            btn_Addcust = new Button();
            label9 = new Label();
            label16 = new Label();
            label18 = new Label();
            label12 = new Label();
            label4 = new Label();
            label8 = new Label();
            label17 = new Label();
            label15 = new Label();
            label_contactTitle = new Label();
            label7 = new Label();
            label14 = new Label();
            label10 = new Label();
            contactNameAddLable = new Label();
            label6 = new Label();
            label13 = new Label();
            txtEmployeeId = new Label();
            lbl_companyName = new Label();
            label1 = new Label();
            label5 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lbl_customerId = new Label();
            txtRequiredDate = new TextBox();
            txtShipCity = new TextBox();
            txtCountry = new TextBox();
            txtAddress = new TextBox();
            txtPostalCode = new TextBox();
            txtContactTitle = new TextBox();
            txtRegion = new TextBox();
            txtOrderDate = new TextBox();
            txtFax = new TextBox();
            txtContactName = new TextBox();
            textBox2 = new TextBox();
            txtCity = new TextBox();
            txtOrderId = new TextBox();
            txtCompanyName = new TextBox();
            txtCustomerId = new TextBox();
            btn_deleteOrder = new Button();
            btn_showOrders = new Button();
            btn_showCustomers = new Button();
            dgv_CustomerTable = new DataGridView();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            bindingSource1 = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            label20 = new Label();
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
            Page_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CustomerTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tab_Connection
            // 
            tab_Connection.Controls.Add(tabPage1);
            tab_Connection.Controls.Add(tab_inquiry);
            tab_Connection.Controls.Add(tab_addData);
            tab_Connection.Controls.Add(Page_Customers);
            tab_Connection.Dock = DockStyle.Fill;
            tab_Connection.Location = new Point(0, 0);
            tab_Connection.Name = "tab_Connection";
            tab_Connection.SelectedIndex = 0;
            tab_Connection.Size = new Size(944, 711);
            tab_Connection.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(876, 633);
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
            splitContainer1.Size = new Size(870, 627);
            splitContainer1.SplitterDistance = 343;
            splitContainer1.TabIndex = 0;
            // 
            // btn_disconnect
            // 
            btn_disconnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_disconnect.FlatStyle = FlatStyle.System;
            btn_disconnect.Font = new Font("Segoe UI", 12F);
            btn_disconnect.Location = new Point(43, 529);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(270, 55);
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
            btn_Connection.Location = new Point(43, 449);
            btn_Connection.Name = "btn_Connection";
            btn_Connection.Size = new Size(270, 55);
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
            txt_Password.Size = new Size(181, 23);
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
            txt_userName.Size = new Size(181, 23);
            txt_userName.TabIndex = 2;
            txt_userName.Text = "just_user";
            txt_userName.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_hostName
            // 
            txt_hostName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_hostName.Location = new Point(85, 55);
            txt_hostName.Name = "txt_hostName";
            txt_hostName.Size = new Size(181, 23);
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
            lbl_Password.Size = new Size(219, 23);
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
            lbl_userName.Size = new Size(219, 23);
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
            lbl_serverName.Size = new Size(219, 23);
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
            lstvConnectionStrings.Size = new Size(523, 605);
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
            statusStrip_connection.Location = new Point(0, 605);
            statusStrip_connection.Name = "statusStrip_connection";
            statusStrip_connection.Size = new Size(523, 22);
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
            tab_inquiry.Size = new Size(876, 633);
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
            splitContainer2.Panel1.Controls.Add(label19);
            splitContainer2.Panel1.Controls.Add(btn_saveToXML);
            splitContainer2.Panel1.Controls.Add(btn_customers);
            splitContainer2.Panel1.Controls.Add(btn_saveToCSV);
            splitContainer2.Panel1.Controls.Add(btn_Customer_Orders);
            splitContainer2.Panel1.Controls.Add(txt_city);
            splitContainer2.Panel1.Controls.Add(txt_country);
            splitContainer2.Panel1.Controls.Add(lbl_city);
            splitContainer2.Panel1.Controls.Add(lbl_phone);
            splitContainer2.Panel1.Controls.Add(txt_orderID);
            splitContainer2.Panel1.Controls.Add(txt_customerID);
            splitContainer2.Panel1.Controls.Add(lbl_orderID);
            splitContainer2.Panel1.Controls.Add(lbl_custtomerID);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgv_resultQuery);
            splitContainer2.Size = new Size(870, 627);
            splitContainer2.SplitterDistance = 258;
            splitContainer2.TabIndex = 0;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label19.Location = new Point(194, 22);
            label19.Name = "label19";
            label19.Size = new Size(114, 25);
            label19.TabIndex = 11;
            label19.Text = "Фильтры";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_saveToXML
            // 
            btn_saveToXML.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_saveToXML.FlatStyle = FlatStyle.System;
            btn_saveToXML.Font = new Font("Segoe UI", 12F);
            btn_saveToXML.Location = new Point(528, 94);
            btn_saveToXML.Name = "btn_saveToXML";
            btn_saveToXML.Size = new Size(135, 40);
            btn_saveToXML.TabIndex = 9;
            btn_saveToXML.Text = "save XML";
            btn_saveToXML.UseVisualStyleBackColor = true;
            btn_saveToXML.Click += btn_saveToXML_Click;
            // 
            // btn_customers
            // 
            btn_customers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_customers.FlatStyle = FlatStyle.System;
            btn_customers.Font = new Font("Segoe UI", 12F);
            btn_customers.Location = new Point(684, 25);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(141, 42);
            btn_customers.TabIndex = 8;
            btn_customers.Text = "Клиенты";
            btn_customers.UseVisualStyleBackColor = true;
            btn_customers.Click += btn_customers_Click;
            // 
            // btn_saveToCSV
            // 
            btn_saveToCSV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_saveToCSV.FlatStyle = FlatStyle.System;
            btn_saveToCSV.Font = new Font("Segoe UI", 12F);
            btn_saveToCSV.Location = new Point(684, 97);
            btn_saveToCSV.Name = "btn_saveToCSV";
            btn_saveToCSV.Size = new Size(141, 40);
            btn_saveToCSV.TabIndex = 10;
            btn_saveToCSV.Text = "save CSV";
            btn_saveToCSV.UseVisualStyleBackColor = true;
            btn_saveToCSV.Click += btn_saveToCSV_Click;
            // 
            // btn_Customer_Orders
            // 
            btn_Customer_Orders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Customer_Orders.FlatStyle = FlatStyle.System;
            btn_Customer_Orders.Font = new Font("Segoe UI", 12F);
            btn_Customer_Orders.Location = new Point(528, 22);
            btn_Customer_Orders.Name = "btn_Customer_Orders";
            btn_Customer_Orders.Size = new Size(135, 41);
            btn_Customer_Orders.TabIndex = 7;
            btn_Customer_Orders.Text = "Клиент/Заказ";
            btn_Customer_Orders.UseVisualStyleBackColor = true;
            btn_Customer_Orders.Click += btn_Customer_Orders_Click;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(352, 118);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(111, 23);
            txt_city.TabIndex = 6;
            // 
            // txt_country
            // 
            txt_country.Location = new Point(135, 118);
            txt_country.Name = "txt_country";
            txt_country.Size = new Size(103, 23);
            txt_country.TabIndex = 3;
            // 
            // lbl_city
            // 
            lbl_city.Font = new Font("Segoe UI", 12F);
            lbl_city.Location = new Point(275, 118);
            lbl_city.Name = "lbl_city";
            lbl_city.Size = new Size(103, 23);
            lbl_city.TabIndex = 0;
            lbl_city.Text = "City";
            // 
            // lbl_phone
            // 
            lbl_phone.Font = new Font("Segoe UI", 12F);
            lbl_phone.Location = new Point(22, 120);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(142, 23);
            lbl_phone.TabIndex = 0;
            lbl_phone.Text = "Country";
            // 
            // txt_orderID
            // 
            txt_orderID.Location = new Point(352, 67);
            txt_orderID.Name = "txt_orderID";
            txt_orderID.Size = new Size(111, 23);
            txt_orderID.TabIndex = 4;
            // 
            // txt_customerID
            // 
            txt_customerID.Location = new Point(135, 67);
            txt_customerID.Name = "txt_customerID";
            txt_customerID.Size = new Size(103, 23);
            txt_customerID.TabIndex = 1;
            // 
            // lbl_orderID
            // 
            lbl_orderID.Font = new Font("Segoe UI", 12F);
            lbl_orderID.Location = new Point(275, 67);
            lbl_orderID.Name = "lbl_orderID";
            lbl_orderID.Size = new Size(103, 23);
            lbl_orderID.TabIndex = 0;
            lbl_orderID.Text = "Order ID";
            // 
            // lbl_custtomerID
            // 
            lbl_custtomerID.Font = new Font("Segoe UI", 12F);
            lbl_custtomerID.Location = new Point(22, 69);
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
            dgv_resultQuery.Size = new Size(870, 365);
            dgv_resultQuery.TabIndex = 0;
            // 
            // tab_addData
            // 
            tab_addData.Controls.Add(tableLayoutPanel1);
            tab_addData.Location = new Point(4, 24);
            tab_addData.Name = "tab_addData";
            tab_addData.Padding = new Padding(3);
            tab_addData.Size = new Size(876, 633);
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
            tableLayoutPanel1.Size = new Size(870, 627);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvOrders
            // 
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { orderId, customerId, orderDate, shippedDate, shipVia, shipAddress, shipCity, shipCountry });
            dgvOrders.Location = new Point(3, 3);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(714, 307);
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
            btn_addOrder.Location = new Point(726, 3);
            btn_addOrder.Name = "btn_addOrder";
            btn_addOrder.Size = new Size(141, 307);
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
            dgv_addCustomer.Location = new Point(3, 316);
            dgv_addCustomer.Name = "dgv_addCustomer";
            dgv_addCustomer.Size = new Size(714, 308);
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
            btn_addCustomer.Location = new Point(726, 316);
            btn_addCustomer.Name = "btn_addCustomer";
            btn_addCustomer.Size = new Size(141, 308);
            btn_addCustomer.TabIndex = 0;
            btn_addCustomer.Text = "Добавить клиента";
            btn_addCustomer.UseVisualStyleBackColor = true;
            btn_addCustomer.Click += btn_addCustomer_Click;
            // 
            // Page_Customers
            // 
            Page_Customers.Controls.Add(label20);
            Page_Customers.Controls.Add(txtShipAddress);
            Page_Customers.Controls.Add(txtShipName);
            Page_Customers.Controls.Add(txtFreight);
            Page_Customers.Controls.Add(txtShipVia);
            Page_Customers.Controls.Add(txtShippedDate);
            Page_Customers.Controls.Add(txtShipCountry);
            Page_Customers.Controls.Add(btn_DeleteCustomer);
            Page_Customers.Controls.Add(btn_Addcust);
            Page_Customers.Controls.Add(label9);
            Page_Customers.Controls.Add(label16);
            Page_Customers.Controls.Add(label18);
            Page_Customers.Controls.Add(label12);
            Page_Customers.Controls.Add(label4);
            Page_Customers.Controls.Add(label8);
            Page_Customers.Controls.Add(label17);
            Page_Customers.Controls.Add(label15);
            Page_Customers.Controls.Add(label_contactTitle);
            Page_Customers.Controls.Add(label7);
            Page_Customers.Controls.Add(label14);
            Page_Customers.Controls.Add(label10);
            Page_Customers.Controls.Add(contactNameAddLable);
            Page_Customers.Controls.Add(label6);
            Page_Customers.Controls.Add(label13);
            Page_Customers.Controls.Add(txtEmployeeId);
            Page_Customers.Controls.Add(lbl_companyName);
            Page_Customers.Controls.Add(label1);
            Page_Customers.Controls.Add(label5);
            Page_Customers.Controls.Add(txtPhone);
            Page_Customers.Controls.Add(label3);
            Page_Customers.Controls.Add(label2);
            Page_Customers.Controls.Add(lbl_customerId);
            Page_Customers.Controls.Add(txtRequiredDate);
            Page_Customers.Controls.Add(txtShipCity);
            Page_Customers.Controls.Add(txtCountry);
            Page_Customers.Controls.Add(txtAddress);
            Page_Customers.Controls.Add(txtPostalCode);
            Page_Customers.Controls.Add(txtContactTitle);
            Page_Customers.Controls.Add(txtRegion);
            Page_Customers.Controls.Add(txtOrderDate);
            Page_Customers.Controls.Add(txtFax);
            Page_Customers.Controls.Add(txtContactName);
            Page_Customers.Controls.Add(textBox2);
            Page_Customers.Controls.Add(txtCity);
            Page_Customers.Controls.Add(txtOrderId);
            Page_Customers.Controls.Add(txtCompanyName);
            Page_Customers.Controls.Add(txtCustomerId);
            Page_Customers.Controls.Add(btn_deleteOrder);
            Page_Customers.Controls.Add(btn_showOrders);
            Page_Customers.Controls.Add(btn_showCustomers);
            Page_Customers.Controls.Add(dgv_CustomerTable);
            Page_Customers.Location = new Point(4, 24);
            Page_Customers.Name = "Page_Customers";
            Page_Customers.Padding = new Padding(3);
            Page_Customers.Size = new Size(936, 683);
            Page_Customers.TabIndex = 3;
            Page_Customers.Text = "Entity Framework";
            Page_Customers.UseVisualStyleBackColor = true;
            // 
            // txtShipAddress
            // 
            txtShipAddress.Location = new Point(796, 535);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(100, 23);
            txtShipAddress.TabIndex = 5;
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(796, 505);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(100, 23);
            txtShipName.TabIndex = 5;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(796, 473);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(100, 23);
            txtFreight.TabIndex = 5;
            // 
            // txtShipVia
            // 
            txtShipVia.Location = new Point(796, 444);
            txtShipVia.Name = "txtShipVia";
            txtShipVia.Size = new Size(100, 23);
            txtShipVia.TabIndex = 5;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(796, 414);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(100, 23);
            txtShippedDate.TabIndex = 5;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(568, 542);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(100, 23);
            txtShipCountry.TabIndex = 5;
            // 
            // btn_DeleteCustomer
            // 
            btn_DeleteCustomer.FlatStyle = FlatStyle.System;
            btn_DeleteCustomer.Location = new Point(385, 618);
            btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            btn_DeleteCustomer.Size = new Size(122, 34);
            btn_DeleteCustomer.TabIndex = 4;
            btn_DeleteCustomer.Text = "Delete Customer";
            btn_DeleteCustomer.UseVisualStyleBackColor = true;
            btn_DeleteCustomer.Click += btn_DeleteCustomer_Click;
            // 
            // btn_Addcust
            // 
            btn_Addcust.FlatStyle = FlatStyle.System;
            btn_Addcust.Location = new Point(201, 618);
            btn_Addcust.Name = "btn_Addcust";
            btn_Addcust.Size = new Size(122, 34);
            btn_Addcust.TabIndex = 4;
            btn_Addcust.Text = "Add Customer";
            btn_Addcust.UseVisualStyleBackColor = true;
            btn_Addcust.Click += btn_Addcust_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(253, 535);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 3;
            label9.Text = "phone ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(687, 535);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 3;
            label16.Text = "ship Address";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(459, 545);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 3;
            label18.Text = "ship Country ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(459, 511);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 3;
            label12.Text = "required Date ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 538);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(253, 506);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 3;
            label8.Text = "country ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(687, 569);
            label17.Name = "label17";
            label17.Size = new Size(56, 15);
            label17.TabIndex = 3;
            label17.Text = "ship City ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(687, 506);
            label15.Name = "label15";
            label15.Size = new Size(61, 15);
            label15.TabIndex = 3;
            label15.Text = "shipName";
            // 
            // label_contactTitle
            // 
            label_contactTitle.AutoSize = true;
            label_contactTitle.Location = new Point(27, 509);
            label_contactTitle.Name = "label_contactTitle";
            label_contactTitle.Size = new Size(75, 15);
            label_contactTitle.TabIndex = 3;
            label_contactTitle.Text = "contact Title ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 477);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 3;
            label7.Text = "postalCode ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(687, 477);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 3;
            label14.Text = "freight";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(459, 477);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 3;
            label10.Text = "orderDate ";
            // 
            // contactNameAddLable
            // 
            contactNameAddLable.AutoSize = true;
            contactNameAddLable.Location = new Point(27, 480);
            contactNameAddLable.Name = "contactNameAddLable";
            contactNameAddLable.Size = new Size(85, 15);
            contactNameAddLable.TabIndex = 3;
            contactNameAddLable.Text = "contact Name ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 448);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 3;
            label6.Text = "region ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(687, 448);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 3;
            label13.Text = "shipVia ";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.AutoSize = true;
            txtEmployeeId.Location = new Point(459, 448);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(72, 15);
            txtEmployeeId.TabIndex = 3;
            txtEmployeeId.Text = "Employee Id";
            // 
            // lbl_companyName
            // 
            lbl_companyName.AutoSize = true;
            lbl_companyName.Location = new Point(27, 451);
            lbl_companyName.Name = "lbl_companyName";
            lbl_companyName.Size = new Size(95, 15);
            lbl_companyName.TabIndex = 3;
            lbl_companyName.Text = "company Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 561);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 3;
            label1.Text = "fax ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 419);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 3;
            label5.Text = "city ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(331, 532);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(687, 419);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "shipped Date ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 419);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "order Id";
            // 
            // lbl_customerId
            // 
            lbl_customerId.AutoSize = true;
            lbl_customerId.Location = new Point(27, 422);
            lbl_customerId.Name = "lbl_customerId";
            lbl_customerId.Size = new Size(70, 15);
            lbl_customerId.TabIndex = 3;
            lbl_customerId.Text = "customer id";
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(568, 508);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(100, 23);
            txtRequiredDate.TabIndex = 2;
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(796, 566);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(100, 23);
            txtShipCity.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(331, 503);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(136, 535);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 2;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(331, 474);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(100, 23);
            txtPostalCode.TabIndex = 2;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(136, 506);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(100, 23);
            txtContactTitle.TabIndex = 2;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(331, 445);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(100, 23);
            txtRegion.TabIndex = 2;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(568, 474);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(100, 23);
            txtOrderDate.TabIndex = 2;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(331, 561);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(100, 23);
            txtFax.TabIndex = 2;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(136, 477);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(100, 23);
            txtContactName.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 445);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(331, 416);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 2;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(568, 416);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(100, 23);
            txtOrderId.TabIndex = 2;
            toolTip1.SetToolTip(txtOrderId, "введите число");
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(136, 448);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 2;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(136, 419);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(100, 23);
            txtCustomerId.TabIndex = 2;
            toolTip1.SetToolTip(txtCustomerId, "не более 5 символов");
            // 
            // btn_deleteOrder
            // 
            btn_deleteOrder.FlatStyle = FlatStyle.System;
            btn_deleteOrder.Location = new Point(780, 618);
            btn_deleteOrder.Name = "btn_deleteOrder";
            btn_deleteOrder.Size = new Size(116, 34);
            btn_deleteOrder.TabIndex = 1;
            btn_deleteOrder.Text = "Delete Order";
            btn_deleteOrder.UseVisualStyleBackColor = true;
            btn_deleteOrder.Click += btn_deleteOrder_Click;
            // 
            // btn_showOrders
            // 
            btn_showOrders.FlatStyle = FlatStyle.System;
            btn_showOrders.Location = new Point(581, 618);
            btn_showOrders.Name = "btn_showOrders";
            btn_showOrders.Size = new Size(116, 34);
            btn_showOrders.TabIndex = 1;
            btn_showOrders.Text = "Show orders";
            btn_showOrders.UseVisualStyleBackColor = true;
            btn_showOrders.Click += btn_showOrders_Click;
            // 
            // btn_showCustomers
            // 
            btn_showCustomers.FlatStyle = FlatStyle.System;
            btn_showCustomers.Location = new Point(27, 618);
            btn_showCustomers.Name = "btn_showCustomers";
            btn_showCustomers.Size = new Size(122, 34);
            btn_showCustomers.TabIndex = 1;
            btn_showCustomers.Text = "Show customers";
            btn_showCustomers.UseVisualStyleBackColor = true;
            btn_showCustomers.Click += btn_showCustomers_Click;
            // 
            // dgv_CustomerTable
            // 
            dgv_CustomerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CustomerTable.Dock = DockStyle.Top;
            dgv_CustomerTable.Location = new Point(3, 3);
            dgv_CustomerTable.Name = "dgv_CustomerTable";
            dgv_CustomerTable.Size = new Size(930, 348);
            dgv_CustomerTable.TabIndex = 0;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(321, 363);
            label20.Name = "label20";
            label20.Size = new Size(294, 23);
            label20.TabIndex = 6;
            label20.Text = "Введите данные для добавления в БД";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 711);
            Controls.Add(tab_Connection);
            MinimumSize = new Size(960, 750);
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
            Page_Customers.ResumeLayout(false);
            Page_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CustomerTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
        private StatusStrip statusStrip_connection;
        private ToolStripStatusLabel lbltoolStripStatus;
        private TextBox txt_city;
        private Label lbl_city;
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
        private TabPage Page_Customers;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Button btn_showCustomers;
        private DataGridView dgv_CustomerTable;
        private BindingSource bindingSource1;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label_contactTitle;
        private Label label7;
        private Label contactNameAddLable;
        private Label label6;
        private Label lbl_companyName;
        private Label label5;
        private TextBox txtPhone;
        private Label lbl_customerId;
        private TextBox txtCountry;
        private TextBox txtAddress;
        private TextBox txtPostalCode;
        private TextBox txtContactTitle;
        private TextBox txtRegion;
        private TextBox txtContactName;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtCustomerId;
        private Label label1;
        private TextBox txtFax;
        private Button btn_Addcust;
        private Button btn_DeleteCustomer;
        private Button btn_deleteOrder;
        private Button btn_showOrders;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label txtEmployeeId;
        private Label label2;
        private TextBox txtRequiredDate;
        private TextBox textBox4;
        private TextBox txtOrderDate;
        private TextBox textBox2;
        private TextBox txtOrderId;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label3;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label label18;
        private Label label17;
        private TextBox textBox11;
        private TextBox txtShipCity;
        private TextBox txtShipAddress;
        private TextBox txtShipName;
        private TextBox txtFreight;
        private TextBox txtShipVia;
        private TextBox txtShippedDate;
        private TextBox txtShipCountry;
        private ToolTip toolTip1;
        private Label label19;
        private Label label20;
        //private Button btn_loadCustomers;
    }
}
