using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateOne = Console.ReadLine();
            var dateTwo = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(dateOne, dateTwo);

            Console.WriteLine(dateModifier.Difference);
        }
    }
}
