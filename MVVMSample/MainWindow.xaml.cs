using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(heightText.Text);
            double weight = double.Parse(weightText.Text);

            double bmi = Math.Truncate(weight / Math.Pow((height / 100), 2) * 100) / 100;
            bmiText.Text = string.Format("{0,5:##.##}", bmi);

        }
    }
}
