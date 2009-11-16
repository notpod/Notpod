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

        private Pattern()
        {
        }

        public static Pattern Instance(string id, string format)
        {
            Pattern pattern = new Pattern();
            pattern.id = id;
            pattern.format = format;
            return pattern;
        }

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
