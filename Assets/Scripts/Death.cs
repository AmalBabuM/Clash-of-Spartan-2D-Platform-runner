using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    Animator anim;
    Rigidbody2D rb;
    bool isDead = false;
    HealthBar health;
    private void Start()
    {   
        health=FindObjectOfType<HealthBar>();
        rb= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }
    private void Update()
    {
        if(rb.transform.position.y < -3f && isDead==false)
        {
            health.SetValue(0);
            /*anim.SetTrigger("dead");*/
            isDead=true;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Trap")
        {
            health.SetValue(0);
            /*anim.SetTrigger("dead");*/
            rb.bodyType = RigidbodyType2D.Static;
            
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
