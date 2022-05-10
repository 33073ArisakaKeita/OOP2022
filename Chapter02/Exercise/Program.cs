using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("a", "aa", 246),
                new Song("b", "bb", 241),
                new Song("c", "cc", 240)
            };
            /*Listバージョン
             * List<song> songs = new List<Song>();
             * var song1 = new Song("a", "aa", 246);
             * var song2 = new Song("a", "aa", 246);
             * var song3 = new Song("a", "aa", 246);
             * songs.Add();
             */
            PrintSongs(songs);
        }
        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0} {1} {2}:{3:d2}", song.Title,
                    song.ArtistName, song.Length / 60, song.Length % 60); 
            }
            //ゼロ埋め、書式設定、ゼロサプレス
        }
    }
}
