using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        string expression = "0";
        float answer;
        char operater = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            expression += "1";
            txtDisplay.Text = expression;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            expression += "2";
            txtDisplay.Text = expression;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            expression += "3";
            txtDisplay.Text = expression;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            expression += "4";
            txtDisplay.Text = expression;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            expression += "5";
            txtDisplay.Text = expression;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            expression += "6";
            txtDisplay.Text = expression;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            expression += "7";
            txtDisplay.Text = expression;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            expression += "8";
            txtDisplay.Text = expression;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            expression += "9";
            txtDisplay.Text = expression;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            expression += "0";
            txtDisplay.Text = expression;
        }
        private void btn_decimal_Click(object sender, EventArgs e)
        {
            expression += ".";
            txtDisplay.Text = expression;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            UpadteExpressionAfterAnswer();
            operater = '+';
            expression += "+";
            txtDisplay.Text = expression;
        }
        private void btn_sub_Click(object sender, EventArgs e)
        {
            UpadteExpressionAfterAnswer();
            operater = '-';
            expression += "-";
            txtDisplay.Text = expression;
        }
        private void btn_multiple_Click(object sender, EventArgs e)
        {
            UpadteExpressionAfterAnswer();
            operater = '*';
            expression += "*";
            txtDisplay.Text = expression;
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            UpadteExpressionAfterAnswer();
            operater = '/';
            expression += "/";
            txtDisplay.Text = expression;
        }
        private void btn_Modules_Click(object sender, EventArgs e)
        {
            UpadteExpressionAfterAnswer();
            operater = '%';
            expression += "%";
            txtDisplay.Text = expression;
        }
        private void btn_CE_Click(object sender, EventArgs e)
        {
            expression = "0";
            if (operater == ' ')
            {
                txtDisplay.Text = " ";
                expression = "0";
                operater = ' ';
            }
            txtDisplay.Text = expression;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (expression.Length > 0)
            {
                expression = expression.Remove(expression.Length - 1, 1);
            }
            txtDisplay.Text = expression;
        }

        private void btn_ans_Click(object sender, EventArgs e)
        {
            answer = getAnswer();
            operater = ' ';
            expression = answer.ToString();
            txtDisplay.Text = answer.ToString();

        }
        public float getAnswer()
        {
            string[] components = expression.Split(operater);
            if (components.Length > 1)
            {
                switch (operater)
                {

                    case '+':
                        {
                            answer = float.Parse(components[0]) + float.Parse(components[1]);
                            break;
                        }
                    case '-':
                        {
                            answer = float.Parse(components[0]) - float.Parse(components[1]);
                            break;
                        }
                    case '*':
                        {
                            answer = float.Parse(components[0]) * float.Parse(components[1]);
                            break;
                        }
                    case '/':
                        {
                            answer = float.Parse(components[0]) / float.Parse(components[1]);
                            break;
                        }
                    case '%':
                        {
                            answer = float.Parse(components[0]) % float.Parse(components[1]);
                            break;
                        }
                    case ' ':
                        {
                            answer = answer;
                            break;
                        }
                }
            }
            return answer;
        }
        public bool isComponentsAreNumber(string[] components)
        {
            foreach(var number in components)
            {
                switch (number)
                {

                    case "+":
                        {
                            return false;
                        }
                    case "-":
                        {
                            return false;
                        }
                    case "*":
                        {
                            return false;
                        }
                    case "/":
                        {
                            return false;
                        }
                    case "%":
                        {
                            return false;
                        }
                    case " ":
                        {
                            return false; 
                        }
                }
            }
            return true;
        }
        public void UpadteExpressionAfterAnswer()
        {
            if (operater != ' ')
            {
                answer = getAnswer();
                expression = " ";
                expression += answer.ToString();
            }
        }

    }
}