using System;
using System.Text;
using UnityEngine;
using Object = System.Object;

namespace Script.SingleTone
{
    public class SingleToneUnity<T> : MonoBehaviour  where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (!ReferenceEquals(_instance,null)) return _instance;
                _instance = FindObjectOfType<T>();
                if (!ReferenceEquals(_instance,null)) return _instance;
                var namOfObject = new StringBuilder();
                namOfObject.Append(typeof(T));
                namOfObject.Append("_SingleTone");
                var newObject = new GameObject(namOfObject.ToString());
                _instance = newObject.AddComponent<T>();
                return _instance;
            }
        }

        public virtual void Awake()
        {
            if (!ReferenceEquals(_instance,null)) Destroy(gameObject);
            else
            {
                _instance = this as T; 
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}
