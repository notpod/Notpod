using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesAgent.Services;

namespace iTunesAgent.Mocks
{
    public class MockMediaSoftwareService : MediaSoftwareService
    {

        private List<Playlist> playlists;

        public List<Playlist> GetPlaylists()
        {
            return playlists;
        }

        public Playlist GetPlaylist(string id)
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public string Version
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public AbstractMediaSoftwareConnectionFactory MediaSoftwareConnectionFactory
        {
            set { throw new NotImplementedException(); }
        }

        #region MockMediaSoftwareService specific methods for setting dummy values 

        public void SetPlaylists(List<Playlist> playlists)
        {
            this.playlists = playlists;
        }

        #endregion 
    }
}
