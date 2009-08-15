using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace iTunesAgent.Service
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

        /*!
         * Get a specific playlist by it's name.
         * 
         * \param name The name of the playlist.
         * \return The specified playlist if found, otherwise the method returns null.
         */
        Playlist GetPlaylist(string name);

        /*!
         * Initialize the iTunesService.
         */
        void Initialize();
    }
}
