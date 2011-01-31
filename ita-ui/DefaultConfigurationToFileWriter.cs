using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTunesAgent.UI.Properties;

namespace iTunesAgent.UI.Configuration
{
    
    public class DefaultConfigurationToFileWriter : ConfigurationWriter
    {
        private string filePath;

        public static string GetDefaultConfiguration()
        {
            return Resources.DEFAULT_CONFIGURATION;
        }

        public DefaultConfigurationToFileWriter(string filePath)
        {
            this.filePath = filePath;
        }

        #region ConfigurationWriter Members

        /*!
         * \copydoc ConfigurationWriter::Write()
         */
        public void Write()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath);
                writer.Write(Resources.DEFAULT_CONFIGURATION);
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                throw new IOException(Resources.StrDefaultConfigWriteError, ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        #endregion

        #region ITranslatable Members

        public void OnTranslate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
