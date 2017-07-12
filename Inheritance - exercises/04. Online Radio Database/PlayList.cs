using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Online_Radio_Database
{
    public class PlayList
    {
        private List<Song> songs;

        public PlayList()
        {
            this.Songs = new List<Song>();
        }

        public List<Song> Songs
        {
            get { return songs; }
            set { songs = value; }
        }

        public string AddSong(Song song)
        {
            this.Songs.Add(song);
            return "Song added.";
        }

        public string GetPlayListLength()
        {
            var ttlSeconds = 0;
            var ttlMinutes = 0;

            if (this.songs.Count == 0)
            {
                return $"Playlist length: 0h 0m 0s";
            }

            this.songs.ForEach(song =>
            {
                ttlSeconds += song.Seconds;
                ttlMinutes += song.Minutes;
            });

            ttlMinutes += ttlSeconds / 60;
            ttlSeconds = ttlSeconds % 60;

            var ttlHours = ttlMinutes / 60;
            ttlMinutes = ttlMinutes % 60;

            return $"Playlist length: {ttlHours}h {ttlMinutes}m {ttlSeconds}s";
        }
    }
}
