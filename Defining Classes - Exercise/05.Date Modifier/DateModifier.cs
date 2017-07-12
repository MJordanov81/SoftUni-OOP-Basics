using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_Modifier
{
    public class DateModifier
    {
        public int Difference { get; }

        public DateModifier(string dateOne, string dateTwo)
        {
            var argsDateOne = dateOne.Split();
            var firstDate = new DateTime(int.Parse(argsDateOne[0]), int.Parse(argsDateOne[1]), int.Parse(argsDateOne[2]));

            var argsDateTwo = dateTwo.Split();
            var secondDate = new DateTime(int.Parse(argsDateTwo[0]), int.Parse(argsDateTwo[1]), int.Parse(argsDateTwo[2]));

            this.Difference = (int) Math.Abs((secondDate - firstDate).TotalDays);
        }
    }
}
