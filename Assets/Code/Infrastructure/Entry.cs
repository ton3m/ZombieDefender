using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Infrastructure
{
    public class Entry : MonoBehaviour, IUpdateable
    {
        public event Action Updating;
        
        [SerializeField] private Player _player;
        [SerializeField] private Gun _gun;

        private Input _input;
        private Fabric _fabric;

        private void Awake()
        {
            _fabric = new Fabric();
            _input = new Input(this);
            
            _player.Initialize(_input);
            _gun.Initialize(_fabric);
        }

        private void Update() => Updating?.Invoke();
    }
}
