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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operator_Current = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            btn_Show.Content += (sender as Button).Content.ToString();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            btn_Show.Content = "";
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            string txt = btn_Show.Content.ToString();
            decimal num = 0;
            string[] nums;
            switch(operator_Current)
            {
                case "+":
                    nums = txt.Split("+");
                    num = decimal.Parse(nums[0]) + decimal.Parse(nums[1]);
                    btn_Show.Content = num.ToString();
                    break;

                case "÷":
                    nums = txt.Split("÷");
                    num = decimal.Parse(nums[0]) / decimal.Parse(nums[1]);
                    btn_Show.Content = num.ToString();
                    break;

                case "×":
                    nums = txt.Split("×");
                    num = decimal.Parse(nums[0]) * decimal.Parse(nums[1]);
                    btn_Show.Content = num.ToString();
                    break;

                case "−":
                    nums = txt.Split("−");
                    num = decimal.Parse(nums[0]) - decimal.Parse(nums[1]);
                    btn_Show.Content = num.ToString();
                    break;

            }
            
        }

        private void Operator(object sender, RoutedEventArgs e)
        {
            operator_Current = (sender as Button).Content.ToString();
            btn_Show.Content += (sender as Button).Content.ToString();
        }
    }
}