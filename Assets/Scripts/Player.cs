using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoreGame.MemorySystem;

public class Player : Character2D
{

    new void Update()
    {
        base.Update();
        if (Btn_Submit)
        {
            GameData gd = MemorySystem.LoadData("MyCoolGame.data");
            transform.position = gd.PosVector;
        }
    }

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MemorySystem.Save(new GameData(transform.position.x, transform.position.y), "MyCoolGame.data");
    }
}
