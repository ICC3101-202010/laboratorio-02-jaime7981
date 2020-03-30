using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorSpotifai
{
    class Spotifai : Song
    {
        private int songscounter = 0;
        private int reconvar;

        public Spotifai() : base()
        {

        }

        public Spotifai(string genere, string artist, string album, string name) : base(genere, artist, album, name)
        {

        }

        public bool AddSong()
        {
            Console.WriteLine("\n Name of the song: ");
            string newname = Console.ReadLine();
            Console.WriteLine("\n Artist of the song: ");
            string newartist = Console.ReadLine();
            Console.WriteLine("\n Album of the song: ");
            string newalbum = Console.ReadLine();
            Console.WriteLine("\n Genere of the song: ");
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

        public string[,] Filter(string filter, string value)
        {
            string[,] FilteredSongs = new string[40, 4];

            int varcounter = 0;

            if (filter == "Name") { reconvar = 0; } if (filter == "Artist") { reconvar = 1; }
            if (filter == "Album") { reconvar = 2; } if (filter == "Genere") { reconvar = 3; }


            if (filter == "Name" || filter == "Artist" || filter == "Album" || filter == "Genere")
            {
                for (int i = 0; i < songscounter; i++)
                {
                    if (value == Songs[i, reconvar].ToString())
                    {
                        FilteredSongs[varcounter, 0] = Songs[i, 0].ToString(); FilteredSongs[varcounter, 1] = Songs[i, 1].ToString();
                        FilteredSongs[varcounter, 2] = Songs[i, 2].ToString(); FilteredSongs[varcounter, 3] = Songs[i, 3].ToString();
                        varcounter++;
                    }
                }

                if (varcounter == 0)
                {
                    Console.WriteLine("We couldn´t find a match \n");
                    FilteredSongs = new string[0, 0];
                    return FilteredSongs;
                }

                for (int i = 0; i < varcounter; i++)
                {
                    name = FilteredSongs[varcounter, 0]; artist = FilteredSongs[varcounter, 1];
                    album = FilteredSongs[varcounter, 2]; genere = FilteredSongs[varcounter, 3];
                    Information();
                }

                return FilteredSongs;
            }

            else
            {
                Console.WriteLine("Error: No proper filter selected \n");
                FilteredSongs = new string[0, 0];
                return FilteredSongs;
            }
        }

    }
}
