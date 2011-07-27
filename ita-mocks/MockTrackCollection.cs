using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTunesAgent.Mocks
{
    public class MockTrackCollection : IITTrackCollection
    {
        public int Count
        {
            get { return 0; }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IITTrack get_ItemByName(string Name)
        {
            throw new NotImplementedException();
        }

        public IITTrack get_ItemByPersistentID(int highID, int lowID)
        {
            throw new NotImplementedException();
        }

        public IITTrack get_ItemByPlayOrder(int Index)
        {
            throw new NotImplementedException();
        }

        public IITTrack this[int Index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
