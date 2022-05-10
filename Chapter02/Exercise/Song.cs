using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    public class Song {

        public String Title { get; set; }

        public String ArtistName { get; set; }

        public int Length { get; set; }

        public Song(String title, String artistname, int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
