using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myDBProject
{
    internal class LoadData
    {

        //private string connectionString;

        private NpgsqlConnection connection;

        public LoadData(NpgsqlConnection connection)
        {
           // this.connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;
            this.connection = connection;
        }

        public DataTable DataLoadCustomer()
        {
            DataTable dt = new DataTable();
            try
            {
                string querry = @"SELECT customer_id, 
                                         contact_name, 
                                         phone 
                                    FROM public.customers;";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(querry, connection);
                {
                    adapter.Fill(dt);
                }

            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Ошибка:" + ex);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Общая ошибка: " + ex.Message);
                }

            }
            return dt;

        }

        public DataTable DataLoad_CustomerOrders(string city = null, string country = null, string customer_id = null, int? order_id = null)
        {
            DataTable dt = new DataTable();
            try
            {
                // Базовый SQL-запрос
                string querry = @"
                    SELECT     pc.customer_id, pc.contact_name, pc.city, pc.country, 
                               po.order_id, po.order_date, po.ship_city, po.ship_country 
                    FROM       public.customers pc 
                    INNER JOIN public.orders po ON pc.customer_id = po.customer_id 
                    WHERE 1=1";
                               

                // Добавляем условия фильтрации
                if (!string.IsNullOrEmpty(city))
                {
                    querry += " AND pc.city = @city";
                }
                if (!string.IsNullOrEmpty(country))
                {
                    querry += " AND pc.country = @country";
                }
                if (!string.IsNullOrEmpty(customer_id))
                {
                    querry += " AND pc.customer_id = @customer_id";
                }
                if (order_id.HasValue)
                {
                    querry += " AND po.order_id = @order_id";
                }

                //Добавляем параметры для фильтрации
                // Создаем команду
                NpgsqlCommand command = new NpgsqlCommand(querry, connection);

                if (!string.IsNullOrEmpty(city))
                {
                    command.Parameters.AddWithValue("@city", city);
                }
                if (!string.IsNullOrEmpty(country))
                {
                    command.Parameters.AddWithValue("@country", country);
                }
                if (!string.IsNullOrEmpty(customer_id))
                {
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                }
                if (order_id.HasValue)
                {
                    command.Parameters.AddWithValue("@order_id", order_id);
                }
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }

            }

            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Ошибка:" + ex);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Общая ошибка: " + ex.Message);
                }

            }
            return dt;


        }

    }
}
