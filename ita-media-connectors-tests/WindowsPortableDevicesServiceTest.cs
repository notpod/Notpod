using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Connectors
{
    using NUnit.Framework;

    [TestFixture]
    public class WindowsPortableDevicesServiceTest
    {

        [Test]
        public void TestEnumerate()
        {
            WindowsPortableDevicesService s = new WindowsPortableDevicesService();
            s.Enumerate();
        }
    }
}
