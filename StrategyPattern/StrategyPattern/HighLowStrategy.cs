using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HighLowStrategy : IStrategy
    {
        /// <summary>
        /// This function is based on Low and High of Supply and Demand
        /// </summary>
        /// <param name="NoofProducts"></param>
        /// <param name="ProductName"></param>
        /// <param name="Supply"></param>
        /// <param name="Demand"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        double IStrategy.Calculation(int NoofProducts, string ProductName,string Supply, string Demand, double price)
        {
            double prices = 0;
            
            /// If Supply is High and demand is Low Product is sold at 5 % less than chosen price.
            if (Supply == "High" && Demand == "Low")
            {
                prices = (double)(price - (price * 0.05));

            }

            return prices;
        }
    }
}
