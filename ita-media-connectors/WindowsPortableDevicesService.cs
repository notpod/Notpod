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

        /// <summary>
        /// Returns the USB identifiers for the connected MTP compatible devices.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns a WindowsPortableDevice based on the provided ID. The caller must call Connect on the returned device in order to use it.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public CompatibleDevice GetDeviceById(string deviceId)
        {

            WindowsPortableDevice device = new WindowsPortableDevice(deviceId);
            return device;

        }

    }
}
