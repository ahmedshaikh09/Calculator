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
    public partial class IntegerConvertModalWindow : Window
    {
        private string Property { get; set; }
        private int Value { get; set; }

        public IntegerConvertModalWindow()
        {
            InitializeComponent();
        }
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Property = ComboBox1.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Property = ComboBox1.Text;

            Value = int.Parse(Number.Text);
            txtResult.Text = GetResult(Value, Property);
        }
        private string GetResult(int Number, string Selection1)
        {
            if (Property == "Hexadecimal")
            {
                return Number.ToString("X");
            }
            if (Property == "Octal")
            {
                return Convert.ToString(Number, 8);
            }
            if (Property == "Binary")
            {
                return Convert.ToString(Number, 2);
            }
            else  
            {
                return "0";
            }
        }

    }
}
