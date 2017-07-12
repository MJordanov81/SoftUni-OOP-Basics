using System;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private readonly double IncreasedSummerConsumption = 0.9;
        private readonly string VehicleType = "Car";

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
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

        public override void PrintNeedsRefueling()
        {
            Console.Write(VehicleType);
            base.PrintNeedsRefueling();
        }

        public override void PrintTravelledDistance(double kilometers)
        {
            Console.Write(VehicleType);
            base.PrintTravelledDistance(kilometers);
        }

        public override string PrintOut()
        {
            return VehicleType + base.PrintOut();
        }
    }
}
