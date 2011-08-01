/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 28.07.2011
 * Time: 13:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace iTunesAgent.UI
{
	/// <summary>
	/// Constants used when intercepting system messages
	/// </summary>
	public sealed class WMConstants
	{
		
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MINIMIZE = 0xF020;
        
        public const int WM_DEVICECHANGE = 0x0219;        
        public const int DBT_DEVICEARRIVAL = 0x8000;        
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        public const int DBT_DEVNODES_CHANGED = 0x0007;
	}
}
