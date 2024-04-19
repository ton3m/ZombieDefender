using System;
using UnityEngine;

namespace Code
{
    public abstract class Rotator : MonoBehaviour
    {
        protected void LookAt(Vector2 target)
        {
            Vector2 direction = (target - (Vector2)transform.position).normalized;
            float angle = Vector2.SignedAngle(Vector2.right, direction);

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}