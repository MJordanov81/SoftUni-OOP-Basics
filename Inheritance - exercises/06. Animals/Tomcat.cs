using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            :base(name, age)
        {
            base.Gender = "Male";
        }

        public Tomcat(string name, int age, string gender) 
            : base(name, age, gender)
        {
            
        }

        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}
