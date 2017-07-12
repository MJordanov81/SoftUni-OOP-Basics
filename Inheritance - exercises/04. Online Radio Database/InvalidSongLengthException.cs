using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database.CustomeExceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message
        {
            get { return "Invalid song length."; }
        }
    }
}
