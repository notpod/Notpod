using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using NUnit.Framework;

namespace iTunesAgent.Domain
{
    [TestFixture]
    public class ConfigurationTest
    {

        [Test]
        public void TestSerializeConfiguration()
        {

            // Inverted configuration to check that actual 
            // set values are serialized.
            Configuration configuration =
                Configuration.Instance(false, false, true, false, false);

            FileStream writeStream = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            try
            {
                writeStream = new FileStream("configuration.xml", FileMode.CreateNew);
                serializer.Serialize(writeStream, configuration);
            }
            finally
            {
                if (writeStream != null)
                    writeStream.Close();
            }

            FileStream readStream = null;
            try
            {
                readStream = new FileStream("configuration.xml", FileMode.Open);
                Configuration deserializedConfiguration = (Configuration)serializer.Deserialize(readStream);

                Assert.AreEqual(false, deserializedConfiguration.CheckForUpdates);
                Assert.AreEqual(true, deserializedConfiguration.CloseWithITunes);
                Assert.AreEqual(false, deserializedConfiguration.ITAFolder);
                Assert.AreEqual(false, deserializedConfiguration.UseBallons);
                Assert.AreEqual(false, deserializedConfiguration.WarnOnSystemDrive);
            }
            finally
            {
                if (readStream != null)
                    readStream.Close();
            }
            
        }
    }
}
