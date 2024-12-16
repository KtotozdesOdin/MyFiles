using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace MSExcel

{
    public partial class Form1 : Form
    {
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;

            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            workbook = app.Workbooks.Open(ofd.FileName);
            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
            ShtRange = NwSheet.UsedRange;
            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
            {

                DataTable.dt.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
            }
            DataTable.dt.AcceptChanges();
        }
    }
}
