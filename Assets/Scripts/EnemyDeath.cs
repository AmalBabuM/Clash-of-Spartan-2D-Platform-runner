using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    Animator anim;

    AudioManager audioManager;
    void Start()
    {
        audioManager=FindObjectOfType<AudioManager>();
        anim= GetComponentInParent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space))
        {
            audioManager.CoinCollect();
            /* Debug.Log("GHHHH");*/
            anim.SetTrigger("die");
        }
    }

}
