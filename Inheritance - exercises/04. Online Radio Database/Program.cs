using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.Online_Radio_Database.CustomeExceptions;

namespace _04.Online_Radio_Database
{
    public class Program
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var playlist = new PlayList();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                if (input.Length != 3)
                {
                    Console.WriteLine(new InvalidSongException().Message);
                }
                else
                {
                    var artist = input[0];
                    var song = input[1];
                    var length = input[2].Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);

                    if (length.Length != 2)
                    {
                        Console.WriteLine(new InvalidSongException().Message);
                        continue;                        
                    }

                    int minutes;
                    int seconds;

                    var minutesAreParsable = int.TryParse(input[2].Split(new []{ ':' }, StringSplitOptions.RemoveEmptyEntries)[0], out minutes);
                    var secondsAreParsable = int.TryParse(input[2].Split(new []{ ':' }, StringSplitOptions.RemoveEmptyEntries)[1], out seconds);

                    if (!secondsAreParsable || !minutesAreParsable)
                    {
                        Console.WriteLine(new InvalidSongLengthException().Message);
                        continue;
                    }

                    try
                    {
                        Song currentSong = new Song(song, artist, minutes, seconds);
                        Console.WriteLine(playlist.AddSong(currentSong));
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine($"Songs added: {playlist.Songs.Count}");
            Console.WriteLine(playlist.GetPlayListLength());

        }
    }
}
