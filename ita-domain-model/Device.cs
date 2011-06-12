using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iTunesAgent.Domain
{    
    /// <summary>
    /// Contains information about a configured device - a device that iTunes Agent is able to communicate with.
    /// </summary>
    public class Device
    {        
        private string name;

        private string identifier;

        private List<PlaylistAssociation> playlists = new List<PlaylistAssociation>();

        [XmlElement("name")]
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        [XmlElement("identifier")]
        public string Identifier
        {
            set { identifier = value; }
            get { return identifier; }
        }

        [XmlElement("playlists")]
        public List<PlaylistAssociation> Playlists
        {
            get { return playlists; }
        }

        public void AddPlaylistAssociation(PlaylistAssociation association)
        {
            playlists.Add(association);
        }

        public void AddPlaylistAssociation(long playlistID, string patternID, string deviceFolder)
        {
            playlists.Add(new PlaylistAssociation(playlistID, patternID, deviceFolder));
        }

        public void RemovePlaylistAssociationByPlaylistID(long id)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (playlists[i].PlaylistID == id)
                {
                    playlists.RemoveAt(i);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return this.name;
        }

    }
}
