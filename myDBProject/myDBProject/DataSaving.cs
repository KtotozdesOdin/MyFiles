using Npgsql;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDBProject
{
    internal class DataSaving
    {
        private NpgsqlConnection connection;

        public DataSaving(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public static void SaveToCSV(DataTable dataTable, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Записываем заголовки столбцов
                    IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);

                    writer.WriteLine(string.Join(",", columnNames));

                    // Записываем данные
                    foreach (DataRow row in dataTable.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        writer.WriteLine(string.Join(",", fields));
                    }
                }

                MessageBox.Show("Данные успешно сохранены в CSV-файл: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении в CSV-файл: " + ex.Message);
            }

        }

        public static void SaveToXML(DataTable dataTable, string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(dataTable.TableName))
                {
                    dataTable.TableName = "Table";
                }
                dataTable.WriteXml(filePath, XmlWriteMode.WriteSchema);
                MessageBox.Show("Данные успешно сохранены в XML-файл: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении в XML-файл: " + ex.Message);
            }

        }


    }
}
