using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.FavoriteThings
{
    class Music
    {

        public Genre MusicGenre { get; set; }
        public string Artist { get; set; }

        public string Album { get; set; }

        public void ListeningTo()
        {
            Console.WriteLine($"I listen to music often as well. Recently I have been listening to {Album} by {Artist}.  The genre I most frequently listen to is {MusicGenre}");
        }
    }

    enum Genre
    {
        Rock,
        Pop,
        Folk,
        Indie,
        Blues,
        Jazz
    }
}
