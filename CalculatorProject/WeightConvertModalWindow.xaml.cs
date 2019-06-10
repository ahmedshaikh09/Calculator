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
using System.Windows.Shapes;

namespace CalculatorProject
{
    public partial class WeightConvertModalWindow : Window
    {
        private string Selection1 { get; set; }
        private string Selection2 { get; set; }
        private double Value { get; set; }

        public WeightConvertModalWindow()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selection1 = ComboBox1.Text;
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selection2 = ComboBox2.Text;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Selection1 = ComboBox1.Text;
            Selection2 = ComboBox2.Text;

            Value = double.Parse(Number.Text);
            txtResult.Text = GetResult(Value, Selection1, Selection2);
        }
        private string GetResult(double Number, string Selection1, string Selection2)
        {
            if (Selection1 == "Milligrams" && Selection2 == "Grams")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Milligrams" && Selection2 == "Kilograms")
            {
                return (Number / 1000000).ToString();
            }
            if (Selection1 == "Milligrams" && Selection2 == "Ounces")
            {
                return (Number / 28349.523).ToString();
            }
            if (Selection1 == "Milligrams" && Selection2 == "Pounds")
            {
                return (Number / 453592).ToString();
            }
            if (Selection1 == "Grams" && Selection2 == "Milligrams")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Grams" && Selection2 == "Kilograms")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Grams" && Selection2 == "Ounces")
            {
                return (Number / 28.35).ToString();
            }
            if (Selection1 == "Grams" && Selection2 == "Pounds")
            {
                return (Number / 453.592).ToString();
            }
            if (Selection1 == "Kilograms" && Selection2 == "Grams")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Kilograms" && Selection2 == "Milligrams")
            {
                return (Number * 1e+6).ToString();
            }
            if (Selection1 == "Kilograms" && Selection2 == "Ounces")
            {
                return (Number * 35.274).ToString();
            }
            if (Selection1 == "Kilograms" && Selection2 == "Pounds")
            {
                return (Number * 2.205).ToString();
            }
            if (Selection1 == "Ounces" && Selection2 == "Grams")
            {
                return (Number * 28.35).ToString();
            }
            if (Selection1 == "Ounces" && Selection2 == "Kilograms")
            {
                return (Number / 35.274).ToString();
            }
            if (Selection1 == "Ounces" && Selection2 == "Pounds")
            {
                return (Number / 16).ToString();
            }
            if (Selection1 == "Ounces" && Selection2 == "Milligrams")
            {
                return (Number * 28349.523).ToString();
            }
            if (Selection1 == "Pounds" && Selection2 == "Grams")
            {
                return (Number * 453.592).ToString();
            }
            if (Selection1 == "Pounds" && Selection2 == "Kilograms")
            {
                return (Number / 2.205).ToString();
            }
            if (Selection1 == "Pounds" && Selection2 == "Ounces")
            {
                return (Number * 16).ToString();
            }
            if (Selection1 == "Pounds" && Selection2 == "Milligrams")
            {
                return (Number * 453592.37).ToString();
            }
            if (Selection1 == Selection2)
            {
                return (Number).ToString();
            }
            else
            {
                return "0";
            }
        }
    }
}
