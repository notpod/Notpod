using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Services.iTunes
{
    /*!
     * Exception class used by iTunesService implementations.
     */
    public class ITunesServiceException : ApplicationException
    {

        /*!
         * Instantiate iTunesServiceExpception.
         * 
         * \param message Exception message.
         */
        public ITunesServiceException(string message)
            : base(message)
        {

        }

        /*!
         * Instantiate iTunesServiceExpception.
         * 
         * \param message Exception message.
         * \param inner The inner exception.
         */
        public ITunesServiceException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }
}
