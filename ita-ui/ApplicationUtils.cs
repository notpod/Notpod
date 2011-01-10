using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTunesAgent.Domain;
using iTunesAgent.UI.Properties;
using System.Windows.Forms;
using iTunesAgent.UI.Configuration;

namespace iTunesAgent.UI
{
    public class ApplicationUtils
    {
        public static readonly string APP_CONFIG_PATH = GetUserAppDataPath() + "\\ApplicationConfiguration.xml";

        /*!
         * Populates the ModelRepository with configuration from file.
         */
        public static ModelRepository LoadModelRepository(ConfigurationChecker configurationChecker)
        {
            ModelRepository repo = new ModelRepository();

            Stream read;
            try
            {
                configurationChecker.CheckConfiguration();
                read = new FileStream(APP_CONFIG_PATH, FileMode.Open);

            }
            catch (Exception ex)
            {

                throw new IOException("Unable to load application configuration.", ex);
            }

            try
            {
                repo.Deserialize("appconfig", typeof(iTunesAgent.Domain.Configuration), read);
            }
            finally
            {

                if (read != null)
                {
                    read.Close();
                }
            }

            return repo;
        }

        public static string GetUserAppDataPath()
        {
            return Application.UserAppDataPath;
        }
    }
}
