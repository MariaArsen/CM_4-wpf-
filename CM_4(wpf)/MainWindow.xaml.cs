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

namespace CM_4_wpf_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble = rateEuro * sumEuro;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateFunt = Convert.ToDouble(rate2.Text);
            double sumFunt = Convert.ToDouble(sum2.Text);
            double resDouble = rateFunt * sumFunt;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double ratePeco = Convert.ToDouble(rate3.Text);
            double sumPeco = Convert.ToDouble(sum3.Text);
            double resDouble = ratePeco * sumPeco;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double numberMeters = Convert.ToDouble(metr.Text);
            double resDouble = numberMeters * 100;
            resSm.Text= resDouble.ToString("N2");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double numberMeters = Convert.ToDouble(metr1.Text);
            double resDouble = numberMeters * 39.37;
            resIns.Text = resDouble.ToString("N2");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double numberMiles = Convert.ToDouble(mile.Text);
            double resDouble = numberMiles * 1609.34;
            resM.Text = resDouble.ToString("N2");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double numberMeters = Convert.ToDouble(metr3.Text);
            double resDouble = numberMeters * 3.281;
            resFt.Text = resDouble.ToString("N2");
        }
    }
}
