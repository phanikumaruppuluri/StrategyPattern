using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Product
    {
        /// <summary>
        /// property details of Supply
        /// </summary>
        public string Supply { get; set; }
        /// <summary>
        /// Property of Demand
        /// </summary>
        public string Demand { get; set; }
        /// <summary>
        /// Property of Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property of NoOfproducts
        /// </summary>
        public int NoofProducts { get; set; }
        /// <summary>
        /// Property of ProductName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Property of SurveyedPrices
        /// </summary>
        public string SuryedPrices { get; set; }
        /// <summary>
        /// List of Product Details
        /// </summary>
        public List<ProductDetails> ProductDetails { get; set; }

        /// <summary>
        /// Declaration of Istrategy
        /// </summary>
        public IStrategy CurretStrategy;

        /// <summary>
        /// Refrence of Istrategy
        /// </summary>
        /// <param name="NewStrategy">NewStrategy</param>
        public Product(IStrategy NewStrategy)
        {
            CurretStrategy = NewStrategy;
        }

        /// <summary>
        /// Calculation of strategy details
        /// </summary>
        /// <returns>It returns double value</returns>
        public double Calculation()
        {
            return CurretStrategy.Calculation(this.NoofProducts,this.ProductName,this.Supply,this.Demand,this.Price);
        }

        
    }
}
