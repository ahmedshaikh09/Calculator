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
    public partial class FileSizeConvertModalWindow : Window
    {
        private string Selection1 { get; set; }
        private string Selection2 { get; set; }
        private double Value { get; set; }

        public FileSizeConvertModalWindow()
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
            if (Selection1 == "Bytes" && Selection2 == "Kilobytes")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Bytes" && Selection2 == "Gigabytes")
            {
                return (Number / 1e+9).ToString();
            }
            if (Selection1 == "Bytes" && Selection2 == "Megabytes")
            {
                return (Number / 1e+6).ToString();
            }
            if (Selection1 == "Bytes" && Selection2 == "Terabytes")
            {
                return (Number / 1e+12).ToString();
            }
            if (Selection1 == "Kilobytes" && Selection2 == "Bytes")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Kilobytes" && Selection2 == "Megabytes")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Kilobytes" && Selection2 == "Gigabytes")
            {
                return (Number / 1e+6).ToString();
            }
            if (Selection1 == "Kilobytes" && Selection2 == "Terabytes")
            {
                return (Number / 1e+9).ToString();
            }
            if (Selection1 == "Megabytes" && Selection2 == "Bytes")
            {
                return (Number * 1e+6).ToString();
            }
            if (Selection1 == "Megabytes" && Selection2 == "Kilobytes")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Megabytes" && Selection2 == "Gigabytes")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Megabytes" && Selection2 == "Terabytes")
            {
                return (Number / 1e+6).ToString();
            }
            if (Selection1 == "Gigabytes" && Selection2 == "Bytes")
            {
                return (Number * 1e+9).ToString();
            }
            if (Selection1 == "Gigabytes" && Selection2 == "Kilobytes")
            {
                return (Number * 1e+6).ToString();
            }
            if (Selection1 == "Gigabytes" && Selection2 == "Megabytes")
            {
                return (Number * 1000).ToString();
            }
            if (Selection1 == "Gigabytes" && Selection2 == "Terabytes")
            {
                return (Number / 1000).ToString();
            }
            if (Selection1 == "Terabytes" && Selection2 == "Bytes")
            {
                return (Number * 1e+12).ToString();
            }
            if (Selection1 == "Terabytes" && Selection2 == "Kilobytes")
            {
                return (Number * 1e+9).ToString();
            }
            if (Selection1 == "Terabytes" && Selection2 == "Megabytes")
            {
                return (Number * 1e+6).ToString();
            }
            if (Selection1 == "Terabytes" && Selection2 == "Gigabytes ")
            {
                return (Number * 1000).ToString();
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
