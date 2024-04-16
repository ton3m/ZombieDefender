using UnityEngine;

namespace Code.Infrastructure
{
    public class Fabric
    {
        public T Create<T>(T obj, Vector3 position, Quaternion rotation) where T : Object
        {
            return Object.Instantiate(obj, position, rotation);
        }
    }
}