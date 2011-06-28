using System.Windows;

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
            var viewModel = new BmiViewModel();

            viewModel.Height = double.Parse(heightText.Text);
            viewModel.Weight = double.Parse(weightText.Text);

            bmiText.Text = string.Format("{0,5:##.##}", viewModel.Bmi);
        }
    }
}
