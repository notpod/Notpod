/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 27.07.2011
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using iTunesAgent.Domain;
using System.Collections.Generic;
using System.Linq;

namespace iTunesAgent.Connectors
{
	/// <summary>
	/// Description of SupportedDevicesManager.
	/// </summary>
	public class SupportedDevicesManager : IDevicesManager
	{
		
		private DeviceCollection configuredDevices;
		
		private List<CompatibleDevice> connectedDevices = new List<CompatibleDevice>();
		
		private WindowsPortableDevicesService portableDevicesService;
		
		
		public SupportedDevicesManager()
		{
		}
		
		public void CheckForConfiguredDevices()
		{
			
			string[] idsOfConnectedDevices = portableDevicesService.GetDeviceIds();
			foreach(string id in idsOfConnectedDevices) {
				
				if(CheckIfDeviceAlreadyRecognized(id)) 
				{					
					continue;
				}
				
				IEnumerable<Device> recognizedList = from c in configuredDevices.Devices where c.Identifier == id select c;
				if(recognizedList.Count() == 0)
				{					
					continue;
				}
																
				CompatibleDevice compatibleDevice = portableDevicesService.GetDeviceById(id);
				compatibleDevice.Connect();
				
				connectedDevices.Add(compatibleDevice);
				OnNewDeviceConnected(compatibleDevice);
			}
			
		}
		
		bool CheckIfDeviceAlreadyRecognized(string id)
		{
			
			return (from d in configuredDevices.Devices where d.Identifier == id select d).Count() > 0;
			
		}
		
		public CompatibleDevice GetDevice(string identifier)
		{
			throw new NotImplementedException();
		}
		
		public DeviceCollection ConfiguredDevices {
			get { return configuredDevices; }
			set { configuredDevices = value; }
		}

		public WindowsPortableDevicesService PortableDevicesService {
			get { return portableDevicesService; }
			set { portableDevicesService = value; }
		}
		
		protected virtual void OnNewDeviceConnected(CompatibleDevice device) {
			
			if(NewDeviceConnected != null) 
			{
				EventArgs args = new EventArgs();
				NewDeviceConnected(args);
			}
		}

		
		public event NewDeviceConnectedHandler NewDeviceConnected;
	}
}
