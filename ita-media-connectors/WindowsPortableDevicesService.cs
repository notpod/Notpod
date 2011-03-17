using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PortableDeviceApiLib;
using PortableDeviceTypesLib;
using iTunesAgent.Domain;
using iTunesAgent.Connectors.Domain;

namespace iTunesAgent.Connectors
{

    public class WindowsPortableDevicesService : MediaDevicesService
    {
        private PortableDeviceManager deviceManager;

        public WindowsPortableDevicesService()
        {
            deviceManager = new PortableDeviceManagerClass();
        }


        #region MediaDevicesService Members

        public string Devices
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        public string[] GetDeviceIds()
        {
                        
            uint cDevices = 1;
            deviceManager.GetDevices(null, ref cDevices);
                        
            if (cDevices == 0)
            {
                return new string[0];
            }

            string[] idArray = new string[cDevices];
           
                deviceManager.GetDevices(ref idArray[0], ref cDevices);

                return idArray;                        
        }

        public CompatibleDevice GetDeviceById(string deviceId)
        {

            WindowsPortableDevice device = new WindowsPortableDevice(deviceId);
            return device;

        }
                
    }
}
