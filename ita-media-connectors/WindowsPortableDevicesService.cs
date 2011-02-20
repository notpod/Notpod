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

        public List<CompatibleDevice> GetDevices()
        {

            //
            // Probe for number of devices
            //
            uint cDevices = 1;
            deviceManager.GetDevices(null, ref cDevices);

            //
            // Re-allocate if needed
            //
            if (cDevices == 0)
            {
                return null;
            }

            string deviceID = "";
            deviceManager.GetDevices(ref deviceID, ref cDevices);

            List<CompatibleDevice> devices = new List<CompatibleDevice>();

            for (int ndxDevices = 0; ndxDevices < cDevices; ndxDevices++)
            {

                PortableDevice portableDevice = new PortableDeviceClass();

                PortableDeviceApiLib.IPortableDeviceValues clientValues = (PortableDeviceApiLib.IPortableDeviceValues)new PortableDeviceTypesLib.PortableDeviceValuesClass();

                //Set the application name
                PortableDeviceApiLib._tagpropertykey prop = PortableDevicePKeys.WPD_CLIENT_NAME;
                clientValues.SetStringValue(ref prop, Application.ProductName);
                
                //Set the App version
                prop = PortableDevicePKeys.WPD_CLIENT_MAJOR_VERSION;
                clientValues.SetFloatValue(ref prop, 1.0f);
                
                //Open connection
                portableDevice.Open(deviceID, clientValues);


                WindowsPortableDevice device = new WindowsPortableDevice();
                device.Identifier = deviceID;
                device.Name = RetrieveFriendlyName(portableDevice, deviceID);
                
                portableDevice.Close();

                devices.Add(device);
            }

            return devices;

        }

        private string RetrieveFriendlyName(PortableDeviceApiLib.IPortableDevice portableDevice, string objectId)
        {
            IPortableDeviceContent content;
            IPortableDeviceProperties properties;
            PortableDeviceApiLib.IPortableDeviceValues propertyValues;

            portableDevice.Content(out content);
            content.Properties(out properties);

            properties.GetValues("DEVICE", null, out propertyValues);

            string val = string.Empty;
            propertyValues.GetStringValue(PortableDevicePKeys.WPD_DEVICE_FRIENDLY_NAME, out val);

            return val;
        }

    }
}
