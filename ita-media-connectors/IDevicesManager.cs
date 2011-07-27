/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 27.07.2011
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace iTunesAgent.Connectors
{
	
	public delegate void NewDeviceConnectedHandler(EventArgs e);
	/// <summary>
	/// Provides an interface for managers handling devices the application can work with.
	/// </summary>
	public interface IDevicesManager
	{
		
		event NewDeviceConnectedHandler NewDeviceConnected;
		
		/// <summary>
		/// Instruct the manager to look for new devices connected to the system, that are 
		/// configured for use with the application.
		/// </summary>
		void CheckForConfiguredDevices();
						
		/// <summary>
		/// Get a reference to a specific device by it's identifier.
		/// </summary>
		/// <param name="identifier">The identifier for the device</param>
		/// <returns></returns>
		CompatibleDevice GetDevice(string identifier);
		
		
	}
}
