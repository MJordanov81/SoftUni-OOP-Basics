using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    public class Car
    {
        private Cargo cargo;
        private Engine engine;
        private Tire[] tires;
        private string model;

        public Car(string model, Cargo cargo, Engine engine, Tire[] tires)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
            this.Tires = tires;
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
