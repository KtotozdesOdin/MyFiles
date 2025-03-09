using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDBProject
{
    internal class CreateData
    {
        private NpgsqlConnection connection;

        public CreateData(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public void AddOrder(int orderId, string customerId = null, DateTime? orderDate = null, DateTime? shippedDate = null, int? shipVia = null,
            string shipAddress = null, string shipCity = null, string shipCountry = null)
        {
            try
            {
                string querry = @"INSERT INTO public.orders(order_id, customer_id, order_date, shipped_date, 
                                                        ship_via, ship_address, ship_city, ship_country)
	                          VALUES (@orderId, @customerId, @orderDate, @shippedDate, @shipVia, @shipAddress, @shipCity, @shipCountry);";

                using (NpgsqlCommand command = new NpgsqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@orderDate", orderDate);                    
                    command.Parameters.AddWithValue("@shippedDate", shippedDate ?? (object)DBNull.Value); // Если shippedDate равен null, используем DBNull.Value
                    command.Parameters.AddWithValue("@shipVia", shipVia ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@shipAddress", shipAddress);
                    command.Parameters.AddWithValue("@shipCity", shipCity);
                    command.Parameters.AddWithValue("@shipCountry", shipCountry);

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();

                }
                if (orderId == null)
                {
                    MessageBox.Show("Поле 'Order ID' не может быть пустым.");
                    return;
                }
                if (orderDate > DateTime.Now)
                {
                    MessageBox.Show("Дата заказа не может быть в будущем.");
                    return;
                }
                else
                {
                    MessageBox.Show("Заказ добавлен!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
            }
            
            finally
            {
                // Закрываем соединение (если нужно)
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void AddCustomer(string customerId, string companyName, string contactName = null, string contactTitle = null, 
                                string address = null, string city = null, string region = null, string postalCode = null, 
                                string country = null, string phone = null, string fax = null)
        {
            try
            {
                string querry = @" INSERT INTO public.customers (
                            customer_id, company_name, contact_name, contact_title, address, 
                            city, region, postal_code, country, phone, fax
                            ) 
                            VALUES (@customerId, @companyName, @contactName, @contactTitle, 
                                    @address, @city, @region, @postalCode, @country, @phone, @fax
                            );";

                using (NpgsqlCommand command = new NpgsqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@companyName", companyName);
                    command.Parameters.AddWithValue("@contactName", contactName);
                    command.Parameters.AddWithValue("@contactTitle", contactTitle ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@address", address); 
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@region", region ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@postalCode", postalCode ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@country", country);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@fax", fax);

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();

                }
                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("Поле 'Customer ID' не может быть пустым.");
                    return;
                }
                if (string.IsNullOrEmpty(companyName))
                {
                    MessageBox.Show("Поле 'company Name' не может быть пустым.");
                    return;
                }
                else
                {
                    MessageBox.Show("Клиент добавлен!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
            }
            finally
            {
                // Закрываем соединение (если нужно)
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
