using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTunesAgent.Mocks
{
    public class MockPlaylistCollection : IITPlaylistCollection
    {

        public List<IITPlaylist> playlists;

        public List<IITPlaylist> Playlists
        {
            get { return this.playlists; }
            set { this.playlists = value; }
        }

        public int Count
        {
            get { return this.playlists.Count; }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return playlists.GetEnumerator();
        }

        public IITPlaylist get_ItemByName(string Name)
        {
            throw new NotImplementedException();
        }

        public IITPlaylist get_ItemByPersistentID(int highID, int lowID)
        {
            throw new NotImplementedException();
        }

        public IITPlaylist this[int index]
        {
            get { return this.playlists[index]; }
        }
    }
}
