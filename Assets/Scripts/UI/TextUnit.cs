using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class TextUnit : MonoBehaviour
    {
        private Text _text;
        private int _defaultFontSize;

        private void Awake()
        {
            _text = GetComponent<Text>();
            _defaultFontSize = _text.fontSize;
        }

        public void SetColor(Color color)
        {
            _text.color = color;
        }

        public void SetFontSize(float sizeMultiplier)
        {
            _text.fontSize = (int)(_defaultFontSize * sizeMultiplier);
        }
    }
}
