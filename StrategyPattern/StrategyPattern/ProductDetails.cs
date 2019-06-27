using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ProductDetails
    {

        public IProductStrategy ProductDetailsCalculation;

        public ProductDetails(IProductStrategy NewStrategy)
        {
            ProductDetailsCalculation = NewStrategy;
        }

        /// <summary>
        /// Calculation of FlasshDrive details
        /// </summary>
        /// <returns></returns>
        public double ProductFlashDriveCalculation()
        {
            return ProductDetailsCalculation.ProductFlashDriveCalculation();
        }

        /// <summary>
        /// Calculation of SSD Details
        /// </summary>
        /// <param name="ssd">bool value</param>
        /// <returns></returns>
        public double ProductSSDCalculation(bool ssd)
        {
            return ProductDetailsCalculation.ProductSSDCalculation(ssd);
        }

        /// <summary>
        /// Calculation of Mp3Calculation
        /// </summary>
        /// <returns>It returns double value</returns>
        public double ProductMP3Calculation()
        {
            return ProductDetailsCalculation.ProductMP3Calculation();
        }
    }

}
