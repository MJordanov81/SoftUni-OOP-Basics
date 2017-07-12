using System;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        private bool isEmpty;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
            set { isEmpty = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public virtual string PrintOut()
        {
            return $": {this.FuelQuantity:f2}";
        }

        public virtual void PrintTravelledDistance(double kilometers)
        {
            Console.WriteLine($" travelled {kilometers} km");
        }

        public virtual void PrintNeedsRefueling()
        {
            Console.WriteLine($" needs refueling");
        }

        public abstract void Drive(double kilometers);

        public virtual void Refuel(double litres)
        {
            if (litres <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (litres + this.FuelQuantity > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                this.FuelQuantity += litres;
            }
        }
    }
}
