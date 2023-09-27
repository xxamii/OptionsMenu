using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance == null)
                _instance = (T)this;
            else
                Destroy(this);
        }

        private void OnDestroy()
        {
            _instance = null;
        }
    }
}
