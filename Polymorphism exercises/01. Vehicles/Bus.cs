using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Bus : Vehicle
    {
        private readonly double IncreasedSummerConsumption = 1.4;
        private readonly string VehicleType = "Bus";

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double kilometers)
        {
            if (this.IsEmpty)
            {
                if (this.FuelQuantity < kilometers * (this.FuelConsumption))
                {
                    this.PrintNeedsRefueling();
                }
                else
                {
                    this.FuelQuantity -= kilometers * (this.FuelConsumption);
                    this.PrintTravelledDistance(kilometers);
                }

                return;
            }

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
