using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace iTunesAgent.Services
{
    /*!
     * Interface for services providing the iTunes Agent application with access to media software facilities.
     *
     */
    public interface MediaSoftwareService
    {
        /*!
         * Get a list of all available playlists in iTunes.
         * 
         * \return List of Playlist entities representing the different playlists.
         */
        List<Playlist> GetPlaylists();

        
        /// <summary>
        /// Get a specific playlist by it's id.
        /// </summary>
        /// <param name="id">The name of the playlist.</param>
        /// <returns>The specified playlist if found, otherwise the method returns null.</returns>
        Playlist GetPlaylist(int id);

        /*!
         * Initialize the iTunesService.
         */
        void Initialize();


        /*!
         * Accessor for the media software service version. 
         */
        string Version { get; }

        /*!
         * Accessor for the media software service name.
         */
        string Name { get; }

        /*!
         * Set the AbstractMediaSoftwareConnetionFactory to use for obtaining a 
         * reference to the media software in use by this service.
         * 
         */
        AbstractMediaSoftwareConnectionFactory MediaSoftwareConnectionFactory { set; }
    }
}
