using UnityEngine;

namespace Code
{
    public class RotatorToTarget : Rotator
    {
        [SerializeField] private Transform _target;
        
        private void Update()
        {
            LookAt(_target.position);    
        }
    }
}