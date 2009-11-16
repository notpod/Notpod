using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iTunesAgent.Domain
{
    public class PlaylistAssociation
    {
        private long playlistID;

        private string deviceFolder;

        private string patternID;

        public PlaylistAssociation()
        {
        }

        public PlaylistAssociation(long playlistID, string patternID, string deviceFolder)
        {
            this.playlistID = playlistID;
            this.patternID = patternID;
            this.deviceFolder = deviceFolder;
        }

        [XmlElement("playlistid")]
        public long PlaylistID
        {
            set { playlistID = value; }
            get { return playlistID; }
        }

        [XmlElement("folder")]
        public string DeviceFolder
        {
            set { deviceFolder = value; }
            get { return deviceFolder; }
        }

        [XmlElement("pattern")]
        public string PatternID
        {
            set { patternID = value; }
            get { return patternID; }
        }
    }
}
