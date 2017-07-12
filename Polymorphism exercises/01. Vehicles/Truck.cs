using System;
using Microsoft.SqlServer.Server;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        readonly double IncreasedSummerConsumption = 1.6;
        private readonly string VehicleType = "Truck";

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double kilometers)
        {
            if (this.FuelQuantity < kilometers * (this.FuelConsumption + IncreasedSummerConsumption))
            {
                this.PrintNeedsRefueling();
            }
            else
            {
                this.FuelQuantity -= kilometers * (this.FuelConsumption + IncreasedSummerConsumption);
                this.PrintTravelledDistance(kilometers);
            }
        }

        public override void Refuel(double litres)
        {
            litres = litres * 95 / 100;
            if (litres <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.FuelQuantity += litres;
            }
        }

        public override void PrintTravelledDistance(double kilometers)
        {
            Console.Write(VehicleType);
            base.PrintTravelledDistance(kilometers);
        }

        public override void PrintNeedsRefueling()
        {
            Console.Write(VehicleType);
            base.PrintNeedsRefueling();
        }

        public override string PrintOut()
        {
            return VehicleType + base.PrintOut();
        }
    }
}
