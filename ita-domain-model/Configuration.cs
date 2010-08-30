using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iTunesAgent.Domain
{
    [XmlRoot("configuration")]
    public class Configuration
    {
        private bool useBaloons = true;
        
        private bool itaFolder = true;

        private bool closeWithITunes = false;

        private bool warnOnSystemDrive = true;

        private bool checkForUpdates = true;

        private string language = "en-GB";

        private Configuration()
        {
        }

        [XmlElement("usebaloon")]
        public bool UseBallons
        {
            get { return useBaloons; }
            set { useBaloons = value; }
        }

        [XmlElement("closewithitunes")]
        public bool CloseWithITunes
        {
            get { return closeWithITunes; }
            set { closeWithITunes = value; }
        }

        [XmlElement("itafolder")]
        public bool ITAFolder
        {
            get { return itaFolder; }
            set { itaFolder = value; }
        }

        [XmlElement("warnonsystemdrive")]
        public bool WarnOnSystemDrive
        {
            get { return warnOnSystemDrive; }
            set { warnOnSystemDrive = value; }
        }

        [XmlElement("checkforupdates")]
        public bool CheckForUpdates
        {
            get { return checkForUpdates; }
            set { checkForUpdates = value; }
        }

        [XmlElement("language")]
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
                
        /// <summary>
        /// Instantiate a Configuration object with the provided values.
        /// </summary>
        /// <param name="useBallons">Use ballon notifications.</param>
        /// <param name="itaFolder">Use a top level "iTunes Agent" folder 
        /// in iTunes for device playlists.</param>
        /// <param name="closeWithItunes">Close iTunes Agent whenever 
        /// iTunes is closing down.</param>
        /// <param name="warnOnSystemDrive">Warn if the user selects what 
        /// appears to be a system drive.</param>
        /// <param name="checkForUpdates">Automatically check for 
        /// application updates.</param>
        /// <returns>New instance of Configuration.</returns>
        public static Configuration Instance(bool useBallons, bool itaFolder, 
            bool closeWithItunes, bool warnOnSystemDrive, bool checkForUpdates)
        {
            Configuration cf = new Configuration();
            cf.useBaloons = useBallons;
            cf.itaFolder = itaFolder;
            cf.closeWithITunes = closeWithItunes;
            cf.warnOnSystemDrive = warnOnSystemDrive;
            cf.checkForUpdates = checkForUpdates;

            return cf;
        }

        /// <summary>
        /// Return a default Configuration instance.
        /// </summary>
        /// <returns></returns>
        public static Configuration Instance()
        {
            return new Configuration();
        }
    }
}
