namespace ROMB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Обработчик события Resize для формы
            this.Resize += Form1_Resize;

            // Первоначальное позиционирование кнопки
            CenterButton();

            button1 = new Button();
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void CenterButton()
        {
            button1.Location = new Point(this.ClientSize.Width / 2 - button1.Width / 2,
                                         this.ClientSize.Height / 2 - button1.Height / 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Определение координат вершин ромба
            int x1 = this.Width / 2;
            int y1 = 0;
            int x2 = this.Width;
            int y2 = this.Height / 2;
            int x3 = x1;
            int y3 = this.Height;
            int x4 = 0;
            int y4 = y2;

            // Создание объекта GraphicsPath для рисования ромба
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddLine(x1, y1, x2, y2);
            myPath.AddLine(x2, y2, x3, y3);
            myPath.AddLine(x3, y3, x4, y4);
            myPath.AddLine(x4, y4, x1, y1);

            // Создание Region из GraphicsPath
            Region myRegion = new Region(myPath);

            // Установка Region для формы
            this.Region = myRegion;
        }
    }
}
