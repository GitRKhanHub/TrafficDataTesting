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

using System.Threading;

namespace TrafficDataTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //переменные и методы находятся в App.xaml.cs

        private async void startButton_0_Click(object sender, RoutedEventArgs e)
        {
            
            App.runner0 = true;
            int num;

           
            while (App.runner0)
            {
                num = App.FourSignNumber_Generator();
                if (App.isSimpleNumber(num))
                {
                    TextBlock_0.Inlines.Add(new Run(" " + num) { Foreground = Brushes.Red });
                }
                else
                    TextBlock_0.Inlines.Add(new Run(" " + num));
                await Task.Delay(App.period);

            }

        }

        private void stopButton_0_Click(object sender, RoutedEventArgs e)
        {

            App.runner0 = false;
        }

        private async void startButton_1_Click(object sender, RoutedEventArgs e)
        {
            App.runner1 = true;
            int num;


            while (App.runner1)
            {
                num = App.FourSignNumber_Generator();
                if (App.isSimpleNumber(num))
                {
                    TextBlock_1.Inlines.Add(new Run(" " + num) { Foreground = Brushes.Red });
                }
                else
                    TextBlock_1.Inlines.Add(new Run(" " + num));
                await Task.Delay(App.period);

            }

        }

        private void stopButton_1_Click(object sender, RoutedEventArgs e)
        {
            App.runner1 = false;
        }

        private async void startButton_2_Click(object sender, RoutedEventArgs e)
        {
            App.runner2 = true;
            int num;


            while (App.runner2)
            {
                num = App.FourSignNumber_Generator();
                if (App.isSimpleNumber(num))
                {
                    TextBlock_2.Inlines.Add(new Run(" " + num) { Foreground = Brushes.Red });
                }
                else
                    TextBlock_2.Inlines.Add(new Run(" " + num));
                await Task.Delay(App.period);

            }
        }

        private void stopButton_2_Click(object sender, RoutedEventArgs e)
        {
            App.runner2 = false;
        }
    }
}
