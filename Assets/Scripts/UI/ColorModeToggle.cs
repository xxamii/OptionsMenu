using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ColorModeToggle : MonoBehaviour
    {
        [SerializeField] private Color _lightColor;
        [SerializeField] private Color _darkColor;
        [SerializeField] private List<Graphic> _darkObjects;
        [SerializeField] private List<Graphic> _lightObjects;

        private Toggle _toggle;
        private TextManager _textManager;

        private void Start()
        {
            _toggle = GetComponent<Toggle>();
            _textManager = TextManager.Instance;

            ToggleColorMode();
        }

        public void ToggleColorMode()
        {
            if (_toggle.isOn)
            {
                SetColors(_darkColor, _lightColor);
            }
            else
            {
                SetColors(_lightColor, _darkColor);
            }
        }

        private void SetColors(Color lightColor, Color darkColor)
        {
            _textManager.SetAllTextColor(darkColor);

            foreach (Graphic element in _lightObjects)
            {
                element.color = lightColor;
            }

            foreach (Graphic element in _darkObjects)
            {
                element.color = darkColor;
            }
        }
    }
}
