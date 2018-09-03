using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoreGame.PlayerController;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class Character2D : MonoBehaviour
{
    protected Animator anim;
    protected Rigidbody2D rb2D;
    protected SpriteRenderer sr;
    [SerializeField]
    LandingSystem landingSystem;
    protected RaycastHit2D ground;

    [SerializeField]
    float maxVel;

    protected bool jump;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected float jumpForce;

    private void FixedUpdate()
    {
        Move2D();
        Jump2D();
    }

    protected virtual void Move2D()
    {
        ground = landingSystem.IsGroinding(transform);

        rb2D.AddForce(Vector2.right * ComponentX, ForceMode2D.Impulse);
        Vector2 clampVelocity = Vector2.ClampMagnitude(rb2D.velocity, maxVel);
        rb2D.velocity = new Vector2( ground & ComponentX != 0f & rb2D.velocity.x != 0f ? 
            clampVelocity.x : !ground & ComponentX != 0f ? clampVelocity.x : 0f, rb2D.velocity.y);
        rb2D.velocity -= ComponentX == 0f ? ground.normal : Vector2.zero;
    }

    private void Update()
    {
        FlipX();
    }

    void FlipX()
    {
        sr.flipX = ComponentX > 0f ? false : ComponentX < 0f ? true : sr.flipX;
    }

    protected virtual void Jump2D()
    {
        jump = Btn_Jump == true & ground;
        rb2D.AddForce(Vector2.up * (jump ? jumpForce : 0f), ForceMode2D.Impulse);
    }

    private void OnDrawGizmos()
    {
        landingSystem.RayDrawCall(transform);
    }

    protected float ComponentX
    {
        get
        {
            return Controls.Axis.x;
        }
    }

    protected bool Btn_Jump
    {
        get
        {
            return Controls.Btn_Jump;
        }
    }
}
