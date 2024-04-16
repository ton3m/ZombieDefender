using System;
using Code.Infrastructure;
using UnityEngine;

namespace Code
{
    [RequireComponent(typeof(Mover))]
    [RequireComponent(typeof(Shooter))]
    
    public class Player : MonoBehaviour
    {
        [SerializeField] private Mover _mover; 
        [SerializeField] private Shooter _shooter;
        
        private Input _input;
        
        public void Initialize(Input input)
        {
            _input = input;
        }
        
        private void Update()
        {
            if (_input.KeyPressed(KeyCode.Mouse0)) 
                _shooter.Shoot();
            
            _mover.Move(_input.Axis);
        }
    }
}