
using UnityEngine;

namespace CoreGame
{
    namespace MyNamespaces { }

    namespace PlayerController
    {
        public class Controls
        {
            public Controls() { }

            /// <summary>
            /// Sirve como la variable de eje X y Y de la input del teclado o joystick.
            /// </summary>
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

            public static bool Btn_Submit
            {
                get
                {
                    return Input.GetButtonDown("Submit");
                }
            }
        }
    }
}
