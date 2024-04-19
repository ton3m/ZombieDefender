using Code.Movement;
using UnityEngine;

namespace Code
{
    public class Follower : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Mover _mover;
    
        private void Update()
        {
            if (_target is null)
                return;

            Vector3 direction = _target.position - transform.position;
            _mover.Move(direction);
        }
    }
}
 