using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services.iTunes
{        
    using NUnit.Framework;

    /*!
     * Test case for iTunesServiceImpl.
     * \sa iTunesServiceImpl
     */
    [TestFixture]
    public class ITunesServiceImplTest
    {

        [Test]
        public void TestInitialize()
        {
            ITunesServiceImpl service = new ITunesServiceImpl();
            service.MediaSoftwareConnectionFactory = new MockITunesConnectionFactory();     
            service.Initialize();

            Assert.AreEqual(true, service.Initialized);
        }


        [Test]
        [ExpectedException(typeof(MissingFieldException))]
        public void TestInitializeValidatesRequiredFields()
        {

            ITunesServiceImpl service = new ITunesServiceImpl();
            service.Initialize();
        }

        [Test]
        [ExpectedException(typeof(ITunesServiceException))]
        public void TestInitializeFailsOnMoreThanOneCall()
        {

            ITunesServiceImpl service = GetServiceInstance();            
            service.Initialize();
            service.Initialize();
        }

        private static ITunesServiceImpl GetServiceInstance()
        {
            ITunesServiceImpl service = new ITunesServiceImpl();
            service.MediaSoftwareConnectionFactory = new MockITunesConnectionFactory();            
            return service;
        }

        [Test]
        public void TestVersion()
        {
            ITunesServiceImpl service = GetServiceInstance();
            service.Initialize();
            Assert.AreEqual("1.0", service.Version);
        }

        [Test]
        [ExpectedException(typeof(ITunesServiceException))]
        public void TestAccessingMethodsBeforeInitializeIsCalled()
        {
            ITunesServiceImpl service = GetServiceInstance();
            string version = service.Version;
        }
    }
}
