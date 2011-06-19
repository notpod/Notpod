using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;
namespace iTunesAgent.Services
{
    public class MockITunesConnectionFactory : AbstractMediaSoftwareConnectionFactory
    {

        private iTunesApp iTunesClassToReturn;

        public override object CreateMediaSoftwareConnection()
        {
            return iTunesClassToReturn;
        }

        public iTunesApp ITunesClassToReturn
        {
            get { return this.iTunesClassToReturn; }
            set { this.iTunesClassToReturn = value; }
        }
    }
}
