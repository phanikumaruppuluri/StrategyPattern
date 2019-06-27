using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ProductDetailList : IProductStrategy
    {
        private string productname;
        private string surveyedprices;
        private double prices;
        public ProductDetailList(string productname, string surveyedprices, double prices)
        {
            this.productname = productname;
            this.surveyedprices = surveyedprices;
            this.prices = prices;

        }

        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public string SurveyedPrices
        {
            get { return productname; }
            set { productname = value; }
        }

        public double Prices
        {
            get { return prices; }
            set { prices = value; }
        }

        /// <summary>
        /// List Details of First input
        /// </summary>
        /// <returns>It From List and returns List of product details</returns>
        public List<ProductDetailList> ProductDetailsLists()
        {
            List<ProductDetailList> productDetails = new List<ProductDetailList>();
            productDetails.Add(new ProductDetailList("FlashDrive", "X", 1.0));
            productDetails.Add(new ProductDetailList("SSD", "X", 10.0));
            productDetails.Add(new ProductDetailList("FlashDrive", "Y", 0.9));
            productDetails.Add(new ProductDetailList("FlashDrive", "Z", 1.1));
            productDetails.Add(new ProductDetailList("SSD", "Y", 12.5));
            return productDetails;
        }

        /// <summary>
        /// List details of Second Inpt
        /// </summary>
        /// <returns>It returns List of Product details</returns>
        public List<ProductDetailList> ProductDetailLists()
        {
            List<ProductDetailList> productDetails = new List<ProductDetailList>();
            productDetails.Add(new ProductDetailList("SSD", "W", 11.0));
            productDetails.Add(new ProductDetailList("SSD", "X" , 12.0));
            productDetails.Add(new ProductDetailList("MP3Player" , "X" , 60.0));
            productDetails.Add(new ProductDetailList("MP3Player" , "Y" , 20.0));
            productDetails.Add(new ProductDetailList("MP3Player" , "Y" , 50.0));
            productDetails.Add(new ProductDetailList("SSD" , "V" , 10.0));
            productDetails.Add(new ProductDetailList("SSD" , "Y" , 11.0));
            productDetails.Add(new ProductDetailList("SSD" , "Z" , 12.0));
            return productDetails;
        }

        /// <summary>
        /// Calculation of Flash Drive Details
        /// </summary>
        /// <returns>It returns Double value </returns>
        double IProductStrategy.ProductFlashDriveCalculation()
        {

            double flashDrive = 0;
           
            double lowest_price = 0;
            /// Formation of List
            List<ProductDetailList> productFlashDrive = ProductDetailsLists();
            ///From the list Get Flash drive details
            var flashDrives = productFlashDrive.Where(s => s != null && s.ProductName == "FlashDrive");
            if (flashDrives != null)
            {
                ///Count of flsh drive products
                int count = productFlashDrive.Where(s => s != null && s.ProductName == "FlashDrive").Count();
                ///Sum of Prrices of Flash Drive Details
                double total = productFlashDrive.Sum(d => d.Prices);
                ///Get Avergae of flash Drive 
                flashDrive = total / count;
                ///Get Lowest value out of all the prices
                lowest_price = productFlashDrive.Where(a => a.ProductName == "FlashDrive").Min(p => p.Prices);
            }
          

            return lowest_price;
        }

        /// <summary>
        /// Calculation of SSD Details
        /// </summary>
        /// <param name="ssds">Get the deatails based on bool value </param>
        /// <returns>It returns double value</returns>
        double IProductStrategy.ProductSSDCalculation(bool ssds)
        {
            double ssd = 0;
            double lowest_price = 0;
            List<ProductDetailList> productSSDDrive = new List<ProductDetailList>();
            if (ssds == true)
            {///Get first  List Details
                 productSSDDrive = ProductDetailsLists();
            }
            else
            {
                /// Get Second List Details
                List<ProductDetailList> uniquePrices = new List<ProductDetailList>();
                uniquePrices = ProductDetailLists();
                ///Get unique list from the prices
                productSSDDrive = uniquePrices.GroupBy(i => i.Prices).Select(g => g.First()).ToList();
            }
            ///Get details from list where product name is SSD
            var SSDDrives = productSSDDrive.Where(s => s != null && s.ProductName == "SSD");
            if (SSDDrives != null)
            {
                /// Count Details from the list
                int count = productSSDDrive.Where(s => s != null && s.ProductName == "SSD").Count();
                ///Get the total of SSD . Sum of prices
                double total = productSSDDrive.Where(s => s != null && s.ProductName == "SSD").Sum(d => d.Prices);
                ///Average Details
                ssd = total / count;
                if (ssds == true)
                {
                    /// Get the Lowest of the prices.
                    lowest_price = productSSDDrive.Where(a => a.ProductName == "SSD").Min(p => p.Prices);
                }
                else
                {
                    ///Get the price deatils
                    lowest_price = ssd;
                }
            }
            return lowest_price;
        }

        /// <summary>
        /// Calculation of MP3 Details
        /// </summary>
        /// <returns>It returns Double value</returns>
        double IProductStrategy.ProductMP3Calculation()
        {

            double MP3Player = 0;

            double lowest_price = 0;
            ///Get the List details of Second Input
            List<ProductDetailList> productMP3Drive = ProductDetailLists();
            var flashDrives = productMP3Drive.Where(s => s != null && s.ProductName == "MP3Player");
            if (flashDrives != null)
            {
                /// Get the Count details from the list
                int count = productMP3Drive.Where(s => s != null && s.ProductName == "MP3Player").Count();
                ///Get Sum of price details from the list
                double total = productMP3Drive.Where(s => s != null && s.ProductName == "MP3Player").Sum(d => d.Prices);//productMP3Drive.Sum(d => d.Prices);
                ///Get Average details
                MP3Player = total / count;
                List<double> pt = new List<double>();
                ///Get average Details if price is less thn average price ignore it
                foreach (var item in flashDrives)
                {
                    ///If Price is garter than average price consider it
                    if(MP3Player<item.Prices)
                    {
                        double i = item.Prices;
                        pt.Add(i);
                    }
                }
                /// Get the Min Vale
                lowest_price = pt.Min();//productMP3Drive.Where(a => a.ProductName == "MP3Player").Min(p => p.Prices);
            }


            return lowest_price;
        }
    }
}
