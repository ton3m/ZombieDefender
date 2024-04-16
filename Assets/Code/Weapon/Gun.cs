using Code.Infrastructure;
using UnityEngine;

namespace Code
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private Transform _shootPoint;

        private Fabric _fabric;

        public void Initialize(Fabric fabric) =>
            _fabric = fabric;

        public void Shoot()
        {
            Bullet bullet = _fabric.Create(_bulletPrefab, _shootPoint.position, _shootPoint.rotation);
            
            bullet.Initialize(_shootPoint.up, 10, 1);
        }
    }
}