using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ToggleImageSwap : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Sprite _onSprite;
        [SerializeField] private Sprite _offSprite;

        private Toggle _toggle;

        private void Start()
        {
            _toggle = GetComponent<Toggle>();

            ToggleImage();
        }

        public void ToggleImage()
        {
            _image.sprite = _toggle.isOn ? _onSprite : _offSprite;
        }
    }
}
