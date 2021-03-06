﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.XPath;

namespace ReproductorSpotifai
{
    class Spotifai : Playlist
    {
        private int songscounter = 0;
        private int reconvar;
        private int listcounter;

        private object[,] Playlists = new object[40,40];

        public Spotifai() : base()
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

                for (int j = 0; j < varcounter; j++)
                {
                    name = FilteredSongs[j, 0]; artist = FilteredSongs[j, 1];
                    album = FilteredSongs[j, 2]; genere = FilteredSongs[j, 3];
                    Information();
                }

                if (varcounter == 0)
                {
                    Console.WriteLine("We couldn´t find a match \n");
                    FilteredSongs = new string[0, 0];
                    return FilteredSongs;
                }

                Console.WriteLine("\n Song added \n");
                return FilteredSongs;
            }

            else
            {
                Console.WriteLine("Error: No proper filter selected \n");
                FilteredSongs = new string[0, 0];
                return FilteredSongs;
            }
        }

        public bool NewUserPlaylist(string filter, string value, string playlistnewname)
        {
            int varcounter = 0;

            if (filter == "Name") { reconvar = 0; }
            if (filter == "Artist") { reconvar = 1; }
            if (filter == "Album") { reconvar = 2; }
            if (filter == "Genere") { reconvar = 3; }


            if (filter == "Name" || filter == "Artist" || filter == "Album" || filter == "Genere")
            {
                Playlists[listcounter, 0] = listcounter + 2;
                Playlists[listcounter, 1] = playlistnewname;

                for (int i = 0; i < songscounter; i++)
                {
                    if (value == Songs[i, reconvar].ToString())
                    {
                        Playlists[listcounter,(i+2)] = ("\n Genere: " + Songs[i, 3].ToString() + "\n Artist: " + Songs[i, 1].ToString() + 
                                                        "\n Album: " + Songs[i, 2].ToString() + "\n Name: " + Songs[i, 0].ToString() + "\n");
                        varcounter++;
                    }
                }
                Console.WriteLine("\n Playlist added \n");
                string auxvar = Playlists[listcounter, 0].ToString();
                Console.WriteLine("\n Playlist: " + Playlists[listcounter, 1].ToString());
                for (int j = 0; j < Int32.Parse(auxvar); j++)
                {
                    Console.WriteLine(Playlists[listcounter, (j + 2)].ToString());
                }
                listcounter++;
                return true;
            }
            if (varcounter == 0)
            {
                Console.WriteLine("We couldn´t find a match, no playlist created \n");
                return false;
            }
            else
            {
                Console.WriteLine("Error: No proper filter selected \n");
                return false;
            }
        }

        public string MyPlaylists()
        {
            if (listcounter == 0)
            {
                Console.WriteLine("No playlist has been found");
            }
            for (int i = 0; i < listcounter; i++)
            {
                string auxvar = Playlists[i, 0].ToString();

                Console.WriteLine("\n Playlist: " + Playlists[i, 1].ToString());

                for (int j = 0; j < Int32.Parse(auxvar); j++)
                {
                    Console.WriteLine(Playlists[i,(j+2)].ToString());
                }
            }
            return "";
        }

    }
}
