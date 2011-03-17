using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesAgent.Domain;

namespace iTunesAgent.Connectors
{
    public interface MediaDevicesService
    {
        string[] GetDeviceIds();
        CompatibleDevice GetDeviceById(string deviceId);
    }
}
