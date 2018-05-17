using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Utility
{
    class GameObjectPool
    {
        private readonly GameObject[] _pool;
        private readonly GameObject _object;
        private readonly GameObject _root;

        public GameObjectPool(int capacity, GameObject obj)
        {
            _object = obj;
            _pool = new GameObject[capacity];

            _root = new GameObject("Pool");
            var transform = _root.transform;
            for (int i = 0; i < capacity; i++)
            {
                var go = GameObject.Instantiate(_object, transform);
                _pool[i] = go;
                go.SetActive(false);
            }
        }

        public GameObject AllocateObject()
        {
            foreach (var go in _pool)
            {
                if (go == null) continue;
                if(go.activeSelf == false)
                {
                    go.SetActive(true);
                    return go;
                }
            }
            return null;
        }

        public void DestroyObject(GameObject go)
        {
            if (go == null) return;
            go.SetActive(false);
        }

    }
}
