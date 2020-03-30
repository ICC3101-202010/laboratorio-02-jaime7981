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
            Console.WriteLine("Welcome back user!");
            Spotifai user = new Spotifai();

            while (true){
                Console.WriteLine("\n Menu: \n Add / Show / Search / Exit \n");
                var = Console.ReadLine();
                if(var == "Add")
                {
                    user.AddSong();
                }

                if (var == "Show")
                {
                    user.ShowSongs();
                }

                if (var == "Search")
                {
                    Console.WriteLine("\n Kind: Genere / Artist / Album / Name \n");
                    var = Console.ReadLine();
                    Console.WriteLine("\n Write what you want to search: ");
                    search = Console.ReadLine();

                    user.Filter(var, search);
                }

                if (var == "Exit"){
                    break;
                }
            }
        }
    }
}
