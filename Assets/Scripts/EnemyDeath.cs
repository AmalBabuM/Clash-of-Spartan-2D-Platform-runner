using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim= GetComponentInParent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space))
        {
            /* Debug.Log("GHHHH");*/
            anim.SetTrigger("die");
        }
    }

}
