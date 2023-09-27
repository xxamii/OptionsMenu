using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pages
{
    public class Page : MonoBehaviour
    {
        [SerializeField] private float _animationDuration;
        [SerializeField] private Vector2 _onPosition;
        [SerializeField] private Vector2 _offPosition;
        [SerializeField] private PageType _type;
        public PageType Type => _type;

        private RectTransform _rectTransform;

        private void Start()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        public void Animate(bool on)
        {
            if (on)
                gameObject.SetActive(true);

            StopCoroutine("AnimationRoutine");
            StartCoroutine("AnimationRoutine", on);
        }

        private IEnumerator AnimationRoutine(bool on)
        {
            Vector2 from = _rectTransform.anchoredPosition;
            Vector2 to = on ? _onPosition : _offPosition;
            float timer = 0f;

            while ((to - _rectTransform.anchoredPosition).magnitude >= 3f)
            {
                _rectTransform.anchoredPosition = Vector2.Lerp(from, to, timer / _animationDuration);
                timer += Time.deltaTime;

                yield return null;
            }

            _rectTransform.anchoredPosition = to;

            if (!on)
                gameObject.SetActive(false);
        }
    }
}
