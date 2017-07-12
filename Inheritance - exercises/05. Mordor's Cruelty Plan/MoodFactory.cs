using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    public static class MoodFactory
    {
        public static Mood GetMood(int points)
        {
            if (points < -5)
            {
                return new Angry(points);
            }
            else if (points <= 0)
            {
                return new Sad(points);
            }
            else if (points <= 15)
            {
                return new Happy(points);
            }

            return new JavaScript(points);
        }
    }
}
