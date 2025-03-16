using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDBProject
{
    public class Order
    {
        // Первичный ключ
        public int order_id { get; set; }

        // Внешний ключ на таблицу customers
        public string? customer_id { get; set; }

        // Внешний ключ на таблицу employees
        public int? employee_id { get; set; }

        // Дата заказа
        public DateTime? order_date { get; set; }

        // Требуемая дата доставки
        public DateTime? required_date { get; set; }

        // Фактическая дата доставки (может быть null)
        public DateTime? shipped_date { get; set; }

        // Внешний ключ на таблицу shippers (способ доставки)
        public int? ship_via { get; set; }

        // Стоимость доставки
       // public decimal? freight { get; set; }

        // Название судна
        public string? ship_name { get; set; }

        // Адрес доставки
        public string? ship_address { get; set; }

        // Город доставки
        public string? ship_city { get; set; }

        // Регион доставки (может быть null)
        public string? ship_region { get; set; }

        // Почтовый индекс доставки (может быть null)
        public string? ship_postal_code { get; set; }

        // Страна доставки
        public string ship_country { get; set; }
    }
}
