using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace Pages
{
    public class PageTransitions : Singleton<PageTransitions>
    {
        [SerializeField] private List<Page> _pagesList;
        private Dictionary<PageType, Page> _pages;

        private void Start()
        {
            PopulatePages();
        }

        public void TransitionFromTo(PageType pageFrom, PageType pageTo)
        {
            if (PageExists(pageFrom) && PageExists(pageTo))
            {
                _pages[pageFrom].Animate(false);
                _pages[pageTo].Animate(true);
            }
        }

        private void PopulatePages()
        {
            _pages = new Dictionary<PageType, Page>();

            foreach (Page page in _pagesList)
            {
                if (!PageExists(page.Type))
                    _pages.Add(page.Type, page);
                else
                    Debug.LogError("Trying to create duplicate of page type " + page.Type);
            }
        }

        private bool PageExists(PageType type)
        {
            return _pages.ContainsKey(type);
        }
    }
}
