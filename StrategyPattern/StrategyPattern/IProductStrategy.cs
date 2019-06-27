using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IProductStrategy
    {
        //decimal ProductDetailsCalculation(int NoofProducts,string ProductName, string SuryedPrices, string Price);
        double ProductFlashDriveCalculation();

        double ProductSSDCalculation(bool ssd);

        double ProductMP3Calculation();
    }
}
