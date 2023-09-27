using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Audio
{
    public class AudioVolumeSlider : MonoBehaviour
    {
        [SerializeField] private AudioGroup _group;

        private AudioPlayer _audioPlayer;
        private Slider _slider;

        private void Start()
        {
            _audioPlayer = AudioPlayer.Instance;
            _slider = GetComponent<Slider>();

            float volume = _audioPlayer.GetVolume(_group);
            _slider.value = Mathf.Pow(10, (volume / 20));
        }

        public void SetVolume()
        {
            float volume = Mathf.Log10(_slider.value) * 20;
            _audioPlayer.SetVolume(_group, volume);
        }
    }
}
