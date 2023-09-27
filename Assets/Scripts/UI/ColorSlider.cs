using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ColorSlider : MonoBehaviour
    {
        [SerializeField] private int _colorIndex;

        private TextManager _textManager;
        private Slider _slider;

        private void Start()
        {
            _slider = GetComponent<Slider>();
            _textManager = TextManager.Instance;
            _textManager.OnColorChange += SetSliderValue;

            SetSliderValue();
        }

        public void ChangeColor()
        {
            Color currentColor = _textManager.CurrentColor;
            currentColor[_colorIndex] = _slider.value;
            _textManager.SetAllTextColor(currentColor);
        }

        private void SetSliderValue()
        {
            _slider.value = _textManager.CurrentColor[_colorIndex];
        }
    }
}
