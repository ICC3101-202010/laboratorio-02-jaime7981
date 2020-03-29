using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorSpotifai
{
    class Spotifai : Song
    {
        private object[,] Songs = new object[10,4];
        private int songscounter = 0;

        public Spotifai() : base()
        {

        }

        public Spotifai(string genere, string artist, string album, string name) : base(genere, artist, album, name)
        {

        }

        public bool AddSong()
        {
            Console.WriteLine("Name of the song: ");
            string newname = Console.ReadLine();
            Console.WriteLine("Artist of the song: ");
            string newartist = Console.ReadLine();
            Console.WriteLine("Album of the song: ");
            string newalbum = Console.ReadLine();
            Console.WriteLine("Genere of the song: ");
            string newgenere = Console.ReadLine();

            for (int i = 0; i < songscounter; i++)
            {
                if (newname == Songs[i,0].ToString() && newartist == Songs[i,1].ToString() && 
                    newalbum == Songs[i,2].ToString() && newgenere == Songs[i, 3].ToString())
                {
                    return false;
                }
            }
            Songs[songscounter, 0] = newname; Songs[songscounter, 1] = newartist;
            Songs[songscounter, 2] = newalbum; Songs[songscounter, 3] = newgenere;
            songscounter ++;
            return true;
        }


        public void ShowSongs()
        {
            for (int i = 0; i < songscounter; i++)
            {
                name = Songs[i, 0].ToString(); artist = Songs[i, 1].ToString();
                album = Songs[i, 2].ToString(); genere = Songs[i, 3].ToString();
                Information();
            }
        }

    }
}
