using Code.Infrastructure;
using UnityEngine;

namespace Code
{
    public class Input
    {
        public Vector2 Axis { get; private set; }
        public Vector2 MousePosition { get; private set; }

        public Input(IUpdateable updateable) =>
            updateable.Updating += Update;

        private void Update()
        {
            Axis = new Vector2
            {
                x = UnityEngine.Input.GetAxis("Horizontal"),
                y = UnityEngine.Input.GetAxis("Vertical")
            };

            MousePosition = UnityEngine.Input.mousePosition;
        }
        
        public Vector2 GetMouseWorldPosition(Camera cam) => 
            cam.ScreenToWorldPoint(MousePosition);

        public bool KeyPressed(KeyCode key)
        {
            return UnityEngine.Input.GetKeyDown(key);
        }

        public bool KeyDown(KeyCode key)
        {
            return UnityEngine.Input.GetKey(key);
        }
    }
}