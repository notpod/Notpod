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

            Pattern pattern = Pattern.Instance("itunes", "iTunes", "%MACRO1%\\%MACRO2%");
            pattern.Compilationformat = "Compilation\\%MACRO3%";
            pattern.Description = "Pattern descripiton";
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
                Assert.AreEqual(pattern.Id, deserializedCollection.Patterns[0].Id);
                Assert.AreEqual(pattern.Name, deserializedCollection.Patterns[0].Name);
                Assert.AreEqual(pattern.Format, deserializedCollection.Patterns[0].Format);
                Assert.AreEqual(pattern.Compilationformat, deserializedCollection.Patterns[0].Compilationformat);
                Assert.AreEqual(pattern.Description, deserializedCollection.Patterns[0].Description);

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
