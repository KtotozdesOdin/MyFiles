namespace NotModal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string SolData
        {
            get
            { return textBoxF1.Text; }

            set
            { textBoxF1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
        }
    }
}
