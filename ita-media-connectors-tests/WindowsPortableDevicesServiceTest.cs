using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesAgent.Connectors.Domain;

namespace iTunesAgent.Connectors
{
    using NUnit.Framework;
        
    public class WindowsPortableDevicesServiceTest
    {

        
        public static void Main(String[] args)
        {
            WindowsPortableDevicesService s = new WindowsPortableDevicesService();
            string[] devices = s.GetDeviceIds();

            foreach (string id in devices)
            {
                Console.Out.WriteLine("Identifier: {0}", id);
                Console.Out.WriteLine("Connecting...");
                CompatibleDevice device = s.GetDeviceById(id);
                device.Connect();
                Console.Out.WriteLine("Name: " + device.Name);

                Console.Out.WriteLine("Disconnecting...");
                device.Disconnect();
            }

            Console.In.ReadLine();
        }
    }
}
