using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using NUnit.Framework;

namespace iTunesAgent.Domain
{

    [TestFixture]
    public class DeviceCollectionTest
    {

        [Test]
        public void TestSerializeDeviceCollection()
        {
            DeviceCollection collection = new DeviceCollection();

            Device msd = new Device();
            msd.Name = "Test1";
            msd.Identifier = "file:mydevice.id";
            msd.AddPlaylistAssociation(1234, "pattern", "Playlist1");
            msd.AddPlaylistAssociation(4567, "pattern", "Playlist2");

            collection.Devices.Add(msd);

            Device wpd = new Device();
            wpd.Name = "Test2";
            wpd.Identifier = "usb:1234567890";
            wpd.AddPlaylistAssociation(4321, "pattern2", "Playlist3");
            wpd.AddPlaylistAssociation(7654, "pattern2", "Playlist4");

            collection.Devices.Add(wpd);

            XmlSerializer serializer = new XmlSerializer(collection.GetType());
            FileStream fs = null;
            try
            {
                fs = new FileStream("test.xml", FileMode.Create);
                serializer.Serialize(fs, collection);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

            FileStream read = null;
            try
            {
                read = new FileStream("test.xml", FileMode.Open);
                DeviceCollection deserializedCollection =
                    (DeviceCollection)serializer.Deserialize(read);

                Assert.NotNull(deserializedCollection);
                Assert.AreEqual(2, deserializedCollection.Devices.Count);

                Device d1 = deserializedCollection.Devices[0];
                Device d2 = deserializedCollection.Devices[1];

                Assert.AreEqual("Test1", d1.Name);
                Assert.AreEqual("file:mydevice.id", d1.Identifier);
                Assert.AreEqual(2, d1.Playlists.Count);
                Assert.AreEqual(1234, d1.Playlists[0].PlaylistID);
                Assert.AreEqual("pattern", d1.Playlists[0].PatternID);
                Assert.AreEqual("Playlist1", d1.Playlists[0].DeviceFolder);
                Assert.AreEqual(4567, d1.Playlists[1].PlaylistID);
                Assert.AreEqual("pattern", d1.Playlists[1].PatternID);
                Assert.AreEqual("Playlist2", d1.Playlists[1].DeviceFolder);

                Assert.AreEqual("Test2", d2.Name);
                Assert.AreEqual("usb:1234567890", d2.Identifier);
                Assert.AreEqual(2, d2.Playlists.Count);
                Assert.AreEqual(4321, d2.Playlists[0].PlaylistID);
                Assert.AreEqual("pattern2", d2.Playlists[0].PatternID);
                Assert.AreEqual("Playlist3", d2.Playlists[0].DeviceFolder);
                Assert.AreEqual(7654, d2.Playlists[1].PlaylistID);
                Assert.AreEqual("pattern2", d2.Playlists[1].PatternID);
                Assert.AreEqual("Playlist4", d2.Playlists[1].DeviceFolder);


            }
            finally
            {
                if (read != null)
                {
                    read.Close();
                }
            }

            File.Delete("test.xml");
        }

        [Test]
        public void GetDeviceByIdentifier_shouldReturnNullWhenNoDeviceWithProvidedIdentifier()
        {

            DeviceCollection collection = new DeviceCollection();

            Assert.IsNull(collection.GetDeviceWithIdentifier("usb:12345"));

            Device testDevice = new Device();
            testDevice.Identifier = "usb:54321";
            testDevice.Name = "Test device";
            collection.Devices.Add(testDevice);

            Assert.IsNull(collection.GetDeviceWithIdentifier("usb:12345"));
        }

        [Test]
        public void GetDeviceByIdentifier_shouldReturnDeviceWithMatchingIdentifier()
        {

            DeviceCollection collection = new DeviceCollection();
            Device testDevice = new Device();
            testDevice.Identifier = "usb:54321";
            testDevice.Name = "Test device";
            collection.Devices.Add(testDevice);


            Assert.AreEqual(testDevice, collection.GetDeviceWithIdentifier("usb:54321"));


            Assert.IsNull(collection.GetDeviceWithIdentifier("usb:12345"));
        }
    }
}
