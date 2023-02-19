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
    enum MovementState { idle, running, jump, fall, attack}
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
        rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
    }
    bool IsGrounded() //This checks if the box collider is touching the ground by using the physics2D.BoxCast function
                      //coll.bounds gets the center of our box collider, coll.bounds.size gets the size of the box collider
                      //0f is for the rotation ie no rotation
                      //Vector2.down moves the box slightly down 0.1f
                      
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);
        //this creates a box similiar to that of the box collider and checks if touches the groundLayer
    }

    void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.W)||(Input.GetKeyDown(KeyCode.UpArrow))) && IsGrounded())
        {
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            state= MovementState.attack;
        }
        anim.SetInteger("state",(int)state);
    }
}
