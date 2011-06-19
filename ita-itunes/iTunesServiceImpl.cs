using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services.iTunes
{
    using iTunesAgent.Services;
    using iTunesLib;
    /*!
     * Implementation of the MediaSoftwareService interface - providing iTunes Agent with access to iTunes' facilities.
     */
    public class ITunesServiceImpl : MediaSoftwareService
    {
        public static string SERVICE_NAME = "itunes";

        private AbstractMediaSoftwareConnectionFactory softwareConnectionFactory;
        
        private iTunesApp itunesCom;

        private bool initialized = false;

        private string version;

        private string name = "iTunes";


        /*!
         * \copydoc MediaSoftwareService::Version
         */
        public string Version
        {
            get
            {
                ValidateState();
                return version;
            }
        }

        public string Name
        {
            get
            {
                ValidateState();
                return name;
            }
        }

        /*!
         * \return A boolean indicating whether the service has been initialized 
         * or not.
         */
        public bool Initialized
        {            
            get
            {
                return initialized;
            }
        }

        #region MediaSoftwareService Members

        /*!
         * \copydoc MediaSoftwareService::Initialize()
         */
        public void Initialize()
        {

            ValidateFields();

            if (initialized)
                throw new ITunesServiceException("You tried to initialize me twice.");

            try
            {
                itunesCom = (iTunesApp)softwareConnectionFactory.CreateMediaSoftwareConnection();
                version = itunesCom.Version;
                initialized = true;
                
                
            }
            catch (Exception e)
            {
                throw new ITunesServiceException("Unable to instantiate iTunes adapter.", e);
            }

        }

        private void ValidateFields()
        {
            if (softwareConnectionFactory == null)
            {
                throw new MissingFieldException("Required field is not set.", "softwareConnectionFactory");
            }
        }

        private void ValidateState()
        {
            if (!initialized)
            {
                throw new ITunesServiceException("Service instance not initialized. Please call Initialize() first.");
            }
        }

        /*!
         * 
         * \copydoc MediaSoftwareService::GetPlaylists()
         */
        public List<Playlist> GetPlaylists()
        {
            ValidateState();
            IITPlaylistCollection playlists = itunesCom.LibrarySource.Playlists;

            List<Playlist> listOfPlaylists = new List<Playlist>();

            foreach (IITPlaylist playlist in playlists)
            {

                Playlist pl = new Playlist();
                pl.Name = playlist.Name;
                pl.PlaylistType = playlist.Kind.ToString();                
                listOfPlaylists.Add(pl);
            }

            return listOfPlaylists;

        }

        /*!
         * \copydoc MediaSoftwareService::GetPlaylist(string)
         */
        public Playlist GetPlaylist(string name)
        {
            ValidateState();
            throw new NotImplementedException();
        }

        #endregion

        /*!
         * \copydoc MediaSoftwareService::MediaSoftwareConnectionFactory{set}
         */
        public AbstractMediaSoftwareConnectionFactory MediaSoftwareConnectionFactory
        {
            set
            {
                softwareConnectionFactory = value;
            }
        }
    }
}
