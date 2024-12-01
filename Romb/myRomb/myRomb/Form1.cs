namespace myRomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    this.FormBorderStyle = FormBorderStyle.None;
        //    this.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
        //    this.Region.Union(new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
        //    this.Region.Exclude(new System.Drawing.Rectangle(this.Width / 4, 0, this.Width / 2, this.Height / 2));
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Добавление эллипса, вписанного в прямоугольную форму 
            // заданной ширины и высоты 
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
