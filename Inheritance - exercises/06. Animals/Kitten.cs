using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            :base(name, age)
        {
            base.Gender = "Female";
        }

        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
            
        }

        public override string ProduceSound()
        {
            return "Miau";
        }
    }
}
