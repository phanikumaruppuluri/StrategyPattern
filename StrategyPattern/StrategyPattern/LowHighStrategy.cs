using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class LowHighStrategy : IStrategy
    {
        /// <summary>
        /// Caluculation of Low high Startegy
        /// </summary>
        /// <param name="NoofProducts">NoofProducts</param>
        /// <param name="ProductName">ProductName</param>
        /// <param name="Supply">Supply</param>
        /// <param name="Demand">Demand</param>
        /// <param name="price">price</param>
        /// <returns></returns>
        double IStrategy.Calculation(int NoofProducts, string ProductName, string Supply, string Demand, double price)
        {
            double prices = 0;
            /// If Supply is High and demand is Low Product is sold at 5 % more than chosen price.
            if (Supply == "Low" && Demand == "High")
            {
                prices = (double)(price + (price * 0.05));

            }
            return prices;
        }
    }
}
