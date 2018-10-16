using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quotes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.Write("Enter your total weight of the package: ");
            double packageWeight = Convert.ToDouble(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
            }

            Console.WriteLine("Please enter package width in inches.");
            double packageWidthInches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter package height in inches.");
            double packageHeightInches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter package length in inches.");
            double packageLengthInches = Convert.ToDouble(Console.ReadLine());

            if (packageWidthInches + packageHeightInches + packageLengthInches > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day");
            } 
            else
            {
                double shippingCalculation = ((packageWidthInches + packageHeightInches + packageLengthInches) * packageWeight) / 100;
                Console.WriteLine("Your estimate total for shipping this package is: $" + shippingCalculation + " thank you");
            }
            

            Console.Read();
        }
    }
}
