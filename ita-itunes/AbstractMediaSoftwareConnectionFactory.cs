using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services
{
    /*!
     * Abstract factory class for obtaining references to media 
     * software.
     */
    public abstract class AbstractMediaSoftwareConnectionFactory
    {
        public abstract object CreateMediaSoftwareConnection();
    }
}
