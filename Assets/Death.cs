using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    bool isDead = false;
    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }
    private void Update()
    {
        if(rb.transform.position.y < -3f && isDead==false)
        {
            anim.SetTrigger("dead");
            isDead=true;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Trap")
        {
            anim.SetTrigger("dead");
            rb.bodyType = RigidbodyType2D.Static;
            
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
