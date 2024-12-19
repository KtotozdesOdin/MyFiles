using System.Diagnostics.Eventing.Reader;
using System;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Numerics;
using System.ComponentModel;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void SetStandardMode()
        {
            buttonSin.Visible = false;
            buttonCos.Visible = false;
            buttonTan.Visible = false;
            buttonCtg.Visible = false;
            buttonFactorial.Visible = false;
            buttonPow.Visible = false;
            buttonReverse.Visible = false;
            button�ubeRoot.Visible = false;
            buttonEQN.Visible = false;

            this.Size = new Size(400, 500);
        }

        private void SetEngineeringMode()
        {
            // ���������� ���������� ������
            buttonSin.Visible = true;
            buttonCos.Visible = true;
            buttonTan.Visible = true;
            buttonCtg.Visible = true;
            buttonFactorial.Visible = true;
            buttonPow.Visible = true;
            buttonReverse.Visible = true;
            button�ubeRoot.Visible = true;
            buttonEQN.Visible = true;

            this.Size = new Size(500, 500);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private double currentResult = 0; // ������� ���������
        private bool isNewInput = true;  // ���� ��� ����������� ������ ����� �����
        private double op1, op2;
        private string currentOperator;
        private enum CalculatorState 
        {   InputFirstOperand, 
            InputOperator, 
            InputSecondOperand, 
            InputPower, 
            EQN, 
            Result 
        }
        private CalculatorState currentState = CalculatorState.InputFirstOperand;


        private double Calculate(double num1, double num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                        throw new DivideByZeroException("������� �� ���� ����������.");
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("����������� ��������.");
            }
        }

        private void SetOperator(string op)
        {
            try
            {
                // ���������, ��� � ���� ����� ���� �����
                if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
                {
                    double inputNumber = double.Parse(textBoxInput.Text);

                    if (!isNewInput)
                    {
                        // ���� ��� �� ������ ����, ��������� ���������� � ������� ����������
                        currentResult = Calculate(currentResult, inputNumber, currentOperator);
                        labelOutPut.Text = currentResult.ToString();
                    }
                    else
                    {
                        // ���� ��� ������ ����, ������������� ��������� �������� ����������
                        currentResult = inputNumber;
                        isNewInput = false;
                    }

                    // ������������� ����� ��������
                    currentOperator = op;

                    // ������� ���� ����� ��� ���������� �����
                    textBoxInput.Clear();
                }

                else if (isNewInput) // ���� ���� ������, �� �� ���������� �������� � �����������
                {
                    currentOperator = op;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void buttonPlus_Click(object sender, EventArgs e) => SetOperator("+");
        private void buttonMinus_Click(object sender, EventArgs e) => SetOperator("-");
        private void buttonMultiple_Click(object sender, EventArgs e) => SetOperator("*");
        private void buttonDivide_Click(object sender, EventArgs e) => SetOperator("/");

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentState == CalculatorState.InputPower)
                {
                    // ���������, ��� ������� ������� (� ���� textBoxInput)
                    if (double.TryParse(textBoxPower.Text, out double power))
                    {
                        // ��������� ��������� ���������� � �������
                        double result = Math.Pow(op1, power);

                        // ���������� ���������
                        labelOutPut.Text = result.ToString();

                        // ���������� ��������� ��� ����� ��������
                        currentState = CalculatorState.Result;
                        //textBoxInput.Clear();
                        //textBoxPower.Clear();
                    }
                    else
                    {
                        MessageBox.Show("������� ���������� �������� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                // ��� ��������� (�� �������)
                else if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
                {
                    double inputNumber = double.Parse(textBoxInput.Text);

                    // ��������� ��������� ����������
                    currentResult = Calculate(currentResult, inputNumber, currentOperator);

                    // ���������� ���������
                    labelOutPut.Text = currentResult.ToString();

                    // ���������� ��������� ��� ����� ��������
                    textBoxInput.Clear();
                    isNewInput = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDigit(string digit)
        {
            switch (currentState)
            {
                case CalculatorState.InputFirstOperand:
                case CalculatorState.InputSecondOperand:
                case CalculatorState.Result:
                case CalculatorState.EQN:
                    textBoxInput.Text += digit;
                    break;

                case CalculatorState.InputPower:
                    textBoxPower.Text += digit;
                    break;

                default:
                    // ��������� ������������ ��������� (�� ������ ������)
                    MessageBox.Show("����������� ��������� ������������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            
            }
        }

        private void button1_Click(object sender, EventArgs e) => AddDigit("1");
        private void button2_Click(object sender, EventArgs e) => AddDigit("2");

        private void button3_Click(object sender, EventArgs e) => AddDigit("3");

        private void button4_Click(object sender, EventArgs e) => AddDigit("4");

        private void button5_Click(object sender, EventArgs e) => AddDigit("5");

        private void button6_Click(object sender, EventArgs e) => AddDigit("6");

        private void button7_Click(object sender, EventArgs e) => AddDigit("7");

        private void button8_Click(object sender, EventArgs e) => AddDigit("8");

        private void button9_Click(object sender, EventArgs e) => AddDigit("9");

        private void button0_Click(object sender, EventArgs e) => AddDigit("0");

        private void button16_Click_1(object sender, EventArgs e) => AddDigit(",");
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
            textBoxPower.Text = string.Empty;
            labelOutPut.Text = string.Empty;

            op1 = 0;
            op2 = 0;
            currentOperator = "";
            currentState = CalculatorState.InputFirstOperand;

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double operand))
                {
                    double sqrtResult = Math.Sqrt(operand);
                    if (double.IsNaN(sqrtResult))
                    {
                        MessageBox.Show("������ ������� ������ �� �������������� �����",
                            "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        labelOutPut.Text = sqrtResult.ToString();
                        currentState = CalculatorState.Result;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� �������������� ������: {ex.Message}",
                    "����������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double operand))
                {
                    operand %= 360;
                    double radians = operand * Math.PI / 180.0;
                    double SinResult = Math.Sin(radians);
                    labelOutPut.Text = SinResult.ToString("F1");
                    currentState = CalculatorState.Result;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� �������������� ������: {ex.Message}",
                    "����������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double operand))
                {
                    operand %= 360;
                    double radians = operand * Math.PI / 180.0;
                    double CosResult = Math.Cos(radians);
                    labelOutPut.Text = CosResult.ToString("F1");
                    currentState = CalculatorState.Result;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� �������������� ������: {ex.Message}",
                    "����������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double operand))
                {
                    operand %= 360;
                    double radians = operand * Math.PI / 180.0;
                    double TanResult = Math.Tan(radians);
                    labelOutPut.Text = TanResult.ToString("F1");
                    currentState = CalculatorState.Result;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� �������������� ������: {ex.Message}",
                    "����������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCtg_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double operand))
                {
                    operand %= 360;
                    double radians = operand * Math.PI / 180.0;
                    double CtgResult = 1 / Math.Tan(radians);
                    labelOutPut.Text = CtgResult.ToString("F1");
                    currentState = CalculatorState.Result;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� �������������� ������: {ex.Message}",
                    "����������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStandardMode();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEngineeringMode();
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double f))
            {
                if (f < 0)
                {
                    textBoxInput.Text = "��������� �������������� ����� �� ���������.";
                }
                else
                {
                    BigInteger result = Factorial(f);
                    labelOutPut.Text = result.ToString();

                }
            }

        }
        private BigInteger Factorial(double n)
        {
            if (n == 0 || n == 1)
                return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }


        private void buttonPow_Click(object sender, EventArgs e)
        {
            // ���������, ��� ������� ��������� ����� (� ���� textBoxInput)
            if (double.TryParse(textBoxInput.Text, out double p))
            {
               
                op1 = p;
                // ������������� �� ���� �������
                currentState = CalculatorState.InputPower;
                labelOutPut.Text = "������� �������"; // ��������� ��� ������������
            }

            else
            {
                MessageBox.Show("������� ������� ����� ��� ���������� � �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ���������� � �������
        private void buttonPow2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double p))
            {
                double result = Math.Pow(p, 2);
                labelOutPut.Text = result.ToString();

            }
        }

        private void button�ubeRoot_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double number))
                {
                    double result = Math.Cbrt(number);
                    labelOutPut.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxInput.Text, out double p))
                {
                    if (p == 0)
                    {
                        MessageBox.Show("������� �� ���� ����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    double result = 1 / p;
                    labelOutPut.Text = result.ToString();

                }
                else
                {
                    MessageBox.Show("������� ���������� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // ��������� ������ ����������� ������
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // ��������� ������ ������� ����������� ���������
        //����� �������� ������ ������ ��� ����� ����� �������
        

        private void buttonEQN_Click(object sender, EventArgs e)
        {
            currentState = CalculatorState.EQN;
            if (currentState == CalculatorState.EQN)
            {

                string[] coefficients = textBoxInput.Text.Split(",");

                // ���������� ���������
                Console.WriteLine($"����: {textBoxInput.Text}");

                if (coefficients.Length == 3 &&
                    double.TryParse(coefficients[0], out double a) &&
                    double.TryParse(coefficients[1], out double b) &&
                    double.TryParse(coefficients[2], out double c))
                {
                    var result = SolveQuadraticEquation(a, b, c);

                    // ���������� ���������
                    Console.WriteLine($"������������: a={a}, b={b}, c={c}");
                    Console.WriteLine($"���������: x1={result.x1:F3}, x2 = {result.x2:F3}");

                    if (result.x1.HasValue && result.x2.HasValue)
                    {
                        labelOutPut.Text = $"x1 = {result.x1:F3}, x2 = {result.x2:F3}";

                    }
                    else if (result.x1.HasValue)
                    {
                        labelOutPut.Text = $"x = {result.x1:F3}";
                    }
                    else
                    {
                        labelOutPut.Text = "No roots.";
                    }

                    //textBoxInput.Clear();
                    currentState = CalculatorState.Result;
                }
                else
                {
                    MessageBox.Show("������� ��� ������������ ����� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBoxInput.Clear(); // ������� ���� ����� ��� ������ ���������
                //labelOutPut.Text = ""; // ������� ����� ����������
            }
        }

        // ����� ��� ������� ����������� ���������
        private (double? x1, double? x2) SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                MessageBox.Show("����������� 'a' �� ����� ���� ����� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return (null, null); // ��� �������������� ������
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return (x, null); // ���� ������
            }
            else
            {
                double sqrtD = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                return (x1, x2); // ��� �����
            }
        }
    }
}
