using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesAgent.Domain;

namespace iTunesAgent.Connectors
{
    public interface MediaDevicesService<T>
    {
        string[] GetDeviceIds();
        T GetDeviceById(string deviceId);
    }
}
