using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PortableDeviceApiLib;

namespace iTunesAgent.Connectors.Domain
{
    /// <summary>
    /// Value object for storing information about a compatible portable device connected to the computer.
    /// </summary>
    public class WindowsPortableDevice : CompatibleDevice
    {
        private string deviceId;

        private PortableDevice portableDevice;
        
        private PortableDeviceFolder deviceContents;
        
        public WindowsPortableDevice(string deviceId)
        {
            this.deviceId = deviceId;
            portableDevice = new PortableDeviceClass();
                
        }

        public override void Connect()
        {
            //Creating propValues for connection
            IPortableDeviceValues clientValues = (IPortableDeviceValues)new PortableDeviceTypesLib.PortableDeviceValuesClass();

            //Set the application name
            _tagpropertykey prop = PortableDevicePKeys.WPD_CLIENT_NAME;
            clientValues.SetStringValue(ref prop, "iTunes Agent");
            //Set the App version
            prop = PortableDevicePKeys.WPD_CLIENT_MAJOR_VERSION;
            clientValues.SetFloatValue(ref prop, 2f);
            //Set the app minor version
            prop = PortableDevicePKeys.WPD_CLIENT_MINOR_VERSION;
            clientValues.SetFloatValue(ref prop, 0f);

            //Open connection
            this.portableDevice.Open(this.deviceId, clientValues);
            
            SetValues();

            RefreshContents();
            
            this.isConnected = true;           
        }

        private void SetValues()
        {
            IPortableDeviceContent content;
            IPortableDeviceProperties properties;
            PortableDeviceApiLib.IPortableDeviceValues propertyValues;

            this.portableDevice.Content(out content);
            content.Properties(out properties);

            properties.GetValues("DEVICE", null, out propertyValues);

            string val = string.Empty;
            propertyValues.GetStringValue(ref PortableDevicePKeys.WPD_DEVICE_FRIENDLY_NAME, out val);
            this.Name = val;

            this.Identifier = deviceId;
        }

        public override void Disconnect()
        {

            this.portableDevice.Close();
            isConnected = false;
        }
        
        public override PortableDeviceFolder GetContents()
        {
            return deviceContents;
        }
        
        public override void RefreshContents() 
        {
            var root = new PortableDeviceFolder("DEVICE", "DEVICE");

            IPortableDeviceContent content;
            this.portableDevice.Content(out content);
            EnumerateContents(ref content, root);

            deviceContents = root;
        }
        
        public override bool CheckPath(String path) 
        {
            
            string[] partsOfPath = path.Split('\\');
            
            PortableDeviceFolder currentFolder = deviceContents;
            for(int i = 0; i < partsOfPath.Length; i++) 
            {
                
                IEnumerable<PortableDeviceObject> matchingFolder = from f in currentFolder.Files where f.Name == partsOfPath[i] select f;
                if(matchingFolder.Count() == 0)
                {
                    return false;
                }
                
                currentFolder = (PortableDeviceFolder)matchingFolder.First();
            }
            
            return true;
            
        }

        public override string ToString()
        {
            return this.Name;
        }
        
        

    }
}
