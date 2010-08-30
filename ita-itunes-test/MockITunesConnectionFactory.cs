using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services
{
    public class MockITunesConnectionFactory : AbstractMediaSoftwareConnectionFactory
    {
        public override object CreateMediaSoftwareConnection()
        {
            return new MockITunesAppClass();
        }
    }
}
