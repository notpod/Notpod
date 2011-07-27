/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 27.07.2011
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace iTunesAgent.Connectors
{
	[TestFixture]
	public class SupportedDevicesManagerTest
	{
		private SupportedDevicesManager manager;
		
		private WindowsPortableDevicesService portableDevicesService;
		
		private MockRepository mocks;
		
		
		
		[SetUp]
		public void Setup() 
		{		

			manager = new SupportedDevicesManager();
			
			mocks = new MockRepository();
		
			portableDevicesService = mocks.StrictMock<WindowsPortableDevicesService>();
			manager.PortableDevicesService = portableDevicesService;
		}
		
		[Test]
		[Ignore]
		public void CheckForConfiguredDevices_ShouldCallGetDeviceIdsOnPortableDevicesService()
		{
			
			string[] listOfIds = new string[]{ "id1" };
			
			Expect.Call(portableDevicesService.GetDeviceIds()).Return(listOfIds);
			mocks.ReplayAll();
			
			manager.CheckForConfiguredDevices();
			
			mocks.VerifyAll();
		}
	}
}
