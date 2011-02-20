using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Connectors
{
    using NUnit.Framework;
        
    public class WindowsPortableDevicesServiceTest
    {

        
        public static void Main(String[] args)
        {
            WindowsPortableDevicesService s = new WindowsPortableDevicesService();
            List<CompatibleDevice> devices = s.GetDevices();

            foreach (CompatibleDevice device in devices)
            {
                Console.Out.WriteLine("Name: {0}, Identifier: {1}", device.Name, device.Identifier);
            }

            Console.In.ReadLine();
        }
    }
}
