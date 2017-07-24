using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace killnickelpart2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string artistName, string songTitle)> goodSongs = new List<(string, string)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

            allSongs.Add(("Nickelback", "How You Remind Me"));
            allSongs.Add(("Elmo", "Elmo's Got the Moves"));
            allSongs.Add(("Weird Al", "I'm Fat"));
            allSongs.Add(("Nickelback", "Rockstar"));
            allSongs.Add(("Nickelback", "Photograph"));
            allSongs.Add(("Taylor Swift", "Fearless"));
            allSongs.Add(("George Jones", "He Stopped Loving Her Today"));

            foreach ((string artistName, string songTitle) song in allSongs)
            {
                if(song.artistName != "Nickelback")
                {
                    goodSongs.Add(song);
                }
            }

            foreach((string artistName, string songTitle) songs in goodSongs)
            {
                Console.WriteLine($"\n{songs.artistName} - {songs.songTitle}");
            }

            Console.Read();
        }
    }
}
