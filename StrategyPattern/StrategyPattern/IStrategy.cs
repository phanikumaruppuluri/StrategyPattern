using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IStrategy
    {
        /// <summary>
        /// Interface details for calculation
        /// </summary>
        /// <param name="NoofProducts">NoofProducts</param>
        /// <param name="ProductName">ProductName</param>
        /// <param name="Supply">Supply</param>
        /// <param name="Demand">Demand</param>
        /// <param name="Price">Price</param>
        /// <returns>It returns double value</returns>
        double Calculation(int NoofProducts,string ProductName,string Supply,string Demand,double Price);

        
    }
}
