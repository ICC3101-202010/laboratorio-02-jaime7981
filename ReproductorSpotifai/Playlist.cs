using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorSpotifai
{
    class Playlist : Song
    {
        private string playlistname;

        public Playlist() : base()
        {

        }

        public Playlist(string playlistname) : base()
        {
            this.playlistname = playlistname;
        }

        public string GetPlaylistName() { return playlistname; }
    }
}
