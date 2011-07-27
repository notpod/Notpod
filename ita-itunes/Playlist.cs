using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services
{
    public class Playlist
    {
                
        private string name;

        private int id;

        private string type;

        private int trackCount;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

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


        public int TrackCount
        {
            get { return this.trackCount; }
            set { this.trackCount = value; }
        }

    }
}
