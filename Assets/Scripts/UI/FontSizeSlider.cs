using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class FontSizeSlider : MonoBehaviour
    {
        private TextManager _textManager;
        private Slider _slider;

        private void Start()
        {
            _slider = GetComponent<Slider>();
            _textManager = TextManager.Instance;

            _slider.value = _textManager.CurrentSizeMultiplier;
        }

        public void ChangeFontSize()
        {
            _textManager.SetAllTextFontSize(_slider.value);
        }
    }
}
