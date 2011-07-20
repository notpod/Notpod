/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 20.07.2011
 * Time: 15:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.Domain;

namespace iTunesAgent.UI.Controls
{
	/// <summary>
	/// Description of PlaylistAssociationChooseDevicePage.
	/// </summary>
	public partial class PlaylistAssociationChooseDevicePage : AbstractWizardPage
	{
		
		private ModelRepository model;
	
		
		public PlaylistAssociationChooseDevicePage()
		{
			
			InitializeComponent();
		}
		
       public ModelRepository Model {

			get { return model; }
			set { model = value; }
		}
		
		public override void Populate() 
		{
		    DeviceCollection devices = model.Get<DeviceCollection>("devices");
		    foreach(Device device in devices.Devices) 
		    {
		        cbDevices.Items.Add(device);
		    }
		
		}
		
		public override bool ValidateBeforeNext()
		{
			return true;
		}
	}
}
