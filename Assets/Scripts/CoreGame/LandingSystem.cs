using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoreGame
{
    namespace PlayerController
    {
        [System.Serializable]
        public class LandingSystem
        {
            [SerializeField]
            bool debugRay;
            [SerializeField]
            Color rayColor;
            [SerializeField, Range(0.1f, 10f)]
            float rayLenght;
            [SerializeField]
            LayerMask groundLayer;
            [SerializeField]
            Vector2 startPosition;

            public RaycastHit2D IsGroinding(Transform transform)
            {
                return Physics2D.Raycast(startPosition + (Vector2)transform.position, -transform.up, rayLenght, groundLayer);
            }

            public void RayDrawCall(Transform transform)
            {
                if (debugRay)
                {
                    Gizmos.color = rayColor;
                    Gizmos.DrawRay((Vector2)transform.position + startPosition, -transform.up * rayLenght);
                }
            }
        }
    }
}
