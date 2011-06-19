using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;
namespace iTunesAgent.Services
{
    public class MockLibrarySource : IITSource 
    {

        private IITPlaylistCollection playlists;

        public double Capacity
        {
            get { throw new NotImplementedException(); }
        }

        public double FreeSpace
        {
            get { throw new NotImplementedException(); }
        }

        public void GetITObjectIDs(out int sourceID, out int playlistID, out int trackID, out int databaseID)
        {
            throw new NotImplementedException();
        }

        public int Index
        {
            get { throw new NotImplementedException(); }
        }

        public ITSourceKind Kind
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITPlaylistCollection Playlists
        {
            get { return playlists; }
            set { this.playlists = value; }
        }

        public int TrackDatabaseID
        {
            get { throw new NotImplementedException(); }
        }

        public int playlistID
        {
            get { throw new NotImplementedException(); }
        }

        public int sourceID
        {
            get { throw new NotImplementedException(); }
        }

        public int trackID
        {
            get { throw new NotImplementedException(); }
        }
    }
}
