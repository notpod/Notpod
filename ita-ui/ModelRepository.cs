using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using iTunesAgent.Domain;
using log4net;

namespace iTunesAgent.UI
{
    public class ModelRepository : Dictionary<string, object>
    {
        ILog l = LogManager.GetLogger(typeof(ModelRepository));

        /// <summary>
        /// Deserialize a component and add it to the repository.
        /// </summary>
        /// <param name="component">Component ID.</param>
        /// <param name="type">Component type.</param>
        /// <param name="stream">Stream to deserialize from.</param>
        public void Deserialize(string component, Type type, Stream stream)
        {            
            XmlSerializer ds = new XmlSerializer(type);
            Object deserialized = ds.Deserialize(stream);

            this.Add(component, deserialized);
        }

        /// <summary>
        /// Serialize a component.
        /// </summary>
        /// <param name="component"></param>
        /// <param name="type"></param>
        /// <param name="stream"></param>
        public void Serialize(string component, Type type, Stream stream)
        {
            XmlSerializer xs = new XmlSerializer(type);
            xs.Serialize(stream, this[component]);
        }

    }
}
