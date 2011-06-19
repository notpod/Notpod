using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services.iTunes
{        
    using NUnit.Framework;
    using Rhino.Mocks;
    using iTunesLib;

    /*!
     * Test case for iTunesServiceImpl.
     * \sa iTunesServiceImpl
     */
    [TestFixture]
    public class ITunesServiceImplTest
    {
        private MockITunesConnectionFactory mockConnectionFactory;

        private MockITunesAppClass mockITunesApp;

        [SetUp]
        public void Before()
        {            
            mockITunesApp = new MockITunesAppClass();

            mockConnectionFactory = new MockITunesConnectionFactory();
            mockConnectionFactory.ITunesClassToReturn = mockITunesApp;

        }


        [Test]
        public void TestInitialize()
        {
            ITunesServiceImpl service = new ITunesServiceImpl();
            service.MediaSoftwareConnectionFactory = mockConnectionFactory;
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

        private ITunesServiceImpl GetServiceInstance()
        {
            ITunesServiceImpl service = new ITunesServiceImpl();
            service.MediaSoftwareConnectionFactory = this.mockConnectionFactory;
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

        [Test]
        public void TestGetPlaylists_always_returnsListWithPlaylistsEqualToThatReturnedFromITunes()
        {
            MockRepository mocks = new MockRepository();

            ITunesServiceImpl service = GetServiceInstance();
            service.Initialize();

            MockLibrarySource librarySource = new MockLibrarySource();
            MockPlaylistCollection playlistCollection = new MockPlaylistCollection();
            librarySource.Playlists = playlistCollection;

            List<IITPlaylist> playlistsToReturn = new List<IITPlaylist>();
            IITPlaylist playlist1 = new MockPlaylist();
            playlist1.Name = "Playlist 1";
            ((MockPlaylist)playlist1).Kind = ITPlaylistKind.ITPlaylistKindLibrary;

            IITPlaylist playlist2 = new MockPlaylist();
            playlist2.Name = "Playlist 2";
            ((MockPlaylist)playlist2).Kind = ITPlaylistKind.ITPlaylistKindUser;

            playlistsToReturn.Add(playlist1);
            playlistsToReturn.Add(playlist2);

            playlistCollection.Playlists = playlistsToReturn;
                        
            mockITunesApp.LibrarySource = librarySource;

            List<Playlist> playlists = service.GetPlaylists();

            Assert.AreEqual(2, playlists.Count);
            Assert.AreEqual("Playlist 1", playlists[0].Name);
            Assert.AreEqual("Playlist 2", playlists[1].Name);

        }
    }
}
