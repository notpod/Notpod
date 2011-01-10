using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using iTunesAgent.UI.Properties;

namespace iTunesAgent.UI.Configuration
{
    [TestFixture]
    public class DefaultConfigurationToFileWriterTest
    {
        private string testConfigurationFileName = "testConfiguation.xml";

        [TestFixtureSetUp]
        public void Before()
        {
            if (File.Exists(testConfigurationFileName))
            {
                File.Delete(testConfigurationFileName);
            }
        }
                
        [Test]
        public void TestWrite()
        {

            DefaultConfigurationToFileWriter configurationWriter = new DefaultConfigurationToFileWriter(testConfigurationFileName);
            configurationWriter.Write();

            Assert.AreEqual(true, File.Exists(testConfigurationFileName));

            string writtenContent = File.ReadAllText(testConfigurationFileName);
            Assert.AreEqual(DefaultConfigurationToFileWriter.GetDefaultConfiguration(), writtenContent);
        }
    }
}
