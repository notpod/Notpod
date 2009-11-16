using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iTunesAgent.Domain
{

    public class Pattern
    {
        private string id;

        private string format;

        [XmlElement("id")]
        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        [XmlElement("format")]
        public string Format
        {
            set { format = value; }
            get { return format; }
        }
    }
}
