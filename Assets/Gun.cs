using UnityEngine;

namespace Code
{
    public class Gun
    {
        [SerializeField] GameObject _bullet;
        [SerializeField] Transform _shootPoint;

        private Fabric _fabric;
    
        public void Initialize(Fabric fabric)
        {
            _fabric = fabric;
        }
        
        public void Shoot()
        {
            var bulletObj = _fabric.Create(_bullet, Transform.position);
            var bullet = bulletObj.Get                         
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