using UnityEngine;

namespace Code
{
    public class Damager: MonoBehaviour, IDamager
    {
        [SerializeField] private float _damage;
        [SerializeField] private CollidingDetector _detector;

        private void OnEnable() => 
            _detector.Detected += OnDetected;

        private void OnDisable() => 
            _detector.Detected -= OnDetected;

        public void Damage(Health aim, float value) => 
            aim.Damage(value);

        private void OnDetected(GameObject obj)
        {
            if (obj.TryGetComponent(out Health aim)) 
                Damage(aim, _damage);
        }
    }
}