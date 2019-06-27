using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AvergarePriceStrategy :IStrategy
    {
        int avg = 0;

        public int Main()
        {

            int m, i, sum = 0;
            Console.WriteLine("Enter the Number of Products ");
            Console.WriteLine("Enter Price of Products ");
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            Console.WriteLine("Enter the Array Elements ");
            for (i = 0; i < m; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < m; i++)
            {
                sum += a[i];
            }
            avg = sum / m;
            Console.WriteLine("Average is {0}", avg);
            Console.ReadLine();

            return avg;
        }

        double IStrategy.Calculation(int NoofProducts, string ProductName,string Supply, string Demand, double price)
        {
            double average = Main(); 
            if(price > average)
            {
                average =  (double)((avg - (avg * 0.5)))/100;
                Console.WriteLine("It is promotion");
               
            }
            else
            {
                average = (double)((avg + (avg * 0.5)))/100;
                Console.WriteLine("Data errors ");
            }
            return average;
        }
    }
}
