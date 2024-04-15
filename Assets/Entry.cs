using UnityEngine;

namespace Code
{
    public class Entry : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        private Input _input;

        private void Awake()
        {
            _input = new Input(_mover);
            _mover.Initialize(_input);
        }
    }
}
