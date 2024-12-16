using PdfiumViewer;

namespace PDF_Reader
{
    public partial class Form1 : Form
    {
        private PdfViewer pdfViewer;

        public Form1()
        {
            InitializeComponent();
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            this.Controls.Add(pdfViewer);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "pdf|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pdfViewer.LoadFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
