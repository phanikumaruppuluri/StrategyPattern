using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HighStrategy:IStrategy
    {
        /// <summary>
        /// Function Determines if Supply is High and Demand is High
        /// </summary>
        /// <param name="NoofProducts"></param>
        /// <param name="ProductName"></param>
        /// <param name="Supply"></param>
        /// <param name="Demand"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        double IStrategy.Calculation(int NoofProducts, string ProductName,string Supply,string Demand,double price)
        {
            double prices = 0;
           if(Supply == "High" && Demand == "High" )
            {
                /// If supply is High and Demand is high prices remain same
                prices= (double)(price); 

            }
           
            return prices;
        }
    }
}
