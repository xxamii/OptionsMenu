using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Utils;

namespace Audio
{
    public class AudioPlayer : Singleton<AudioPlayer>
    {
        [SerializeField] private AudioMixer _mixer;
        [SerializeField] private List<AudioTrack> _tracksList;

        private Dictionary<AudioType, AudioTrack> _tracks;

        private void Start()
        {
            PopulateTracks();
        }

        public void PlaySFX(AudioObject clip)
        {
            if (TrackExists(clip.Type))
                _tracks[clip.Type].PlaySFX(clip);
        }

        public void PlayMusic(AudioObject clip)
        {
            if (TrackExists(clip.Type))
                _tracks[clip.Type].PlayMusic(clip);
        }

        public void SetVolume(AudioGroup type, float volume)
        {
            _mixer.SetFloat(type.ToString(), volume);
        }

        public float GetVolume(AudioGroup type)
        {
            float volume;
            _mixer.GetFloat(type.ToString(), out volume);
            return volume;
        }

        private void PopulateTracks()
        {
            _tracks = new Dictionary<AudioType, AudioTrack>();

            foreach(AudioTrack track in _tracksList)
            {
                if (!TrackExists(track.Type))
                    _tracks.Add(track.Type, track);
            }
        }

        private bool TrackExists(AudioType type)
        {
            return _tracks.ContainsKey(type);
        }
    }
}
