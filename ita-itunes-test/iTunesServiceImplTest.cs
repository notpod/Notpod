using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services.iTunes
{        
    using NUnit.Framework;
    using Rhino.Mocks;
    using iTunesLib;
    using iTunesAgent.Mocks;

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
            ITunesServiceImpl service = GetServiceInstance();
            service.Initialize();

            MockLibrarySource librarySource = CreateAndSetUpLibrarySource();
                        
            mockITunesApp.LibrarySource = librarySource;

            List<Playlist> playlists = service.GetPlaylists();

            Assert.AreEqual(2, playlists.Count);
            Assert.AreEqual("Playlist 1", playlists[0].Name);
            Assert.AreEqual("Playlist 2", playlists[1].Name);

        }
        
        MockLibrarySource CreateAndSetUpLibrarySource()
        {
            MockLibrarySource librarySource = new MockLibrarySource();
            MockPlaylistCollection playlistCollection = new MockPlaylistCollection();
            librarySource.Playlists = playlistCollection;

            List<IITPlaylist> playlistsToReturn = new List<IITPlaylist>();
            MockPlaylist playlist1 = new MockPlaylist();
            playlist1.Name = "Playlist 1";
            playlist1.playlistID = 1;
            ((MockPlaylist)playlist1).Kind = ITPlaylistKind.ITPlaylistKindLibrary;

            MockPlaylist playlist2 = new MockPlaylist();
            playlist2.Name = "Playlist 2";
            playlist2.playlistID = 2;
            ((MockPlaylist)playlist2).Kind = ITPlaylistKind.ITPlaylistKindUser;

            playlistsToReturn.Add(playlist1);
            playlistsToReturn.Add(playlist2);

            playlistCollection.Playlists = playlistsToReturn;
            
            return librarySource;
        }
        
        [Test]
        public void GetPlaylist_ShouldReturnPlaylistForTheGivenID() 
        {            
            ITunesServiceImpl service = GetServiceInstance();
            service.Initialize();

            MockLibrarySource librarySource = CreateAndSetUpLibrarySource();
                        
            mockITunesApp.LibrarySource = librarySource;

            Playlist playlist = service.GetPlaylist(2);

            Assert.NotNull(playlist);
            Assert.AreEqual(2, playlist.ID);            
        }
        
        [Test]
        public void GetPlaylist_ShouldReturNullWhenNoPlaylistWithTheGivenID() 
        {            
            ITunesServiceImpl service = GetServiceInstance();
            service.Initialize();

            MockLibrarySource librarySource = CreateAndSetUpLibrarySource();
                        
            mockITunesApp.LibrarySource = librarySource;

            Playlist playlist = service.GetPlaylist(42);

            Assert.Null(playlist);   
        }
    }
}
