using Npgsql;
using System.Linq.Expressions;
using System.Data;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection();
        string testConnect = @" Host=localhost;Port=5432;Database=Northwind; Username=postgres;Password=372865; Persist Security Info=True;";

        private void btn_DBConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("���������� � ����� ������ ��������� �������");

                }
                else
                {
                    MessageBox.Show("���������� � ����� ������ ��� �����������");
                }
            }
            catch
            {
                MessageBox.Show("������ ���������� � ����� ������");
            }
        }

        private void btn_closeConnection_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("���������� � ����� ������ �������");
            }
            else
            {
                MessageBox.Show("���������� � ����� ������ ��� �������");
            }
        }
    }
}       
