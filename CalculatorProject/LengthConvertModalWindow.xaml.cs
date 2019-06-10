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

    public partial class LengthConvertModalWindow : Window
    {
        private string Selection1 { get; set; }
        private string Selection2 { get; set; }
        private double Value { get; set; }

        public LengthConvertModalWindow()
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
            if (Selection1 == "Millimetres" && Selection2 == "Centimeters")
            {
                return (Number / 10).ToString();
            }
            if (Selection1 == "Millimetres" && Selection2 == "Meters")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Millimetres" && Selection2 == "Kilometers")
            {
                return (Number / 1e+6).ToString();
            }
            if (Selection1 == "Millimetres" && Selection2 == "Inches")
            {
                return (Number / 25.4).ToString();
            }
            if (Selection1 == "Millimetres" && Selection2 == "Feet")
            {
                return (Number / 304.8).ToString();
            }
            if (Selection1 == "Centimeters" && Selection2 == "Millimetres")
            {
                return (Number * 10).ToString();
            }
            if (Selection1 == "Centimeters" && Selection2 == "Meters")
            {
                return (Number / 100).ToString();
            }
            if (Selection1 == "Centimeters" && Selection2 == "Kilometers")
            {
                return (Number / 100000).ToString();
            }
            if (Selection1 == "Centimeters" && Selection2 == "Inches")
            {
                return (Number / 2.54).ToString();
            }
            if (Selection1 == "Centimeters" && Selection2 == "Feet")
            {
                return (Number / 30.48).ToString();
            }
            if (Selection1 == "Meters" && Selection2 == "Millimetres")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Meters" && Selection2 == "Centimeters")
            {
                return (Number * 100).ToString();
            }
            if (Selection1 == "Meters" && Selection2 == "Kilometers")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Meters" && Selection2 == "Inches")
            {
                return (Number * 39.37).ToString();
            }
            if (Selection1 == "Meters" && Selection2 == "Feet")
            {
                return (Number * 3.281).ToString();
            }
            if (Selection1 == "Kilometers" && Selection2 == "Millimetres")
            {
                return (Number * 1e+6).ToString();
            }
            if (Selection1 == "Kilometers" && Selection2 == "Centimeters")
            {
                return (Number * 100000).ToString();
            }
            if (Selection1 == "Kilometers" && Selection2 == "Meters")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Kilometers" && Selection2 == "Inches")
            {
                return (Number * 39370.079).ToString();
            }
            if (Selection1 == "Kilometers" && Selection2 == "Feet")
            {
                return (Number * 3280.84).ToString();
            }
            if (Selection1 == "Inches" && Selection2 == "Millimetres")
            {
                return (Number * 25.4).ToString();
            }
            if (Selection1 == "Inches" && Selection2 == "Centimeters")
            {
                return (Number * 2.54).ToString();
            }
            if (Selection1 == "Inches" && Selection2 == "Meters")
            {
                return (Number / 39.37).ToString();
            }
            if (Selection1 == "Inches" && Selection2 == "Kilometers")
            {
                return (Number / 39370.079).ToString();
            }
            if (Selection1 == "Inches" && Selection2 == "Feet")
            {
                return (Number / 12).ToString();
            }
            if (Selection1 == "Feet" && Selection2 == "Millimetres")
            {
                return (Number * 304.8).ToString();
            }
            if (Selection1 == "Feet" && Selection2 == "Centimeters")
            {
                return (Number * 30.48).ToString();
            }
            if (Selection1 == "Feet" && Selection2 == "Meters")
            {
                return (Number / 3.281).ToString();
            }
            if (Selection1 == "Feet" && Selection2 == "Kilometers")
            {
                return (Number / 3280.84).ToString();
            }
            if (Selection1 == "Feet" && Selection2 == "Inches")
            {
                return (Number * 12).ToString();
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
