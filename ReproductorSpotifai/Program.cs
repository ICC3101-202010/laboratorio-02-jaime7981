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
            Console.WriteLine("Welcome back user! \n");

            while (true){
                Spotifai a = new Spotifai("Rock", "Dire Straits", "Dire Straits", "Sultains Of Swing");

                Console.WriteLine("Do you want to add a new song? \n Yes/No");
                var = Console.ReadLine();
                if(var == "Yes")
                {
                    Console.WriteLine(a.AddSong());
                }

                a.WatchSong();

                Console.WriteLine("Do you want to exit? \n Exit");
                var = Console.ReadLine();
                if (var == "Exit"){
                    break;
                }
            }
        }
    }
}
