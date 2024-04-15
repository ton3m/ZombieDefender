using System;
using UnityEngine;

namespace Code
{
    public class Mover : MonoBehaviour, IUpdateable, IInitializable<Input>
    {
        public event Action Updating;

        [SerializeField] private float _speed;

        private Vector2 _direction;
        private Input _input;


        public void Initialize(Input input) => 
            _input = input;

        void Update()
        {
            Updating?.Invoke();

            _direction = new Vector2(_input.X, _input.Y).normalized;

            transform.position += (Vector3)_direction * _speed * Time.deltaTime; 
        }
    }
}