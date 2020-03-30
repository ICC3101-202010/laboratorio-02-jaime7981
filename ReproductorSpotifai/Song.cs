using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorSpotifai
{
    class Song
    {
        protected string genere;
        protected string artist;
        protected string album;
        protected string name;

        protected object[,] Songs = new object[100, 4];

        public Song()
        {

        }

        public Song(string genere, string artist, string album, string name)
        {
            this.genere = genere;
            this.artist = artist;
            this.album = album;
            this.name = name;
        }

        public void Information()
        {
            Console.WriteLine("\n Genere: " + genere + "\n Artist: " + artist + "\n Album: " + album + "\n Name: " + name + "\n");
        }
    }
}
