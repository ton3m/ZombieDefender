using UnityEngine;

namespace Code.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Vector2 _velocity;
        private Vector2 _direction;
        
        public void Move(Vector2 direction)
        {
            _direction = direction.normalized;
            _velocity = _direction * _speed;
            
            ChangePosition();
        }

        private void ChangePosition()
        {
            transform.position += (Vector3)_direction * (_speed * Time.deltaTime);
        }
    }
}