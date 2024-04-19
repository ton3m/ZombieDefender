using System;
using UnityEngine;

namespace Code
{
    public class Zombie : MonoBehaviour
    {
        [SerializeField] private Follower _follower;
       // [SerializeField] private Damager _damager;
        
        [SerializeField] private Transform _target;
        [SerializeField] private float _attackDistance;
        
        private State _state;

        private enum State
        {
            Follow,
            Attack
        }

        private void Update()
        {
            Vector3 displacement = _target.position - transform.position;

            _state = IsCloseToAttack(displacement) ? State.Follow : State.Attack;
            
            UpdateStates();
        }

        private void UpdateStates()
        {
            if (_state == State.Follow)
                _follower.enabled = true;
            else
                _follower.enabled = false;

            if (_state == State.Attack) ;
            // Debug.Log("Attack!");
        }

        private bool IsCloseToAttack(Vector3 displacement) =>
            displacement.magnitude > _attackDistance;
    }
}