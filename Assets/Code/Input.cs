using Code.Infrastructure;
using UnityEngine;

namespace Code
{
    public class Input
    {
        public Vector2 Axis { get; private set; }

        public Input(IUpdateable updateable) =>
            updateable.Updating += Update;

        private void Update()
        {
            Axis = new Vector2
            {
                x = UnityEngine.Input.GetAxis("Horizontal"),
                y = UnityEngine.Input.GetAxis("Vertical")
            };
        }

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