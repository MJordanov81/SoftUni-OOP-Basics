using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.Online_Radio_Database.CustomeExceptions;

namespace _04.Online_Radio_Database
{
    public class Song
    {
        private string name;
        private string artistName;
        private int minutes;
        private int seconds;

        public Song(string name, string artistName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                else
                {
                    seconds = value;
                }               
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                else
                {
                    minutes = value;
                }
            }
        }

        public string ArtistName
        {
            get { return artistName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidArtistNameException();
                }
                else
                {
                    artistName = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                name = value; }
        }
    }
}
