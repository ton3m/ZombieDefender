using UnityEngine;

namespace Code
{
    public class Gun
    {
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _shootPoint;

        private Fabric _fabric;
    
        public void Initialize(Fabric fabric)
        {
            _fabric = fabric;
        }
        
        public void Shoot()
        {
            var bulletObj = _fabric.Create(_bullet, Transform.position);
            var bullet = bulletObj.GetComponent<Bullet>();                         
        }
    }

    public class Bullet: MonoBehaviour
    {
        [SerializeField] private float _velocity;
        [SerializeField] private Vector3 _velocity;
        [SerializeField] private float _damage;

        public void Initialize(float velocity, float damage)
        {
            _velocity = velocity;
            _damage = damage;
        }

        private void Update()
        {
            transform.position += 
        }
    }

    public class Fabric
    {
        public GameObject Create(GameObject obj, Transform transform)
        {
            return Object.Instantiate(obj, transform);
        }
    }    
}