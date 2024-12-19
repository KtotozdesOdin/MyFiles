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
            buttonСubeRoot.Visible = false;
            buttonEQN.Visible = false;

            this.Size = new Size(400, 500);
        }

        private void SetEngineeringMode()
        {
            // Показываем инженерные кнопки
            buttonSin.Visible = true;
            buttonCos.Visible = true;
            buttonTan.Visible = true;
            buttonCtg.Visible = true;
            buttonFactorial.Visible = true;
            buttonPow.Visible = true;
            buttonReverse.Visible = true;
            buttonСubeRoot.Visible = true;
            buttonEQN.Visible = true;

            this.Size = new Size(500, 500);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private double currentResult = 0; // Текущий результат
        private bool isNewInput = true;  // Флаг для определения нового ввода числа
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
                        throw new DivideByZeroException("Деление на ноль невозможно.");
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("Неизвестный оператор.");
            }
        }

        private void SetOperator(string op)
        {
            try
            {
                // Проверяем, что в поле ввода есть число
                if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
                {
                    double inputNumber = double.Parse(textBoxInput.Text);

                    if (!isNewInput)
                    {
                        // Если это не первый ввод, выполняем вычисление с текущим оператором
                        currentResult = Calculate(currentResult, inputNumber, currentOperator);
                        labelOutPut.Text = currentResult.ToString();
                    }
                    else
                    {
                        // Если это первый ввод, устанавливаем начальное значение результата
                        currentResult = inputNumber;
                        isNewInput = false;
                    }

                    // Устанавливаем новый оператор
                    currentOperator = op;

                    // Очищаем поле ввода для следующего числа
                    textBoxInput.Clear();
                }

                else if (isNewInput) // Если поле пустое, но мы продолжаем работать с результатом
                {
                    currentOperator = op;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Проверяем, что введена степень (в поле textBoxInput)
                    if (double.TryParse(textBoxPower.Text, out double power))
                    {
                        // Вычисляем результат возведения в степень
                        double result = Math.Pow(op1, power);

                        // Отображаем результат
                        labelOutPut.Text = result.ToString();

                        // Сбрасываем состояние для новой операции
                        currentState = CalculatorState.Result;
                        //textBoxInput.Clear();
                        //textBoxPower.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное значение степени.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                // все остальное (не степень)
                else if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
                {
                    double inputNumber = double.Parse(textBoxInput.Text);

                    // Выполняем последнее вычисление
                    currentResult = Calculate(currentResult, inputNumber, currentOperator);

                    // Отображаем результат
                    labelOutPut.Text = currentResult.ToString();

                    // Сбрасываем состояние для новой операции
                    textBoxInput.Clear();
                    isNewInput = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Обработка неизвестного состояния (на случай ошибок)
                    MessageBox.Show("Неизвестное состояние калькулятора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Нельзя извлечь корень из отрицательного числа",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}",
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}",
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}",
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}",
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}",
                    "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStandardMode();
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEngineeringMode();
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double f))
            {
                if (f < 0)
                {
                    textBoxInput.Text = "Факториал отрицательного числа не определен.";
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
            // Проверяем, что введено основание числа (в поле textBoxInput)
            if (double.TryParse(textBoxInput.Text, out double p))
            {
               
                op1 = p;
                // Переключаемся на ввод степени
                currentState = CalculatorState.InputPower;
                labelOutPut.Text = "Введите степень"; // Подсказка для пользователя
            }

            else
            {
                MessageBox.Show("Сначала введите число для возведения в степень.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // возведение в квадрат
        private void buttonPow2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInput.Text, out double p))
            {
                double result = Math.Pow(p, 2);
                labelOutPut.Text = result.ToString();

            }
        }

        private void buttonСubeRoot_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    double result = 1 / p;
                    labelOutPut.Text = result.ToString();

                }
                else
                {
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Обработка других неожиданных ошибок
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // обработка кнопки решения квадратного уравнения
        //перед нажатием кнопки ввести три числа через запятую
        

        private void buttonEQN_Click(object sender, EventArgs e)
        {
            currentState = CalculatorState.EQN;
            if (currentState == CalculatorState.EQN)
            {

                string[] coefficients = textBoxInput.Text.Split(",");

                // Отладочное сообщение
                Console.WriteLine($"Ввод: {textBoxInput.Text}");

                if (coefficients.Length == 3 &&
                    double.TryParse(coefficients[0], out double a) &&
                    double.TryParse(coefficients[1], out double b) &&
                    double.TryParse(coefficients[2], out double c))
                {
                    var result = SolveQuadraticEquation(a, b, c);

                    // Отладочные сообщения
                    Console.WriteLine($"Коэффициенты: a={a}, b={b}, c={c}");
                    Console.WriteLine($"Результат: x1={result.x1:F3}, x2 = {result.x2:F3}");

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
                    MessageBox.Show("Введите три коэффициента через запятую.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBoxInput.Clear(); // Очищаем поле ввода для нового уравнения
                //labelOutPut.Text = ""; // Очищаем вывод результата
            }
        }

        // Метод для решения квадратного уравнения
        private (double? x1, double? x2) SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                MessageBox.Show("Коэффициент 'a' не может быть равен нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return (null, null); // Нет действительных корней
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return (x, null); // Один корень
            }
            else
            {
                double sqrtD = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                return (x1, x2); // Два корня
            }
        }
    }
}
