using UnityEngine;

namespace Code
{
    public class Bullet : MonoBehaviour
    {
        public Vector3 _direction { get; private set; }
        private float _velocity;
        private float _damage;

        public void Initialize(Vector3 direction, float velocity, float damage)
        {
            _direction = direction;
            _velocity = velocity;
            _damage = damage;
        }

        private void Update()
        {
            transform.position += _direction.normalized * (_velocity * Time.deltaTime);
        }
    }
}