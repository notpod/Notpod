using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.Connectors
{
    public abstract class CompatibleDevice
    {
        private string identifier;

        private string name;

        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
