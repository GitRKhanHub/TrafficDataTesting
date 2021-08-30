using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Documents;

namespace TrafficDataTesting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool runner0 = true; //условие для цикла 0-го столбца генерации
        public static bool runner1 = true; //условие для цикла 1-го столбца генерации
        public static bool runner2 = true; //условие для цикла 2-го столбца генерации
        public static int period = 100; //временной период в мс

        public static int FourSignNumber_Generator() //генератор случ. 4-хзнач. положит. цел. числа
        {
            {
                Random rnd = new Random();
                int temp = rnd.Next(1000, 10000);

                return temp;
            }
        }

        public static bool isSimpleNumber(int num) //проверка на простоту числа
        {
            bool res = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    res = false;
                    break;

                }

            }
            return res;
        }

        //public static async void Cycle_Number_GeneratorAsync(TextBlock tb, bool runner) //генератор с периодом, заполняющий окно
        //{
        //    int num;


        //    while (runner)
        //    {
        //        num = App.FourSignNumber_Generator();
        //        if (App.isSimpleNumber(num))
        //        {
        //            tb.Inlines.Add(new Run(" " + num) { Foreground = Brushes.Red });
        //        }
        //        else
        //            tb.Inlines.Add(new Run(" " + num));
        //        await Task.Delay(2000);

        //    }
        //} 
    }
}
