namespace Code
{
    public class Input
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Input(IUpdateable updateable) => 
            updateable.Updating += Update;

        private void Update()
        {
            X = UnityEngine.Input.GetAxis("Horizontal");
            Y = UnityEngine.Input.GetAxis("Vertical");
        }
    }
}
