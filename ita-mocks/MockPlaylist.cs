using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTunesAgent.Mocks
{    
    public class MockPlaylist : IITPlaylist
    {
        private string name;

        private int id;

        private ITPlaylistKind kind;

        public MockPlaylist()
        {

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public int Duration
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

        public ITPlaylistKind Kind
        {
            get { return this.kind; }
            set { this.kind = value; }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void PlayFirstTrack()
        {
            throw new NotImplementedException();
        }

        public void Print(bool showPrintDialog, ITPlaylistPrintKind printKind, string theme)
        {
            throw new NotImplementedException();
        }

        public IITTrackCollection Search(string searchText, ITPlaylistSearchField searchFields)
        {
            throw new NotImplementedException();
        }

        public bool Shuffle
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

        public double Size
        {
            get { throw new NotImplementedException(); }
        }

        public ITPlaylistRepeatMode SongRepeat
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

        public IITSource Source
        {
            get { throw new NotImplementedException(); }
        }

        public string Time
        {
            get { throw new NotImplementedException(); }
        }

        public int TrackDatabaseID
        {
            get { throw new NotImplementedException(); }
        }

        public IITTrackCollection Tracks
        {
            get { return new MockTrackCollection(); }
        }

        public bool Visible
        {
            get { throw new NotImplementedException(); }
        }

        public int playlistID
        {
            get { return this.id; }
            set { this.id = value; }
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
