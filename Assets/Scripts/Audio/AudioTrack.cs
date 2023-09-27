using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
    public class AudioTrack : MonoBehaviour
    {
        [SerializeField] private AudioType _type;
        public AudioType Type => _type;

        private AudioSource _source;

        public void PlaySFX(AudioObject clip)
        {
            if (clip.Type == _type)
                _source.PlayOneShot(clip.Clip);
        }

        public void PlayMusic(AudioObject clip)
        {
            if (clip.Type == _type)
            {
                _source.Stop();
                _source.clip = clip.Clip;
                _source.Play();
            }
        }
    }
}
