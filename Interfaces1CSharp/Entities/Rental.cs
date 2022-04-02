using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1CSharp.Entities
{
    internal class Rental
    {
        public string CarModel { get; set; }
        public DateTime PickupCar { get; set; }
        public DateTime ReturnCar { get; set; }
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public Rental(string carModel, DateTime pickupCar, DateTime returnCar, double pricePerHour, double pricePerDay)
        {
            
            CarModel = carModel;
            PickupCar = pickupCar;
            ReturnCar = returnCar;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
        //calcula o pagemtno basico e verifica se não passou de um dia.
        public double BasicPayment()
        {
            double basicPayment = 0.0;
            if(Hours() > 12 && Days() == 0)
            {
                return PricePerDay;

            }
            else if (Hours() < 12 && Days() == 0)
            {
                return PricePerHour * Hours();

            }
            else if (Hours() > 0 && Days() > 0) 
            {
                return((Days() + 1) * PricePerDay);
            }
            else
            {
                return Days() * PricePerDay;
            }
            return basicPayment;
      
        }
        //calcula as horas que o carro ficou com o locatário
        public int Hours()
        {
            TimeSpan hours  = ReturnCar - PickupCar;
            if(hours.Hours < 1)
            {
                throw new Exception("Pick Date > Return Date.");
            }
            if (hours.TotalMinutes % 60 != 0)
            {
                hours = hours.Add(TimeSpan.FromHours(1));
            }
            return hours.Hours;
        }
        public int Days()
        {
            TimeSpan days = ReturnCar - PickupCar;
            return days.Days;

        }
        public double TaxesCalculate()
        {
            if (BasicPayment() < 100.00)
            {
                return BasicPayment() * (Taxes.HIGHTAX / 100);

            }
            else
            {
                return  BasicPayment() * (Taxes.LOWTAX/100);
            }
        }
        
        public double TotalPayment()
        {
            return BasicPayment() + TaxesCalculate();  
        }
    }
}
