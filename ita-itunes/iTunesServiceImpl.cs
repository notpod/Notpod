using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Service
{
    using iTunesLib;
    /*!
     * Implementation of the IiTunesService interface - providing iTunes Agent with access to iTunes' facilities.
     */
    public class iTunesServiceImpl : MediaSoftwareService
    {
        private iTunesApp itunesCom;

        private bool initialized = false;

        private string version;

        private List<IiTunesListener> listeners = new List<IiTunesListener>();

        /*!
         * Get the iTunes version.
         */
        public string Version
        {
            get
            {
                return version;
            }
        }

        #region IiTunesService Members

        /*!
         * \copydoc IiTunesService::Initialize()
         */
        void MediaSoftwareService.Initialize()
        {
            if (initialized)
                throw new iTunesServiceException("You tried to initialize me twice.");

            try
            {
                itunesCom = new iTunesAppClass();
                version = itunesCom.Version;
                initialized = true;
                
                
            }
            catch (Exception e)
            {
                throw new iTunesServiceException("Unable to instantiate iTunes adapter.", e);
            }

        }

        /*!
         * 
         * \copydoc IiTunesService::GetPlaylists()
         */
        List<Playlist> MediaSoftwareService.GetPlaylists()
        {
            throw new NotImplementedException();
        }

        /*!
         * \copydoc IiTunesService::GetPlaylist(string)
         */
        Playlist MediaSoftwareService.GetPlaylist(string name)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
