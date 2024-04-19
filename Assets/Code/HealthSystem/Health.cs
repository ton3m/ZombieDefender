using System;
using UnityEngine;

namespace Code
{
    public class Health : MonoBehaviour
    {
        public event Action<float> Changed;
        
        [SerializeField] private float _maxHP;
        
        public float HP => _HP;
        private float _HP;

        private void Start()
        {
            Set(_maxHP);
        }

        public void Damage(float value) =>
            ChangeBy(-value);
        
        public void Heal(float value) =>
            ChangeBy(value);
        
        public void SetToMax() =>
            Set(_maxHP);
        
        private void ChangeBy(float value) =>
            Set(Math.Clamp(HP + value, 0, _maxHP));

        private void Set(float value)
        {
            if (value < 0 || value > _maxHP)
                throw Consts.Exceptions.OutOfBounds;

            _HP = value;
            Changed?.Invoke(_HP);
            
            Debug.Log($"{name} HP: {HP}");
            
            if (_HP == 0)
                Die();
        }

        private void Die()
        {
            gameObject.SetActive(false);
            Debug.Log($"{name}: i've died 💀");
        }
    }
}