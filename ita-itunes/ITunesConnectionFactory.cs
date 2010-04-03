using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;
namespace iTunesAgent.Services.iTunes
{
    /*!
     * Factory for creating connections to iTunes.
     * \sa AbstractMediaSoftwareServiceFactory
     */
    public class ITunesConnectionFactory : AbstractMediaSoftwareConnectionFactory
    {
        public override object CreateMediaSoftwareConnection()
        {
            return new iTunesAppClass();
        }
    }
}
