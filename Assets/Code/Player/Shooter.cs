using UnityEngine;

namespace Code
{
    public class Shooter : MonoBehaviour
    {
        [SerializeField] private Gun _gun;

        public void Shoot() => 
            _gun.Shoot();
    }
}