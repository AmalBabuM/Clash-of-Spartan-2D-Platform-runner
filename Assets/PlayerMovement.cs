using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 15f;
    public float speed = 500f;
    float move;
    Animator anim;
    SpriteRenderer icon;
    BoxCollider2D coll;
    public LayerMask groundLayer;
    enum MovementState { idle, running, jump, fall}
    void Start()
    {
           rb= GetComponent<Rigidbody2D>();
           anim= rb.GetComponent<Animator>();
           icon= rb.GetComponent<SpriteRenderer>();  //To flip while going left
           coll= rb.GetComponent<BoxCollider2D>();
    } 
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        Jump();
        action();
        /*Movement();*/
    }
    private void FixedUpdate()
    {
        
        
        /*Debug.Log(move);*/
        rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
    }
    bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);
    }

    void Jump()
    {
        /*Debug.Log("Hello");*/

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            /*Debug.Log("HI");*/
            /*rb.velocity = Vector2.up * jumpForce;*/
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }
   /* void Movement()
    {

        move = Input.GetAxisRaw("Horizontal");
        action();
        *//*Debug.Log(move);*//*
        rb.velocity=new Vector2(move*speed*Time.deltaTime,rb.velocity.y);
    }*/

    void action()
    {
        MovementState state;

        if (move >0)
        {
            /*anim.SetBool("running", true);*/
            state= MovementState.running;
            icon.flipX= false;
        }
        else if(move <0)
        {
            state = MovementState.running;
            /*anim.SetBool("running", true);*/
            icon.flipX = true;
        }
        else
        {
            state = MovementState.idle;
/*            anim.SetBool("running", false);
*/
        }
        if(rb.velocity.y> 0.1)
        {
            state = MovementState.jump;

        }
        else if (rb.velocity.y < -0.1)
        {
            state = MovementState.fall;

        }
        anim.SetInteger("state",(int)state);
    }
}
