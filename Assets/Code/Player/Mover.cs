using UnityEngine;

namespace Code
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Vector2 _velocity;
        private Vector2 _direction;

        private void Update()
        {
            _velocity = _direction * _speed;
            ChangePosition();
        }

        public void Move(Vector2 direction) => 
            _direction = direction.normalized;

        private void ChangePosition()
        {
            transform.position += (Vector3)_direction * (_speed * Time.deltaTime);
        }
    }
}