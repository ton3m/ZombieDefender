using UnityEngine;

namespace Code
{
    public class Bullet : MonoBehaviour
    {
        public Vector3 _direction { get; private set; }
        private float _speed;
        private float _damage;

        public void Initialize(Vector3 direction, float speed, float damage)
        {
            _direction = direction;
            _speed = speed;
            _damage = damage;
        }

        private void Update()
        {
            transform.position += _direction.normalized * (_speed * Time.deltaTime);
        }
    }
}