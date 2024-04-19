using System;
using UnityEngine;

namespace Code
{
    public class CollidingDetector: MonoBehaviour
    {
        public event Action<GameObject> Detected;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            Detected?.Invoke(other.gameObject);
        }
    }
}