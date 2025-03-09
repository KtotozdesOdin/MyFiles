using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq;
using Npgsql;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace myDBProject
{
    public partial class Form1 : Form
    {

        private string connectionString;

        private NpgsqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;

            // Инициализация объекта подключения
            this.connection = new NpgsqlConnection();

            //Заполнение ListView данными о строке подключения
            foreach (ConnectionStringSettings cs in ConfigurationManager.ConnectionStrings)
            {
                ListViewItem item = new ListViewItem(cs.Name);
                item.SubItems.Add(cs.ProviderName);
                item.SubItems.Add(cs.Name);
                item.SubItems.Add(cs.ConnectionString);
                lstvConnectionStrings.Items.Add(item);
            }
            foreach (ColumnHeader column in lstvConnectionStrings.Columns)
            {
                column.Width = -2; // -2 означает автоматическую подгонку ширины колонки
            }

            btn_Connection.Enabled = true;
            btn_disconnect.Enabled = false;



        }

        private void btn_Connection_Click(object sender, EventArgs e)
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = txt_hostName.Text;
            builder.Port = 5432;
            builder.Database = "Northwind";
            builder.Username = txt_userName.Text;
            builder.Password = txt_Password.Text;
            string connectionString = builder.ConnectionString;

            try
            {
                //открываем соединение
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Соединение уже открыто!");
                }
                else
                {
                    this.connection = new NpgsqlConnection(connectionString);
                    connection.Open();
                    lbltoolStripStatus.Text = builder.Host + " " + builder.Port + " " + builder.Database;
                    statusStrip_connection.ForeColor = System.Drawing.Color.Green;
                    //MessageBox.Show("Подключено");
                    var connectionState = connection.State.ToString();
                    btn_disconnect.Enabled = true;
                }
            }
            catch (NpgsqlException ex)
            {
                lbltoolStripStatus.Text = connectionString;
                statusStrip_connection.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Ошибка подключения");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Введите данные для подключения");
            }
        }


        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                    lbltoolStripStatus.Text = "Соединение отключено!";
                    statusStrip_connection.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("База данных отключена");

                    btn_disconnect.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Соединение уже закрыто.");
                }
            }
            catch (Exception ex)
            {

                // Обработка ошибок при отключении
                MessageBox.Show("Ошибка при отключении: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }


        private void btn_Customer_Orders_Click(object sender, EventArgs e)
        {
            string cityFilter = txt_city.Text;
            string countryFilter = txt_country.Text;


            // Загружаем данные с фильтрами
            LoadData dataLoader = new LoadData(connection);
            DataTable dataTable = dataLoader.DataLoad_CustomerOrders(cityFilter, countryFilter);

            dgv_resultQuery.AutoGenerateColumns = false;
            dgv_resultQuery.Columns.Clear();
            dgv_resultQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Создаем столбцы вручную
            dgv_resultQuery.Columns.Add("customer_id", "customer ID");
            dgv_resultQuery.Columns.Add("contact_name", "contact Name");
            dgv_resultQuery.Columns.Add("phone", "phone"); // Добавляем недостающий столбец
            dgv_resultQuery.Columns.Add("city", "city");
            dgv_resultQuery.Columns.Add("country", "country");
            dgv_resultQuery.Columns.Add("order_id", "order id");
            dgv_resultQuery.Columns.Add("order_date", "order date");
            dgv_resultQuery.Columns.Add("ship_city", "ship city");
            dgv_resultQuery.Columns.Add("ship_country", "ship country");

            // Привязываем столбцы к полям DataTable
            dgv_resultQuery.Columns["customer_id"].DataPropertyName = "customer_id";
            dgv_resultQuery.Columns["contact_name"].DataPropertyName = "contact_name";
            dgv_resultQuery.Columns["phone"].DataPropertyName = "phone"; // Привязываем столбец phone
            dgv_resultQuery.Columns["city"].DataPropertyName = "city";
            dgv_resultQuery.Columns["country"].DataPropertyName = "country";
            dgv_resultQuery.Columns["order_id"].DataPropertyName = "order_id";
            dgv_resultQuery.Columns["order_date"].DataPropertyName = "order_date";
            dgv_resultQuery.Columns["ship_city"].DataPropertyName = "ship_city";
            dgv_resultQuery.Columns["ship_country"].DataPropertyName = "ship_country";

            // Привязываем данные
            dgv_resultQuery.DataSource = dataTable;

            dgv_resultQuery.DataSource = dataTable;
        }


        private void btn_customers_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData dataLoader = new LoadData(connection);
                DataTable dataTable = dataLoader.DataLoadCustomer();

                dgv_resultQuery.AutoGenerateColumns = false;
                dgv_resultQuery.Columns.Clear();
                dgv_resultQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Создаем столбцы вручную
                dgv_resultQuery.Columns.Add("customer_id", "Customer ID");
                dgv_resultQuery.Columns.Add("contact_name", "Contact Name");
                dgv_resultQuery.Columns.Add("phone", "Phone");

                // Привязываем столбцы к полям DataTable
                dgv_resultQuery.Columns["customer_id"].DataPropertyName = "customer_id";
                dgv_resultQuery.Columns["contact_name"].DataPropertyName = "contact_name";
                dgv_resultQuery.Columns["phone"].DataPropertyName = "phone";

                // Привязываем данные
                dgv_resultQuery.DataSource = dataTable;

                dgv_resultQuery.DataSource = dataTable;
            }
            catch (NpgsqlException ex)
            {
                lbltoolStripStatus.Text = connectionString;
                statusStrip_connection.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Ошибка подключения");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Введите данные для подключения");
            }
        }

        private void btn_saveToCSV_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dgv_resultQuery.DataSource;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "data.csv";
                saveFileDialog.Filter = "CSV Files(*.csv) |*.csv";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    DataSaving.SaveToCSV(dataTable, filePath);
                }
                else
                {
                    MessageBox.Show("Сохранение отменено.");
                }
            }
        }

        private void btn_saveToXML_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dgv_resultQuery.DataSource;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "data.xml";
                saveFileDialog.Filter = "XML Files(*.xml) |*.xml";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    DataSaving.SaveToXML(dataTable, filePath);
                }
                else
                {
                    MessageBox.Show("Сохранение отменено.");
                }
            }
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvOrders.Rows[0];

                int orderId = int.Parse(row.Cells["OrderId"].Value.ToString());
                string customerId = row.Cells["CustomerId"].Value.ToString();
                DateTime orderDate = DateTime.Parse(row.Cells["OrderDate"].Value.ToString());
                DateTime? shippedDate = string.IsNullOrEmpty(row.Cells["ShippedDate"].Value?.ToString()) ? (DateTime?)null : DateTime.Parse(row.Cells["ShippedDate"].Value.ToString());
                int shipVia = int.Parse(row.Cells["ShipVia"].Value.ToString());
                string shipAddress = row.Cells["ShipAddress"].Value.ToString();
                string shipCity = row.Cells["ShipCity"].Value.ToString();
                string shipCountry = row.Cells["ShipCountry"].Value.ToString();

                CreateData createData = new CreateData(connection);
                createData.AddOrder(orderId, customerId, orderDate, shippedDate, shipVia, shipAddress, shipCity, shipCountry);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли строки в DataGridView
            if (dgv_addCustomer.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для добавления.");
                return;
            }

            // Получаем первую строку (предполагаем, что данные вводятся в одну строку)
            DataGridViewRow row = dgv_addCustomer.Rows[0];

            // Проверяем, что все обязательные поля заполнены
            if (row.Cells["customer_id"].Value == null || row.Cells["company_name"].Value == null)
            {
                MessageBox.Show("Поля 'Customer ID' и 'Company Name' обязательны для заполнения.");
                return;
            }

            // Получаем данные из DataGridView
            string customerId = row.Cells["customer_id"].Value.ToString();
            string companyName = row.Cells["company_name"].Value.ToString();
            string contactName = row.Cells["contact_name"].Value?.ToString(); // Если значение null, используем null
            string contactTitle = row.Cells["contact_title"].Value?.ToString();
            string address = row.Cells["address"].Value?.ToString();
            string city = row.Cells["city"].Value?.ToString();
            string region = row.Cells["region"].Value?.ToString();
            string postalCode = row.Cells["postal_code"].Value?.ToString();
            string country = row.Cells["country"].Value?.ToString();
            string phone = row.Cells["phone"].Value?.ToString();
            string fax = row.Cells["fax"].Value?.ToString();

            // Создаем объект CreateData (предположим, что connection уже инициализирован)
            CreateData createData = new CreateData(connection);

            // Добавляем клиента
            createData.AddCustomer(customerId, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax);

            // Очищаем DataGridView после добавления
            dgv_addCustomer.Rows.Clear();
        }
    }
}
