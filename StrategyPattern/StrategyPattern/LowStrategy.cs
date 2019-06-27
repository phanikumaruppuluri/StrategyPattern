using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class LowStrategy : IStrategy
    {
        /// <summary>
        /// Function Determines if Supply is Low and Demand is Low
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
         
            /// If supply is Low and Demand is low price should be increased by 10 %
            if (Supply == "Low" && Demand == "Low")
            {
                prices = (double)(price + (price * 0.1));

            }
            return prices;
        }
    }
}
