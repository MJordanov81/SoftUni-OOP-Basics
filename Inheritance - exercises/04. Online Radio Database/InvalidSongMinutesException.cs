using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database.CustomeExceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public override string Message
        {
            get { return "Song minutes should be between 0 and 14."; }
        }
    }
}
