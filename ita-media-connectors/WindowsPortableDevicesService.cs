using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortableDeviceApiLib;
using PortableDeviceTypesLib;

namespace iTunesAgent.Connectors
{

    public class WindowsPortableDevicesService : MediaDevicesService
    {
        #region MediaDevicesService Members

        public string Devices
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        public void Enumerate()
        {
            PortableDeviceManagerClass devMgr = new PortableDeviceManagerClass();

            // Create our client information collection
            PortableDeviceApiLib.IPortableDeviceValues pValues = (PortableDeviceApiLib.IPortableDeviceValues)
                    new PortableDeviceTypesLib.PortableDeviceValuesClass();

            // Create a new IPortableDevice instance
            PortableDeviceClass pPortableDevice = new PortableDeviceClass();

            uint i = 0;

            uint cDevices = 0;

            string strDeviceID = String.Empty;

            string strFriendlyName = String.Empty;

            string strtmp = String.Empty;

            // Retrieve a count of connected WPD devices.
            devMgr.GetDevices(ref strtmp, ref cDevices);

            Console.Out.WriteLine("Number of devices: " + cDevices);

            // Iterate through the connected WPD devices--searching for 
            // a TemperatureSensor device. If it's found, open the device
            // and begin retrieving the temperature property.

            if (cDevices > 0)
            {

                // Retrieve the PnP identifiers for each 

                // connected device.

                string strPnPDeviceIDs = String.Empty;

                devMgr.GetDevices(ref strPnPDeviceIDs, ref cDevices);

                Console.Out.WriteLine("PnP Device IDs: " + strPnPDeviceIDs);

                //// For each connected device, retrieve the friendly

                //// name and compare it to the TempSensor's name.

                for (i = 0; i < cDevices; i++)
                {

                    strFriendlyName = RetrieveFriendlyName(devMgr, strPnPDeviceIDs);

                    Console.Out.Write("Device: " + strFriendlyName);

                }

            }

        }

        string RetrieveFriendlyName(

                        PortableDeviceApiLib.PortableDeviceManagerClass PortableDeviceManager,

                        string PnPDeviceID)
        {

            uint cFriendlyName = 0;

            ushort[] usFriendlyName;

            ushort pDeviceFriendlyName = 0;

            string strFriendlyName = String.Empty;



            // First, pass NULL as the LPWSTR return string parameter to get the total number

            // of characters to allocate for the string value.

            PortableDeviceManager.GetDeviceFriendlyName(PnPDeviceID, ref pDeviceFriendlyName, ref cFriendlyName);



            // Second allocate the number of characters needed and retrieve the string value.



            usFriendlyName = new ushort[cFriendlyName];

            if (usFriendlyName.Length > 0)
            {

                PortableDeviceManager.GetDeviceFriendlyName(PnPDeviceID, ref pDeviceFriendlyName, ref cFriendlyName);



                // We need to convert the array of ushorts to a string, one

                // character at a time.

                foreach (ushort letter in usFriendlyName)

                    if (letter != 0)

                        strFriendlyName += (char)letter;



                // Return the friendly name

                return strFriendlyName;

            }

            else

                return null;

        }

    }
}
