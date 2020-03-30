using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorSpotifai
{
    class Program
    {
        static void Main(string[] args)
        {
            string var;
            string search;
            string newname;

            Console.WriteLine("Welcome back user!");
            Spotifai user = new Spotifai();

            while (true){
                Console.WriteLine("\n Menu: \n Add / Show / Filter / My Playlists / New Playlist / Exit \n");
                var = Console.ReadLine();
                if(var == "Add")
                {
                    user.AddSong();
                }

                if (var == "Show")
                {
                    user.ShowSongs();
                }

                if (var == "Filter")
                {
                    Console.WriteLine("\n Kind: Genere / Artist / Album / Name \n");
                    var = Console.ReadLine();

                    Console.WriteLine("\n Write what you want to search: ");
                    search = Console.ReadLine();

                    user.Filter(var, search);
                }

                if (var == "New Playlist")
                {
                    Console.WriteLine("\n Kind: Genere / Artist / Album / Name \n");
                    var = Console.ReadLine();

                    Console.WriteLine("\n Type your filter: ");
                    search = Console.ReadLine();

                    Console.WriteLine("\n Type your playlist name: ");
                    newname = Console.ReadLine();

                    user.NewUserPlaylist(var, search, newname);
                }

                if (var == "My Playlists")
                {
                    user.MyPlaylists();
                }

                if (var == "Exit"){
                    break;
                }
            }
        }
    }
}
