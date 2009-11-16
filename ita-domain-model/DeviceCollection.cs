using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iTunesAgent.Domain
{
    [XmlRoot("devicecollection")]
    public class DeviceCollection
    {

        private List<Device> devices = new List<Device>();

        [XmlElement("devices")]
        public List<Device> Devices
        {
            set { devices = value; }
            get { return devices; }
        }

    }
}
