using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using iTunesAgent.Mocks;
using iTunesAgent.Services;
using iTunesAgent.Domain;
using System.Windows.Forms;

namespace iTunesAgent.UI
{
    [TestFixture]
    public class PlaylistsPanelTest
    {

        [Test]
        public void PlaylistsPanelLoad_ShouldCreateOneAssociationControlPerAvailablePlaylist()
        {

            List<Playlist> playlists = BuildListOfDummyPlaylists(2);
            ModelRepository model = new ModelRepository();
            model.Add("devices", new DeviceCollection());

            MockMediaSoftwareService mockMediaSoftwareService = new MockMediaSoftwareService();
            mockMediaSoftwareService.SetPlaylists(playlists);
            
            PlaylistsPanel playlistsPanel = new PlaylistsPanel();
            playlistsPanel.MediaSoftwareService = mockMediaSoftwareService;
            playlistsPanel.Model = model;

            playlistsPanel.PlaylistsPanel_Load(this, null);

            int numberOfAssociationControlsCreated = 0;            
            foreach (Control panelControl in playlistsPanel.FlowPlaylistAssociations.Controls)
            {
                Console.WriteLine(String.Format("Control type: {0}", panelControl.GetType().ToString()));
                if (panelControl is PlaylistAssociationControl)
                {
                    numberOfAssociationControlsCreated++;
                }
            }

            Assert.AreEqual(playlists.Count(), numberOfAssociationControlsCreated);            
            
        }

        private List<Playlist> BuildListOfDummyPlaylists(int numberOfPlaylists)
        {
            List<Playlist> playlists = new List<Playlist>();

            for (int p = 0; p < numberOfPlaylists; p++)
            {

                Playlist playlist = new Playlist();
                playlist.ID = p;
                playlist.Name = String.Format("Playlist {0}", p);
                playlist.PlaylistType = "TestPlaylist";
                playlists.Add(playlist);
            }

            return playlists;

        }

        [Test]
        public void AddAssociationButtonClick_ShouldSpawnNewAssociationDialogForCorrectPlaylist()
        {

            MockRepository mockrepo = new MockRepository();

            PlaylistsPanel playlistsPanel = new PlaylistsPanel();

            INewPlaylistAssociationFormFactory newPlaylistAssociationFormFactory = mockrepo.StrictMock<INewPlaylistAssociationFormFactory>();
            playlistsPanel.NewPlaylistAssociationFormFactory = newPlaylistAssociationFormFactory;

            NewPlaylistAssociationForm mockedForm = mockrepo.StrictMock<NewPlaylistAssociationForm>();

            Expect.Call(newPlaylistAssociationFormFactory.NewInstance()).Repeat.Once().Return(mockedForm);
            Expect.Call(mockedForm.ShowDialog(null)).IgnoreArguments().Repeat.Once().Return(DialogResult.OK);
            mockrepo.ReplayAll();

            PlaylistAssociationControl associationControl = new PlaylistAssociationControl();

            Button button = new Button();
            button.Parent = associationControl;
            playlistsPanel.AddAssociationButton_Click(button, null);

            mockrepo.VerifyAll();
        }
    }
}
