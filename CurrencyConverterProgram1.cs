using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("n********Currency Converter******\n");
            double amount;

            string currency;
            string con = "y";
            double factor;
            



            Dictionary<string, double> factors = new Dictionary<string, double>();
            factors.Add("GBP", 0.89D);
            factors.Add("USD", 1.21D);
            factors.Add("CHF", 1.07D);
            factors.Add("AUD", 1.57D);
            factors.Add("CAD", 1.54D);






            while (con == "y")
            {
                Console.Write("Enter the amount in Euro: ");
                amount = double.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Please choose the currency you wish to convert to:");
                Console.WriteLine("USD");
                Console.WriteLine("GBP");
                Console.WriteLine("CHF");
                Console.WriteLine("AUD");
                Console.WriteLine("CAD");
                Console.WriteLine("");
                currency = Console.ReadLine();


                if (factors.TryGetValue(currency, out factor))
                {
                    Console.WriteLine("You have entered {0} EUR which converts to {1} {2}", amount, amount * factor, currency);
                }
                else
                {
                    Console.WriteLine("You did not enter a recognised currency {1}", currency);
                }
                Console.WriteLine("Would you like to do another calculation press y or any key to exit: ");
                con = Console.ReadLine();
            }

            Console.WriteLine("\nI am out of the loop");


            Console.ReadLine();





        }

    }

}
        
  
