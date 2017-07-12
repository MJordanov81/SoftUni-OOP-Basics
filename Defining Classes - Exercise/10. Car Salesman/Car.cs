using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }      

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public override string ToString()
        {

            var displacement = this.Engine.Displacement != 0 ? this.Engine.Displacement.ToString() : "n/a";
            var efficiency = this.Engine.Efficiency != null && this.Engine.Efficiency != String.Empty? this.Engine.Efficiency : "n/a";
            var colorChecked = this.Color != null && this.Color != String.Empty ? this.Color : "n/a";
            var weightChecked = this.Weight != 0 ? this.Weight.ToString() : "n/a";

            var result = new StringBuilder();
            result.Append($"{this.Model}:\n");
            result.Append($"  {this.Engine.Model}:\n");
            result.Append($"    Power: {this.Engine.Power}\n");
            result.Append($"    Displacement: {displacement}\n");
            result.Append($"    Efficiency: {efficiency}\n");
            result.Append($"  Weight: {weightChecked}\n");
            result.Append($"  Color: {colorChecked}");

            return result.ToString();
        }
    }
}
