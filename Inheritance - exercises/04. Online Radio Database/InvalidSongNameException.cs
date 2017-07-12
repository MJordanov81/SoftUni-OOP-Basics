using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database.CustomeExceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        public override string Message
        {
            get { return "Song name should be between 3 and 30 symbols."; }
        }
    }
}
