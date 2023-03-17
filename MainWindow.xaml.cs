using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a, b, result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtSo1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtSo2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(txtSo1.Text);
            b = Int32.Parse(txtSo2.Text);
            result = a + b;
            txtResult.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(txtSo1.Text);
            b = Int32.Parse(txtSo2.Text);
            result = a - b;
            txtResult.Text = result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(txtSo1.Text);
            b = Int32.Parse(txtSo2.Text);
            result = a * b;
            txtResult.Text = result.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            a = Int32.Parse(txtSo1.Text);
            b = Int32.Parse(txtSo2.Text);
            result = a / b;
            txtResult.Text = result.ToString();
        }
    }
}
