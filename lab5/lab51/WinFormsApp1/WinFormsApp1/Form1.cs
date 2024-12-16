using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;

        private DataTable dt = new DataTable();
        //private OpenFileDialog ofd = new OpenFileDialog(); // Добавлено объявление ofd

        public Form1()
        {
            InitializeComponent();
            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; // Добавлено для удобства выбора файлов
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                LoadExcelData(ofd.FileName); // Вынесено в отдельную функцию
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExcelData(string filePath)
        {
            try
            {
                app = new ExcelObj.Application();
                workbook = app.Workbooks.Open(filePath);
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets[1]; // Упрощенное получение листа
                ShtRange = NwSheet.UsedRange;

                // Заполнение DataTable
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    string columnName = (ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2?.ToString() ?? $"Column{Cnum}"; // Обработка null
                    dt.Columns.Add(new DataColumn(columnName));
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        object cellValue = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2;
                        dr[Cnum - 1] = cellValue == null ? DBNull.Value : cellValue.ToString(); // Обработка null
                    }
                    dt.Rows.Add(dr);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Освобождение ресурсов COM
                ReleaseObject(NwSheet);
                ReleaseObject(workbook);
                ReleaseObject(app);
            }
        }


        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}