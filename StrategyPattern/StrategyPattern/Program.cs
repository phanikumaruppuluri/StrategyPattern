using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            /// InputDetails
            ProductDetails productDetails = new ProductDetails(new ProductDetailList(null,null,0));
            Console.WriteLine(" Input");
            Console.WriteLine("Number of Products =" + 5);
            Console.WriteLine("FlashDrive" +" " +"X" + " "+1.0);
            Console.WriteLine("SSD" + " " + "X" + " " + 10.0);
            Console.WriteLine("FlashDrive" + " " + "Y" + " " + 0.9);
            Console.WriteLine("FlashDrive" + " " + "Z" + " " + 1.1);
            Console.WriteLine("SSD" + " " + "Y" + " " + 12.5);
           
            Console.WriteLine(" OutPut");
            /// Calcualtion of FlashDriveDetails
            double flasDetails = productDetails.ProductFlashDriveCalculation();
            bool ssd = true;
            ///Calculation of SSD Details
            double ssdDetails = productDetails.ProductSSDCalculation(ssd);

            /// Details of Flash drive
            Product product5 = new Product(new HighStrategy());
            product5.ProductName = "flashdrive";
            product5.NoofProducts = 3;
            product5.Supply = "High";
            product5.Demand = "High";
            product5.Price = flasDetails;
            Console.WriteLine(product5.NoofProducts + "\n" + product5.ProductName + " " + product5.Supply + " " + product5.Demand);
            Console.WriteLine("Price Details for FlashDrive = " + product5.Calculation());

            ///Details of SSD Details
            Product product6 = new Product(new LowHighStrategy());
            product6.ProductName = "SSD";
            product6.NoofProducts = 2;
            product6.Supply = "Low";
            product6.Demand = "High";
            product6.Price = ssdDetails;
            Console.WriteLine(product6.NoofProducts + "\n" + product6.ProductName + " " + product6.Supply + " " + product6.Demand);
            Console.WriteLine("Price Details for FlashDrive = " + product6.Calculation());

            Console.WriteLine(" Input");
            ///Second Inpt Details Total * products
            Console.WriteLine("Number of Products =" + 8);
            Console.WriteLine("SSD" + " " + "W " + " " + 11.0);
            Console.WriteLine("SSD" + " " + "X" + " " + 12.0);
            Console.WriteLine("MP3Player" + " " + "X" + " " + 60.0);
            Console.WriteLine("MP3Player" + " " + "Y" + " " + 20.0);
            Console.WriteLine("MP3Player" + " " + "Y" + " " + 50.0);
            Console.WriteLine("SSD" + " " + "V" + " " + 10.0);
            Console.WriteLine("SSD" + " " + "Y" + " " + 11.0);
            Console.WriteLine("SSD" + " " + "Z" + " " + 12.0);

            Console.WriteLine(" OutPut");

            /// Calculation of MP3 details
            double MP3PlayerDetails = productDetails.ProductMP3Calculation();
            bool ssds = false;
            /// Calculation of SSdD details
            double ssd2Details = productDetails.ProductSSDCalculation(ssds);

            /// Details of Mp3 player
            Product product7 = new Product(new HighStrategy());
            product7.ProductName = "MP3Player";
            product7.NoofProducts = 3;
            product7.Supply = "High";
            product7.Demand = "High";
            product7.Price = MP3PlayerDetails;
            Console.WriteLine(product7.NoofProducts + "\n" + product7.ProductName + " " + product7.Supply + " " + product7.Demand);
            Console.WriteLine("Price Details for FlashDrive = " + product7.Calculation());

            /// Details of SSD details
            Product product8 = new Product(new LowStrategy());
            product8.ProductName = "SSD";
            product8.NoofProducts = 5;
            product8.Supply = "Low";
            product8.Demand = "Low";
            product8.Price = ssd2Details;
            Console.WriteLine(product8.NoofProducts + "\n" + product8.ProductName + " " + product8.Supply + " " + product8.Demand);
            Console.WriteLine("Price Details for FlashDrive = " + product8.Calculation());

        }
    
    }


    enum SupplyandDemand
    {
        High = 0,
        Low = 1,
        
    }
}
