using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace UI
{
    public class TextManager : Singleton<TextManager>
    {
        public event Action OnColorChange;

        [SerializeField] private List<TextUnit> _textUnits;
        [SerializeField] private Color _currentColor;
        [SerializeField] private float _currentSizeMultiplier;

        public Color CurrentColor => _currentColor;
        public float CurrentSizeMultiplier => _currentSizeMultiplier;

        private void Start()
        {
            SetAllTextColor(_currentColor);
            SetAllTextFontSize(_currentSizeMultiplier);
        }

        public void SetAllTextColor(Color color)
        {
            _currentColor = color;

            foreach(TextUnit text in _textUnits)
            {
                text.SetColor(color);
            }

            OnColorChange?.Invoke();
        }

        public void SetAllTextFontSize(float sizeMultiplier)
        {
            _currentSizeMultiplier = sizeMultiplier;

            foreach (TextUnit text in _textUnits)
            {
                text.SetFontSize(sizeMultiplier);
            }
        }
    }
}
