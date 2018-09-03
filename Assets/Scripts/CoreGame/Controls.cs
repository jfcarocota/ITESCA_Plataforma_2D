
using UnityEngine;

namespace CoreGame
{
    namespace PlayerController
    {
        public class Controls
        {
            public Controls() { }

            public static Vector2 Axis
            {
                get
                {
                    return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                }
            }

            public static bool Btn_Jump
            {
                get
                {
                    return Input.GetButtonDown("Jump");
                }
            }

            public static bool btn_Climb
            {
                get
                {
                    return Input.GetButton("Climb");
                }
            }

            public static bool Btn_Crouch
            {
                get
                {
                    return Input.GetButton("Crouch");
                }
            }
        }
    }
}
