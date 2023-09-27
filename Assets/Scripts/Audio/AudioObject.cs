using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
    [System.Serializable]
    public class AudioObject
    {
        [SerializeField] private AudioClip _clip;
        public AudioClip Clip => _clip;

        [SerializeField] private AudioType _type;
        public AudioType Type => _type;
    }
}
