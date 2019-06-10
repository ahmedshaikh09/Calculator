using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorProject
{
    public partial class MainWindow : Window
    {
        private Operator currentOperator;
        private double firstNumber;
        private double secondNumber;
        private double singleNumber;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;

            if (txtResult.Text != "0")
            {
                txtResult.Text = $"{txtResult.Text}{btn.Content}";
            }
            else
            {
                txtResult.Text = btn.Content.ToString();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            singleNumber = 0;
            currentOperator = 0;
            txtResult.Text = "0";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Add;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetResult(firstNumber, currentOperator, secondNumber);
        }
        private string GetResult(double firstNumber, Operator currentOperator, double secondNumber)
        {
            if (currentOperator == Operator.Add)
            {
                return (firstNumber + secondNumber).ToString();
            }
            else if (currentOperator == Operator.Substract)
            {
                return (firstNumber - secondNumber).ToString();
            }
            else if (currentOperator == Operator.Multiply)
            {
                return (firstNumber * secondNumber).ToString();
            }
            else if (currentOperator == Operator.Divide)
            {
                return (firstNumber / secondNumber).ToString();
            }
            else if (currentOperator == Operator.Modulus)
            {
                return (firstNumber % secondNumber).ToString();
            }
            else if (currentOperator == Operator.Power)
            {
                return Math.Pow(firstNumber, secondNumber).ToString();
            }
            else
            {
                return "0";
            }
        }
        private string GetSingleNumberResult(double singleNumber, Operator currentOperator)
        {
            if (currentOperator == Operator.Factorial)
            {
                int factorial = 1;
                for (int counter = 1; counter <= singleNumber; counter++)
                {
                    factorial = factorial * counter;
                }

                return factorial.ToString();
            }
            else if (currentOperator == Operator.Celsius)
            {
                return ((singleNumber - 32) * 5 / 9).ToString();
            }
            else if (currentOperator == Operator.Fahrenheit)
            {
                return (((9.0 / 5.0) * singleNumber) + 32).ToString();
            }
            else if (currentOperator == Operator.SquareRoot)
            {
                return (Math.Sqrt(singleNumber)).ToString();
            }
            else
            {
                return "0";
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Substract;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Multiply;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Divide;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (double.Parse(txtResult.Text) * -1).ToString();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Modulus;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.IndexOf('.') < 0)
            {
                txtResult.Text += ".";
            }
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Power;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Factorial;
            singleNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetSingleNumberResult(singleNumber, currentOperator);
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Celsius;
            singleNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetSingleNumberResult(singleNumber, currentOperator) + "°C";
        }
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Fahrenheit;
            singleNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetSingleNumberResult(singleNumber, currentOperator) + "°F";
        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.SquareRoot;
            singleNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetSingleNumberResult(singleNumber, currentOperator);
        }
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.HexaDecimal;
            singleNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetSingleNumberResult(singleNumber, currentOperator);
        }
        private void btnOpenModal_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow();
            modalWindow.ShowDialog();
        }

        private void btnOpenModal_Click2(object sender, RoutedEventArgs e)
        {
            WeightConvertModalWindow weightConvertModalWindow = new WeightConvertModalWindow();
            weightConvertModalWindow.ShowDialog();
        }
        private void btnOpenModal_Click3(object sender, RoutedEventArgs e)
        {
            LengthConvertModalWindow lengthConvertModalWindow = new LengthConvertModalWindow();
            lengthConvertModalWindow.ShowDialog();
        }
        private void btnOpenModal_Click4(object sender, RoutedEventArgs e)
        {
            PercentConvertModalWindow percentConvertModalWindow = new PercentConvertModalWindow();
            percentConvertModalWindow.ShowDialog();
        }
        private void btnOpenModal_Click5(object sender, RoutedEventArgs e)
        {
            FileSizeConvertModalWindow fileSizeConvertModalWindow = new FileSizeConvertModalWindow();
            fileSizeConvertModalWindow.ShowDialog();
        }
        private void btnOpenModal_Click6(object sender, RoutedEventArgs e)
        {
            IntegerConvertModalWindow integerConvertModalWindow = new IntegerConvertModalWindow();
            integerConvertModalWindow.ShowDialog();
        }

    }
    public enum Operator
    {
        Add,
        Substract,
        Multiply,
        Divide,
        Modulus,
        Power,
        Factorial,
        Celsius,
        Fahrenheit,
        SquareRoot,
        HexaDecimal
    }
}
