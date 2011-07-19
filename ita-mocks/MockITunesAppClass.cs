using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTunesAgent.Services
{
    
    public class MockITunesAppClass : iTunesApp
    {

        private IITSource librarySource;

        public MockITunesAppClass()
        {
        }

        
        public String Version
        {
            get
            {
                return "1.0";
            }        
        }

        #region IiTunes Members

        public bool AppCommandMessageProcessingEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Authorize(int numElems, ref object data, ref string names)
        {
            throw new NotImplementedException();
        }

        public void BackTrack()
        {
            throw new NotImplementedException();
        }

        public IITBrowserWindow BrowserWindow
        {
            get { throw new NotImplementedException(); }
        }

        public bool CheckVersion(int majorVersion, int minorVersion)
        {
            throw new NotImplementedException();
        }

        public IITOperationStatus ConvertFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public iTunesConvertOperationStatus ConvertFile2(string filePath)
        {
            throw new NotImplementedException();
        }

        public IITOperationStatus ConvertFiles(ref object filePaths)
        {
            throw new NotImplementedException();
        }

        public iTunesConvertOperationStatus ConvertFiles2(ref object filePaths)
        {
            throw new NotImplementedException();
        }

        public iTunesConvertOperationStatus ConvertOperationStatus
        {
            get { throw new NotImplementedException(); }
        }

        public IITOperationStatus ConvertTrack(ref object iTrackToConvert)
        {
            throw new NotImplementedException();
        }

        public iTunesConvertOperationStatus ConvertTrack2(ref object iTrackToConvert)
        {
            throw new NotImplementedException();
        }

        public IITOperationStatus ConvertTracks(ref object iTracksToConvert)
        {
            throw new NotImplementedException();
        }

        public iTunesConvertOperationStatus ConvertTracks2(ref object iTracksToConvert)
        {
            throw new NotImplementedException();
        }

        public IITEQPreset CreateEQPreset(string eqPresetName)
        {
            throw new NotImplementedException();
        }

        public IITPlaylist CreateFolder(string folderName)
        {
            throw new NotImplementedException();
        }

        public IITPlaylist CreateFolderInSource(string folderName, ref object iSource)
        {
            throw new NotImplementedException();
        }

        public IITPlaylist CreatePlaylist(string playlistName)
        {
            throw new NotImplementedException();
        }

        public IITPlaylist CreatePlaylistInSource(string playlistName, ref object iSource)
        {
            throw new NotImplementedException();
        }

        public IITEQPreset CurrentEQPreset
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITEncoder CurrentEncoder
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITPlaylist CurrentPlaylist
        {
            get { throw new NotImplementedException(); }
        }

        public string CurrentStreamTitle
        {
            get { throw new NotImplementedException(); }
        }

        public string CurrentStreamURL
        {
            get { throw new NotImplementedException(); }
        }

        public IITTrack CurrentTrack
        {
            get { throw new NotImplementedException(); }
        }

        public IITVisual CurrentVisual
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool EQEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITEQPresetCollection EQPresets
        {
            get { throw new NotImplementedException(); }
        }

        public IITWindow EQWindow
        {
            get { throw new NotImplementedException(); }
        }

        public IITEncoderCollection Encoders
        {
            get { throw new NotImplementedException(); }
        }

        public void FastForward()
        {
            throw new NotImplementedException();
        }

        public bool ForceToForegroundOnDialog
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool FullScreenVisuals
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITObject GetITObjectByID(int sourceID, int playlistID, int trackID, int databaseID)
        {
            throw new NotImplementedException();
        }

        public void GetITObjectPersistentIDs(ref object iObject, out int highID, out int lowID)
        {
            throw new NotImplementedException();
        }

        public void GetPlayerButtonsState(out bool previousEnabled, out ITPlayButtonState playPauseStopState, out bool nextEnabled)
        {
            throw new NotImplementedException();
        }

        public void GotoMusicStoreHomePage()
        {
            throw new NotImplementedException();
        }

        public IITLibraryPlaylist LibraryPlaylist
        {
            get { throw new NotImplementedException(); }
        }

        public IITSource LibrarySource
        {
            get { return this.librarySource; }
            set { this.librarySource = value; }
        }

        public string LibraryXMLPath
        {
            get { throw new NotImplementedException(); }
        }

        public bool Mute
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void NextTrack()
        {
            throw new NotImplementedException();
        }

        public void OpenURL(string URL)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void PlayFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void PlayPause()
        {
            throw new NotImplementedException();
        }

        public void PlayerButtonClicked(ITPlayerButton playerButton, int playerButtonModifierKeys)
        {
            throw new NotImplementedException();
        }

        public int PlayerPosition
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ITPlayerState PlayerState
        {
            get { throw new NotImplementedException(); }
        }

        public void PreviousTrack()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {
            throw new NotImplementedException();
        }

        public IITTrackCollection SelectedTracks
        {
            get { throw new NotImplementedException(); }
        }

        public void SetOptions(int options)
        {
            throw new NotImplementedException();
        }

        public int SoundVolume
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool SoundVolumeControlEnabled
        {
            get { throw new NotImplementedException(); }
        }

        public IITSourceCollection Sources
        {
            get { throw new NotImplementedException(); }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void SubscribeToPodcast(string URL)
        {
            throw new NotImplementedException();
        }

        public void UpdateIPod()
        {
            throw new NotImplementedException();
        }

        public void UpdatePodcastFeeds()
        {
            throw new NotImplementedException();
        }

        public ITVisualSize VisualSize
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITVisualCollection Visuals
        {
            get { throw new NotImplementedException(); }
        }

        public bool VisualsEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IITWindowCollection Windows
        {
            get { throw new NotImplementedException(); }
        }

        public bool get_CanSetShuffle(ref object iPlaylist)
        {
            throw new NotImplementedException();
        }

        public bool get_CanSetSongRepeat(ref object iPlaylist)
        {
            throw new NotImplementedException();
        }

        public int get_ITObjectPersistentIDHigh(ref object iObject)
        {
            throw new NotImplementedException();
        }

        public int get_ITObjectPersistentIDLow(ref object iObject)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region _IiTunesEvents_Event Members

        public event _IiTunesEvents_OnAboutToPromptUserToQuitEventEventHandler OnAboutToPromptUserToQuitEvent;

        public event _IiTunesEvents_OnCOMCallsDisabledEventEventHandler OnCOMCallsDisabledEvent;

        public event _IiTunesEvents_OnCOMCallsEnabledEventEventHandler OnCOMCallsEnabledEvent;

        public event _IiTunesEvents_OnDatabaseChangedEventEventHandler OnDatabaseChangedEvent;

        public event _IiTunesEvents_OnPlayerPlayEventEventHandler OnPlayerPlayEvent;

        public event _IiTunesEvents_OnPlayerPlayingTrackChangedEventEventHandler OnPlayerPlayingTrackChangedEvent;

        public event _IiTunesEvents_OnPlayerStopEventEventHandler OnPlayerStopEvent;

        public event _IiTunesEvents_OnQuittingEventEventHandler OnQuittingEvent;

        public event _IiTunesEvents_OnSoundVolumeChangedEventEventHandler OnSoundVolumeChangedEvent;

        public event _IiTunesEvents_OnUserInterfaceEnabledEventEventHandler OnUserInterfaceEnabledEvent;

        #endregion
    }
}
