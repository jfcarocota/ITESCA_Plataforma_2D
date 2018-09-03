using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character2D
{
    protected override void Move2D()
    {
        base.Move2D();
        anim.SetFloat("MoveX", Mathf.Abs(ComponentX));
    }

    protected override void Jump2D()
    {
        base.Jump2D();
        if (jump)
        {
            anim.SetTrigger("Jump");
        }
        anim.SetBool("Ground", ground);
    }
}
