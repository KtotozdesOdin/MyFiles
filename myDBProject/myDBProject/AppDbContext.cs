using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.EntityFrameworkCore.Scaffolding;
using System.Configuration;

namespace myDBProject
{
    internal class AppDbContext : DbContext
    {
       
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;
                optionsBuilder.UseNpgsql(connectionString);

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка первичного ключа
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.customer_id); // Указываем, что customer_id является первичным ключом

            // Настройка имени таблицы (если оно отличается от имени класса)
            modelBuilder.Entity<Customer>()
                .ToTable("customers"); // Указываем имя таблицы в базе данных

            modelBuilder.Entity<Order>()
                .HasKey(c => c.order_id);// Указываем, что order_id является первичным ключом
            modelBuilder.Entity<Order>()
               .ToTable("orders"); // Указываем имя таблицы в базе данных
        }

        public void DeleteCustomer(string customer_id)
        {
            try
            {
                var context = new AppDbContext();
                

                var customer = context.Customers.Find(customer_id);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    MessageBox.Show($"Запись {customer} удалена");
                }
                else
                {
                    MessageBox.Show($"Запись {customer} не найдена");
                }
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Ошибка" + e);
            }

            
        }

        public void DeleteOrder(int order_id)
        {
            try
            {
                using (var context = new AppDbContext())
                { 
                    var order = context.Orders.Find(order_id);
                    if (order != null)
                    {
                        context.Orders.Remove(order);
                        context.SaveChanges();
                        MessageBox.Show($"Запись {order_id} удалена");
                    }
                    else
                    {
                        MessageBox.Show($"Запись {order_id} не найдена");
                    } 
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Ошибка" + e);
            }


        }
    }
}
