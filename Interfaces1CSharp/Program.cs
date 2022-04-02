using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the rental data");
                Console.Write("Car model : ");
                string carModel = Console.ReadLine();
                Console.Write("Pickup (dd//MM/yyyy hh:ss): ");
                DateTime pickupCar = DateTime.Parse(Console.ReadLine());
                Console.Write("Return (dd//MM/yyyy hh:ss): ");
                DateTime returnCar = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter price per hour : "); 
                double pricePerHour = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Enter price per day : ");
                double pricePerDay = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("INVOICE :");
                Console.WriteLine("Basic Payment : ");
                Console.WriteLine("Tax : ");
                Console.WriteLine("Total Payment : ");


                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
