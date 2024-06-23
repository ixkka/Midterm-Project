using System.Data;
using System.Text;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttontest_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backspcBtn_Click(object sender, EventArgs e)
        {
            if (displayTxtBox.Text.Length >= 3 && displayTxtBox.Text.EndsWith(" "))
            {
                displayTxtBox.Text = displayTxtBox.Text.Remove(displayTxtBox.Text.Length - 3);
            } else if (displayTxtBox.Text.Length >= 1)
            {
                displayTxtBox.Text = displayTxtBox.Text.Remove(displayTxtBox.Text.Length - 1);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayTxtBox.Clear();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "0";
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "1";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "3";
        }


        private void fourBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "9";
        }

        private void decimalPtBtn_Click(object sender, EventArgs e)
        {
            string text = displayTxtBox.Text;
            if (!text.EndsWith(".") && !text.Split(" ").Last().Contains("."))
            {
                displayTxtBox.Text += ".";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += " + ";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += " - ";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += " * ";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += " / ";
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            calculateResult();
        }

        private void calculateResult()
        {
            try
            {
                string expression = displayTxtBox.Text;
                var result = EvaluateExpression(expression);
                displayTxtBox.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid expression. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            Stack<double> operandStack = new Stack<double>();
            Stack<char> operatorStack = new Stack<char>();

            int i = 0;
            while (i < expression.Length)
            {
                char currentChar = expression[i];

                if (char.IsDigit(currentChar) || currentChar == '.')
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        sb.Append(expression[i]);
                        i++;
                    }
                    double number = double.Parse(sb.ToString());
                    operandStack.Push(number);
                }
                else if (IsOperator(currentChar))
                {
                    while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(currentChar))
                    {
                        ProcessOperator(operandStack, operatorStack);
                    }
                    operatorStack.Push(currentChar);
                    i++;
                }
                else
                {
                    i++;
                }
            }

            while (operatorStack.Count > 0)
            {
                ProcessOperator(operandStack, operatorStack);
            }

            if (operandStack.Count == 1)
            {
                return operandStack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression.");
            }
        }
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

        private void ProcessOperator(Stack<double> operandStack, Stack<char> operatorStack)
        {
            char op = operatorStack.Pop();
            double right = operandStack.Pop();
            double left = operandStack.Pop();
            double result = ApplyOperator(left, op, right);
            operandStack.Push(result);
        }

        private double ApplyOperator(double left, char op, double right)
        {
            switch (op)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    if (right == 0)
                        throw new DivideByZeroException("Division by zero.");
                    return left / right;
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }
    }


}
