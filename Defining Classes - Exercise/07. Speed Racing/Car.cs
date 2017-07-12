using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuel;
        private double consumption;
        private int distance;

        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public double Consumption
        {
            get { return consumption; }
            set { consumption = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public bool IsThereEnoughFuel(int kilometers)
        {
            return kilometers * this.consumption <= this.fuel;
        }

        public void DriveCar(int kilometers)
        {
            this.Distance += kilometers;
            this.Fuel -= kilometers * this.consumption;
        }

        public override string ToString()
        {
            return string.Format($"{this.Model} {this.Fuel:f2} {this.Distance}");
        }
    }
}
