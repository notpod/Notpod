using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Service
{
    /*!
     * Exception class used by iTunesService implementations.
     */
    public class iTunesServiceException : ApplicationException
    {

        /*!
         * Instantiate iTunesServiceExpception.
         * 
         * \param message Exception message.
         */
        public iTunesServiceException(string message)
            : base(message)
        {

        }

        /*!
         * Instantiate iTunesServiceExpception.
         * 
         * \param message Exception message.
         * \param inner The inner exception.
         */
        public iTunesServiceException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }
}
