using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using Rhino.Mocks;

namespace iTunesAgent.UI.Configuration
{
    [TestFixture]
    public class ConfigurationCheckerImplTest
    {
        private string testConfigurationFile = "testConfiguration.xml";

        MockRepository mock = new MockRepository();
        ConfigurationWriter configurationWriter = null;

        [TestFixtureSetUp]
        public void Before()
        {
            if (File.Exists(testConfigurationFile))
            {
                File.Delete(testConfigurationFile);
            }

            SetUpMock();
        }

        private void SetUpMock()
        {
            configurationWriter = mock.StrictMock<ConfigurationWriter>();
        }

        [Test]
        public void CheckConfigurationShouldCallWriteOnConfigurationManagerWhenNoExistingConfiguration()
        {
            ConfigurationCheckerImpl checker = new ConfigurationCheckerImpl();
            checker.ConfigurationWriter = configurationWriter;            
            Expect.Call(configurationWriter.Write);
            mock.ReplayAll();

            checker.CheckConfiguration();

            mock.VerifyAll();
        }
    }
}
