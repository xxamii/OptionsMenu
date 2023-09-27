using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pages
{
    public class PageTransitionOnClick : MonoBehaviour
    {
        [SerializeField] private PageType _pageFrom;
        [SerializeField] private PageType _pageTo;
        private PageTransitions _pageTransitions;

        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _pageTransitions = PageTransitions.Instance;

            _button.onClick.AddListener(() => _pageTransitions.TransitionFromTo(_pageFrom, _pageTo));
        }
    }
}
