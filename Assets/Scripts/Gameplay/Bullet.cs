using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Utility;

namespace Assets.Scripts.Gameplay
{
    public class Bullet : MonoBehaviour
    {
        private float _duration = 1;

        public event Action<GameObject> OnEnd;

        private void Update()
        {
            //_duration -= Time.deltaTime;
            //if(_duration <= 0)
            //{
            //    OnEnd(gameObject);
            //}
        }
    }
}
