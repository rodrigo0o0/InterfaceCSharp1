using Interfaces1CSharp.Entities;
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
                Console.Write("Pickup (dd//MM/yyyy hh:mm): ");
                DateTime pickupCar = DateTime.Parse(Console.ReadLine());
                Console.Write("Return (dd//MM/yyyy hh:mm): ");
                DateTime returnCar = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter price per hour : "); 
                double pricePerHour = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Enter price per day : ");
                double pricePerDay = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Rental rental = new Rental(carModel, pickupCar, returnCar, pricePerHour, pricePerDay);
                Console.WriteLine("INVOICE : ");
                Console.WriteLine("Basic Payment : " + rental.BasicPayment().ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Tax : " + rental.TaxesCalculate().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Total Payment : " + rental.TotalPayment().ToString("F2",CultureInfo.InvariantCulture));
                

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
