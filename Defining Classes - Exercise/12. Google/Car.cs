using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car(string mode, int speed)
        {
            this.Model = mode;
            this.Speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
