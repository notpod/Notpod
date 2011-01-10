using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTunesAgent.UI.Properties;

namespace iTunesAgent.UI.Configuration
{
    public class ConfigurationCheckerImpl : ConfigurationChecker
    {
        private ConfigurationWriter configurationWriter;

        public ConfigurationWriter ConfigurationWriter
        {
            get { return configurationWriter; }
            set { configurationWriter = value; }
        }


        #region ConfigurationChecker Members

        /*!
         * Checks application configuration and writes 
         * default configuration if none exists.
         */
        public void CheckConfiguration()
        {
            if (File.Exists(ApplicationUtils.APP_CONFIG_PATH))
            {
                return;
            }

            configurationWriter.Write();
        }

        #endregion
    }
}
