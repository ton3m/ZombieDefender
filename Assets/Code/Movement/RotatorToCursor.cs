using UnityEngine;

namespace Code
{
    public class RotatorToCursor : Rotator
    {
        private Input _input;
        private Camera _camera;

        public void Initialize(Input input, Camera cam)
        {
            _camera = cam;
            _input = input;
        }

        private void Update()
        {
            Vector2 mousePos = _input.GetMouseWorldPosition(_camera);
            LookAt(mousePos);
        }
    }
}