﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("曲1", "歌手1", 246),
                new Song("曲2", "歌手2", 241),
                new Song("曲3", "歌手3", 240)
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
        private static void PrintSongs(IEnumerable<Song> songs) {
            //foreach (var song in songs) {
            //    Console.WriteLine("{0} {1} {2}:{3:d2}", song.Title,
            //        song.ArtistName, song.Length / 60, song.Length % 60); 
            //}
            foreach (var song in songs) {
                Console.WriteLine("{0} {1} {2:m\\:ss}", song.Title,
                    song.ArtistName,TimeSpan.FromSeconds(song.Length));
            };

            //ゼロ埋め、書式設定、ゼロサプレス
        }
        }
}
