using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services
{
    public class Playlist
    {
                
        private string name;

        private string type;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string PlaylistType
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
