/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 26.07.2011
 * Time: 15:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using iTunesAgent.UI.Controls;
using iTunesAgent.Domain;
using iTunesAgent.Services;
using iTunesAgent.UI.Components.Wizard;

namespace iTunesAgent.UI.Controls
{
    /// <summary>
    /// Test case for PlaylistAssociationChooseDevicePageTest.
    /// </summary>
    [TestFixture]
    public class PlaylistAssociationChooseDevicePageTest
    {
        private ModelRepository model;

        private DeviceCollection devices;
        
        private Device device;
        
        [SetUp]
        public void SetUp()
        {
            model = new ModelRepository();
                        
            devices = new DeviceCollection();
            device = new Device();
            device.Name = "Test device";
            device.Identifier = "test";
            devices.Devices.Add(device);
            
            model["devices"] = devices;
        }
        
        
        [Test]
        public void Populate_shouldAddAvailableDevicesToComboBox()
        {
            
            PlaylistAssociationChooseDevicePage page = new PlaylistAssociationChooseDevicePage();
            page.DataStore = new WizardDataStore();
            page.Model = model;
            
            page.Populate();
            
            Assert.AreEqual(devices.Devices.Count, page.SelectedDeviceComboBox.Items.Count);
            
        }
        
        [Test]
        public void Populate_shouldAutoSelectPreviouslySelectedDeviceWhenAvailable()
        {            
            PlaylistAssociationChooseDevicePage page = new PlaylistAssociationChooseDevicePage();
            page.DataStore = new WizardDataStore();
            page.Model = model;
            page.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDDEVICE] = device;
            
            page.Populate();
            
            Assert.AreSame(device, page.SelectedDeviceComboBox.SelectedItem);
        }
        
    }
}
