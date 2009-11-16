using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Xml.Serialization;
using System.IO;

namespace iTunesAgent.Domain
{
    [TestFixture]
    public class PatternCollectionTest
    {

        [Test]
        public void TestSerializePatternCollection()
        {
            PatternCollection collection = new PatternCollection();

            Pattern pattern = Pattern.Instance("itunes", "%MACRO1%\\%MACRO2%");
            collection.Patterns.Add(pattern);

            XmlSerializer serializer = new XmlSerializer(collection.GetType());

            FileStream stream = null;
            try
            {
                stream = new FileStream("patterncollection.xml", FileMode.Create);                
                serializer.Serialize(stream, collection);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            try
            {
                stream = new FileStream("patterncollection.xml", FileMode.Open);
                PatternCollection deserializedCollection = (PatternCollection)
                    serializer.Deserialize(stream);

                Assert.NotNull(deserializedCollection);
                Assert.AreEqual(1, deserializedCollection.Patterns.Count);
                Assert.AreEqual("itunes", deserializedCollection.Patterns[0].Id);
                Assert.AreEqual("%MACRO1%\\%MACRO2%", deserializedCollection.Patterns[0].Format);

            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }


            File.Delete("patterncollection.xml");
        }

    }
}
